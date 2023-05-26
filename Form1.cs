namespace Winforms
{
    public partial class Form1 : Form
    {
        string currentUser = "";
        public Form1()
        {
            InitializeComponent();
        }

        //Tar en till inloggskärmen
        private void LoginScreenBtn_Click(object sender, EventArgs e)
        {
            Login.BringToFront();
        }

        //Tar en till registrering
        private void RegisterScreenBtn_Click(object sender, EventArgs e)
        {
            Register.BringToFront();
        }

        //Skapar konto
        private void NewAccBtn_Click(object sender, EventArgs e)
        {
            string persnumber = RegisterPersnumberBox.Text;
            string password = RegisterPasswordBox.Text;
            RegisterPage(persnumber, password);
            Login.BringToFront();
        }

        //Loggar in användare
        private void LoginBtn_Click(object sender, EventArgs e)
        {

            var persNumber = LoginPersnumbrBox.Text;

            var password = LoginPasswordBox.Text;

            LoginPage(persNumber, password);
            if (currentUser == persNumber)
            {
                Menu.BringToFront();
            }
        }

        //Tar en till tillbakalämningskärmen
        private void ReturnFormBtn_Click(object sender, EventArgs e)
        {
            Return.BringToFront();
        }

        //Tar en till lösenordsbyteskärmen
        private void ChangeFormBtn_Click(object sender, EventArgs e)
        {
            ChPassword.BringToFront();
        }

        //Stänger ner form
        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Lånar bok
        private void RentBtn_Click(object sender, EventArgs e)
        {
            string bookTitle = RentTitleBox.Text;
            string bookAuthor = RentAuthorBox.Text;

            string bookISBN = RentISBNBox.Text;
            BorrowBook(bookTitle, bookAuthor, bookISBN);
        }

        //Lämnar tillbaka bok
        private void ReturnBookBtn_Click(object sender, EventArgs e)
        {
            bookReturnedLabel.Visible = false;
            var ISBNnumber = ReturnISBNBox.Text;
            ReturnBook(ISBNnumber);
            bookReturnedLabel.Visible = true;
        }

        //Tar en till låna bokskärmen
        private void RentFormBtn_Click(object sender, EventArgs e)
        {
            Rent.Visible = false;
            Rent.BringToFront();
            Rent.Visible = true;
        }

        //Tar en tillbaka till menyn
        private void button1_Click(object sender, EventArgs e)
        {
            Menu.BringToFront();
        }

        //Tar en tillbaka till menyn
        private void backBtn_Click(object sender, EventArgs e)
        {
            Menu.BringToFront();
        }

        //Ändrar lösenord för användare
        private void ChangePasswordBox_Click(object sender, EventArgs e)
        {

            passwordLabel.Visible = false;
            string newPassword = NewPasswordBox.Text;
            ChangePassword(newPassword);
            passwordLabel.Visible = true;
        }

        //Tar en tillbaka till menyn
        private void backButn_Click(object sender, EventArgs e)
        {
            Menu.BringToFront();
        }


        public static void RegisterPage(string persnumber, string password)
        {

            var line = $"\n{persnumber} {password}";

            File.AppendAllText(@"C:\Users\albert.rogo\source\repos\WinForms\Winforms\usersForm.txt", line);

        }
        public bool LoginPage(string persNumber, string password)
        {

            var persnumber1 = persNumber;

            var password1 = password;

            string[] loginFromFile = File.ReadAllLines(@"C:\Users\albert.rogo\source\repos\WinForms\Winforms\usersForm.txt");

            bool loginOk = false;
            foreach (var line in loginFromFile)
            {
                string[] tokens = line.Split(" ");
                string userIdFromFile = tokens[0];
                string userPassword = tokens[1];

                if (userIdFromFile == persnumber1 && userPassword == password1)
                {
                    loginOk = true;
                    currentUser = persnumber1;
                }

            }
            if (loginOk)
            {

                return true;
            }
            else
            {
                return false;
            }
        }

        public void BorrowBook(string bookTitle, string bookAuthor, string bookISBN)
        {
            bool bookFound = false;
            string bookNum = "";
            bookAlreadyBorrowedLabel.Visible = false;
            bookBorrowedText.Visible = false;


            string[] booksFromFile = File.ReadAllLines(@"C:\Users\albert.rogo\source\repos\WinForms\Winforms\Books.txt");
            foreach (var line in (booksFromFile))
            {
                string[] tokens = line.Split(" ");
                if (line.Contains(bookTitle.ToString()))
                {
                    bookFound = true;
                    bookNum = tokens[0];
                }

                else if (line.Contains(bookAuthor.ToString()))
                {
                    bookFound = true;
                    bookNum = tokens[0];

                }
                else if (line.Contains(bookISBN.ToString()))
                {
                    bookFound = true;
                    bookNum = tokens[0];
                }

            }

            if (bookFound)
            {
                bookAlreadyBorrowedLabel.Visible = true;
            }
            else
            {
                bookBorrowedText.Visible = true;
            }


        }
        public static void ReturnBook(string ISBNnumber)
        {
            bool bookFound = false;
            string bookNum = "";

            string[] booksFromFile = File.ReadAllLines(@"C:\Users\albert.rogo\source\repos\WinForms\Winforms\Books.txt");
            foreach (var line in (booksFromFile))
            {
                string[] tokens = line.Split(" ");
                if (line.Contains(ISBNnumber.ToString()))
                {
                    bookFound = true;
                    bookNum = tokens[0];
                }
            }
        }
        public void ChangePassword(string newPassword)
        {

            List<string> allUsers = new List<string>(File.ReadAllLines(@"C:\Users\albert.rogo\source\repos\WinForms\Winforms\usersForm.txt"));
            int i = 0;
            int lineNumber = 0;
            string line = "";
            foreach (var user in allUsers)
            {
                string[] tokens1 = user.Split(" ");
                string userIdFromFile = tokens1[0];
                if (userIdFromFile == currentUser)
                {
                    line = $"{userIdFromFile} {newPassword}";
                    lineNumber = i;
                }
                i++;
            }
            allUsers[i - 1] = line;
            File.WriteAllLines(@"C:\Users\albert.rogo\source\repos\WinForms\Winforms\usersForm.txt", allUsers.ToArray());
        }


    }
}