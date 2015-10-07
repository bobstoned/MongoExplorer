namespace Fester.MongoExplorer.Plugin.MongoImaging {
	partial class ImageGenerationDialog {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.label2 = new System.Windows.Forms.Label();
			this.progressBar = new System.Windows.Forms.ProgressBar();
			this.patientSelectionCriteriaGroupBox = new System.Windows.Forms.GroupBox();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.patientNumberTextBox = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.scopeWithRadioButton = new System.Windows.Forms.RadioButton();
			this.replaceImagesCheckbox = new System.Windows.Forms.CheckBox();
			this.addNewImagesCheckBox = new System.Windows.Forms.CheckBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.sampleFilesListBox = new System.Windows.Forms.CheckedListBox();
			this.filesCountLabel = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.browseButton = new System.Windows.Forms.Button();
			this.sampleFilesPathTextBox = new System.Windows.Forms.TextBox();
			this.patientCountUpDown = new System.Windows.Forms.NumericUpDown();
			this.scopeWithoutRadioButton = new System.Windows.Forms.RadioButton();
			this.scopeAllRadioButton = new System.Windows.Forms.RadioButton();
			this.goButton = new System.Windows.Forms.Button();
			this.closeButton = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.failedTextBox = new System.Windows.Forms.TextBox();
			this.processedTextBox = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.messageTextBox = new System.Windows.Forms.TextBox();
			this.cancelButton = new System.Windows.Forms.Button();
			this.extListBox = new System.Windows.Forms.CheckedListBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.getAllCheckBox = new System.Windows.Forms.CheckBox();
			this.patientSelectionCriteriaGroupBox.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.patientCountUpDown)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(18, 20);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(65, 17);
			this.label2.TabIndex = 5;
			this.label2.Text = "Progress";
			// 
			// progressBar
			// 
			this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.progressBar.Location = new System.Drawing.Point(21, 40);
			this.progressBar.Name = "progressBar";
			this.progressBar.Size = new System.Drawing.Size(600, 23);
			this.progressBar.TabIndex = 4;
			// 
			// patientSelectionCriteriaGroupBox
			// 
			this.patientSelectionCriteriaGroupBox.Controls.Add(this.radioButton1);
			this.patientSelectionCriteriaGroupBox.Controls.Add(this.patientNumberTextBox);
			this.patientSelectionCriteriaGroupBox.Controls.Add(this.label6);
			this.patientSelectionCriteriaGroupBox.Controls.Add(this.label5);
			this.patientSelectionCriteriaGroupBox.Controls.Add(this.scopeWithRadioButton);
			this.patientSelectionCriteriaGroupBox.Controls.Add(this.replaceImagesCheckbox);
			this.patientSelectionCriteriaGroupBox.Controls.Add(this.addNewImagesCheckBox);
			this.patientSelectionCriteriaGroupBox.Controls.Add(this.patientCountUpDown);
			this.patientSelectionCriteriaGroupBox.Controls.Add(this.scopeWithoutRadioButton);
			this.patientSelectionCriteriaGroupBox.Controls.Add(this.scopeAllRadioButton);
			this.patientSelectionCriteriaGroupBox.Location = new System.Drawing.Point(21, 106);
			this.patientSelectionCriteriaGroupBox.Name = "patientSelectionCriteriaGroupBox";
			this.patientSelectionCriteriaGroupBox.Size = new System.Drawing.Size(390, 228);
			this.patientSelectionCriteriaGroupBox.TabIndex = 6;
			this.patientSelectionCriteriaGroupBox.TabStop = false;
			this.patientSelectionCriteriaGroupBox.Text = "Patient selection";
			// 
			// radioButton1
			// 
			this.radioButton1.AutoSize = true;
			this.radioButton1.Location = new System.Drawing.Point(28, 115);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(127, 21);
			this.radioButton1.TabIndex = 24;
			this.radioButton1.Text = "Patient Number";
			this.radioButton1.UseVisualStyleBackColor = true;
			// 
			// patientNumberTextBox
			// 
			this.patientNumberTextBox.Location = new System.Drawing.Point(191, 114);
			this.patientNumberTextBox.Name = "patientNumberTextBox";
			this.patientNumberTextBox.Size = new System.Drawing.Size(120, 22);
			this.patientNumberTextBox.TabIndex = 23;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(317, 88);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(37, 17);
			this.label6.TabIndex = 22;
			this.label6.Text = "rows";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(188, 63);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(53, 17);
			this.label5.TabIndex = 21;
			this.label5.Text = "Limit to";
			// 
			// scopeWithRadioButton
			// 
			this.scopeWithRadioButton.AutoSize = true;
			this.scopeWithRadioButton.Checked = true;
			this.scopeWithRadioButton.Location = new System.Drawing.Point(28, 61);
			this.scopeWithRadioButton.Name = "scopeWithRadioButton";
			this.scopeWithRadioButton.Size = new System.Drawing.Size(106, 21);
			this.scopeWithRadioButton.TabIndex = 20;
			this.scopeWithRadioButton.TabStop = true;
			this.scopeWithRadioButton.Text = "With Images";
			this.scopeWithRadioButton.UseVisualStyleBackColor = true;
			// 
			// replaceImagesCheckbox
			// 
			this.replaceImagesCheckbox.AutoSize = true;
			this.replaceImagesCheckbox.Location = new System.Drawing.Point(28, 177);
			this.replaceImagesCheckbox.Name = "replaceImagesCheckbox";
			this.replaceImagesCheckbox.Size = new System.Drawing.Size(173, 21);
			this.replaceImagesCheckbox.TabIndex = 19;
			this.replaceImagesCheckbox.Text = "Replace empty images";
			this.replaceImagesCheckbox.UseVisualStyleBackColor = true;
			this.replaceImagesCheckbox.Click += new System.EventHandler(this.updateOptionsClick);
			// 
			// addNewImagesCheckBox
			// 
			this.addNewImagesCheckBox.AutoSize = true;
			this.addNewImagesCheckBox.Checked = true;
			this.addNewImagesCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.addNewImagesCheckBox.Location = new System.Drawing.Point(28, 150);
			this.addNewImagesCheckBox.Name = "addNewImagesCheckBox";
			this.addNewImagesCheckBox.Size = new System.Drawing.Size(133, 21);
			this.addNewImagesCheckBox.TabIndex = 18;
			this.addNewImagesCheckBox.Text = "Add new images";
			this.addNewImagesCheckBox.UseVisualStyleBackColor = true;
			this.addNewImagesCheckBox.Click += new System.EventHandler(this.updateOptionsClick);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.sampleFilesListBox);
			this.groupBox2.Controls.Add(this.filesCountLabel);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.browseButton);
			this.groupBox2.Controls.Add(this.sampleFilesPathTextBox);
			this.groupBox2.Location = new System.Drawing.Point(21, 344);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(390, 284);
			this.groupBox2.TabIndex = 17;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Sample files";
			// 
			// sampleFilesListBox
			// 
			this.sampleFilesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.sampleFilesListBox.CheckOnClick = true;
			this.sampleFilesListBox.FormattingEnabled = true;
			this.sampleFilesListBox.Location = new System.Drawing.Point(28, 151);
			this.sampleFilesListBox.Name = "sampleFilesListBox";
			this.sampleFilesListBox.Size = new System.Drawing.Size(326, 89);
			this.sampleFilesListBox.TabIndex = 21;
			this.sampleFilesListBox.SelectedValueChanged += new System.EventHandler(this.sampleFilesListBox_SelectedValueChanged);
			// 
			// filesCountLabel
			// 
			this.filesCountLabel.AutoSize = true;
			this.filesCountLabel.Location = new System.Drawing.Point(25, 254);
			this.filesCountLabel.Name = "filesCountLabel";
			this.filesCountLabel.Size = new System.Drawing.Size(112, 17);
			this.filesCountLabel.TabIndex = 20;
			this.filesCountLabel.Text = "No files selected";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(25, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(235, 42);
			this.label1.TabIndex = 18;
			this.label1.Text = "Choose a folder from which to add sample files to each patient";
			// 
			// browseButton
			// 
			this.browseButton.Location = new System.Drawing.Point(28, 113);
			this.browseButton.Name = "browseButton";
			this.browseButton.Size = new System.Drawing.Size(68, 27);
			this.browseButton.TabIndex = 17;
			this.browseButton.Text = "Browse..";
			this.browseButton.UseVisualStyleBackColor = true;
			this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
			// 
			// sampleFilesPathTextBox
			// 
			this.sampleFilesPathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.sampleFilesPathTextBox.Location = new System.Drawing.Point(28, 80);
			this.sampleFilesPathTextBox.Name = "sampleFilesPathTextBox";
			this.sampleFilesPathTextBox.ReadOnly = true;
			this.sampleFilesPathTextBox.Size = new System.Drawing.Size(326, 22);
			this.sampleFilesPathTextBox.TabIndex = 16;
			this.sampleFilesPathTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// patientCountUpDown
			// 
			this.patientCountUpDown.Location = new System.Drawing.Point(191, 86);
			this.patientCountUpDown.Name = "patientCountUpDown";
			this.patientCountUpDown.Size = new System.Drawing.Size(120, 22);
			this.patientCountUpDown.TabIndex = 2;
			this.patientCountUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
			// 
			// scopeWithoutRadioButton
			// 
			this.scopeWithoutRadioButton.AutoSize = true;
			this.scopeWithoutRadioButton.Location = new System.Drawing.Point(28, 86);
			this.scopeWithoutRadioButton.Name = "scopeWithoutRadioButton";
			this.scopeWithoutRadioButton.Size = new System.Drawing.Size(126, 21);
			this.scopeWithoutRadioButton.TabIndex = 1;
			this.scopeWithoutRadioButton.Text = "Without Images";
			this.scopeWithoutRadioButton.UseVisualStyleBackColor = true;
			// 
			// scopeAllRadioButton
			// 
			this.scopeAllRadioButton.AutoSize = true;
			this.scopeAllRadioButton.Location = new System.Drawing.Point(28, 36);
			this.scopeAllRadioButton.Name = "scopeAllRadioButton";
			this.scopeAllRadioButton.Size = new System.Drawing.Size(44, 21);
			this.scopeAllRadioButton.TabIndex = 0;
			this.scopeAllRadioButton.Text = "All";
			this.scopeAllRadioButton.UseVisualStyleBackColor = true;
			// 
			// goButton
			// 
			this.goButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.goButton.Enabled = false;
			this.goButton.Location = new System.Drawing.Point(18, 634);
			this.goButton.Name = "goButton";
			this.goButton.Size = new System.Drawing.Size(64, 33);
			this.goButton.TabIndex = 7;
			this.goButton.Text = "Go";
			this.goButton.UseVisualStyleBackColor = true;
			this.goButton.Click += new System.EventHandler(this.goButton_Click);
			// 
			// closeButton
			// 
			this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.closeButton.Location = new System.Drawing.Point(557, 634);
			this.closeButton.Name = "closeButton";
			this.closeButton.Size = new System.Drawing.Size(64, 33);
			this.closeButton.TabIndex = 8;
			this.closeButton.Text = "Close";
			this.closeButton.UseVisualStyleBackColor = true;
			this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.groupBox1.Controls.Add(this.failedTextBox);
			this.groupBox1.Controls.Add(this.processedTextBox);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Location = new System.Drawing.Point(427, 373);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(195, 255);
			this.groupBox1.TabIndex = 14;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Results";
			// 
			// failedTextBox
			// 
			this.failedTextBox.Location = new System.Drawing.Point(96, 60);
			this.failedTextBox.Name = "failedTextBox";
			this.failedTextBox.ReadOnly = true;
			this.failedTextBox.Size = new System.Drawing.Size(62, 22);
			this.failedTextBox.TabIndex = 3;
			// 
			// processedTextBox
			// 
			this.processedTextBox.Location = new System.Drawing.Point(96, 27);
			this.processedTextBox.Name = "processedTextBox";
			this.processedTextBox.ReadOnly = true;
			this.processedTextBox.Size = new System.Drawing.Size(62, 22);
			this.processedTextBox.TabIndex = 2;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(15, 63);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(46, 17);
			this.label4.TabIndex = 1;
			this.label4.Text = "Failed";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(15, 30);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(75, 17);
			this.label3.TabIndex = 0;
			this.label3.Text = "Processed";
			// 
			// messageTextBox
			// 
			this.messageTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.messageTextBox.Location = new System.Drawing.Point(21, 69);
			this.messageTextBox.Name = "messageTextBox";
			this.messageTextBox.Size = new System.Drawing.Size(600, 22);
			this.messageTextBox.TabIndex = 15;
			// 
			// cancelButton
			// 
			this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.cancelButton.Enabled = false;
			this.cancelButton.Location = new System.Drawing.Point(88, 634);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(64, 33);
			this.cancelButton.TabIndex = 16;
			this.cancelButton.Text = "Cancel";
			this.cancelButton.UseVisualStyleBackColor = true;
			this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
			// 
			// extListBox
			// 
			this.extListBox.CheckOnClick = true;
			this.extListBox.FormattingEnabled = true;
			this.extListBox.Items.AddRange(new object[] {
            "bmp",
            "doc",
            "gif",
            "jpg",
            "pdf",
            "png",
            "rtf",
            "tiff",
            "txt"});
			this.extListBox.Location = new System.Drawing.Point(18, 36);
			this.extListBox.Name = "extListBox";
			this.extListBox.Size = new System.Drawing.Size(104, 157);
			this.extListBox.TabIndex = 17;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.getAllCheckBox);
			this.groupBox3.Controls.Add(this.extListBox);
			this.groupBox3.Location = new System.Drawing.Point(427, 106);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(195, 228);
			this.groupBox3.TabIndex = 18;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "File extensions";
			// 
			// getAllCheckBox
			// 
			this.getAllCheckBox.AutoSize = true;
			this.getAllCheckBox.Location = new System.Drawing.Point(18, 199);
			this.getAllCheckBox.Name = "getAllCheckBox";
			this.getAllCheckBox.Size = new System.Drawing.Size(158, 21);
			this.getAllCheckBox.TabIndex = 18;
			this.getAllCheckBox.Text = "Get all images types";
			this.getAllCheckBox.UseVisualStyleBackColor = true;
			this.getAllCheckBox.CheckedChanged += new System.EventHandler(this.getAllCheckBox_CheckedChanged);
			// 
			// ImageGenerationDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(642, 692);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.messageTextBox);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.closeButton);
			this.Controls.Add(this.goButton);
			this.Controls.Add(this.patientSelectionCriteriaGroupBox);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.progressBar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ImageGenerationDialog";
			this.Text = "Image Generation";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ImageGenerationDialog_FormClosing);
			this.patientSelectionCriteriaGroupBox.ResumeLayout(false);
			this.patientSelectionCriteriaGroupBox.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.patientCountUpDown)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ProgressBar progressBar;
		private System.Windows.Forms.GroupBox patientSelectionCriteriaGroupBox;
		private System.Windows.Forms.NumericUpDown patientCountUpDown;
		private System.Windows.Forms.RadioButton scopeWithoutRadioButton;
		private System.Windows.Forms.RadioButton scopeAllRadioButton;
		private System.Windows.Forms.Button goButton;
		private System.Windows.Forms.Button closeButton;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox failedTextBox;
		private System.Windows.Forms.TextBox processedTextBox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox messageTextBox;
		private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button browseButton;
		private System.Windows.Forms.TextBox sampleFilesPathTextBox;
		private System.Windows.Forms.Label filesCountLabel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.CheckedListBox sampleFilesListBox;
		private System.Windows.Forms.CheckBox replaceImagesCheckbox;
		private System.Windows.Forms.CheckBox addNewImagesCheckBox;
		private System.Windows.Forms.RadioButton scopeWithRadioButton;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.TextBox patientNumberTextBox;
		private System.Windows.Forms.CheckedListBox extListBox;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.CheckBox getAllCheckBox;
	}
}