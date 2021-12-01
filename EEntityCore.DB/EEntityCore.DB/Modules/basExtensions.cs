using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace EEntityCore.DB.Modules
{
    public static class basExtensions
    {

        // You must implement New() which you will use to pass in the table name. Anyways we will pass it for you


        /// <summary>
        /// This will split this table rows into classes containing 1 row each. AT most
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="pObj"></param>
        /// <returns></returns>
        /// <remarks></remarks>
        public static IEnumerable<T> AsEnumerableDBTable<T>(this T pObj) where T : Abstracts.SimpleTablePlugIn, new()
        {
            var drst = new List<T>();
            if (pObj is null || !pObj.HasRows())
                return drst;
            drst = (from dr in pObj.AllRows
                    select new T().LoadGeneric<T>(dr)).ToList();
            return drst;
        }

        /// <summary>
        /// Convert as Generic method on DB to conver SimplePlugin to Anyother 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="pObj"></param>
        /// <returns></returns>
        /// <remarks></remarks>
        public static T As<T>(this Abstracts.SimpleTablePlugIn pObj) where T : Abstracts.SimpleTablePlugIn, new()
        {
            var drst = new T();
            if (pObj is null || !pObj.HasRows() || !pObj.IsTargettedRowValid)
                return drst;

            return drst.LoadGeneric<T>(pObj.TargettedRow);
        }

        /// <summary>
        /// This return first row according to ID Asc
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="pObj"></param>
        /// <returns></returns>
        /// <remarks></remarks>
        public static List<T> SortedRows<T>(this T pObj) where T : Abstracts.SimpleTablePlugIn, new()
        {
            List<T> drst;
            if (pObj is null || !pObj.HasRows())
                return new List<T>();
            drst = (from dr in pObj.AllRows
                    select new T().LoadGeneric<T>(dr)).OrderBy(x => x.ID).ToList();
            return drst;
        }

        /// <summary>
        /// This return first row according to ID Asc
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="pObj"></param>
        /// <returns></returns>
        /// <remarks></remarks>
        public static T GetFirstRowIDASC<T>(this T pObj) where T : Abstracts.SimpleTablePlugIn, new()
        {
            return pObj.SortedRows().First();
        }


        /// <summary>
        /// This return last row according to ID Asc
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="pObj"></param>
        /// <returns></returns>
        /// <remarks></remarks>
        public static T GetLastRowIDASC<T>(this T pObj) where T : Abstracts.SimpleTablePlugIn, new()
        {
            return pObj.SortedRows().Last();
        }


        /// <summary>
        /// This return last row if any row is availble
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="pObj"></param>
        /// <returns></returns>
        /// <remarks></remarks>
        public static T ExtractLastRow<T>(this T pObj) where T : Abstracts.SimpleTablePlugIn, new()
        {
            if (pObj is null || !pObj.HasRows())
                return new T();
            return pObj.AsEnumerableDBTable().Last();
        }


        /// <summary>
        /// returns first row if any
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="pObj"></param>
        /// <returns></returns>
        /// <remarks></remarks>
        public static T ExtractFirstRow<T>(this T pObj) where T : Abstracts.SimpleTablePlugIn, new()
        {
            if (pObj is null || !pObj.HasRows())
                return new T();
            return pObj.AsEnumerableDBTable().First();
        }


        /// <summary>
        /// gets net ID from the rows loaded using linq
        /// </summary>
        /// <returns></returns>
        /// <remarks></remarks>
        public static long GetNextID<T>(this T pObj) where T : Abstracts.SimpleTablePlugIn, new()
        {
            if (!pObj.HasRows())
                return 1L; // Might be empty table
            if (!pObj.HasNumericPrimaryKeyColumn)
                throw new Exception("This table doesnt contain a numeric primary key");
            return pObj.GetLastRowIDASC().ID + 1L;
        }

        /// <summary>
        /// gets net ID from the rows loaded using linq
        /// </summary>
        /// <returns></returns>
        /// <remarks></remarks>
        public static DataTable FirstTable(this DataSet pObj)
        {
            return pObj==null || pObj.Tables.Count == 0 ? null : pObj.Tables[0];
        }


        /// <summary>
        /// Converts DB Null to system understandable type
        /// </summary>
        /// <returns></returns>
        /// <remarks></remarks>
        public static object GetDBValueConverted<T>(this DataRow row, string columnName)
        {
            var r = row[columnName];

            if ( typeof(T) == typeof(string) )
                return r == null || r is System.DBNull ? null : r;

            return r == null || r is System.DBNull ? null : (T)r;
        }
    }
}