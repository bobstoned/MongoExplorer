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
			this.panel1 = new System.Windows.Forms.Panel();
			this.getImagesButton = new System.Windows.Forms.Button();
			this.imageEditorFrame = new Blithe.Client.Controls.ImageEditor.ImageEditorFrame();
			this.templateListBox = new System.Windows.Forms.ListBox();
			this.fileDialog = new System.Windows.Forms.OpenFileDialog();
			this.flatTabControl1 = new FlatTabControl.FlatTabControl();
			this.imageEditTab = new System.Windows.Forms.TabPage();
			this.annotationsTab = new System.Windows.Forms.TabPage();
			this.annotationsInfoControl = new Fester.MongoExplorer.Plugin.MongoImaging.AnnotationsInfoControl();
			this.saveButton = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.flatTabControl1.SuspendLayout();
			this.imageEditTab.SuspendLayout();
			this.annotationsTab.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.saveButton);
			this.panel1.Controls.Add(this.getImagesButton);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(880, 60);
			this.panel1.TabIndex = 7;
			// 
			// getImagesButton
			// 
			this.getImagesButton.Location = new System.Drawing.Point(14, 15);
			this.getImagesButton.Name = "getImagesButton";
			this.getImagesButton.Size = new System.Drawing.Size(126, 35);
			this.getImagesButton.TabIndex = 19;
			this.getImagesButton.Text = "Get Images";
			this.getImagesButton.UseVisualStyleBackColor = true;
			this.getImagesButton.Click += new System.EventHandler(this.getImagesButton_Click);
			// 
			// imageEditorFrame
			// 
			this.imageEditorFrame.Dock = System.Windows.Forms.DockStyle.Fill;
			this.imageEditorFrame.Location = new System.Drawing.Point(136, 8);
			this.imageEditorFrame.Margin = new System.Windows.Forms.Padding(4);
			this.imageEditorFrame.Name = "imageEditorFrame";
			this.imageEditorFrame.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.imageEditorFrame.Size = new System.Drawing.Size(728, 533);
			this.imageEditorFrame.TabIndex = 8;
			// 
			// templateListBox
			// 
			this.templateListBox.DisplayMember = "Name";
			this.templateListBox.Dock = System.Windows.Forms.DockStyle.Left;
			this.templateListBox.FormattingEnabled = true;
			this.templateListBox.ItemHeight = 16;
			this.templateListBox.Location = new System.Drawing.Point(8, 8);
			this.templateListBox.Name = "templateListBox";
			this.templateListBox.Size = new System.Drawing.Size(128, 533);
			this.templateListBox.TabIndex = 9;
			// 
			// fileDialog
			// 
			this.fileDialog.FileName = "openFileDialog1";
			// 
			// flatTabControl1
			// 
			this.flatTabControl1.Controls.Add(this.imageEditTab);
			this.flatTabControl1.Controls.Add(this.annotationsTab);
			this.flatTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flatTabControl1.Location = new System.Drawing.Point(0, 60);
			this.flatTabControl1.myBackColor = System.Drawing.SystemColors.Control;
			this.flatTabControl1.Name = "flatTabControl1";
			this.flatTabControl1.SelectedIndex = 0;
			this.flatTabControl1.Size = new System.Drawing.Size(880, 582);
			this.flatTabControl1.TabIndex = 10;
			// 
			// imageEditTab
			// 
			this.imageEditTab.Controls.Add(this.imageEditorFrame);
			this.imageEditTab.Controls.Add(this.templateListBox);
			this.imageEditTab.Location = new System.Drawing.Point(4, 29);
			this.imageEditTab.Name = "imageEditTab";
			this.imageEditTab.Padding = new System.Windows.Forms.Padding(8);
			this.imageEditTab.Size = new System.Drawing.Size(872, 549);
			this.imageEditTab.TabIndex = 0;
			this.imageEditTab.Text = "Image Edit";
			this.imageEditTab.UseVisualStyleBackColor = true;
			// 
			// annotationsTab
			// 
			this.annotationsTab.AutoScroll = true;
			this.annotationsTab.Controls.Add(this.annotationsInfoControl);
			this.annotationsTab.Location = new System.Drawing.Point(4, 29);
			this.annotationsTab.Name = "annotationsTab";
			this.annotationsTab.Padding = new System.Windows.Forms.Padding(3);
			this.annotationsTab.Size = new System.Drawing.Size(872, 549);
			this.annotationsTab.TabIndex = 1;
			this.annotationsTab.Text = "Annotations";
			this.annotationsTab.UseVisualStyleBackColor = true;
			// 
			// annotationsInfoControl
			// 
			this.annotationsInfoControl.Annotations = null;
			this.annotationsInfoControl.Dock = System.Windows.Forms.DockStyle.Top;
			this.annotationsInfoControl.Location = new System.Drawing.Point(3, 3);
			this.annotationsInfoControl.Name = "annotationsInfoControl";
			this.annotationsInfoControl.Size = new System.Drawing.Size(845, 615);
			this.annotationsInfoControl.TabIndex = 0;
			// 
			// saveButton
			// 
			this.saveButton.Location = new System.Drawing.Point(146, 15);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(126, 35);
			this.saveButton.TabIndex = 20;
			this.saveButton.Text = "Save";
			this.saveButton.UseVisualStyleBackColor = true;
			this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
			// 
			// ImagingPluginControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.flatTabControl1);
			this.Controls.Add(this.panel1);
			this.Name = "ImagingPluginControl";
			this.Size = new System.Drawing.Size(880, 642);
			this.panel1.ResumeLayout(false);
			this.flatTabControl1.ResumeLayout(false);
			this.imageEditTab.ResumeLayout(false);
			this.annotationsTab.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private Blithe.Client.Controls.ImageEditor.ImageEditorFrame imageEditorFrame;
		private System.Windows.Forms.ListBox templateListBox;
		private System.Windows.Forms.OpenFileDialog fileDialog;
		private System.Windows.Forms.Button getImagesButton;
		private FlatTabControl.FlatTabControl flatTabControl1;
		private System.Windows.Forms.TabPage imageEditTab;
		private System.Windows.Forms.TabPage annotationsTab;
		private AnnotationsInfoControl annotationsInfoControl;
		private System.Windows.Forms.Button saveButton;
	}
}
