using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace IMDBS
{
   public class Function
   {
      public static string gen = "";
      public static OleDbConnection con;
      public static OleDbCommand command;
      public static OleDbDataReader reader;

      public static void fill(string q, DataGridView dgv) // gen(query), datagrid
      {
         try
         {
            Connection.DB();
            DataTable dt = new DataTable();
            OleDbDataAdapter data = null;
            OleDbCommand command = new OleDbCommand(q, Connection.con);
            data = new OleDbDataAdapter(command);
            data.Fill(dt);
            dgv.DataSource = dt;
            Connection.con.Close();
         }
         catch (Exception e)
         {
            MessageBox.Show(e.Message);
         }
      }
   }
}
