
namespace MEESENGEr
{
    partial class LoginScreen
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginScreen));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties25 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties26 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties27 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties28 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties29 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties30 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties31 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties32 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.LoginBox = new Bunifu.UI.WinForms.BunifuTextBox();
            this.PasswordBox = new Bunifu.UI.WinForms.BunifuTextBox();
            this.LoginMessageBlock = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Name = "label1";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.button1, "button1");
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LoginBox
            // 
            this.LoginBox.AcceptsReturn = false;
            this.LoginBox.AcceptsTab = false;
            this.LoginBox.AnimationSpeed = 200;
            this.LoginBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.LoginBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.LoginBox.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.LoginBox, "LoginBox");
            this.LoginBox.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.LoginBox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.LoginBox.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.LoginBox.BorderColorIdle = System.Drawing.Color.Silver;
            this.LoginBox.BorderRadius = 1;
            this.LoginBox.BorderThickness = 1;
            this.LoginBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.LoginBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LoginBox.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.LoginBox.DefaultText = "";
            this.LoginBox.FillColor = System.Drawing.Color.White;
            this.LoginBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LoginBox.HideSelection = true;
            this.LoginBox.IconLeft = null;
            this.LoginBox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.LoginBox.IconPadding = 10;
            this.LoginBox.IconRight = null;
            this.LoginBox.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.LoginBox.Lines = new string[0];
            this.LoginBox.MaxLength = 32767;
            this.LoginBox.Modified = false;
            this.LoginBox.Multiline = false;
            this.LoginBox.Name = "LoginBox";
            stateProperties25.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties25.FillColor = System.Drawing.Color.Empty;
            stateProperties25.ForeColor = System.Drawing.Color.Empty;
            stateProperties25.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.LoginBox.OnActiveState = stateProperties25;
            stateProperties26.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties26.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties26.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.LoginBox.OnDisabledState = stateProperties26;
            stateProperties27.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties27.FillColor = System.Drawing.Color.Empty;
            stateProperties27.ForeColor = System.Drawing.Color.Empty;
            stateProperties27.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.LoginBox.OnHoverState = stateProperties27;
            stateProperties28.BorderColor = System.Drawing.Color.Silver;
            stateProperties28.FillColor = System.Drawing.Color.White;
            stateProperties28.ForeColor = System.Drawing.SystemColors.ControlText;
            stateProperties28.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.LoginBox.OnIdleState = stateProperties28;
            this.LoginBox.PasswordChar = '\0';
            this.LoginBox.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.LoginBox.PlaceholderText = "Enter text";
            this.LoginBox.ReadOnly = false;
            this.LoginBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.LoginBox.SelectedText = "";
            this.LoginBox.SelectionLength = 0;
            this.LoginBox.SelectionStart = 0;
            this.LoginBox.ShortcutsEnabled = true;
            this.LoginBox.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.LoginBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.LoginBox.TextMarginBottom = 0;
            this.LoginBox.TextMarginLeft = 3;
            this.LoginBox.TextMarginTop = 0;
            this.LoginBox.TextPlaceholder = "Enter text";
            this.LoginBox.UseSystemPasswordChar = false;
            this.LoginBox.WordWrap = true;
            this.LoginBox.TextChanged += new System.EventHandler(this.bunifuTextBox1_TextChanged);
            // 
            // PasswordBox
            // 
            this.PasswordBox.AcceptsReturn = false;
            this.PasswordBox.AcceptsTab = false;
            this.PasswordBox.AnimationSpeed = 200;
            this.PasswordBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.PasswordBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.PasswordBox.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.PasswordBox, "PasswordBox");
            this.PasswordBox.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.PasswordBox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.PasswordBox.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.PasswordBox.BorderColorIdle = System.Drawing.Color.Silver;
            this.PasswordBox.BorderRadius = 1;
            this.PasswordBox.BorderThickness = 1;
            this.PasswordBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.PasswordBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordBox.DefaultFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordBox.DefaultText = "";
            this.PasswordBox.FillColor = System.Drawing.Color.White;
            this.PasswordBox.ForeColor = System.Drawing.Color.Black;
            this.PasswordBox.HideSelection = true;
            this.PasswordBox.IconLeft = null;
            this.PasswordBox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordBox.IconPadding = 10;
            this.PasswordBox.IconRight = null;
            this.PasswordBox.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordBox.Lines = new string[0];
            this.PasswordBox.MaxLength = 32767;
            this.PasswordBox.Modified = false;
            this.PasswordBox.Multiline = false;
            this.PasswordBox.Name = "PasswordBox";
            stateProperties29.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties29.FillColor = System.Drawing.Color.Empty;
            stateProperties29.ForeColor = System.Drawing.Color.Empty;
            stateProperties29.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.PasswordBox.OnActiveState = stateProperties29;
            stateProperties30.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties30.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties30.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties30.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.PasswordBox.OnDisabledState = stateProperties30;
            stateProperties31.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties31.FillColor = System.Drawing.Color.Empty;
            stateProperties31.ForeColor = System.Drawing.Color.Empty;
            stateProperties31.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.PasswordBox.OnHoverState = stateProperties31;
            stateProperties32.BorderColor = System.Drawing.Color.Silver;
            stateProperties32.FillColor = System.Drawing.Color.White;
            stateProperties32.ForeColor = System.Drawing.Color.Black;
            stateProperties32.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.PasswordBox.OnIdleState = stateProperties32;
            this.PasswordBox.PasswordChar = '\0';
            this.PasswordBox.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.PasswordBox.PlaceholderText = "Enter text";
            this.PasswordBox.ReadOnly = false;
            this.PasswordBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PasswordBox.SelectedText = "";
            this.PasswordBox.SelectionLength = 0;
            this.PasswordBox.SelectionStart = 0;
            this.PasswordBox.ShortcutsEnabled = true;
            this.PasswordBox.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.PasswordBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.PasswordBox.TextMarginBottom = 0;
            this.PasswordBox.TextMarginLeft = 3;
            this.PasswordBox.TextMarginTop = 0;
            this.PasswordBox.TextPlaceholder = "Enter text";
            this.PasswordBox.UseSystemPasswordChar = false;
            this.PasswordBox.WordWrap = true;
            // 
            // LoginMessageBlock
            // 
            resources.ApplyResources(this.LoginMessageBlock, "LoginMessageBlock");
            this.LoginMessageBlock.Name = "LoginMessageBlock";
            // 
            // LoginScreen
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.LoginMessageBlock);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.LoginBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.DarkRed;
            this.Name = "LoginScreen";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private Bunifu.UI.WinForms.BunifuTextBox LoginBox;
        private Bunifu.UI.WinForms.BunifuTextBox PasswordBox;
        private System.Windows.Forms.Label LoginMessageBlock;
    }
}

