namespace Fester.MongoExplorer.Plugin.Collection {
	partial class CollectionPluginControl {
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
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.collectionView = new System.Windows.Forms.DataGridView();
			this.splitter1 = new System.Windows.Forms.Splitter();
			this.panel7 = new System.Windows.Forms.Panel();
			this.documentTextBox = new System.Windows.Forms.RichTextBox();
			this.panel5 = new System.Windows.Forms.Panel();
			this.label7 = new System.Windows.Forms.Label();
			this.maxDocsUpDown = new System.Windows.Forms.NumericUpDown();
			this.collectionNameTextBox = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.panel8 = new System.Windows.Forms.Panel();
			this.documentCountTextBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.collectionListBox = new System.Windows.Forms.ListBox();
			this.panel6 = new System.Windows.Forms.Panel();
			this.refreshButton = new System.Windows.Forms.Button();
			this.panel2.SuspendLayout();
			this.panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.collectionView)).BeginInit();
			this.panel7.SuspendLayout();
			this.panel5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.maxDocsUpDown)).BeginInit();
			this.panel8.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel6.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.panel4);
			this.panel2.Controls.Add(this.panel3);
			this.panel2.Controls.Add(this.panel1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(713, 603);
			this.panel2.TabIndex = 9;
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.Transparent;
			this.panel4.Controls.Add(this.collectionView);
			this.panel4.Controls.Add(this.splitter1);
			this.panel4.Controls.Add(this.panel7);
			this.panel4.Controls.Add(this.panel5);
			this.panel4.Controls.Add(this.panel8);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel4.Location = new System.Drawing.Point(272, 0);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(441, 603);
			this.panel4.TabIndex = 9;
			// 
			// collectionView
			// 
			this.collectionView.BackgroundColor = System.Drawing.Color.White;
			this.collectionView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.collectionView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.collectionView.Location = new System.Drawing.Point(0, 43);
			this.collectionView.Name = "collectionView";
			this.collectionView.RowTemplate.Height = 24;
			this.collectionView.Size = new System.Drawing.Size(441, 299);
			this.collectionView.TabIndex = 4;
			this.collectionView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.collectionView_CellClick);
			// 
			// splitter1
			// 
			this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.splitter1.Location = new System.Drawing.Point(0, 342);
			this.splitter1.Name = "splitter1";
			this.splitter1.Size = new System.Drawing.Size(441, 10);
			this.splitter1.TabIndex = 8;
			this.splitter1.TabStop = false;
			// 
			// panel7
			// 
			this.panel7.Controls.Add(this.documentTextBox);
			this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel7.Location = new System.Drawing.Point(0, 352);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(441, 211);
			this.panel7.TabIndex = 7;
			// 
			// documentTextBox
			// 
			this.documentTextBox.BackColor = System.Drawing.Color.White;
			this.documentTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.documentTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.documentTextBox.Location = new System.Drawing.Point(0, 0);
			this.documentTextBox.Name = "documentTextBox";
			this.documentTextBox.Size = new System.Drawing.Size(441, 211);
			this.documentTextBox.TabIndex = 4;
			this.documentTextBox.Text = "";
			// 
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.Color.Transparent;
			this.panel5.Controls.Add(this.label7);
			this.panel5.Controls.Add(this.maxDocsUpDown);
			this.panel5.Controls.Add(this.collectionNameTextBox);
			this.panel5.Controls.Add(this.label4);
			this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel5.Location = new System.Drawing.Point(0, 0);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(441, 43);
			this.panel5.TabIndex = 6;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(228, 15);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(67, 17);
			this.label7.TabIndex = 3;
			this.label7.Text = "Max docs";
			// 
			// maxDocsUpDown
			// 
			this.maxDocsUpDown.BackColor = System.Drawing.Color.LightSalmon;
			this.maxDocsUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.maxDocsUpDown.Location = new System.Drawing.Point(301, 13);
			this.maxDocsUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.maxDocsUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.maxDocsUpDown.Name = "maxDocsUpDown";
			this.maxDocsUpDown.Size = new System.Drawing.Size(91, 22);
			this.maxDocsUpDown.TabIndex = 2;
			this.maxDocsUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
			// 
			// collectionNameTextBox
			// 
			this.collectionNameTextBox.BackColor = System.Drawing.Color.LightSalmon;
			this.collectionNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.collectionNameTextBox.Location = new System.Drawing.Point(78, 12);
			this.collectionNameTextBox.Name = "collectionNameTextBox";
			this.collectionNameTextBox.ReadOnly = true;
			this.collectionNameTextBox.Size = new System.Drawing.Size(144, 22);
			this.collectionNameTextBox.TabIndex = 1;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(3, 15);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(69, 17);
			this.label4.TabIndex = 0;
			this.label4.Text = "Collection";
			// 
			// panel8
			// 
			this.panel8.BackColor = System.Drawing.Color.Transparent;
			this.panel8.Controls.Add(this.documentCountTextBox);
			this.panel8.Controls.Add(this.label3);
			this.panel8.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel8.Location = new System.Drawing.Point(0, 563);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(441, 40);
			this.panel8.TabIndex = 5;
			// 
			// documentCountTextBox
			// 
			this.documentCountTextBox.Location = new System.Drawing.Point(123, 9);
			this.documentCountTextBox.Name = "documentCountTextBox";
			this.documentCountTextBox.ReadOnly = true;
			this.documentCountTextBox.Size = new System.Drawing.Size(100, 22);
			this.documentCountTextBox.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(4, 12);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(113, 17);
			this.label3.TabIndex = 0;
			this.label3.Text = "Document Count";
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.Transparent;
			this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel3.Location = new System.Drawing.Point(262, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(10, 603);
			this.panel3.TabIndex = 8;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.collectionListBox);
			this.panel1.Controls.Add(this.panel6);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Padding = new System.Windows.Forms.Padding(8, 8, 0, 0);
			this.panel1.Size = new System.Drawing.Size(262, 603);
			this.panel1.TabIndex = 6;
			// 
			// collectionListBox
			// 
			this.collectionListBox.BackColor = System.Drawing.Color.White;
			this.collectionListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.collectionListBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.collectionListBox.FormattingEnabled = true;
			this.collectionListBox.IntegralHeight = false;
			this.collectionListBox.ItemHeight = 16;
			this.collectionListBox.Location = new System.Drawing.Point(8, 8);
			this.collectionListBox.Name = "collectionListBox";
			this.collectionListBox.Size = new System.Drawing.Size(254, 555);
			this.collectionListBox.TabIndex = 2;
			this.collectionListBox.SelectedIndexChanged += new System.EventHandler(this.collectionListBox_SelectedIndexChanged);
			// 
			// panel6
			// 
			this.panel6.BackColor = System.Drawing.Color.Transparent;
			this.panel6.Controls.Add(this.refreshButton);
			this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel6.Location = new System.Drawing.Point(8, 563);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(254, 40);
			this.panel6.TabIndex = 11;
			// 
			// refreshButton
			// 
			this.refreshButton.BackColor = System.Drawing.Color.LightSalmon;
			this.refreshButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
			this.refreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.refreshButton.Location = new System.Drawing.Point(0, 5);
			this.refreshButton.Name = "refreshButton";
			this.refreshButton.Size = new System.Drawing.Size(91, 31);
			this.refreshButton.TabIndex = 10;
			this.refreshButton.Text = "Refresh";
			this.refreshButton.UseVisualStyleBackColor = false;
			this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
			// 
			// CollectionPluginControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.panel2);
			this.Name = "CollectionPluginControl";
			this.Size = new System.Drawing.Size(713, 603);
			this.panel2.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.collectionView)).EndInit();
			this.panel7.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			this.panel5.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.maxDocsUpDown)).EndInit();
			this.panel8.ResumeLayout(false);
			this.panel8.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel6.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ListBox collectionListBox;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Button refreshButton;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.DataGridView collectionView;
		private System.Windows.Forms.Splitter splitter1;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.RichTextBox documentTextBox;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.NumericUpDown maxDocsUpDown;
		private System.Windows.Forms.TextBox collectionNameTextBox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.TextBox documentCountTextBox;
		private System.Windows.Forms.Label label3;

	}
}
