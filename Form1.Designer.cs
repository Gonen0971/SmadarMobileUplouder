using System.Windows.Forms;

namespace SmadarMobileUplouder
{
    partial class Form1
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
            System.Windows.Forms.GroupBox groupBox_Lower;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.GroupBox groupBox1;
            this.txtBox_FileSelected = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_getPDF = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.combo_path_Type = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtBox_ComapnyCode = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBox_CompanyName = new System.Windows.Forms.TextBox();
            this.txtBox_path = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox_Right = new System.Windows.Forms.GroupBox();
            this.rButton_Other = new System.Windows.Forms.RadioButton();
            this.rButton_DocCycle = new System.Windows.Forms.RadioButton();
            this.rButton_Smadar = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_send = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.text_AuthPassword = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.checkBox_Auth = new System.Windows.Forms.CheckBox();
            this.text_AuthUser = new System.Windows.Forms.TextBox();
            groupBox_Lower = new System.Windows.Forms.GroupBox();
            groupBox1 = new System.Windows.Forms.GroupBox();
            groupBox_Lower.SuspendLayout();
            this.groupBox_Right.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_Lower
            // 
            groupBox_Lower.BackColor = System.Drawing.SystemColors.ControlLight;
            groupBox_Lower.Controls.Add(this.txtBox_FileSelected);
            groupBox_Lower.Controls.Add(this.label9);
            groupBox_Lower.Controls.Add(this.label12);
            groupBox_Lower.Controls.Add(this.btn_getPDF);
            groupBox_Lower.Controls.Add(this.label10);
            groupBox_Lower.Controls.Add(this.combo_path_Type);
            groupBox_Lower.Controls.Add(this.label13);
            groupBox_Lower.Controls.Add(this.txtBox_ComapnyCode);
            groupBox_Lower.Controls.Add(this.label7);
            groupBox_Lower.Controls.Add(this.txtBox_CompanyName);
            groupBox_Lower.Controls.Add(this.txtBox_path);
            groupBox_Lower.Controls.Add(this.label6);
            groupBox_Lower.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            groupBox_Lower.ForeColor = System.Drawing.SystemColors.HotTrack;
            groupBox_Lower.Location = new System.Drawing.Point(18, 101);
            groupBox_Lower.Margin = new System.Windows.Forms.Padding(4);
            groupBox_Lower.Name = "groupBox_Lower";
            groupBox_Lower.Padding = new System.Windows.Forms.Padding(4);
            groupBox_Lower.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            groupBox_Lower.Size = new System.Drawing.Size(625, 284);
            groupBox_Lower.TabIndex = 36;
            groupBox_Lower.TabStop = false;
            groupBox_Lower.Text = "פרטי החברה";
            // 
            // txtBox_FileSelected
            // 
            this.txtBox_FileSelected.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_FileSelected.Location = new System.Drawing.Point(8, 177);
            this.txtBox_FileSelected.Multiline = true;
            this.txtBox_FileSelected.Name = "txtBox_FileSelected";
            this.txtBox_FileSelected.ReadOnly = true;
            this.txtBox_FileSelected.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBox_FileSelected.Size = new System.Drawing.Size(351, 85);
            this.txtBox_FileSelected.TabIndex = 44;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(267, 157);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 17);
            this.label9.TabIndex = 43;
            this.label9.Text = "שמות הקבצים";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label12.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label12.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label12.Location = new System.Drawing.Point(230, 42);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label12.Size = new System.Drawing.Size(122, 16);
            this.label12.TabIndex = 40;
            this.label12.Text = "שם הטאבלט/ תיקייה";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_getPDF
            // 
            this.btn_getPDF.BackColor = System.Drawing.SystemColors.Control;
            this.btn_getPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_getPDF.Location = new System.Drawing.Point(398, 177);
            this.btn_getPDF.Name = "btn_getPDF";
            this.btn_getPDF.Size = new System.Drawing.Size(211, 41);
            this.btn_getPDF.TabIndex = 6;
            this.btn_getPDF.Text = "בחר קובצי PDF להעלאה...";
            this.btn_getPDF.UseVisualStyleBackColor = false;
            this.btn_getPDF.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label10.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label10.Location = new System.Drawing.Point(511, 42);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label10.Size = new System.Drawing.Size(81, 16);
            this.label10.TabIndex = 39;
            this.label10.Text = "בחירת יישות";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // combo_path_Type
            // 
            this.combo_path_Type.FormattingEnabled = true;
            this.combo_path_Type.Items.AddRange(new object[] {
            "user",
            "folder"});
            this.combo_path_Type.Location = new System.Drawing.Point(399, 65);
            this.combo_path_Type.Name = "combo_path_Type";
            this.combo_path_Type.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.combo_path_Type.Size = new System.Drawing.Size(210, 28);
            this.combo_path_Type.TabIndex = 2;
            this.combo_path_Type.Text = "user";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic);
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label13.Location = new System.Drawing.Point(451, 232);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(161, 30);
            this.label13.TabIndex = 30;
            this.label13.Text = "יש למלא את קוד החברה או שם\r\n החברה באנגלית";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtBox_ComapnyCode
            // 
            this.txtBox_ComapnyCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBox_ComapnyCode.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtBox_ComapnyCode.Location = new System.Drawing.Point(398, 120);
            this.txtBox_ComapnyCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtBox_ComapnyCode.MaxLength = 40;
            this.txtBox_ComapnyCode.Name = "txtBox_ComapnyCode";
            this.txtBox_ComapnyCode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtBox_ComapnyCode.Size = new System.Drawing.Size(211, 26);
            this.txtBox_ComapnyCode.TabIndex = 4;
            this.txtBox_ComapnyCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBox_ComapnyCode.WordWrap = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(525, 96);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(62, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "קוד חברה";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBox_CompanyName
            // 
            this.txtBox_CompanyName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBox_CompanyName.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtBox_CompanyName.Location = new System.Drawing.Point(8, 120);
            this.txtBox_CompanyName.Margin = new System.Windows.Forms.Padding(4);
            this.txtBox_CompanyName.MaxLength = 20;
            this.txtBox_CompanyName.Name = "txtBox_CompanyName";
            this.txtBox_CompanyName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtBox_CompanyName.Size = new System.Drawing.Size(351, 26);
            this.txtBox_CompanyName.TabIndex = 5;
            this.txtBox_CompanyName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtBox_path
            // 
            this.txtBox_path.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBox_path.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtBox_path.Location = new System.Drawing.Point(8, 65);
            this.txtBox_path.Margin = new System.Windows.Forms.Padding(4);
            this.txtBox_path.MaxLength = 50;
            this.txtBox_path.Name = "txtBox_path";
            this.txtBox_path.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtBox_path.Size = new System.Drawing.Size(351, 26);
            this.txtBox_path.TabIndex = 3;
            this.txtBox_path.Text = "Unrefrenced";
            this.txtBox_path.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(241, 96);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(111, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "שם חברה (אנגלית)";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox_Right
            // 
            this.groupBox_Right.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox_Right.Controls.Add(this.rButton_Other);
            this.groupBox_Right.Controls.Add(this.rButton_DocCycle);
            this.groupBox_Right.Controls.Add(this.rButton_Smadar);
            this.groupBox_Right.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupBox_Right.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox_Right.Location = new System.Drawing.Point(661, 101);
            this.groupBox_Right.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox_Right.Name = "groupBox_Right";
            this.groupBox_Right.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox_Right.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox_Right.Size = new System.Drawing.Size(181, 283);
            this.groupBox_Right.TabIndex = 34;
            this.groupBox_Right.TabStop = false;
            this.groupBox_Right.Text = "בחירת שרת";
            // 
            // rButton_Other
            // 
            this.rButton_Other.AutoSize = true;
            this.rButton_Other.BackColor = System.Drawing.Color.Transparent;
            this.rButton_Other.Enabled = false;
            this.rButton_Other.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.rButton_Other.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rButton_Other.Location = new System.Drawing.Point(113, 114);
            this.rButton_Other.Margin = new System.Windows.Forms.Padding(4);
            this.rButton_Other.Name = "rButton_Other";
            this.rButton_Other.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rButton_Other.Size = new System.Drawing.Size(49, 20);
            this.rButton_Other.TabIndex = 3;
            this.rButton_Other.Text = "אחר";
            this.rButton_Other.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rButton_Other.UseVisualStyleBackColor = false;
            // 
            // rButton_DocCycle
            // 
            this.rButton_DocCycle.AutoSize = true;
            this.rButton_DocCycle.BackColor = System.Drawing.Color.Transparent;
            this.rButton_DocCycle.Enabled = false;
            this.rButton_DocCycle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.rButton_DocCycle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rButton_DocCycle.Location = new System.Drawing.Point(77, 77);
            this.rButton_DocCycle.Margin = new System.Windows.Forms.Padding(4);
            this.rButton_DocCycle.Name = "rButton_DocCycle";
            this.rButton_DocCycle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rButton_DocCycle.Size = new System.Drawing.Size(85, 20);
            this.rButton_DocCycle.TabIndex = 2;
            this.rButton_DocCycle.Text = "DocCycle";
            this.rButton_DocCycle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rButton_DocCycle.UseVisualStyleBackColor = false;
            // 
            // rButton_Smadar
            // 
            this.rButton_Smadar.AutoSize = true;
            this.rButton_Smadar.BackColor = System.Drawing.Color.Transparent;
            this.rButton_Smadar.Checked = true;
            this.rButton_Smadar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.rButton_Smadar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rButton_Smadar.Location = new System.Drawing.Point(44, 40);
            this.rButton_Smadar.Margin = new System.Windows.Forms.Padding(4);
            this.rButton_Smadar.Name = "rButton_Smadar";
            this.rButton_Smadar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rButton_Smadar.Size = new System.Drawing.Size(118, 20);
            this.rButton_Smadar.TabIndex = 1;
            this.rButton_Smadar.TabStop = true;
            this.rButton_Smadar.Text = "Smadar Mobile";
            this.rButton_Smadar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rButton_Smadar.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(18, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 433);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 37;
            // 
            // btn_send
            // 
            this.btn_send.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_send.Location = new System.Drawing.Point(462, 501);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(181, 41);
            this.btn_send.TabIndex = 49;
            this.btn_send.Text = "שלח";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click_1);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_Cancel.Location = new System.Drawing.Point(19, 501);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(181, 41);
            this.btn_Cancel.TabIndex = 50;
            this.btn_Cancel.Text = "יציאה";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.AutoEllipsis = true;
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_Save.Location = new System.Drawing.Point(661, 500);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(181, 41);
            this.btn_Save.TabIndex = 48;
            this.btn_Save.Text = "שמור הגדרות";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // groupBox1
            // 
            groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            groupBox1.Controls.Add(this.text_AuthUser);
            groupBox1.Controls.Add(this.checkBox_Auth);
            groupBox1.Controls.Add(this.textBox1);
            groupBox1.Controls.Add(this.button1);
            groupBox1.Controls.Add(this.label4);
            groupBox1.Controls.Add(this.label5);
            groupBox1.Controls.Add(this.text_AuthPassword);
            groupBox1.Controls.Add(this.label11);
            groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            groupBox1.Location = new System.Drawing.Point(18, 393);
            groupBox1.Margin = new System.Windows.Forms.Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(4);
            groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            groupBox1.Size = new System.Drawing.Size(625, 101);
            groupBox1.TabIndex = 47;
            groupBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(8, 177);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox1.Size = new System.Drawing.Size(351, 85);
            this.textBox1.TabIndex = 44;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button1.Location = new System.Drawing.Point(398, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(211, 41);
            this.button1.TabIndex = 6;
            this.button1.Text = "בחר קובצי PDF להעלאה...";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(518, 36);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 39;
            this.label4.Text = "שם משתמש";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic);
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(451, 232);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 30);
            this.label5.TabIndex = 30;
            this.label5.Text = "יש למלא את קוד החברה או שם\r\n החברה באנגלית";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // text_AuthPassword
            // 
            this.text_AuthPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.text_AuthPassword.Enabled = false;
            this.text_AuthPassword.ForeColor = System.Drawing.SystemColors.InfoText;
            this.text_AuthPassword.Location = new System.Drawing.Point(148, 59);
            this.text_AuthPassword.Margin = new System.Windows.Forms.Padding(4);
            this.text_AuthPassword.MaxLength = 40;
            this.text_AuthPassword.Name = "text_AuthPassword";
            this.text_AuthPassword.PasswordChar = '*';
            this.text_AuthPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.text_AuthPassword.Size = new System.Drawing.Size(211, 24);
            this.text_AuthPassword.TabIndex = 47;
            this.text_AuthPassword.WordWrap = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label11.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label11.Location = new System.Drawing.Point(307, 36);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label11.Size = new System.Drawing.Size(45, 16);
            this.label11.TabIndex = 15;
            this.label11.Text = "סיסמא";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // checkBox_Auth
            // 
            this.checkBox_Auth.AutoSize = true;
            this.checkBox_Auth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Auth.Location = new System.Drawing.Point(474, -1);
            this.checkBox_Auth.Name = "checkBox_Auth";
            this.checkBox_Auth.Size = new System.Drawing.Size(151, 20);
            this.checkBox_Auth.TabIndex = 45;
            this.checkBox_Auth.Text = "אימות שרת (לבדיקות)";
            this.checkBox_Auth.UseVisualStyleBackColor = true;
            this.checkBox_Auth.CheckedChanged += new System.EventHandler(this.checkBox_Auth_CheckedChanged);
            // 
            // text_AuthUser
            // 
            this.text_AuthUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.text_AuthUser.Enabled = false;
            this.text_AuthUser.ForeColor = System.Drawing.SystemColors.InfoText;
            this.text_AuthUser.Location = new System.Drawing.Point(398, 59);
            this.text_AuthUser.Margin = new System.Windows.Forms.Padding(4);
            this.text_AuthUser.MaxLength = 40;
            this.text_AuthUser.Name = "text_AuthUser";
            this.text_AuthUser.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.text_AuthUser.Size = new System.Drawing.Size(211, 24);
            this.text_AuthUser.TabIndex = 46;
            this.text_AuthUser.WordWrap = false;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(859, 553);
            this.Controls.Add(groupBox1);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.label8);
            this.Controls.Add(groupBox_Lower);
            this.Controls.Add(this.groupBox_Right);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "DocUploader";
            this.Load += new System.EventHandler(this.Form1_Load);
            groupBox_Lower.ResumeLayout(false);
            groupBox_Lower.PerformLayout();
            this.groupBox_Right.ResumeLayout(false);
            this.groupBox_Right.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox_Right;
        private System.Windows.Forms.RadioButton rButton_Other;
        private System.Windows.Forms.RadioButton rButton_DocCycle;
        private System.Windows.Forms.RadioButton rButton_Smadar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_getPDF;
        private System.Windows.Forms.TextBox txtBox_ComapnyCode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBox_CompanyName;
        private System.Windows.Forms.TextBox txtBox_path;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox combo_path_Type;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.TextBox txtBox_FileSelected;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_Cancel;
        private Button btn_Save;
        private TextBox text_AuthUser;
        private CheckBox checkBox_Auth;
        private TextBox textBox1;
        private Button button1;
        private Label label4;
        private Label label5;
        private TextBox text_AuthPassword;
        private Label label11;

        public Label Label1 { get => label1; set => label1 = value; }
    }
}