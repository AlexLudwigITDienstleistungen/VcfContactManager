namespace ContactSplitter
{
	partial class FormMain
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Vom Windows Form-Designer generierter Code

		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung.
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
            this.labelSource = new System.Windows.Forms.Label();
            this.labelDestination = new System.Windows.Forms.Label();
            this.textBoxSource = new System.Windows.Forms.TextBox();
            this.textBoxDestination = new System.Windows.Forms.TextBox();
            this.buttonSourceSelect = new System.Windows.Forms.Button();
            this.buttonDestinationSelect = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.radioButtonSplit = new System.Windows.Forms.RadioButton();
            this.buttonOutlookSelect = new System.Windows.Forms.Button();
            this.textBoxOutlook = new System.Windows.Forms.TextBox();
            this.labelOutlook = new System.Windows.Forms.Label();
            this.radioButtonOutlookImport = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // labelSource
            // 
            this.labelSource.AutoSize = true;
            this.labelSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelSource.Location = new System.Drawing.Point(12, 16);
            this.labelSource.Name = "labelSource";
            this.labelSource.Size = new System.Drawing.Size(72, 17);
            this.labelSource.TabIndex = 0;
            this.labelSource.Text = "Quelldatei";
            // 
            // labelDestination
            // 
            this.labelDestination.AutoSize = true;
            this.labelDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelDestination.Location = new System.Drawing.Point(12, 50);
            this.labelDestination.Name = "labelDestination";
            this.labelDestination.Size = new System.Drawing.Size(73, 17);
            this.labelDestination.TabIndex = 1;
            this.labelDestination.Text = "Zielordner";
            // 
            // textBoxSource
            // 
            this.textBoxSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxSource.Location = new System.Drawing.Point(113, 14);
            this.textBoxSource.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSource.Name = "textBoxSource";
            this.textBoxSource.Size = new System.Drawing.Size(457, 23);
            this.textBoxSource.TabIndex = 2;
            // 
            // textBoxDestination
            // 
            this.textBoxDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxDestination.Location = new System.Drawing.Point(113, 47);
            this.textBoxDestination.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxDestination.Name = "textBoxDestination";
            this.textBoxDestination.Size = new System.Drawing.Size(457, 23);
            this.textBoxDestination.TabIndex = 3;
            // 
            // buttonSourceSelect
            // 
            this.buttonSourceSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonSourceSelect.Location = new System.Drawing.Point(577, 12);
            this.buttonSourceSelect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSourceSelect.Name = "buttonSourceSelect";
            this.buttonSourceSelect.Size = new System.Drawing.Size(132, 28);
            this.buttonSourceSelect.TabIndex = 4;
            this.buttonSourceSelect.Text = "Auswählen";
            this.buttonSourceSelect.UseVisualStyleBackColor = true;
            this.buttonSourceSelect.Click += new System.EventHandler(this.buttonSourceSelect_Click);
            // 
            // buttonDestinationSelect
            // 
            this.buttonDestinationSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonDestinationSelect.Location = new System.Drawing.Point(577, 46);
            this.buttonDestinationSelect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDestinationSelect.Name = "buttonDestinationSelect";
            this.buttonDestinationSelect.Size = new System.Drawing.Size(132, 28);
            this.buttonDestinationSelect.TabIndex = 5;
            this.buttonDestinationSelect.Text = "Auswählen";
            this.buttonDestinationSelect.UseVisualStyleBackColor = true;
            this.buttonDestinationSelect.Click += new System.EventHandler(this.buttonDestinationSelect_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonStart.Location = new System.Drawing.Point(577, 112);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(132, 28);
            this.buttonStart.TabIndex = 6;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonConvert_Click);
            // 
            // radioButtonSplit
            // 
            this.radioButtonSplit.AutoSize = true;
            this.radioButtonSplit.Checked = true;
            this.radioButtonSplit.Location = new System.Drawing.Point(16, 116);
            this.radioButtonSplit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonSplit.Name = "radioButtonSplit";
            this.radioButtonSplit.Size = new System.Drawing.Size(73, 21);
            this.radioButtonSplit.TabIndex = 7;
            this.radioButtonSplit.TabStop = true;
            this.radioButtonSplit.Text = "Splitten";
            this.radioButtonSplit.UseVisualStyleBackColor = true;
            this.radioButtonSplit.CheckedChanged += new System.EventHandler(this.radioButtonSplit_CheckedChanged);
            // 
            // buttonOutlookSelect
            // 
            this.buttonOutlookSelect.Enabled = false;
            this.buttonOutlookSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonOutlookSelect.Location = new System.Drawing.Point(577, 79);
            this.buttonOutlookSelect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonOutlookSelect.Name = "buttonOutlookSelect";
            this.buttonOutlookSelect.Size = new System.Drawing.Size(132, 28);
            this.buttonOutlookSelect.TabIndex = 10;
            this.buttonOutlookSelect.Text = "Auswählen";
            this.buttonOutlookSelect.UseVisualStyleBackColor = true;
            this.buttonOutlookSelect.Click += new System.EventHandler(this.buttonOutlookSelect_Click);
            // 
            // textBoxOutlook
            // 
            this.textBoxOutlook.Enabled = false;
            this.textBoxOutlook.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxOutlook.Location = new System.Drawing.Point(113, 80);
            this.textBoxOutlook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxOutlook.Name = "textBoxOutlook";
            this.textBoxOutlook.Size = new System.Drawing.Size(457, 23);
            this.textBoxOutlook.TabIndex = 9;
            // 
            // labelOutlook
            // 
            this.labelOutlook.AutoSize = true;
            this.labelOutlook.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelOutlook.Location = new System.Drawing.Point(12, 84);
            this.labelOutlook.Name = "labelOutlook";
            this.labelOutlook.Size = new System.Drawing.Size(99, 17);
            this.labelOutlook.TabIndex = 8;
            this.labelOutlook.Text = "Outlookordner";
            // 
            // radioButtonOutlookImport
            // 
            this.radioButtonOutlookImport.AutoSize = true;
            this.radioButtonOutlookImport.Location = new System.Drawing.Point(113, 116);
            this.radioButtonOutlookImport.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonOutlookImport.Name = "radioButtonOutlookImport";
            this.radioButtonOutlookImport.Size = new System.Drawing.Size(118, 21);
            this.radioButtonOutlookImport.TabIndex = 11;
            this.radioButtonOutlookImport.Text = "Outlook import";
            this.radioButtonOutlookImport.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 154);
            this.Controls.Add(this.radioButtonOutlookImport);
            this.Controls.Add(this.buttonOutlookSelect);
            this.Controls.Add(this.textBoxOutlook);
            this.Controls.Add(this.labelOutlook);
            this.Controls.Add(this.radioButtonSplit);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.buttonDestinationSelect);
            this.Controls.Add(this.buttonSourceSelect);
            this.Controls.Add(this.textBoxDestination);
            this.Controls.Add(this.textBoxSource);
            this.Controls.Add(this.labelDestination);
            this.Controls.Add(this.labelSource);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormMain";
            this.Text = "Vcf Contact Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelSource;
		private System.Windows.Forms.Label labelDestination;
		private System.Windows.Forms.TextBox textBoxSource;
		private System.Windows.Forms.TextBox textBoxDestination;
		private System.Windows.Forms.Button buttonSourceSelect;
		private System.Windows.Forms.Button buttonDestinationSelect;
		private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.RadioButton radioButtonSplit;
        private System.Windows.Forms.Button buttonOutlookSelect;
        private System.Windows.Forms.TextBox textBoxOutlook;
        private System.Windows.Forms.Label labelOutlook;
        private System.Windows.Forms.RadioButton radioButtonOutlookImport;
	}
}

