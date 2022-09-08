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
using DNUltimate.Properties;
using DNUltimate.DBClasses;
using static DNUltimate.DBClasses.DBConstants;


namespace DNUltimate
{
    public partial class NoteForm : Form
    {
        private readonly string[] p_strings = { "High", "Medium", "Low" };
        public NoteForm()
        {
            InitializeComponent();
        }

        void ControlSelected (object sender, EventArgs e)
        {
            Control selectedControl = (Control)sender;
            selectedControl.Focus();
            selectedControl.Select();
        }

        void AnyControlKeyDown(object sender, KeyEventArgs e)
        {
            bool commonFlag = e.Control && NoteDisp.SelectedItem != null;
            if (commonFlag && e.KeyCode == Keys.C)
            {
                Clipboard.SetText((string)NoteDisp.SelectedItem);
            }
            if (commonFlag && !e.Shift && e.KeyCode == Keys.Delete)
            {
                if (!Settings.Default.DeleteNoteWarning)
                {
                    CustMessageBox mbox = new CustMessageBox(ErrorCodes.DeleteNoteWarning);
                    if (mbox.ShowDialog() == DialogResult.Yes)
                    {
                        DeleteBtn.PerformClick();
                    }
                }
                else
                {
                    DeleteBtn.PerformClick();
                }
            }
            if (commonFlag && e.Shift && e.KeyCode == Keys.Delete)
            {
                if (!Settings.Default.ClearNoteWarning)
                {
                    CustMessageBox mbox = new(ErrorCodes.ClearNoteWarning);
                    if (mbox.ShowDialog() == DialogResult.Yes)
                    {
                        ClearBtn.PerformClick();
                    }
                }
                else
                {
                    ClearBtn.PerformClick();
                }
            }
            if (e.Control && e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                AddBtn.PerformClick();
            }
            if (e.Control && e.KeyCode == Keys.E)
            {
                ToolBarEditNote.PerformClick();
            }
        }

        void AddNote(object sender, EventArgs e)
        {
            // Check for errors:
            if (string.IsNullOrWhiteSpace(NoteInputBox.Text))
            {
                if (!Settings.Default.NullItemCB)
                {
                    CustMessageBox mbox = new(ErrorCodes.NullItem);
                    mbox.ShowDialog();
                }
            }
            if (NoteDisp.Items.Contains(NoteInputBox.Text))
            {
                if (!Settings.Default.DuplicateItemCB)
                {
                    CustMessageBox mbox = new(ErrorCodes.DuplicateItem);
                    mbox.ShowDialog();
                }
            }
            // If no errors, update GUI and files:
            if (!string.IsNullOrWhiteSpace(NoteInputBox.Text) && !NoteDisp.Items.Contains(NoteInputBox.Text))
            {
                DocumentReference collection = db.Collection(NOTES_COLLECTION).Document(Login.User).Collection("notes").Document(NoteInputBox.Text);
                Note note = new() {
                    Note_ = NoteInputBox.Text,
                    Time = $"{Date.Value.Date: dd/MM/yyyy}{Time.Value: hh:mm tt}",
                    Priority = PriorityBtn.SelectedIndex
                };

                collection.SetAsync(note);
                
                NoteDisp.Items.Add(NoteInputBox.Text);
                DateTimeDisp.Items.Add($"{Date.Value:dd/MM/yyyy} {Time.Value:hh:mm tt}");
                PriorityDisp.Items.Add(PriorityBtn.SelectedItem);
                NoteInputBox.Focus();
                NoteInputBox.Select();
                // Make deleting and clearing features enabled:
                DeleteBtn.Enabled = true;
                ClearBtn.Enabled = true;
            }
        }

        async void DeleteNote(object sender, EventArgs e)
        {
            if (NoteDisp.SelectedIndex <= -1)
            {
                // If not, show error:
                if (!Settings.Default.DeleteDropDownOptionNullCB)
                {

                    CustMessageBox mbox = new(ErrorCodes.DeleteDropDownOptionNull);
                    mbox.ShowDialog();
                }
            }
            else
            {

                DocumentReference reference = db.Collection(NOTES_COLLECTION).Document(Login.User).Collection("notes").Document(NoteDisp.SelectedItem as string);
                await reference.DeleteAsync();

                NoteDisp.Items.Clear();
                DateTimeDisp.Items.Clear();
                PriorityDisp.Items.Clear();

                Query query = db.Collection(NOTES_COLLECTION).Document(Login.User).Collection("notes");
                QuerySnapshot snapshots = await query.GetSnapshotAsync();

                foreach (DocumentSnapshot item in snapshots)
                {
                    Note note = item.ConvertTo<Note>();
                    NoteDisp.Items.Add(note.Note_);
                    DateTimeDisp.Items.Add(note.Time);
                    PriorityDisp.Items.Add(p_strings[note.Priority]);
                }

                // If listbox is empty, disable deleting and clearing features:
                if (NoteDisp.Items.Count == 0)
                {
                    ClearBtn.Enabled = false;
                    DeleteBtn.Enabled = false;
                    NoteInputBox.Select();
                    NoteInputBox.Focus();
                }
            }
        } 

        async void ClearNotes(object sender, EventArgs e)
        {
            CollectionReference collectionReference = db.Collection(NOTES_COLLECTION).Document(Login.User).Collection("notes");
            QuerySnapshot snapshots = await collectionReference.GetSnapshotAsync();

            foreach (DocumentSnapshot doc in snapshots)
            {
                await doc.Reference.DeleteAsync();
            }

            NoteDisp.Items.Clear();
            DateTimeDisp.Items.Clear();
            PriorityDisp.Items.Clear();

            // Disable delete and clear features:
            ClearBtn.Enabled = false;
            DeleteBtn.Enabled = false;

            // Select input:
            NoteInputBox.Select();
            NoteInputBox.Focus();
        }

        async void Startup(object sender, EventArgs e)
        {
            Query query = db.Collection(NOTES_COLLECTION).Document(Login.User).Collection("notes");
            QuerySnapshot snapshots = await query.GetSnapshotAsync();

            foreach (DocumentSnapshot item in snapshots)
            {
                Note note = item.ConvertTo<Note>();
                NoteDisp.Items.Add(note.Note_);
                DateTimeDisp.Items.Add(note.Time);
                PriorityDisp.Items.Add(p_strings[note.Priority]);
            }

            PriorityBtn.SelectedIndex = 0;

            // Check if there are no notes to disable delete and clear features if none:
            if (NoteDisp.Items.Count == 0)
            {
                ClearBtn.Enabled = false;
                DeleteBtn.Enabled = false;
            }
        }

        void About(object sender, EventArgs e)
        {
            new About().ShowDialog();
        }

        void Rate(object sender, EventArgs e)
        {

            new Rate().ShowDialog();
        }

        void OnListBox1ItemMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && NoteDisp.SelectedIndex != -1)
            {
                EditContextMenu.Show(sender as Control, new System.Drawing.Point(e.X, e.Y));
            }
        }

        void BEdit(object sender, EventArgs e)
        {
            if (NoteDisp.SelectedIndex == -1)
            {
                if (!Properties.Settings.Default.DeleteDropDownOptionNullCB)
                {
                    CustMessageBox mb = new(ErrorCodes.DeleteDropDownOptionNull);
                    mb.ShowDialog();
                }
            }
            else
            {
                InputBox inp = new InputBox();
                string new_name = "";
                switch (inp.ShowDialog())
                {
                    case DialogResult.OK:
                        new_name = inp.Controls["textBox1"].Text;
                        break;
                    case DialogResult.Cancel:
                        new_name = NoteDisp.SelectedItem.ToString();
                        break;
                    default:
                        break;
                }
                DocumentReference currNote = db.Collection(NOTES_COLLECTION).Document(Login.User)
                                                                            .Collection("notes").Document(NoteDisp.SelectedItem.ToString());
                Note n = new Note()
                {
                    Note_ = new_name,
                    Time = DateTimeDisp.Items[NoteDisp.SelectedIndex].ToString(),
                    Priority = PriorityDisp.Items.IndexOf(PriorityDisp.Items[NoteDisp.SelectedIndex]),
                };
                currNote.SetAsync(n);
            }
        }

        void ContextMenuEdit(object sender, EventArgs e)
        {
            ToolBarEditNote.PerformClick();
        }
    }
}
