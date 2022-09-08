using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Cloud.Firestore;
using DNUltimate.UserLogin;
using DNUltimate.DBClasses;
using static DNUltimate.DBClasses.DBConstants;

namespace DNUltimate
{
    public partial class Login : Form
    {
        bool showingPwd = false;
        public static string User { get; set; } = "";
        public Login()
        {
            InitializeComponent();
        }

        private void LinkBtnMouseLeave(object sender, EventArgs e)
        {
            Button s = sender as Button;
            s.ForeColor = ColorTranslator.FromHtml("#0000EE");
            s.Font = new("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
        }

        private void LinkBtnMouseEnter(object sender, EventArgs e)
        {
            Button s = sender as Button;
            s.ForeColor = ColorTranslator.FromHtml("#800080");
            s.Font = new("Segoe UI", 9F, FontStyle.Underline | FontStyle.Italic, GraphicsUnit.Point);
        }

        private void showPwd_Click(object sender, EventArgs e)
        {
            pwdInp.PasswordChar = showingPwd ? '●' : '\0';
            showingPwd ^= true;
        }

        private async void ProceedClick(object sender, EventArgs e)
        {
            CollectionReference reference = db.Collection(USER_COLLECTION);
            QuerySnapshot documents = await reference.GetSnapshotAsync();
            bool found = false;
            foreach (DocumentSnapshot doc in documents)
            {
                UserLoginData user = doc.ConvertTo<UserLoginData>();
                if (user.Name == Username.Text && user.Pass == pwdInp.Text)
                {
                    MessageBox.Show("Welcome back " + user.Name + "!", "DigiNotes Ultimate", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    User = user.Name;
                    found = true;
                }
            }

            if (!found)
            {
                MessageBox.Show("Invalid Username/Password. Please check again.\nIf you are new here, please create an account.", "DigiNotes Ultimate", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (found)
            {
                Hide();
                new NoteForm().ShowDialog();
                Close();
            }
        }

        private void createAcc_Click(object sender, EventArgs e)
        {
            Hide();
            new SignUp().ShowDialog();
            Close();
        }
    }
}
