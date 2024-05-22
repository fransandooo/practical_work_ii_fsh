namespace PracticalWorkII
{
    partial class Register
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private State state; // i need to call the variable state from the class state here so i can use it in the form class


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
            label1 = new Label();
            NameBox = new TextBox();
            UsernameBox = new TextBox();
            PasswordBox = new TextBox();
            RepeatPasswordBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            checkBox1 = new CheckBox();
            RegisterButton = new Button();
            linkLabel1 = new LinkLabel();
            label6 = new Label();
            EmailBox = new TextBox();
            buttonExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.GradientActiveCaption;
            label1.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(-4, 0);
            label1.Name = "label1";
            label1.Size = new Size(703, 61);
            label1.TabIndex = 0;
            label1.Text = "OOP CALCULATOR";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // NameBox
            // 
            NameBox.BorderStyle = BorderStyle.FixedSingle;
            NameBox.Location = new Point(234, 91);
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(232, 25);
            NameBox.TabIndex = 1;
            NameBox.TextChanged += NameBox_TextChanged;
            // 
            // UsernameBox
            // 
            UsernameBox.BorderStyle = BorderStyle.FixedSingle;
            UsernameBox.Location = new Point(234, 155);
            UsernameBox.Name = "UsernameBox";
            UsernameBox.Size = new Size(232, 25);
            UsernameBox.TabIndex = 2;
            UsernameBox.TextChanged += UsernameBox_TextChanged;
            // 
            // PasswordBox
            // 
            PasswordBox.BorderStyle = BorderStyle.FixedSingle;
            PasswordBox.Location = new Point(234, 258);
            PasswordBox.Name = "PasswordBox";
            PasswordBox.PasswordChar = '*';
            PasswordBox.Size = new Size(232, 25);
            PasswordBox.TabIndex = 4;
            PasswordBox.TextChanged += PasswordBox_TextChanged;
            // 
            // RepeatPasswordBox
            // 
            RepeatPasswordBox.BorderStyle = BorderStyle.FixedSingle;
            RepeatPasswordBox.Location = new Point(234, 327);
            RepeatPasswordBox.Name = "RepeatPasswordBox";
            RepeatPasswordBox.PasswordChar = '*';
            RepeatPasswordBox.Size = new Size(232, 25);
            RepeatPasswordBox.TabIndex = 3;
            RepeatPasswordBox.TextChanged += RepeatPasswordBox_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(234, 64);
            label2.Name = "label2";
            label2.Size = new Size(55, 24);
            label2.TabIndex = 5;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(234, 128);
            label3.Name = "label3";
            label3.Size = new Size(86, 24);
            label3.TabIndex = 6;
            label3.Text = "Username";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(234, 232);
            label4.Name = "label4";
            label4.Size = new Size(82, 24);
            label4.TabIndex = 7;
            label4.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(234, 300);
            label5.Name = "label5";
            label5.Size = new Size(140, 24);
            label5.TabIndex = 8;
            label5.Text = "Repeat Password";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(362, 358);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(104, 24);
            checkBox1.TabIndex = 9;
            checkBox1.Text = "Policy Terms";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // RegisterButton
            // 
            RegisterButton.BackColor = SystemColors.GradientActiveCaption;
            RegisterButton.Font = new Font("Arial Narrow", 18F, FontStyle.Regular, GraphicsUnit.Point);
            RegisterButton.Location = new Point(264, 388);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(154, 45);
            RegisterButton.TabIndex = 10;
            RegisterButton.Text = "REGISTER";
            RegisterButton.UseVisualStyleBackColor = false;
            RegisterButton.Click += RegisterButton_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Arial Narrow", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel1.LinkColor = Color.RoyalBlue;
            linkLabel1.Location = new Point(511, 403);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(177, 22);
            linkLabel1.TabIndex = 11;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Already Registered? Login";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(234, 181);
            label6.Name = "label6";
            label6.Size = new Size(51, 24);
            label6.TabIndex = 13;
            label6.Text = "Email";
            // 
            // EmailBox
            // 
            EmailBox.BorderStyle = BorderStyle.FixedSingle;
            EmailBox.Location = new Point(234, 208);
            EmailBox.Name = "EmailBox";
            EmailBox.Size = new Size(232, 25);
            EmailBox.TabIndex = 12;
            EmailBox.TextChanged += EmailBox_TextChanged;
            // 
            // buttonExit
            // 
            buttonExit.BackColor = SystemColors.ActiveCaption;
            buttonExit.Font = new Font("Arial Narrow", 17F, FontStyle.Regular, GraphicsUnit.Point);
            buttonExit.Location = new Point(12, 368);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(139, 70);
            buttonExit.TabIndex = 25;
            buttonExit.Text = "Exit";
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 450);
            Controls.Add(buttonExit);
            Controls.Add(label6);
            Controls.Add(EmailBox);
            Controls.Add(linkLabel1);
            Controls.Add(RegisterButton);
            Controls.Add(checkBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(PasswordBox);
            Controls.Add(RepeatPasswordBox);
            Controls.Add(UsernameBox);
            Controls.Add(NameBox);
            Controls.Add(label1);
            Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Register";
            Text = "OOP CALCULATOR (REGISTER)";
            Load += Register_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox NameBox;
        private TextBox UsernameBox;
        private TextBox PasswordBox;
        private TextBox RepeatPasswordBox;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private CheckBox checkBox1;
        private Button RegisterButton;
        private LinkLabel linkLabel1;
        private Label label6;
        private TextBox EmailBox;
        private Button buttonExit;
    }
}