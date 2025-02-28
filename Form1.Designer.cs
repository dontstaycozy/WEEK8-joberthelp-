namespace WEEK8
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
            btnConnectionTest = new Button();
            btnLoadData = new Button();
            dgvStudentInfo = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbxID = new TextBox();
            tbxLname = new TextBox();
            tbxFname = new TextBox();
            btnInsert = new Button();
            btnDel = new Button();
            btnUpdate = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvStudentInfo).BeginInit();
            SuspendLayout();
            // 
            // btnConnectionTest
            // 
            btnConnectionTest.Location = new Point(12, 523);
            btnConnectionTest.Name = "btnConnectionTest";
            btnConnectionTest.Size = new Size(131, 23);
            btnConnectionTest.TabIndex = 0;
            btnConnectionTest.Text = "Connection Test";
            btnConnectionTest.UseVisualStyleBackColor = true;
            btnConnectionTest.Click += btnConnectionTest_Click;
            // 
            // btnLoadData
            // 
            btnLoadData.Location = new Point(149, 523);
            btnLoadData.Name = "btnLoadData";
            btnLoadData.Size = new Size(131, 23);
            btnLoadData.TabIndex = 1;
            btnLoadData.Text = "Load Data";
            btnLoadData.UseVisualStyleBackColor = true;
            btnLoadData.Click += btnLoadData_Click;
            // 
            // dgvStudentInfo
            // 
            dgvStudentInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudentInfo.Location = new Point(401, 12);
            dgvStudentInfo.Name = "dgvStudentInfo";
            dgvStudentInfo.Size = new Size(565, 534);
            dgvStudentInfo.TabIndex = 3;
            dgvStudentInfo.CellClick += dgvStudentInfo_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(2, 27);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 4;
            label1.Text = "STUDENT ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(2, 56);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 5;
            label2.Text = "LAST NAME: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(2, 85);
            label3.Name = "label3";
            label3.Size = new Size(75, 15);
            label3.TabIndex = 6;
            label3.Text = "FIRST NAME:";
            // 
            // tbxID
            // 
            tbxID.Location = new Point(81, 24);
            tbxID.Name = "tbxID";
            tbxID.Size = new Size(211, 23);
            tbxID.TabIndex = 7;
            // 
            // tbxLname
            // 
            tbxLname.Location = new Point(81, 53);
            tbxLname.Name = "tbxLname";
            tbxLname.Size = new Size(211, 23);
            tbxLname.TabIndex = 8;
            // 
            // tbxFname
            // 
            tbxFname.Location = new Point(81, 82);
            tbxFname.Name = "tbxFname";
            tbxFname.Size = new Size(211, 23);
            tbxFname.TabIndex = 9;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(24, 137);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(75, 23);
            btnInsert.TabIndex = 10;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnDel
            // 
            btnDel.Location = new Point(105, 137);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(75, 23);
            btnDel.TabIndex = 11;
            btnDel.Text = "Delete";
            btnDel.UseVisualStyleBackColor = true;
            btnDel.Click += btnDel_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(186, 137);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 558);
            Controls.Add(btnUpdate);
            Controls.Add(btnDel);
            Controls.Add(btnInsert);
            Controls.Add(tbxFname);
            Controls.Add(tbxLname);
            Controls.Add(tbxID);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvStudentInfo);
            Controls.Add(btnLoadData);
            Controls.Add(btnConnectionTest);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvStudentInfo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConnectionTest;
        private Button btnLoadData;
        private DataGridView dgvStudentInfo;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbxID;
        private TextBox tbxLname;
        private TextBox tbxFname;
        private Button btnInsert;
        private Button btnDel;
        private Button btnUpdate;
    }
}
