using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DNUltimate
{
    public enum ErrorCodes
    {
        NullItem = 1,
        DuplicateItem,
        DeleteDropDownOptionNull,
        DeleteNoteWarning,
        ClearNoteWarning
    }

    public partial class CustMessageBox : Form
    {
        private static ErrorCodes errorCode;
        // Error strings:
        private readonly string[] errors = new string[] { "Write down a note.", "Duplicate items are \nnot allowed.", "Select an item from \nthe main list.", "Delete selected note?", "Clear all notes?" };
        public CustMessageBox(ErrorCodes ErrorCode)
        {
            InitializeComponent();
            // Assign value to bring in class scope:
            errorCode = ErrorCode;
            // Set image of Image:
            pictureBox1.Image = (int)ErrorCode <= 3 ? Image.FromFile(Directory.GetCurrentDirectory() + @"\Resources\err.png") : Image.FromFile(Directory.GetCurrentDirectory() + @"\Resources\warn.png");
            // Check if request is warning:
            if ((int)ErrorCode > 3)
            {
                this.Text = "Are you sure?";
                button2.Visible = true;
                button3.Visible = true;
                button2.Select();
            }
            else
            {
                button1.Visible = true;
            }
            // Set text of Label:
            label1.Text = errors[(int)ErrorCode - 1];
        }

        void AnyButtonClicked(object sender, EventArgs e)
        {

        }
    }
}
