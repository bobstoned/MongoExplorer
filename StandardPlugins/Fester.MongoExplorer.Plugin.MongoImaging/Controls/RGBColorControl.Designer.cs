namespace Fester.MongoExplorer.Plugin.MongoImaging.Controls {
	partial class RGBColorControl {
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
			this.lineRedUpDown = new System.Windows.Forms.NumericUpDown();
			this.colorBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.lineGreenUpDown = new System.Windows.Forms.NumericUpDown();
			this.lineBlueUpDown = new System.Windows.Forms.NumericUpDown();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.colorPanel = new System.Windows.Forms.Panel();
			this.colorDialog = new System.Windows.Forms.ColorDialog();
			((System.ComponentModel.ISupportInitialize)(this.lineRedUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.colorBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lineGreenUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lineBlueUpDown)).BeginInit();
			this.SuspendLayout();
			// 
			// lineRedUpDown
			// 
			this.lineRedUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.colorBindingSource, "R", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.lineRedUpDown.Location = new System.Drawing.Point(6, 29);
			this.lineRedUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.lineRedUpDown.Name = "lineRedUpDown";
			this.lineRedUpDown.Size = new System.Drawing.Size(62, 22);
			this.lineRedUpDown.TabIndex = 11;
			// 
			// colorBindingSource
			// 
			this.colorBindingSource.DataSource = typeof(Fester.MongoExplorer.Plugin.MongoImaging.Collections.ImageDoc.ColorType);
			this.colorBindingSource.CurrentItemChanged += new System.EventHandler(this.colorBindingSource_CurrentItemChanged);
			this.colorBindingSource.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.colorBindingSource_ListChanged);
			// 
			// lineGreenUpDown
			// 
			this.lineGreenUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.colorBindingSource, "G", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.lineGreenUpDown.Location = new System.Drawing.Point(74, 29);
			this.lineGreenUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.lineGreenUpDown.Name = "lineGreenUpDown";
			this.lineGreenUpDown.Size = new System.Drawing.Size(62, 22);
			this.lineGreenUpDown.TabIndex = 12;
			// 
			// lineBlueUpDown
			// 
			this.lineBlueUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.colorBindingSource, "B", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.lineBlueUpDown.Location = new System.Drawing.Point(142, 29);
			this.lineBlueUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.lineBlueUpDown.Name = "lineBlueUpDown";
			this.lineBlueUpDown.Size = new System.Drawing.Size(62, 22);
			this.lineBlueUpDown.TabIndex = 13;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(3, 9);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(34, 17);
			this.label4.TabIndex = 14;
			this.label4.Text = "Red";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(71, 9);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(48, 17);
			this.label5.TabIndex = 15;
			this.label5.Text = "Green";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(139, 9);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(36, 17);
			this.label6.TabIndex = 16;
			this.label6.Text = "Blue";
			// 
			// colorPanel
			// 
			this.colorPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(148)))), ((int)(((byte)(148)))));
			this.colorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.colorPanel.ForeColor = System.Drawing.SystemColors.ButtonShadow;
			this.colorPanel.Location = new System.Drawing.Point(213, 9);
			this.colorPanel.Name = "colorPanel";
			this.colorPanel.Size = new System.Drawing.Size(44, 42);
			this.colorPanel.TabIndex = 17;
			this.colorPanel.Tag = "fixed";
			this.colorPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.colorPanel_Paint);
			this.colorPanel.DoubleClick += new System.EventHandler(this.colorPanel_DoubleClick);
			// 
			// RGBColorControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.colorPanel);
			this.Controls.Add(this.lineRedUpDown);
			this.Controls.Add(this.lineGreenUpDown);
			this.Controls.Add(this.lineBlueUpDown);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label6);
			this.Name = "RGBColorControl";
			this.Size = new System.Drawing.Size(288, 62);
			((System.ComponentModel.ISupportInitialize)(this.lineRedUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.colorBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lineGreenUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lineBlueUpDown)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.NumericUpDown lineRedUpDown;
		private System.Windows.Forms.NumericUpDown lineGreenUpDown;
		private System.Windows.Forms.NumericUpDown lineBlueUpDown;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.BindingSource colorBindingSource;
		private System.Windows.Forms.Panel colorPanel;
		private System.Windows.Forms.ColorDialog colorDialog;
	}
}
