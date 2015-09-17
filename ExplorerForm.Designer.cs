namespace Fester.MongoExplorer.App {
	partial class ExplorerForm {
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.pluginsTabPage = new System.Windows.Forms.TabPage();
			this.pluginListBox = new System.Windows.Forms.ListBox();
			this.closeButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.serverTextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.databaseTextBox = new System.Windows.Forms.TextBox();
			this.connectButton = new System.Windows.Forms.Button();
			this.panel8 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.collectionTabPage = new System.Windows.Forms.TabPage();
			this.panel2 = new System.Windows.Forms.Panel();
			this.collectionView = new System.Windows.Forms.DataGridView();
			this.splitter1 = new System.Windows.Forms.Splitter();
			this.panel7 = new System.Windows.Forms.Panel();
			this.documentTextBox = new System.Windows.Forms.RichTextBox();
			this.panel5 = new System.Windows.Forms.Panel();
			this.label7 = new System.Windows.Forms.Label();
			this.maxDocsUpDown = new System.Windows.Forms.NumericUpDown();
			this.collectionNameTextBox = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.documentCountTextBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.collectionListBox = new System.Windows.Forms.ListBox();
			this.panel6 = new System.Windows.Forms.Panel();
			this.refreshButton = new System.Windows.Forms.Button();
			this.queryTabControl = new FlatTabControl.FlatTabControl();
			this.panel9 = new System.Windows.Forms.Panel();
			this.pluginHost = new Fester.MongoExplorer.App.Plugin.PluginHost();
			this.pluginsTabPage.SuspendLayout();
			this.panel8.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.collectionTabPage.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.collectionView)).BeginInit();
			this.panel7.SuspendLayout();
			this.panel5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.maxDocsUpDown)).BeginInit();
			this.panel4.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel6.SuspendLayout();
			this.queryTabControl.SuspendLayout();
			this.panel9.SuspendLayout();
			this.SuspendLayout();
			// 
			// pluginsTabPage
			// 
			this.pluginsTabPage.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.pluginsTabPage.Controls.Add(this.pluginHost);
			this.pluginsTabPage.Controls.Add(this.pluginListBox);
			this.pluginsTabPage.Location = new System.Drawing.Point(4, 29);
			this.pluginsTabPage.Name = "pluginsTabPage";
			this.pluginsTabPage.Padding = new System.Windows.Forms.Padding(8, 8, 3, 3);
			this.pluginsTabPage.Size = new System.Drawing.Size(895, 450);
			this.pluginsTabPage.TabIndex = 4;
			this.pluginsTabPage.Text = "Plugins";
			// 
			// pluginListBox
			// 
			this.pluginListBox.BackColor = System.Drawing.Color.White;
			this.pluginListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.pluginListBox.Dock = System.Windows.Forms.DockStyle.Left;
			this.pluginListBox.FormattingEnabled = true;
			this.pluginListBox.ItemHeight = 16;
			this.pluginListBox.Location = new System.Drawing.Point(8, 8);
			this.pluginListBox.Name = "pluginListBox";
			this.pluginListBox.Size = new System.Drawing.Size(275, 439);
			this.pluginListBox.TabIndex = 1;
			this.pluginListBox.SelectedIndexChanged += new System.EventHandler(this.pluginListBox_SelectedIndexChanged);
			// 
			// closeButton
			// 
			this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.closeButton.BackColor = System.Drawing.Color.LightSalmon;
			this.closeButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
			this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.closeButton.Location = new System.Drawing.Point(810, 11);
			this.closeButton.Name = "closeButton";
			this.closeButton.Size = new System.Drawing.Size(91, 31);
			this.closeButton.TabIndex = 9;
			this.closeButton.Text = "&Close";
			this.closeButton.UseVisualStyleBackColor = false;
			this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(273, 64);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(50, 17);
			this.label1.TabIndex = 1;
			this.label1.Text = "Server";
			// 
			// serverTextBox
			// 
			this.serverTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.serverTextBox.BackColor = System.Drawing.Color.LightSalmon;
			this.serverTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.serverTextBox.Location = new System.Drawing.Point(329, 64);
			this.serverTextBox.Name = "serverTextBox";
			this.serverTextBox.ReadOnly = true;
			this.serverTextBox.Size = new System.Drawing.Size(228, 22);
			this.serverTextBox.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(563, 64);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(69, 17);
			this.label2.TabIndex = 7;
			this.label2.Text = "Database";
			// 
			// databaseTextBox
			// 
			this.databaseTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.databaseTextBox.BackColor = System.Drawing.Color.LightSalmon;
			this.databaseTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.databaseTextBox.Location = new System.Drawing.Point(638, 64);
			this.databaseTextBox.Name = "databaseTextBox";
			this.databaseTextBox.ReadOnly = true;
			this.databaseTextBox.Size = new System.Drawing.Size(228, 22);
			this.databaseTextBox.TabIndex = 8;
			// 
			// connectButton
			// 
			this.connectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.connectButton.BackColor = System.Drawing.Color.LightSalmon;
			this.connectButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
			this.connectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.connectButton.Location = new System.Drawing.Point(163, 57);
			this.connectButton.Name = "connectButton";
			this.connectButton.Size = new System.Drawing.Size(91, 31);
			this.connectButton.TabIndex = 11;
			this.connectButton.Text = "Connect";
			this.connectButton.UseVisualStyleBackColor = false;
			this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
			// 
			// panel8
			// 
			this.panel8.BackColor = System.Drawing.Color.Transparent;
			this.panel8.Controls.Add(this.pictureBox1);
			this.panel8.Controls.Add(this.connectButton);
			this.panel8.Controls.Add(this.label1);
			this.panel8.Controls.Add(this.databaseTextBox);
			this.panel8.Controls.Add(this.serverTextBox);
			this.panel8.Controls.Add(this.label2);
			this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel8.Location = new System.Drawing.Point(8, 0);
			this.panel8.Name = "panel8";
			this.panel8.Padding = new System.Windows.Forms.Padding(0, 0, 0, 8);
			this.panel8.Size = new System.Drawing.Size(903, 109);
			this.panel8.TabIndex = 12;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
			this.pictureBox1.Image = global::Fester.MongoExplorer.App.Properties.Resources.mongo_explorer_logo;
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(135, 101);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// collectionTabPage
			// 
			this.collectionTabPage.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.collectionTabPage.Controls.Add(this.panel2);
			this.collectionTabPage.Controls.Add(this.panel3);
			this.collectionTabPage.Controls.Add(this.panel1);
			this.collectionTabPage.Location = new System.Drawing.Point(4, 29);
			this.collectionTabPage.Name = "collectionTabPage";
			this.collectionTabPage.Padding = new System.Windows.Forms.Padding(6);
			this.collectionTabPage.Size = new System.Drawing.Size(895, 450);
			this.collectionTabPage.TabIndex = 2;
			this.collectionTabPage.Text = "Collections";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Transparent;
			this.panel2.Controls.Add(this.collectionView);
			this.panel2.Controls.Add(this.splitter1);
			this.panel2.Controls.Add(this.panel7);
			this.panel2.Controls.Add(this.panel5);
			this.panel2.Controls.Add(this.panel4);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(278, 6);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(611, 438);
			this.panel2.TabIndex = 6;
			// 
			// collectionView
			// 
			this.collectionView.BackgroundColor = System.Drawing.Color.White;
			this.collectionView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.collectionView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.collectionView.Location = new System.Drawing.Point(0, 43);
			this.collectionView.Name = "collectionView";
			this.collectionView.RowTemplate.Height = 24;
			this.collectionView.Size = new System.Drawing.Size(611, 134);
			this.collectionView.TabIndex = 4;
			this.collectionView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.collectionView_CellClick);
			// 
			// splitter1
			// 
			this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.splitter1.Location = new System.Drawing.Point(0, 177);
			this.splitter1.Name = "splitter1";
			this.splitter1.Size = new System.Drawing.Size(611, 10);
			this.splitter1.TabIndex = 8;
			this.splitter1.TabStop = false;
			// 
			// panel7
			// 
			this.panel7.Controls.Add(this.documentTextBox);
			this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel7.Location = new System.Drawing.Point(0, 187);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(611, 211);
			this.panel7.TabIndex = 7;
			// 
			// documentTextBox
			// 
			this.documentTextBox.BackColor = System.Drawing.Color.White;
			this.documentTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.documentTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.documentTextBox.Location = new System.Drawing.Point(0, 0);
			this.documentTextBox.Name = "documentTextBox";
			this.documentTextBox.Size = new System.Drawing.Size(611, 211);
			this.documentTextBox.TabIndex = 4;
			this.documentTextBox.Text = "function() { \nreturn db.images.count(); \n}";
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
			this.panel5.Size = new System.Drawing.Size(611, 43);
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
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.Transparent;
			this.panel4.Controls.Add(this.documentCountTextBox);
			this.panel4.Controls.Add(this.label3);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel4.Location = new System.Drawing.Point(0, 398);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(611, 40);
			this.panel4.TabIndex = 5;
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
			this.panel3.Location = new System.Drawing.Point(268, 6);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(10, 438);
			this.panel3.TabIndex = 7;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.collectionListBox);
			this.panel1.Controls.Add(this.panel6);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(6, 6);
			this.panel1.Name = "panel1";
			this.panel1.Padding = new System.Windows.Forms.Padding(8, 8, 0, 0);
			this.panel1.Size = new System.Drawing.Size(262, 438);
			this.panel1.TabIndex = 5;
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
			this.collectionListBox.Size = new System.Drawing.Size(254, 390);
			this.collectionListBox.TabIndex = 2;
			this.collectionListBox.SelectedIndexChanged += new System.EventHandler(this.collectionListBox_SelectedIndexChanged);
			// 
			// panel6
			// 
			this.panel6.BackColor = System.Drawing.Color.Transparent;
			this.panel6.Controls.Add(this.refreshButton);
			this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel6.Location = new System.Drawing.Point(8, 398);
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
			// queryTabControl
			// 
			this.queryTabControl.Controls.Add(this.collectionTabPage);
			this.queryTabControl.Controls.Add(this.pluginsTabPage);
			this.queryTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.queryTabControl.Location = new System.Drawing.Point(8, 109);
			this.queryTabControl.myBackColor = System.Drawing.SystemColors.Control;
			this.queryTabControl.Name = "queryTabControl";
			this.queryTabControl.SelectedIndex = 0;
			this.queryTabControl.Size = new System.Drawing.Size(903, 483);
			this.queryTabControl.TabIndex = 13;
			// 
			// panel9
			// 
			this.panel9.BackColor = System.Drawing.Color.Transparent;
			this.panel9.Controls.Add(this.closeButton);
			this.panel9.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel9.Location = new System.Drawing.Point(8, 592);
			this.panel9.Name = "panel9";
			this.panel9.Size = new System.Drawing.Size(903, 56);
			this.panel9.TabIndex = 14;
			// 
			// pluginHost
			// 
			this.pluginHost.BackColor = System.Drawing.Color.Transparent;
			this.pluginHost.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pluginHost.Location = new System.Drawing.Point(283, 8);
			this.pluginHost.Name = "pluginHost";
			this.pluginHost.Plugin = null;
			this.pluginHost.Size = new System.Drawing.Size(609, 439);
			this.pluginHost.TabIndex = 11;
			// 
			// ExplorerForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(919, 648);
			this.Controls.Add(this.queryTabControl);
			this.Controls.Add(this.panel8);
			this.Controls.Add(this.panel9);
			this.Name = "ExplorerForm";
			this.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
			this.Text = "Mongo Explorer";
			this.pluginsTabPage.ResumeLayout(false);
			this.panel8.ResumeLayout(false);
			this.panel8.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.collectionTabPage.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.collectionView)).EndInit();
			this.panel7.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			this.panel5.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.maxDocsUpDown)).EndInit();
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel6.ResumeLayout(false);
			this.queryTabControl.ResumeLayout(false);
			this.panel9.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button closeButton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox serverTextBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox databaseTextBox;
		private System.Windows.Forms.TabPage pluginsTabPage;
		private System.Windows.Forms.ListBox pluginListBox;
		private System.Windows.Forms.Button connectButton;
		private Plugin.PluginHost pluginHost;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TabPage collectionTabPage;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.DataGridView collectionView;
		private System.Windows.Forms.Splitter splitter1;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.RichTextBox documentTextBox;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.NumericUpDown maxDocsUpDown;
		private System.Windows.Forms.TextBox collectionNameTextBox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.TextBox documentCountTextBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ListBox collectionListBox;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Button refreshButton;
		private FlatTabControl.FlatTabControl queryTabControl;
		private System.Windows.Forms.Panel panel9;
	}
}

