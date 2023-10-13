namespace OrganizationProfile
{
    partial class frmRegistration
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
            txtStudentNo = new TextBox();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            txtMiddleInitial = new TextBox();
            txtAge = new TextBox();
            txtContactNo = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            cbPrograms = new ComboBox();
            cbGender = new ComboBox();
            datePickerBirthday = new DateTimePicker();
            btnRegister = new Button();
            SuspendLayout();
            // 
            // txtStudentNo
            // 
            txtStudentNo.Location = new Point(127, 61);
            txtStudentNo.Name = "txtStudentNo";
            txtStudentNo.Size = new Size(252, 23);
            txtStudentNo.TabIndex = 0;
            txtStudentNo.TextChanged += textBox1_TextChanged;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(127, 104);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(252, 23);
            txtLastName.TabIndex = 1;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(497, 105);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(138, 23);
            txtFirstName.TabIndex = 2;
            // 
            // txtMiddleInitial
            // 
            txtMiddleInitial.Location = new Point(685, 105);
            txtMiddleInitial.Name = "txtMiddleInitial";
            txtMiddleInitial.Size = new Size(74, 23);
            txtMiddleInitial.TabIndex = 3;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(127, 152);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(100, 23);
            txtAge.TabIndex = 4;
            // 
            // txtContactNo
            // 
            txtContactNo.Location = new Point(580, 201);
            txtContactNo.Name = "txtContactNo";
            txtContactNo.Size = new Size(154, 23);
            txtContactNo.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(30, 63);
            label1.Name = "label1";
            label1.Size = new Size(91, 21);
            label1.TabIndex = 6;
            label1.Text = "Student No.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(23, 15);
            label2.Name = "label2";
            label2.Size = new Size(175, 37);
            label2.TabIndex = 7;
            label2.Text = "Registration";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(37, 107);
            label3.Name = "label3";
            label3.Size = new Size(84, 21);
            label3.TabIndex = 8;
            label3.Text = "Last Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(84, 154);
            label4.Name = "label4";
            label4.Size = new Size(37, 21);
            label4.TabIndex = 9;
            label4.Text = "Age";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(53, 201);
            label5.Name = "label5";
            label5.Size = new Size(68, 21);
            label5.TabIndex = 10;
            label5.Text = "Birthday";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(420, 63);
            label6.Name = "label6";
            label6.Size = new Size(71, 21);
            label6.TabIndex = 11;
            label6.Text = "Program";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(405, 107);
            label7.Name = "label7";
            label7.Size = new Size(86, 21);
            label7.TabIndex = 12;
            label7.Text = "First Name";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(641, 107);
            label8.Name = "label8";
            label8.Size = new Size(38, 21);
            label8.TabIndex = 13;
            label8.Text = "M. I.";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(430, 152);
            label9.Name = "label9";
            label9.Size = new Size(61, 21);
            label9.TabIndex = 14;
            label9.Text = "Gender";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(483, 203);
            label10.Name = "label10";
            label10.Size = new Size(91, 21);
            label10.TabIndex = 15;
            label10.Text = "Contact No.";
            label10.Click += label10_Click;
            // 
            // cbPrograms
            // 
            cbPrograms.FormattingEnabled = true;
            cbPrograms.Location = new Point(497, 61);
            cbPrograms.Name = "cbPrograms";
            cbPrograms.Size = new Size(262, 23);
            cbPrograms.TabIndex = 16;
            // 
            // cbGender
            // 
            cbGender.FormattingEnabled = true;
            cbGender.Location = new Point(497, 150);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(121, 23);
            cbGender.TabIndex = 17;
            // 
            // datePickerBirthday
            // 
            datePickerBirthday.Location = new Point(145, 201);
            datePickerBirthday.Name = "datePickerBirthday";
            datePickerBirthday.Size = new Size(288, 23);
            datePickerBirthday.TabIndex = 18;
            // 
            // btnRegister
            // 
            btnRegister.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegister.Location = new Point(342, 261);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(105, 34);
            btnRegister.TabIndex = 19;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            // 
            // frmRegistration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(781, 319);
            Controls.Add(btnRegister);
            Controls.Add(datePickerBirthday);
            Controls.Add(cbGender);
            Controls.Add(cbPrograms);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtContactNo);
            Controls.Add(txtAge);
            Controls.Add(txtMiddleInitial);
            Controls.Add(txtFirstName);
            Controls.Add(txtLastName);
            Controls.Add(txtStudentNo);
            Name = "frmRegistration";
            Text = "Organization Profile";
            Load += frmRegistration_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtStudentNo;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private TextBox txtMiddleInitial;
        private TextBox txtAge;
        private TextBox txtContactNo;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private ComboBox cbPrograms;
        private ComboBox cbGender;
        private DateTimePicker datePickerBirthday;
        private Button btnRegister;
    }
}