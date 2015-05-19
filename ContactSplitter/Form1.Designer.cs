namespace ContactSplitter
{
	partial class Form1
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
			this.buttonConvert = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// labelSource
			// 
			this.labelSource.AutoSize = true;
			this.labelSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.labelSource.Location = new System.Drawing.Point(12, 16);
			this.labelSource.Name = "labelSource";
			this.labelSource.Size = new System.Drawing.Size(84, 20);
			this.labelSource.TabIndex = 0;
			this.labelSource.Text = "Quelldatei";
			// 
			// labelDestination
			// 
			this.labelDestination.AutoSize = true;
			this.labelDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.labelDestination.Location = new System.Drawing.Point(12, 50);
			this.labelDestination.Name = "labelDestination";
			this.labelDestination.Size = new System.Drawing.Size(83, 20);
			this.labelDestination.TabIndex = 1;
			this.labelDestination.Text = "Zielordner";
			// 
			// textBoxSource
			// 
			this.textBoxSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.textBoxSource.Location = new System.Drawing.Point(102, 13);
			this.textBoxSource.Name = "textBoxSource";
			this.textBoxSource.Size = new System.Drawing.Size(469, 26);
			this.textBoxSource.TabIndex = 2;
			// 
			// textBoxDestination
			// 
			this.textBoxDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.textBoxDestination.Location = new System.Drawing.Point(102, 47);
			this.textBoxDestination.Name = "textBoxDestination";
			this.textBoxDestination.Size = new System.Drawing.Size(469, 26);
			this.textBoxDestination.TabIndex = 3;
			// 
			// buttonSourceSelect
			// 
			this.buttonSourceSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.buttonSourceSelect.Location = new System.Drawing.Point(577, 12);
			this.buttonSourceSelect.Name = "buttonSourceSelect";
			this.buttonSourceSelect.Size = new System.Drawing.Size(114, 28);
			this.buttonSourceSelect.TabIndex = 4;
			this.buttonSourceSelect.Text = "Auswählen";
			this.buttonSourceSelect.UseVisualStyleBackColor = true;
			this.buttonSourceSelect.Click += new System.EventHandler(this.buttonSourceSelect_Click);
			// 
			// buttonDestinationSelect
			// 
			this.buttonDestinationSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.buttonDestinationSelect.Location = new System.Drawing.Point(577, 46);
			this.buttonDestinationSelect.Name = "buttonDestinationSelect";
			this.buttonDestinationSelect.Size = new System.Drawing.Size(114, 28);
			this.buttonDestinationSelect.TabIndex = 5;
			this.buttonDestinationSelect.Text = "Auswählen";
			this.buttonDestinationSelect.UseVisualStyleBackColor = true;
			this.buttonDestinationSelect.Click += new System.EventHandler(this.buttonDestinationSelect_Click);
			// 
			// buttonConvert
			// 
			this.buttonConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.buttonConvert.Location = new System.Drawing.Point(577, 80);
			this.buttonConvert.Name = "buttonConvert";
			this.buttonConvert.Size = new System.Drawing.Size(114, 28);
			this.buttonConvert.TabIndex = 6;
			this.buttonConvert.Text = "Konvertieren";
			this.buttonConvert.UseVisualStyleBackColor = true;
			this.buttonConvert.Click += new System.EventHandler(this.buttonConvert_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(703, 120);
			this.Controls.Add(this.buttonConvert);
			this.Controls.Add(this.buttonDestinationSelect);
			this.Controls.Add(this.buttonSourceSelect);
			this.Controls.Add(this.textBoxDestination);
			this.Controls.Add(this.textBoxSource);
			this.Controls.Add(this.labelDestination);
			this.Controls.Add(this.labelSource);
			this.Name = "Form1";
			this.Text = "Form1";
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
		private System.Windows.Forms.Button buttonConvert;
	}
}

