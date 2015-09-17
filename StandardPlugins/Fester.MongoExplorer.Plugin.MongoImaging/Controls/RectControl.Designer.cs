namespace Fester.MongoExplorer.Plugin.MongoImaging.Controls {
	partial class RectControl {
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
			this.label16 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.numericUpDown13 = new System.Windows.Forms.NumericUpDown();
			this.numericUpDown12 = new System.Windows.Forms.NumericUpDown();
			this.label14 = new System.Windows.Forms.Label();
			this.numericUpDown11 = new System.Windows.Forms.NumericUpDown();
			this.numericUpDown10 = new System.Windows.Forms.NumericUpDown();
			this.label13 = new System.Windows.Forms.Label();
			this.rectBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.pointBindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown13)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown12)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown11)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown10)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.rectBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pointBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(208, 9);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(49, 17);
			this.label16.TabIndex = 38;
			this.label16.Text = "Height";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(140, 9);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(44, 17);
			this.label15.TabIndex = 37;
			this.label15.Text = "Width";
			// 
			// numericUpDown13
			// 
			this.numericUpDown13.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.rectBindingSource, "Height", true, System.Windows.Forms.DataSourceUpdateMode.Never));
			this.numericUpDown13.Location = new System.Drawing.Point(211, 29);
			this.numericUpDown13.Name = "numericUpDown13";
			this.numericUpDown13.Size = new System.Drawing.Size(62, 22);
			this.numericUpDown13.TabIndex = 36;
			// 
			// numericUpDown12
			// 
			this.numericUpDown12.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.rectBindingSource, "Width", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.numericUpDown12.Location = new System.Drawing.Point(143, 29);
			this.numericUpDown12.Name = "numericUpDown12";
			this.numericUpDown12.Size = new System.Drawing.Size(62, 22);
			this.numericUpDown12.TabIndex = 35;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(73, 9);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(17, 17);
			this.label14.TabIndex = 34;
			this.label14.Text = "Y";
			// 
			// numericUpDown11
			// 
			this.numericUpDown11.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.pointBindingSource, "Y", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.numericUpDown11.Location = new System.Drawing.Point(75, 29);
			this.numericUpDown11.Name = "numericUpDown11";
			this.numericUpDown11.Size = new System.Drawing.Size(62, 22);
			this.numericUpDown11.TabIndex = 33;
			// 
			// numericUpDown10
			// 
			this.numericUpDown10.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.pointBindingSource, "X", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.numericUpDown10.Location = new System.Drawing.Point(7, 29);
			this.numericUpDown10.Name = "numericUpDown10";
			this.numericUpDown10.Size = new System.Drawing.Size(62, 22);
			this.numericUpDown10.TabIndex = 31;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(5, 9);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(17, 17);
			this.label13.TabIndex = 32;
			this.label13.Text = "X";
			// 
			// rectBindingSource
			// 
			this.rectBindingSource.DataSource = typeof(Fester.MongoExplorer.Plugin.MongoImaging.Collections.ImageDoc.BoundingRect);
			// 
			// pointBindingSource
			// 
			this.pointBindingSource.DataSource = typeof(Fester.MongoExplorer.Plugin.MongoImaging.Collections.ImageDoc.Point);
			// 
			// RectControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.label16);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.numericUpDown13);
			this.Controls.Add(this.numericUpDown12);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.numericUpDown11);
			this.Controls.Add(this.numericUpDown10);
			this.Controls.Add(this.label13);
			this.Name = "RectControl";
			this.Size = new System.Drawing.Size(283, 66);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown13)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown12)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown11)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown10)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.rectBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pointBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.NumericUpDown numericUpDown13;
		private System.Windows.Forms.NumericUpDown numericUpDown12;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.NumericUpDown numericUpDown11;
		private System.Windows.Forms.NumericUpDown numericUpDown10;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.BindingSource rectBindingSource;
		private System.Windows.Forms.BindingSource pointBindingSource;
	}
}
