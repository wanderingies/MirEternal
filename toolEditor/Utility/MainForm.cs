using System.Text;

namespace Utility
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            m_button1.Click += (s, e) =>
            {
                if (intextBox.Text != string.Empty)
                {
                    var value = intextBox.Text;
                    byte[] buffer = new byte[value.Length / 2];
                    for (int i = 0; i < buffer.Length; i++)
                        buffer[i] = Convert.ToByte(value.Substring(i * 2, 2).Trim(), 16);

                    var result = EncryptionValue(buffer);
                    StringBuilder strBuider = new StringBuilder();
                    for (int index = 0; index < result.Length; index++)
                        strBuider.Append(((int)result[index]).ToString("X2"));

                    outextBox.Text = strBuider.ToString();
                }
            };

            inbutton1.Click += (s, e) =>
            {
                OpenFileDialog dialog = new OpenFileDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                    textBox3.Text = dialog.FileName;
            };

            oubutton1.Click += (s, e) =>
            {
                SaveFileDialog dialog = new SaveFileDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                    textBox4.Text = dialog.FileName;
            };

            m_button3.Click += (s, e) =>
            {
                if (textBox6.Text == string.Empty)
                    return;

                if (oufoldertBox.Text == string.Empty)
                    return;

                var files = Directory.GetFiles(textBox6.Text, "*.*", SearchOption.AllDirectories);
                foreach (var file in files)
                {
                    FileInfo fileInfo = new FileInfo(file);

                    var buffer = File.ReadAllBytes(fileInfo.FullName);
                    var result = Crypto.Decrypt(buffer);

                    var path = fileInfo.DirectoryName.Replace(textBox6.Text, oufoldertBox.Text);
                    if (!Directory.Exists(path))
                        Directory.CreateDirectory(path);

                    var fPath = Path.Combine(path, fileInfo.Name);
                    File.WriteAllBytes(fPath, result);
                }
            };
        }

        private byte EncryptionKey = 129;

        private byte[] EncryptionValue(byte[] data)
        {
            for (int i = 4; i < data.Length; i++)
                data[i] ^= EncryptionKey;

            return data;
        }

        public static Point 点阵坐标转协议坐标(Point location)
        {
            return new Point(location.X * 32 - 16, location.Y * 32 - 16);
        }


        public static Point 协议坐标转点阵坐标(Point location)
        {
            return new Point((int)Math.Round((double)((location.X + 16f) / 32f)), (int)Math.Round((double)((location.Y + 16f) / 32f)));
        }


        public static Point 游戏坐标转本地(PointF 游戏坐标)
        {
            PointF pointF = default(PointF);
            pointF.Y = (游戏坐标.X + 游戏坐标.Y) / 0.707107f / 0.000976562f / 2f / 4096f;
            pointF.X = (游戏坐标.X / 0.707107f / 0.000976562f + 134217730f) / 4096f - pointF.Y;
            return new Point((int)((double)(pointF.X / 32f) + 0.5), (int)((double)(pointF.Y / 32f) + 0.5));
        }


        public static PointF 本地转游戏坐标(Point location)
        {
            PointF pointF = new PointF((location.X - 0.5f) * 32f, (location.Y - 0.5f) * 32f);
            return new PointF
            {
                X = ((pointF.Y + pointF.X) * 4096f - 134217730f) * 0.707107f * 0.000976562f,
                Y = ((pointF.Y - pointF.X) * 4096f + 134217730f) * 0.707107f * 0.000976562f
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var point = new Point(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
            textBox7.Text = $"{点阵坐标转协议坐标(point)}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var point = new Point(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
            textBox7.Text = $"{协议坐标转点阵坐标(point)}";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var point = new PointF(float.Parse(textBox1.Text), float.Parse(textBox2.Text));
            textBox7.Text = $"{游戏坐标转本地(point)}";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var point = new Point(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
            textBox7.Text = $"{本地转游戏坐标(point)}";
        }
    }
}