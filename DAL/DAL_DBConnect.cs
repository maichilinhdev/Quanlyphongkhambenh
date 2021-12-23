using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_DBConnect //CHU Y la PUBLIC class
    {
        //Class chua Connection
       // static string dirExc = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase).Remove(0, 6);

        static string cnnStr = @"Data Source=DESKTOP-87UNAA4\SQLEXPRESS01;Initial Catalog=PKBSGD;Integrated Security=True";

       // static string cnnStr = @"Data Source=.\SQLEXPRESS; AttachDbFilename="+ dirExc + @"\QLPMT.mdf;Integrated Security=True";


        protected SqlConnection _cn = new SqlConnection(cnnStr);


    }
}
