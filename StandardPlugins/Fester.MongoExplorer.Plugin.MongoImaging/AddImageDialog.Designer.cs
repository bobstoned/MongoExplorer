namespace Fester.MongoExplorer.Plugin.MongoImaging {
	partial class AddImageDialog {
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
			this.okButton = new System.Windows.Forms.Button();
			this.cancelButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.descriptionTextBox = new System.Windows.Forms.TextBox();
			this.openFileButton = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.fileNameTextBox = new System.Windows.Forms.TextBox();
			this.chooseImageDialog = new System.Windows.Forms.OpenFileDialog();
			this.label2 = new System.Windows.Forms.Label();
			this.nameTextBox = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.infoTextBox = new System.Windows.Forms.GroupBox();
			this.dimensionsTextBox = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.sizeTextBox = new System.Windows.Forms.TextBox();
			this.infoTextBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// okButton
			// 
			this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.okButton.Enabled = false;
			this.okButton.Location = new System.Drawing.Point(231, 355);
			this.okButton.Name = "okButton";
			this.okButton.Size = new System.Drawing.Size(75, 31);
			this.okButton.TabIndex = 0;
			this.okButton.Text = "OK";
			this.okButton.UseVisualStyleBackColor = true;
			this.okButton.Click += new System.EventHandler(this.okButton_Click);
			// 
			// cancelButton
			// 
			this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cancelButton.Location = new System.Drawing.Point(312, 355);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(75, 31);
			this.cancelButton.TabIndex = 1;
			this.cancelButton.Text = "Cancel";
			this.cancelButton.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 220);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(79, 17);
			this.label1.TabIndex = 2;
			this.label1.Text = "Description";
			// 
			// descriptionTextBox
			// 
			this.descriptionTextBox.AcceptsReturn = true;
			this.descriptionTextBox.AcceptsTab = true;
			this.descriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.descriptionTextBox.Location = new System.Drawing.Point(15, 240);
			this.descriptionTextBox.Multiline = true;
			this.descriptionTextBox.Name = "descriptionTextBox";
			this.descriptionTextBox.Size = new System.Drawing.Size(372, 88);
			this.descriptionTextBox.TabIndex = 3;
			// 
			// openFileButton
			// 
			this.openFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.openFileButton.Location = new System.Drawing.Point(356, 26);
			this.openFileButton.Name = "openFileButton";
			this.openFileButton.Size = new System.Drawing.Size(33, 28);
			this.openFileButton.TabIndex = 4;
			this.openFileButton.Text = "...";
			this.openFileButton.UseVisualStyleBackColor = true;
			this.openFileButton.Click += new System.EventHandler(this.openFileButton_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(34, 17);
			this.label3.TabIndex = 6;
			this.label3.Text = "File:";
			// 
			// fileNameTextBox
			// 
			this.fileNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.fileNameTextBox.Location = new System.Drawing.Point(15, 29);
			this.fileNameTextBox.Name = "fileNameTextBox";
			this.fileNameTextBox.ReadOnly = true;
			this.fileNameTextBox.Size = new System.Drawing.Size(335, 22);
			this.fileNameTextBox.TabIndex = 7;
			// 
			// chooseImageDialog
			// 
			this.chooseImageDialog.DefaultExt = "jpg";
			this.chooseImageDialog.FileName = "*.jpg";
			this.chooseImageDialog.Filter = "*.jpg|JPEG Images;";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 60);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(45, 17);
			this.label2.TabIndex = 8;
			this.label2.Text = "Name";
			// 
			// nameTextBox
			// 
			this.nameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.nameTextBox.BackColor = System.Drawing.SystemColors.Window;
			this.nameTextBox.Location = new System.Drawing.Point(15, 80);
			this.nameTextBox.Name = "nameTextBox";
			this.nameTextBox.Size = new System.Drawing.Size(372, 22);
			this.nameTextBox.TabIndex = 9;
			this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 27);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(85, 17);
			this.label4.TabIndex = 10;
			this.label4.Text = "Dimensions:";
			// 
			// infoTextBox
			// 
			this.infoTextBox.Controls.Add(this.sizeTextBox);
			this.infoTextBox.Controls.Add(this.label5);
			this.infoTextBox.Controls.Add(this.dimensionsTextBox);
			this.infoTextBox.Controls.Add(this.label4);
			this.infoTextBox.Location = new System.Drawing.Point(15, 111);
			this.infoTextBox.Name = "infoTextBox";
			this.infoTextBox.Size = new System.Drawing.Size(372, 95);
			this.infoTextBox.TabIndex = 11;
			this.infoTextBox.TabStop = false;
			this.infoTextBox.Text = "Image Properties";
			// 
			// dimensionsTextBox
			// 
			this.dimensionsTextBox.Location = new System.Drawing.Point(97, 24);
			this.dimensionsTextBox.Name = "dimensionsTextBox";
			this.dimensionsTextBox.ReadOnly = true;
			this.dimensionsTextBox.Size = new System.Drawing.Size(172, 22);
			this.dimensionsTextBox.TabIndex = 11;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(6, 56);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(39, 17);
			this.label5.TabIndex = 12;
			this.label5.Text = "Size:";
			// 
			// sizeTextBox
			// 
			this.sizeTextBox.Location = new System.Drawing.Point(97, 56);
			this.sizeTextBox.Name = "sizeTextBox";
			this.sizeTextBox.ReadOnly = true;
			this.sizeTextBox.Size = new System.Drawing.Size(172, 22);
			this.sizeTextBox.TabIndex = 13;
			// 
			// AddImageDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.cancelButton;
			this.ClientSize = new System.Drawing.Size(399, 400);
			this.Controls.Add(this.infoTextBox);
			this.Controls.Add(this.nameTextBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.fileNameTextBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.openFileButton);
			this.Controls.Add(this.descriptionTextBox);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.okButton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "AddImageDialog";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Add an image";
			this.infoTextBox.ResumeLayout(false);
			this.infoTextBox.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button okButton;
		private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox descriptionTextBox;
		private System.Windows.Forms.Button openFileButton;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox fileNameTextBox;
		private System.Windows.Forms.OpenFileDialog chooseImageDialog;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox nameTextBox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.GroupBox infoTextBox;
		private System.Windows.Forms.TextBox sizeTextBox;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox dimensionsTextBox;
	}
}