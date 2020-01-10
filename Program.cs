using System;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Threading;

namespace SmadarMobileUplouder
{
    class Program
    {
        private static Mutex mutex;
        public static string ProductionPath = "";
        public static DateTime LastUpadte = DateTime.Now;
        public static string TrcFile = AppDomain.CurrentDomain.BaseDirectory + "SmadarMobile.log";
        public static string ExePath = Directory.GetCurrentDirectory() + "\\";
        public static string version = "1.0";
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        ///////////////////////////////////////////////////////////////////////////////////////////
        [STAThread]
        static void Main()
        {
            //  --  Read Assembly version --
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
            version = fvi.FileVersion;
            //  -----------------------------

            System.Diagnostics.ProcessStartInfo start = new System.Diagnostics.ProcessStartInfo();
            //AccessToken MyAccessToken = new AccessToken();
            //HTTPRequest MyHttpRequest = new HTTPRequest();
            bool createdNew = true;
            mutex = new Mutex(true, @"Local\SmadarFileUploader.exe", out createdNew);
            if (createdNew)
            {
                try
                {
                    if (File.Exists(TrcFile))
                        File.Delete(TrcFile);
                    FileStream MyLogFile = new FileStream(TrcFile, FileMode.OpenOrCreate);
                    TextWriterTraceListener myListener = new TextWriterTraceListener(MyLogFile);
                    Trace.Listeners.Add(new TextWriterTraceListener(Console.Out));
                    Trace.AutoFlush = true;
                    Trace.Indent();
                    Trace.Listeners.Add(myListener);
                    Trace.TraceInformation(DateTime.Now + " " + "Application started");
                    Application.EnableVisualStyles();
                   // Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new Form1());
                    Trace.Close();


                }
                catch (Exception ex)
                {

                    Trace.TraceError(DateTime.Now + " " + "Exception " + ex.Message + " in function Main class program \r\n");
                    MessageBox.Show("התקבלה שגיאה כללית במערכת\n פרטים נרשמו לקובץ הלוג \n ", "Smadar Mobile", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Trace.Close();

                }
            }
            else
            {
                MessageBox.Show("המערכת עדיין עובדת ברקע", "סגירה", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                Environment.Exit(0);

            }

        }
    }
}
