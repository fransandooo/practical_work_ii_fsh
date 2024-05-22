namespace PracticalWorkII
{
    partial class UserInfo
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
            PasswordLabel = new Label();
            UsernameLabel = new Label();
            EmailLabel = new Label();
            NameLabel = new Label();
            OperationsLabel = new Label();
            UpdateInfoButton = new Button();
            newNameBox = new TextBox();
            newEmailBox = new TextBox();
            newUsernameBox = new TextBox();
            newPasswordBox = new TextBox();
            buttonExit = new Button();
            SuspendLayout();
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Font = new Font("Arial Narrow", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            PasswordLabel.Location = new Point(12, 296);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(199, 40);
            PasswordLabel.TabIndex = 5;
            PasswordLabel.Text = "PASSWORD: ";
            PasswordLabel.Click += PasswordLabel_Click;
            // 
            // UsernameLabel
            // 
            UsernameLabel.AutoSize = true;
            UsernameLabel.Font = new Font("Arial Narrow", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            UsernameLabel.Location = new Point(12, 198);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(194, 40);
            UsernameLabel.TabIndex = 4;
            UsernameLabel.Text = "USERNAME: ";
            UsernameLabel.Click += UsernameLabel_Click;
            // 
            // EmailLabel
            // 
            EmailLabel.AutoSize = true;
            EmailLabel.Font = new Font("Arial Narrow", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            EmailLabel.Location = new Point(12, 116);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(121, 40);
            EmailLabel.TabIndex = 7;
            EmailLabel.Text = "EMAIL: ";
            EmailLabel.Click += EmailLabel_Click;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("Arial Narrow", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            NameLabel.Location = new Point(12, 18);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(116, 40);
            NameLabel.TabIndex = 6;
            NameLabel.Text = "NAME: ";
            NameLabel.Click += NameLabel_Click;
            // 
            // OperationsLabel
            // 
            OperationsLabel.AutoSize = true;
            OperationsLabel.Font = new Font("Arial Narrow", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            OperationsLabel.Location = new Point(12, 377);
            OperationsLabel.Name = "OperationsLabel";
            OperationsLabel.Size = new Size(220, 40);
            OperationsLabel.TabIndex = 8;
            OperationsLabel.Text = "OPERATIONS: ";
            OperationsLabel.Click += OperationsLabel_Click;
            // 
            // UpdateInfoButton
            // 
            UpdateInfoButton.BackColor = SystemColors.GradientActiveCaption;
            UpdateInfoButton.Font = new Font("Arial Narrow", 18F, FontStyle.Regular, GraphicsUnit.Point);
            UpdateInfoButton.Location = new Point(467, 386);
            UpdateInfoButton.Name = "UpdateInfoButton";
            UpdateInfoButton.Size = new Size(189, 52);
            UpdateInfoButton.TabIndex = 10;
            UpdateInfoButton.Text = "UPDATE INFO";
            UpdateInfoButton.UseVisualStyleBackColor = false;
            UpdateInfoButton.Click += UpdateInfoButton_Click;
            // 
            // newNameBox
            // 
            newNameBox.BorderStyle = BorderStyle.FixedSingle;
            newNameBox.Location = new Point(467, 32);
            newNameBox.Name = "newNameBox";
            newNameBox.PlaceholderText = "New Name";
            newNameBox.Size = new Size(202, 27);
            newNameBox.TabIndex = 9;
            newNameBox.TextChanged += newNameBox_TextChanged;
            // 
            // newEmailBox
            // 
            newEmailBox.BorderStyle = BorderStyle.FixedSingle;
            newEmailBox.Location = new Point(467, 130);
            newEmailBox.Name = "newEmailBox";
            newEmailBox.PlaceholderText = "New Email";
            newEmailBox.Size = new Size(202, 27);
            newEmailBox.TabIndex = 11;
            newEmailBox.TextChanged += newEmailBox_TextChanged;
            // 
            // newUsernameBox
            // 
            newUsernameBox.BorderStyle = BorderStyle.FixedSingle;
            newUsernameBox.Location = new Point(467, 211);
            newUsernameBox.Name = "newUsernameBox";
            newUsernameBox.PlaceholderText = "New Username";
            newUsernameBox.Size = new Size(202, 27);
            newUsernameBox.TabIndex = 12;
            newUsernameBox.TextChanged += newUsernameBox_TextChanged;
            // 
            // newPasswordBox
            // 
            newPasswordBox.BorderStyle = BorderStyle.FixedSingle;
            newPasswordBox.Location = new Point(467, 309);
            newPasswordBox.Name = "newPasswordBox";
            newPasswordBox.PlaceholderText = "New Password";
            newPasswordBox.Size = new Size(202, 27);
            newPasswordBox.TabIndex = 13;
            newPasswordBox.TextChanged += newPasswordBox_TextChanged;
            // 
            // buttonExit
            // 
            buttonExit.BackColor = SystemColors.ActiveCaption;
            buttonExit.Font = new Font("Arial Narrow", 17F, FontStyle.Regular, GraphicsUnit.Point);
            buttonExit.Location = new Point(680, 386);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(108, 52);
            buttonExit.TabIndex = 25;
            buttonExit.Text = "Exit";
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click;
            // 
            // UserInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonExit);
            Controls.Add(newPasswordBox);
            Controls.Add(newUsernameBox);
            Controls.Add(newEmailBox);
            Controls.Add(UpdateInfoButton);
            Controls.Add(newNameBox);
            Controls.Add(OperationsLabel);
            Controls.Add(EmailLabel);
            Controls.Add(NameLabel);
            Controls.Add(PasswordLabel);
            Controls.Add(UsernameLabel);
            Name = "UserInfo";
            Text = "UserInfo";
            Load += UserInfo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label PasswordLabel;
        private Label UsernameLabel;
        private Label EmailLabel;
        private Label NameLabel;
        private Label OperationsLabel;
        private Button UpdateInfoButton;
        private TextBox newNameBox;
        private TextBox newEmailBox;
        private TextBox newUsernameBox;
        private TextBox newPasswordBox;
        private Button buttonExit;
    }
}