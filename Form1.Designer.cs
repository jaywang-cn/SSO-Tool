namespace TokenGenerator
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			label1 = new Label();
			authUrlTextBox = new TextBox();
			clientIdTextBox = new TextBox();
			label2 = new Label();
			button1 = new Button();
			result1TextBox = new TextBox();
			domainHintTextBox = new TextBox();
			label3 = new Label();
			tabControl1 = new TabControl();
			tabPage1 = new TabPage();
			label17 = new Label();
			scopesTextBox = new TextBox();
			label13 = new Label();
			comboBox2 = new ComboBox();
			label12 = new Label();
			comboBox1 = new ComboBox();
			label11 = new Label();
			label10 = new Label();
			accessToken = new TextBox();
			redirectUrl = new TextBox();
			label9 = new Label();
			tabPage2 = new TabPage();
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
			tabControl1.SuspendLayout();
			tabPage1.SuspendLayout();
			tabPage2.SuspendLayout();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(19, 64);
			label1.Name = "label1";
			label1.Size = new Size(108, 25);
			label1.TabIndex = 0;
			label1.Text = "AuthorityUrl";
			// 
			// authUrlTextBox
			// 
			authUrlTextBox.Location = new Point(133, 61);
			authUrlTextBox.Name = "authUrlTextBox";
			authUrlTextBox.Size = new Size(840, 31);
			authUrlTextBox.TabIndex = 4;
			// 
			// clientIdTextBox
			// 
			clientIdTextBox.Location = new Point(133, 103);
			clientIdTextBox.Name = "clientIdTextBox";
			clientIdTextBox.Size = new Size(468, 31);
			clientIdTextBox.TabIndex = 3;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(55, 106);
			label2.Name = "label2";
			label2.Size = new Size(72, 25);
			label2.TabIndex = 2;
			label2.Text = "ClientId";
			// 
			// button1
			// 
			button1.Location = new Point(19, 262);
			button1.Name = "button1";
			button1.Size = new Size(112, 34);
			button1.TabIndex = 1;
			button1.Text = "Start";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// result1TextBox
			// 
			result1TextBox.Location = new Point(17, 357);
			result1TextBox.Multiline = true;
			result1TextBox.Name = "result1TextBox";
			result1TextBox.Size = new Size(475, 367);
			result1TextBox.TabIndex = 5;
			// 
			// domainHintTextBox
			// 
			domainHintTextBox.Location = new Point(133, 195);
			domainHintTextBox.Name = "domainHintTextBox";
			domainHintTextBox.Size = new Size(162, 31);
			domainHintTextBox.TabIndex = 7;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(19, 198);
			label3.Name = "label3";
			label3.Size = new Size(108, 25);
			label3.TabIndex = 6;
			label3.Text = "domain hint";
			// 
			// tabControl1
			// 
			tabControl1.Controls.Add(tabPage1);
			tabControl1.Controls.Add(tabPage2);
			tabControl1.Dock = DockStyle.Fill;
			tabControl1.Location = new Point(0, 0);
			tabControl1.Name = "tabControl1";
			tabControl1.SelectedIndex = 0;
			tabControl1.Size = new Size(1015, 788);
			tabControl1.TabIndex = 8;
			// 
			// tabPage1
			// 
			tabPage1.Controls.Add(label17);
			tabPage1.Controls.Add(scopesTextBox);
			tabPage1.Controls.Add(label13);
			tabPage1.Controls.Add(comboBox2);
			tabPage1.Controls.Add(label12);
			tabPage1.Controls.Add(comboBox1);
			tabPage1.Controls.Add(label11);
			tabPage1.Controls.Add(label10);
			tabPage1.Controls.Add(accessToken);
			tabPage1.Controls.Add(redirectUrl);
			tabPage1.Controls.Add(label9);
			tabPage1.Controls.Add(result1TextBox);
			tabPage1.Controls.Add(domainHintTextBox);
			tabPage1.Controls.Add(button1);
			tabPage1.Controls.Add(label3);
			tabPage1.Controls.Add(label1);
			tabPage1.Controls.Add(clientIdTextBox);
			tabPage1.Controls.Add(authUrlTextBox);
			tabPage1.Controls.Add(label2);
			tabPage1.Location = new Point(4, 34);
			tabPage1.Name = "tabPage1";
			tabPage1.Padding = new Padding(3);
			tabPage1.Size = new Size(1007, 750);
			tabPage1.TabIndex = 0;
			tabPage1.Text = "User Access Token";
			tabPage1.UseVisualStyleBackColor = true;
			// 
			// label17
			// 
			label17.AutoSize = true;
			label17.Location = new Point(329, 198);
			label17.Name = "label17";
			label17.Size = new Size(131, 25);
			label17.TabIndex = 19;
			label17.Text = "custom scopes";
			// 
			// scopesTextBox
			// 
			scopesTextBox.Location = new Point(466, 195);
			scopesTextBox.Name = "scopesTextBox";
			scopesTextBox.Size = new Size(507, 31);
			scopesTextBox.TabIndex = 18;
			// 
			// label13
			// 
			label13.AutoSize = true;
			label13.Location = new Point(547, 23);
			label13.Name = "label13";
			label13.Size = new Size(103, 25);
			label13.TabIndex = 16;
			label13.Text = "Server Type";
			// 
			// comboBox2
			// 
			comboBox2.Enabled = false;
			comboBox2.FormattingEnabled = true;
			comboBox2.Location = new Point(656, 15);
			comboBox2.Name = "comboBox2";
			comboBox2.Size = new Size(162, 33);
			comboBox2.TabIndex = 15;
			// 
			// label12
			// 
			label12.AutoSize = true;
			label12.Location = new Point(30, 23);
			label12.Name = "label12";
			label12.Size = new Size(97, 25);
			label12.TabIndex = 14;
			label12.Text = "B2C Server";
			// 
			// comboBox1
			// 
			comboBox1.FormattingEnabled = true;
			comboBox1.Items.AddRange(new object[] { "Jaywtgb2c", "CargoWiseB2CTest01", "CargoWiseB2C01", "JayOneLogin", "JayOkta" });
			comboBox1.Location = new Point(133, 19);
			comboBox1.Name = "comboBox1";
			comboBox1.Size = new Size(376, 33);
			comboBox1.TabIndex = 13;
			comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
			// 
			// label11
			// 
			label11.AutoSize = true;
			label11.Location = new Point(515, 321);
			label11.Name = "label11";
			label11.Size = new Size(112, 25);
			label11.TabIndex = 12;
			label11.Text = "access token";
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.Location = new Point(17, 321);
			label10.Name = "label10";
			label10.Size = new Size(77, 25);
			label10.TabIndex = 11;
			label10.Text = "id token";
			// 
			// accessToken
			// 
			accessToken.Location = new Point(515, 357);
			accessToken.Multiline = true;
			accessToken.Name = "accessToken";
			accessToken.Size = new Size(470, 367);
			accessToken.TabIndex = 10;
			// 
			// redirectUrl
			// 
			redirectUrl.Location = new Point(133, 152);
			redirectUrl.Name = "redirectUrl";
			redirectUrl.Size = new Size(468, 31);
			redirectUrl.TabIndex = 9;
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Location = new Point(19, 155);
			label9.Name = "label9";
			label9.Size = new Size(96, 25);
			label9.TabIndex = 8;
			label9.Text = "redirect url";
			// 
			// tabPage2
			// 
			tabPage2.Controls.Add(audTextbox);
			tabPage2.Controls.Add(label8);
			tabPage2.Controls.Add(button4);
			tabPage2.Controls.Add(button3);
			tabPage2.Controls.Add(result2TextBox);
			tabPage2.Controls.Add(button2);
			tabPage2.Controls.Add(certificatePathTextBox);
			tabPage2.Controls.Add(label7);
			tabPage2.Controls.Add(privateKeyPathTextBox);
			tabPage2.Controls.Add(label6);
			tabPage2.Controls.Add(azpTextbox);
			tabPage2.Controls.Add(label5);
			tabPage2.Controls.Add(endpointTextBox);
			tabPage2.Controls.Add(label4);
			tabPage2.Location = new Point(4, 34);
			tabPage2.Name = "tabPage2";
			tabPage2.Padding = new Padding(3);
			tabPage2.Size = new Size(1007, 750);
			tabPage2.TabIndex = 1;
			tabPage2.Text = "Client Access Token";
			tabPage2.UseVisualStyleBackColor = true;
			// 
			// audTextbox
			// 
			audTextbox.Location = new Point(136, 128);
			audTextbox.Name = "audTextbox";
			audTextbox.Size = new Size(538, 31);
			audTextbox.TabIndex = 13;
			audTextbox.Text = "3a3eae3b-2640-4a5c-9e0f-23d2ffaa4f38";
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Location = new Point(45, 131);
			label8.Name = "label8";
			label8.Size = new Size(42, 25);
			label8.TabIndex = 12;
			label8.Text = "aud";
			// 
			// button4
			// 
			button4.Location = new Point(680, 233);
			button4.Name = "button4";
			button4.Size = new Size(69, 34);
			button4.TabIndex = 11;
			button4.Text = "...";
			button4.UseVisualStyleBackColor = true;
			button4.Click += button4_Click;
			// 
			// button3
			// 
			button3.Location = new Point(680, 176);
			button3.Name = "button3";
			button3.Size = new Size(69, 34);
			button3.TabIndex = 10;
			button3.Text = "...";
			button3.UseVisualStyleBackColor = true;
			button3.Click += button3_Click;
			// 
			// result2TextBox
			// 
			result2TextBox.Location = new Point(32, 339);
			result2TextBox.Multiline = true;
			result2TextBox.Name = "result2TextBox";
			result2TextBox.Size = new Size(944, 323);
			result2TextBox.TabIndex = 9;
			// 
			// button2
			// 
			button2.Location = new Point(32, 289);
			button2.Name = "button2";
			button2.Size = new Size(112, 34);
			button2.TabIndex = 8;
			button2.Text = "Generate";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// certificatePathTextBox
			// 
			certificatePathTextBox.Location = new Point(136, 235);
			certificatePathTextBox.Name = "certificatePathTextBox";
			certificatePathTextBox.Size = new Size(538, 31);
			certificatePathTextBox.TabIndex = 7;
			certificatePathTextBox.Text = "Certificate.crt";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(32, 241);
			label7.Name = "label7";
			label7.Size = new Size(90, 25);
			label7.TabIndex = 6;
			label7.Text = "Certificate";
			// 
			// privateKeyPathTextBox
			// 
			privateKeyPathTextBox.Location = new Point(136, 179);
			privateKeyPathTextBox.Name = "privateKeyPathTextBox";
			privateKeyPathTextBox.Size = new Size(538, 31);
			privateKeyPathTextBox.TabIndex = 5;
			privateKeyPathTextBox.Text = "privatekey.key";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(32, 182);
			label6.Name = "label6";
			label6.Size = new Size(98, 25);
			label6.TabIndex = 4;
			label6.Text = "Private Key";
			// 
			// azpTextbox
			// 
			azpTextbox.Location = new Point(136, 79);
			azpTextbox.Name = "azpTextbox";
			azpTextbox.Size = new Size(538, 31);
			azpTextbox.TabIndex = 3;
			azpTextbox.Text = "4a02e648-e55a-4633-9512-665620e7bb08";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(45, 82);
			label5.Name = "label5";
			label5.Size = new Size(40, 25);
			label5.TabIndex = 2;
			label5.Text = "azp";
			// 
			// endpointTextBox
			// 
			endpointTextBox.Location = new Point(136, 32);
			endpointTextBox.Name = "endpointTextBox";
			endpointTextBox.Size = new Size(840, 31);
			endpointTextBox.TabIndex = 1;
			endpointTextBox.Text = "https://login.microsoftonline.com/804a70cf-4a61-4a08-908e-a32b2cff8131/oauth2/v2.0/token";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(46, 32);
			label4.Name = "label4";
			label4.Size = new Size(84, 25);
			label4.TabIndex = 0;
			label4.Text = "Endpoint";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1015, 788);
			Controls.Add(tabControl1);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "Form1";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Token Generation";
			tabControl1.ResumeLayout(false);
			tabPage1.ResumeLayout(false);
			tabPage1.PerformLayout();
			tabPage2.ResumeLayout(false);
			tabPage2.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Label label1;
		private TextBox authUrlTextBox;
		private TextBox clientIdTextBox;
		private Label label2;
		private Button button1;
		private TextBox result1TextBox;
		private TextBox domainHintTextBox;
		private Label label3;
		private TabControl tabControl1;
		private TabPage tabPage1;
		private TabPage tabPage2;
		private TextBox privateKeyPathTextBox;
		private Label label6;
		private TextBox azpTextbox;
		private Label label5;
		private TextBox endpointTextBox;
		private Label label4;
		private TextBox result2TextBox;
		private Button button2;
		private TextBox certificatePathTextBox;
		private Label label7;
		private Button button4;
		private Button button3;
		private TextBox audTextbox;
		private Label label8;
		private TextBox redirectUrl;
		private Label label9;
		private Label label11;
		private Label label10;
		private TextBox accessToken;
		private Label label12;
		private ComboBox comboBox1;
		private Label label13;
		private ComboBox comboBox2;
		private TextBox scopesTextBox;
		private Label label17;
		private Label label14;
		private Button button7;
		private Button button8;
		private Button idpAssertionButton;
	}
}