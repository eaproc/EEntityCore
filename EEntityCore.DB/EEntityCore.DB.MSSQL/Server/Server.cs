using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using CODERiT.Logger.Standard.VB.Exceptions;
using EEntityCore.DB.Abstracts;
using EEntityCore.DB.Exceptions;
using ELibrary.Standard.VB;
using ELibrary.Standard.VB.Modules;
using ELibrary.Standard.VB.Objects;
using ELibrary.Standard.VB.Types;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic; // Install-Package Microsoft.VisualBasic
using Microsoft.VisualBasic.CompilerServices; // Install-Package Microsoft.VisualBasic


namespace EEntityCore.DB.MSSQL
{
    /// <summary>
    /// Contains Basic Operations to perform when using MS SQL Server [2008] in your project as a Server/Standlone
    /// </summary>
    /// <remarks>I assume this is Local. On Local Connections</remarks>
    public abstract partial class Server : All__DBs, IDisposable
    {


        #region Properties

        #region Private


        // REM 
        /// <summary>
        /// Actually When you initiate Local you dont need to pass any credential apart from the database
        /// You wish to use
        /// </summary>
        /// <remarks></remarks>
        protected internal string CurrentDBInUse;


        #endregion


        #region Public 



        protected string __SQLServerAddress { get; set; }

        /// <summary>
        /// Server address or host name with address like WINHOST-PC\SQLEXPRESS
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public virtual string SQLServerAddress
        {
            get
            {
                // REM If Not __SQLServerAddress.ToLower().EndsWith("\sqlexpress") Then __SQLServerAddress &= "\sqlexpress"
                return __SQLServerAddress;
            }
        }

        protected string __SQLServerUserName = null;

        public string SQLServerUserName
        {
            get
            {
                return __SQLServerUserName;
            }
        }

        protected string __SQLServerPassword = null;

        public string SQLServerPassword
        {
            get
            {
                return __SQLServerPassword;
            }
        }

        /// <summary>
        /// SQL Server Default Port Number
        /// </summary>
        /// <remarks></remarks>
        public const int DEFAULT_PORT = 1433;
        protected int __SQLServerPort = 0;

        public int SQLServerPort
        {
            get
            {
                return __SQLServerPort;
            }
        }

        public string DatabaseName
        {
            get
            {
                return CurrentDBInUse;
            }
        }



        #endregion


        #region Constants


        #endregion

        #endregion


        #region Constructors



        /// <summary>
        /// Set Database to use
        /// </summary>
        /// <param name="useDatabase"></param>
        /// <param name="pSQLServerFullAddress">Enter full instance name like pcName\SqlExpress2014</param>
        /// <remarks></remarks>
        public Server(string useDatabase, string pSQLServerFullAddress)
        {
            CurrentDBInUse = useDatabase;
            __SQLServerAddress = pSQLServerFullAddress;
        }


        /// <summary>
        /// Set Database to use
        /// </summary>
        /// <param name="useDatabase">Database on MyPC\sqlexpress</param>
        /// <remarks></remarks>
        public Server(string useDatabase) : this(useDatabase, @"localhost\sqlexpress")
        {
        }



        #endregion


        #region Methods

        #region Private



        #region IDisposable Support
        private bool disposedValue; // To detect redundant calls

        // IDisposable
        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {


                    // TODO: dispose managed state (managed objects).

                }

                // TODO: free unmanaged resources (unmanaged objects) and override Finalize() below.
                // TODO: set large fields to null.
            }

            disposedValue = true;
        }

        // TODO: override Finalize() only if Dispose(ByVal disposing As Boolean) above has code to free unmanaged resources.
        // Protected Overrides Sub Finalize()
        // ' Do not change this code.  Put cleanup code in Dispose(ByVal disposing As Boolean) above.
        // Dispose(False)
        // MyBase.Finalize()
        // End Sub

        // This code added by Visual Basic to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code.  Put cleanup code in Dispose(ByVal disposing As Boolean) above.
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        #endregion

        /// <summary>
        /// Incase your database is using 'Date', you might need to encode it to \'Date\' if you are using encoding
        /// </summary>
        /// <param name="__str "></param>
        /// <returns></returns>
        /// <remarks></remarks>
        private string Encode__Apostrophe(string __str)
        {
            return Strings.Replace(__str, "'", @"\'");
        }

        #endregion


        #region Public
        // Note Parameters that changes Depending on the database you are working with
        // 
        // SQL Server Does Not Support ` sign for quoting fields
        // Also Does Not support # for Date quoting Use ' instead
        // 
        // 
        // 
        // 

        // 
        // 
        // SQL Server Does Not Support ` sign for quoting fields
        // Also Does Not support # for Date quoting Use ' instead

        #region has direct Relation With getConnection()

        #region dbExec and getRS


        /// <summary>
        /// Using SQL Default Path and DB 
        /// </summary>
        /// <returns></returns>
        /// <remarks></remarks>
        public abstract Microsoft.Data.SqlClient.SqlConnection GetSQLConnection();
       


        /// <summary>
        /// Execute SQL StoredProcedures ... Using Current Database
        /// </summary>
        /// <param name="SQLParameters"></param>
        /// <remarks></remarks>
        public bool DbExec(string StoredProcedure, SqlParameter[] SQLParameters)
        {
            var sqlDBCon = GetSQLConnection();
            if (basExtensions.IsNothing(sqlDBCon))
                return false;
            try
            {
                var sqlCommand = new SqlCommand(StoredProcedure);
                using (sqlCommand)
                {
                    sqlCommand.Connection = sqlDBCon;
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.CommandTimeout = 0;  // no time out here
                    sqlCommand.Parameters.AddRange(SQLParameters);
                    sqlCommand.ExecuteNonQuery();
                    sqlDBCon.Close();
                    sqlDBCon = null;
                }
            }
            catch (Exception )
            {
                // Logger.Log(New SQLCodeException(ex))
                throw;
            }
            finally
            {
                if (sqlDBCon is object)
                {
                    if (sqlDBCon.State != ConnectionState.Closed)
                        sqlDBCon.Close();
                    sqlDBCon = null;
                }
            }

            return true;
        }

        /// <summary>
        /// Using current loaded database
        /// </summary>
        /// <param name="SQL"></param>
        /// <returns></returns>
        /// <remarks></remarks>
        public override int DbExec(string SQL)
        {
            // 
            // Be careful because tracking works on the database name passed in
            // 
            var sqlDBCon = GetSQLConnection();
            if (basExtensions.IsNothing(sqlDBCon))
                return -1;
            try
            {
                var sqlCommand = new SqlCommand();
                using (sqlCommand)
                {
                    sqlCommand.Connection = sqlDBCon;
                    sqlCommand.CommandType = CommandType.Text;
                    sqlCommand.CommandTimeout = 0;  // no time out here
                    sqlCommand.CommandText = SQL;
                    return sqlCommand.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                var ex2 = new SQLCodeException(SQL, ex);

                // Logger.Log(New SQLCodeException(SQL, ex))

                throw ex2;
            }
            finally
            {
                if (sqlDBCon is object)
                {
                    if (sqlDBCon.State != ConnectionState.Closed)
                        sqlDBCon.Close();
                    sqlDBCon = null;
                }
            }
        }


        /// <summary>
        /// Get RS using Specific DB. Throws Exception.
        /// Returns DataSet or throws Exception
        /// </summary>
        /// <param name="SQL"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        /// <remarks></remarks>
        public override DataSet GetRS(string SQL)
        {
            // 
            // Be careful because tracking works on the database name passed in
            // 

            var srs = new DataSet();
            var sqlDBCon = GetSQLConnection();
            if (basExtensions.IsNothing(sqlDBCon))
                return null;
            try
            {
                var sqlCommand = new SqlCommand();
                using (sqlCommand)
                {
                    sqlCommand.Connection = sqlDBCon;
                    sqlCommand.CommandType = CommandType.Text;
                    sqlCommand.CommandTimeout = 0;  // no time out here
                    sqlCommand.CommandText = SQL;
                    var da = new SqlDataAdapter(sqlCommand);
                    da.Fill(srs);
                    da.Dispose();
                    da = null;
                }
            }
            catch (Exception ex)
            {
                throw new SQLCodeException(SQL, ex);
            }
            finally
            {
                if (sqlDBCon is object)
                {
                    if (sqlDBCon.State != ConnectionState.Closed)
                        sqlDBCon.Close();
                    sqlDBCon = null;
                }
            }

            return srs;
        }

        

        /// <summary>
        /// Get RS using default DB and Stored Procedures
        /// </summary>
        /// <param name="StoredProcedure "></param>
        /// <returns></returns>
        /// <remarks></remarks>
        public DataSet GetRS(string StoredProcedure, params SqlParameter[] SQLParameters)
        {
            var srs = new DataSet();
            var sqlDBCon = new SqlConnection();
            sqlDBCon = GetSQLConnection();
            if (basExtensions.IsNothing(sqlDBCon))
                return null;
            try
            {
                var sqlCommand = new SqlCommand();
                using (sqlCommand)
                {
                    sqlCommand.Connection = sqlDBCon;
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.CommandText = StoredProcedure;
                    sqlCommand.Parameters.AddRange(SQLParameters);
                    var da = new SqlDataAdapter(sqlCommand);
                    da.Fill(srs);
                    da.Dispose();
                    da = null;
                }
            }
            catch (Exception ex)
            {
                Logger.Log(new SQLCodeException(ex));
                return null;
            }
            finally
            {
                if (sqlDBCon is object)
                {
                    if (sqlDBCon.State != ConnectionState.Closed)
                        sqlDBCon.Close();
                    sqlDBCon = null;
                }
            }

            return srs;
        }


        #endregion

        #region Testing Connection

        /// <summary>
        /// Test if DB is Ok. Always use master db
        /// </summary>
        /// <remarks></remarks>
        public override bool PingDB()
        {
            return IsDataSetValid(GetRS("SELECT * FROM sys.server_principals"));
        }

        /// <summary>
        /// Indicate if Connection will be successful using the current parameters
        /// </summary>
        /// <returns></returns>
        /// <remarks></remarks>
        public override bool CanConnect()
        {
            return CanConnect(true);
        }


        /// <summary>
        /// Indicate if Connection will be successful using the current parameters.
        /// Silent Run
        /// </summary>
        /// <param name="Silent">dummy input</param>
        /// <remarks></remarks>
        public bool CanConnect(bool Silent)
        {
            SqlConnection aCon = GetSQLConnection();
            try
            {
                if (!basExtensions.IsNothing(aCon))
                    return true;
            }
            catch (Exception ex)
            {
                Logger.Log(new EException("Exception Under CanConnect (SQL Server)", ex));
            }
            finally
            {
                if (!basExtensions.IsNothing(aCon))
                {
                    aCon.Close();
                    aCon = default;
                }
            }

            return false;
        }

        #endregion


        //#region Saving Binaries to Database

        //#region Saving Image to Database

        ///// <summary>
        ///// Save Image On a Table Using a Unique ID
        ///// </summary>
        ///// <param name="TableName"></param>
        ///// <param name="ImageColumnName"></param>
        ///// <param name="ColumnIDName"></param>
        ///// <param name="ColumnID"></param>
        ///// <param name="ImageToSave"></param>
        ///// <returns></returns>
        ///// <remarks></remarks>
        //public bool SaveThisImageOnTable(string TableName, string ImageColumnName, string ColumnIDName, long ColumnID, byte[] ImageToSave = null)
        //{
        //    var Con = GetSQLConnection();
        //    if (Con is null)
        //        return false;
        //    try
        //    {
        //        string sql = string.Format("UPDATE {0} SET {1} = @photo  WHERE {2}={3} ", TableName, ImageColumnName, ColumnIDName, ColumnID);

        //        // When it nothing you have to set NULL yourself using string .. it doesn't work on parameters 
        //        // to automatically set null
        //        string sqlNull = string.Format("UPDATE {0} SET {1} =NULL  WHERE {2}={3} ", TableName, ImageColumnName, ColumnIDName, ColumnID);
        //        if (ImageToSave is object)
        //        {
        //            byte[] data = null;
        //            var cmd = new SqlCommand(sql, Con);
        //            data = ImageToSave;
        //            var p = new SqlParameter("@photo", SqlDbType.Image);
        //            p.Value = data;
        //            cmd.Parameters.Add(p);
        //            cmd.ExecuteNonQuery();
        //        }
        //        else
        //        {
        //            return DbExec(sqlNull);
        //        }
        //    }
        //    catch (Exception )
        //    {
        //        return false;
        //    }
        //    finally
        //    {
        //        if (Con is object)
        //        {
        //            if (Con.State != ConnectionState.Closed)
        //                Con.Close();
        //            Con = null;
        //        }
        //    }

        //    return true;
        //}


        ///// <summary>
        ///// Fectch Image Value From Database
        ///// </summary>
        ///// <param name="TableName">The Table name we want to extract from</param>
        ///// <param name="ImageColumnName">Image Column Name</param>
        ///// <param name="ColumnIDName">A unique ID column Name [Must Contain Numeric]</param>
        ///// <param name="ColumnID">Unique Column ID Value</param>
        ///// <returns>Image or Nothing</returns>
        ///// <remarks></remarks>
        //public byte[] FetchImageFromTable(string TableName, string ImageColumnName, string ColumnIDName, long ColumnID)
        //{
        //    var Con = GetSQLConnection();
        //    if (Con is null)
        //        return null;
        //    try
        //    {
        //        string sql = string.Format("SELECT {1} FROM {0} WHERE {2}={3} ", TableName, ImageColumnName, ColumnIDName, ColumnID);
        //        var cmd = new SqlCommand(sql, Con);
        //        byte[] imageData = (byte[])cmd.ExecuteScalar();
        //        if (imageData is object)
        //        {
        //            using (var ms = new MemoryStream(imageData, 0, imageData.Length))
        //            {
        //                ms.Write(imageData, 0, imageData.Length);
        //                return ms.GetBuffer();
        //            }
        //        }
        //    }
        //    catch (Exception )
        //    {
        //    }
        //    finally
        //    {
        //        if (Con is object)
        //        {
        //            if (Con.State != ConnectionState.Closed)
        //                Con.Close();
        //            Con = null;
        //        }
        //    }

        //    return null;
        //}

        //#endregion


        //#region Saving Other Files to Database

        /////// <summary>
        /////// Save VarBinary On a Table Using a Unique ID [long]
        /////// </summary>
        /////// <param name="TableName">The table where to insert the file</param>
        /////// <param name="FileColumnName">The Column on Table for the file</param>
        /////// <param name="ColumnIDValue">The primary key id value</param>
        /////// <returns>boolean on success</returns>
        /////// <remarks></remarks>
        ////public bool SaveVarBinaryOnTable(string TableName, string FileColumnName, long ColumnIDValue, byte[] pContents = null)
        ////{
        ////    var Con = GetSQLConnection();
        ////    if (Con is null)
        ////        return false;
        ////    try
        ////    {
        ////        string sql = string.Format("UPDATE {0} SET {1} = @sfile  WHERE ID={2} ", TableName, FileColumnName, ColumnIDValue);

        ////        // When it nothing you have to set NULL yourself using string .. it doesn't work on parameters 
        ////        // to automatically set null
        ////        string sqlNull = string.Format("UPDATE {0} SET {1} =NULL  WHERE ID={2} ", TableName, FileColumnName, ColumnIDValue);
        ////        if (pContents is object)
        ////        {
        ////            var data = pContents;
        ////            var cmd = new SqlCommand(sql, Con);
        ////            var p = new SqlParameter("@sfile", SqlDbType.VarBinary);
        ////            p.Value = data;
        ////            cmd.Parameters.Add(p);
        ////            cmd.ExecuteNonQuery();
        ////        }
        ////        else
        ////        {
        ////        SaveAsNull:
        ////            ;
        ////            return DbExec(sqlNull);
        ////        }
        ////    }
        ////    catch (Exception )
        ////    {
        ////        return false;
        ////    }
        ////    finally
        ////    {
        ////        if (Con is object)
        ////        {
        ////            if (Con.State != ConnectionState.Closed)
        ////                Con.Close();
        ////            Con = null;
        ////        }
        ////    }

        ////    return true;
        ////}


        /////// <summary>
        /////// Save File On a Table Using a Unique ID [long]
        /////// </summary>
        /////// <param name="TableName">The table where to insert the file</param>
        /////// <param name="FileColumnName">The Column on Table for the file</param>
        /////// <param name="ColumnIDName">The primary key name</param>
        /////// <param name="ColumnIDValue">The primary key id value</param>
        /////// <param name="FilePath">The path of the file to save to database</param>
        /////// <returns>boolean on success</returns>
        /////// <remarks></remarks>
        ////public bool SaveThisFileOnTable(string TableName, string FileColumnName, long ColumnIDValue, string ColumnIDName = "ID", string FilePath = null)
        ////{
        ////    var Con = GetSQLConnection();
        ////    if (Con is null)
        ////        return false;
        ////    try
        ////    {
        ////        string sql = string.Format("UPDATE {0} SET {1} = @sfile  WHERE {2}={3} ", TableName, FileColumnName, ColumnIDName, ColumnIDValue);

        ////        // When it nothing you have to set NULL yourself using string .. it doesn't work on parameters 
        ////        // to automatically set null
        ////        string sqlNull = string.Format("UPDATE {0} SET {1} =NULL  WHERE {2}={3} ", TableName, FileColumnName, ColumnIDName, ColumnIDValue);
        ////        if (FilePath is object)
        ////        {
        ////            if (!File.Exists(FilePath))
        ////                goto SaveAsNull;
        ////            byte[] data = null;
        ////            var cmd = new SqlCommand(sql, Con);
        ////            data = File.ReadAllBytes(FilePath);
        ////            var p = new SqlParameter("@sfile", SqlDbType.VarBinary);
        ////            p.Value = data;
        ////            cmd.Parameters.Add(p);
        ////            cmd.ExecuteNonQuery();
        ////        }
        ////        else
        ////        {
        ////        SaveAsNull:
        ////            ;
        ////            return DbExec(sqlNull);
        ////        }
        ////    }
        ////    catch (Exception ex)
        ////    {
        ////        return false;
        ////    }
        ////    finally
        ////    {
        ////        if (Con is object)
        ////        {
        ////            if (Con.State != ConnectionState.Closed)
        ////                Con.Close();
        ////            Con = null;
        ////        }
        ////    }

        ////    return true;
        ////}

        /////// <summary>
        /////// Save File On a Table Using a Unique ID [long]
        /////// </summary>
        /////// <param name="TableName">The table where to insert the file</param>
        /////// <param name="FileColumnName">The Column on Table for the file</param>
        /////// <param name="ColumnIDName">The unique key name</param>
        /////// <param name="ColumnIDValue">The primary key id value</param>
        /////// <param name="FilePath">The path of the file to save to database</param>
        /////// <returns>boolean on success</returns>
        /////// <remarks></remarks>
        ////public bool SaveThisFileOnTable(string TableName, string FileColumnName, string ColumnIDValue, string ColumnIDName = "ID", string FilePath = null)
        ////{
        ////    var Con = GetSQLConnection();
        ////    if (Con is null)
        ////        return false;
        ////    try
        ////    {
        ////        string sql = string.Format("UPDATE {0} SET {1} = @sfile  WHERE {2}='{3}' ", TableName, FileColumnName, ColumnIDName, ColumnIDValue);

        ////        // When it nothing you have to set NULL yourself using string .. it doesn't work on parameters 
        ////        // to automatically set null
        ////        string sqlNull = string.Format("UPDATE {0} SET {1} =NULL  WHERE {2}='{3}' ", TableName, FileColumnName, ColumnIDName, ColumnIDValue);
        ////        if (FilePath is object)
        ////        {
        ////            if (!File.Exists(FilePath))
        ////                goto SaveAsNull;
        ////            byte[] data = null;
        ////            var cmd = new SqlCommand(sql, Con);
        ////            data = File.ReadAllBytes(FilePath);
        ////            var p = new SqlParameter("@sfile", SqlDbType.VarBinary);
        ////            p.Value = data;
        ////            cmd.Parameters.Add(p);
        ////            cmd.ExecuteNonQuery();
        ////        }
        ////        else
        ////        {
        ////        SaveAsNull:
        ////            ;
        ////            return DbExec(sqlNull);
        ////        }
        ////    }
        ////    catch (Exception ex)
        ////    {
        ////        return false;
        ////    }
        ////    finally
        ////    {
        ////        if (Con is object)
        ////        {
        ////            if (Con.State != ConnectionState.Closed)
        ////                Con.Close();
        ////            Con = null;
        ////        }
        ////    }

        ////    return true;
        ////}


        /////// <summary>
        /////// Fectch Image Value From Database
        /////// </summary>
        /////// <param name="TableName">The Table name we want to extract from</param>
        /////// <param name="FileColumnName">Image Column Name</param>
        /////// <param name="ColumnIDName">A unique ID column Name [Must Contain Numeric]</param>
        /////// <param name="ColumnIDValue">Unique Column ID Value</param>
        /////// <returns>Image or Nothing</returns>
        /////// <remarks></remarks>
        ////private byte[] FetchFileFromTable(string TableName, string FileColumnName, long ColumnIDValue, string ColumnIDName = "ID")
        ////{
        ////    var Con = GetSQLConnection();
        ////    if (Con is null)
        ////        return null;
        ////    try
        ////    {
        ////        string sql = string.Format("SELECT {1} FROM {0} WHERE {2}={3} ", TableName, FileColumnName, ColumnIDName, ColumnIDValue);
        ////        var cmd = new SqlCommand(sql, Con);
        ////        byte[] imageData = (byte[])cmd.ExecuteScalar();
        ////        return imageData;
        ////    }

        ////    // 'If Not imageData Is Nothing Then
        ////    // '    Using ms As New IO.MemoryStream(imageData, 0, imageData.Length)
        ////    // '        ms.Write(imageData, 0, imageData.Length)
        ////    // '        Return Image.FromStream(ms, True)
        ////    // '    End Using

        ////    // 'End If
        ////    catch (Exception ex)
        ////    {
        ////    }
        ////    finally
        ////    {
        ////        if (Con is object)
        ////        {
        ////            if (Con.State != ConnectionState.Closed)
        ////                Con.Close();
        ////            Con = null;
        ////        }
        ////    }

        ////    return null;
        ////}


        ///// <summary>
        ///// Fectch File Data Value From Database
        ///// </summary>
        ///// <param name="TableName">The Table name we want to extract from</param>
        ///// <param name="FileColumnName">Image Column Name</param>
        ///// <param name="ColumnIDName">A unique ID column Name [Must Contain String]</param>
        ///// <param name="ColumnIDValue">Unique Column ID Value</param>
        ///// <returns>File or Nothing</returns>
        ///// <remarks></remarks>
        //private byte[] FetchFileFromTable(string TableName, string FileColumnName, string ColumnIDValue, string ColumnIDName = "ID")
        //{
        //    var Con = GetSQLConnection();
        //    if (Con is null)
        //        return null;
        //    try
        //    {
        //        string sql = string.Format("SELECT {1} FROM {0} WHERE {2}='{3}' ", TableName, FileColumnName, ColumnIDName, ColumnIDValue);
        //        var cmd = new SqlCommand(sql, Con);
        //        byte[] imageData = (byte[])cmd.ExecuteScalar();
        //        return imageData;
        //    }
        //    catch (Exception )
        //    {
        //    }
        //    finally
        //    {
        //        if (Con is object)
        //        {
        //            if (Con.State != ConnectionState.Closed)
        //                Con.Close();
        //            Con = null;
        //        }
        //    }

        //    return null;
        //}



        ///// <summary>
        ///// Fetch file from database and returns filepath [Make sure you invoke with administrative rights to write to disk]
        ///// </summary>
        ///// <param name="TableName">The Table Name Containing the File</param>
        ///// <param name="FileColumnName">The Column Name Containing the File bytes</param>
        ///// <param name="ColumnIDName">A unique column on the table</param>
        ///// <param name="ColumnIDValue">The unique column value</param>
        ///// <param name="FolderPath" >The destination directory to store the extracted file</param>
        ///// <param name="suggestedFileName" >The suggested file name</param>
        ///// <param name="Overwrite" >Overwrite File if it already exist in the directory</param>
        ///// <returns>It returns the name of the file written if succeeded</returns>
        ///// <remarks></remarks>
        //public string FetchFileFromTable(string TableName, string FileColumnName, string ColumnIDName, long ColumnIDValue, string FolderPath, string suggestedFileName = "File.dat", bool Overwrite = true)
        //{
        //    throw new NotImplementedException();
        //    // If Not Directory.Exists(FolderPath) Then Return vbNullString

        //    // Dim __byte() As Byte = Me.FetchFileFromTable(TableName, FileColumnName, ColumnIDValue, ColumnIDName)


        //    // If __byte IsNot Nothing Then
        //    // Dim originalFileName As String = String.Format("{0}\{1}", FolderPath, suggestedFileName)
        //    // If Overwrite Then
        //    // If File.Exists(originalFileName) Then File.Delete(originalFileName)
        //    // Else
        //    // REM Fetch Available File name
        //    // originalFileName = EIO.getAvailableFileName(FolderPath, suggestedFileName)
        //    // End If

        //    // File.WriteAllBytes(originalFileName, __byte)
        //    // Return originalFileName
        //    // Else
        //    // Return vbNullString
        //    // End If

        //}

        ///// <summary>
        ///// Fetch file from database and returns filepath [Make sure you invoke with administrative rights to write to disk]
        ///// </summary>
        ///// <param name="TableName">The Table Name Containing the File</param>
        ///// <param name="FileColumnName">The Column Name Containing the File bytes</param>
        ///// <param name="ColumnIDName">A unique column on the table</param>
        ///// <param name="ColumnIDValue">The unique column value</param>
        ///// <param name="FolderPath" >The destination directory to store the extracted file</param>
        ///// <param name="suggestedFileName" >The suggested file name</param>
        ///// <param name="Overwrite" >Overwrite File if it already exist in the directory</param>
        ///// <returns>It returns the name of the file written if succeeded</returns>
        ///// <remarks></remarks>
        //public string FetchFileFromTable(string TableName, string FileColumnName, string ColumnIDName, string ColumnIDValue, string FolderPath, string suggestedFileName = "File.dat", bool Overwrite = true)
        //{
        //    throw new NotImplementedException();

        //    // If Not Directory.Exists(FolderPath) Then Return vbNullString

        //    // Dim __byte() As Byte = Me.FetchFileFromTable(TableName, FileColumnName, ColumnIDValue, ColumnIDName)


        //    // If __byte IsNot Nothing Then
        //    // Dim originalFileName As String = String.Format("{0}\{1}", FolderPath, suggestedFileName)
        //    // If Overwrite Then
        //    // If File.Exists(originalFileName) Then File.Delete(originalFileName)
        //    // Else
        //    // REM Fetch Available File name
        //    // originalFileName = EIO.getAvailableFileName(FolderPath, suggestedFileName)
        //    // End If

        //    // File.WriteAllBytes(originalFileName, __byte)
        //    // Return originalFileName
        //    // Else
        //    // Return vbNullString
        //    // End If

        //}


        //#endregion





        //#endregion

        #region Filling Datasets and DataTables

        /// <summary>
        /// Fill All Data For Tables in this Hard-Coded dataset
        /// </summary>
        /// <param name="MyDataSet"></param>
        /// <remarks></remarks>
        public override bool FillMyTables(ref DataSet MyDataSet)
        {
            var Con = GetSQLConnection();
            if (Con is null)
                return false;
            try
            {
                SqlDataAdapter da;
                foreach (DataTable OneTable in MyDataSet.Tables)
                {

                    // Clear previous info to avoid cache
                    OneTable.Clear();
                    da = new SqlDataAdapter("Select * From " + OneTable.TableName, Con);
                    da.Fill(MyDataSet.Tables[OneTable.TableName]);

                    // Application.DoEvents()

                }

                return true;
            }
            catch (Exception )
            {
            }
            // REM Report Error

            finally
            {
                if (Con is object)
                {
                    if (Con.State != ConnectionState.Closed)
                        Con.Close();
                    Con = null;
                }
            }

            return false;
        }

        /// <summary>
        /// Fill All Data For Table
        /// </summary>
        /// <param name="OneTable"></param>
        /// <remarks></remarks>
        public override bool FillMyTable(ref DataTable OneTable)
        {
            var Con = GetSQLConnection();
            if (Con is null)
                return false;
            try
            {
                SqlDataAdapter da;


                // Clear previous info to avoid cache
                OneTable.Clear();
                da = new SqlDataAdapter("Select * From " + OneTable.TableName, Con);
                da.Fill(OneTable);
                // Application.DoEvents()

                return true;
            }
            catch (Exception )
            {
            }
            finally
            {
                if (Con is object)
                {
                    if (Con.State != ConnectionState.Closed)
                        Con.Close();
                    Con = null;
                }
            }

            return false;
        }


        /// <summary>
        /// Fill All Data For Table
        /// </summary>
        /// <param name="OneTable"></param>
        /// <param name="SQLWHERECondition__Or__FullSQL_Statement" >You can pass in a full sql state or only where condition</param>
        /// <remarks></remarks>
        public bool FillMyTable(ref DataTable OneTable, string SQLWHERECondition__Or__FullSQL_Statement)
        {

            // REM No Spaces
            if (SQLWHERECondition__Or__FullSQL_Statement is object)
                SQLWHERECondition__Or__FullSQL_Statement = SQLWHERECondition__Or__FullSQL_Statement.Trim();

            // REM Decide which one we are going for here
            string SQL_Statement = string.Format("Select * From {0} {1}", OneTable.TableName, SQLWHERECondition__Or__FullSQL_Statement);

            // REM IF it is full sql then override
            if (!string.IsNullOrEmpty(SQLWHERECondition__Or__FullSQL_Statement))
            {
                if (SQLWHERECondition__Or__FullSQL_Statement.IndexOf("SELECT") == 0)
                {
                    SQL_Statement = SQLWHERECondition__Or__FullSQL_Statement;
                }
            }

            var Con = GetSQLConnection();
            if (Con is null)
                return false;
            try
            {
                SqlDataAdapter da;

                // Clear previous info to avoid cache
                OneTable.Clear();
                da = new SqlDataAdapter(SQL_Statement, Con);
                da.Fill(OneTable);
                // Application.DoEvents()

                return true;
            }
            catch (Exception )
            {
            }
            finally
            {
                if (Con is object)
                {
                    if (Con.State != ConnectionState.Closed)
                        Con.Close();
                    Con = null;
                }
            }

            return false;
        }


        /// <summary>
        /// Fill All Data For Table
        /// </summary>
        /// <param name="OneTable"></param>
        /// <param name="SQL " >SQL For Table</param>
        /// <remarks></remarks>
        public override bool FillMyTable(string SQL, ref DataTable OneTable)
        {
            var Con = GetSQLConnection();
            if (Con is null)
                return false;
            try
            {
                SqlDataAdapter da;

                // Clear previous info to avoid cache
                OneTable.Clear();
                da = new SqlDataAdapter(SQL, Con);
                da.Fill(OneTable);
                // Application.DoEvents()

                return true;
            }
            catch (Exception )
            {
            }
            finally
            {
                if (Con is object)
                {
                    if (Con.State != ConnectionState.Closed)
                        Con.Close();
                    Con = null;
                }
            }

            return false;
        }


        /// <summary>
        /// Fill All Data For Table With Provided StoredProcedure
        /// </summary>
        /// <param name="OneTable"></param>
        /// <remarks></remarks>
        public bool FillMyTable(ref DataTable OneTable, string StoredProcedure, params SqlParameter[] SQLParameters)
        {
            var sqlDBCon = new SqlConnection();
            sqlDBCon = GetSQLConnection();
            if (basExtensions.IsNothing(sqlDBCon))
                return default;
            try
            {
                var sqlCommand = new SqlCommand();
                using (sqlCommand)
                {
                    sqlCommand.Connection = sqlDBCon;
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.CommandText = StoredProcedure;
                    sqlCommand.Parameters.AddRange(SQLParameters);
                    var da = new SqlDataAdapter(sqlCommand);


                    // Clear previous info to avoid cache
                    OneTable.Clear();
                    da.Fill(OneTable);
                    // Application.DoEvents()

                    da.Dispose();
                    da = null;
                    sqlDBCon.Close();
                    sqlDBCon = null;
                }

                return true;
            }
            catch (Exception )
            {
            }
            finally
            {
                if (sqlDBCon is object)
                {
                    if (sqlDBCon.State != ConnectionState.Closed)
                        sqlDBCon.Close();
                    sqlDBCon = null;
                }
            }

            return false;
        }

        #endregion


        #endregion





        /// <summary>
        /// Package the DateTime Output in the correct saving Order.
        /// Pack a formatted SQL Server save date into quoted string '{_dateValue}'
        /// </summary>
        /// <param name="_DateTime"></param>
        /// <returns></returns>
        /// <remarks>NB: If date should be empty it should be set to Null</remarks>
        public string PackageDateTimeForSavingOnSQL2008(string _DateTime)
        {
            if (_DateTime is null)
                return "Null";
            if (_DateTime.Equals(""))
                return "Null";
            return string.Format("'{0}'", _DateTime);
        }

        #region Saving Date and Time in SQL Server 2008


        public override string GetSQLDateTimeFormat (NullableDateTime _DateTime)
        {
            return GetSQLDateTimeFormat(_DateTime, false);
        }

        public string GetSQLDateTimeFormat (NullableDateTime _DateTime, bool EncodeApostrophe)
        {
            if (_DateTime is null || _DateTime.isNull)
                return PackageDateTimeForSavingOnSQL2008(Constants.vbNullString);
            if (EncodeApostrophe)
            {
                return Encode__Apostrophe(PackageDateTimeForSavingOnSQL2008(EDateTime.ValueOf(_DateTime, EDateTime.SpecialDateTimeFormats.STYLE2)));
            }
            else
            {
                return PackageDateTimeForSavingOnSQL2008(EDateTime.ValueOf(_DateTime, EDateTime.SpecialDateTimeFormats.STYLE2));
            }
        }

        public string GetSQLDateFormat (NullableDateTime _Date, bool EncodeApostrophe)
        {
            if (_Date is null || _Date.isNull)
                return PackageDateTimeForSavingOnSQL2008(Constants.vbNullString);
            if (EncodeApostrophe)
            {
                return Encode__Apostrophe(PackageDateTimeForSavingOnSQL2008(EDateTime.ValueOf(_Date, EDateTime.SpecialDateTimeFormats.STYLE1)));
            }
            else
            {
                return PackageDateTimeForSavingOnSQL2008(EDateTime.ValueOf(_Date, EDateTime.SpecialDateTimeFormats.STYLE1));
            }
        }

        public override string GetSQLDateFormat (NullableDateTime _Date)
        {
            return GetSQLDateFormat(_Date, false);
        }

        public string GetSQLTimeFormat (NullableDateTime _Time, bool EncodeApostrophe)
        {
            if (_Time is null || _Time.isNull)
                return PackageDateTimeForSavingOnSQL2008(Constants.vbNullString);
            if (EncodeApostrophe)
            {
                return Encode__Apostrophe(PackageDateTimeForSavingOnSQL2008(EDateTime.ValueOf(_Time, EDateTime.TimeFormatUsedWithoutSeconds)));
            }
            else
            {
                return PackageDateTimeForSavingOnSQL2008(EDateTime.ValueOf(_Time, EDateTime.TimeFormatUsedWithoutSeconds));
            }
        }

        public override string GetSQLTimeFormat (NullableDateTime _Time)
        {
            return GetSQLTimeFormat(_Time, false);
        }


        #endregion




        /// <summary>
        /// Check If Table is Created on Current Database in Use. ISOLATION LEVEL: READ_COMMITTED
        /// </summary>
        /// <param name="pTableName"></param>
        /// <returns></returns>
        /// <remarks></remarks>
        public bool IsTableCreatedOnDatabase(string pTableName)
        {
            return IsDataSetValid(GetRS(string.Format("Select * from sys.tables c WHERE c.name='{0}'", pTableName)));
        }



        /// <summary>
        /// Check If Allow_Snapshot is set to ON on the indicated database name. It using current connect to perform the query
        /// </summary>
        /// <param name="pDatabase"></param>
        /// <returns></returns>
        /// <remarks></remarks>
        public bool IsSnapshotSetOnDatabase(string pDatabase)
        {
            var p = GetRS(string.Format("SELECT snapshot_isolation_state FROM sys.databases WHERE [name]='{0}'", pDatabase));
            if (IsDataSetValid(p))
            {
                return EBoolean.ValueOf(p.Tables[0].AsEnumerable().ElementAtOrDefault(0)[0]);
            }

            return false;
        }


        /// <summary>
        /// Check If Allow_Snapshot is set to ON on the this current database name.
        /// </summary>
        /// <returns></returns>
        /// <remarks></remarks>
        public bool IsSnapshotSetOnDatabase()
        {
            return IsSnapshotSetOnDatabase(DatabaseName);
        }

        public bool SetAllowSnapshotOnDatabase(bool pSetOn, string pDatabaseName)
        {
            if (pSetOn)
                return DbExec(string.Format("ALTER DATABASE {0} SET ALLOW_SNAPSHOT_ISOLATION ON", pDatabaseName)) >= 0;
            return DbExec(string.Format("ALTER DATABASE {0} SET ALLOW_SNAPSHOT_ISOLATION OFF", pDatabaseName)) >= 0;
        }

        public bool SetAllowSnapshotOnDatabase(bool pSetOn)
        {
            return SetAllowSnapshotOnDatabase(pSetOn, pDatabaseName: DatabaseName);
        }

        #endregion


        #endregion


    }
}
