namespace Fester.MongoExplorer.Plugin.MongoImaging {
	partial class AnnotationsInfoControl {
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
			this.components = new System.ComponentModel.Container();
			this.annotationsListBox = new System.Windows.Forms.ListBox();
			this.imageBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
			this.label10 = new System.Windows.Forms.Label();
			this.numericUpDown9 = new System.Windows.Forms.NumericUpDown();
			this.label11 = new System.Windows.Forms.Label();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.label12 = new System.Windows.Forms.Label();
			this.pointsGrid = new System.Windows.Forms.DataGridView();
			this.xDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.yDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.pointBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.label17 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.mainPanel = new System.Windows.Forms.Panel();
			this.imageEditorFrame = new Blithe.Client.Controls.ImageEditor.ImageEditorFrame();
			this.rectControl = new Fester.MongoExplorer.Plugin.MongoImaging.Controls.RectControl();
			this.fillColorControl = new Fester.MongoExplorer.Plugin.MongoImaging.Controls.RGBColorControl();
			this.lineColorControl = new Fester.MongoExplorer.Plugin.MongoImaging.Controls.RGBColorControl();
			this.rectBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.addButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.imageBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pointsGrid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pointBindingSource)).BeginInit();
			this.mainPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.rectBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// annotationsListBox
			// 
			this.annotationsListBox.DataSource = this.imageBindingSource;
			this.annotationsListBox.DisplayMember = "AnnotationType";
			this.annotationsListBox.Dock = System.Windows.Forms.DockStyle.Left;
			this.annotationsListBox.FormattingEnabled = true;
			this.annotationsListBox.ItemHeight = 16;
			this.annotationsListBox.Location = new System.Drawing.Point(0, 0);
			this.annotationsListBox.Name = "annotationsListBox";
			this.annotationsListBox.Size = new System.Drawing.Size(165, 615);
			this.annotationsListBox.TabIndex = 0;
			// 
			// imageBindingSource
			// 
			this.imageBindingSource.DataSource = typeof(Fester.MongoExplorer.Plugin.MongoImaging.Collections.ImageDoc.Annotation);
			this.imageBindingSource.CurrentItemChanged += new System.EventHandler(this.imageBindingSource_CurrentItemChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(78, 17);
			this.label1.TabIndex = 1;
			this.label1.Text = "Page Index";
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.imageBindingSource, "PageIndex", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.numericUpDown1.Location = new System.Drawing.Point(121, 16);
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(62, 22);
			this.numericUpDown1.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 54);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(77, 17);
			this.label2.TabIndex = 3;
			this.label2.Text = "Fill Opacity";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 115);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(72, 17);
			this.label3.TabIndex = 4;
			this.label3.Text = "Line Color";
			// 
			// numericUpDown5
			// 
			this.numericUpDown5.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.imageBindingSource, "FillOpacity", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.numericUpDown5.Location = new System.Drawing.Point(121, 54);
			this.numericUpDown5.Name = "numericUpDown5";
			this.numericUpDown5.Size = new System.Drawing.Size(62, 22);
			this.numericUpDown5.TabIndex = 11;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(12, 184);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(62, 17);
			this.label10.TabIndex = 12;
			this.label10.Text = "Fill Color";
			// 
			// numericUpDown9
			// 
			this.numericUpDown9.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.imageBindingSource, "lineThickness", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.numericUpDown9.Location = new System.Drawing.Point(121, 233);
			this.numericUpDown9.Name = "numericUpDown9";
			this.numericUpDown9.Size = new System.Drawing.Size(62, 22);
			this.numericUpDown9.TabIndex = 20;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(12, 232);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(103, 17);
			this.label11.TabIndex = 19;
			this.label11.Text = "Line Thickness";
			// 
			// checkBox1
			// 
			this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBox1.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.imageBindingSource, "Filled", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.checkBox1.Location = new System.Drawing.Point(15, 294);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(124, 24);
			this.checkBox1.TabIndex = 21;
			this.checkBox1.Text = "Filled?";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(12, 308);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(37, 17);
			this.label12.TabIndex = 22;
			this.label12.Text = "Rect";
			// 
			// pointsGrid
			// 
			this.pointsGrid.AutoGenerateColumns = false;
			this.pointsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.pointsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.xDataGridViewTextBoxColumn,
            this.yDataGridViewTextBoxColumn});
			this.pointsGrid.DataSource = this.pointBindingSource;
			this.pointsGrid.Location = new System.Drawing.Point(431, 35);
			this.pointsGrid.Name = "pointsGrid";
			this.pointsGrid.RowTemplate.Height = 24;
			this.pointsGrid.Size = new System.Drawing.Size(322, 188);
			this.pointsGrid.TabIndex = 31;
			// 
			// xDataGridViewTextBoxColumn
			// 
			this.xDataGridViewTextBoxColumn.DataPropertyName = "X";
			this.xDataGridViewTextBoxColumn.HeaderText = "X";
			this.xDataGridViewTextBoxColumn.Name = "xDataGridViewTextBoxColumn";
			// 
			// yDataGridViewTextBoxColumn
			// 
			this.yDataGridViewTextBoxColumn.DataPropertyName = "Y";
			this.yDataGridViewTextBoxColumn.HeaderText = "Y";
			this.yDataGridViewTextBoxColumn.Name = "yDataGridViewTextBoxColumn";
			// 
			// pointBindingSource
			// 
			this.pointBindingSource.DataSource = typeof(Fester.MongoExplorer.Plugin.MongoImaging.Collections.ImageDoc.Point);
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Location = new System.Drawing.Point(427, 15);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(47, 17);
			this.label17.TabIndex = 32;
			this.label17.Text = "Points";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(431, 255);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(259, 22);
			this.textBox1.TabIndex = 33;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(470, 295);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(115, 22);
			this.textBox2.TabIndex = 36;
			// 
			// checkBox2
			// 
			this.checkBox2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBox2.Location = new System.Drawing.Point(169, 294);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(124, 24);
			this.checkBox2.TabIndex = 46;
			this.checkBox2.Text = "Has Line?";
			this.checkBox2.UseVisualStyleBackColor = true;
			// 
			// mainPanel
			// 
			this.mainPanel.Controls.Add(this.addButton);
			this.mainPanel.Controls.Add(this.imageEditorFrame);
			this.mainPanel.Controls.Add(this.rectControl);
			this.mainPanel.Controls.Add(this.fillColorControl);
			this.mainPanel.Controls.Add(this.lineColorControl);
			this.mainPanel.Controls.Add(this.label1);
			this.mainPanel.Controls.Add(this.label2);
			this.mainPanel.Controls.Add(this.label3);
			this.mainPanel.Controls.Add(this.pointsGrid);
			this.mainPanel.Controls.Add(this.label10);
			this.mainPanel.Controls.Add(this.label11);
			this.mainPanel.Controls.Add(this.label12);
			this.mainPanel.Controls.Add(this.label17);
			this.mainPanel.Controls.Add(this.numericUpDown1);
			this.mainPanel.Controls.Add(this.numericUpDown5);
			this.mainPanel.Controls.Add(this.numericUpDown9);
			this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainPanel.Location = new System.Drawing.Point(165, 0);
			this.mainPanel.Name = "mainPanel";
			this.mainPanel.Size = new System.Drawing.Size(801, 615);
			this.mainPanel.TabIndex = 47;
			// 
			// imageEditorFrame
			// 
			this.imageEditorFrame.Location = new System.Drawing.Point(431, 247);
			this.imageEditorFrame.Margin = new System.Windows.Forms.Padding(4);
			this.imageEditorFrame.Name = "imageEditorFrame";
			this.imageEditorFrame.Size = new System.Drawing.Size(322, 269);
			this.imageEditorFrame.TabIndex = 42;
			// 
			// rectControl
			// 
			this.rectControl.BoundingRect = null;
			this.rectControl.Location = new System.Drawing.Point(117, 277);
			this.rectControl.Name = "rectControl";
			this.rectControl.Size = new System.Drawing.Size(283, 66);
			this.rectControl.TabIndex = 41;
			// 
			// fillColorControl
			// 
			this.fillColorControl.ColorValue = null;
			this.fillColorControl.Location = new System.Drawing.Point(117, 158);
			this.fillColorControl.Name = "fillColorControl";
			this.fillColorControl.Size = new System.Drawing.Size(291, 55);
			this.fillColorControl.TabIndex = 40;
			// 
			// lineColorControl
			// 
			this.lineColorControl.ColorValue = null;
			this.lineColorControl.Location = new System.Drawing.Point(117, 89);
			this.lineColorControl.Name = "lineColorControl";
			this.lineColorControl.Size = new System.Drawing.Size(291, 63);
			this.lineColorControl.TabIndex = 39;
			// 
			// rectBindingSource
			// 
			this.rectBindingSource.DataSource = typeof(Fester.MongoExplorer.Plugin.MongoImaging.Collections.ImageDoc.BoundingRect);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(151, 452);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(100, 50);
			this.pictureBox1.TabIndex = 51;
			this.pictureBox1.TabStop = false;
			// 
			// addButton
			// 
			this.addButton.Location = new System.Drawing.Point(15, 355);
			this.addButton.Name = "addButton";
			this.addButton.Size = new System.Drawing.Size(75, 33);
			this.addButton.TabIndex = 43;
			this.addButton.Text = "Add";
			this.addButton.UseVisualStyleBackColor = true;
			this.addButton.Click += new System.EventHandler(this.addButton_Click);
			// 
			// AnnotationsInfoControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.mainPanel);
			this.Controls.Add(this.annotationsListBox);
			this.Name = "AnnotationsInfoControl";
			this.Size = new System.Drawing.Size(966, 615);
			((System.ComponentModel.ISupportInitialize)(this.imageBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown9)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pointsGrid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pointBindingSource)).EndInit();
			this.mainPanel.ResumeLayout(false);
			this.mainPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.rectBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox annotationsListBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.NumericUpDown numericUpDown5;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.NumericUpDown numericUpDown9;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.BindingSource imageBindingSource;
		private System.Windows.Forms.DataGridView pointsGrid;
		private System.Windows.Forms.DataGridViewTextBoxColumn xDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn yDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource pointBindingSource;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.Panel mainPanel;
		private System.Windows.Forms.BindingSource rectBindingSource;
		private System.Windows.Forms.PictureBox pictureBox1;
		private Controls.RGBColorControl fillColorControl;
		private Controls.RGBColorControl lineColorControl;
		private Controls.RectControl rectControl;
		private Blithe.Client.Controls.ImageEditor.ImageEditorFrame imageEditorFrame;
		private System.Windows.Forms.Button addButton;
	}
}
