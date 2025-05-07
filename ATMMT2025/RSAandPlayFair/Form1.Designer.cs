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
            pnlRSA = new Panel();
            label11 = new Label();
            button1 = new Button();
            button2 = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            menuStrip1.SuspendLayout();
            pnlPlayFair5x5.SuspendLayout();
            pnlPlayFair6x6.SuspendLayout();
            pnlRSA.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mstrPlayFair, mstrRSA });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(873, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // mstrPlayFair
            // 
            mstrPlayFair.DropDownItems.AddRange(new ToolStripItem[] { mstr5x5Matrix, mstr6x6Matrix });
            mstrPlayFair.Name = "mstrPlayFair";
            mstrPlayFair.Size = new Size(92, 29);
            mstrPlayFair.Text = "Play Fair";
            // 
            // mstr5x5Matrix
            // 
            mstr5x5Matrix.Name = "mstr5x5Matrix";
            mstr5x5Matrix.Size = new Size(270, 34);
            mstr5x5Matrix.Text = "5x5 Matrix";
            mstr5x5Matrix.Click += mstr5x5Matrix_Click;
            // 
            // mstr6x6Matrix
            // 
            mstr6x6Matrix.Name = "mstr6x6Matrix";
            mstr6x6Matrix.Size = new Size(270, 34);
            mstr6x6Matrix.Text = "6x6 Matrix";
            mstr6x6Matrix.Click += mstr6x6Matrix_Click;
            // 
            // mstrRSA
            // 
            mstrRSA.Name = "mstrRSA";
            mstrRSA.Size = new Size(61, 29);
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
            pnlPlayFair5x5.Location = new Point(13, 39);
            pnlPlayFair5x5.Name = "pnlPlayFair5x5";
            pnlPlayFair5x5.Size = new Size(848, 526);
            pnlPlayFair5x5.TabIndex = 1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Elephant", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(575, 12);
            label10.Name = "label10";
            label10.Size = new Size(221, 37);
            label10.TabIndex = 8;
            label10.Text = "Play Fair 5x5";
            // 
            // btnPF5_Decrypt
            // 
            btnPF5_Decrypt.Location = new Point(675, 466);
            btnPF5_Decrypt.Name = "btnPF5_Decrypt";
            btnPF5_Decrypt.Size = new Size(173, 52);
            btnPF5_Decrypt.TabIndex = 6;
            btnPF5_Decrypt.Text = "Decrypt";
            btnPF5_Decrypt.UseVisualStyleBackColor = true;
            btnPF5_Decrypt.Click += btnPF5_Decrypt_Click_1;
            // 
            // btnPF5_Encrypt
            // 
            btnPF5_Encrypt.Location = new Point(485, 466);
            btnPF5_Encrypt.Name = "btnPF5_Encrypt";
            btnPF5_Encrypt.Size = new Size(173, 52);
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
            tlpPF5_KeyMatrix.Location = new Point(488, 77);
            tlpPF5_KeyMatrix.Name = "tlpPF5_KeyMatrix";
            tlpPF5_KeyMatrix.RowCount = 5;
            tlpPF5_KeyMatrix.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpPF5_KeyMatrix.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpPF5_KeyMatrix.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpPF5_KeyMatrix.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpPF5_KeyMatrix.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpPF5_KeyMatrix.Size = new Size(360, 360);
            tlpPF5_KeyMatrix.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 285);
            label3.Name = "label3";
            label3.Size = new Size(63, 25);
            label3.TabIndex = 4;
            label3.Text = "Result:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(485, 49);
            label4.Name = "label4";
            label4.Size = new Size(98, 25);
            label4.TabIndex = 3;
            label4.Text = "Key Matrix:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 49);
            label2.Name = "label2";
            label2.Size = new Size(58, 25);
            label2.TabIndex = 3;
            label2.Text = "Input:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 12);
            label1.Name = "label1";
            label1.Size = new Size(49, 25);
            label1.TabIndex = 2;
            label1.Text = "Key: ";
            // 
            // tbPF5Result
            // 
            tbPF5Result.Location = new Point(3, 313);
            tbPF5Result.Multiline = true;
            tbPF5Result.Name = "tbPF5Result";
            tbPF5Result.Size = new Size(463, 205);
            tbPF5Result.TabIndex = 1;
            // 
            // tbPF5Input
            // 
            tbPF5Input.Location = new Point(3, 77);
            tbPF5Input.Multiline = true;
            tbPF5Input.Name = "tbPF5Input";
            tbPF5Input.Size = new Size(463, 205);
            tbPF5Input.TabIndex = 1;
            // 
            // tbPF5Key
            // 
            tbPF5Key.Location = new Point(48, 12);
            tbPF5Key.Name = "tbPF5Key";
            tbPF5Key.Size = new Size(418, 31);
            tbPF5Key.TabIndex = 0;
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
            pnlPlayFair6x6.Location = new Point(13, 39);
            pnlPlayFair6x6.Name = "pnlPlayFair6x6";
            pnlPlayFair6x6.Size = new Size(849, 526);
            pnlPlayFair6x6.TabIndex = 1;
            pnlPlayFair6x6.Visible = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Elephant", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(575, 12);
            label9.Name = "label9";
            label9.Size = new Size(223, 37);
            label9.TabIndex = 8;
            label9.Text = "Play Fair 6x6";
            // 
            // tlpPF6_KeyMatrix
            // 
            tlpPF6_KeyMatrix.BackColor = SystemColors.ActiveCaption;
            tlpPF6_KeyMatrix.ColumnCount = 6;
            tlpPF6_KeyMatrix.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            tlpPF6_KeyMatrix.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            tlpPF6_KeyMatrix.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            tlpPF6_KeyMatrix.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            tlpPF6_KeyMatrix.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            tlpPF6_KeyMatrix.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            tlpPF6_KeyMatrix.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tlpPF6_KeyMatrix.ForeColor = SystemColors.ActiveCaptionText;
            tlpPF6_KeyMatrix.Location = new Point(489, 77);
            tlpPF6_KeyMatrix.Name = "tlpPF6_KeyMatrix";
            tlpPF6_KeyMatrix.RowCount = 6;
            tlpPF6_KeyMatrix.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tlpPF6_KeyMatrix.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tlpPF6_KeyMatrix.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tlpPF6_KeyMatrix.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tlpPF6_KeyMatrix.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tlpPF6_KeyMatrix.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tlpPF6_KeyMatrix.Size = new Size(360, 360);
            tlpPF6_KeyMatrix.TabIndex = 7;
            // 
            // btnPF6_Decrypt
            // 
            btnPF6_Decrypt.Location = new Point(675, 466);
            btnPF6_Decrypt.Name = "btnPF6_Decrypt";
            btnPF6_Decrypt.Size = new Size(173, 52);
            btnPF6_Decrypt.TabIndex = 6;
            btnPF6_Decrypt.Text = "Decrypt";
            btnPF6_Decrypt.UseVisualStyleBackColor = true;
            btnPF6_Decrypt.Click += btnPF6_Decrypt_Click;
            // 
            // btnPF6_Encrypt
            // 
            btnPF6_Encrypt.Location = new Point(485, 466);
            btnPF6_Encrypt.Name = "btnPF6_Encrypt";
            btnPF6_Encrypt.Size = new Size(173, 52);
            btnPF6_Encrypt.TabIndex = 6;
            btnPF6_Encrypt.Text = "Encrypt";
            btnPF6_Encrypt.UseVisualStyleBackColor = true;
            btnPF6_Encrypt.Click += btnPF6_Encrypt_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 285);
            label5.Name = "label5";
            label5.Size = new Size(63, 25);
            label5.TabIndex = 4;
            label5.Text = "Result:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(485, 49);
            label6.Name = "label6";
            label6.Size = new Size(98, 25);
            label6.TabIndex = 3;
            label6.Text = "Key Matrix:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 49);
            label7.Name = "label7";
            label7.Size = new Size(58, 25);
            label7.TabIndex = 3;
            label7.Text = "Input:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(3, 12);
            label8.Name = "label8";
            label8.Size = new Size(49, 25);
            label8.TabIndex = 2;
            label8.Text = "Key: ";
            // 
            // tbPF6_Result
            // 
            tbPF6_Result.Location = new Point(3, 313);
            tbPF6_Result.Multiline = true;
            tbPF6_Result.Name = "tbPF6_Result";
            tbPF6_Result.Size = new Size(463, 205);
            tbPF6_Result.TabIndex = 1;
            // 
            // tbPF6_Input
            // 
            tbPF6_Input.Location = new Point(3, 77);
            tbPF6_Input.Multiline = true;
            tbPF6_Input.Name = "tbPF6_Input";
            tbPF6_Input.Size = new Size(463, 205);
            tbPF6_Input.TabIndex = 1;
            // 
            // tbPF6_Key
            // 
            tbPF6_Key.Location = new Point(48, 12);
            tbPF6_Key.Name = "tbPF6_Key";
            tbPF6_Key.Size = new Size(418, 31);
            tbPF6_Key.TabIndex = 0;
            // 
            // pnlRSA
            // 
            pnlRSA.Controls.Add(label11);
            pnlRSA.Location = new Point(13, 39);
            pnlRSA.Name = "pnlRSA";
            pnlRSA.Size = new Size(847, 529);
            pnlRSA.TabIndex = 0;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(401, 185);
            label11.Name = "label11";
            label11.Size = new Size(45, 25);
            label11.TabIndex = 0;
            label11.Text = "RSA";
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
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(873, 577);
            Controls.Add(menuStrip1);
            Controls.Add(pnlPlayFair5x5);
            Controls.Add(pnlPlayFair6x6);
            Controls.Add(pnlRSA);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "ATMMT2025";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            pnlPlayFair5x5.ResumeLayout(false);
            pnlPlayFair5x5.PerformLayout();
            pnlPlayFair6x6.ResumeLayout(false);
            pnlPlayFair6x6.PerformLayout();
            pnlRSA.ResumeLayout(false);
            pnlRSA.PerformLayout();
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
    }
}
