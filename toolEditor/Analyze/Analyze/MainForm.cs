using SharpPcap;
using SharpPcap.LibPcap;
using System.Text;

namespace Analyze
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            conditionRegular.Enabled = false;
            conditionAdd.Click += (s, e) =>
            {
                if (conditionAdd.Checked)
                {
                    conditionOther.Enabled = true;
                    conditionRegular.Enabled = true;
                }
                else
                {
                    conditionOther.Enabled = false;
                    conditionRegular.Enabled = false;
                    conditionRegular.Checked = false;
                }
            };

            conditionRegular.Click += (s, e) =>
            {
            };

            toolStripButtonStart.Click += (s, e) =>
            {
                if (currentDevice != null && currentDevice.Opened)
                {
                    currentDevice.StartCapture();
                    toolStripButtonStart.Checked = true;
                    toolStripButtonStart.Enabled = false;
                    toolStripButtonStop.Enabled = true;
                }
                else
                {
                    MessageBox.Show("先通过菜单<捕获>下选择将要捕获的设备", "错误");
                }
            };

            toolStripButtonPause.Enabled = false;
            toolStripButtonPause.Click += (s, e) =>
            {
                //if (currentDevice != null)
                //    currentDevice.StopCapture();
            };

            toolStripButtonStop.Enabled = false;
            toolStripButtonStop.Click += (s, e) =>
            {
                if (currentDevice != null && currentDevice.Opened)
                {
                    currentDevice.StopCapture();
                    toolStripButtonStart.Checked = false;
                    toolStripButtonStart.Enabled = true;
                    toolStripButtonStop.Enabled = false;
                }
                else
                {
                    MessageBox.Show("先通过菜单<捕获>下选择将要捕获的设备\n并已经开始捕获", "错误");
                }
            };

            listBoxData.SelectedIndexChanged += (s, e) =>
            {
                if (listBoxData.SelectedIndex > 0)
                {
                    var buffer = RawCaptures[listBoxData.SelectedIndex].Data;
                    StringBuilder strBuider = new StringBuilder();
                    for (int index = 0; index < buffer.Length; index++)
                        strBuider.Append(((int)buffer[index]).ToString("X2"));

                    textBox2.Text = strBuider.ToString();
                }
            };

            Load += (s, e) =>
            {
                devices = CaptureDeviceList.Instance;
                if (devices.Count < 1)
                {
                    Console.WriteLine("在这台机器上没有找到任何设备");
                }
                else
                {
                    ToolStripItem item;
                    foreach (var dev in devices)
                    {
                        item = new ToolStripMenuItem();
                        PcapDevice? device = dev as PcapDevice;

                        item.Tag = device?.Description;
                        item.Text = $"{device?.Interface.FriendlyName}";
                        if (device?.Description == "Adapter for loopback traffic capture"
                        && device?.Interface.FriendlyName == null)
                            item.Text = $"本地回还(127)";
                        item.Font = new Font("Microsoft YaHei UI", 9F, GraphicsUnit.Point);

                        item.Click += selectDevice;
                        捕获ToolStripMenuItem.DropDownItems.Add(item);
                    }
                }
            };
        }

        private PcapDevice? currentDevice = null;
        private CaptureDeviceList? devices = null;

        private List<RawCapture> RawCaptures = new List<RawCapture>();

        private void selectDevice(object sender, EventArgs eventArgs)
        {
            if (devices != null)
            {
                foreach (var item in 捕获ToolStripMenuItem.DropDownItems)
                {
                    if (item is ToolStripMenuItem)
                    {
                        ToolStripMenuItem? menuItem = item as ToolStripMenuItem;
                        menuItem.Checked = false;
                    }
                }

                ToolStripMenuItem? toolStripMenuItem = sender as ToolStripMenuItem;
                toolStripMenuItem.Checked = true;

                foreach (PcapDevice device in devices)
                {
                    if (device.Opened) device.StopCapture();
                    device.OnPacketArrival -= new PacketArrivalEventHandler(DeviceOnPacketArrival);

                    if (device.Interface.FriendlyName == toolStripMenuItem.Text)
                    {
                        currentDevice = device;
                        break;
                    }
                }

                if (currentDevice == null)
                {
                    currentDevice = devices[devices.Count - 1] as PcapDevice;
                }

                currentDevice.OnPacketArrival += new PacketArrivalEventHandler(DeviceOnPacketArrival);

                int readTimeoutMilliseconds = 1000;
                currentDevice.Open(mode: DeviceModes.Promiscuous | DeviceModes.DataTransferUdp | DeviceModes.NoCaptureLocal, read_timeout: readTimeoutMilliseconds);
            }
        }

        private void DeviceOnPacketArrival(object sender, PacketCapture packetCapture)
        {
            var time = packetCapture.Header.Timeval.Date;
            var len = packetCapture.Data.Length;
            RawCaptures.Add(packetCapture.GetPacket());
            //var rawPacket = packetCapture.GetPacket();
            string value = string.Format("{0}:{1} | {2}:{3} | Len={4}", time.ToString("T"), time.Millisecond.ToString().PadRight(4, ' '), packetCapture.Device.MacAddress, packetCapture.Device.LinkType, len);

            listBoxData.Invoke(new Action(() =>
            {
                listBoxData.Items.Add(value);
                //listBoxData.SelectedIndex = listBoxData.Items.Count - 1;
                //listBoxData.AutoScrollOffset = new Point(0, 0);
                //listBoxData.scro.ScrollIntoView(listBoxData.SelectedItem);
            }));

            //Console.WriteLine(rawPacket.ToString());
        }
    }
}