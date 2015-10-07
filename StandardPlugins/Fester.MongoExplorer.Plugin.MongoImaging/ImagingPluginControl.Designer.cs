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
			this.addImageButton = new System.Windows.Forms.Button();
			this.saveButton = new System.Windows.Forms.Button();
			this.getImagesButton = new System.Windows.Forms.Button();
			this.fileDialog = new System.Windows.Forms.OpenFileDialog();
			this.flatTabControl1 = new FlatTabControl.FlatTabControl();
			this.imageEditTab = new System.Windows.Forms.TabPage();
			this.imageBrowserControl = new Fester.MongoExplorer.Plugin.MongoImaging.Controls.ImageBrowserControl();
			this.splitter1 = new System.Windows.Forms.Splitter();
			this.annotationsTab = new System.Windows.Forms.TabPage();
			this.annotationsInfoControl = new Fester.MongoExplorer.Plugin.MongoImaging.AnnotationsInfoControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.generateButton = new System.Windows.Forms.Button();
			this.filterPanel = new System.Windows.Forms.Panel();
			this.label4 = new System.Windows.Forms.Label();
			this.sizeUpDown = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.widthUpDown = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.heightUpDown = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.nameFilterTextBox = new System.Windows.Forms.TextBox();
			this.flatTabControl1.SuspendLayout();
			this.imageEditTab.SuspendLayout();
			this.annotationsTab.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.filterPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.sizeUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.widthUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.heightUpDown)).BeginInit();
			this.SuspendLayout();
			// 
			// addImageButton
			// 
			this.addImageButton.Location = new System.Drawing.Point(697, 12);
			this.addImageButton.Name = "addImageButton";
			this.addImageButton.Size = new System.Drawing.Size(87, 29);
			this.addImageButton.TabIndex = 21;
			this.addImageButton.Text = "Add";
			this.addImageButton.UseVisualStyleBackColor = true;
			this.addImageButton.Click += new System.EventHandler(this.addImageButton_Click);
			// 
			// saveButton
			// 
			this.saveButton.Location = new System.Drawing.Point(790, 12);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(81, 29);
			this.saveButton.TabIndex = 20;
			this.saveButton.Text = "Save";
			this.saveButton.UseVisualStyleBackColor = true;
			this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
			// 
			// getImagesButton
			// 
			this.getImagesButton.Location = new System.Drawing.Point(605, 12);
			this.getImagesButton.Name = "getImagesButton";
			this.getImagesButton.Size = new System.Drawing.Size(86, 29);
			this.getImagesButton.TabIndex = 19;
			this.getImagesButton.Text = "Find";
			this.getImagesButton.UseVisualStyleBackColor = true;
			this.getImagesButton.Click += new System.EventHandler(this.getImagesButton_Click);
			// 
			// fileDialog
			// 
			this.fileDialog.FileName = "openFileDialog1";
			// 
			// flatTabControl1
			// 
			this.flatTabControl1.Controls.Add(this.imageEditTab);
			this.flatTabControl1.Controls.Add(this.annotationsTab);
			this.flatTabControl1.Controls.Add(this.tabPage1);
			this.flatTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flatTabControl1.Location = new System.Drawing.Point(0, 50);
			this.flatTabControl1.myBackColor = System.Drawing.SystemColors.Control;
			this.flatTabControl1.Name = "flatTabControl1";
			this.flatTabControl1.SelectedIndex = 0;
			this.flatTabControl1.Size = new System.Drawing.Size(880, 592);
			this.flatTabControl1.TabIndex = 10;
			// 
			// imageEditTab
			// 
			this.imageEditTab.Controls.Add(this.imageBrowserControl);
			this.imageEditTab.Controls.Add(this.splitter1);
			this.imageEditTab.Location = new System.Drawing.Point(4, 29);
			this.imageEditTab.Name = "imageEditTab";
			this.imageEditTab.Padding = new System.Windows.Forms.Padding(8);
			this.imageEditTab.Size = new System.Drawing.Size(872, 559);
			this.imageEditTab.TabIndex = 0;
			this.imageEditTab.Text = "Image Edit";
			this.imageEditTab.UseVisualStyleBackColor = true;
			// 
			// imageBrowserControl
			// 
			this.imageBrowserControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.imageBrowserControl.Images = null;
			this.imageBrowserControl.Location = new System.Drawing.Point(11, 8);
			this.imageBrowserControl.Name = "imageBrowserControl";
			this.imageBrowserControl.Size = new System.Drawing.Size(853, 543);
			this.imageBrowserControl.TabIndex = 11;
			// 
			// splitter1
			// 
			this.splitter1.Location = new System.Drawing.Point(8, 8);
			this.splitter1.Name = "splitter1";
			this.splitter1.Size = new System.Drawing.Size(3, 543);
			this.splitter1.TabIndex = 10;
			this.splitter1.TabStop = false;
			// 
			// annotationsTab
			// 
			this.annotationsTab.AutoScroll = true;
			this.annotationsTab.Controls.Add(this.annotationsInfoControl);
			this.annotationsTab.Location = new System.Drawing.Point(4, 29);
			this.annotationsTab.Name = "annotationsTab";
			this.annotationsTab.Padding = new System.Windows.Forms.Padding(3);
			this.annotationsTab.Size = new System.Drawing.Size(872, 559);
			this.annotationsTab.TabIndex = 1;
			this.annotationsTab.Text = "Annotations";
			this.annotationsTab.UseVisualStyleBackColor = true;
			// 
			// annotationsInfoControl
			// 
			this.annotationsInfoControl.Annotations = null;
			this.annotationsInfoControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.annotationsInfoControl.Location = new System.Drawing.Point(3, 3);
			this.annotationsInfoControl.Name = "annotationsInfoControl";
			this.annotationsInfoControl.Size = new System.Drawing.Size(866, 553);
			this.annotationsInfoControl.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.generateButton);
			this.tabPage1.Location = new System.Drawing.Point(4, 29);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(872, 559);
			this.tabPage1.TabIndex = 2;
			this.tabPage1.Text = "Generate Images";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// generateButton
			// 
			this.generateButton.Location = new System.Drawing.Point(24, 31);
			this.generateButton.Name = "generateButton";
			this.generateButton.Size = new System.Drawing.Size(126, 35);
			this.generateButton.TabIndex = 22;
			this.generateButton.Text = "Generate";
			this.generateButton.UseVisualStyleBackColor = true;
			this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
			// 
			// filterPanel
			// 
			this.filterPanel.Controls.Add(this.addImageButton);
			this.filterPanel.Controls.Add(this.label4);
			this.filterPanel.Controls.Add(this.saveButton);
			this.filterPanel.Controls.Add(this.sizeUpDown);
			this.filterPanel.Controls.Add(this.getImagesButton);
			this.filterPanel.Controls.Add(this.label3);
			this.filterPanel.Controls.Add(this.widthUpDown);
			this.filterPanel.Controls.Add(this.label2);
			this.filterPanel.Controls.Add(this.heightUpDown);
			this.filterPanel.Controls.Add(this.label1);
			this.filterPanel.Controls.Add(this.nameFilterTextBox);
			this.filterPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.filterPanel.Location = new System.Drawing.Point(0, 0);
			this.filterPanel.Name = "filterPanel";
			this.filterPanel.Size = new System.Drawing.Size(880, 50);
			this.filterPanel.TabIndex = 14;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(487, 18);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(35, 17);
			this.label4.TabIndex = 7;
			this.label4.Text = "Size";
			// 
			// sizeUpDown
			// 
			this.sizeUpDown.Location = new System.Drawing.Point(528, 16);
			this.sizeUpDown.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
			this.sizeUpDown.Name = "sizeUpDown";
			this.sizeUpDown.Size = new System.Drawing.Size(68, 22);
			this.sizeUpDown.TabIndex = 6;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(222, 18);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(44, 17);
			this.label3.TabIndex = 5;
			this.label3.Text = "Width";
			// 
			// widthUpDown
			// 
			this.widthUpDown.Location = new System.Drawing.Point(272, 16);
			this.widthUpDown.Maximum = new decimal(new int[] {
            4000,
            0,
            0,
            0});
			this.widthUpDown.Name = "widthUpDown";
			this.widthUpDown.Size = new System.Drawing.Size(68, 22);
			this.widthUpDown.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(353, 18);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(49, 17);
			this.label2.TabIndex = 3;
			this.label2.Text = "Height";
			// 
			// heightUpDown
			// 
			this.heightUpDown.Location = new System.Drawing.Point(408, 16);
			this.heightUpDown.Maximum = new decimal(new int[] {
            4000,
            0,
            0,
            0});
			this.heightUpDown.Name = "heightUpDown";
			this.heightUpDown.Size = new System.Drawing.Size(68, 22);
			this.heightUpDown.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(45, 17);
			this.label1.TabIndex = 1;
			this.label1.Text = "Name";
			// 
			// nameFilterTextBox
			// 
			this.nameFilterTextBox.Location = new System.Drawing.Point(63, 15);
			this.nameFilterTextBox.Name = "nameFilterTextBox";
			this.nameFilterTextBox.Size = new System.Drawing.Size(149, 22);
			this.nameFilterTextBox.TabIndex = 0;
			// 
			// ImagingPluginControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.flatTabControl1);
			this.Controls.Add(this.filterPanel);
			this.Name = "ImagingPluginControl";
			this.Size = new System.Drawing.Size(880, 642);
			this.flatTabControl1.ResumeLayout(false);
			this.imageEditTab.ResumeLayout(false);
			this.annotationsTab.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.filterPanel.ResumeLayout(false);
			this.filterPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.sizeUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.widthUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.heightUpDown)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.OpenFileDialog fileDialog;
		private System.Windows.Forms.Button getImagesButton;
		private FlatTabControl.FlatTabControl flatTabControl1;
		private System.Windows.Forms.TabPage annotationsTab;
		private AnnotationsInfoControl annotationsInfoControl;
		private System.Windows.Forms.Button saveButton;
		private System.Windows.Forms.Button addImageButton;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.Button generateButton;
		private System.Windows.Forms.TabPage imageEditTab;
		private System.Windows.Forms.Splitter splitter1;
		private System.Windows.Forms.Panel filterPanel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox nameFilterTextBox;
		private Controls.ImageBrowserControl imageBrowserControl;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.NumericUpDown widthUpDown;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown heightUpDown;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.NumericUpDown sizeUpDown;
	}
}
