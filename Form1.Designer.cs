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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnConnectionTest = new Button();
            btnLoadData = new Button();
            dgvStudentInfo = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            tbxLname = new TextBox();
            tbxFname = new TextBox();
            btnInsert = new Button();
            btnDel = new Button();
            btnUpdate = new Button();
            tbxCourse = new TextBox();
            label4 = new Label();
            tbxYlevel = new TextBox();
            label5 = new Label();
            tbxCourseNo = new TextBox();
            label6 = new Label();
            tbxFGrade1 = new TextBox();
            label7 = new Label();
            tbxStudentID = new TextBox();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            testConnectionToolStripMenuItem = new ToolStripMenuItem();
            loadDataToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvStudentInfo).BeginInit();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnConnectionTest
            // 
            btnConnectionTest.Location = new Point(148, 1429);
            btnConnectionTest.Margin = new Padding(7, 8, 7, 8);
            btnConnectionTest.Name = "btnConnectionTest";
            btnConnectionTest.Size = new Size(318, 63);
            btnConnectionTest.TabIndex = 0;
            btnConnectionTest.Text = "Test Connection";
            btnConnectionTest.UseVisualStyleBackColor = true;
            btnConnectionTest.Click += btnConnectionTest_Click;
            // 
            // btnLoadData
            // 
            btnLoadData.Location = new Point(481, 1429);
            btnLoadData.Margin = new Padding(7, 8, 7, 8);
            btnLoadData.Name = "btnLoadData";
            btnLoadData.Size = new Size(318, 63);
            btnLoadData.TabIndex = 1;
            btnLoadData.Text = "Load Data";
            btnLoadData.UseVisualStyleBackColor = true;
            btnLoadData.Click += btnLoadData_Click;
            // 
            // dgvStudentInfo
            // 
            dgvStudentInfo.BackgroundColor = SystemColors.ButtonHighlight;
            dgvStudentInfo.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dgvStudentInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudentInfo.Cursor = Cursors.Cross;
            dgvStudentInfo.GridColor = SystemColors.GradientInactiveCaption;
            dgvStudentInfo.Location = new Point(974, 81);
            dgvStudentInfo.Margin = new Padding(7, 8, 7, 8);
            dgvStudentInfo.Name = "dgvStudentInfo";
            dgvStudentInfo.RowHeadersWidth = 102;
            dgvStudentInfo.Size = new Size(1372, 1412);
            dgvStudentInfo.TabIndex = 3;
            dgvStudentInfo.CellClick += dgvStudentInfo_CellClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 162);
            label2.Margin = new Padding(7, 0, 7, 0);
            label2.Name = "label2";
            label2.Size = new Size(190, 41);
            label2.TabIndex = 5;
            label2.Text = "LAST NAME: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 241);
            label3.Margin = new Padding(7, 0, 7, 0);
            label3.Name = "label3";
            label3.Size = new Size(189, 41);
            label3.TabIndex = 6;
            label3.Text = "FIRST NAME:";
            // 
            // tbxLname
            // 
            tbxLname.Location = new Point(260, 156);
            tbxLname.Margin = new Padding(7, 8, 7, 8);
            tbxLname.Name = "tbxLname";
            tbxLname.Size = new Size(507, 47);
            tbxLname.TabIndex = 8;
            // 
            // tbxFname
            // 
            tbxFname.Location = new Point(260, 235);
            tbxFname.Margin = new Padding(7, 8, 7, 8);
            tbxFname.Name = "tbxFname";
            tbxFname.Size = new Size(507, 47);
            tbxFname.TabIndex = 9;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(183, 1350);
            btnInsert.Margin = new Padding(7, 8, 7, 8);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(182, 63);
            btnInsert.TabIndex = 10;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnDel
            // 
            btnDel.Location = new Point(380, 1350);
            btnDel.Margin = new Padding(7, 8, 7, 8);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(182, 63);
            btnDel.TabIndex = 11;
            btnDel.Text = "Delete";
            btnDel.UseVisualStyleBackColor = true;
            btnDel.Click += btnDel_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(577, 1350);
            btnUpdate.Margin = new Padding(7, 8, 7, 8);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(182, 63);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // tbxCourse
            // 
            tbxCourse.Location = new Point(260, 312);
            tbxCourse.Margin = new Padding(7, 8, 7, 8);
            tbxCourse.Name = "tbxCourse";
            tbxCourse.Size = new Size(507, 47);
            tbxCourse.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 310);
            label4.Margin = new Padding(7, 0, 7, 0);
            label4.Name = "label4";
            label4.Size = new Size(136, 41);
            label4.TabIndex = 13;
            label4.Text = "COURSE:";
            // 
            // tbxYlevel
            // 
            tbxYlevel.Location = new Point(260, 388);
            tbxYlevel.Margin = new Padding(7, 8, 7, 8);
            tbxYlevel.Name = "tbxYlevel";
            tbxYlevel.Size = new Size(507, 47);
            tbxYlevel.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 386);
            label5.Margin = new Padding(7, 0, 7, 0);
            label5.Name = "label5";
            label5.Size = new Size(179, 41);
            label5.TabIndex = 15;
            label5.Text = "YEAR LEVEL:";
            // 
            // tbxCourseNo
            // 
            tbxCourseNo.Location = new Point(260, 460);
            tbxCourseNo.Margin = new Padding(7, 8, 7, 8);
            tbxCourseNo.Name = "tbxCourseNo";
            tbxCourseNo.Size = new Size(507, 47);
            tbxCourseNo.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 460);
            label6.Margin = new Padding(7, 0, 7, 0);
            label6.Name = "label6";
            label6.Size = new Size(196, 41);
            label6.TabIndex = 17;
            label6.Text = "COURSE NO.:";
            // 
            // tbxFGrade1
            // 
            tbxFGrade1.Location = new Point(260, 535);
            tbxFGrade1.Margin = new Padding(7, 8, 7, 8);
            tbxFGrade1.Name = "tbxFGrade1";
            tbxFGrade1.Size = new Size(507, 47);
            tbxFGrade1.TabIndex = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(17, 535);
            label7.Margin = new Padding(7, 0, 7, 0);
            label7.Name = "label7";
            label7.Size = new Size(229, 41);
            label7.TabIndex = 19;
            label7.Text = "FINAL GRADE 1:";
            // 
            // tbxStudentID
            // 
            tbxStudentID.Location = new Point(260, 81);
            tbxStudentID.Margin = new Padding(7, 8, 7, 8);
            tbxStudentID.Name = "tbxStudentID";
            tbxStudentID.ReadOnly = true;
            tbxStudentID.Size = new Size(507, 47);
            tbxStudentID.TabIndex = 21;
            tbxStudentID.TextAlign = HorizontalAlignment.Right;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 81);
            label1.Margin = new Padding(7, 0, 7, 0);
            label1.Name = "label1";
            label1.Size = new Size(189, 41);
            label1.TabIndex = 22;
            label1.Text = "STUDENT ID:";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(40, 40);
            menuStrip1.Items.AddRange(new ToolStripItem[] { testConnectionToolStripMenuItem, loadDataToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(2375, 49);
            menuStrip1.TabIndex = 23;
            menuStrip1.Text = "menuStrip1";
            // 
            // testConnectionToolStripMenuItem
            // 
            testConnectionToolStripMenuItem.Name = "testConnectionToolStripMenuItem";
            testConnectionToolStripMenuItem.Size = new Size(255, 45);
            testConnectionToolStripMenuItem.Text = "Test Connection";
            testConnectionToolStripMenuItem.Click += testConnectionToolStripMenuItem_Click;
            // 
            // loadDataToolStripMenuItem
            // 
            loadDataToolStripMenuItem.Name = "loadDataToolStripMenuItem";
            loadDataToolStripMenuItem.Size = new Size(176, 45);
            loadDataToolStripMenuItem.Text = "Load Data";
            loadDataToolStripMenuItem.Click += loadDataToolStripMenuItem_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(141, 675);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(600, 600);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(2375, 1525);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(tbxStudentID);
            Controls.Add(tbxFGrade1);
            Controls.Add(label7);
            Controls.Add(tbxCourseNo);
            Controls.Add(label6);
            Controls.Add(tbxYlevel);
            Controls.Add(label5);
            Controls.Add(tbxCourse);
            Controls.Add(label4);
            Controls.Add(btnUpdate);
            Controls.Add(btnDel);
            Controls.Add(btnInsert);
            Controls.Add(tbxFname);
            Controls.Add(tbxLname);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dgvStudentInfo);
            Controls.Add(btnLoadData);
            Controls.Add(btnConnectionTest);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(7, 8, 7, 8);
            MaximumSize = new Size(2407, 1613);
            MinimumSize = new Size(2407, 1613);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvStudentInfo).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConnectionTest;
        private Button btnLoadData;
        private DataGridView dgvStudentInfo;
        private Label label2;
        private Label label3;
        private TextBox tbxLname;
        private TextBox tbxFname;
        private Button btnInsert;
        private Button btnDel;
        private Button btnUpdate;
        private TextBox tbxCourse;
        private Label label4;
        private TextBox tbxYlevel;
        private Label label5;
        private TextBox tbxCourseNo;
        private Label label6;
        private TextBox tbxFGrade1;
        private Label label7;
        private TextBox tbxStudentID;
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem testConnectionToolStripMenuItem;
        private ToolStripMenuItem loadDataToolStripMenuItem;
        private PictureBox pictureBox1;
    }
}
