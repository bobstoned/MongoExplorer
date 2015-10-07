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
			this.components = new System.ComponentModel.Container();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.queryTextBox = new System.Windows.Forms.RichTextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.commandResultsText = new System.Windows.Forms.RichTextBox();
			this.executeButton = new System.Windows.Forms.Button();
			this.panel3 = new System.Windows.Forms.Panel();
			this.scriptListBox = new System.Windows.Forms.ListBox();
			this.scriptBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.panel2.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.scriptBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.panel1);
			this.panel2.Controls.Add(this.panel3);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1017, 603);
			this.panel2.TabIndex = 9;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.queryTextBox);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.label9);
			this.panel1.Controls.Add(this.commandResultsText);
			this.panel1.Controls.Add(this.executeButton);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(187, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(830, 603);
			this.panel1.TabIndex = 14;
			// 
			// queryTextBox
			// 
			this.queryTextBox.AcceptsTab = true;
			this.queryTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.queryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.scriptBindingSource, "Content", true));
			this.queryTextBox.Location = new System.Drawing.Point(6, 37);
			this.queryTextBox.Name = "queryTextBox";
			this.queryTextBox.Size = new System.Drawing.Size(818, 164);
			this.queryTextBox.TabIndex = 9;
			this.queryTextBox.Text = "function() { \nreturn db.posts.find(\n  { tags : \"swing\" },\n  {author: true, tags:t" +
    "rue}\n).limit(1).sort({date: -1}).pretty().toArray();\n}";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.ForeColor = System.Drawing.Color.DarkViolet;
			this.label8.Location = new System.Drawing.Point(6, 256);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(55, 17);
			this.label8.TabIndex = 12;
			this.label8.Text = "Results";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.ForeColor = System.Drawing.Color.DarkViolet;
			this.label9.Location = new System.Drawing.Point(3, 17);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(71, 17);
			this.label9.TabIndex = 13;
			this.label9.Text = "Command";
			// 
			// commandResultsText
			// 
			this.commandResultsText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.commandResultsText.Location = new System.Drawing.Point(6, 276);
			this.commandResultsText.Name = "commandResultsText";
			this.commandResultsText.Size = new System.Drawing.Size(818, 319);
			this.commandResultsText.TabIndex = 11;
			this.commandResultsText.Text = "";
			// 
			// executeButton
			// 
			this.executeButton.Location = new System.Drawing.Point(6, 207);
			this.executeButton.Name = "executeButton";
			this.executeButton.Size = new System.Drawing.Size(91, 31);
			this.executeButton.TabIndex = 10;
			this.executeButton.Text = "Execute";
			this.executeButton.UseVisualStyleBackColor = true;
			this.executeButton.Click += new System.EventHandler(this.executeButton_Click);
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.scriptListBox);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.Name = "panel3";
			this.panel3.Padding = new System.Windows.Forms.Padding(8, 8, 0, 8);
			this.panel3.Size = new System.Drawing.Size(187, 603);
			this.panel3.TabIndex = 15;
			// 
			// scriptListBox
			// 
			this.scriptListBox.DataSource = this.scriptBindingSource;
			this.scriptListBox.DisplayMember = "Name";
			this.scriptListBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.scriptListBox.FormattingEnabled = true;
			this.scriptListBox.ItemHeight = 16;
			this.scriptListBox.Location = new System.Drawing.Point(8, 8);
			this.scriptListBox.Name = "scriptListBox";
			this.scriptListBox.Size = new System.Drawing.Size(179, 587);
			this.scriptListBox.TabIndex = 0;
			this.scriptListBox.SelectedIndexChanged += new System.EventHandler(this.scriptListBox_SelectedIndexChanged);
			// 
			// scriptBindingSource
			// 
			this.scriptBindingSource.DataSource = typeof(Fester.MongoExplorer.Plugin.MongoShell.MongoScriptFile);
			// 
			// MongoShellPluginControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.panel2);
			this.Name = "MongoShellPluginControl";
			this.Size = new System.Drawing.Size(1017, 603);
			this.panel2.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.scriptBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.RichTextBox commandResultsText;
		private System.Windows.Forms.RichTextBox queryTextBox;
		private System.Windows.Forms.Button executeButton;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.ListBox scriptListBox;
		private System.Windows.Forms.BindingSource scriptBindingSource;

	}
}
