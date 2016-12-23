namespace Forms
{
    partial class BookForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.BookListPanel = new System.Windows.Forms.Panel();
            this.BooksGrid = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookPanel = new System.Windows.Forms.Panel();
            this.Clear = new System.Windows.Forms.Button();
            this.AddABook = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.amountBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.yearBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.titleBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.authorBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BookListPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BooksGrid)).BeginInit();
            this.BookPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BookListPanel
            // 
            this.BookListPanel.Controls.Add(this.BooksGrid);
            this.BookListPanel.Location = new System.Drawing.Point(13, 13);
            this.BookListPanel.Name = "BookListPanel";
            this.BookListPanel.Size = new System.Drawing.Size(283, 294);
            this.BookListPanel.TabIndex = 0;
            // 
            // BooksGrid
            // 
            this.BooksGrid.AllowUserToAddRows = false;
            this.BooksGrid.AllowUserToDeleteRows = false;
            this.BooksGrid.AllowUserToResizeColumns = false;
            this.BooksGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.BooksGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BooksGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Author,
            this.Title,
            this.Year,
            this.Amount});
            this.BooksGrid.Location = new System.Drawing.Point(4, 4);
            this.BooksGrid.Name = "BooksGrid";
            this.BooksGrid.RowHeadersVisible = false;
            this.BooksGrid.Size = new System.Drawing.Size(276, 283);
            this.BooksGrid.TabIndex = 0;
            this.BooksGrid.SelectionChanged += new System.EventHandler(this.BooksGrid_SelectionChanged);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            this.Id.Width = 22;
            // 
            // Author
            // 
            this.Author.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Author.HeaderText = "Author";
            this.Author.Name = "Author";
            this.Author.Width = 63;
            // 
            // Title
            // 
            this.Title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            // 
            // Year
            // 
            this.Year.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Year.HeaderText = "Year";
            this.Year.Name = "Year";
            this.Year.Width = 54;
            // 
            // Amount
            // 
            this.Amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.Width = 68;
            // 
            // BookPanel
            // 
            this.BookPanel.Controls.Add(this.Clear);
            this.BookPanel.Controls.Add(this.AddABook);
            this.BookPanel.Controls.Add(this.Delete);
            this.BookPanel.Controls.Add(this.Edit);
            this.BookPanel.Controls.Add(this.amountBox);
            this.BookPanel.Controls.Add(this.label4);
            this.BookPanel.Controls.Add(this.yearBox);
            this.BookPanel.Controls.Add(this.label3);
            this.BookPanel.Controls.Add(this.titleBox);
            this.BookPanel.Controls.Add(this.label2);
            this.BookPanel.Controls.Add(this.authorBox);
            this.BookPanel.Controls.Add(this.label1);
            this.BookPanel.Location = new System.Drawing.Point(303, 13);
            this.BookPanel.Name = "BookPanel";
            this.BookPanel.Size = new System.Drawing.Size(166, 294);
            this.BookPanel.TabIndex = 1;
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(15, 177);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(142, 23);
            this.Clear.TabIndex = 5;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // AddABook
            // 
            this.AddABook.Location = new System.Drawing.Point(15, 206);
            this.AddABook.Name = "AddABook";
            this.AddABook.Size = new System.Drawing.Size(142, 23);
            this.AddABook.TabIndex = 6;
            this.AddABook.Text = "AddABook";
            this.AddABook.UseVisualStyleBackColor = true;
            this.AddABook.Click += new System.EventHandler(this.AddABook_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(15, 264);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(142, 23);
            this.Delete.TabIndex = 8;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(15, 235);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(142, 23);
            this.Edit.TabIndex = 7;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // amountBox
            // 
            this.amountBox.Location = new System.Drawing.Point(15, 151);
            this.amountBox.Name = "amountBox";
            this.amountBox.Size = new System.Drawing.Size(142, 20);
            this.amountBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Amount";
            // 
            // yearBox
            // 
            this.yearBox.Location = new System.Drawing.Point(15, 111);
            this.yearBox.Name = "yearBox";
            this.yearBox.Size = new System.Drawing.Size(142, 20);
            this.yearBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Year";
            // 
            // titleBox
            // 
            this.titleBox.Location = new System.Drawing.Point(15, 71);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(142, 20);
            this.titleBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Title";
            // 
            // authorBox
            // 
            this.authorBox.Location = new System.Drawing.Point(15, 31);
            this.authorBox.Name = "authorBox";
            this.authorBox.Size = new System.Drawing.Size(142, 20);
            this.authorBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Author";
            // 
            // BookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 390);
            this.Controls.Add(this.BookPanel);
            this.Controls.Add(this.BookListPanel);
            this.Name = "BookForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.BookListPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BooksGrid)).EndInit();
            this.BookPanel.ResumeLayout(false);
            this.BookPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BookListPanel;
        private System.Windows.Forms.Panel BookPanel;
        private System.Windows.Forms.DataGridView BooksGrid;
        private System.Windows.Forms.Button AddABook;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.TextBox amountBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox yearBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox authorBox;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
    }
}

