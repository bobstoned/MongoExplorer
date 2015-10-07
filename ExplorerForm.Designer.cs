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
			this.closeButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.serverTextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.databaseTextBox = new System.Windows.Forms.TextBox();
			this.connectButton = new System.Windows.Forms.Button();
			this.panel8 = new System.Windows.Forms.Panel();
			this.panel9 = new System.Windows.Forms.Panel();
			this.queryTabControl = new FlatTabControl.FlatTabControl();
			this.pluginsTabPage = new System.Windows.Forms.TabPage();
			this.pluginListBox = new System.Windows.Forms.ListBox();
			this.pluginHost = new Fester.MongoExplorer.App.Plugin.PluginHost();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel8.SuspendLayout();
			this.panel9.SuspendLayout();
			this.queryTabControl.SuspendLayout();
			this.pluginsTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
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
			this.label1.Location = new System.Drawing.Point(288, 22);
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
			this.serverTextBox.Location = new System.Drawing.Point(344, 20);
			this.serverTextBox.Name = "serverTextBox";
			this.serverTextBox.ReadOnly = true;
			this.serverTextBox.Size = new System.Drawing.Size(228, 22);
			this.serverTextBox.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(269, 54);
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
			this.databaseTextBox.Location = new System.Drawing.Point(344, 52);
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
			this.connectButton.Location = new System.Drawing.Point(158, 31);
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
			this.panel8.Size = new System.Drawing.Size(903, 90);
			this.panel8.TabIndex = 12;
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
			// queryTabControl
			// 
			this.queryTabControl.Controls.Add(this.pluginsTabPage);
			this.queryTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.queryTabControl.Location = new System.Drawing.Point(8, 90);
			this.queryTabControl.myBackColor = System.Drawing.SystemColors.Control;
			this.queryTabControl.Name = "queryTabControl";
			this.queryTabControl.SelectedIndex = 0;
			this.queryTabControl.Size = new System.Drawing.Size(903, 502);
			this.queryTabControl.TabIndex = 13;
			// 
			// pluginsTabPage
			// 
			this.pluginsTabPage.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.pluginsTabPage.Controls.Add(this.pluginHost);
			this.pluginsTabPage.Controls.Add(this.pluginListBox);
			this.pluginsTabPage.Location = new System.Drawing.Point(4, 29);
			this.pluginsTabPage.Name = "pluginsTabPage";
			this.pluginsTabPage.Padding = new System.Windows.Forms.Padding(8, 8, 3, 3);
			this.pluginsTabPage.Size = new System.Drawing.Size(895, 469);
			this.pluginsTabPage.TabIndex = 4;
			this.pluginsTabPage.Text = "Modules";
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
			this.pluginListBox.Size = new System.Drawing.Size(275, 458);
			this.pluginListBox.TabIndex = 1;
			this.pluginListBox.SelectedIndexChanged += new System.EventHandler(this.pluginListBox_SelectedIndexChanged);
			// 
			// pluginHost
			// 
			this.pluginHost.BackColor = System.Drawing.Color.Transparent;
			this.pluginHost.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pluginHost.Location = new System.Drawing.Point(283, 8);
			this.pluginHost.Name = "pluginHost";
			this.pluginHost.Plugin = null;
			this.pluginHost.Size = new System.Drawing.Size(609, 458);
			this.pluginHost.TabIndex = 11;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::Fester.MongoExplorer.App.Properties.Resources.logo_red_horns1;
			this.pictureBox1.Location = new System.Drawing.Point(4, 2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(97, 82);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
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
			this.panel8.ResumeLayout(false);
			this.panel8.PerformLayout();
			this.panel9.ResumeLayout(false);
			this.queryTabControl.ResumeLayout(false);
			this.pluginsTabPage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
		private FlatTabControl.FlatTabControl queryTabControl;
		private System.Windows.Forms.Panel panel9;
	}
}

