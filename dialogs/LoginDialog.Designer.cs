namespace Fester.MongoExplorer.App {
	partial class LoginDialog {
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
			this.label1 = new System.Windows.Forms.Label();
			this.serverTextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.connectButton = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.portUpDown = new System.Windows.Forms.NumericUpDown();
			this.databaseComboBox = new System.Windows.Forms.ComboBox();
			this.applyButton = new System.Windows.Forms.Button();
			this.connectedLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.portUpDown)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(15, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(50, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Server";
			// 
			// serverTextBox
			// 
			this.serverTextBox.Location = new System.Drawing.Point(18, 38);
			this.serverTextBox.Name = "serverTextBox";
			this.serverTextBox.Size = new System.Drawing.Size(176, 22);
			this.serverTextBox.TabIndex = 1;
			this.serverTextBox.Text = "mongodb://localhost";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(15, 98);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(69, 17);
			this.label2.TabIndex = 2;
			this.label2.Text = "Database";
			// 
			// connectButton
			// 
			this.connectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.connectButton.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.connectButton.Enabled = false;
			this.connectButton.Location = new System.Drawing.Point(150, 159);
			this.connectButton.Name = "connectButton";
			this.connectButton.Size = new System.Drawing.Size(93, 30);
			this.connectButton.TabIndex = 5;
			this.connectButton.Text = "Connect";
			this.connectButton.UseVisualStyleBackColor = true;
			this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
			// 
			// button2
			// 
			this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.button2.Location = new System.Drawing.Point(249, 159);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(78, 30);
			this.button2.TabIndex = 6;
			this.button2.Text = "Cancel";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(197, 19);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(34, 17);
			this.label3.TabIndex = 7;
			this.label3.Text = "Port";
			// 
			// portUpDown
			// 
			this.portUpDown.Location = new System.Drawing.Point(200, 38);
			this.portUpDown.Maximum = new decimal(new int[] {
            30000,
            0,
            0,
            0});
			this.portUpDown.Name = "portUpDown";
			this.portUpDown.Size = new System.Drawing.Size(75, 22);
			this.portUpDown.TabIndex = 8;
			this.portUpDown.Value = new decimal(new int[] {
            27017,
            0,
            0,
            0});
			// 
			// databaseComboBox
			// 
			this.databaseComboBox.Enabled = false;
			this.databaseComboBox.FormattingEnabled = true;
			this.databaseComboBox.Location = new System.Drawing.Point(18, 118);
			this.databaseComboBox.Name = "databaseComboBox";
			this.databaseComboBox.Size = new System.Drawing.Size(309, 24);
			this.databaseComboBox.TabIndex = 9;
			this.databaseComboBox.TextChanged += new System.EventHandler(this.databaseComboBox_TextChanged);
			// 
			// applyButton
			// 
			this.applyButton.Location = new System.Drawing.Point(281, 36);
			this.applyButton.Name = "applyButton";
			this.applyButton.Size = new System.Drawing.Size(46, 26);
			this.applyButton.TabIndex = 10;
			this.applyButton.Text = "go";
			this.applyButton.UseVisualStyleBackColor = true;
			this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
			// 
			// connectedLabel
			// 
			this.connectedLabel.AutoSize = true;
			this.connectedLabel.Location = new System.Drawing.Point(15, 63);
			this.connectedLabel.Name = "connectedLabel";
			this.connectedLabel.Size = new System.Drawing.Size(76, 17);
			this.connectedLabel.TabIndex = 11;
			this.connectedLabel.Text = "Connected";
			this.connectedLabel.Visible = false;
			// 
			// LoginDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(346, 211);
			this.Controls.Add(this.connectedLabel);
			this.Controls.Add(this.applyButton);
			this.Controls.Add(this.databaseComboBox);
			this.Controls.Add(this.portUpDown);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.connectButton);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.serverTextBox);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "LoginDialog";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Mongo DB Login";
			((System.ComponentModel.ISupportInitialize)(this.portUpDown)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox serverTextBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button connectButton;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.NumericUpDown portUpDown;
		private System.Windows.Forms.ComboBox databaseComboBox;
		private System.Windows.Forms.Button applyButton;
		private System.Windows.Forms.Label connectedLabel;
	}
}