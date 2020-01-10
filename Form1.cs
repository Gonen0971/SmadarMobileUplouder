using AutoUpdaterDotNET;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;


namespace SmadarMobileUplouder
{
    public partial class Form1 : Form
    {
        // -- Variables  --
        public IDictionary<string, string> ListFiles64 = new Dictionary<string, string>();
        private string _Domain_name,
                       _Company_code,
                       _Path_type,
                       _Path,
                       _AuthUser,
                       _AuthPassword;
        private bool _EnableAuth;

        // --Properties--
        public  string domain_name
        {
           get { return _Domain_name; }
           set { _Domain_name = value; }
       }
        public string company_code
        {
            get { return _Company_code; }
            set { _Company_code = value; }
        }
        public string path_type
        {
            get { return _Path_type; }
            set { _Path_type = value; }
        }
        public string path
        {
            get { return _Path; }
            set { _Path = value; }
        }
        public string authUser
        {
            get { return _AuthUser; }
            set { _AuthUser = value; }
        }
        public string authPassword
        {
            get { return _AuthPassword; }
            set { _AuthPassword = value; }
        }
        public bool enableAuth
        {
            get { return _EnableAuth; }
            set { _EnableAuth = value; }
        }

        public string this[string key]
        {
            // returns value 
            get { return ListFiles64[key]; }

            //  add value
            set { ListFiles64[key] = value; }
        }

        //---- Constracture ---
        public Form1()
        {
            InitializeComponent();
            MaximizeBox = false;
            //// Read Data from configuration file ////
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        }

        private string convertPDF2base64(string filename)
        {
            byte[] pdfBytes = File.ReadAllBytes(@filename);
            return (Convert.ToBase64String(pdfBytes));

        }



        /// <summary>
        /// // Select PDF File for upload
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_send_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            
            txtBox_FileSelected.Text = string.Empty;

            dlg.Reset();
            dlg.FileName = string.Empty;
            dlg.Multiselect = true;
            dlg.Filter = "pdf files (*.pdf) |*.pdf;";
            dlg.Title = "Select PDF files to upload";
            dlg.RestoreDirectory = true;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                
                // Read the files

                foreach (String file in dlg.FileNames)
                {
                    try
                    {
                        string fileName = Path.GetFileName(file);
                        if (file != null )
                        {

                            //Save FileNames & Base64Files to Dictionary
                            ListFiles64.Add(fileName, this.convertPDF2base64(file));

                            if (txtBox_FileSelected.TextLength == 0)
                            {
                                txtBox_FileSelected.Text = fileName;
                            }
                            else
                                txtBox_FileSelected.Text += System.Environment.NewLine + txtBox_FileSelected.Text;
                        }
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("Cannot Open PDF: " + file.Substring(file.LastIndexOf('\\'))
                         + ". You may not have permission to read the file, or " +
                         "it may be corrupt.\n\nReported error: " + ex.Message);
                    }
                }

            }

        }
        /// <summary>
        /// -- Send Button  --
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_send_Click_1(object sender, EventArgs e)
        {
            AccessToken MyAccessToken = new AccessToken();
            if (txtBox_FileSelected.TextLength > 0 && (txtBox_CompanyName.TextLength > 0 || txtBox_ComapnyCode.TextLength > 0))
            {
                btn_send.Enabled = true;
                // Get Form Data
                domain_name = txtBox_CompanyName.Text;
                company_code = txtBox_ComapnyCode.Text;
                path_type = combo_path_Type.Text;
                path = txtBox_path.Text;
                enableAuth = checkBox_Auth.Checked;
                authUser = text_AuthUser.Text;
                authPassword = text_AuthPassword.Text;

                MyAccessToken.GetAccessToken(domain_name, company_code, ListFiles64, path_type, path, enableAuth, authUser, authPassword );
                
            }
            else
            {
                MessageBox.Show("requeried filed are empty!");
                LogMessage("requeried filed are empty!");
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            //txtBox_ComapnyCode.Text = string.Empty;
            //txtBox_CompanyName.Text = string.Empty;
            txtBox_FileSelected.Text = string.Empty;
            this.Close();
            foreach (TraceListener listener in Trace.Listeners)
            {
                listener.Flush();
            }
            Application.Exit();

        }

        public void LogMessage(string Text)
        {
            //textBox_log.Text += DateTime.Now + " " + Text + Environment.NewLine;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // -- AutoUpdater load  --
            AutoUpdaterDotNet.RunAutoUpdater();
            
            //// Read Data from configuration file ////
            combo_path_Type.Text = Properties.Settings.Default.PathType;
            txtBox_path.Text = Properties.Settings.Default.LastPath;
            txtBox_ComapnyCode.Text = Properties.Settings.Default.CompanyCode;
            txtBox_CompanyName.Text = Properties.Settings.Default.CompanyName;
            checkBox_Auth.Checked = Properties.Settings.Default.IsAuthntication;
            text_AuthUser.Text = Properties.Settings.Default.Auth_User;
            text_AuthPassword.Text = Properties.Settings.Default.Auth_Password;
            this.Text = "Doc Uploader Ver. " + Program.version;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            //// Save Fields to configuration file ////
            Properties.Settings.Default.PathType = combo_path_Type.Text;
            Properties.Settings.Default.LastPath = txtBox_path.Text;
            Properties.Settings.Default.CompanyCode = txtBox_ComapnyCode.Text;
            Properties.Settings.Default.CompanyName = txtBox_CompanyName.Text;
            Properties.Settings.Default.Auth_Password = text_AuthPassword.Text;
            Properties.Settings.Default.Auth_User = text_AuthUser.Text;
            Properties.Settings.Default.IsAuthntication = checkBox_Auth.Checked;
            Properties.Settings.Default.Save();
            MessageBox.Show("Settings saved successfully");
            LogMessage("Settings saved successfully");

        }

        private void checkBox_Auth_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Auth.Checked)
            {
                this.text_AuthPassword.Enabled = true;
                this.text_AuthUser.Enabled = true;
            }
            else
            {
                this.text_AuthUser.Enabled = false;
                this.text_AuthPassword.Enabled = false;
            }
        }
    }

    

}
