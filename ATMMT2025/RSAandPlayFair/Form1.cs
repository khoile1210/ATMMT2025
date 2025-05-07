using System.Diagnostics.Eventing.Reader;

namespace RSAandPlayFair
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mstrRSA_Click(object sender, EventArgs e)
        {
            pnlRSA.Visible = true;
            pnlPlayFair5x5.Visible = false;
            pnlPlayFair6x6.Visible = false;
            mstrRSA.BackColor = Color.LightGray;
            mstrPlayFair.BackColor = Color.Transparent;
            mstr5x5Matrix.BackColor = Color.Transparent;
            mstr6x6Matrix.BackColor = Color.Transparent;
        }

        private void mstr5x5Matrix_Click(object sender, EventArgs e)
        {
            pnlPlayFair5x5.Visible = true;
            pnlPlayFair6x6.Visible = false;
            pnlRSA.Visible = false;
            mstrPlayFair.BackColor = Color.LightGray;
            mstr5x5Matrix.BackColor = Color.LightGray;
            mstrRSA.BackColor = Color.Transparent;
            mstr6x6Matrix.BackColor = Color.Transparent;
        }

        private void mstr6x6Matrix_Click(object sender, EventArgs e)
        {
            pnlPlayFair6x6.Visible = true;
            pnlPlayFair5x5.Visible = false;
            pnlRSA.Visible = false;
            mstrPlayFair.BackColor = Color.LightGray;
            mstr6x6Matrix.BackColor = Color.LightGray;
            mstr5x5Matrix.BackColor = Color.Transparent;
            mstrRSA.BackColor = Color.Transparent;
        }

        private void btnPF5_Encrypt_Click_1(object sender, EventArgs e)
        {
            tlpPF5_KeyMatrix.Controls.Clear();
            tbPF5Key.Text = tbPF5Key.Text.ToUpper();

            List<Control> but = new List<Control>();
            List<char> chars = new List<char>();
            int[] pos = new int[26];
            bool[] used = new bool[26];
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string rs = "";
            string inputStr = tbPF5Input.Text.ToUpper();
            string content = "";

            foreach (var i in inputStr)
            {
                if (i >= 'A' && i <= 'Z') content += i;
            }

            int lContent = content.Length;

            foreach (var i in tbPF5Key.Text)
            {
                if (used[i - 65] == false)
                {
                    chars.Add(i);
                    if (i == 'I' || i == 'J')
                    {
                        used['I' - 65] = true;
                        used['J' - 65] = true;
                    }
                    used[i - 65] = true;
                }
            }

            foreach (var i in alphabet)
            {
                if (used[i - 65] == false)
                {
                    chars.Add(i);
                    if (i == 'I' || i == 'J')
                    {
                        used['I' - 65] = true;
                        used['J' - 65] = true;
                    }
                    used[i - 65] = true;
                }
            }

            for (int i = 0; i < 25; i++)
            {
                pos[chars[i] - 65] = i;
            }

            foreach (var i in chars)
            {
                //tlpKeyMatrix.Controls.Add(new TextBox());

                //tbContent.Text += DateTime.Now.ToShortTimeString();
                //tlpKeyMatrix.Controls.Add(new Button() { Text = i.ToString(),
                //    Size = new Size { Height = tlpKeyMatrix.Height / 5,
                //        Width = tlpKeyMatrix.Width / 5 } });

                but.Add(new Button()
                {
                    Text = i.ToString(),
                    Size = new Size
                    {
                        Height = tlpPF5_KeyMatrix.Height / 5,
                        Width = tlpPF5_KeyMatrix.Width / 5
                    }
                });
            }
            tlpPF5_KeyMatrix.Controls.AddRange(but.ToArray());

            for (int i = 0; i < lContent; i += 2)
            {
                int j = i + 1;
                int xi, yi, xj, yj;
                char fi, fj, rsi, rsj;
                bool duplicate = false;
                fi = content[i];
                try
                {
                    fj = content[j];
                }
                catch
                {
                    if (fi == 'X')
                        fj = 'Y';
                    else fj = 'X';
                }


                if (fi == fj)
                {
                    duplicate = true;
                    if (fi == 'X')
                        fj = 'Y';
                    else fj = 'X';
                }
                xi = pos[fi - 65] % 5;
                yi = pos[fi - 65] / 5;
                xj = pos[fj - 65] % 5;
                yj = pos[fj - 65] / 5;



                if (xi == xj)
                {
                    yi = (yi + 1) % 5;
                    yj = (yj + 1) % 5;
                }
                else if (yi == yj)
                {
                    xi = (xi + 1) % 5;
                    xj = (xj + 1) % 5;
                }
                else
                {
                    int temp = xi;
                    xi = xj;
                    xj = temp;
                }

                rsi = chars[yi * 5 + xi];
                rsj = chars[yj * 5 + xj];

                rs += rsi;
                rs += rsj;
                if (duplicate)
                {
                    rs += rsi;
                    rs += rsj;
                }
            }
            tbPF5Result.Text = rs.ToString();
        }

        private void btnPF5_Decrypt_Click_1(object sender, EventArgs e)
        {
            tlpPF5_KeyMatrix.Controls.Clear();
            tbPF5Key.Text = tbPF5Key.Text.ToUpper();

            List<Control> but = new List<Control>();
            List<char> chars = new List<char>();
            int[] pos = new int[26];
            bool[] used = new bool[26];
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string rs = "";
            string inputStr = tbPF5Input.Text.ToUpper();
            string content = "";

            foreach (var i in inputStr)
            {
                if (i >= 'A' && i <= 'Z') content += i;
            }
            int lContent = content.Length;

            foreach (var i in tbPF5Key.Text)
            {
                if (used[i - 65] == false)
                {
                    chars.Add(i);
                    if (i == 'I' || i == 'J')
                    {
                        used['I' - 65] = true;
                        used['J' - 65] = true;
                    }
                    used[i - 65] = true;
                }
            }

            foreach (var i in alphabet)
            {
                if (used[i - 65] == false)
                {
                    chars.Add(i);
                    if (i == 'I' || i == 'J')
                    {
                        used['I' - 65] = true;
                        used['J' - 65] = true;
                    }
                    used[i - 65] = true;
                }
            }

            for (int i = 0; i < 25; i++)
            {
                pos[chars[i] - 65] = i;
            }

            foreach (var i in chars)
            {
                but.Add(new Button()
                {
                    Text = i.ToString(),
                    Size = new Size
                    {
                        Height = tlpPF5_KeyMatrix.Height / 5,
                        Width = tlpPF5_KeyMatrix.Width / 5
                    }
                });
            }
            tlpPF5_KeyMatrix.Controls.AddRange(but.ToArray());

            for (int i = 0; i < lContent; i += 2)
            {
                int j = i + 1;
                int xi, yi, xj, yj;
                char fi, fj, rsi, rsj;
                try
                {
                    fi = content[i];
                    fj = content[j];
                }
                catch
                {
                    MessageBox.Show("In valid CipherText", "Error");
                    return;
                }

                xi = pos[fi - 65] % 5;
                yi = pos[fi - 65] / 5;
                xj = pos[fj - 65] % 5;
                yj = pos[fj - 65] / 5;

                if (xi == xj)
                {
                    yi = (5 + yi - 1) % 5;
                    yj = (5 + yj - 1) % 5;
                }
                else if (yi == yj)
                {
                    xi = (5 + xi - 1) % 5;
                    xj = (5 + xj - 1) % 5;
                }
                else
                {
                    int temp = xi;
                    xi = xj;
                    xj = temp;
                }

                rsi = chars[yi * 5 + xi];
                rsj = chars[yj * 5 + xj];

                rs += rsi;
                rs += rsj;

            }
            tbPF5Result.Text = rs.ToString();
        }

        private void btnPF6_Encrypt_Click(object sender, EventArgs e)
        {
            tlpPF6_KeyMatrix.Controls.Clear();
            tbPF6_Key.Text = tbPF6_Key.Text.ToUpper();

            List<Control> but = new List<Control>();
            List<char> chars = new List<char>();
            int[] pos = new int[36];
            bool[] used = new bool[36];
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            string rs = "";
            string inputStr = tbPF6_Input.Text.ToUpper();
            string content = "";

            foreach (var i in inputStr)
            {
                if (alphabet.Contains(i)) content += i;
                //if ((i >= 'A' && i <= 'Z')) content += i;
            }
            int lContent = content.Length;

            foreach (var i in tbPF6_Key.Text)
            {   
                if (i >= '0' && i <= '9')
                {
                    if (used[i -22] == false)
                    {
                        chars.Add(i);
                        used[i -22] = true;
                    }
                }
                else
                {
                    if (used[i - 65] == false)
                    {
                        chars.Add(i);
                        used[i - 65] = true;
                    }
                }
            }

            foreach (var i in alphabet)
            {
                if (i >= '0' && i <= '9')
                {
                    if (used[i - 22] == false)
                    {
                        chars.Add(i);
                        used[i - 22] = true;
                    }
                }
                else
                {
                    if (used[i - 65] == false)
                    {
                        chars.Add(i);
                        used[i - 65] = true;
                    }
                }
                
            }

            for (int i = 0; i < 36; i++)
            {
                if (chars[i] >= '0' && chars[i] <= '9')
                    pos[chars[i] - 22] = i;
                else
                    pos[chars[i] - 65] = i;
            }

            foreach (var i in chars)
            {
                but.Add(new Button()
                {
                    Text = i.ToString(),
                    Size = new Size
                    {
                        Height = tlpPF5_KeyMatrix.Height / 6,
                        Width = tlpPF5_KeyMatrix.Width / 6
                    }
                });
            }
            tlpPF6_KeyMatrix.Controls.AddRange(but.ToArray());

            for (int i = 0; i < lContent; i += 2)
            {
                int j = i + 1;
                int xi, yi, xj, yj;
                char fi, fj, rsi, rsj;
                bool duplicate = false;
                fi = content[i];
                try
                {
                    fj = content[j];
                }
                catch
                {
                    if (fi == 'X')
                        fj = 'Y';
                    else fj = 'X';
                }

                if (fi == fj)
                {
                    duplicate = true;
                    if (fi == 'X')
                        fj = 'Y';
                    else fj = 'X';
                }
                if (fi >= 'A' && fi <= 'Z')
                {
                    xi = pos[fi - 65] % 6;
                    yi = pos[fi - 65] / 6;
                }
                else
                {
                    xi = pos[fi -22] % 6;
                    yi = pos[fi -22] / 6;
                }

                if (fj >= 'A' && fj <= 'Z')
                {
                    xj = pos[fj - 65] % 6;
                    yj = pos[fj - 65] / 6;
                }
                else
                {
                    xj = pos[fj -22] % 6;
                    yj = pos[fj -22] / 6;
                }


                if (xi == xj)
                {
                    yi = (yi + 1) % 6;
                    yj = (yj + 1) % 6;
                }
                else if (yi == yj)
                {
                    xi = (xi + 1) % 6;
                    xj = (xj + 1) % 6;
                }
                else
                {
                    int temp = xi;
                    xi = xj;
                    xj = temp;
                }

                rsi = chars[yi * 6 + xi];
                rsj = chars[yj * 6 + xj];

                rs += rsi;
                rs += rsj;
                if (duplicate)
                {
                    rs += rsi;
                    rs += rsj;
                }
            }
            tbPF6_Result.Text = rs.ToString();
        }

        private void btnPF6_Decrypt_Click(object sender, EventArgs e)
        {
            tlpPF6_KeyMatrix.Controls.Clear();
            tbPF6_Key.Text = tbPF6_Key.Text.ToUpper();

            List<Control> but = new List<Control>();
            List<char> chars = new List<char>();
            int[] pos = new int[36];
            bool[] used = new bool[36];
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            string rs = "";
            string inputStr = tbPF6_Input.Text.ToUpper();
            string content = "";

            foreach (var i in inputStr)
            {
                if (alphabet.Contains(i)) content += i;
            }
            int lContent = content.Length;


            foreach (var i in tbPF6_Key.Text)
            {
                if (i >= '0' && i <= '9')
                {
                    if (used[i - 22] == false)
                    {
                        chars.Add(i);
                        used[i - 22] = true;
                    }
                }
                else
                {
                    if (used[i - 65] == false)
                    {
                        chars.Add(i);
                        used[i - 65] = true;
                    }
                }
            }

            foreach (var i in alphabet)
            {
                if (i >= '0' && i <= '9')
                {
                    if (used[i - 22] == false)
                    {
                        chars.Add(i);
                        used[i - 22] = true;
                    }
                }
                else
                {
                    if (used[i - 65] == false)
                    {
                        chars.Add(i);
                        used[i - 65] = true;
                    }
                }

            }

            for (int i = 0; i < 36; i++)
            {
                if (chars[i] >= '0' && chars[i] <= '9')
                    pos[chars[i] - 22] = i;
                else
                    pos[chars[i] - 65] = i;
            }

            foreach (var i in chars)
            {
                but.Add(new Button()
                {
                    Text = i.ToString(),
                    Size = new Size
                    {
                        Height = tlpPF5_KeyMatrix.Height / 6,
                        Width = tlpPF5_KeyMatrix.Width / 6
                    }
                });
            }
            tlpPF6_KeyMatrix.Controls.AddRange(but.ToArray());

            for (int i = 0; i < lContent; i += 2)
            {
                int j = i + 1;
                int xi, yi, xj, yj;
                char fi, fj, rsi, rsj;
                try
                {
                    fi = content[i];
                    fj = content[j];
                }
                catch
                {
                    MessageBox.Show("In valid CipherText", "Error");
                    return;
                }

                if (fi >= 'A' && fi <= 'Z')
                {
                    xi = pos[fi - 65] % 6;
                    yi = pos[fi - 65] / 6;
                }
                else
                {
                    xi = pos[fi - 22] % 6;
                    yi = pos[fi - 22] / 6;
                }

                if (fj >= 'A' && fj <= 'Z')
                {
                    xj = pos[fj - 65] % 6;
                    yj = pos[fj - 65] / 6;
                }
                else
                {
                    xj = pos[fj - 22] % 6;
                    yj = pos[fj - 22] / 6;
                }

                if (xi == xj)
                {
                    yi = (6 + yi - 1) % 6;
                    yj = (6 + yj - 1) % 6;
                }
                else if (yi == yj)
                {
                    xi = (6 + xi - 1) % 6;
                    xj = (6 + xj - 1) % 6;
                }
                else
                {
                    int temp = xi;
                    xi = xj;
                    xj = temp;
                }

                rsi = chars[yi * 6 + xi];
                rsj = chars[yj * 6 + xj];

                rs += rsi;
                rs += rsj;

            }
            tbPF6_Result.Text = rs.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
