using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace IMDBS
{
   public partial class Form1 : Form
   {
      private OleDbConnection con;

      public Form1()
      {
         InitializeComponent();
         con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\\Programming\\NET Core\\IMDBS\\LibSysdb.mdb");
      }

      private void Form1_Load(object sender, EventArgs e)
      {
         loadDatagrid();
      }

      private void loadDatagrid()
      {
         try
         {
            con.Open();
            OleDbCommand com = new OleDbCommand("SELECT accession_number AS [ACCESSION NUMBER], title AS [TITLE], author AS [AUTHOR] FROM book ORDER BY accession_number", con);
            com.ExecuteNonQuery();

            OleDbDataAdapter adap = new OleDbDataAdapter(com);
            DataTable tab = new DataTable();

            adap.Fill(tab);
            datagridViewBooks.DataSource = tab;

            con.Close();
         }

         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }
      }

      private void btnAdd_Click(object sender, EventArgs e)
      {
         try
         {
            con.Open();
            OleDbCommand com = new OleDbCommand("INSERT INTO book(accession_number, title, author) VALUES('" + txtNo.Text + "', '" + txtTitle.Text + "', '" + txtAuthor.Text + "')", con);
            com.ExecuteNonQuery();

            MessageBox.Show("Successfully SAVED!", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            con.Close();
            loadDatagrid();
            clearTextField();
         }

         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }
      }

      private void btnDelete_Click(object sender, EventArgs e)
      {
         try
         {
            con.Open();

            var dr = MessageBox.Show("Are you sure you want to delete this?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
               OleDbCommand com = new OleDbCommand("DELETE FROM book WHERE accession_number = '" + txtNo.Text + "' ", con);
               com.ExecuteNonQuery();
               MessageBox.Show("Successfully DELETED!", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
               clearTextField();
            }
            else
            {
               MessageBox.Show("CANCELLED!", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            con.Close();
            loadDatagrid();
         }

         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }
      }

      private void txtSearch_TextChanged(object sender, EventArgs e)
      {
         try
         {
            con.Open();
            OleDbCommand com = new OleDbCommand("SELECT * FROM book WHERE title LIKE '" + txtSearch.Text + "%'", con);
            com.ExecuteNonQuery();

            OleDbDataAdapter adap = new OleDbDataAdapter(com);
            DataTable tab = new DataTable();

            adap.Fill(tab);
            datagridViewBooks.DataSource = tab;

            con.Close();
         }

         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }
      }

      private void datagridViewBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
      {
         txtNo.Text = datagridViewBooks[0, e.RowIndex].Value.ToString();
         txtTitle.Text = datagridViewBooks[1, e.RowIndex].Value.ToString();
         txtAuthor.Text = datagridViewBooks[2, e.RowIndex].Value.ToString();
      }

      private void btnEdit_Click(object sender, EventArgs e)
      {
         try
         {
            con.Open();

            OleDbCommand com = new OleDbCommand("UPDATE book SET title = '" + txtTitle.Text + "', author = '" + txtAuthor.Text + "' WHERE accession_number = '" + txtNo.Text + "' ", con);
            com.ExecuteNonQuery();

            MessageBox.Show("Successfully UPDATED!", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            con.Close();
            loadDatagrid();
            clearTextField();
         }

         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }
      }

      private void clearTextField()
      {
         txtNo.Clear();
         txtTitle.Clear();
         txtAuthor.Clear();
      }
   }
}
