namespace PracticalWorkII
{
    partial class CalculatorInterface
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button0 = new Button();
            buttonComa = new Button();
            buttonSign = new Button();
            buttonAdd = new Button();
            buttonMinus = new Button();
            buttonMultiply = new Button();
            buttonDivision = new Button();
            buttonPow = new Button();
            buttonMod = new Button();
            buttonEquals = new Button();
            CalculatorTextBox = new TextBox();
            UserInfoButton = new Button();
            buttonCero = new Button();
            buttonExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.GradientActiveCaption;
            label1.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(-1, -19);
            label1.Name = "label1";
            label1.Size = new Size(703, 61);
            label1.TabIndex = 1;
            label1.Text = "OOP CALCULATOR";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Font = new Font("Arial Narrow", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(20, 129);
            button1.Name = "button1";
            button1.Size = new Size(70, 70);
            button1.TabIndex = 2;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Arial Narrow", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(116, 129);
            button2.Name = "button2";
            button2.Size = new Size(70, 70);
            button2.TabIndex = 3;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Arial Narrow", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(212, 129);
            button3.Name = "button3";
            button3.Size = new Size(70, 70);
            button3.TabIndex = 4;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Arial Narrow", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(20, 210);
            button4.Name = "button4";
            button4.Size = new Size(70, 70);
            button4.TabIndex = 7;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Arial Narrow", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(116, 210);
            button5.Name = "button5";
            button5.Size = new Size(70, 70);
            button5.TabIndex = 6;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Arial Narrow", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button6.Location = new Point(212, 210);
            button6.Name = "button6";
            button6.Size = new Size(70, 70);
            button6.TabIndex = 5;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Arial Narrow", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button7.Location = new Point(20, 291);
            button7.Name = "button7";
            button7.Size = new Size(70, 70);
            button7.TabIndex = 10;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Font = new Font("Arial Narrow", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button8.Location = new Point(116, 291);
            button8.Name = "button8";
            button8.Size = new Size(70, 70);
            button8.TabIndex = 9;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Font = new Font("Arial Narrow", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button9.Location = new Point(212, 291);
            button9.Name = "button9";
            button9.Size = new Size(70, 70);
            button9.TabIndex = 8;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button0
            // 
            button0.Font = new Font("Arial Narrow", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button0.Location = new Point(116, 372);
            button0.Name = "button0";
            button0.Size = new Size(70, 70);
            button0.TabIndex = 11;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            button0.Click += button0_Click;
            // 
            // buttonComa
            // 
            buttonComa.Font = new Font("Arial Narrow", 18F, FontStyle.Regular, GraphicsUnit.Point);
            buttonComa.Location = new Point(212, 372);
            buttonComa.Name = "buttonComa";
            buttonComa.Size = new Size(70, 70);
            buttonComa.TabIndex = 12;
            buttonComa.Text = ",";
            buttonComa.UseVisualStyleBackColor = true;
            buttonComa.Click += buttonComa_Click;
            // 
            // buttonSign
            // 
            buttonSign.Font = new Font("Arial Narrow", 18F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSign.Location = new Point(20, 372);
            buttonSign.Name = "buttonSign";
            buttonSign.Size = new Size(70, 70);
            buttonSign.TabIndex = 13;
            buttonSign.Text = "+/-";
            buttonSign.UseVisualStyleBackColor = true;
            buttonSign.Click += buttonSign_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Font = new Font("Arial Narrow", 18F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAdd.Location = new Point(467, 129);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(70, 70);
            buttonAdd.TabIndex = 14;
            buttonAdd.Text = "+";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonMinus
            // 
            buttonMinus.Font = new Font("Arial Narrow", 18F, FontStyle.Regular, GraphicsUnit.Point);
            buttonMinus.Location = new Point(467, 210);
            buttonMinus.Name = "buttonMinus";
            buttonMinus.Size = new Size(70, 70);
            buttonMinus.TabIndex = 15;
            buttonMinus.Text = "-";
            buttonMinus.UseVisualStyleBackColor = true;
            buttonMinus.Click += buttonMinus_Click;
            // 
            // buttonMultiply
            // 
            buttonMultiply.Font = new Font("Arial Narrow", 18F, FontStyle.Regular, GraphicsUnit.Point);
            buttonMultiply.Location = new Point(467, 291);
            buttonMultiply.Name = "buttonMultiply";
            buttonMultiply.Size = new Size(70, 70);
            buttonMultiply.TabIndex = 16;
            buttonMultiply.Text = "*";
            buttonMultiply.UseVisualStyleBackColor = true;
            buttonMultiply.Click += buttonMultiply_Click;
            // 
            // buttonDivision
            // 
            buttonDivision.Font = new Font("Arial Narrow", 18F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDivision.Location = new Point(467, 372);
            buttonDivision.Name = "buttonDivision";
            buttonDivision.Size = new Size(70, 70);
            buttonDivision.TabIndex = 17;
            buttonDivision.Text = "/";
            buttonDivision.UseVisualStyleBackColor = true;
            buttonDivision.Click += buttonDivision_Click;
            // 
            // buttonPow
            // 
            buttonPow.Font = new Font("Arial Narrow", 18F, FontStyle.Regular, GraphicsUnit.Point);
            buttonPow.Location = new Point(571, 129);
            buttonPow.Name = "buttonPow";
            buttonPow.Size = new Size(70, 70);
            buttonPow.TabIndex = 18;
            buttonPow.Text = "^";
            buttonPow.UseVisualStyleBackColor = true;
            buttonPow.Click += buttonPow_Click;
            // 
            // buttonMod
            // 
            buttonMod.Font = new Font("Arial Narrow", 17F, FontStyle.Regular, GraphicsUnit.Point);
            buttonMod.Location = new Point(571, 210);
            buttonMod.Name = "buttonMod";
            buttonMod.Size = new Size(70, 70);
            buttonMod.TabIndex = 19;
            buttonMod.Text = "mod";
            buttonMod.UseVisualStyleBackColor = true;
            buttonMod.Click += buttonMod_Click;
            // 
            // buttonEquals
            // 
            buttonEquals.BackColor = SystemColors.ActiveCaption;
            buttonEquals.Font = new Font("Arial Narrow", 17F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEquals.Location = new Point(571, 372);
            buttonEquals.Name = "buttonEquals";
            buttonEquals.Size = new Size(70, 70);
            buttonEquals.TabIndex = 20;
            buttonEquals.Text = "=";
            buttonEquals.UseVisualStyleBackColor = false;
            buttonEquals.Click += buttonEquals_Click;
            // 
            // CalculatorTextBox
            // 
            CalculatorTextBox.Anchor = AnchorStyles.None;
            CalculatorTextBox.BackColor = SystemColors.ButtonHighlight;
            CalculatorTextBox.Font = new Font("Arial Narrow", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            CalculatorTextBox.Location = new Point(20, 55);
            CalculatorTextBox.Multiline = true;
            CalculatorTextBox.Name = "CalculatorTextBox";
            CalculatorTextBox.ReadOnly = true;
            CalculatorTextBox.Size = new Size(659, 50);
            CalculatorTextBox.TabIndex = 21;
            CalculatorTextBox.Text = "0";
            CalculatorTextBox.TextAlign = HorizontalAlignment.Right;
            CalculatorTextBox.TextChanged += CalculatorTextBox_TextChanged;
            // 
            // UserInfoButton
            // 
            UserInfoButton.BackColor = SystemColors.ActiveCaption;
            UserInfoButton.Font = new Font("Arial Narrow", 17F, FontStyle.Regular, GraphicsUnit.Point);
            UserInfoButton.Location = new Point(304, 368);
            UserInfoButton.Name = "UserInfoButton";
            UserInfoButton.Size = new Size(139, 70);
            UserInfoButton.TabIndex = 22;
            UserInfoButton.Text = "User Info";
            UserInfoButton.UseVisualStyleBackColor = false;
            UserInfoButton.Click += UserInfoButton_Click;
            // 
            // buttonCero
            // 
            buttonCero.Font = new Font("Arial Narrow", 17F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCero.Location = new Point(571, 291);
            buttonCero.Name = "buttonCero";
            buttonCero.Size = new Size(70, 70);
            buttonCero.TabIndex = 23;
            buttonCero.Text = "C";
            buttonCero.UseVisualStyleBackColor = true;
            buttonCero.Click += buttonCero_Click;
            // 
            // buttonExit
            // 
            buttonExit.BackColor = SystemColors.ActiveCaption;
            buttonExit.Font = new Font("Arial Narrow", 17F, FontStyle.Regular, GraphicsUnit.Point);
            buttonExit.Location = new Point(304, 291);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(139, 70);
            buttonExit.TabIndex = 24;
            buttonExit.Text = "Exit";
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click;
            // 
            // CalculatorInterface
            // 
            AutoScaleDimensions = new SizeF(7F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 450);
            Controls.Add(buttonExit);
            Controls.Add(buttonCero);
            Controls.Add(UserInfoButton);
            Controls.Add(CalculatorTextBox);
            Controls.Add(buttonEquals);
            Controls.Add(buttonMod);
            Controls.Add(buttonPow);
            Controls.Add(buttonDivision);
            Controls.Add(buttonMultiply);
            Controls.Add(buttonMinus);
            Controls.Add(buttonAdd);
            Controls.Add(buttonSign);
            Controls.Add(buttonComa);
            Controls.Add(button0);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button9);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "CalculatorInterface";
            Text = "OOP CALCULATOR";
            Load += CalculatorInterface_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button0;
        private Button buttonComa;
        private Button buttonSign;
        private Button buttonAdd;
        private Button buttonMinus;
        private Button buttonMultiply;
        private Button buttonDivision;
        private Button buttonPow;
        private Button buttonMod;
        private Button buttonEquals;
        private TextBox CalculatorTextBox;
        private Button UserInfoButton;
        private Button buttonCero;
        private Button buttonExit;
    }
}