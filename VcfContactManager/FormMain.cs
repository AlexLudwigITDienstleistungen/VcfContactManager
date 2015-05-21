using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;


namespace ContactSplitter
{
	public partial class FormMain : Form
	{
		public FormMain()
		{
			InitializeComponent();
		}

		private void buttonSourceSelect_Click(object sender, EventArgs e)
		{
			OpenFileDialog objOpenFileDialog = new OpenFileDialog();
			objOpenFileDialog.Filter = "V-Card|*.vcf";
			objOpenFileDialog.Multiselect = false;
			if(Program.FolderBrowsing != "")
			{
                objOpenFileDialog.InitialDirectory = Program.FolderBrowsing;
			}
			if(objOpenFileDialog.ShowDialog(this) == DialogResult.OK)
			{
                Program.FolderBrowsing = objOpenFileDialog.FileName.Substring(0, objOpenFileDialog.FileName.LastIndexOf("\\"));
				textBoxSource.Text = objOpenFileDialog.FileName;
			}
		}

		private void buttonDestinationSelect_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog objFolderBrowserDialog = new FolderBrowserDialog();
            if (Program.FolderBrowsing != "")
			{
                objFolderBrowserDialog.SelectedPath = Program.FolderBrowsing;
			}
			if(objFolderBrowserDialog.ShowDialog(this) == DialogResult.OK)
			{
                Program.FolderBrowsing = objFolderBrowserDialog.SelectedPath;
				textBoxDestination.Text = objFolderBrowserDialog.SelectedPath;
			}
		}

		private void buttonConvert_Click(object sender, EventArgs e)
        {
            ThreadStart objThreadStart = null;
            if (radioButtonSplit.Checked)
            {
                if (textBoxSource.Text != "" && textBoxDestination.Text != "")
                {
                    buttonStart.Enabled = false;
                    textBoxDestination.Enabled = false;
                    buttonDestinationSelect.Enabled = false;
                    textBoxOutlook.Enabled = false;
                    buttonOutlookSelect.Enabled = false;
                    objThreadStart = new ThreadStart(Program.Convert);
                }
                else
                {
                    MessageBox.Show(FormMain.ActiveForm, "Error Source and Destination must be specified.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (textBoxSource.Text != "" && textBoxOutlook.Text != "")
                {
                    buttonStart.Enabled = false;
                    textBoxDestination.Enabled = false;
                    buttonDestinationSelect.Enabled = false;
                    textBoxOutlook.Enabled = false;
                    buttonOutlookSelect.Enabled = false;
                    objThreadStart = new ThreadStart(Program.Import);
                }
                else
                {
                    MessageBox.Show(FormMain.ActiveForm, "Error Source and Destination must be specified.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            try
            {
                Thread objThread = new Thread(objThreadStart);
                Program.SourceFile = textBoxSource.Text;
                Program.DestinationDirectory = textBoxDestination.Text;
                objThread.Start();
            }
            catch (Exception)
            {
            }
		}

        private void radioButtonSplit_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonSplit.Checked)
            {
                textBoxDestination.Enabled = true;
                buttonDestinationSelect.Enabled = true;
                textBoxOutlook.Enabled = false;
                buttonOutlookSelect.Enabled = false;
            }
            else
            {
                textBoxDestination.Enabled = false;
                buttonDestinationSelect.Enabled = false;
                textBoxOutlook.Enabled = true;
                buttonOutlookSelect.Enabled = true;
            }
        }

        private void buttonOutlookSelect_Click(object sender, EventArgs e)
        {
            Program.SelectMapiFolder();
            if (Program.MapiFolder != null)
            {
                textBoxOutlook.Text = Program.MapiFolder.FolderPath;
            }
            else
            {
                textBoxOutlook.Text = "";
            }
            this.Focus();
        }

        public void EnableStartButton()
        {
            if (buttonStart.InvokeRequired)
            {
                buttonStart.Invoke(new MethodInvoker(EnableStartButton));
                return;
            }
            else
            {
                buttonStart.Enabled = true;
                radioButtonSplit_CheckedChanged(new object(), new EventArgs());
            }
        }
	}
}
