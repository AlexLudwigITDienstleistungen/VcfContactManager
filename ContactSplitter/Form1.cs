using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace ContactSplitter
{
	public partial class Form1 : Form
	{
		private static string strFolderBrowsing;
		private static string strSourceFile;
		private static string strDestinationDirectory;
		public Form1()
		{
			InitializeComponent();
		}

		private void buttonSourceSelect_Click(object sender, EventArgs e)
		{
			OpenFileDialog objOpenFileDialog = new OpenFileDialog();
			objOpenFileDialog.Filter = "V-CARD|*.vcf";
			objOpenFileDialog.Multiselect = false;
			if(strFolderBrowsing != "")
			{
				objOpenFileDialog.InitialDirectory = strFolderBrowsing;
			}
			if(objOpenFileDialog.ShowDialog(this) == DialogResult.OK)
			{
				strFolderBrowsing = objOpenFileDialog.FileName.Substring(0, objOpenFileDialog.FileName.LastIndexOf("\\"));
				textBoxSource.Text = objOpenFileDialog.FileName;
			}
		}

		private void buttonDestinationSelect_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog objFolderBrowserDialog = new FolderBrowserDialog();
			if(strFolderBrowsing != "")
			{
				objFolderBrowserDialog.SelectedPath = strFolderBrowsing;
			}
			if(objFolderBrowserDialog.ShowDialog(this) == DialogResult.OK)
			{
				strFolderBrowsing = objFolderBrowserDialog.SelectedPath;
				textBoxDestination.Text = objFolderBrowserDialog.SelectedPath;
			}
		}

		private void buttonConvert_Click(object sender, EventArgs e)
		{
			ThreadStart objThreadStart = new ThreadStart(Convert);
			Thread objThread = new Thread(objThreadStart);
			strSourceFile = textBoxSource.Text;
			strDestinationDirectory = textBoxDestination.Text;
			objThread.Start();
		}

		private void Convert()
		{
			try
			{
				StreamReader objStreamReader = new StreamReader(strSourceFile);
				int intElementCounter = 1;
				while(!objStreamReader.EndOfStream)
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
						MessageBox.Show(Form1.ActiveForm, "Error while writing file.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
				objStreamReader.Close();
				MessageBox.Show(Form1.ActiveForm, "File has been successfully processed.", "Information.", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception)
			{
				MessageBox.Show(Form1.ActiveForm, "Error while reading file.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
