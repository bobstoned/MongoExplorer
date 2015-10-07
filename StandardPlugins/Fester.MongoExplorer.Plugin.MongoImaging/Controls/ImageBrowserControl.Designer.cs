namespace Fester.MongoExplorer.Plugin.MongoImaging.Controls {
	partial class ImageBrowserControl {
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
			this.imageListBox = new System.Windows.Forms.ListBox();
			this.imageBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.imageEditorFrame = new Blithe.Client.Controls.ImageEditor.ImageEditorFrame();
			this.splitter2 = new System.Windows.Forms.Splitter();
			this.panel1 = new System.Windows.Forms.Panel();
			this.imageInfoPanel = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.imageBindingSource)).BeginInit();
			this.panel1.SuspendLayout();
			this.imageInfoPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// imageListBox
			// 
			this.imageListBox.DataSource = this.imageBindingSource;
			this.imageListBox.DisplayMember = "Name";
			this.imageListBox.Dock = System.Windows.Forms.DockStyle.Left;
			this.imageListBox.FormattingEnabled = true;
			this.imageListBox.ItemHeight = 16;
			this.imageListBox.Location = new System.Drawing.Point(0, 0);
			this.imageListBox.Name = "imageListBox";
			this.imageListBox.Size = new System.Drawing.Size(161, 609);
			this.imageListBox.TabIndex = 14;
			this.imageListBox.ValueMember = "Id";
			// 
			// imageBindingSource
			// 
			this.imageBindingSource.DataSource = typeof(Fester.MongoExplorer.Plugin.MongoImaging.Collections.ImageDoc);
			this.imageBindingSource.PositionChanged += new System.EventHandler(this.imageBindingSource_PositionChanged);
			// 
			// imageEditorFrame
			// 
			this.imageEditorFrame.Dock = System.Windows.Forms.DockStyle.Fill;
			this.imageEditorFrame.Location = new System.Drawing.Point(0, 44);
			this.imageEditorFrame.Margin = new System.Windows.Forms.Padding(4);
			this.imageEditorFrame.Name = "imageEditorFrame";
			this.imageEditorFrame.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.imageEditorFrame.ShowToolOptions = true;
			this.imageEditorFrame.ShowTools = true;
			this.imageEditorFrame.ShowTopToolBar = true;
			this.imageEditorFrame.Size = new System.Drawing.Size(674, 565);
			this.imageEditorFrame.TabIndex = 15;
			// 
			// splitter2
			// 
			this.splitter2.Location = new System.Drawing.Point(161, 0);
			this.splitter2.Name = "splitter2";
			this.splitter2.Size = new System.Drawing.Size(13, 609);
			this.splitter2.TabIndex = 16;
			this.splitter2.TabStop = false;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.imageEditorFrame);
			this.panel1.Controls.Add(this.imageInfoPanel);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(174, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(674, 609);
			this.panel1.TabIndex = 17;
			// 
			// imageInfoPanel
			// 
			this.imageInfoPanel.Controls.Add(this.textBox3);
			this.imageInfoPanel.Controls.Add(this.label3);
			this.imageInfoPanel.Controls.Add(this.textBox2);
			this.imageInfoPanel.Controls.Add(this.label2);
			this.imageInfoPanel.Controls.Add(this.textBox1);
			this.imageInfoPanel.Controls.Add(this.label1);
			this.imageInfoPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.imageInfoPanel.Location = new System.Drawing.Point(0, 0);
			this.imageInfoPanel.Name = "imageInfoPanel";
			this.imageInfoPanel.Size = new System.Drawing.Size(674, 44);
			this.imageInfoPanel.TabIndex = 16;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(49, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Name:";
			// 
			// textBox1
			// 
			this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.imageBindingSource, "Name", true));
			this.textBox1.Location = new System.Drawing.Point(61, 7);
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new System.Drawing.Size(144, 22);
			this.textBox1.TabIndex = 1;
			// 
			// textBox2
			// 
			this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.imageBindingSource, "Size", true));
			this.textBox2.Location = new System.Drawing.Point(255, 7);
			this.textBox2.Name = "textBox2";
			this.textBox2.ReadOnly = true;
			this.textBox2.Size = new System.Drawing.Size(108, 22);
			this.textBox2.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(214, 10);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(35, 17);
			this.label2.TabIndex = 2;
			this.label2.Text = "Size";
			// 
			// textBox3
			// 
			this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.imageBindingSource, "DimensionsDisplayText", true));
			this.textBox3.Location = new System.Drawing.Point(469, 7);
			this.textBox3.Name = "textBox3";
			this.textBox3.ReadOnly = true;
			this.textBox3.Size = new System.Drawing.Size(164, 22);
			this.textBox3.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(382, 10);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(81, 17);
			this.label3.TabIndex = 4;
			this.label3.Text = "Dimensions";
			// 
			// ImageBrowserControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.splitter2);
			this.Controls.Add(this.imageListBox);
			this.Name = "ImageBrowserControl";
			this.Size = new System.Drawing.Size(848, 609);
			((System.ComponentModel.ISupportInitialize)(this.imageBindingSource)).EndInit();
			this.panel1.ResumeLayout(false);
			this.imageInfoPanel.ResumeLayout(false);
			this.imageInfoPanel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox imageListBox;
		private Blithe.Client.Controls.ImageEditor.ImageEditorFrame imageEditorFrame;
		private System.Windows.Forms.Splitter splitter2;
		private System.Windows.Forms.BindingSource imageBindingSource;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel imageInfoPanel;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
	}
}
