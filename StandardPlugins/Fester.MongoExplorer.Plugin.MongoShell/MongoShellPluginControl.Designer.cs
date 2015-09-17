namespace Fester.MongoExplorer.Plugin.MongoShell {
	partial class MongoShellPluginControl {
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
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.commandResultsText = new System.Windows.Forms.RichTextBox();
			this.queryTextBox = new System.Windows.Forms.RichTextBox();
			this.executeButton = new System.Windows.Forms.Button();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.label9);
			this.panel2.Controls.Add(this.label8);
			this.panel2.Controls.Add(this.commandResultsText);
			this.panel2.Controls.Add(this.queryTextBox);
			this.panel2.Controls.Add(this.executeButton);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(713, 603);
			this.panel2.TabIndex = 9;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.ForeColor = System.Drawing.Color.DarkViolet;
			this.label9.Location = new System.Drawing.Point(12, 18);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(71, 17);
			this.label9.TabIndex = 13;
			this.label9.Text = "Command";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.ForeColor = System.Drawing.Color.DarkViolet;
			this.label8.Location = new System.Drawing.Point(12, 261);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(55, 17);
			this.label8.TabIndex = 12;
			this.label8.Text = "Results";
			// 
			// commandResultsText
			// 
			this.commandResultsText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.commandResultsText.Location = new System.Drawing.Point(15, 281);
			this.commandResultsText.Name = "commandResultsText";
			this.commandResultsText.Size = new System.Drawing.Size(690, 302);
			this.commandResultsText.TabIndex = 11;
			this.commandResultsText.Text = "";
			// 
			// queryTextBox
			// 
			this.queryTextBox.AcceptsTab = true;
			this.queryTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.queryTextBox.Location = new System.Drawing.Point(15, 38);
			this.queryTextBox.Name = "queryTextBox";
			this.queryTextBox.Size = new System.Drawing.Size(690, 164);
			this.queryTextBox.TabIndex = 9;
			this.queryTextBox.Text = "function() { \nreturn db.posts.find(\n  { tags : \"swing\" },\n  {author: true, tags:t" +
    "rue}\n).limit(1).sort({date: -1}).pretty().toArray();\n}";
			// 
			// executeButton
			// 
			this.executeButton.Location = new System.Drawing.Point(12, 208);
			this.executeButton.Name = "executeButton";
			this.executeButton.Size = new System.Drawing.Size(91, 31);
			this.executeButton.TabIndex = 10;
			this.executeButton.Text = "Execute";
			this.executeButton.UseVisualStyleBackColor = true;
			this.executeButton.Click += new System.EventHandler(this.executeButton_Click);
			// 
			// MongoShellPluginControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.panel2);
			this.Name = "MongoShellPluginControl";
			this.Size = new System.Drawing.Size(713, 603);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.RichTextBox commandResultsText;
		private System.Windows.Forms.RichTextBox queryTextBox;
		private System.Windows.Forms.Button executeButton;

	}
}
