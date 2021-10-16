
namespace IMDBS
{
   partial class Form1
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.txtNo = new System.Windows.Forms.TextBox();
         this.txtAuthor = new System.Windows.Forms.TextBox();
         this.txtTitle = new System.Windows.Forms.TextBox();
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.label4 = new System.Windows.Forms.Label();
         this.txtSearch = new System.Windows.Forms.TextBox();
         this.datagridViewBooks = new System.Windows.Forms.DataGridView();
         this.btnAdd = new System.Windows.Forms.Button();
         this.btnEdit = new System.Windows.Forms.Button();
         this.btnDelete = new System.Windows.Forms.Button();
         this.btnCancel = new System.Windows.Forms.Button();
         this.btnShow = new System.Windows.Forms.Button();
         ((System.ComponentModel.ISupportInitialize)(this.datagridViewBooks)).BeginInit();
         this.SuspendLayout();
         // 
         // txtNo
         // 
         this.txtNo.Location = new System.Drawing.Point(286, 82);
         this.txtNo.Name = "txtNo";
         this.txtNo.Size = new System.Drawing.Size(100, 20);
         this.txtNo.TabIndex = 0;
         // 
         // txtAuthor
         // 
         this.txtAuthor.Location = new System.Drawing.Point(286, 134);
         this.txtAuthor.Name = "txtAuthor";
         this.txtAuthor.Size = new System.Drawing.Size(100, 20);
         this.txtAuthor.TabIndex = 1;
         // 
         // txtTitle
         // 
         this.txtTitle.Location = new System.Drawing.Point(286, 108);
         this.txtTitle.Name = "txtTitle";
         this.txtTitle.Size = new System.Drawing.Size(100, 20);
         this.txtTitle.TabIndex = 2;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(174, 88);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(96, 13);
         this.label1.TabIndex = 3;
         this.label1.Text = "Accession Number";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(174, 115);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(27, 13);
         this.label2.TabIndex = 4;
         this.label2.Text = "Title";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(174, 141);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(38, 13);
         this.label3.TabIndex = 5;
         this.label3.Text = "Author";
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(58, 219);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(41, 13);
         this.label4.TabIndex = 6;
         this.label4.Text = "Search";
         // 
         // txtSearch
         // 
         this.txtSearch.Location = new System.Drawing.Point(112, 212);
         this.txtSearch.Name = "txtSearch";
         this.txtSearch.Size = new System.Drawing.Size(139, 20);
         this.txtSearch.TabIndex = 7;
         this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
         // 
         // datagridViewBooks
         // 
         this.datagridViewBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.datagridViewBooks.Location = new System.Drawing.Point(196, 238);
         this.datagridViewBooks.Name = "datagridViewBooks";
         this.datagridViewBooks.Size = new System.Drawing.Size(444, 185);
         this.datagridViewBooks.TabIndex = 8;
         this.datagridViewBooks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridViewBooks_CellContentClick);
         // 
         // btnAdd
         // 
         this.btnAdd.Location = new System.Drawing.Point(517, 65);
         this.btnAdd.Name = "btnAdd";
         this.btnAdd.Size = new System.Drawing.Size(75, 23);
         this.btnAdd.TabIndex = 9;
         this.btnAdd.Text = "Add";
         this.btnAdd.UseVisualStyleBackColor = true;
         this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
         // 
         // btnEdit
         // 
         this.btnEdit.Location = new System.Drawing.Point(517, 141);
         this.btnEdit.Name = "btnEdit";
         this.btnEdit.Size = new System.Drawing.Size(75, 23);
         this.btnEdit.TabIndex = 10;
         this.btnEdit.Text = "Edit";
         this.btnEdit.UseVisualStyleBackColor = true;
         this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
         // 
         // btnDelete
         // 
         this.btnDelete.Location = new System.Drawing.Point(517, 105);
         this.btnDelete.Name = "btnDelete";
         this.btnDelete.Size = new System.Drawing.Size(75, 23);
         this.btnDelete.TabIndex = 11;
         this.btnDelete.Text = "Delete";
         this.btnDelete.UseVisualStyleBackColor = true;
         this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
         // 
         // btnCancel
         // 
         this.btnCancel.Location = new System.Drawing.Point(631, 105);
         this.btnCancel.Name = "btnCancel";
         this.btnCancel.Size = new System.Drawing.Size(75, 23);
         this.btnCancel.TabIndex = 12;
         this.btnCancel.Text = "Cancel";
         this.btnCancel.UseVisualStyleBackColor = true;
         // 
         // btnShow
         // 
         this.btnShow.Location = new System.Drawing.Point(631, 65);
         this.btnShow.Name = "btnShow";
         this.btnShow.Size = new System.Drawing.Size(75, 23);
         this.btnShow.TabIndex = 13;
         this.btnShow.Text = "Show";
         this.btnShow.UseVisualStyleBackColor = true;
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(800, 450);
         this.Controls.Add(this.btnShow);
         this.Controls.Add(this.btnCancel);
         this.Controls.Add(this.btnDelete);
         this.Controls.Add(this.btnEdit);
         this.Controls.Add(this.btnAdd);
         this.Controls.Add(this.datagridViewBooks);
         this.Controls.Add(this.txtSearch);
         this.Controls.Add(this.label4);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.txtTitle);
         this.Controls.Add(this.txtAuthor);
         this.Controls.Add(this.txtNo);
         this.Name = "Form1";
         this.Text = "Library System";
         this.Load += new System.EventHandler(this.Form1_Load);
         ((System.ComponentModel.ISupportInitialize)(this.datagridViewBooks)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.TextBox txtNo;
      private System.Windows.Forms.TextBox txtAuthor;
      private System.Windows.Forms.TextBox txtTitle;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.TextBox txtSearch;
      private System.Windows.Forms.DataGridView datagridViewBooks;
      private System.Windows.Forms.Button btnAdd;
      private System.Windows.Forms.Button btnEdit;
      private System.Windows.Forms.Button btnDelete;
      private System.Windows.Forms.Button btnCancel;
      private System.Windows.Forms.Button btnShow;
   }
}

