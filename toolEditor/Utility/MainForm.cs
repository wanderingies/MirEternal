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
        }

        private byte EncryptionKey = 129;

        private byte[] EncryptionValue(byte[] data)
        {
            for (int i = 4; i < data.Length; i++)
                data[i] ^= EncryptionKey;

            return data;
        }
    }
}