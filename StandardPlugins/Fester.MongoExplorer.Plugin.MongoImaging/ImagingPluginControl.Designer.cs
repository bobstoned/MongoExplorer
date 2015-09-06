namespace Fester.MongoExplorer.Plugin.MongoImaging {
	partial class ImagingPluginControl {
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.openFileButton = new System.Windows.Forms.Button();
			this.getTemplatesButton = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.imageEditorFrame = new Blithe.Client.Controls.ImageEditor.ImageEditorFrame();
			this.templateListBox = new System.Windows.Forms.ListBox();
			this.fileDialog = new System.Windows.Forms.OpenFileDialog();
			this.saveButton = new System.Windows.Forms.Button();
			this.labelName = new System.Windows.Forms.Label();
			this.nameTextBox = new System.Windows.Forms.TextBox();
			this.descriptionTextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.regionTextBox = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(285, 29);
			this.label1.TabIndex = 0;
			this.label1.Text = "Prescription Templates";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.regionTextBox);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.descriptionTextBox);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.nameTextBox);
			this.panel1.Controls.Add(this.labelName);
			this.panel1.Controls.Add(this.saveButton);
			this.panel1.Controls.Add(this.openFileButton);
			this.panel1.Controls.Add(this.getTemplatesButton);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(728, 204);
			this.panel1.TabIndex = 7;
			// 
			// openFileButton
			// 
			this.openFileButton.Location = new System.Drawing.Point(448, 33);
			this.openFileButton.Name = "openFileButton";
			this.openFileButton.Size = new System.Drawing.Size(115, 35);
			this.openFileButton.TabIndex = 11;
			this.openFileButton.Text = "Open File";
			this.openFileButton.UseVisualStyleBackColor = true;
			this.openFileButton.Click += new System.EventHandler(this.openFile_Click);
			// 
			// getTemplatesButton
			// 
			this.getTemplatesButton.Location = new System.Drawing.Point(316, 33);
			this.getTemplatesButton.Name = "getTemplatesButton";
			this.getTemplatesButton.Size = new System.Drawing.Size(126, 35);
			this.getTemplatesButton.TabIndex = 10;
			this.getTemplatesButton.Text = "Get Templates";
			this.getTemplatesButton.UseVisualStyleBackColor = true;
			this.getTemplatesButton.Click += new System.EventHandler(this.getTemplatesButton_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.SystemColors.Control;
			this.label3.ForeColor = System.Drawing.Color.DarkViolet;
			this.label3.Location = new System.Drawing.Point(5, 42);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(296, 17);
			this.label3.TabIndex = 9;
			this.label3.Text = "Prescription templates managed in Mongo DB";
			// 
			// imageEditorFrame
			// 
			this.imageEditorFrame.Dock = System.Windows.Forms.DockStyle.Fill;
			this.imageEditorFrame.Location = new System.Drawing.Point(120, 204);
			this.imageEditorFrame.Margin = new System.Windows.Forms.Padding(4);
			this.imageEditorFrame.Name = "imageEditorFrame";
			this.imageEditorFrame.Size = new System.Drawing.Size(608, 438);
			this.imageEditorFrame.TabIndex = 8;
			// 
			// templateListBox
			// 
			this.templateListBox.DisplayMember = "Name";
			this.templateListBox.Dock = System.Windows.Forms.DockStyle.Left;
			this.templateListBox.FormattingEnabled = true;
			this.templateListBox.ItemHeight = 16;
			this.templateListBox.Location = new System.Drawing.Point(0, 204);
			this.templateListBox.Name = "templateListBox";
			this.templateListBox.Size = new System.Drawing.Size(120, 438);
			this.templateListBox.TabIndex = 9;
			// 
			// fileDialog
			// 
			this.fileDialog.FileName = "openFileDialog1";
			// 
			// saveButton
			// 
			this.saveButton.Location = new System.Drawing.Point(569, 33);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(115, 35);
			this.saveButton.TabIndex = 12;
			this.saveButton.Text = "Save";
			this.saveButton.UseVisualStyleBackColor = true;
			this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
			// 
			// labelName
			// 
			this.labelName.AutoSize = true;
			this.labelName.Location = new System.Drawing.Point(325, 97);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(45, 17);
			this.labelName.TabIndex = 13;
			this.labelName.Text = "Name";
			// 
			// nameTextBox
			// 
			this.nameTextBox.Location = new System.Drawing.Point(413, 94);
			this.nameTextBox.Name = "nameTextBox";
			this.nameTextBox.Size = new System.Drawing.Size(150, 22);
			this.nameTextBox.TabIndex = 14;
			// 
			// descriptionTextBox
			// 
			this.descriptionTextBox.Location = new System.Drawing.Point(413, 124);
			this.descriptionTextBox.Name = "descriptionTextBox";
			this.descriptionTextBox.Size = new System.Drawing.Size(271, 22);
			this.descriptionTextBox.TabIndex = 16;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(325, 127);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(79, 17);
			this.label2.TabIndex = 15;
			this.label2.Text = "Description";
			// 
			// regionTextBox
			// 
			this.regionTextBox.Location = new System.Drawing.Point(413, 152);
			this.regionTextBox.Name = "regionTextBox";
			this.regionTextBox.Size = new System.Drawing.Size(271, 22);
			this.regionTextBox.TabIndex = 18;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(325, 155);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(60, 17);
			this.label4.TabIndex = 17;
			this.label4.Text = "Regions";
			// 
			// ImagingPluginControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.imageEditorFrame);
			this.Controls.Add(this.templateListBox);
			this.Controls.Add(this.panel1);
			this.Name = "ImagingPluginControl";
			this.Size = new System.Drawing.Size(728, 642);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label3;
		private Blithe.Client.Controls.ImageEditor.ImageEditorFrame imageEditorFrame;
		private System.Windows.Forms.ListBox templateListBox;
		private System.Windows.Forms.Button getTemplatesButton;
		private System.Windows.Forms.Button openFileButton;
		private System.Windows.Forms.OpenFileDialog fileDialog;
		private System.Windows.Forms.Button saveButton;
		private System.Windows.Forms.TextBox regionTextBox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox descriptionTextBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox nameTextBox;
		private System.Windows.Forms.Label labelName;
	}
}
