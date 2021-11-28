using System;
using CODERiT.Logger.Standard.VB;

namespace EEntityCore.DB.MSSQL
{

    // 
    // 
    // 
    // 
    // 

    public class Program
    {
        static Program()
        {
            Logger = new Log1(typeof(Program)).Load(Log1.Modes.FILE, true);
        }



        #region Properties




        internal static Log1 Logger { get; set; }

        public static string ApplicationStartUpPath
        {
            get
            {
                return AppDomain.CurrentDomain.BaseDirectory;
            }
        }


        #endregion


        #region Enums



        #endregion










        #region Methods



        #endregion





    }
}