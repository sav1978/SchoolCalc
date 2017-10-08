using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SQLite;

namespace SchoolCalc
{
    public class Globals
    {
        public static string DbName = "SchoolCalc.sqlite";
        
        public static string Version = "3.2"; // app version/db version    

        public static string Saldo_2016_2017 = "0";

        public static SQLiteConnection Connection = null;
    }
}
