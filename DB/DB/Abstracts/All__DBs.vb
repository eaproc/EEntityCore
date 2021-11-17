''
''Dependencies
''    dllFunctionsNet.dll


REM Make PrepareStringForDatabaseInsertOrUpdate Run on all execute on database and executeQuery
REM With this you dont have to worry about apostrophe



Imports DB.Interfaces

Imports CODERiT.Logger.v._3._5
Imports EPRO.Library

'Imports prjLogger

Namespace Abstracts

    ''' <summary>
    ''' This is an abstract class for SQL Compliant Databases
    ''' </summary>
    ''' <remarks></remarks>
    Public MustInherit Class All__DBs
        Implements IAll__DBs

        REM There is no point of adding friend since this class will always be inherited
        REM The good point of adding protected is descendants can just use the variable without adding the class name
        ''' <summary>
        ''' I make this Public so that user can redirect the logger
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Property Logger As Log1 = New Log1(GetType(All__DBs)).Load(Log1.Modes.FILE, True)


        ''' <summary>
        ''' 0 = Path [C:\], 1= VersionNumber: in Integers [1,2,3,4,5]
        ''' </summary>
        ''' <remarks>REM   "{0}\DBUpgrades\SQL_Upgrade_{1}.sql"</remarks>
        Public Const SQL_UPGRADE_FILES_LOCATION As String = "{0}\DBUpgrades\SQL_Upgrade_{1}.sql"

#Region "Enums"
        ''' <summary>
        ''' Defines Database ConnectionState
        ''' </summary>
        ''' <remarks></remarks>
        Public Enum DBConnectionState
            Disconnected
            Connected
            Unknown
        End Enum
#End Region



#Region "Duplicate Entry Controllers"


        ''' <summary>
        ''' Get the next Auto ID for the table provided using the unique column IDHolderColumn
        ''' </summary>
        ''' <param name="TableName">The name of the table</param>
        ''' <param name="IDHolderColumn">A numeric column, preferrable a long</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function GETNewID(ByVal TableName As String,
                                 Optional ByVal IDHolderColumn As String = "ID") As Long
            Dim GenNumber As Long

            Try
                Dim dts As DataSet = getRS(String.Format(
                                           "Select {0} From {1} Order By {0} Desc", IDHolderColumn, TableName)
                                       )
                If IsDataSetValid(dts) Then
                    GenNumber = Objects.ELong.valueOf(dts.Tables(0).Rows(0)(0).ToString())
                End If

            Catch ex As Exception

            End Try
            GenNumber += 1

            Const MAX_RECORD As Long = 999999999

            If GenNumber > MAX_RECORD Then
                Logger.Log("Sorry you have exceed the Maximum Record Capacity " &
                       "Built for this Software" &
                    vbCrLf & "Therefore, Auto Generate ID can't function!!!")
            Else
                Return GenNumber
            End If
            Return 0
        End Function


#End Region




#Region "Inserting Record"

#End Region



        ''' <summary>
        ''' Return yes ONLY IF dataset contains any row.
        ''' </summary>
        ''' <param name="ds">Dataset to evaluate</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Function IsDataSetValid(ByVal ds As DataSet) As Boolean
            Try
                If Not IsNothing(ds) Then
                    If ds.Tables(0).Rows.Count > 0 Then
                        Return True
                    Else
                        Return False
                    End If
                Else
                    Return False
                End If
            Catch ex As Exception
                Return False
            End Try
        End Function

        ''' <summary>
        ''' Return yes ONLY IF dataset contains any row.
        ''' </summary>
        ''' <param name="ds">Dataset to evaluate</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Function IsDataSetValid(ByVal ds As IEnumerable(Of DataRow)) As Boolean
            Try
                If Not IsNothing(ds) Then
                    If ds.Count > 0 Then
                        Return True
                    Else
                        Return False
                    End If
                Else
                    Return False
                End If
            Catch ex As Exception
                Return False
            End Try
        End Function


        ''' <summary>
        ''' Checks if two tables are absolutely equal
        ''' </summary>
        ''' <param name="Table1"></param>
        ''' <param name="Table2"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function AreTableEqual(ByVal Table1 As DataTable,
                                      ByVal Table2 As DataTable) As Boolean

            If Table1 Is Nothing Or Table2 Is Nothing Then Return False
            If Table1.Rows.Count > Table2.Rows.Count Then Return False
            If Table1.Columns.Count > Table2.Columns.Count Then Return False

            Dim index As Integer = 0
            For Each dRow As DataRow In Table1.Rows

                If Not dRow.ItemArray.SequenceEqual(Table2.Rows(index).ItemArray) Then Return False

                index += 1

            Next

            Return True
        End Function

        ''' <summary>
        ''' Since All SQL has issues with apostrophe(') in a string, we will correct that before inserting or updating
        ''' </summary>
        ''' <param name="strString">The string to Lock on Apostrophe</param>
        ''' <returns></returns>
        ''' <remarks>NOTE: Target Should be the string in the parameters not the syntax like a='{0}' should already be done</remarks>
        Public Shared Function PrepareStringForDatabaseInsertOrUpdate(ByVal strString As String) As String
            Return Replace(strString, "'", "''")
        End Function


#Region "Results Conversions"

        Public Structure ConversionDB(Of T)
            ''' <summary>
            ''' Returns All the Values in the specified Column as One Dimensional Array
            ''' </summary>
            ''' <param name="DataSetRows">Rows Contain the values</param>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public Shared Function ConvertColumnValuesToArray(ByVal DataSetRows As DataRowCollection,
                                                             Optional ByVal ColIndex As Int16 = 0) As T()

                Try
                    Dim Col(DataSetRows.Count - 1) As T, IncreamentCount As Int16 = 0

                    For Each dRow As DataRow In DataSetRows
                        Col(IncreamentCount) = CType(dRow(ColIndex), T)

                        IncreamentCount += CShort(1)
                    Next
                    Return Col
                Catch ex As Exception
                    Return Nothing
                End Try

            End Function
        End Structure

        ''' <summary>
        ''' Convert a whole column to String
        ''' </summary>
        ''' <param name="DataSetRows"></param>
        ''' <param name="ColIndex"></param>
        ''' <param name="Delimiter"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Function ConvertColumnValuesToString(ByVal DataSetRows As DataRowCollection,
                                                             Optional ByVal ColIndex As Int16 = 0,
                                                             Optional ByVal Delimiter As String = ",") As String

            Try

                Dim result As String = vbNullString

                For Each dRow As DataRow In DataSetRows
                    result &= Objects.EStrings.valueOf(dRow(ColIndex))

                    If DataSetRows.IndexOf(dRow) <> DataSetRows.Count - 1 Then result &= Delimiter


                Next

                Return result

            Catch ex As Exception
                Return vbNullString
            End Try

        End Function

#End Region



#Region "Saving Date And Time [General]"


        ''' <summary>
        ''' Gets A Formatted DateTime... NB: It is already packed like '{0}'
        ''' </summary>
        ''' <param name="_DateTime"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public MustOverride Function GetSQLDateTimeFormat(ByVal _DateTime As Types.NullableDateTime) As String



        ''' <summary>
        ''' Returns Date Format [07/22/2013]. NB: It is already packed like '{0}'
        ''' </summary>
        ''' <param name="_Date"></param>
        ''' <returns></returns>
        ''' <remarks>NB: It is already packed</remarks>
        Public MustOverride Function GetSQLDateFormat(ByVal _Date As Types.NullableDateTime) As String

        ''' <summary>
        ''' Returns Time Format [01:45:58 AM]. NB: It is already packed like '{0}'
        ''' </summary>
        ''' <param name="_Time"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public MustOverride Function GetSQLTimeFormat(ByVal _Time As Types.NullableDateTime) As String


#End Region


#Region "Saving Image to Database"



#End Region


#Region "Test DB"


        ''' <summary>
        ''' Test if DB is ok. Must always be silent check or default if no silent.
        ''' </summary>
        ''' <remarks></remarks>
        Public MustOverride Function PingDB() As Boolean Implements IAll__DBs.PingDB
        ' ''We dont need the result
        ' ''basTestMYSQLServerConnection.getRS("Select * From Customers")

        ''End Sub

        ''' <summary>
        ''' Indicate if Connection will be successful using the current parameters
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public MustOverride Function CanConnect() As Boolean Implements IAll__DBs.CanConnect


#End Region


        ''' <summary>
        ''' Executes an SQL File containing SQL Statements
        ''' </summary>
        ''' <param name="SQLFileName">SQL File containing SQL Statements</param>
        ''' <param name="TerminateOnError">If One Statement in the file yields error. The process will break if set to true</param>
        ''' <param name="StatementDelimiter">The delimiter use to identify the end of each sql statement. not case sensitive</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public MustOverride Function ExecuteSQLFile(ByVal SQLFileName As String,
                                       Optional ByVal TerminateOnError As Boolean = False,
                                       Optional ByVal StatementDelimiter As String = "GO;") As Boolean Implements IAll__DBs.ExecuteSQLFile

        ''' <summary>
        ''' execute()
        ''' </summary>
        ''' <param name="SQL"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public MustOverride Overloads Function dbExec(ByVal SQL As String) As Boolean Implements IAll__DBs.dbExec

        ''' <summary>
        ''' Makes sure the apostrophe issue is corrected in the strings. 
        ''' NB: For your original SQL Query you should use \' for apostrophe
        ''' </summary>
        ''' <param name="SQL">Name=\'Fred's Computer\'</param>
        ''' <param name="Address_Apostrophe_Issue">Confirmed this is encoded SQL String</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Overridable Overloads Function dbExec(ByVal SQL As String, ByVal Address_Apostrophe_Issue As Boolean) As Boolean

            If Not Address_Apostrophe_Issue Then Return dbExec(SQL)

            SQL = getHandledSQLApostrophe__Issue(SQL)
            Return dbExec(SQL)

        End Function


        ''' <summary>
        ''' If you used this [  "\'" ] in your SQL statement. it will help you address the ' to double and return back the SQL ready for insert
        ''' </summary>
        ''' <param name="pSQL"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Function getHandledSQLApostrophe__Issue(pSQL As String) As String
            pSQL = Replace(pSQL, "\'", "[*===*]") REM Keep Original Apostrophe Encoded
            pSQL = PrepareStringForDatabaseInsertOrUpdate(pSQL)
            pSQL = Replace(pSQL, "[*===*]", "'")  REM Return Original Apostrophe Encoded
            Return pSQL
        End Function


        ''' <summary>
        ''' executeQuery()
        ''' </summary>
        ''' <param name="SQL"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public MustOverride Overloads Function getRS(ByVal SQL As String) As DataSet Implements IAll__DBs.getRS


        ''' <summary>
        ''' Makes sure the apostrophe issue is corrected in the strings. 
        ''' NB: For your original SQL Query you should use \' for apostrophe
        ''' </summary>
        ''' <param name="SQL">Name=\'Fred's Computer\'</param>
        ''' <param name="Address_Apostrophe_Issue">Confirmed this is encoded SQL String</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Overloads Function getRS(ByVal SQL As String, ByVal Address_Apostrophe_Issue As Boolean) As DataSet

            If Not Address_Apostrophe_Issue Then Return getRS(SQL)

            SQL = Replace(SQL, "\'", "[*===*]") REM Keep Original Apostrophe Encoded
            SQL = PrepareStringForDatabaseInsertOrUpdate(SQL)
            SQL = Replace(SQL, "[*===*]", "'")  REM Return Original Apostrophe Encoded

            Return getRS(SQL)

        End Function


#Region "Filling Datasets and DataTables"


        ''' <summary>
        ''' Fill All Data For Table
        ''' </summary>
        ''' <param name="OneTable"></param>
        ''' <remarks></remarks>
        Public MustOverride Function FillMyTable(ByRef OneTable As DataTable) As Boolean


        ''' <summary>
        ''' Fill All Data For Table
        ''' </summary>
        ''' <param name="OneTable"></param>
        ''' <remarks></remarks>
        Public MustOverride Function FillMyTable(ByVal SQL As String, ByRef OneTable As DataTable) As Boolean



        ''' <summary>
        ''' Fill All Data For Tables in this Hard-Coded dataset
        ''' </summary>
        ''' <param name="MyDataSet"></param>
        ''' <remarks></remarks>
        Public MustOverride Function FillMyTables(ByRef MyDataSet As DataSet) As Boolean


#End Region


#Region "Connection State"



        '' ''' <summary>
        '' ''' This is set by thread keep tracking.. Works only if you use keep tracking method
        '' ''' </summary>
        '' ''' <value></value>
        '' ''' <returns></returns>
        '' ''' <remarks></remarks>
        ''Public MustOverride ReadOnly Property Threaded_ConnectionState As DBConnectionState


        '' ''' <summary>
        '' ''' This is set everytime the getConnection Method is called
        '' ''' </summary>
        '' ''' <value></value>
        '' ''' <returns></returns>
        '' ''' <remarks></remarks>
        ''Public MustOverride ReadOnly Property NoThread_ConnectionState As DBConnectionState


#End Region



    End Class

End Namespace
