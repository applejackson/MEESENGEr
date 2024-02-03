
namespace MEESENGEr
{
    partial class ContactsScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.ContactsList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // ContactsList
            // 
            this.ContactsList.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ContactsList.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContactsList.FormattingEnabled = true;
            this.ContactsList.ItemHeight = 58;
            this.ContactsList.Items.AddRange(new object[] {
            "Viktoria"});
            this.ContactsList.Location = new System.Drawing.Point(22, 12);
            this.ContactsList.Name = "ContactsList";
            this.ContactsList.Size = new System.Drawing.Size(275, 352);
            this.ContactsList.TabIndex = 0;
            this.ContactsList.SelectedIndexChanged += new System.EventHandler(this.ContactsList_SelectedIndexChanged);
            // 
            // ContactsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(441, 450);
            this.Controls.Add(this.ContactsList);
            this.Name = "ContactsScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Messenger";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ContactsList;
    }
}