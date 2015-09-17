namespace Fester.MongoExplorer.Plugin.LiberatoDatabaseUpgrade {
	partial class LiberateratoDatabaseUpgradePluginControl {
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
			this.removeButton = new System.Windows.Forms.Button();
			this.documentTextBox = new System.Windows.Forms.RichTextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// removeButton
			// 
			this.removeButton.Location = new System.Drawing.Point(21, 75);
			this.removeButton.Name = "removeButton";
			this.removeButton.Size = new System.Drawing.Size(139, 27);
			this.removeButton.TabIndex = 1;
			this.removeButton.Text = "Apply Upgrade";
			this.removeButton.UseVisualStyleBackColor = true;
			// 
			// documentTextBox
			// 
			this.documentTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.documentTextBox.Location = new System.Drawing.Point(0, 219);
			this.documentTextBox.Name = "documentTextBox";
			this.documentTextBox.Size = new System.Drawing.Size(728, 423);
			this.documentTextBox.TabIndex = 5;
			this.documentTextBox.Text = "";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label11);
			this.panel1.Controls.Add(this.label10);
			this.panel1.Controls.Add(this.label9);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.comboBox1);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.removeButton);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(728, 219);
			this.panel1.TabIndex = 7;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(24, 188);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(88, 17);
			this.label11.TabIndex = 20;
			this.label11.Text = "Progress log";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.BackColor = System.Drawing.Color.Transparent;
			this.label10.ForeColor = System.Drawing.Color.DarkViolet;
			this.label10.Location = new System.Drawing.Point(25, 118);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(148, 17);
			this.label10.TabIndex = 19;
			this.label10.Text = "Applying script 1 of 23";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.BackColor = System.Drawing.Color.Transparent;
			this.label9.ForeColor = System.Drawing.Color.DarkViolet;
			this.label9.Location = new System.Drawing.Point(126, 146);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(211, 17);
			this.label9.TabIndex = 18;
			this.label9.Text = "001 DDL Prescribing Collections";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(25, 146);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(99, 17);
			this.label8.TabIndex = 17;
			this.label8.Text = "Current Script:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(178, 11);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(64, 17);
			this.label6.TabIndex = 16;
			this.label6.Text = "Contents";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.ForeColor = System.Drawing.Color.DarkViolet;
			this.label7.Location = new System.Drawing.Point(178, 31);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(129, 17);
			this.label7.TabIndex = 15;
			this.label7.Text = "Prescribing Module";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(18, 11);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(106, 17);
			this.label2.TabIndex = 11;
			this.label2.Text = "Select Upgrade";
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "2.1",
            "2.2",
            "3.0",
            "4.0"});
			this.comboBox1.Location = new System.Drawing.Point(21, 31);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(139, 24);
			this.comboBox1.TabIndex = 10;
			this.comboBox1.Text = "3.0";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.SystemColors.Control;
			this.label3.ForeColor = System.Drawing.Color.DarkViolet;
			this.label3.Location = new System.Drawing.Point(18, 178);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(0, 17);
			this.label3.TabIndex = 8;
			// 
			// LiberateratoDatabaseUpgradePluginControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.documentTextBox);
			this.Controls.Add(this.panel1);
			this.Name = "LiberateratoDatabaseUpgradePluginControl";
			this.Size = new System.Drawing.Size(728, 642);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button removeButton;
		private System.Windows.Forms.RichTextBox documentTextBox;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label11;
	}
}
