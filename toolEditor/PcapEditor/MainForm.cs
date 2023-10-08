using Microsoft.VisualBasic;
using PcapEditor.Windows.Forms;
using System.Windows.Forms;

namespace PcapEditor
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            m_toolStripMenuItem_open.Click += (s, e) =>
            {
                OpenFileDialog ofd = new OpenFileDialog();
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    var fileName = ofd.FileName;
                    DynamicFileByteProvider dynamicFileByteProvider;
                    try
                    {
                        // try to open in write mode
                        dynamicFileByteProvider = new DynamicFileByteProvider(fileName);
                        hexBox.ByteProvider = dynamicFileByteProvider;
                        //dynamicFileByteProvider.Changed += new EventHandler(byteProvider_Changed);
                        //dynamicFileByteProvider.LengthChanged += new EventHandler(byteProvider_LengthChanged);
                    }
                    catch (IOException) // write mode failed
                    {
                        /*try
                        {
                            // try to open in read-only mode
                            dynamicFileByteProvider = new DynamicFileByteProvider(fileName, true);
                            if (Program.ShowQuestion(strings.OpenReadonly) == DialogResult.No)
                            {
                                dynamicFileByteProvider.Dispose();
                                return;
                            }
                        }
                        catch (IOException) // read-only also failed
                        {
                            // file cannot be opened
                            Program.ShowError(strings.OpenFailed);
                            return;
                        }*/
                    }
                }
            };
        }
    }
}