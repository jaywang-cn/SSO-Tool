namespace TokenGenerator
{
	partial class SSOForm
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
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(47, 77);
			label1.Name = "label1";
			label1.Size = new Size(108, 25);
			label1.TabIndex = 0;
			label1.Text = "AuthorityUrl";
			// 
			// authUrlTextBox
			// 
			authUrlTextBox.Location = new Point(161, 74);
			authUrlTextBox.Name = "authUrlTextBox";
			authUrlTextBox.Size = new Size(840, 31);
			authUrlTextBox.TabIndex = 4;
			// 
			// clientIdTextBox
			// 
			clientIdTextBox.Location = new Point(161, 116);
			clientIdTextBox.Name = "clientIdTextBox";
			clientIdTextBox.Size = new Size(468, 31);
			clientIdTextBox.TabIndex = 3;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(83, 119);
			label2.Name = "label2";
			label2.Size = new Size(72, 25);
			label2.TabIndex = 2;
			label2.Text = "ClientId";
			// 
			// button1
			// 
			button1.Location = new Point(47, 275);
			button1.Name = "button1";
			button1.Size = new Size(112, 34);
			button1.TabIndex = 1;
			button1.Text = "Start";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// result1TextBox
			// 
			result1TextBox.Location = new Point(45, 370);
			result1TextBox.Multiline = true;
			result1TextBox.Name = "result1TextBox";
			result1TextBox.Size = new Size(475, 367);
			result1TextBox.TabIndex = 5;
			// 
			// domainHintTextBox
			// 
			domainHintTextBox.Location = new Point(161, 208);
			domainHintTextBox.Name = "domainHintTextBox";
			domainHintTextBox.Size = new Size(162, 31);
			domainHintTextBox.TabIndex = 7;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(47, 211);
			label3.Name = "label3";
			label3.Size = new Size(108, 25);
			label3.TabIndex = 6;
			label3.Text = "domain hint";
			// 
			// label17
			// 
			label17.AutoSize = true;
			label17.Location = new Point(357, 211);
			label17.Name = "label17";
			label17.Size = new Size(131, 25);
			label17.TabIndex = 19;
			label17.Text = "custom scopes";
			// 
			// scopesTextBox
			// 
			scopesTextBox.Location = new Point(494, 208);
			scopesTextBox.Name = "scopesTextBox";
			scopesTextBox.Size = new Size(507, 31);
			scopesTextBox.TabIndex = 18;
			// 
			// label13
			// 
			label13.AutoSize = true;
			label13.Location = new Point(575, 36);
			label13.Name = "label13";
			label13.Size = new Size(103, 25);
			label13.TabIndex = 16;
			label13.Text = "Server Type";
			// 
			// comboBox2
			// 
			comboBox2.Enabled = false;
			comboBox2.FormattingEnabled = true;
			comboBox2.Location = new Point(684, 28);
			comboBox2.Name = "comboBox2";
			comboBox2.Size = new Size(162, 33);
			comboBox2.TabIndex = 15;
			// 
			// label12
			// 
			label12.AutoSize = true;
			label12.Location = new Point(58, 36);
			label12.Name = "label12";
			label12.Size = new Size(97, 25);
			label12.TabIndex = 14;
			label12.Text = "B2C Server";
			// 
			// comboBox1
			// 
			comboBox1.FormattingEnabled = true;
			comboBox1.Items.AddRange(new object[] { "Jaywtgb2c", "CargoWiseB2CTest01", "CargoWiseB2C01", "JayOneLogin", "JayOkta" });
			comboBox1.Location = new Point(161, 32);
			comboBox1.Name = "comboBox1";
			comboBox1.Size = new Size(376, 33);
			comboBox1.TabIndex = 13;
			comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
			// 
			// label11
			// 
			label11.AutoSize = true;
			label11.Location = new Point(543, 334);
			label11.Name = "label11";
			label11.Size = new Size(112, 25);
			label11.TabIndex = 12;
			label11.Text = "access token";
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.Location = new Point(45, 334);
			label10.Name = "label10";
			label10.Size = new Size(77, 25);
			label10.TabIndex = 11;
			label10.Text = "id token";
			// 
			// accessToken
			// 
			accessToken.Location = new Point(543, 370);
			accessToken.Multiline = true;
			accessToken.Name = "accessToken";
			accessToken.Size = new Size(470, 367);
			accessToken.TabIndex = 10;
			// 
			// redirectUrl
			// 
			redirectUrl.Location = new Point(161, 165);
			redirectUrl.Name = "redirectUrl";
			redirectUrl.Size = new Size(468, 31);
			redirectUrl.TabIndex = 9;
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Location = new Point(47, 168);
			label9.Name = "label9";
			label9.Size = new Size(96, 25);
			label9.TabIndex = 8;
			label9.Text = "redirect url";
			// 
			// SSOForm
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1048, 790);
			Controls.Add(label17);
			Controls.Add(scopesTextBox);
			Controls.Add(label12);
			Controls.Add(label13);
			Controls.Add(label2);
			Controls.Add(comboBox2);
			Controls.Add(authUrlTextBox);
			Controls.Add(clientIdTextBox);
			Controls.Add(comboBox1);
			Controls.Add(label1);
			Controls.Add(label11);
			Controls.Add(label3);
			Controls.Add(label10);
			Controls.Add(button1);
			Controls.Add(accessToken);
			Controls.Add(domainHintTextBox);
			Controls.Add(redirectUrl);
			Controls.Add(result1TextBox);
			Controls.Add(label9);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "SSOForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "User Token";
			ResumeLayout(false);
			PerformLayout();
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
	}
}