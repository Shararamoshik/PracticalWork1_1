namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtTitle = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtAuthor = new TextBox();
            nudYear = new TextBox();
            label4 = new Label();
            btnCreate = new Button();
            listBoxBooks = new CheckedListBox();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnGroupByAuthor = new Button();
            btnSearchByYear = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(119, 95);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(125, 27);
            txtTitle.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 98);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 2;
            label2.Text = "название";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(64, 130);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 3;
            label3.Text = "автор";
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(119, 127);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(125, 27);
            txtAuthor.TabIndex = 4;
            // 
            // nudYear
            // 
            nudYear.Location = new Point(119, 160);
            nudYear.Name = "nudYear";
            nudYear.Size = new Size(125, 27);
            nudYear.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(81, 163);
            label4.Name = "label4";
            label4.Size = new Size(32, 20);
            label4.TabIndex = 6;
            label4.Text = "год";
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(57, 193);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(150, 35);
            btnCreate.TabIndex = 7;
            btnCreate.Text = "Создать";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // listBoxBooks
            // 
            listBoxBooks.FormattingEnabled = true;
            listBoxBooks.Location = new Point(297, 56);
            listBoxBooks.Name = "listBoxBooks";
            listBoxBooks.Size = new Size(346, 466);
            listBoxBooks.TabIndex = 8;
            listBoxBooks.SelectedIndexChanged += listBoxBooks_SelectedIndexChanged;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(81, 275);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(90, 28);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Удалить";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(57, 234);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(150, 35);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "Обновить";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnGroupByAuthor
            // 
            btnGroupByAuthor.Location = new Point(57, 321);
            btnGroupByAuthor.Name = "btnGroupByAuthor";
            btnGroupByAuthor.Size = new Size(140, 50);
            btnGroupByAuthor.TabIndex = 11;
            btnGroupByAuthor.Text = "Группировать по авторам";
            btnGroupByAuthor.UseVisualStyleBackColor = true;
            btnGroupByAuthor.Click += btnGroupByAuthor_Click;
            // 
            // btnSearchByYear
            // 
            btnSearchByYear.Location = new Point(57, 377);
            btnSearchByYear.Name = "btnSearchByYear";
            btnSearchByYear.Size = new Size(140, 50);
            btnSearchByYear.TabIndex = 12;
            btnSearchByYear.Text = "Поиск по году";
            btnSearchByYear.UseVisualStyleBackColor = true;
            btnSearchByYear.Click += btnSearchByYear_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(297, 33);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 13;
            label1.Text = "книги:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(672, 544);
            Controls.Add(label1);
            Controls.Add(btnSearchByYear);
            Controls.Add(btnGroupByAuthor);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(listBoxBooks);
            Controls.Add(btnCreate);
            Controls.Add(label4);
            Controls.Add(nudYear);
            Controls.Add(txtAuthor);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtTitle);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTitle;
        private Label label2;
        private Label label3;
        private TextBox txtAuthor;
        private TextBox nudYear;
        private Label label4;
        private Button btnCreate;
        private CheckedListBox listBoxBooks;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnGroupByAuthor;
        private Button btnSearchByYear;
        private Label label1;
    }
}
