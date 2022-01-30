namespace Mbb
{
	partial class GetSerialNumberForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GetSerialNumberForm));
			this.messgeLabel = new System.Windows.Forms.Label();
			this.inputSerialNumberLabel = new System.Windows.Forms.Label();
			this.inputSerialNumberTextBox = new System.Windows.Forms.TextBox();
			this.addKeyButton = new System.Windows.Forms.Button();
			this.exitButton = new System.Windows.Forms.Button();
			this.notificationTimer = new System.Windows.Forms.Timer(this.components);
			this.activeCodeLabel = new System.Windows.Forms.Label();
			this.activeCodeTextBox = new System.Windows.Forms.TextBox();
			this.copyButton = new System.Windows.Forms.Button();
			this.pasteButton = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.checkPictureBox = new System.Windows.Forms.PictureBox();
			this.minimizedButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.checkPictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// messgeLabel
			// 
			this.messgeLabel.AutoSize = true;
			this.messgeLabel.Font = new System.Drawing.Font("Tahoma", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.messgeLabel.ForeColor = System.Drawing.Color.Tomato;
			this.messgeLabel.Location = new System.Drawing.Point(69, 9);
			this.messgeLabel.Name = "messgeLabel";
			this.messgeLabel.Size = new System.Drawing.Size(310, 41);
			this.messgeLabel.TabIndex = 6;
			this.messgeLabel.Text = "Invalid license Key!";
			// 
			// inputSerialNumberLabel
			// 
			this.inputSerialNumberLabel.AutoSize = true;
			this.inputSerialNumberLabel.Location = new System.Drawing.Point(33, 115);
			this.inputSerialNumberLabel.Name = "inputSerialNumberLabel";
			this.inputSerialNumberLabel.Size = new System.Drawing.Size(140, 13);
			this.inputSerialNumberLabel.TabIndex = 3;
			this.inputSerialNumberLabel.Text = "Please Enter Serial Number:";
			// 
			// inputSerialNumberTextBox
			// 
			this.inputSerialNumberTextBox.Location = new System.Drawing.Point(36, 131);
			this.inputSerialNumberTextBox.Name = "inputSerialNumberTextBox";
			this.inputSerialNumberTextBox.Size = new System.Drawing.Size(349, 21);
			this.inputSerialNumberTextBox.TabIndex = 0;
			this.inputSerialNumberTextBox.TextChanged += new System.EventHandler(this.InputSerialNumberTextBox_TextChanged);
			// 
			// addKeyButton
			// 
			this.addKeyButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue;
			this.addKeyButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.addKeyButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.addKeyButton.Image = ((System.Drawing.Image)(resources.GetObject("addKeyButton.Image")));
			this.addKeyButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.addKeyButton.Location = new System.Drawing.Point(75, 166);
			this.addKeyButton.Name = "addKeyButton";
			this.addKeyButton.Size = new System.Drawing.Size(130, 35);
			this.addKeyButton.TabIndex = 1;
			this.addKeyButton.Text = "&Add Key";
			this.addKeyButton.UseVisualStyleBackColor = true;
			this.addKeyButton.Click += new System.EventHandler(this.AddKeyButton_Click);
			// 
			// exitButton
			// 
			this.exitButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue;
			this.exitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.exitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.exitButton.Image = ((System.Drawing.Image)(resources.GetObject("exitButton.Image")));
			this.exitButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.exitButton.Location = new System.Drawing.Point(244, 166);
			this.exitButton.Name = "exitButton";
			this.exitButton.Size = new System.Drawing.Size(130, 35);
			this.exitButton.TabIndex = 2;
			this.exitButton.Text = "&Exit";
			this.exitButton.UseVisualStyleBackColor = true;
			this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
			// 
			// notificationTimer
			// 
			this.notificationTimer.Interval = 850;
			this.notificationTimer.Tick += new System.EventHandler(this.Timer1_Tick);
			// 
			// activeCodeLabel
			// 
			this.activeCodeLabel.AutoSize = true;
			this.activeCodeLabel.Location = new System.Drawing.Point(33, 68);
			this.activeCodeLabel.Name = "activeCodeLabel";
			this.activeCodeLabel.Size = new System.Drawing.Size(69, 13);
			this.activeCodeLabel.TabIndex = 4;
			this.activeCodeLabel.Text = "Active Code:";
			// 
			// activeCodeTextBox
			// 
			this.activeCodeTextBox.Location = new System.Drawing.Point(36, 84);
			this.activeCodeTextBox.Name = "activeCodeTextBox";
			this.activeCodeTextBox.ReadOnly = true;
			this.activeCodeTextBox.Size = new System.Drawing.Size(349, 21);
			this.activeCodeTextBox.TabIndex = 7;
			this.activeCodeTextBox.TextChanged += new System.EventHandler(this.ActiveCodeTextBox_TextChanged);
			// 
			// copyButton
			// 
			this.copyButton.BackColor = System.Drawing.Color.Transparent;
			this.copyButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("copyButton.BackgroundImage")));
			this.copyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.copyButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.copyButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.copyButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.copyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.copyButton.Location = new System.Drawing.Point(391, 82);
			this.copyButton.Name = "copyButton";
			this.copyButton.Size = new System.Drawing.Size(25, 25);
			this.copyButton.TabIndex = 8;
			this.copyButton.UseVisualStyleBackColor = false;
			this.copyButton.Click += new System.EventHandler(this.CopyButton_Click);
			// 
			// pasteButton
			// 
			this.pasteButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pasteButton.BackgroundImage")));
			this.pasteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pasteButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.pasteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.pasteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.pasteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.pasteButton.Location = new System.Drawing.Point(391, 129);
			this.pasteButton.Name = "pasteButton";
			this.pasteButton.Size = new System.Drawing.Size(25, 25);
			this.pasteButton.TabIndex = 9;
			this.pasteButton.UseVisualStyleBackColor = true;
			this.pasteButton.Click += new System.EventHandler(this.PasteButton_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.SlateBlue;
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(448, 5);
			this.panel1.TabIndex = 10;
			// 
			// checkPictureBox
			// 
			this.checkPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("checkPictureBox.Image")));
			this.checkPictureBox.Location = new System.Drawing.Point(10, 131);
			this.checkPictureBox.Name = "checkPictureBox";
			this.checkPictureBox.Size = new System.Drawing.Size(20, 20);
			this.checkPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.checkPictureBox.TabIndex = 11;
			this.checkPictureBox.TabStop = false;
			this.checkPictureBox.Visible = false;
			// 
			// minimizedButton
			// 
			this.minimizedButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minimizedButton.BackgroundImage")));
			this.minimizedButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.minimizedButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.minimizedButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.minimizedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.minimizedButton.Location = new System.Drawing.Point(422, 11);
			this.minimizedButton.Name = "minimizedButton";
			this.minimizedButton.Size = new System.Drawing.Size(20, 20);
			this.minimizedButton.TabIndex = 14;
			this.minimizedButton.UseVisualStyleBackColor = true;
			this.minimizedButton.Click += new System.EventHandler(this.MinimizedButton_Click);
			// 
			// GetSerialNumberForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(448, 213);
			this.ControlBox = false;
			this.Controls.Add(this.minimizedButton);
			this.Controls.Add(this.checkPictureBox);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.pasteButton);
			this.Controls.Add(this.copyButton);
			this.Controls.Add(this.activeCodeTextBox);
			this.Controls.Add(this.activeCodeLabel);
			this.Controls.Add(this.exitButton);
			this.Controls.Add(this.addKeyButton);
			this.Controls.Add(this.inputSerialNumberTextBox);
			this.Controls.Add(this.inputSerialNumberLabel);
			this.Controls.Add(this.messgeLabel);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "GetSerialNumberForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Load += new System.EventHandler(this.GetSerialNumberForm_Load);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GetSerialNumberForm_MouseDown);
			((System.ComponentModel.ISupportInitialize)(this.checkPictureBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label messgeLabel;
		private System.Windows.Forms.Label inputSerialNumberLabel;
		private System.Windows.Forms.TextBox inputSerialNumberTextBox;
		private System.Windows.Forms.Button addKeyButton;
		private System.Windows.Forms.Button exitButton;
		private System.Windows.Forms.Timer notificationTimer;
		private System.Windows.Forms.Label activeCodeLabel;
		private System.Windows.Forms.Button copyButton;
		private System.Windows.Forms.Button pasteButton;
		private System.Windows.Forms.Panel panel1;
		public System.Windows.Forms.TextBox activeCodeTextBox;
		private System.Windows.Forms.PictureBox checkPictureBox;
		private System.Windows.Forms.Button minimizedButton;
	}
}