using System;
using System.Windows.Forms;
using Google.Cloud.Firestore;
using static DNUltimate.DBClasses.DBConstants;
namespace DNUltimate
{
    public partial class Rate : Form
    {
        private object r = 5;
        public Rate()
        {
            InitializeComponent();
        }

        private void Back(object sender, EventArgs e)
        {
            Close();
        }
        private void RateBtn(object sender, EventArgs e)
        {
            // Insert rating into database:
            //DBConnection.INSERT(r, () =>
            //{
            //    System.Windows.Forms.MessageBox.Show("Thank you for rating DigiNotes!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);          
            //});
            DocumentReference ratingRef = db.Collection(USER_RATING).Document(Login.User);
            Dictionary<string, object> data = new Dictionary<string, object>() { { Login.User, r } };
            ratingRef.SetAsync (data);
            Close();
        }
        private void RatingStartup(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 4;
            button2.Select();
        }

        private void Button3_Click(object sender, MouseEventArgs e)
        {
            contextMenuStrip1.Show(sender as Control, e.X, e.Y);
        }

        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            r = e.ClickedItem.Text;
            button3.Text = r.ToString();
        }
    }
}