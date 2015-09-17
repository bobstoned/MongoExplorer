namespace Fester.MongoExplorer.Plugin.MongoUniversity {
	partial class MongoUniPluginControl {
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
			this.resultsGrid = new System.Windows.Forms.DataGridView();
			this.documentTextBox = new System.Windows.Forms.RichTextBox();
			this.scoreUpDown = new System.Windows.Forms.NumericUpDown();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.resultsGrid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.scoreUpDown)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// removeButton
			// 
			this.removeButton.Location = new System.Drawing.Point(12, 13);
			this.removeButton.Name = "removeButton";
			this.removeButton.Size = new System.Drawing.Size(174, 27);
			this.removeButton.TabIndex = 1;
			this.removeButton.Text = "Remove lowest score";
			this.removeButton.UseVisualStyleBackColor = true;
			this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
			// 
			// resultsGrid
			// 
			this.resultsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.resultsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
			this.resultsGrid.Location = new System.Drawing.Point(0, 82);
			this.resultsGrid.Name = "resultsGrid";
			this.resultsGrid.RowTemplate.Height = 24;
			this.resultsGrid.Size = new System.Drawing.Size(728, 341);
			this.resultsGrid.TabIndex = 2;
			this.resultsGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.resultsGrid_CellClick);
			// 
			// documentTextBox
			// 
			this.documentTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.documentTextBox.Location = new System.Drawing.Point(0, 423);
			this.documentTextBox.Name = "documentTextBox";
			this.documentTextBox.Size = new System.Drawing.Size(728, 219);
			this.documentTextBox.TabIndex = 5;
			this.documentTextBox.Text = "";
			// 
			// scoreUpDown
			// 
			this.scoreUpDown.Location = new System.Drawing.Point(391, 16);
			this.scoreUpDown.Name = "scoreUpDown";
			this.scoreUpDown.Size = new System.Drawing.Size(74, 22);
			this.scoreUpDown.TabIndex = 6;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.scoreUpDown);
			this.panel1.Controls.Add(this.removeButton);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(728, 82);
			this.panel1.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.ForeColor = System.Drawing.Color.MediumVioletRed;
			this.label4.Location = new System.Drawing.Point(483, 18);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(163, 17);
			this.label4.TabIndex = 9;
			this.label4.Text = "(homework only though!)";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.ForeColor = System.Drawing.Color.DarkViolet;
			this.label3.Location = new System.Drawing.Point(21, 52);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(521, 17);
			this.label3.TabIndex = 8;
			this.label3.Text = "NOTE: If you keep running this it will eventually remove all their homework score" +
    "s!";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Location = new System.Drawing.Point(192, 18);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(191, 17);
			this.label2.TabIndex = 7;
			this.label2.Text = "for students above this score";
			// 
			// MongoUniPluginControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.resultsGrid);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.documentTextBox);
			this.Name = "MongoUniPluginControl";
			this.Size = new System.Drawing.Size(728, 642);
			((System.ComponentModel.ISupportInitialize)(this.resultsGrid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.scoreUpDown)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button removeButton;
		private System.Windows.Forms.DataGridView resultsGrid;
		private System.Windows.Forms.RichTextBox documentTextBox;
		private System.Windows.Forms.NumericUpDown scoreUpDown;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
	}
}
