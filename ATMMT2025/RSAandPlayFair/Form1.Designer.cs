namespace RSAandPlayFair
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
            menuStrip1 = new MenuStrip();
            mstrPlayFair = new ToolStripMenuItem();
            mstr5x5Matrix = new ToolStripMenuItem();
            mstr6x6Matrix = new ToolStripMenuItem();
            mstrRSA = new ToolStripMenuItem();
            pnlPlayFair5x5 = new Panel();
            label10 = new Label();
            btnPF5_Decrypt = new Button();
            btnPF5_Encrypt = new Button();
            tlpPF5_KeyMatrix = new TableLayoutPanel();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            tbPF5Result = new TextBox();
            tbPF5Input = new TextBox();
            tbPF5Key = new TextBox();
            pnlRSA = new Panel();
            button3 = new Button();
            btnBam = new Button();
            btnCopy = new Button();
            btnKySo = new Button();
            textBox11 = new TextBox();
            label21 = new Label();
            textBox8 = new TextBox();
            label18 = new Label();
            textBox9 = new TextBox();
            label19 = new Label();
            textBox10 = new TextBox();
            label20 = new Label();
            textBox7 = new TextBox();
            label17 = new Label();
            textBox5 = new TextBox();
            label15 = new Label();
            textBox6 = new TextBox();
            label16 = new Label();
            btnKeygenPQ = new Button();
            textBox3 = new TextBox();
            label13 = new Label();
            textBox4 = new TextBox();
            label14 = new Label();
            btnRandomKeygen = new Button();
            textBox2 = new TextBox();
            label12 = new Label();
            textBox1 = new TextBox();
            label11 = new Label();
            pnlPlayFair6x6 = new Panel();
            label9 = new Label();
            tlpPF6_KeyMatrix = new TableLayoutPanel();
            btnPF6_Decrypt = new Button();
            btnPF6_Encrypt = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            tbPF6_Result = new TextBox();
            tbPF6_Input = new TextBox();
            tbPF6_Key = new TextBox();
            button1 = new Button();
            button2 = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            menuStrip1.SuspendLayout();
            pnlPlayFair5x5.SuspendLayout();
            pnlRSA.SuspendLayout();
            pnlPlayFair6x6.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mstrPlayFair, mstrRSA });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(698, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // mstrPlayFair
            // 
            mstrPlayFair.DropDownItems.AddRange(new ToolStripItem[] { mstr5x5Matrix, mstr6x6Matrix });
            mstrPlayFair.Name = "mstrPlayFair";
            mstrPlayFair.Size = new Size(77, 24);
            mstrPlayFair.Text = "Play Fair";
            // 
            // mstr5x5Matrix
            // 
            mstr5x5Matrix.Name = "mstr5x5Matrix";
            mstr5x5Matrix.Size = new Size(161, 26);
            mstr5x5Matrix.Text = "5x5 Matrix";
            mstr5x5Matrix.Click += mstr5x5Matrix_Click;
            // 
            // mstr6x6Matrix
            // 
            mstr6x6Matrix.Name = "mstr6x6Matrix";
            mstr6x6Matrix.Size = new Size(161, 26);
            mstr6x6Matrix.Text = "6x6 Matrix";
            mstr6x6Matrix.Click += mstr6x6Matrix_Click;
            // 
            // mstrRSA
            // 
            mstrRSA.Name = "mstrRSA";
            mstrRSA.Size = new Size(50, 24);
            mstrRSA.Text = "RSA";
            mstrRSA.Click += mstrRSA_Click;
            // 
            // pnlPlayFair5x5
            // 
            pnlPlayFair5x5.Controls.Add(label10);
            pnlPlayFair5x5.Controls.Add(btnPF5_Decrypt);
            pnlPlayFair5x5.Controls.Add(btnPF5_Encrypt);
            pnlPlayFair5x5.Controls.Add(tlpPF5_KeyMatrix);
            pnlPlayFair5x5.Controls.Add(label3);
            pnlPlayFair5x5.Controls.Add(label4);
            pnlPlayFair5x5.Controls.Add(label2);
            pnlPlayFair5x5.Controls.Add(label1);
            pnlPlayFair5x5.Controls.Add(tbPF5Result);
            pnlPlayFair5x5.Controls.Add(tbPF5Input);
            pnlPlayFair5x5.Controls.Add(tbPF5Key);
            pnlPlayFair5x5.Location = new Point(10, 31);
            pnlPlayFair5x5.Margin = new Padding(2);
            pnlPlayFair5x5.Name = "pnlPlayFair5x5";
            pnlPlayFair5x5.Size = new Size(678, 421);
            pnlPlayFair5x5.TabIndex = 1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Elephant", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(460, 10);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(191, 31);
            label10.TabIndex = 8;
            label10.Text = "Play Fair 5x5";
            // 
            // btnPF5_Decrypt
            // 
            btnPF5_Decrypt.Location = new Point(540, 373);
            btnPF5_Decrypt.Margin = new Padding(2);
            btnPF5_Decrypt.Name = "btnPF5_Decrypt";
            btnPF5_Decrypt.Size = new Size(138, 42);
            btnPF5_Decrypt.TabIndex = 6;
            btnPF5_Decrypt.Text = "Decrypt";
            btnPF5_Decrypt.UseVisualStyleBackColor = true;
            btnPF5_Decrypt.Click += btnPF5_Decrypt_Click_1;
            // 
            // btnPF5_Encrypt
            // 
            btnPF5_Encrypt.Location = new Point(388, 373);
            btnPF5_Encrypt.Margin = new Padding(2);
            btnPF5_Encrypt.Name = "btnPF5_Encrypt";
            btnPF5_Encrypt.Size = new Size(138, 42);
            btnPF5_Encrypt.TabIndex = 6;
            btnPF5_Encrypt.Text = "Encrypt";
            btnPF5_Encrypt.UseVisualStyleBackColor = true;
            btnPF5_Encrypt.Click += btnPF5_Encrypt_Click_1;
            // 
            // tlpPF5_KeyMatrix
            // 
            tlpPF5_KeyMatrix.BackColor = SystemColors.ActiveCaption;
            tlpPF5_KeyMatrix.ColumnCount = 5;
            tlpPF5_KeyMatrix.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlpPF5_KeyMatrix.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlpPF5_KeyMatrix.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlpPF5_KeyMatrix.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlpPF5_KeyMatrix.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlpPF5_KeyMatrix.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tlpPF5_KeyMatrix.ForeColor = SystemColors.ActiveCaptionText;
            tlpPF5_KeyMatrix.Location = new Point(390, 62);
            tlpPF5_KeyMatrix.Margin = new Padding(2);
            tlpPF5_KeyMatrix.Name = "tlpPF5_KeyMatrix";
            tlpPF5_KeyMatrix.RowCount = 5;
            tlpPF5_KeyMatrix.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpPF5_KeyMatrix.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpPF5_KeyMatrix.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpPF5_KeyMatrix.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpPF5_KeyMatrix.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpPF5_KeyMatrix.Size = new Size(288, 288);
            tlpPF5_KeyMatrix.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(2, 228);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 4;
            label3.Text = "Result:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(388, 39);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(82, 20);
            label4.TabIndex = 3;
            label4.Text = "Key Matrix:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(2, 39);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 3;
            label2.Text = "Input:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(2, 10);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(40, 20);
            label1.TabIndex = 2;
            label1.Text = "Key: ";
            // 
            // tbPF5Result
            // 
            tbPF5Result.Location = new Point(2, 250);
            tbPF5Result.Margin = new Padding(2);
            tbPF5Result.Multiline = true;
            tbPF5Result.Name = "tbPF5Result";
            tbPF5Result.Size = new Size(371, 165);
            tbPF5Result.TabIndex = 1;
            // 
            // tbPF5Input
            // 
            tbPF5Input.Location = new Point(2, 62);
            tbPF5Input.Margin = new Padding(2);
            tbPF5Input.Multiline = true;
            tbPF5Input.Name = "tbPF5Input";
            tbPF5Input.Size = new Size(371, 165);
            tbPF5Input.TabIndex = 1;
            // 
            // tbPF5Key
            // 
            tbPF5Key.Location = new Point(38, 10);
            tbPF5Key.Margin = new Padding(2);
            tbPF5Key.Name = "tbPF5Key";
            tbPF5Key.Size = new Size(335, 27);
            tbPF5Key.TabIndex = 0;
            // 
            // pnlRSA
            // 
            pnlRSA.Controls.Add(button3);
            pnlRSA.Controls.Add(btnBam);
            pnlRSA.Controls.Add(btnCopy);
            pnlRSA.Controls.Add(btnKySo);
            pnlRSA.Controls.Add(textBox11);
            pnlRSA.Controls.Add(label21);
            pnlRSA.Controls.Add(textBox8);
            pnlRSA.Controls.Add(label18);
            pnlRSA.Controls.Add(textBox9);
            pnlRSA.Controls.Add(label19);
            pnlRSA.Controls.Add(textBox10);
            pnlRSA.Controls.Add(label20);
            pnlRSA.Controls.Add(textBox7);
            pnlRSA.Controls.Add(label17);
            pnlRSA.Controls.Add(textBox5);
            pnlRSA.Controls.Add(label15);
            pnlRSA.Controls.Add(textBox6);
            pnlRSA.Controls.Add(label16);
            pnlRSA.Controls.Add(btnKeygenPQ);
            pnlRSA.Controls.Add(textBox3);
            pnlRSA.Controls.Add(label13);
            pnlRSA.Controls.Add(textBox4);
            pnlRSA.Controls.Add(label14);
            pnlRSA.Controls.Add(btnRandomKeygen);
            pnlRSA.Controls.Add(textBox2);
            pnlRSA.Controls.Add(label12);
            pnlRSA.Controls.Add(textBox1);
            pnlRSA.Controls.Add(label11);
            pnlRSA.Location = new Point(1, 29);
            pnlRSA.Margin = new Padding(2);
            pnlRSA.Name = "pnlRSA";
            pnlRSA.Size = new Size(688, 423);
            pnlRSA.TabIndex = 0;
            pnlRSA.Paint += pnlRSA_Paint;
            // 
            // button3
            // 
            button3.Location = new Point(596, 327);
            button3.Name = "button3";
            button3.Size = new Size(66, 86);
            button3.TabIndex = 27;
            button3.Text = "Xác minh";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // btnBam
            // 
            btnBam.Location = new Point(595, 198);
            btnBam.Name = "btnBam";
            btnBam.Size = new Size(66, 86);
            btnBam.TabIndex = 26;
            btnBam.Text = "Băm SHA";
            btnBam.UseVisualStyleBackColor = true;
            btnBam.Click += button7_Click;
            // 
            // btnCopy
            // 
            btnCopy.Location = new Point(158, 360);
            btnCopy.Name = "btnCopy";
            btnCopy.Size = new Size(131, 29);
            btnCopy.TabIndex = 25;
            btnCopy.Text = "Copy chữ ký số";
            btnCopy.UseVisualStyleBackColor = true;
            btnCopy.Click += btnCopy_Click;
            // 
            // btnKySo
            // 
            btnKySo.Location = new Point(17, 360);
            btnKySo.Name = "btnKySo";
            btnKySo.Size = new Size(135, 29);
            btnKySo.TabIndex = 24;
            btnKySo.Text = "Tiến hành ký số";
            btnKySo.UseVisualStyleBackColor = true;
            btnKySo.Click += btnKySo_Click;
            // 
            // textBox11
            // 
            textBox11.Location = new Point(317, 386);
            textBox11.Name = "textBox11";
            textBox11.ReadOnly = true;
            textBox11.Size = new Size(272, 27);
            textBox11.TabIndex = 23;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(317, 364);
            label21.Margin = new Padding(2, 0, 2, 0);
            label21.Name = "label21";
            label21.Size = new Size(125, 20);
            label21.TabIndex = 22;
            label21.Text = "Giải mã chữ ký số";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(317, 323);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(272, 27);
            textBox8.TabIndex = 21;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(317, 301);
            label18.Margin = new Padding(2, 0, 2, 0);
            label18.Name = "label18";
            label18.Size = new Size(72, 20);
            label18.TabIndex = 20;
            label18.Text = "Chữ ký số";
            // 
            // textBox9
            // 
            textBox9.Location = new Point(317, 255);
            textBox9.Name = "textBox9";
            textBox9.ReadOnly = true;
            textBox9.Size = new Size(272, 27);
            textBox9.TabIndex = 19;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(317, 233);
            label19.Margin = new Padding(2, 0, 2, 0);
            label19.Name = "label19";
            label19.Size = new Size(157, 20);
            label19.TabIndex = 18;
            label19.Text = "Kết quả băm SHA-256";
            // 
            // textBox10
            // 
            textBox10.Location = new Point(317, 198);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(272, 27);
            textBox10.TabIndex = 17;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(317, 176);
            label20.Margin = new Padding(2, 0, 2, 0);
            label20.Name = "label20";
            label20.Size = new Size(152, 20);
            label20.TabIndex = 16;
            label20.Text = "Văn bản cần xác minh";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(17, 323);
            textBox7.Name = "textBox7";
            textBox7.ReadOnly = true;
            textBox7.Size = new Size(272, 27);
            textBox7.TabIndex = 15;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(17, 301);
            label17.Margin = new Padding(2, 0, 2, 0);
            label17.Name = "label17";
            label17.Size = new Size(72, 20);
            label17.TabIndex = 14;
            label17.Text = "Chữ ký số";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(17, 255);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(272, 27);
            textBox5.TabIndex = 13;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(17, 233);
            label15.Margin = new Padding(2, 0, 2, 0);
            label15.Name = "label15";
            label15.Size = new Size(157, 20);
            label15.TabIndex = 12;
            label15.Text = "Kết quả băm SHA-256";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(17, 198);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(272, 27);
            textBox6.TabIndex = 11;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(17, 176);
            label16.Margin = new Padding(2, 0, 2, 0);
            label16.Name = "label16";
            label16.Size = new Size(91, 20);
            label16.TabIndex = 10;
            label16.Text = "Văn bản gốc";
            // 
            // btnKeygenPQ
            // 
            btnKeygenPQ.Location = new Point(495, 17);
            btnKeygenPQ.Name = "btnKeygenPQ";
            btnKeygenPQ.Size = new Size(94, 110);
            btnKeygenPQ.TabIndex = 9;
            btnKeygenPQ.Text = "Tạo khoá theo P và Q";
            btnKeygenPQ.UseVisualStyleBackColor = true;
            btnKeygenPQ.Click += btnKeygenPQ_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(193, 96);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 8;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(193, 74);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(111, 20);
            label13.TabIndex = 7;
            label13.Text = "Số nguyên tố Q";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(193, 39);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 6;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(193, 17);
            label14.Margin = new Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Size = new Size(108, 20);
            label14.TabIndex = 5;
            label14.Text = "Số nguyên tố P";
            // 
            // btnRandomKeygen
            // 
            btnRandomKeygen.Location = new Point(378, 17);
            btnRandomKeygen.Name = "btnRandomKeygen";
            btnRandomKeygen.Size = new Size(96, 110);
            btnRandomKeygen.TabIndex = 4;
            btnRandomKeygen.Text = "Tạo khoá ngẫu nhiên";
            btnRandomKeygen.UseVisualStyleBackColor = true;
            btnRandomKeygen.Click += button3_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(17, 96);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 3;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(17, 74);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(111, 20);
            label12.TabIndex = 2;
            label12.Text = "Khoá công khai";
            label12.Click += label12_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(17, 39);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(17, 17);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(90, 20);
            label11.TabIndex = 0;
            label11.Text = "Khoá bí mật";
            label11.Click += label11_Click;
            // 
            // pnlPlayFair6x6
            // 
            pnlPlayFair6x6.Controls.Add(label9);
            pnlPlayFair6x6.Controls.Add(tlpPF6_KeyMatrix);
            pnlPlayFair6x6.Controls.Add(btnPF6_Decrypt);
            pnlPlayFair6x6.Controls.Add(btnPF6_Encrypt);
            pnlPlayFair6x6.Controls.Add(label5);
            pnlPlayFair6x6.Controls.Add(label6);
            pnlPlayFair6x6.Controls.Add(label7);
            pnlPlayFair6x6.Controls.Add(label8);
            pnlPlayFair6x6.Controls.Add(tbPF6_Result);
            pnlPlayFair6x6.Controls.Add(tbPF6_Input);
            pnlPlayFair6x6.Controls.Add(tbPF6_Key);
            pnlPlayFair6x6.Location = new Point(10, 31);
            pnlPlayFair6x6.Margin = new Padding(2);
            pnlPlayFair6x6.Name = "pnlPlayFair6x6";
            pnlPlayFair6x6.Size = new Size(679, 421);
            pnlPlayFair6x6.TabIndex = 1;
            pnlPlayFair6x6.Visible = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Elephant", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(460, 10);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(193, 31);
            label9.TabIndex = 8;
            label9.Text = "Play Fair 6x6";
            // 
            // tlpPF6_KeyMatrix
            // 
            tlpPF6_KeyMatrix.BackColor = SystemColors.ActiveCaption;
            tlpPF6_KeyMatrix.ColumnCount = 6;
            tlpPF6_KeyMatrix.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 48F));
            tlpPF6_KeyMatrix.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 48F));
            tlpPF6_KeyMatrix.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 48F));
            tlpPF6_KeyMatrix.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 48F));
            tlpPF6_KeyMatrix.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 48F));
            tlpPF6_KeyMatrix.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 48F));
            tlpPF6_KeyMatrix.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tlpPF6_KeyMatrix.ForeColor = SystemColors.ActiveCaptionText;
            tlpPF6_KeyMatrix.Location = new Point(391, 62);
            tlpPF6_KeyMatrix.Margin = new Padding(2);
            tlpPF6_KeyMatrix.Name = "tlpPF6_KeyMatrix";
            tlpPF6_KeyMatrix.RowCount = 6;
            tlpPF6_KeyMatrix.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tlpPF6_KeyMatrix.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tlpPF6_KeyMatrix.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tlpPF6_KeyMatrix.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tlpPF6_KeyMatrix.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tlpPF6_KeyMatrix.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tlpPF6_KeyMatrix.Size = new Size(288, 288);
            tlpPF6_KeyMatrix.TabIndex = 7;
            // 
            // btnPF6_Decrypt
            // 
            btnPF6_Decrypt.Location = new Point(540, 373);
            btnPF6_Decrypt.Margin = new Padding(2);
            btnPF6_Decrypt.Name = "btnPF6_Decrypt";
            btnPF6_Decrypt.Size = new Size(138, 42);
            btnPF6_Decrypt.TabIndex = 6;
            btnPF6_Decrypt.Text = "Decrypt";
            btnPF6_Decrypt.UseVisualStyleBackColor = true;
            btnPF6_Decrypt.Click += btnPF6_Decrypt_Click;
            // 
            // btnPF6_Encrypt
            // 
            btnPF6_Encrypt.Location = new Point(388, 373);
            btnPF6_Encrypt.Margin = new Padding(2);
            btnPF6_Encrypt.Name = "btnPF6_Encrypt";
            btnPF6_Encrypt.Size = new Size(138, 42);
            btnPF6_Encrypt.TabIndex = 6;
            btnPF6_Encrypt.Text = "Encrypt";
            btnPF6_Encrypt.UseVisualStyleBackColor = true;
            btnPF6_Encrypt.Click += btnPF6_Encrypt_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(2, 228);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(52, 20);
            label5.TabIndex = 4;
            label5.Text = "Result:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(388, 39);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(82, 20);
            label6.TabIndex = 3;
            label6.Text = "Key Matrix:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(2, 39);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(46, 20);
            label7.TabIndex = 3;
            label7.Text = "Input:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(2, 10);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(40, 20);
            label8.TabIndex = 2;
            label8.Text = "Key: ";
            // 
            // tbPF6_Result
            // 
            tbPF6_Result.Location = new Point(2, 250);
            tbPF6_Result.Margin = new Padding(2);
            tbPF6_Result.Multiline = true;
            tbPF6_Result.Name = "tbPF6_Result";
            tbPF6_Result.Size = new Size(371, 165);
            tbPF6_Result.TabIndex = 1;
            // 
            // tbPF6_Input
            // 
            tbPF6_Input.Location = new Point(2, 62);
            tbPF6_Input.Margin = new Padding(2);
            tbPF6_Input.Multiline = true;
            tbPF6_Input.Name = "tbPF6_Input";
            tbPF6_Input.Size = new Size(371, 165);
            tbPF6_Input.TabIndex = 1;
            // 
            // tbPF6_Key
            // 
            tbPF6_Key.Location = new Point(38, 10);
            tbPF6_Key.Margin = new Padding(2);
            tbPF6_Key.Name = "tbPF6_Key";
            tbPF6_Key.Size = new Size(335, 27);
            tbPF6_Key.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(675, 466);
            button1.Name = "button1";
            button1.Size = new Size(173, 52);
            button1.TabIndex = 6;
            button1.Text = "Decrypt";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(485, 466);
            button2.Name = "button2";
            button2.Size = new Size(173, 52);
            button2.TabIndex = 6;
            button2.Text = "Encrypt";
            button2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.ActiveCaption;
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tableLayoutPanel1.ForeColor = SystemColors.ActiveCaptionText;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.Size = new Size(200, 100);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(698, 462);
            Controls.Add(pnlPlayFair5x5);
            Controls.Add(pnlPlayFair6x6);
            Controls.Add(menuStrip1);
            Controls.Add(pnlRSA);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(2);
            Name = "Form1";
            Text = "ATMMT2025";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            pnlPlayFair5x5.ResumeLayout(false);
            pnlPlayFair5x5.PerformLayout();
            pnlRSA.ResumeLayout(false);
            pnlRSA.PerformLayout();
            pnlPlayFair6x6.ResumeLayout(false);
            pnlPlayFair6x6.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mstrPlayFair;
        private ToolStripMenuItem mstr5x5Matrix;
        private ToolStripMenuItem mstr6x6Matrix;
        private ToolStripMenuItem mstrRSA;
        private Panel pnlPlayFair5x5;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox tbPF5Input;
        private TextBox tbPF5Key;
        private TableLayoutPanel tlpPF5_KeyMatrix;
        private Label label4;
        private Button btnPF5_Decrypt;
        private Button btnPF5_Encrypt;
        private TextBox tbPF5Result;
        private Panel pnlRSA;
        private Button button1;
        private Button button2;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel pnlPlayFair6x6;
        private Button btnPF6_Decrypt;
        private Button btnPF6_Encrypt;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox tbPF6_Result;
        private TextBox tbPF6_Input;
        private TextBox tbPF6_Key;
        private TableLayoutPanel tlpPF6_KeyMatrix;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox textBox2;
        private Label label12;
        private TextBox textBox1;
        private Button btnRandomKeygen;
        private Button btnKeygenPQ;
        private TextBox textBox3;
        private Label label13;
        private TextBox textBox4;
        private Label label14;
        private Button btnBam;
        private Button btnCopy;
        private Button btnKySo;
        private TextBox textBox11;
        private Label label21;
        private TextBox textBox8;
        private Label label18;
        private TextBox textBox9;
        private Label label19;
        private TextBox textBox10;
        private Label label20;
        private TextBox textBox7;
        private Label label17;
        private TextBox textBox5;
        private Label label15;
        private TextBox textBox6;
        private Label label16;
        private Button button3;
    }
}
