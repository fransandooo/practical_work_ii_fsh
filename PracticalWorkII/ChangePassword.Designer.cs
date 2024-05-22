namespace PracticalWorkII
{
    partial class ChangePassword
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
            label3 = new Label();
            label4 = new Label();
            label1 = new Label();
            NewPasswordBox = new TextBox();
            UsernameBox = new TextBox();
            linkLabel2 = new LinkLabel();
            button1 = new Button();
            label2 = new Label();
            NametextBox = new TextBox();
            buttonExit = new Button();
            SuspendLayout();
            // 
            // label3
            // 
            label3.BackColor = SystemColors.GradientActiveCaption;
            label3.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(-1, -1);
            label3.Name = "label3";
            label3.Size = new Size(703, 61);
            label3.TabIndex = 6;
            label3.Text = "OOP CALCULATOR";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(228, 216);
            label4.Name = "label4";
            label4.Size = new Size(121, 24);
            label4.TabIndex = 11;
            label4.Text = "New Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(228, 153);
            label1.Name = "label1";
            label1.Size = new Size(86, 24);
            label1.TabIndex = 10;
            label1.Text = "Username";
            // 
            // NewPasswordBox
            // 
            NewPasswordBox.BorderStyle = BorderStyle.FixedSingle;
            NewPasswordBox.Location = new Point(228, 244);
            NewPasswordBox.Name = "NewPasswordBox";
            NewPasswordBox.PasswordChar = '*';
            NewPasswordBox.Size = new Size(232, 27);
            NewPasswordBox.TabIndex = 9;
            NewPasswordBox.TextChanged += NewPasswordBox_TextChanged;
            // 
            // UsernameBox
            // 
            UsernameBox.BorderStyle = BorderStyle.FixedSingle;
            UsernameBox.Location = new Point(228, 180);
            UsernameBox.Name = "UsernameBox";
            UsernameBox.Size = new Size(232, 27);
            UsernameBox.TabIndex = 8;
            UsernameBox.TextChanged += UsernameBox_TextChanged;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Font = new Font("Arial Narrow", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel2.LinkColor = Color.RoyalBlue;
            linkLabel2.Location = new Point(579, 399);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(96, 22);
            linkLabel2.TabIndex = 12;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Back to Login";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientActiveCaption;
            button1.Font = new Font("Arial Narrow", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(273, 330);
            button1.Name = "button1";
            button1.Size = new Size(151, 40);
            button1.TabIndex = 13;
            button1.Text = "CHANGE";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(234, 90);
            label2.Name = "label2";
            label2.Size = new Size(55, 24);
            label2.TabIndex = 15;
            label2.Text = "Name";
            // 
            // NametextBox
            // 
            NametextBox.BorderStyle = BorderStyle.FixedSingle;
            NametextBox.Location = new Point(229, 117);
            NametextBox.Name = "NametextBox";
            NametextBox.Size = new Size(232, 27);
            NametextBox.TabIndex = 14;
            NametextBox.TextChanged += NametextBox_TextChanged;
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
            // ChangePassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 450);
            Controls.Add(buttonExit);
            Controls.Add(label2);
            Controls.Add(NametextBox);
            Controls.Add(button1);
            Controls.Add(linkLabel2);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(NewPasswordBox);
            Controls.Add(UsernameBox);
            Controls.Add(label3);
            Name = "ChangePassword";
            Text = "ChnagePassword";
            Load += ChnagePassword_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label4;
        private Label label1;
        private TextBox NewPasswordBox;
        private TextBox UsernameBox;
        private LinkLabel linkLabel2;
        private Button button1;
        private Label label2;
        private TextBox NametextBox;
        private Button buttonExit;
    }
}