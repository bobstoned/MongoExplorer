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
			this.components = new System.ComponentModel.Container();
			this.removeButton = new System.Windows.Forms.Button();
			this.resultsGrid = new System.Windows.Forms.DataGridView();
			this.documentTextBox = new System.Windows.Forms.RichTextBox();
			this.scoreUpDown = new System.Windows.Forms.NumericUpDown();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.mainTabControl = new FlatTabControl.FlatTabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label7 = new System.Windows.Forms.Label();
			this.countTextBox = new System.Windows.Forms.TextBox();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.kittensTextBox = new System.Windows.Forms.TextBox();
			this.removedTextBox = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.getImagesButton = new System.Windows.Forms.Button();
			this.progressTimer = new System.Windows.Forms.Timer(this.components);
			this.cancelButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.resultsGrid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.scoreUpDown)).BeginInit();
			this.panel1.SuspendLayout();
			this.mainTabControl.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.panel2.SuspendLayout();
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
			this.resultsGrid.Dock = System.Windows.Forms.DockStyle.Top;
			this.resultsGrid.Location = new System.Drawing.Point(3, 85);
			this.resultsGrid.Name = "resultsGrid";
			this.resultsGrid.RowTemplate.Height = 24;
			this.resultsGrid.Size = new System.Drawing.Size(714, 131);
			this.resultsGrid.TabIndex = 2;
			this.resultsGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.resultsGrid_CellClick);
			// 
			// documentTextBox
			// 
			this.documentTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.documentTextBox.Location = new System.Drawing.Point(3, 216);
			this.documentTextBox.Name = "documentTextBox";
			this.documentTextBox.Size = new System.Drawing.Size(714, 390);
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
			this.panel1.Location = new System.Drawing.Point(3, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(714, 82);
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
			// mainTabControl
			// 
			this.mainTabControl.Controls.Add(this.tabPage2);
			this.mainTabControl.Controls.Add(this.tabPage1);
			this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainTabControl.Location = new System.Drawing.Point(0, 0);
			this.mainTabControl.myBackColor = System.Drawing.SystemColors.Control;
			this.mainTabControl.Name = "mainTabControl";
			this.mainTabControl.SelectedIndex = 0;
			this.mainTabControl.Size = new System.Drawing.Size(728, 642);
			this.mainTabControl.TabIndex = 8;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.documentTextBox);
			this.tabPage1.Controls.Add(this.resultsGrid);
			this.tabPage1.Controls.Add(this.panel1);
			this.tabPage1.Location = new System.Drawing.Point(4, 29);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(720, 609);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Remove Lowest";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.panel2);
			this.tabPage2.Location = new System.Drawing.Point(4, 29);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(720, 609);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Exam Q7";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.cancelButton);
			this.panel2.Controls.Add(this.label7);
			this.panel2.Controls.Add(this.countTextBox);
			this.panel2.Controls.Add(this.checkBox1);
			this.panel2.Controls.Add(this.kittensTextBox);
			this.panel2.Controls.Add(this.removedTextBox);
			this.panel2.Controls.Add(this.label6);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.getImagesButton);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(3, 3);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(714, 252);
			this.panel2.TabIndex = 8;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(16, 109);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(45, 17);
			this.label7.TabIndex = 15;
			this.label7.Text = "Count";
			// 
			// countTextBox
			// 
			this.countTextBox.Location = new System.Drawing.Point(145, 106);
			this.countTextBox.Name = "countTextBox";
			this.countTextBox.ReadOnly = true;
			this.countTextBox.Size = new System.Drawing.Size(123, 22);
			this.countTextBox.TabIndex = 14;
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new System.Drawing.Point(19, 64);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(151, 21);
			this.checkBox1.TabIndex = 13;
			this.checkBox1.Text = "Physically remove?";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// kittensTextBox
			// 
			this.kittensTextBox.Location = new System.Drawing.Point(145, 167);
			this.kittensTextBox.Name = "kittensTextBox";
			this.kittensTextBox.ReadOnly = true;
			this.kittensTextBox.Size = new System.Drawing.Size(123, 22);
			this.kittensTextBox.TabIndex = 12;
			// 
			// removedTextBox
			// 
			this.removedTextBox.Location = new System.Drawing.Point(145, 136);
			this.removedTextBox.Name = "removedTextBox";
			this.removedTextBox.ReadOnly = true;
			this.removedTextBox.Size = new System.Drawing.Size(123, 22);
			this.removedTextBox.TabIndex = 11;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(17, 170);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(115, 17);
			this.label6.TabIndex = 10;
			this.label6.Text = "Removed Kittens";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(17, 139);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(68, 17);
			this.label1.TabIndex = 9;
			this.label1.Text = "Removed";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.ForeColor = System.Drawing.Color.DarkViolet;
			this.label5.Location = new System.Drawing.Point(248, 26);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(165, 17);
			this.label5.TabIndex = 8;
			this.label5.Text = "Question 7 on the exam !";
			// 
			// getImagesButton
			// 
			this.getImagesButton.Location = new System.Drawing.Point(19, 21);
			this.getImagesButton.Name = "getImagesButton";
			this.getImagesButton.Size = new System.Drawing.Size(208, 27);
			this.getImagesButton.TabIndex = 1;
			this.getImagesButton.Text = "Remove orphaned images";
			this.getImagesButton.UseVisualStyleBackColor = true;
			this.getImagesButton.Click += new System.EventHandler(this.getImagesButton_Click);
			// 
			// progressTimer
			// 
			this.progressTimer.Interval = 500;
			this.progressTimer.Tick += new System.EventHandler(this.progressTimer_Tick);
			// 
			// cancelButton
			// 
			this.cancelButton.Enabled = false;
			this.cancelButton.Location = new System.Drawing.Point(20, 206);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(112, 27);
			this.cancelButton.TabIndex = 17;
			this.cancelButton.Text = "Cancel";
			this.cancelButton.UseVisualStyleBackColor = true;
			this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
			// 
			// MongoUniPluginControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.mainTabControl);
			this.Name = "MongoUniPluginControl";
			this.Size = new System.Drawing.Size(728, 642);
			((System.ComponentModel.ISupportInitialize)(this.resultsGrid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.scoreUpDown)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.mainTabControl.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
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
		private FlatTabControl.FlatTabControl mainTabControl;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.TextBox kittensTextBox;
		private System.Windows.Forms.TextBox removedTextBox;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button getImagesButton;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox countTextBox;
		private System.Windows.Forms.Timer progressTimer;
		private System.Windows.Forms.Button cancelButton;
	}
}
