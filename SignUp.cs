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
    public partial class SignUp : Form
    {
        bool showingPwd = false;
        public SignUp()
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
            if (!string.IsNullOrWhiteSpace(pwdInp.Text))
            {
                ValidateResponse validateResp = Validate_.ValidatePasswordStrength(pwdInp.Text);
                if (validateResp.Valid)
                {
                    CollectionReference reference = db.Collection(USER_COLLECTION);
                    QuerySnapshot documents = await reference.GetSnapshotAsync();
                    bool invalid = false;
                    foreach (DocumentSnapshot doc in documents)
                    {
                        UserLoginData user = doc.ConvertTo<UserLoginData>();
                        if (user.Name == Username.Text)
                        {
                            MessageBox.Show("Sorry, you can\'t use the username you want to use as \nsomeone is already using it. Do you want to login?", "DigiNotes Ultimate", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            invalid = true;
                        }
                    }

                    if (!invalid)
                    {
                        DocumentReference userDoc = db.Collection(USER_COLLECTION).Document(Username.Text);
                        UserLoginData user = new UserLoginData()
                        {
                            Name = Username.Text,
                            Pass = pwdInp.Text
                        };
                        await userDoc.SetAsync(user);
                        Login.User = Username.Text;
                        Hide();
                        new NoteForm().ShowDialog();
                        Close();
                    }

                } else
                {
                    MessageBox.Show(validateResp.Error);
                }
            }
        }

        private void createAcc_Click(object sender, EventArgs e)
        {
            Hide();
            new Login().ShowDialog();
            Close();
        }
    }
}
