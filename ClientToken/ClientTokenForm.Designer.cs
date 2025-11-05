namespace ClientToken;

partial class ClientTokenForm
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
		groupBox1 = new GroupBox();
		label9 = new Label();
		label10 = new Label();
		claim2ValueText = new TextBox();
		claim1ValueText = new TextBox();
		claim2NameText = new TextBox();
		label3 = new Label();
		label2 = new Label();
		claim1NameText = new TextBox();
		groupBox1.SuspendLayout();
		SuspendLayout();
		// 
		// audTextbox
		// 
		audTextbox.Location = new Point(242, 126);
		audTextbox.Name = "audTextbox";
		audTextbox.Size = new Size(799, 31);
		audTextbox.TabIndex = 27;
		audTextbox.DataBindings.Add("Text", TextContentCache, "Aud");
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
		result2TextBox.Location = new Point(39, 467);
		result2TextBox.Multiline = true;
		result2TextBox.Name = "result2TextBox";
		result2TextBox.ScrollBars = ScrollBars.Vertical;
		result2TextBox.Size = new Size(1002, 159);
		result2TextBox.TabIndex = 23;
		// 
		// button2
		// 
		button2.Location = new Point(39, 414);
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
		certificatePathTextBox.DataBindings.Add("Text", TextContentCache, "CertificatePath");
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
		privateKeyPathTextBox.DataBindings.Add("Text", TextContentCache, "PrivateKeyPath");
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
		azpTextbox.DataBindings.Add("Text", TextContentCache, "Azp");
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
		endpointTextBox.DataBindings.Add("Text", TextContentCache, "AuthorityUrl");
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
		textBox1.Location = new Point(39, 708);
		textBox1.Multiline = true;
		textBox1.Name = "textBox1";
		textBox1.ScrollBars = ScrollBars.Vertical;
		textBox1.Size = new Size(1002, 450);
		textBox1.TabIndex = 28;
		// 
		// label1
		// 
		label1.AutoSize = true;
		label1.Location = new Point(39, 661);
		label1.Name = "label1";
		label1.Size = new Size(126, 25);
		label1.TabIndex = 29;
		label1.Text = "token payload";
		// 
		// groupBox1
		// 
		groupBox1.Controls.Add(label9);
		groupBox1.Controls.Add(label10);
		groupBox1.Controls.Add(claim2ValueText);
		groupBox1.Controls.Add(claim1ValueText);
		groupBox1.Controls.Add(label3);
		groupBox1.Controls.Add(claim2NameText);
		groupBox1.Controls.Add(label2);
		groupBox1.Controls.Add(claim1NameText);
		groupBox1.Location = new Point(59, 279);
		groupBox1.Name = "groupBox1";
		groupBox1.Size = new Size(1002, 129);
		groupBox1.TabIndex = 34;
		groupBox1.TabStop = false;
		groupBox1.Text = "context claims";
		// 
		// label9
		// 
		label9.AutoSize = true;
		label9.Location = new Point(467, 77);
		label9.Name = "label9";
		label9.Size = new Size(109, 25);
		label9.TabIndex = 37;
		label9.Text = "claim2 value";
		// 
		// label10
		// 
		label10.AutoSize = true;
		label10.Location = new Point(467, 43);
		label10.Name = "label10";
		label10.Size = new Size(109, 25);
		label10.TabIndex = 36;
		label10.Text = "claim1 value";
		// 
		// claim2ValueText
		// 
		claim2ValueText.Location = new Point(582, 74);
		claim2ValueText.Name = "claim2ValueText";
		claim2ValueText.Size = new Size(400, 31);
		claim2ValueText.TabIndex = 35;
		claim2ValueText.DataBindings.Add("Text", TextContentCache, "Claim2Value");
		// 
		// claim1ValueText
		// 
		claim1ValueText.Location = new Point(582, 37);
		claim1ValueText.Name = "claim1ValueText";
		claim1ValueText.Size = new Size(400, 31);
		claim1ValueText.TabIndex = 34;
		claim1ValueText.DataBindings.Add("Text", TextContentCache, "Claim1Value");
		// 
		// claim2NameText
		// 
		claim2NameText.Location = new Point(183, 74);
		claim2NameText.Name = "claim2NameText";
		claim2NameText.Size = new Size(246, 31);
		claim2NameText.TabIndex = 33;
		claim2NameText.DataBindings.Add("Text", TextContentCache, "Claim2Name");
		// 
		// label3
		// 
		label3.AutoSize = true;
		label3.Location = new Point(54, 77);
		label3.Name = "label3";
		label3.Size = new Size(112, 25);
		label3.TabIndex = 32;
		label3.Text = "claim2 name";
		// 
		// label2
		// 
		label2.AutoSize = true;
		label2.Location = new Point(54, 43);
		label2.Name = "label2";
		label2.Size = new Size(112, 25);
		label2.TabIndex = 30;
		label2.Text = "claim1 name";
		// 
		// claim1NameText
		// 
		claim1NameText.Location = new Point(183, 37);
		claim1NameText.Name = "claim1NameText";
		claim1NameText.Size = new Size(246, 31);
		claim1NameText.TabIndex = 31;
		claim1NameText.DataBindings.Add("Text", TextContentCache, "Claim1Name");
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
		Controls.Add(groupBox1);
		Name = "AccessTokenForm";
		StartPosition = FormStartPosition.CenterScreen;
		Text = "AccessTokenForm";
		groupBox1.ResumeLayout(false);
		groupBox1.PerformLayout();
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
	private GroupBox groupBox1;
	private Label label9;
	private Label label10;
	private TextBox claim2ValueText;
	private TextBox claim1ValueText;
	private Label label3;
	private TextBox claim2NameText;
	private Label label2;
	private TextBox claim1NameText;
}