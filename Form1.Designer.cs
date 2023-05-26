namespace Winforms
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
            Welcome = new Panel();
            label2 = new Label();
            RegisterScreenBtn = new Button();
            LoginScreenBtn = new Button();
            Menu = new Panel();
            LogoutBtn = new Button();
            ChangeFormBtn = new Button();
            ReturnFormBtn = new Button();
            RentFormBtn = new Button();
            label10 = new Label();
            label9 = new Label();
            Login = new Panel();
            LoginBtn = new Button();
            label5 = new Label();
            label4 = new Label();
            LoginPasswordBox = new TextBox();
            LoginPersnumbrBox = new TextBox();
            label3 = new Label();
            Register = new Panel();
            NewAccBtn = new Button();
            label8 = new Label();
            label7 = new Label();
            RegisterPasswordBox = new TextBox();
            RegisterPersnumberBox = new TextBox();
            label6 = new Label();
            Rent = new Panel();
            backBtn = new Button();
            bookAlreadyBorrowedLabel = new Label();
            bookBorrowedText = new Label();
            RentBtn = new Button();
            RentISBNBox = new TextBox();
            RentAuthorBox = new TextBox();
            RentTitleBox = new TextBox();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            Return = new Panel();
            backButton = new Button();
            bookReturnedLabel = new Label();
            label1 = new Label();
            ReturnBookBtn = new Button();
            ReturnISBNBox = new TextBox();
            label15 = new Label();
            ChPassword = new Panel();
            backButn = new Button();
            passwordLabel = new Label();
            ChangePasswordBox = new Button();
            NewPasswordBox = new TextBox();
            label20 = new Label();
            label19 = new Label();
            Welcome.SuspendLayout();
            Menu.SuspendLayout();
            Login.SuspendLayout();
            Register.SuspendLayout();
            Rent.SuspendLayout();
            Return.SuspendLayout();
            ChPassword.SuspendLayout();
            SuspendLayout();
            // 
            // Welcome
            // 
            Welcome.Controls.Add(label2);
            Welcome.Controls.Add(RegisterScreenBtn);
            Welcome.Controls.Add(LoginScreenBtn);
            Welcome.Location = new Point(0, -1);
            Welcome.Name = "Welcome";
            Welcome.Size = new Size(800, 453);
            Welcome.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(257, 47);
            label2.Name = "label2";
            label2.Size = new Size(290, 65);
            label2.TabIndex = 3;
            label2.Text = "Välkommen!";
            // 
            // RegisterScreenBtn
            // 
            RegisterScreenBtn.Location = new Point(525, 171);
            RegisterScreenBtn.Name = "RegisterScreenBtn";
            RegisterScreenBtn.Size = new Size(112, 34);
            RegisterScreenBtn.TabIndex = 2;
            RegisterScreenBtn.Text = "Register";
            RegisterScreenBtn.UseVisualStyleBackColor = true;
            RegisterScreenBtn.Click += RegisterScreenBtn_Click;
            // 
            // LoginScreenBtn
            // 
            LoginScreenBtn.Location = new Point(225, 166);
            LoginScreenBtn.Name = "LoginScreenBtn";
            LoginScreenBtn.Size = new Size(108, 38);
            LoginScreenBtn.TabIndex = 4;
            LoginScreenBtn.Text = "Logga in";
            LoginScreenBtn.Click += LoginScreenBtn_Click;
            // 
            // Menu
            // 
            Menu.Controls.Add(LogoutBtn);
            Menu.Controls.Add(ChangeFormBtn);
            Menu.Controls.Add(ReturnFormBtn);
            Menu.Controls.Add(RentFormBtn);
            Menu.Controls.Add(label10);
            Menu.Controls.Add(label9);
            Menu.Location = new Point(0, 0);
            Menu.Name = "Menu";
            Menu.Size = new Size(803, 450);
            Menu.TabIndex = 7;
            // 
            // LogoutBtn
            // 
            LogoutBtn.Location = new Point(353, 252);
            LogoutBtn.Name = "LogoutBtn";
            LogoutBtn.Size = new Size(112, 34);
            LogoutBtn.TabIndex = 5;
            LogoutBtn.Text = "Logga ut";
            LogoutBtn.UseVisualStyleBackColor = true;
            LogoutBtn.Click += LogoutBtn_Click;
            // 
            // ChangeFormBtn
            // 
            ChangeFormBtn.Location = new Point(328, 210);
            ChangeFormBtn.Name = "ChangeFormBtn";
            ChangeFormBtn.Size = new Size(151, 34);
            ChangeFormBtn.TabIndex = 4;
            ChangeFormBtn.Text = "Ändra lösenord";
            ChangeFormBtn.UseVisualStyleBackColor = true;
            ChangeFormBtn.Click += ChangeFormBtn_Click;
            // 
            // ReturnFormBtn
            // 
            ReturnFormBtn.Location = new Point(315, 169);
            ReturnFormBtn.Name = "ReturnFormBtn";
            ReturnFormBtn.Size = new Size(180, 34);
            ReturnFormBtn.TabIndex = 3;
            ReturnFormBtn.Text = "Lämna tillbaka bok";
            ReturnFormBtn.UseVisualStyleBackColor = true;
            ReturnFormBtn.Click += ReturnFormBtn_Click;
            // 
            // RentFormBtn
            // 
            RentFormBtn.Location = new Point(339, 129);
            RentFormBtn.Name = "RentFormBtn";
            RentFormBtn.Size = new Size(126, 34);
            RentFormBtn.TabIndex = 2;
            RentFormBtn.Text = "Låna en bok";
            RentFormBtn.UseVisualStyleBackColor = true;
            RentFormBtn.Click += RentFormBtn_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(335, 78);
            label10.Name = "label10";
            label10.Size = new Size(144, 25);
            label10.TabIndex = 1;
            label10.Text = "Vad vill du göra?";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(257, 13);
            label9.Name = "label9";
            label9.Size = new Size(290, 65);
            label9.TabIndex = 0;
            label9.Text = "Välkommen!";
            // 
            // Login
            // 
            Login.Controls.Add(LoginBtn);
            Login.Controls.Add(label5);
            Login.Controls.Add(label4);
            Login.Controls.Add(LoginPasswordBox);
            Login.Controls.Add(LoginPersnumbrBox);
            Login.Controls.Add(label3);
            Login.Location = new Point(0, 0);
            Login.Name = "Login";
            Login.Size = new Size(800, 453);
            Login.TabIndex = 5;
            // 
            // LoginBtn
            // 
            LoginBtn.Location = new Point(471, 213);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(112, 34);
            LoginBtn.TabIndex = 5;
            LoginBtn.Text = "Logga in";
            LoginBtn.UseVisualStyleBackColor = true;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(215, 217);
            label5.Name = "label5";
            label5.Size = new Size(86, 25);
            label5.TabIndex = 4;
            label5.Text = "Lösenord";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(177, 149);
            label4.Name = "label4";
            label4.Size = new Size(132, 25);
            label4.TabIndex = 3;
            label4.Text = "Personnummer";
            // 
            // LoginPasswordBox
            // 
            LoginPasswordBox.Location = new Point(315, 214);
            LoginPasswordBox.Name = "LoginPasswordBox";
            LoginPasswordBox.Size = new Size(150, 31);
            LoginPasswordBox.TabIndex = 2;
            // 
            // LoginPersnumbrBox
            // 
            LoginPersnumbrBox.Location = new Point(315, 146);
            LoginPersnumbrBox.Name = "LoginPersnumbrBox";
            LoginPersnumbrBox.Size = new Size(150, 31);
            LoginPersnumbrBox.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(293, 27);
            label3.Name = "label3";
            label3.Size = new Size(211, 65);
            label3.TabIndex = 0;
            label3.Text = "Logga in";
            // 
            // Register
            // 
            Register.Controls.Add(NewAccBtn);
            Register.Controls.Add(label8);
            Register.Controls.Add(label7);
            Register.Controls.Add(RegisterPasswordBox);
            Register.Controls.Add(RegisterPersnumberBox);
            Register.Controls.Add(label6);
            Register.Location = new Point(0, 0);
            Register.Name = "Register";
            Register.Size = new Size(800, 452);
            Register.TabIndex = 6;
            // 
            // NewAccBtn
            // 
            NewAccBtn.Location = new Point(449, 210);
            NewAccBtn.Name = "NewAccBtn";
            NewAccBtn.Size = new Size(112, 34);
            NewAccBtn.TabIndex = 5;
            NewAccBtn.Text = "Registrera";
            NewAccBtn.UseVisualStyleBackColor = true;
            NewAccBtn.Click += NewAccBtn_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(189, 216);
            label8.Name = "label8";
            label8.Size = new Size(90, 25);
            label8.TabIndex = 4;
            label8.Text = "Lösenord:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(151, 138);
            label7.Name = "label7";
            label7.Size = new Size(136, 25);
            label7.TabIndex = 3;
            label7.Text = "Personnummer:";
            // 
            // RegisterPasswordBox
            // 
            RegisterPasswordBox.Location = new Point(293, 212);
            RegisterPasswordBox.Name = "RegisterPasswordBox";
            RegisterPasswordBox.Size = new Size(150, 31);
            RegisterPasswordBox.TabIndex = 2;
            // 
            // RegisterPersnumberBox
            // 
            RegisterPersnumberBox.Location = new Point(293, 135);
            RegisterPersnumberBox.Name = "RegisterPersnumberBox";
            RegisterPersnumberBox.Size = new Size(150, 31);
            RegisterPersnumberBox.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(279, 26);
            label6.Name = "label6";
            label6.Size = new Size(240, 65);
            label6.TabIndex = 0;
            label6.Text = "Registrera";
            // 
            // Rent
            // 
            Rent.Controls.Add(backBtn);
            Rent.Controls.Add(bookAlreadyBorrowedLabel);
            Rent.Controls.Add(bookBorrowedText);
            Rent.Controls.Add(RentBtn);
            Rent.Controls.Add(RentISBNBox);
            Rent.Controls.Add(RentAuthorBox);
            Rent.Controls.Add(RentTitleBox);
            Rent.Controls.Add(label14);
            Rent.Controls.Add(label13);
            Rent.Controls.Add(label12);
            Rent.Controls.Add(label11);
            Rent.Location = new Point(0, 0);
            Rent.Name = "Rent";
            Rent.Size = new Size(803, 449);
            Rent.TabIndex = 8;
            Rent.Visible = false;
            // 
            // backBtn
            // 
            backBtn.Location = new Point(12, 13);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(112, 34);
            backBtn.TabIndex = 10;
            backBtn.Text = "Tillbaka";
            backBtn.UseVisualStyleBackColor = true;
            backBtn.Click += backBtn_Click;
            // 
            // bookAlreadyBorrowedLabel
            // 
            bookAlreadyBorrowedLabel.AutoSize = true;
            bookAlreadyBorrowedLabel.ForeColor = Color.Black;
            bookAlreadyBorrowedLabel.Location = new Point(238, 314);
            bookAlreadyBorrowedLabel.Name = "bookAlreadyBorrowedLabel";
            bookAlreadyBorrowedLabel.Size = new Size(359, 25);
            bookAlreadyBorrowedLabel.TabIndex = 9;
            bookAlreadyBorrowedLabel.Text = "Boken är tyvärr redan utlånad eller finns inte";
            bookAlreadyBorrowedLabel.Visible = false;
            // 
            // bookBorrowedText
            // 
            bookBorrowedText.AutoSize = true;
            bookBorrowedText.ForeColor = Color.Black;
            bookBorrowedText.Location = new Point(328, 289);
            bookBorrowedText.Name = "bookBorrowedText";
            bookBorrowedText.Size = new Size(170, 25);
            bookBorrowedText.TabIndex = 8;
            bookBorrowedText.Text = "Boken är nu utlånad";
            bookBorrowedText.Visible = false;
            // 
            // RentBtn
            // 
            RentBtn.Location = new Point(353, 228);
            RentBtn.Name = "RentBtn";
            RentBtn.Size = new Size(112, 34);
            RentBtn.TabIndex = 7;
            RentBtn.Text = "Låna";
            RentBtn.UseVisualStyleBackColor = true;
            RentBtn.Click += RentBtn_Click;
            // 
            // RentISBNBox
            // 
            RentISBNBox.Location = new Point(339, 191);
            RentISBNBox.Name = "RentISBNBox";
            RentISBNBox.Size = new Size(150, 31);
            RentISBNBox.TabIndex = 6;
            // 
            // RentAuthorBox
            // 
            RentAuthorBox.Location = new Point(339, 154);
            RentAuthorBox.Name = "RentAuthorBox";
            RentAuthorBox.Size = new Size(150, 31);
            RentAuthorBox.TabIndex = 5;
            // 
            // RentTitleBox
            // 
            RentTitleBox.Location = new Point(339, 114);
            RentTitleBox.Name = "RentTitleBox";
            RentTitleBox.Size = new Size(150, 31);
            RentTitleBox.TabIndex = 4;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(238, 191);
            label14.Name = "label14";
            label14.Size = new Size(50, 25);
            label14.TabIndex = 3;
            label14.Text = "ISBN";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(238, 148);
            label13.Name = "label13";
            label13.Size = new Size(89, 25);
            label13.TabIndex = 2;
            label13.Text = "Författare";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(238, 114);
            label12.Name = "label12";
            label12.Size = new Size(71, 25);
            label12.TabIndex = 1;
            label12.Text = "Boktitel";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(257, 26);
            label11.Name = "label11";
            label11.Size = new Size(284, 65);
            label11.TabIndex = 0;
            label11.Text = "Låna en bok";
            // 
            // Return
            // 
            Return.Controls.Add(backButton);
            Return.Controls.Add(bookReturnedLabel);
            Return.Controls.Add(label1);
            Return.Controls.Add(ReturnBookBtn);
            Return.Controls.Add(ReturnISBNBox);
            Return.Controls.Add(label15);
            Return.Location = new Point(0, 0);
            Return.Name = "Return";
            Return.Size = new Size(801, 455);
            Return.TabIndex = 9;
            // 
            // backButton
            // 
            backButton.Location = new Point(12, 26);
            backButton.Name = "backButton";
            backButton.Size = new Size(112, 34);
            backButton.TabIndex = 10;
            backButton.Text = "Tillbaka";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += button1_Click;
            // 
            // bookReturnedLabel
            // 
            bookReturnedLabel.AutoSize = true;
            bookReturnedLabel.Location = new Point(315, 246);
            bookReturnedLabel.Name = "bookReturnedLabel";
            bookReturnedLabel.Size = new Size(201, 25);
            bookReturnedLabel.TabIndex = 9;
            bookReturnedLabel.Text = "Boken är tillbakalämnad";
            bookReturnedLabel.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(259, 141);
            label1.Name = "label1";
            label1.Size = new Size(50, 25);
            label1.TabIndex = 8;
            label1.Text = "ISBN";
            // 
            // ReturnBookBtn
            // 
            ReturnBookBtn.Location = new Point(352, 188);
            ReturnBookBtn.Name = "ReturnBookBtn";
            ReturnBookBtn.Size = new Size(112, 34);
            ReturnBookBtn.TabIndex = 7;
            ReturnBookBtn.Text = "Återlämna";
            ReturnBookBtn.UseVisualStyleBackColor = true;
            ReturnBookBtn.Click += ReturnBookBtn_Click;
            // 
            // ReturnISBNBox
            // 
            ReturnISBNBox.Location = new Point(339, 138);
            ReturnISBNBox.Name = "ReturnISBNBox";
            ReturnISBNBox.Size = new Size(150, 31);
            ReturnISBNBox.TabIndex = 6;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(196, 26);
            label15.Name = "label15";
            label15.Size = new Size(425, 65);
            label15.TabIndex = 0;
            label15.Text = "Lämna tillbaka bok";
            // 
            // ChPassword
            // 
            ChPassword.Controls.Add(backButn);
            ChPassword.Controls.Add(passwordLabel);
            ChPassword.Controls.Add(ChangePasswordBox);
            ChPassword.Controls.Add(NewPasswordBox);
            ChPassword.Controls.Add(label20);
            ChPassword.Controls.Add(label19);
            ChPassword.Location = new Point(2, 2);
            ChPassword.Name = "ChPassword";
            ChPassword.Size = new Size(796, 449);
            ChPassword.TabIndex = 10;
            // 
            // backButn
            // 
            backButn.Location = new Point(10, 24);
            backButn.Name = "backButn";
            backButn.Size = new Size(112, 34);
            backButn.TabIndex = 5;
            backButn.Text = "Tillbaka";
            backButn.UseVisualStyleBackColor = true;
            backButn.Click += backButn_Click;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(313, 244);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(217, 25);
            passwordLabel.TabIndex = 4;
            passwordLabel.Text = "Ditt lösenord är nu ändrat";
            passwordLabel.Visible = false;
            // 
            // ChangePasswordBox
            // 
            ChangePasswordBox.Location = new Point(499, 184);
            ChangePasswordBox.Name = "ChangePasswordBox";
            ChangePasswordBox.Size = new Size(112, 34);
            ChangePasswordBox.TabIndex = 3;
            ChangePasswordBox.Text = "Ändra";
            ChangePasswordBox.UseVisualStyleBackColor = true;
            ChangePasswordBox.Click += ChangePasswordBox_Click;
            // 
            // NewPasswordBox
            // 
            NewPasswordBox.Location = new Point(343, 186);
            NewPasswordBox.Name = "NewPasswordBox";
            NewPasswordBox.Size = new Size(150, 31);
            NewPasswordBox.TabIndex = 2;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label20.Location = new Point(166, 180);
            label20.Name = "label20";
            label20.Size = new Size(178, 36);
            label20.TabIndex = 1;
            label20.Text = "Nytt lösenord:";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label19.Location = new Point(228, 11);
            label19.Name = "label19";
            label19.Size = new Size(353, 65);
            label19.TabIndex = 0;
            label19.Text = "Ändra lösenord";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Menu);
            Controls.Add(Rent);
            Controls.Add(Welcome);
            Controls.Add(ChPassword);
            Controls.Add(Return);
            Controls.Add(Register);
            Controls.Add(Login);
            Name = "Form1";
            Text = " ";
            Welcome.ResumeLayout(false);
            Welcome.PerformLayout();
            Menu.ResumeLayout(false);
            Menu.PerformLayout();
            Login.ResumeLayout(false);
            Login.PerformLayout();
            Register.ResumeLayout(false);
            Register.PerformLayout();
            Rent.ResumeLayout(false);
            Rent.PerformLayout();
            Return.ResumeLayout(false);
            Return.PerformLayout();
            ChPassword.ResumeLayout(false);
            ChPassword.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel Welcome;
        private Label label2;
        private Button RegisterScreenBtn;
        private Button LoginScreenBtn;
        private Panel Login;
        private Button LoginBtn;
        private Label label5;
        private Label label4;
        private TextBox LoginPasswordBox;
        private TextBox LoginPersnumbrBox;
        private Label label3;
        private Panel Register;
        private Button NewAccBtn;
        private Label label8;
        private Label label7;
        private TextBox RegisterPasswordBox;
        private TextBox RegisterPersnumberBox;
        private Label label6;
        private Panel Menu;
        private Button ChangeFormBtn;
        private Button ReturnFormBtn;
        private Button RentFormBtn;
        private Label label10;
        private Label label9;
        private Panel Rent;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Button RentBtn;
        private TextBox RentISBNBox;
        private TextBox RentAuthorBox;
        private TextBox RentTitleBox;
        private Panel Return;
        private Button ReturnBookBtn;
        private TextBox ReturnISBNBox;
        private Label label15;
        private Panel ChPassword;
        private Button ChangePasswordBox;
        private TextBox NewPasswordBox;
        private Label label20;
        private Label label19;
        private Button LogoutBtn;
        private Label bookBorrowedText;
        private Label bookAlreadyBorrowedLabel;
        private Label label1;
        private Label bookReturnedLabel;
        private Button backButton;
        private Button backBtn;
        private Label passwordLabel;
        private Button backButn;
    }
}