using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using Outlook = Microsoft.Office.Interop.Outlook;
using Microsoft.CSharp.RuntimeBinder;
using System.Reflection;

namespace ContactSplitter
{
    static class Program
    {
        private static string strFolderBrowsing;
        private static string strSourceFile;
        private static string strDestinationDirectory;
        private static string strTempVCard;
        private static Outlook.MAPIFolder objMapiFolder;
        private static Outlook.Application objOutlookApplication;
        private static Outlook.NameSpace objOutlookNameSpace;
        private static FormMain objFormMain;
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            strTempVCard = new DirectoryInfo(Environment.GetEnvironmentVariable("TEMP")).FullName + "\\tmpV-Card.vcf";
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            objFormMain = new FormMain();
            Application.Run(objFormMain);
        }

        /// <summary>
        /// Get or set the path for initial folder.
        /// </summary>
        public static string FolderBrowsing 
        {
            get 
            {
                return strFolderBrowsing; 
            }
            set
            {
                strFolderBrowsing = value;
            }
        }

        /// <summary>
        /// Get or set the source vcf file.
        /// </summary>
        public static string SourceFile
        {
            get
            {
                return strSourceFile;
            }
            set
            {
                strSourceFile = value;
            }
        }

        /// <summary>
        /// Get or set the destination folder for the vcf files.
        /// </summary>
        public static string DestinationDirectory
        {
            get
            {
                return strDestinationDirectory;
            }
            set
            {
                strDestinationDirectory = value;
            }
        }

        /// <summary>
        /// Get selected MAPI folder.
        /// </summary>
        public static Microsoft.Office.Interop.Outlook.MAPIFolder MapiFolder
        {
            get
            {
                return objMapiFolder;
            }
        }

        /// <summary>
        /// Select a MAPI folder.
        /// </summary>
        public static void SelectMapiFolder()
        {
            try
            {
                objOutlookApplication = new Outlook.Application();
                objOutlookNameSpace = objOutlookApplication.GetNamespace("MAPI");
                objMapiFolder = objOutlookNameSpace.PickFolder();
            }
            catch (Exception)
            {
                MessageBox.Show(FormMain.ActiveForm, "Error while accessing Outlook.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Import selected V-Card Contact to Outlook.
        /// </summary>
        public static void Import()
        {
            bool bolHadError = false;
            try
            {
                try
                {
                    StreamReader objStreamReader = new StreamReader(strSourceFile, new System.Text.UTF8Encoding(false));
                    int intElementCounter = 1;
                    while (!objStreamReader.EndOfStream)
                    {
                        try
                        {
                            StreamWriter objStreamWriter = new StreamWriter(strTempVCard, false, new System.Text.UTF8Encoding(false));
                            objStreamWriter.AutoFlush = true;
                            string strSourceData = "";
                            while (!strSourceData.EndsWith("END:VCARD" + Environment.NewLine) && !objStreamReader.EndOfStream)
                            {
                                strSourceData += objStreamReader.ReadLine() + Environment.NewLine;
                            }
                            objStreamWriter.Write(strSourceData);
                            objStreamWriter.Flush();
                            objStreamWriter.Close();
                            Outlook.ContactItem objOutlookContactItem = null;
                            try
                            {
                                objOutlookContactItem = objOutlookApplication.Session.OpenSharedItem(strTempVCard) as Outlook.ContactItem;
                            }
                            catch (Exception)
                            {
                                bolHadError = true;
                                MessageBox.Show("Error while reading temp file.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            objOutlookContactItem.Save();
                            if (objOutlookContactItem.Parent.FolderPath != objMapiFolder.FolderPath)
                            {
                                objOutlookContactItem = objOutlookContactItem.Move(objMapiFolder) as Outlook.ContactItem;
                                objOutlookContactItem.Save();
                            }
                        }
                        catch (Exception)
                        {
                            bolHadError = true;
                            MessageBox.Show("Error while writing file.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        intElementCounter++;
                    }
                    objStreamReader.Close();
                    try
                    {
                        File.Delete(strTempVCard);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Error the temp file \"" + strTempVCard + "\" has not been deleted.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (bolHadError)
                    {
                        MessageBox.Show("File has been successfully imported to " + objMapiFolder.FolderPath + ".", "Information.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("File has been imported with errors to " + objMapiFolder.FolderPath + ".", "Information.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Error while reading file.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error while accessing Outlook.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            objFormMain.EnableStartButton();
        }

        /// <summary>
        /// Conversion Method to extract each Contact to an own vcf File.
        /// </summary>
        public static void Convert()
        {
            try
            {
                StreamReader objStreamReader = new StreamReader(strSourceFile);
                int intElementCounter = 1;
                while (!objStreamReader.EndOfStream)
                {
                    try
                    {
                        StreamWriter objStreamWriter = new StreamWriter(strSourceFile.Substring(0, strSourceFile.Length - 4) + "_" + intElementCounter.ToString() + ".vcf");
                        string strSourceLine = "";
                        while (strSourceLine != "END:VCARD" && !objStreamReader.EndOfStream)
                        {
                            strSourceLine = objStreamReader.ReadLine();
                            objStreamWriter.WriteLine(strSourceLine);
                        }
                        objStreamWriter.Flush();
                        objStreamWriter.Close();
                        intElementCounter++;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Error while writing file.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                objStreamReader.Close();
                MessageBox.Show("File has been successfully processed.", "Information.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Error while reading file.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            objFormMain.EnableStartButton();
        }
    }
}
