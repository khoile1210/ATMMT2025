using System.Diagnostics.Eventing.Reader;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;


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
                    MessageBox.Show("Invalid CipherText", "Error");
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

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private BigInteger GCD(BigInteger a, BigInteger b)
        {
            while (b != 0)
            {
                BigInteger temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        private BigInteger ModInverse(BigInteger a, BigInteger m)
        {
            BigInteger m0 = m, t, q;
            BigInteger x0 = 0, x1 = 1;

            if (m == 1) return 0;

            while (a > 1)
            {
                q = a / m;
                t = m;
                m = a % m;
                a = t;
                t = x0;
                x0 = x1 - q * x0;
                x1 = t;
            }

            if (x1 < 0) x1 += m0;

            return x1;
        }

        private bool IsPrime(BigInteger number)
        {
            if (number < 2) return false;
            if (number == 2 || number == 3) return true;
            if (number % 2 == 0) return false;

            for (BigInteger i = 3; i * i <= number; i += 2)
                if (number % i == 0) return false;

            return true;
        }


        private void pnlRSA_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnKeygenPQ_Click(object sender, EventArgs e)
        {
            try
            {

                if (!BigInteger.TryParse(textBox4.Text, out BigInteger p) ||
                    !BigInteger.TryParse(textBox3.Text, out BigInteger q))
                {
                    MessageBox.Show("Vui long nhap dung dinh dang so cho P va Q.");
                    return;
                }

                if (!IsPrime(p) || !IsPrime(q))
                {
                    MessageBox.Show("Ca P va Q phai la so nguyen to!");
                    return;
                }


                BigInteger n = p * q;
                BigInteger phi = (p - 1) * (q - 1);

                BigInteger eVal = 65537;
                if (GCD(eVal, phi) != 1)
                {
                    eVal = 3;
                    while (GCD(eVal, phi) != 1) eVal += 2;
                }

                BigInteger d = ModInverse(eVal, phi);


                textBox2.Text = $"({eVal}, {n})";
                textBox1.Text = $"({d}, {n})";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private bool IsProbablyPrime(BigInteger value, int k)
        {
            if (value <= 1) return false;
            if (value <= 3) return true;
            if (value % 2 == 0) return false;

            BigInteger d = value - 1;
            int s = 0;

            while (d % 2 == 0)
            {
                d /= 2;
                s++;
            }

            RandomNumberGenerator rng = RandomNumberGenerator.Create();
            byte[] bytes = new byte[value.ToByteArray().Length];

            for (int i = 0; i < k; i++)
            {
                BigInteger a;
                do
                {
                    rng.GetBytes(bytes);
                    a = new BigInteger(bytes);
                    a = BigInteger.Abs(a);
                } while (a < 2 || a >= value - 2);

                BigInteger x = BigInteger.ModPow(a, d, value);
                if (x == 1 || x == value - 1)
                    continue;

                bool isComposite = true;
                for (int r = 1; r < s; r++)
                {
                    x = BigInteger.ModPow(x, 2, value);
                    if (x == value - 1)
                    {
                        isComposite = false;
                        break;
                    }
                }

                if (isComposite)
                    return false;
            }

            return true;
        }

        private BigInteger GenerateLargePrime(int bits)
        {
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            byte[] bytes = new byte[bits / 8];
            BigInteger p;

            do
            {
                rng.GetBytes(bytes);


                bytes[bytes.Length - 1] |= 0x80;
                bytes[0] |= 1;

                p = new BigInteger(bytes);
                p = BigInteger.Abs(p);
            } while (!IsProbablyPrime(p, 10));

            return p;
        }


        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                BigInteger p = GenerateLargePrime(512);
                BigInteger q = GenerateLargePrime(512);

                textBox4.Text = p.ToString();
                textBox3.Text = q.ToString();

                BigInteger n = p * q;
                BigInteger phi = (p - 1) * (q - 1);

                BigInteger eVal = 65537;
                if (GCD(eVal, phi) != 1)
                {
                    eVal = 3;
                    while (GCD(eVal, phi) != 1) eVal += 2;
                }

                BigInteger d = ModInverse(eVal, phi);


                textBox2.Text = $"({eVal}, {n})";
                textBox1.Text = $"({d}, {n})";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi khi tao khoa: " + ex.Message);
            }
        }

        byte[] GetUnsignedBytes(BigInteger bigInt)
        {
            byte[] temp = bigInt.ToByteArray();
            if (temp[temp.Length - 1] == 0)
            {
                Array.Resize(ref temp, temp.Length - 1);
            }
            Array.Reverse(temp);
            return temp;
        }


        (bool success, BigInteger a, BigInteger b) ParseKeyPair(string s)
        {
            s = s.Trim();
            if (!s.StartsWith("(") || !s.EndsWith(")")) return (false, 0, 0);
            s = s.Substring(1, s.Length - 2);
            var parts = s.Split(',');
            if (parts.Length != 2) return (false, 0, 0);

            if (BigInteger.TryParse(parts[0].Trim(), out BigInteger a) && BigInteger.TryParse(parts[1].Trim(), out BigInteger b))
            {
                return (true, a, b);
            }
            return (false, 0, 0);
        }


        private void btnKySo_Click(object sender, EventArgs e)
        {
            string originalText = textBox6.Text.Trim();
            if (string.IsNullOrEmpty(originalText))
            {
                MessageBox.Show("Vui long nhap van ban goc");
                return;
            }

            byte[] dataBytes = Encoding.UTF8.GetBytes(originalText);
            byte[] hashBytes;
            using (SHA256 sha256 = SHA256.Create())
            {
                hashBytes = sha256.ComputeHash(dataBytes);
            }

            StringBuilder sb = new StringBuilder();
            foreach (byte b in hashBytes)
            {
                sb.Append(b.ToString("x2"));
            }
            textBox5.Text = sb.ToString();

            var priv = ParseKeyPair(textBox1.Text);
            if (!priv.success)
            {
                MessageBox.Show("Dinh dang Private Key khong hop le!");
                return;
            }

            BigInteger d = priv.a;
            BigInteger n = priv.b;

            if (!BigInteger.TryParse(textBox4.Text.Trim(), out BigInteger p) ||
                !BigInteger.TryParse(textBox3.Text.Trim(), out BigInteger q))
            {
                MessageBox.Show("Vui long nhap dung P va Q!");
                return;
            }

            BigInteger eVal = 65537;
            string[] pubParts = textBox2.Text.Split(',');
            if (pubParts.Length > 0 && BigInteger.TryParse(pubParts[0].Trim('(', ' '), out BigInteger eParsed))
                eVal = eParsed;

            BigInteger dp = d % (p - 1);
            BigInteger dq = d % (q - 1);
            BigInteger inverseQ = ModInverse(q, p);  // thay vì q^(p-2) mod p

            RSAParameters rsaParams = new RSAParameters
            {
                Modulus = GetUnsignedBytes(n),
                Exponent = GetUnsignedBytes(eVal),
                D = GetUnsignedBytes(d),
                P = GetUnsignedBytes(p),
                Q = GetUnsignedBytes(q),
                DP = GetUnsignedBytes(dp),
                DQ = GetUnsignedBytes(dq),
                InverseQ = GetUnsignedBytes(inverseQ)
            };

            try
            {
                using (RSA rsa = RSA.Create())
                {
                    rsa.ImportParameters(rsaParams);
                    byte[] signatureBytes = rsa.SignHash(hashBytes, HashAlgorithmName.SHA256, RSASignaturePadding.Pkcs1);
                    textBox7.Text = Convert.ToBase64String(signatureBytes);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi khi ky so: " + ex.Message);
            }
        }
        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox7.Text))
            {
                Clipboard.SetText(textBox7.Text);
                MessageBox.Show("Copied!");
            }
            else
            {
                MessageBox.Show("Chua co chu ky so de copy!");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string originalText = textBox10.Text.Trim();
            if (string.IsNullOrEmpty(originalText))
            {
                MessageBox.Show("Vui long nhap van ban can xac minh");
                return;
            }

            byte[] dataBytes = Encoding.UTF8.GetBytes(originalText);
            byte[] hashBytes;
            using (SHA256 sha256 = SHA256.Create())
            {
                hashBytes = sha256.ComputeHash(dataBytes);
            }

            StringBuilder sb = new StringBuilder();
            foreach (byte b in hashBytes)
            {
                sb.Append(b.ToString("x2"));
            }
            textBox9.Text = sb.ToString();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            string publicKeyText = textBox2.Text.Trim();
            string hashHex = textBox9.Text.Trim().Replace(" ", "").ToLower();
            string signatureBase64 = textBox8.Text.Trim();

            if (string.IsNullOrEmpty(publicKeyText) || string.IsNullOrEmpty(hashHex) || string.IsNullOrEmpty(signatureBase64))
            {
                MessageBox.Show("Vui long nhap du khoa cong khai, hash SHA-256 va chu ky so!");
                return;
            }

            publicKeyText = publicKeyText.Replace("(", "").Replace(")", "");
            var parts = publicKeyText.Split(',');
            BigInteger eVal = BigInteger.Parse(parts[0].Trim());
            BigInteger n = BigInteger.Parse(parts[1].Trim());

            byte[] GetUnsignedBytes(BigInteger bigInt)
            {
                byte[] temp = bigInt.ToByteArray();
                if (temp[temp.Length - 1] == 0)
                    Array.Resize(ref temp, temp.Length - 1);
                Array.Reverse(temp);
                return temp;
            }

            byte[] HexStringToBytes(string hex)
            {
                if (hex.Length % 2 != 0)
                    hex = "0" + hex;

                byte[] bytes = new byte[hex.Length / 2];
                for (int i = 0; i < bytes.Length; i++)
                    bytes[i] = Convert.ToByte(hex.Substring(i * 2, 2), 16);
                return bytes;
            }

            string BytesToHexString(byte[] bytes)
            {
                StringBuilder sb = new StringBuilder();
                foreach (var b in bytes)
                    sb.Append(b.ToString("x2"));
                return sb.ToString();
            }

            try
            {
                byte[] signatureBytes = Convert.FromBase64String(signatureBase64);
                BigInteger sigInt = new BigInteger(signatureBytes.Reverse().Concat(new byte[] { 0 }).ToArray());
                BigInteger decryptedInt = BigInteger.ModPow(sigInt, eVal, n);

                byte[] decryptedBytes = decryptedInt.ToByteArray();
                if (decryptedBytes[decryptedBytes.Length - 1] == 0)
                    Array.Resize(ref decryptedBytes, decryptedBytes.Length - 1);
                Array.Reverse(decryptedBytes);

                textBox11.Text = BytesToHexString(decryptedBytes);

                byte[] expectedHash = HexStringToBytes(hashHex);

                if (decryptedBytes.Length > expectedHash.Length)
                {
                    byte[] extractedHash = decryptedBytes[^expectedHash.Length..];

                    if (extractedHash.SequenceEqual(expectedHash))
                    {
                        MessageBox.Show("Chu ky toan ven.");
                    }
                    else
                    {
                        MessageBox.Show("Chu ky khong hop le hoac da bi thay doi.");
                    }
                }
                else
                {
                    MessageBox.Show("Du lieu giai ma qua ngan khong chua du SHA-256.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi trong qua trinh giai ma: " + ex.Message);
            }
        }
    }
}

