using ELibrary.Standard.VB.Modules;

namespace EEntityCore.MSSQL.WebTest.DBEntities.DatabaseSchema
{
    public class DataColumnNullParamValue
    {
        public DataColumnNullParamValue()
        {
        }

        /// <summary>
        /// Returns Nothing too as null
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        /// <remarks></remarks>
        public override bool Equals(object obj)
        {
            if (obj is null)
                return true;
            if (obj is string && obj.ToString().equalsIgnoreCase(NULL_VALUE))
                return true;
            if (obj is DataColumnNullParamValue)
                return true;
            return false;
        }

        public const string NULL_VALUE = "--(*_*)- CODER => You Rock";

        public override int GetHashCode()
        {
            throw new System.NotImplementedException();
        }



        // Public Shared Narrowing Operator CType(ByVal v As DataColumnNullParamValue) As String
        // REM If v = NULL_VALUE Then Return New DataColumnNullParamValue()
        // Return Nothing
        // End Operator

        // Public Shared Widening Operator CType(ByVal v As String) As DataColumnNullParamValue
        // If v = NULL_VALUE Then Return New DataColumnNullParamValue()
        // Return Nothing
        // End Operator


    }
}