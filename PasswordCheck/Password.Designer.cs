namespace PasswordCheck
{
    partial class Password
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.isName = new System.Windows.Forms.CheckBox();
            this.isEmail = new System.Windows.Forms.CheckBox();
            this.isDictionary = new System.Windows.Forms.CheckBox();
            this.passLength = new System.Windows.Forms.NumericUpDown();
            this.numSpecial = new System.Windows.Forms.NumericUpDown();
            this.numNumeric = new System.Windows.Forms.NumericUpDown();
            this.numLower = new System.Windows.Forms.NumericUpDown();
            this.numUpper = new System.Windows.Forms.NumericUpDown();
            this.firstName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.inpassword = new System.Windows.Forms.TextBox();
            this.checkButton = new System.Windows.Forms.Button();
            this.generatePass = new System.Windows.Forms.Button();
            this.validPassword = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.numPasswords = new System.Windows.Forms.NumericUpDown();
            this.PasswordList = new System.Windows.Forms.ListBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.passLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSpecial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPasswords)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Minimum Password Length";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(269, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Required # of Uppercase Characters";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(268, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Required # of Lowercase Characters";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(243, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Required # of Special Characters";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(249, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Required # of Numeric Characters";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // isName
            // 
            this.isName.AutoSize = true;
            this.isName.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.isName.Location = new System.Drawing.Point(60, 166);
            this.isName.Name = "isName";
            this.isName.Size = new System.Drawing.Size(283, 24);
            this.isName.TabIndex = 11;
            this.isName.Text = "User\'s Name Allowed in Password?";
            this.isName.UseVisualStyleBackColor = true;
            this.isName.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // isEmail
            // 
            this.isEmail.AutoSize = true;
            this.isEmail.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.isEmail.Location = new System.Drawing.Point(60, 196);
            this.isEmail.Name = "isEmail";
            this.isEmail.Size = new System.Drawing.Size(236, 24);
            this.isEmail.TabIndex = 12;
            this.isEmail.Text = "E-mail Allowed in Password?";
            this.isEmail.UseVisualStyleBackColor = true;
            this.isEmail.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // isDictionary
            // 
            this.isDictionary.AutoSize = true;
            this.isDictionary.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.isDictionary.Location = new System.Drawing.Point(60, 226);
            this.isDictionary.Name = "isDictionary";
            this.isDictionary.Size = new System.Drawing.Size(312, 24);
            this.isDictionary.TabIndex = 13;
            this.isDictionary.Text = "Dictionary Words Allowed in Password?";
            this.isDictionary.UseVisualStyleBackColor = true;
            // 
            // passLength
            // 
            this.passLength.Location = new System.Drawing.Point(223, 7);
            this.passLength.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.passLength.Name = "passLength";
            this.passLength.Size = new System.Drawing.Size(120, 26);
            this.passLength.TabIndex = 15;
            this.passLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.passLength.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // numSpecial
            // 
            this.numSpecial.Location = new System.Drawing.Point(336, 135);
            this.numSpecial.Name = "numSpecial";
            this.numSpecial.Size = new System.Drawing.Size(120, 26);
            this.numSpecial.TabIndex = 16;
            this.numSpecial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numSpecial.ValueChanged += new System.EventHandler(this.numSpecial_ValueChanged);
            // 
            // numNumeric
            // 
            this.numNumeric.Location = new System.Drawing.Point(336, 103);
            this.numNumeric.Name = "numNumeric";
            this.numNumeric.Size = new System.Drawing.Size(120, 26);
            this.numNumeric.TabIndex = 17;
            this.numNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numNumeric.ValueChanged += new System.EventHandler(this.numNumeric_ValueChanged);
            // 
            // numLower
            // 
            this.numLower.Location = new System.Drawing.Point(336, 71);
            this.numLower.Name = "numLower";
            this.numLower.Size = new System.Drawing.Size(120, 26);
            this.numLower.TabIndex = 18;
            this.numLower.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numLower.ValueChanged += new System.EventHandler(this.numLower_ValueChanged);
            // 
            // numUpper
            // 
            this.numUpper.Location = new System.Drawing.Point(336, 39);
            this.numUpper.Name = "numUpper";
            this.numUpper.Size = new System.Drawing.Size(120, 26);
            this.numUpper.TabIndex = 19;
            this.numUpper.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numUpper.ValueChanged += new System.EventHandler(this.numUpper_ValueChanged);
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(646, 10);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(218, 26);
            this.firstName.TabIndex = 20;
            this.firstName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(525, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "First Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(525, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 20);
            this.label7.TabIndex = 23;
            this.label7.Text = "Last Name";
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(646, 42);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(218, 26);
            this.lastName.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(525, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 20);
            this.label8.TabIndex = 25;
            this.label8.Text = "E-mail";
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(646, 74);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(218, 26);
            this.emailBox.TabIndex = 24;
            this.emailBox.TextChanged += new System.EventHandler(this.emailBox_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(332, 341);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 20);
            this.label9.TabIndex = 27;
            this.label9.Text = "Password";
            // 
            // inpassword
            // 
            this.inpassword.Location = new System.Drawing.Point(453, 338);
            this.inpassword.Name = "inpassword";
            this.inpassword.PasswordChar = '*';
            this.inpassword.Size = new System.Drawing.Size(218, 26);
            this.inpassword.TabIndex = 26;
            this.inpassword.TextChanged += new System.EventHandler(this.inpassword_TextChanged);
            // 
            // checkButton
            // 
            this.checkButton.Location = new System.Drawing.Point(336, 370);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(190, 40);
            this.checkButton.TabIndex = 28;
            this.checkButton.Text = "Check Password";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // generatePass
            // 
            this.generatePass.Location = new System.Drawing.Point(697, 422);
            this.generatePass.Name = "generatePass";
            this.generatePass.Size = new System.Drawing.Size(190, 40);
            this.generatePass.TabIndex = 29;
            this.generatePass.Text = "Generate Password(s)";
            this.generatePass.UseVisualStyleBackColor = true;
            this.generatePass.Click += new System.EventHandler(this.generatePass_Click);
            // 
            // validPassword
            // 
            this.validPassword.AutoSize = true;
            this.validPassword.Location = new System.Drawing.Point(978, 233);
            this.validPassword.Name = "validPassword";
            this.validPassword.Size = new System.Drawing.Size(0, 20);
            this.validPassword.TabIndex = 30;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(332, 432);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(249, 20);
            this.label10.TabIndex = 31;
            this.label10.Text = "Amount of passwords to generate";
            // 
            // numPasswords
            // 
            this.numPasswords.Location = new System.Drawing.Point(613, 430);
            this.numPasswords.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numPasswords.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPasswords.Name = "numPasswords";
            this.numPasswords.Size = new System.Drawing.Size(58, 26);
            this.numPasswords.TabIndex = 32;
            this.numPasswords.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numPasswords.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // PasswordList
            // 
            this.PasswordList.FormattingEnabled = true;
            this.PasswordList.ItemHeight = 20;
            this.PasswordList.Location = new System.Drawing.Point(916, 341);
            this.PasswordList.Name = "PasswordList";
            this.PasswordList.Size = new System.Drawing.Size(283, 204);
            this.PasswordList.TabIndex = 33;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(697, 468);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(190, 40);
            this.saveButton.TabIndex = 34;
            this.saveButton.Text = "Save Password(s)";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(912, 318);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(167, 20);
            this.label11.TabIndex = 35;
            this.label11.Text = "Generated Passwords";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(532, 370);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 40);
            this.button1.TabIndex = 36;
            this.button1.Text = "Save Results";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 577);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.PasswordList);
            this.Controls.Add(this.numPasswords);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.validPassword);
            this.Controls.Add(this.generatePass);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.inpassword);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.numUpper);
            this.Controls.Add(this.numLower);
            this.Controls.Add(this.numNumeric);
            this.Controls.Add(this.numSpecial);
            this.Controls.Add(this.passLength);
            this.Controls.Add(this.isDictionary);
            this.Controls.Add(this.isEmail);
            this.Controls.Add(this.isName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Password";
            this.Text = "Password";
            this.Load += new System.EventHandler(this.Password_Load);
            ((System.ComponentModel.ISupportInitialize)(this.passLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSpecial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPasswords)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox isName;
        private System.Windows.Forms.CheckBox isEmail;
        private System.Windows.Forms.CheckBox isDictionary;
        private System.Windows.Forms.NumericUpDown passLength;
        private System.Windows.Forms.NumericUpDown numSpecial;
        private System.Windows.Forms.NumericUpDown numNumeric;
        private System.Windows.Forms.NumericUpDown numLower;
        private System.Windows.Forms.NumericUpDown numUpper;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox inpassword;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.Button generatePass;
        private System.Windows.Forms.Label validPassword;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numPasswords;
        private System.Windows.Forms.ListBox PasswordList;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
    }
}

