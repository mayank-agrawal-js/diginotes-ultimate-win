
namespace DNUltimate
{
    partial class NoteForm
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
            this.components = new System.ComponentModel.Container();
            this.AddBtn = new System.Windows.Forms.Button();
            this.NoteInputBox = new System.Windows.Forms.TextBox();
            this.NoteDisp = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.Date = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.DateTimeDisp = new System.Windows.Forms.ListBox();
            this.PriorityDisp = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Toolbar = new System.Windows.Forms.ToolStrip();
            this.ToolBarFileBtn = new System.Windows.Forms.ToolStripDropDownButton();
            this.ToolBarAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolBarRate = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolBarEditBtn = new System.Windows.Forms.ToolStripDropDownButton();
            this.ToolBarEditNote = new System.Windows.Forms.ToolStripMenuItem();
            this.Time = new System.Windows.Forms.DateTimePicker();
            this.EditContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PriorityBtn = new System.Windows.Forms.ComboBox();
            this.Toolbar.SuspendLayout();
            this.EditContextMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.AddBtn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddBtn.Location = new System.Drawing.Point(245, 456);
            this.AddBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(135, 48);
            this.AddBtn.TabIndex = 0;
            this.AddBtn.Text = "Add note";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddNote);
            this.AddBtn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AnyControlKeyDown);
            // 
            // NoteInputBox
            // 
            this.NoteInputBox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NoteInputBox.Location = new System.Drawing.Point(245, 414);
            this.NoteInputBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NoteInputBox.Name = "NoteInputBox";
            this.NoteInputBox.Size = new System.Drawing.Size(345, 38);
            this.NoteInputBox.TabIndex = 1;
            this.NoteInputBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NoteInputBox.Click += new System.EventHandler(this.ControlSelected);
            this.NoteInputBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AnyControlKeyDown);
            // 
            // NoteDisp
            // 
            this.NoteDisp.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.NoteDisp.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NoteDisp.ItemHeight = 31;
            this.NoteDisp.Location = new System.Drawing.Point(264, 87);
            this.NoteDisp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NoteDisp.Name = "NoteDisp";
            this.NoteDisp.Size = new System.Drawing.Size(600, 314);
            this.NoteDisp.TabIndex = 2;
            this.NoteDisp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AnyControlKeyDown);
            this.NoteDisp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnListBox1ItemMouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(239, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Current notes:";
            // 
            // ClearBtn
            // 
            this.ClearBtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClearBtn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ClearBtn.Location = new System.Drawing.Point(386, 456);
            this.ClearBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(208, 48);
            this.ClearBtn.TabIndex = 9;
            this.ClearBtn.Text = "Clear all notes";
            this.ClearBtn.UseVisualStyleBackColor = false;
            this.ClearBtn.Click += new System.EventHandler(this.ClearNotes);
            this.ClearBtn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AnyControlKeyDown);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.DeleteBtn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DeleteBtn.Location = new System.Drawing.Point(245, 508);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(349, 48);
            this.DeleteBtn.TabIndex = 11;
            this.DeleteBtn.Text = "Delete note";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteNote);
            this.DeleteBtn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AnyControlKeyDown);
            // 
            // Date
            // 
            this.Date.CustomFormat = "dd/MM/yyyy";
            this.Date.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Date.Location = new System.Drawing.Point(12, 417);
            this.Date.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Date.Name = "Date";
            this.Date.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Date.Size = new System.Drawing.Size(223, 38);
            this.Date.TabIndex = 14;
            this.Date.Value = new System.DateTime(2021, 7, 14, 18, 42, 0, 0);
            this.Date.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AnyControlKeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 31);
            this.label2.TabIndex = 15;
            this.label2.Text = "Date and time:";
            // 
            // DateTimeDisp
            // 
            this.DateTimeDisp.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.DateTimeDisp.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DateTimeDisp.ItemHeight = 31;
            this.DateTimeDisp.Location = new System.Drawing.Point(12, 87);
            this.DateTimeDisp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DateTimeDisp.Name = "DateTimeDisp";
            this.DateTimeDisp.Size = new System.Drawing.Size(246, 314);
            this.DateTimeDisp.TabIndex = 16;
            this.DateTimeDisp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AnyControlKeyDown);
            // 
            // PriorityDisp
            // 
            this.PriorityDisp.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PriorityDisp.FormattingEnabled = true;
            this.PriorityDisp.ItemHeight = 31;
            this.PriorityDisp.Location = new System.Drawing.Point(870, 87);
            this.PriorityDisp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PriorityDisp.Name = "PriorityDisp";
            this.PriorityDisp.Size = new System.Drawing.Size(137, 314);
            this.PriorityDisp.TabIndex = 17;
            this.PriorityDisp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AnyControlKeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(829, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 31);
            this.label3.TabIndex = 18;
            this.label3.Text = "Priorities: ";
            // 
            // Toolbar
            // 
            this.Toolbar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Toolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolBarFileBtn,
            this.ToolBarEditBtn});
            this.Toolbar.Location = new System.Drawing.Point(0, 0);
            this.Toolbar.Name = "Toolbar";
            this.Toolbar.Size = new System.Drawing.Size(1019, 27);
            this.Toolbar.TabIndex = 21;
            this.Toolbar.Text = "toolStrip1";
            // 
            // ToolBarFileBtn
            // 
            this.ToolBarFileBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ToolBarFileBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolBarAbout,
            this.ToolBarRate});
            this.ToolBarFileBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolBarFileBtn.Name = "ToolBarFileBtn";
            this.ToolBarFileBtn.Size = new System.Drawing.Size(46, 24);
            this.ToolBarFileBtn.Text = "File";
            // 
            // ToolBarAbout
            // 
            this.ToolBarAbout.Name = "ToolBarAbout";
            this.ToolBarAbout.Size = new System.Drawing.Size(140, 26);
            this.ToolBarAbout.Text = "About";
            this.ToolBarAbout.Click += new System.EventHandler(this.About);
            // 
            // ToolBarRate
            // 
            this.ToolBarRate.Name = "ToolBarRate";
            this.ToolBarRate.Size = new System.Drawing.Size(140, 26);
            this.ToolBarRate.Text = "Rate us";
            this.ToolBarRate.Click += new System.EventHandler(this.Rate);
            // 
            // ToolBarEditBtn
            // 
            this.ToolBarEditBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolBarEditNote});
            this.ToolBarEditBtn.Name = "ToolBarEditBtn";
            this.ToolBarEditBtn.Size = new System.Drawing.Size(49, 24);
            this.ToolBarEditBtn.Text = "Edit";
            // 
            // ToolBarEditNote
            // 
            this.ToolBarEditNote.Name = "ToolBarEditNote";
            this.ToolBarEditNote.Size = new System.Drawing.Size(211, 26);
            this.ToolBarEditNote.Text = "Edit selected note";
            this.ToolBarEditNote.Click += new System.EventHandler(this.BEdit);
            // 
            // Time
            // 
            this.Time.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Time.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.Time.Location = new System.Drawing.Point(12, 466);
            this.Time.Name = "Time";
            this.Time.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Time.ShowUpDown = true;
            this.Time.Size = new System.Drawing.Size(223, 38);
            this.Time.TabIndex = 22;
            this.Time.Value = new System.DateTime(2021, 7, 14, 17, 59, 0, 0);
            // 
            // EditContextMenu
            // 
            this.EditContextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.EditContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Edit});
            this.EditContextMenu.Name = "contextMenuStrip1";
            this.EditContextMenu.Size = new System.Drawing.Size(142, 28);
            // 
            // Edit
            // 
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(141, 24);
            this.Edit.Text = "Edit Note";
            this.Edit.Click += new System.EventHandler(this.ContextMenuEdit);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.PriorityBtn);
            this.panel1.Location = new System.Drawing.Point(774, 466);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(198, 28);
            this.panel1.TabIndex = 23;
            // 
            // PriorityBtn
            // 
            this.PriorityBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PriorityBtn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PriorityBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PriorityBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PriorityBtn.FormattingEnabled = true;
            this.PriorityBtn.Items.AddRange(new object[] {
            "High",
            "Medium",
            "Low"});
            this.PriorityBtn.Location = new System.Drawing.Point(0, 0);
            this.PriorityBtn.Name = "PriorityBtn";
            this.PriorityBtn.Size = new System.Drawing.Size(196, 31);
            this.PriorityBtn.TabIndex = 24;
            // 
            // NoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1019, 594);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.Toolbar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PriorityDisp);
            this.Controls.Add(this.DateTimeDisp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NoteDisp);
            this.Controls.Add(this.NoteInputBox);
            this.Controls.Add(this.AddBtn);
            this.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NoteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DigiNotes";
            this.Load += new System.EventHandler(this.Startup);
            this.Click += new System.EventHandler(this.ControlSelected);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AnyControlKeyDown);
            this.Toolbar.ResumeLayout(false);
            this.Toolbar.PerformLayout();
            this.EditContextMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.TextBox NoteInputBox;
        private System.Windows.Forms.ListBox NoteDisp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.DateTimePicker Date;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox DateTimeDisp;
        private System.Windows.Forms.ListBox PriorityDisp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStrip Toolbar;
        private System.Windows.Forms.ToolStripDropDownButton ToolBarFileBtn;
        private System.Windows.Forms.ToolStripMenuItem ToolBarAbout;
        private System.Windows.Forms.ToolStripMenuItem ToolBarRate;
        private System.Windows.Forms.ToolStripDropDownButton ToolBarEditBtn;
        private System.Windows.Forms.ToolStripMenuItem ToolBarEditNote;
        private System.Windows.Forms.DateTimePicker Time;
        private System.Windows.Forms.ContextMenuStrip EditContextMenu;
        private System.Windows.Forms.ToolStripMenuItem Edit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox PriorityBtn;
    }
}

