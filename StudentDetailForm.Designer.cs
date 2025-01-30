namespace DatagirdView
{
    partial class StudentDetailForm
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
            groupBox1 = new GroupBox();
            btnUpdate = new Button();
            cmbExamName = new ComboBox();
            txtGrade = new TextBox();
            txtStudentID = new TextBox();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            label5 = new Label();
            label4 = new Label();
            lblID = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnUpdate);
            groupBox1.Controls.Add(cmbExamName);
            groupBox1.Controls.Add(txtGrade);
            groupBox1.Controls.Add(txtStudentID);
            groupBox1.Controls.Add(txtLastName);
            groupBox1.Controls.Add(txtFirstName);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(lblID);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(343, 281);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Exams";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(123, 246);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // cmbExamName
            // 
            cmbExamName.AutoCompleteCustomSource.AddRange(new string[] { "Görsel Progamlama", "Yazılım Test Ve Doğrulama", "Sayısal analiz" });
            cmbExamName.FormattingEnabled = true;
            cmbExamName.Items.AddRange(new object[] { "Visual Programming", "Mobile Programming", "Programming Language" });
            cmbExamName.Location = new Point(93, 158);
            cmbExamName.Name = "cmbExamName";
            cmbExamName.Size = new Size(151, 28);
            cmbExamName.TabIndex = 9;
            // 
            // txtGrade
            // 
            txtGrade.Location = new Point(106, 203);
            txtGrade.Name = "txtGrade";
            txtGrade.Size = new Size(125, 27);
            txtGrade.TabIndex = 8;
            // 
            // txtStudentID
            // 
            txtStudentID.Location = new Point(106, 116);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(125, 27);
            txtStudentID.TabIndex = 7;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(106, 75);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(125, 27);
            txtLastName.TabIndex = 6;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(106, 37);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(125, 27);
            txtFirstName.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 203);
            label5.Name = "label5";
            label5.Size = new Size(52, 20);
            label5.TabIndex = 4;
            label5.Text = "Grade:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 158);
            label4.Name = "label4";
            label4.Size = new Size(48, 20);
            label4.TabIndex = 3;
            label4.Text = "Exam:";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(11, 116);
            lblID.Name = "lblID";
            lblID.Size = new Size(82, 20);
            lblID.TabIndex = 2;
            lblID.Text = "Student ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 73);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 1;
            label2.Text = "Last Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 44);
            label1.Name = "label1";
            label1.Size = new Size(83, 20);
            label1.TabIndex = 0;
            label1.Text = "First Name:";
            // 
            // StudentDetailForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "StudentDetailForm";
            Text = "StudentDetailForm";
            Load += StudentDetailForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnUpdate;
        private ComboBox cmbExamName;
        private TextBox txtGrade;
        private TextBox txtStudentID;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private Label label5;
        private Label label4;
        private Label lblID;
        private Label label2;
        private Label label1;
    }
}