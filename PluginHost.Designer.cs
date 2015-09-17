namespace Fester.MongoExplorer.App.Plugin {
	partial class PluginHost {
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
			this.pluginDescriptionLabel = new System.Windows.Forms.Label();
			this.pluginNameLabel = new System.Windows.Forms.Label();
			this.headerPanel = new System.Windows.Forms.Panel();
			this.pluginPanel = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.headerPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// pluginDescriptionLabel
			// 
			this.pluginDescriptionLabel.AutoSize = true;
			this.pluginDescriptionLabel.BackColor = System.Drawing.Color.Transparent;
			this.pluginDescriptionLabel.ForeColor = System.Drawing.Color.DarkViolet;
			this.pluginDescriptionLabel.Location = new System.Drawing.Point(14, 54);
			this.pluginDescriptionLabel.Name = "pluginDescriptionLabel";
			this.pluginDescriptionLabel.Size = new System.Drawing.Size(135, 17);
			this.pluginDescriptionLabel.TabIndex = 11;
			this.pluginDescriptionLabel.Text = "<plugin description>";
			// 
			// pluginNameLabel
			// 
			this.pluginNameLabel.AutoSize = true;
			this.pluginNameLabel.BackColor = System.Drawing.Color.Transparent;
			this.pluginNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.pluginNameLabel.Location = new System.Drawing.Point(12, 12);
			this.pluginNameLabel.Name = "pluginNameLabel";
			this.pluginNameLabel.Size = new System.Drawing.Size(193, 29);
			this.pluginNameLabel.TabIndex = 10;
			this.pluginNameLabel.Text = "<Plugin Name>";
			// 
			// headerPanel
			// 
			this.headerPanel.Controls.Add(this.panel1);
			this.headerPanel.Controls.Add(this.pluginDescriptionLabel);
			this.headerPanel.Controls.Add(this.pluginNameLabel);
			this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.headerPanel.Location = new System.Drawing.Point(0, 0);
			this.headerPanel.Name = "headerPanel";
			this.headerPanel.Size = new System.Drawing.Size(885, 86);
			this.headerPanel.TabIndex = 12;
			// 
			// pluginPanel
			// 
			this.pluginPanel.BackColor = System.Drawing.Color.Transparent;
			this.pluginPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pluginPanel.Location = new System.Drawing.Point(0, 86);
			this.pluginPanel.Name = "pluginPanel";
			this.pluginPanel.Size = new System.Drawing.Size(885, 431);
			this.pluginPanel.TabIndex = 13;
			this.pluginPanel.Tag = "";
			this.pluginPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.pluginPanel_Paint);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.panel1.Location = new System.Drawing.Point(0, 82);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(885, 4);
			this.panel1.TabIndex = 12;
			this.panel1.Tag = "fixed";
			// 
			// PluginHost
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.pluginPanel);
			this.Controls.Add(this.headerPanel);
			this.Name = "PluginHost";
			this.Size = new System.Drawing.Size(885, 517);
			this.headerPanel.ResumeLayout(false);
			this.headerPanel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label pluginDescriptionLabel;
		private System.Windows.Forms.Label pluginNameLabel;
		private System.Windows.Forms.Panel headerPanel;
		private System.Windows.Forms.Panel pluginPanel;
		private System.Windows.Forms.Panel panel1;
	}
}
