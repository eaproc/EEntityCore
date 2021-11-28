using System;
using System.Collections.Generic;

namespace EEntityCore.DB.MSSQL.Interfaces
{
    public interface IDBTableDefinitionPlugIn
    {
        public enum ReferentialAction
        {
            NO_ACTION,
            CASCADE,
            SET_NULL,
            SET_DEFAULT,
            UNKNOWN
        }

        [Serializable()]
        public struct ForeignKeyDefinition
        {
            public ForeignKeyDefinition(string pForeignKeyName, bool pIs_disabled, string pDelete_referential_action_desc, string pParentName, string pReferencedParentName)
            {
                ForeignKeyName = pForeignKeyName;
                is_disabled = pIs_disabled;
                delete_referential_action_desc = ReferentialAction.UNKNOWN;
                ParentName = pParentName;
                ReferencedParentName = pReferencedParentName;
                switch (pDelete_referential_action_desc ?? "")
                {
                    case var @case when @case == (ReferentialAction.CASCADE.ToString() ?? ""):
                        {
                            delete_referential_action_desc = ReferentialAction.CASCADE;
                            break;
                        }

                    case var case1 when case1 == (ReferentialAction.NO_ACTION.ToString() ?? ""):
                        {
                            delete_referential_action_desc = ReferentialAction.NO_ACTION;
                            break;
                        }

                    case var case2 when case2 == (ReferentialAction.SET_DEFAULT.ToString() ?? ""):
                        {
                            delete_referential_action_desc = ReferentialAction.SET_DEFAULT;
                            break;
                        }

                    case var case3 when case3 == (ReferentialAction.SET_NULL.ToString() ?? ""):
                        {
                            delete_referential_action_desc = ReferentialAction.SET_NULL;
                            break;
                        }
                }
            }

            public ForeignKeyDefinition(string pForeignKeyName, bool pIs_disabled, ReferentialAction pDelete_referential_action_desc, string pParentName, string pReferencedParentName)
            {
                ForeignKeyName = pForeignKeyName;
                is_disabled = pIs_disabled;
                delete_referential_action_desc = pDelete_referential_action_desc;
                ParentName = pParentName;
                ReferencedParentName = pReferencedParentName;
            }

            public string ForeignKeyName;
            public bool is_disabled;
            public ReferentialAction delete_referential_action_desc;
            public string ParentName;
            public string ReferencedParentName;
        }




        /// <summary>
        /// Return the names of tables this view depend on
        /// </summary>
        /// <returns></returns>
        /// <remarks></remarks>
        List<ForeignKeyDefinition> GetForeignKeys();
        string GetTableName();
        string GetFillSQL();
    }
}