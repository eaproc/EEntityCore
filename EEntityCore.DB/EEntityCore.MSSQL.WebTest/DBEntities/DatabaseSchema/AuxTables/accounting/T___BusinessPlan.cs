using System;                  
using System.Collections.Generic;                  
using System.Data;                  
using System.Linq;                  
using EEntityCore.DB.Abstracts;                  
using EEntityCore.DB.MSSQL.Interfaces;                  
using ELibrary.Standard.VB.Objects;                  
using ELibrary.Standard.VB.Types;                  
using EEntityCore.DB.Modules;                  
using static EEntityCore.MSSQL.WebTest.DBEntities.DatabaseSchema.DatabaseInit;
using EEntityCore.MSSQL.WebTest.DBEntities.DatabaseSchema;

namespace EEntityCore.MSSQL.WebTest.DBEntities.DatabaseSchema.AuxTables.AuxTables.accounting                  
{                  

    public class T___BusinessPlan : Sample__Table, IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  
    {                  
                  
#region Constructors                  
                  
                  
       static T___BusinessPlan()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defID = new DataColumnDefinition(TableColumnNames.ID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.PRIMARY);
          defAcademicSessionID = new DataColumnDefinition(TableColumnNames.AcademicSessionID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.UNIQUE);
          defStudentPopulation = new DataColumnDefinition(TableColumnNames.StudentPopulation.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defAveragePricePerStudent = new DataColumnDefinition(TableColumnNames.AveragePricePerStudent.ToString(), typeof(Decimal),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defSCADWAREAccessRevenue = new DataColumnDefinition(TableColumnNames.SCADWAREAccessRevenue.ToString(), typeof(Decimal),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defSideContractRevenue = new DataColumnDefinition(TableColumnNames.SideContractRevenue.ToString(), typeof(Decimal),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defGrossRevenue = new DataColumnDefinition(TableColumnNames.GrossRevenue.ToString(), typeof(Decimal),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defWages = new DataColumnDefinition(TableColumnNames.Wages.ToString(), typeof(Decimal),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defMarketing = new DataColumnDefinition(TableColumnNames.Marketing.ToString(), typeof(Decimal),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCharity = new DataColumnDefinition(TableColumnNames.Charity.ToString(), typeof(Decimal),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defOthers = new DataColumnDefinition(TableColumnNames.Others.ToString(), typeof(Decimal),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedAt = new DataColumnDefinition(TableColumnNames.CreatedAt.ToString(), typeof(DateTime),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defUpdatedAt = new DataColumnDefinition(TableColumnNames.UpdatedAt.ToString(), typeof(DateTime),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);


          ColumnDefns.Add(defID.ColumnName, defID); 
          ColumnDefns.Add(defAcademicSessionID.ColumnName, defAcademicSessionID); 
          ColumnDefns.Add(defStudentPopulation.ColumnName, defStudentPopulation); 
          ColumnDefns.Add(defAveragePricePerStudent.ColumnName, defAveragePricePerStudent); 
          ColumnDefns.Add(defSCADWAREAccessRevenue.ColumnName, defSCADWAREAccessRevenue); 
          ColumnDefns.Add(defSideContractRevenue.ColumnName, defSideContractRevenue); 
          ColumnDefns.Add(defGrossRevenue.ColumnName, defGrossRevenue); 
          ColumnDefns.Add(defWages.ColumnName, defWages); 
          ColumnDefns.Add(defMarketing.ColumnName, defMarketing); 
          ColumnDefns.Add(defCharity.ColumnName, defCharity); 
          ColumnDefns.Add(defOthers.ColumnName, defOthers); 
          ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt); 
          ColumnDefns.Add(defUpdatedAt.ColumnName, defUpdatedAt); 
                  
          ForeignKeys = new List<IDBTableDefinitionPlugIn.ForeignKeyDefinition>();                  
                  

            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_accounting_BusinessPlan_AcademicSessionID", false, IDBTableDefinitionPlugIn.ReferentialAction.CASCADE,                  
                    "accounting.BusinessPlan", "academic.AcademicSession"                  
                            ));                  

          }


                  
       public T___BusinessPlan() : base()                  
        {                  
        }                  


                  
        #region Full Access                                    
                  
        // Full Access means initial data is loaded directly from database, so DBConn MUST be provided                                                      
                  
        /// <summary>                                                      
        /// FULL ACCESS. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="TableName"></param>                                                      
        /// <remarks></remarks>                                    
        public T___BusinessPlan(All__DBs DBConn) : base(DBConn)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID">Only works if the table contains a column named ID</param>                                                      
        /// <remarks></remarks>                                    
        public T___BusinessPlan(All__DBs DBConn, long pTargettedRowID) : base(DBConn,  pTargettedRowID: pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___BusinessPlan(All__DBs pDBConn, string pSQL) : base(pDBConn,  pSQL)                                    
        {                                    
        }                                    
                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___BusinessPlan(All__DBs pDBConn,  string pSQL, long pTargettedRowID) : base(pDBConn, pSQL, pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        #endregion                                    
                                    
                                    
        #region Partial Access                                    
                                    
        // Partial Simply means initial data is loaded directly from user but DBConn might be provided for reloadClass function to work                                                      
                                    
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___BusinessPlan(DataRowCollection pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___BusinessPlan(IEnumerable<DataRow> pTableRows) : base(pTableRows)                  
        {                  
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___BusinessPlan(IEnumerable<DataRow> pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___BusinessPlan(DataTable FullTable, int TargettedRowID) : base(FullTable, TargettedRowID)                                    
        {                                    
        }                                    
                                    
                                    
        #endregion                                    
                                    
                                    
        #region Shallow Access                                    
        // In the real definition, shallow reference partial. Just that it means partial with no DBConn                                                      
                                    
        /// <summary>                                                      
        /// Shallow Access                                                      
        /// </summary>                                                      
        /// <param name="TargettedRow"></param>                                                      
        /// <remarks>Assuming this Row has a Column Called ID and It will be assigned</remarks>                                    
        public T___BusinessPlan(DataRow TargettedRow) : base(TargettedRow)                                    
        {                                    
        }                                    
                                    
        #endregion                                    
                                    
                                    
                                    
                                    
#endregion                                    
                                    
                                    
                                    
#region Consts and Enums                       

       public const string TABLE_NAME = "accounting.BusinessPlan";
       public const string BusinessPlan__NO__BINARY___SQL_FILL_QUERY = "SELECT [ID], [AcademicSessionID], [StudentPopulation], [AveragePricePerStudent], [SCADWAREAccessRevenue], [SideContractRevenue], [GrossRevenue], [Wages], [Marketing], [Charity], [Others], [CreatedAt], [UpdatedAt] FROM BusinessPlan";
       public const string BusinessPlan__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [ID], [AcademicSessionID], [StudentPopulation], [AveragePricePerStudent], [SCADWAREAccessRevenue], [SideContractRevenue], [GrossRevenue], [Wages], [Marketing], [Charity], [Others], [CreatedAt], [UpdatedAt] FROM BusinessPlan";


       public enum TableColumnNames
       {

           ID,
           AcademicSessionID,
           StudentPopulation,
           AveragePricePerStudent,
           SCADWAREAccessRevenue,
           SideContractRevenue,
           GrossRevenue,
           Wages,
           Marketing,
           Charity,
           Others,
           CreatedAt,
           UpdatedAt
       } 



       public enum TableConstraints{

           pk_accounting_BusinessPlan, 
           fk_accounting_BusinessPlan_AcademicSessionID, 
           uq_accounting_BusinessPlan_AcademicSessionID, 
       } 


 #endregion 


 #region Properties 

       private static List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> ForeignKeys;                  

       private static Dictionary<string, DataColumnDefinition> ColumnDefns; 

       public static readonly DataColumnDefinition defID;
       public static readonly DataColumnDefinition defAcademicSessionID;
       public static readonly DataColumnDefinition defStudentPopulation;
       public static readonly DataColumnDefinition defAveragePricePerStudent;
       public static readonly DataColumnDefinition defSCADWAREAccessRevenue;
       public static readonly DataColumnDefinition defSideContractRevenue;
       public static readonly DataColumnDefinition defGrossRevenue;
       public static readonly DataColumnDefinition defWages;
       public static readonly DataColumnDefinition defMarketing;
       public static readonly DataColumnDefinition defCharity;
       public static readonly DataColumnDefinition defOthers;
       public static readonly DataColumnDefinition defCreatedAt;
       public static readonly DataColumnDefinition defUpdatedAt;

       public Int32 AcademicSessionID {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.AcademicSessionID.ToString()]);
           }
       }


       public Int32 StudentPopulation {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.StudentPopulation.ToString()]);
           }
       }


       public Decimal AveragePricePerStudent {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EDecimal.valueOf(this.TargettedRow[TableColumnNames.AveragePricePerStudent.ToString()]);
           }
       }


       public Decimal SCADWAREAccessRevenue {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EDecimal.valueOf(this.TargettedRow[TableColumnNames.SCADWAREAccessRevenue.ToString()]);
           }
       }


       public Decimal SideContractRevenue {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EDecimal.valueOf(this.TargettedRow[TableColumnNames.SideContractRevenue.ToString()]);
           }
       }


       public Decimal GrossRevenue {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EDecimal.valueOf(this.TargettedRow[TableColumnNames.GrossRevenue.ToString()]);
           }
       }


       public Decimal Wages {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EDecimal.valueOf(this.TargettedRow[TableColumnNames.Wages.ToString()]);
           }
       }


       public Decimal Marketing {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EDecimal.valueOf(this.TargettedRow[TableColumnNames.Marketing.ToString()]);
           }
       }


       public Decimal Charity {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EDecimal.valueOf(this.TargettedRow[TableColumnNames.Charity.ToString()]);
           }
       }


       public Decimal Others {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EDecimal.valueOf(this.TargettedRow[TableColumnNames.Others.ToString()]);
           }
       }


       public NullableDateTime CreatedAt {
           get{ 
               if (!this.IsTargettedRowValid) return NullableDateTime.NULL_TIME;                          
               return  new NullableDateTime(this.TargettedRow[TableColumnNames.CreatedAt.ToString()]);
           }
       }


       public NullableDateTime UpdatedAt {
           get{ 
               if (!this.IsTargettedRowValid) return NullableDateTime.NULL_TIME;                          
               return  new NullableDateTime(this.TargettedRow[TableColumnNames.UpdatedAt.ToString()]);
           }
       }


#endregion

#region Methods                  
                  
                  
                  
        /// <summary>                                                       
        /// Returns Empty class on failure                                                       
        /// </summary>                                                       
        /// <returns></returns>                                                       
        /// <remarks></remarks>                  
        public T___BusinessPlan GetFirstRow()                  
        {                  
            if (this.HasRows())                  
                return new T___BusinessPlan(this.AllRows.First());                  
            return null;                  
        }                  
                  
        public static T___BusinessPlan GetFullTable()                  
        {                  
            return new T___BusinessPlan(DBConnectInterface.GetDBConn());                  
        }                  
                  
        public static T___BusinessPlan GetRowWhereIDUsingSQL(int pID)                  
        {                  
            return new T___BusinessPlan(DBConnectInterface.GetDBConn(), string.Format("SELECT * FROM {0} WHERE ID={1}", (object)pID)).GetFirstRow();                  
        }                  
                  
        public T___BusinessPlan GetRowWhereID(int pID)                  
        {                  
            return new T___BusinessPlan(this.RawTable, pID);                  
        }                  
                  
        private bool IsAllRowEqual(T___BusinessPlan pRow, params DataColumnParameter[] pParams)                  
        {                  
            try                  
            {                  
                if (!this.HasRows())                  
                    return false;                  
                foreach (var pParam in pParams)                  
                {                  
                    if (!pRow.RowEqual(pParam.ColumnName, pParam.Value))                  
                        return false;                  
                }                  
                  
                return true;                  
            }                  
            catch (Exception)                  
            {                  
                return false;                  
            }                  
        }                  
                  
        private bool IsAnyRowEqual(T___BusinessPlan pRow, params DataColumnParameter[] pParams)                  
        {                  
            try                  
            {                  
                if (!this.HasRows())                  
                    return false;                  
                foreach (var pParam in pParams)                  
                {                  
                    if (pRow.RowEqual(pParam.ColumnName, pParam.Value))                  
                        return true;                  
                }                  
                  
                return false;                  
            }                  
            catch (Exception )                  
            {                  
                return false;                  
            }                  
        }                  
                  
        /// <summary>                                                       
        /// Returns Empty class on failure                                                       
        /// </summary>                                                       
        /// <returns></returns>                                                       
        /// <remarks></remarks>                  
        public T___BusinessPlan GetAllRowsEquals(params DataColumnParameter[] pParams)                  
        {                  
            if (pParams is null || pParams.Count() == 0 || !this.HasRows())                  
                return this;                  
            try                  
            {                  
                IEnumerable<DataRow> drst = from dr in this.AllRows                  
                                            where IsAllRowEqual(new T___BusinessPlan(dr), pParams)                  
                                            select dr;                  
                if (drst is object && drst.Count() > 0)                  
                    return new T___BusinessPlan(drst);                  
                return null;                  
            }                  
            catch (Exception)                  
            {                  
                // REM                errorMsg(ex.Message, 1)                                                       
                return null;                  
            }                  
        }                  
                  
        /// <summary>                                                       
        /// Returns Empty class on failure                                                       
        /// </summary>                                                       
        /// <returns></returns>                                                       
        /// <remarks></remarks>                  
        public T___BusinessPlan getAllRowsAny(params DataColumnParameter[] pParams)                  
        {                  
            if (pParams is null || pParams.Count() == 0 || !this.HasRows())                  
                return this;                  
            try                  
            {                  
                IEnumerable<DataRow> drst = from dr in this.AllRows                  
                                            where IsAnyRowEqual(new T___BusinessPlan(dr), pParams)                  
                                            select dr;                  
                if (drst is object && drst.Count() > 0)                  
                    return new T___BusinessPlan(drst);                  
                return null;                  
            }                  
            catch (Exception)                  
            {                  
                // REM errorMsg(ex.Message, 1)                                                       
                return null;                  
            }                  
        }                  
                  
        public Dictionary<string, DataColumnDefinition> getDefinitions()                  
        {                  
            return ColumnDefns;                  
        }                  
                  
        private bool RowEqual(string pColumnName, object pColumnValue)                  
        {                  
            try                  
            {                  
                if (!this.IsTargettedRowValid)                  
                    return false;                  
                switch (DataColumnDefinition.getTypeAllowed(ColumnDefns[pColumnName].DataType))                  
                {                  
                    case var @case when @case == DataColumnDefinition.AllowedDataTypes.Bool:                  
                        {                  
                            return EBoolean.valueOf(this.TargettedRow[pColumnName]) == EBoolean.valueOf(pColumnValue);                  
                        }                  
                  
                    case var case1 when case1 == DataColumnDefinition.AllowedDataTypes.Blob:                  
                        {                  
                            return object.Equals(this.TargettedRow[pColumnName], pColumnValue);                  
                        }                  
                  
                    case var case2 when case2 == DataColumnDefinition.AllowedDataTypes.DateTime:                  
                        {                  
                            return EDateTime.EqualsDateWithoutTime(new NullableDateTime(this.TargettedRow[pColumnName]).DateTimeValue, new NullableDateTime(pColumnValue).DateTimeValue);                  
                        }                  
                  
                    case var case3 when case3 == DataColumnDefinition.AllowedDataTypes.Decimal:                  
                        {                  
                            return EDouble.valueOf(this.TargettedRow[pColumnName]) == EDouble.valueOf(pColumnValue);                  
                        }                  
                  
                    case var case4 when case4 == DataColumnDefinition.AllowedDataTypes.Int:                  
                        {                  
                            return EInt.valueOf(this.TargettedRow[pColumnName]) == EInt.valueOf(pColumnValue);                  
                        }                  
                  
                    case var case5 when case5 == DataColumnDefinition.AllowedDataTypes.Long:                  
                        {                  
                            return ELong.valueOf(this.TargettedRow[pColumnName]) == ELong.valueOf(pColumnValue);                  
                        }                  
                  
                    case var case6 when case6 == DataColumnDefinition.AllowedDataTypes.String:                  
                        {                  
                            return EStrings.equalsIgnoreCase(EStrings.valueOf(this.TargettedRow[pColumnName]), EStrings.valueOf(pColumnValue));                  
                        }                  
                  
                    case var case7 when case7 == DataColumnDefinition.AllowedDataTypes.TimeSpan:                  
                        {                  
                            return object.Equals(this.TargettedRow[pColumnName], pColumnValue);                  
                        }                  
                  
                    default:                  
                        {                  
                            // REM DataColumnDefinition.AllowedDataTypes.UNKNOWN()                                                       
                            return object.Equals(this.TargettedRow[pColumnName], pColumnValue);                  
                        }                  
                }                  
            }                  
            catch (Exception)                  
            {                  
                return false;                  
            }                  
        }                  

                  
        public List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> getForeignKeys()                  
        {                  
            return ForeignKeys;                  
        }                  
                  
        public string getTableName()                  
        {                  
            return TABLE_NAME;                  
        }                  

                  
        public virtual string getFillSQL(){                
            return BusinessPlan__NO__BINARY___SQL_FILL_QUERY;                  
        }                  
                  
                  
                  
#endregion                  
                  
                  




        public static int AddNewDefault(Int32 pAcademicSessionID){

            try{

                DataColumnParameter paramID = new DataColumnParameter(defID, DatabaseInit.DBConnectInterface.GetDBConn().GETNewID(TABLE_NAME));
                DataColumnParameter paramAcademicSessionID = new DataColumnParameter(defAcademicSessionID, pAcademicSessionID);
                DataColumnParameter paramStudentPopulation = new DataColumnParameter(defStudentPopulation, defStudentPopulation.DefaultValue);
                DataColumnParameter paramAveragePricePerStudent = new DataColumnParameter(defAveragePricePerStudent, defAveragePricePerStudent.DefaultValue);
                DataColumnParameter paramSCADWAREAccessRevenue = new DataColumnParameter(defSCADWAREAccessRevenue, defSCADWAREAccessRevenue.DefaultValue);
                DataColumnParameter paramSideContractRevenue = new DataColumnParameter(defSideContractRevenue, defSideContractRevenue.DefaultValue);
                DataColumnParameter paramGrossRevenue = new DataColumnParameter(defGrossRevenue, defGrossRevenue.DefaultValue);
                DataColumnParameter paramWages = new DataColumnParameter(defWages, defWages.DefaultValue);
                DataColumnParameter paramMarketing = new DataColumnParameter(defMarketing, defMarketing.DefaultValue);
                DataColumnParameter paramCharity = new DataColumnParameter(defCharity, defCharity.DefaultValue);
                DataColumnParameter paramOthers = new DataColumnParameter(defOthers, defOthers.DefaultValue);
                DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, defCreatedAt.DefaultValue);
                DataColumnParameter paramUpdatedAt = new DataColumnParameter(defUpdatedAt, defUpdatedAt.DefaultValue);


                DBConnectInterface.GetDBConn().DbExec(
                     String.Format("SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[AcademicSessionID],[StudentPopulation],[AveragePricePerStudent],[SCADWAREAccessRevenue],[SideContractRevenue],[GrossRevenue],[Wages],[Marketing],[Charity],[Others],[CreatedAt],[UpdatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,                paramID.getSQLQuotedValueForAdd(),
                paramAcademicSessionID.getSQLQuotedValueForAdd(),
                paramStudentPopulation.getSQLQuotedValueForAdd(),
                paramAveragePricePerStudent.getSQLQuotedValueForAdd(),
                paramSCADWAREAccessRevenue.getSQLQuotedValueForAdd(),
                paramSideContractRevenue.getSQLQuotedValueForAdd(),
                paramGrossRevenue.getSQLQuotedValueForAdd(),
                paramWages.getSQLQuotedValueForAdd(),
                paramMarketing.getSQLQuotedValueForAdd(),
                paramCharity.getSQLQuotedValueForAdd(),
                paramOthers.getSQLQuotedValueForAdd(),
                paramCreatedAt.getSQLQuotedValueForAdd(),
                paramUpdatedAt.getSQLQuotedValueForAdd()  ), true);




                  
                return EInt.valueOf(paramID.Value);                   
            }catch (Exception){                   
                throw;                   
            }                   
        }                   




                  
                  
        public static bool DeleteItemRow(long pID)                                    
        {                  
            return DeleteRow(DBConnectInterface.GetDBConn(), pID: pID, pTableName: TABLE_NAME);                  
        }                                    


   }


}
