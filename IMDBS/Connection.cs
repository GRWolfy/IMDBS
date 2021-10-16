using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace IMDBS
{
   public class Connection
   {
      public static OleDbConnection con;
      private static string dbconnect = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\\Programming\\NET Core\\IMDBS\\LibSysdb.mdb"; //connection string 

      public static void DB()
      {
         try
         {
            con = new OleDbConnection(dbconnect);
            con.Open();
         }
         catch (Exception e)
         {
            con.Close();
            MessageBox.Show(e.Message);
         }
      }
   }
}
