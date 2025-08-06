namespace TokenGenerator
{
	partial class AccessTokenForm
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
			audTextbox = new TextBox();
			label8 = new Label();
			button4 = new Button();
			button3 = new Button();
			result2TextBox = new TextBox();
			button2 = new Button();
			certificatePathTextBox = new TextBox();
			label7 = new Label();
			privateKeyPathTextBox = new TextBox();
			label6 = new Label();
			azpTextbox = new TextBox();
			label5 = new Label();
			endpointTextBox = new TextBox();
			label4 = new Label();
			textBox1 = new TextBox();
			label1 = new Label();
			SuspendLayout();
			// 
			// audTextbox
			// 
			audTextbox.Location = new Point(242, 126);
			audTextbox.Name = "audTextbox";
			audTextbox.Size = new Size(799, 31);
			audTextbox.TabIndex = 27;
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Location = new Point(183, 129);
			label8.Name = "label8";
			label8.Size = new Size(42, 25);
			label8.TabIndex = 26;
			label8.Text = "aud";
			// 
			// button4
			// 
			button4.Location = new Point(972, 230);
			button4.Name = "button4";
			button4.Size = new Size(69, 34);
			button4.TabIndex = 25;
			button4.Text = "...";
			button4.UseVisualStyleBackColor = true;
			button4.Click += button4_Click;
			// 
			// button3
			// 
			button3.Location = new Point(972, 177);
			button3.Name = "button3";
			button3.Size = new Size(69, 34);
			button3.TabIndex = 24;
			button3.Text = "...";
			button3.UseVisualStyleBackColor = true;
			button3.Click += button3_Click;
			// 
			// result2TextBox
			// 
			result2TextBox.Location = new Point(39, 337);
			result2TextBox.Multiline = true;
			result2TextBox.Name = "result2TextBox";
			result2TextBox.Size = new Size(1002, 366);
			result2TextBox.TabIndex = 23;
			// 
			// button2
			// 
			button2.Location = new Point(39, 287);
			button2.Name = "button2";
			button2.Size = new Size(112, 34);
			button2.TabIndex = 22;
			button2.Text = "Generate Token";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// certificatePathTextBox
			// 
			certificatePathTextBox.Location = new Point(242, 232);
			certificatePathTextBox.Name = "certificatePathTextBox";
			certificatePathTextBox.Size = new Size(724, 31);
			certificatePathTextBox.TabIndex = 21;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(39, 235);
			label7.Name = "label7";
			label7.Size = new Size(186, 25);
			label7.TabIndex = 20;
			label7.Text = "Certificate file location";
			// 
			// privateKeyPathTextBox
			// 
			privateKeyPathTextBox.Location = new Point(242, 179);
			privateKeyPathTextBox.Name = "privateKeyPathTextBox";
			privateKeyPathTextBox.Size = new Size(724, 31);
			privateKeyPathTextBox.TabIndex = 19;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(28, 182);
			label6.Name = "label6";
			label6.Size = new Size(197, 25);
			label6.TabIndex = 18;
			label6.Text = "Private Key File location";
			// 
			// azpTextbox
			// 
			azpTextbox.Location = new Point(242, 77);
			azpTextbox.Name = "azpTextbox";
			azpTextbox.Size = new Size(799, 31);
			azpTextbox.TabIndex = 17;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(185, 80);
			label5.Name = "label5";
			label5.Size = new Size(40, 25);
			label5.TabIndex = 16;
			label5.Text = "azp";
			// 
			// endpointTextBox
			// 
			endpointTextBox.Location = new Point(242, 30);
			endpointTextBox.Name = "endpointTextBox";
			endpointTextBox.Size = new Size(799, 31);
			endpointTextBox.TabIndex = 15;
			endpointTextBox.Text = "https://login.microsoftonline.com/1b20b87e-cebd-43cc-97bd-bdd41a2f5cf1/oauth2/v2.0/token";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(141, 33);
			label4.Name = "label4";
			label4.Size = new Size(84, 25);
			label4.TabIndex = 14;
			label4.Text = "Endpoint";
			// 
			// textBox1
			// 
			textBox1.Location = new Point(39, 748);
			textBox1.Multiline = true;
			textBox1.Name = "textBox1";
			textBox1.ScrollBars = ScrollBars.Vertical;
			textBox1.Size = new Size(1002, 410);
			textBox1.TabIndex = 28;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(39, 720);
			label1.Name = "label1";
			label1.Size = new Size(126, 25);
			label1.TabIndex = 29;
			label1.Text = "token payload";
			// 
			// AccessTokenForm
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1082, 1218);
			Controls.Add(label1);
			Controls.Add(textBox1);
			Controls.Add(audTextbox);
			Controls.Add(label8);
			Controls.Add(button4);
			Controls.Add(button3);
			Controls.Add(result2TextBox);
			Controls.Add(button2);
			Controls.Add(certificatePathTextBox);
			Controls.Add(label7);
			Controls.Add(privateKeyPathTextBox);
			Controls.Add(label6);
			Controls.Add(azpTextbox);
			Controls.Add(label5);
			Controls.Add(endpointTextBox);
			Controls.Add(label4);
			Name = "AccessTokenForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "AccessTokenForm";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox audTextbox;
		private Label label8;
		private Button button4;
		private Button button3;
		private TextBox result2TextBox;
		private Button button2;
		private TextBox certificatePathTextBox;
		private Label label7;
		private TextBox privateKeyPathTextBox;
		private Label label6;
		private TextBox azpTextbox;
		private Label label5;
		private TextBox endpointTextBox;
		private Label label4;
		private TextBox textBox1;
		private Label label1;
	}
}