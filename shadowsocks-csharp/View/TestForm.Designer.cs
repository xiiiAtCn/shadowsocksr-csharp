namespace Shadowsocks.View
{
    partial class TestForm
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
            System.Windows.Forms.TabPage ProxyRule;
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.ProxyType = new System.Windows.Forms.TabPage();
            this.PAC = new System.Windows.Forms.TabPage();
            this.ProxyServer = new System.Windows.Forms.TabPage();
            this.Subscribe = new System.Windows.Forms.TabPage();
            this.OptionalSetting = new System.Windows.Forms.TabPage();
            this.Port = new System.Windows.Forms.TabPage();
            this.Help = new System.Windows.Forms.TabPage();
            this.serverList = new System.Windows.Forms.ListBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.DownButton = new System.Windows.Forms.Button();
            this.UpButton = new System.Windows.Forms.Button();
            this.ServerContainer = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Server_IP = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Server_Port = new System.Windows.Forms.CheckBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            ProxyRule = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.ProxyType.SuspendLayout();
            this.ServerContainer.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.ProxyType);
            this.tabControl1.Controls.Add(this.PAC);
            this.tabControl1.Controls.Add(ProxyRule);
            this.tabControl1.Controls.Add(this.ProxyServer);
            this.tabControl1.Controls.Add(this.Subscribe);
            this.tabControl1.Controls.Add(this.OptionalSetting);
            this.tabControl1.Controls.Add(this.Port);
            this.tabControl1.Controls.Add(this.Help);
            this.tabControl1.Location = new System.Drawing.Point(39, 29);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1361, 657);
            this.tabControl1.TabIndex = 0;
            // 
            // ProxyType
            // 
            this.ProxyType.Controls.Add(this.ServerContainer);
            this.ProxyType.Controls.Add(this.UpButton);
            this.ProxyType.Controls.Add(this.DownButton);
            this.ProxyType.Controls.Add(this.AddButton);
            this.ProxyType.Controls.Add(this.DeleteButton);
            this.ProxyType.Controls.Add(this.serverList);
            this.ProxyType.Location = new System.Drawing.Point(4, 25);
            this.ProxyType.Name = "ProxyType";
            this.ProxyType.Padding = new System.Windows.Forms.Padding(3);
            this.ProxyType.Size = new System.Drawing.Size(1353, 628);
            this.ProxyType.TabIndex = 0;
            this.ProxyType.Text = "ProxyType";
            this.ProxyType.Click += new System.EventHandler(this.ProxyType_Click);
            // 
            // PAC
            // 
            this.PAC.Location = new System.Drawing.Point(4, 25);
            this.PAC.Name = "PAC";
            this.PAC.Padding = new System.Windows.Forms.Padding(3);
            this.PAC.Size = new System.Drawing.Size(1353, 628);
            this.PAC.TabIndex = 1;
            this.PAC.Text = "PAC";
            this.PAC.UseVisualStyleBackColor = true;
            // 
            // ProxyRule
            // 
            ProxyRule.Location = new System.Drawing.Point(4, 25);
            ProxyRule.Name = "ProxyRule";
            ProxyRule.Padding = new System.Windows.Forms.Padding(3);
            ProxyRule.Size = new System.Drawing.Size(1353, 628);
            ProxyRule.TabIndex = 2;
            ProxyRule.Text = "ProxyRule";
            ProxyRule.UseVisualStyleBackColor = true;
            // 
            // ProxyServer
            // 
            this.ProxyServer.Location = new System.Drawing.Point(4, 25);
            this.ProxyServer.Name = "ProxyServer";
            this.ProxyServer.Padding = new System.Windows.Forms.Padding(3);
            this.ProxyServer.Size = new System.Drawing.Size(1385, 637);
            this.ProxyServer.TabIndex = 3;
            this.ProxyServer.Text = "ProxyServer";
            this.ProxyServer.UseVisualStyleBackColor = true;
            // 
            // Subscribe
            // 
            this.Subscribe.Location = new System.Drawing.Point(4, 25);
            this.Subscribe.Name = "Subscribe";
            this.Subscribe.Padding = new System.Windows.Forms.Padding(3);
            this.Subscribe.Size = new System.Drawing.Size(1385, 637);
            this.Subscribe.TabIndex = 4;
            this.Subscribe.Text = "Subscribe";
            this.Subscribe.UseVisualStyleBackColor = true;
            // 
            // OptionalSetting
            // 
            this.OptionalSetting.Location = new System.Drawing.Point(4, 25);
            this.OptionalSetting.Name = "OptionalSetting";
            this.OptionalSetting.Padding = new System.Windows.Forms.Padding(3);
            this.OptionalSetting.Size = new System.Drawing.Size(1385, 637);
            this.OptionalSetting.TabIndex = 5;
            this.OptionalSetting.Text = "OptionalSetting";
            this.OptionalSetting.UseVisualStyleBackColor = true;
            // 
            // Port
            // 
            this.Port.Location = new System.Drawing.Point(4, 25);
            this.Port.Name = "Port";
            this.Port.Padding = new System.Windows.Forms.Padding(3);
            this.Port.Size = new System.Drawing.Size(1385, 637);
            this.Port.TabIndex = 6;
            this.Port.Text = "Port";
            this.Port.UseVisualStyleBackColor = true;
            this.Port.Click += new System.EventHandler(this.tabPage7_Click);
            // 
            // Help
            // 
            this.Help.Location = new System.Drawing.Point(4, 25);
            this.Help.Name = "Help";
            this.Help.Padding = new System.Windows.Forms.Padding(3);
            this.Help.Size = new System.Drawing.Size(1385, 637);
            this.Help.TabIndex = 7;
            this.Help.Text = "Help";
            this.Help.UseVisualStyleBackColor = true;
            // 
            // serverList
            // 
            this.serverList.FormattingEnabled = true;
            this.serverList.ItemHeight = 15;
            this.serverList.Location = new System.Drawing.Point(26, 19);
            this.serverList.Name = "serverList";
            this.serverList.Size = new System.Drawing.Size(277, 424);
            this.serverList.TabIndex = 0;
            this.serverList.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Location = new System.Drawing.Point(184, 473);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(104, 36);
            this.DeleteButton.TabIndex = 1;
            this.DeleteButton.Text = "&Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            // 
            // AddButton
            // 
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Location = new System.Drawing.Point(34, 475);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(110, 34);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "&Add";
            this.AddButton.UseVisualStyleBackColor = true;
            // 
            // DownButton
            // 
            this.DownButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DownButton.Location = new System.Drawing.Point(184, 524);
            this.DownButton.Name = "DownButton";
            this.DownButton.Size = new System.Drawing.Size(104, 37);
            this.DownButton.TabIndex = 3;
            this.DownButton.Text = "&Down";
            this.DownButton.UseVisualStyleBackColor = true;
            // 
            // UpButton
            // 
            this.UpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpButton.Location = new System.Drawing.Point(34, 524);
            this.UpButton.Name = "UpButton";
            this.UpButton.Size = new System.Drawing.Size(110, 37);
            this.UpButton.TabIndex = 4;
            this.UpButton.Text = "&Up";
            this.UpButton.UseVisualStyleBackColor = true;
            // 
            // ServerContainer
            // 
            this.ServerContainer.Controls.Add(this.tableLayoutPanel1);
            this.ServerContainer.Location = new System.Drawing.Point(327, 19);
            this.ServerContainer.Name = "ServerContainer";
            this.ServerContainer.Size = new System.Drawing.Size(543, 577);
            this.ServerContainer.TabIndex = 5;
            this.ServerContainer.TabStop = false;
            this.ServerContainer.Text = "Server";
            this.ServerContainer.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 318F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.textBox5, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.comboBox4, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Server_IP, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Server_Port, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBox2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.comboBox2, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.comboBox1, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.textBox3, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.textBox4, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.comboBox3, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.textBox6, 1, 10);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 11);
            this.tableLayoutPanel1.Controls.Add(this.checkBox2, 0, 12);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDown1, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(16, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 14;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(507, 535);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Server_IP
            // 
            this.Server_IP.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Server_IP.AutoSize = true;
            this.Server_IP.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Server_IP.Location = new System.Drawing.Point(85, 47);
            this.Server_IP.Name = "Server_IP";
            this.Server_IP.Size = new System.Drawing.Size(101, 19);
            this.Server_IP.TabIndex = 0;
            this.Server_IP.Text = "&Server_IP";
            this.Server_IP.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(192, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(312, 25);
            this.textBox1.TabIndex = 6;
            // 
            // Server_Port
            // 
            this.Server_Port.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Server_Port.AutoSize = true;
            this.Server_Port.Location = new System.Drawing.Point(69, 85);
            this.Server_Port.Name = "Server_Port";
            this.Server_Port.Size = new System.Drawing.Size(117, 19);
            this.Server_Port.TabIndex = 7;
            this.Server_Port.Text = "&Server_Port";
            this.Server_Port.UseVisualStyleBackColor = true;
            this.Server_Port.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown1.Location = new System.Drawing.Point(192, 82);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(312, 25);
            this.numericUpDown1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "&Password";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "&Encrypt_Method";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(192, 198);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(312, 23);
            this.comboBox1.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "&Auth_Protocol";
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(192, 160);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(312, 23);
            this.comboBox2.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "&Protocol_Params";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(91, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "&Server_Type";
            // 
            // comboBox4
            // 
            this.comboBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(192, 7);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(312, 23);
            this.comboBox4.TabIndex = 15;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(192, 120);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(312, 25);
            this.textBox2.TabIndex = 16;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.Location = new System.Drawing.Point(192, 233);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(312, 25);
            this.textBox3.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(107, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "&Confusion";
            // 
            // comboBox3
            // 
            this.comboBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(192, 271);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(312, 23);
            this.comboBox3.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 314);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 15);
            this.label7.TabIndex = 19;
            this.label7.Text = "&Confusion_Params";
            // 
            // textBox4
            // 
            this.textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox4.Location = new System.Drawing.Point(192, 309);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(312, 25);
            this.textBox4.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(131, 353);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 15);
            this.label8.TabIndex = 21;
            this.label8.Text = "&Remark";
            // 
            // textBox5
            // 
            this.textBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox5.Location = new System.Drawing.Point(192, 348);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(312, 25);
            this.textBox5.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(139, 390);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label9.Size = new System.Drawing.Size(47, 15);
            this.label9.TabIndex = 24;
            this.label9.Text = "&Group";
            // 
            // textBox6
            // 
            this.textBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox6.Location = new System.Drawing.Point(192, 385);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(312, 25);
            this.textBox6.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(115, 429);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label10.Size = new System.Drawing.Size(71, 15);
            this.label10.TabIndex = 26;
            this.label10.Text = "&SSR_Link";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(29, 467);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(157, 19);
            this.checkBox2.TabIndex = 27;
            this.checkBox2.Text = "&Advanced_Options";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1448, 718);
            this.Controls.Add(this.tabControl1);
            this.Name = "TestForm";
            this.Text = "TestForm";
            this.tabControl1.ResumeLayout(false);
            this.ProxyType.ResumeLayout(false);
            this.ServerContainer.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage ProxyType;
        private System.Windows.Forms.TabPage PAC;
        private System.Windows.Forms.TabPage ProxyServer;
        private System.Windows.Forms.TabPage Subscribe;
        private System.Windows.Forms.TabPage OptionalSetting;
        private System.Windows.Forms.TabPage Port;
        private System.Windows.Forms.TabPage Help;
        private System.Windows.Forms.ListBox serverList;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button UpButton;
        private System.Windows.Forms.Button DownButton;
        private System.Windows.Forms.GroupBox ServerContainer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.CheckBox Server_IP;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox Server_Port;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.CheckBox checkBox2;
    }
}