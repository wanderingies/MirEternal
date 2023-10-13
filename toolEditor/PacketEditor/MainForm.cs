using PacketEditor.Protocol;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

#pragma warning disable CS8622
#pragma warning disable CS8601
#pragma warning disable CS8602

namespace PacketEditor
{
    enum scene
    {
        ProgIsland = 1,
        ProgIsland2,
        ProgIsland3,
        ProgIsland4,
        ProgIsland5 = 5,
        AvatarShow,
        MirSp01 = 10,
        MirSp02_1 = 11,
        MirSp02_2 = 12,
        MirSp02_3 = 13,
        MirSp02_4 = 14,
        MirSp03_1 = 16,
        MirSp03_2 = 17,
        MirSp03_3 = 18,
        MirAct33 = 21,
        MirAct33_1 = 22,
        MirArena01 = 25,
        MirAct36 = 26,
        MirAct36_1 = 27,
        MirAct36_2 = 28,
        MirAct37 = 29,
        MirAct37_1 = 30,
        MirAct34 = 31,
        MirAct34_1 = 32,
        MirAct35 = 35,
        MirAct38 = 40,
        MirAct38_1 = 41,
        MirAct38_2 = 42,
        MirAct38_3 = 43,
        MirAct38_4 = 44,
        MirAct38_5 = 45,
        MirPb04 = 50,
        MirDg13_1 = 51,
        MirDg13_2 = 52,
        MirDg13_3 = 53,
        MirDg13_4 = 54,
        MirDg13_5 = 55,
        MirDg14_1 = 56,
        MirDg14_2 = 57,
        MirDg14_3 = 58,
        MirDg15 = 59,
        MirDg15_1 = 60,
        MirDg15_2 = 61,
        MirDg15_3 = 62,
        MirDg15_4 = 63,
        MirDg15_5 = 64,
        MirDg15_6 = 65,
        MirDg15_7 = 66,
        MirAct07 = 67,
        MirAct08 = 68,
        MirDg16 = 69,
        MirDg17 = 70,
        MirDg17_1 = 71,
        MirAct09 = 72,
        MirAct10 = 73,
        MirAct11 = 74,
        MirAct12 = 75,
        MirAct13 = 76,
        MirAct14 = 77,
        MirAct15 = 78,
        MirAct24 = 79,
        MirAct17 = 80,
        MirAct18 = 81,
        MirAct19 = 82,
        MirDg17_2 = 83,
        MirAct20 = 84,
        MirAct21 = 85,
        MirAct23 = 86,
        MirAct25 = 87,
        MirAct26 = 88,
        MirAct27 = 89,
        MirAct28 = 90,
        MirAct29 = 91,
        MirDg18 = 92,
        MirDg19 = 93,
        MirAct30_1 = 94,
        MirAct30_2 = 95,
        MirAct30_3 = 96,
        MirAct30_4 = 97,
        MirAct30_5 = 98,
        MirAct30_6 = 99,
        MirAct30_7 = 100,
        MirAct30_8 = 101,
        MirPb05 = 102,
        MirAct32 = 103,
        MirPb06 = 104,
        MirDg23 = 110,
        MirDg23_1 = 111,
        MirDg23_2 = 112,
        MirDg26 = 113,
        MirDg26_1 = 114,
        MirDg26_2 = 115,
        MirDg27_1 = 116,
        MirDg27_2 = 117,
        MirDg27_3 = 118,
        MirDg27_4 = 119,
        MirDg25 = 121,
        MirDg25_1 = 122,
        MirDg24_1 = 123,
        MirDg24_2 = 124,
        MirDg27_5 = 125,
        MirDg27_6 = 126,
        MirGd01 = 127,
        MirDg22_1 = 131,
        MirDg22_2 = 132,
        MirDg22_3 = 133,
        Mir_Pb03 = 142,
        Mir_Pb02 = 143,
        Mir_Dg03 = 144,
        Mir_Dg04 = 145,
        Mir_Dg05 = 146,
        MirPb01 = 147,
        MirDg01 = 148,
        Mir_Dg02 = 149,
        MirCt01 = 152,
        Mir_Dg03_1 = 153,
        Mir_Dg03_2 = 154,
        Mir_Dg05_1 = 155,
        Mir_Dg05_2 = 156,
        MirDg01_1 = 157,
        MirDg01_2 = 158,
        Mir_Dg02_1 = 159,
        Mir_Dg02_2 = 160,
        Mir_Dg02_3 = 161,
        Mir_Dg02_4 = 162,
        Mir_Dg02_5 = 163,
        Mir_Dg02_6 = 164,
        MirDg07_2 = 167,
        MirDg07_3 = 168,
        MirDg07_4 = 169,
        MirDg07_5 = 170,
        MirDg07_6 = 171,
        MirDg07_7 = 172,
        MirDg07_8 = 173,
        Mir_In01 = 174,
        MirDg07 = 175,
        Mir_In03 = 176,
        Mir_In04 = 177,
        MirDg08 = 178,
        MirDg09 = 179,
        MirDg07_1 = 180,
        Mir_In02 = 181,
        MirAct01 = 183,
        MirAct02 = 184,
        MirAct03 = 185,
        MirAct04 = 186,
        MirDg10 = 187,
        MirDg11 = 188,
        MirDg11_1 = 189,
        MirDg11_2 = 190,
        MirDg11_3 = 191,
        MirDg11_5 = 193,
        MirDg11_6 = 194,
        MirDg11_7 = 195,
        MirDg11_8 = 196,
        MirDg11_9 = 197,
        MirDg11_10 = 198,
        MirDg11_11 = 199,
        MirDg11_12 = 200,
        MirDg01_3 = 201,
        MirDg01_4 = 202,
        MirDg01_5 = 203,
        MirDg08_1 = 204,
        MirDg08_2 = 205,
        MirDg08_3 = 206,
        Mir_Dg03_3 = 207,
        MirDg01_6 = 208,
        MirDg01_7 = 209,
        MirDg01_8 = 210,
        Mir_Dg05_3 = 211,
        Mir_Dg05_4 = 212,
        Mir_Dg05_5 = 213,
        Mir_Dg05_6 = 214,
        Mir_Dg05_7 = 215,
        Mir_Dg05_8 = 216,
        Mir_Dg05_11 = 219,
        Mir_Dg05_12 = 220,
        Mir_Dg05_13 = 221,
        Mir_Dg05_14 = 222,
        MirAct05_1 = 223,
        MirAct05_2 = 224,
        MirAct05_3 = 225,
        MirAct05_4 = 226,
        MirAct06 = 227,
        MirGd01_1 = 228,
        MirDg12 = 231,
        MirDg12_1 = 232,
        MirDg12_2 = 233,
        MirDg12_3 = 234,
        MirDg12_4 = 235,
        MirDg12_5 = 236,
        MirDg12_6 = 237,
        MirDg12_7 = 238,
        MirDg12_8 = 239,
        MirDg12_9 = 240,
        MirDg12_10 = 241,
        MirDg12_11 = 242,
        MirDg12_12 = 243,
        MirDg12_13 = 244,
        MirDg12_14 = 245,
        MirAct31 = 251,
        MirAct31_1 = 252,
        MirAct39 = 253,
        MirAct39_1 = 254,
        MirAct40 = 255,
    }

    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            Load += (sender, args) =>
            {
                if (!Directory.Exists("npc"))
                    Directory.CreateDirectory("npc");

                if (!Directory.Exists("npc\\npcs"))
                    Directory.CreateDirectory("npc\\npcs");

                var files = Directory.GetFiles(@"npc\npcs", "*.npc", SearchOption.AllDirectories); // 遍历所有文件

                foreach (var file in files)
                {
                    /*var buffer = File.ReadAllText(file);
                    XmlDocument xmlDocument = new XmlDocument();
                    xmlDocument.LoadXml(buffer);

                    var list = xmlDocument.SelectSingleNode("root");
                    XmlElement xmlElement = list as XmlElement;
                    foreach (XmlNode xmlNode in xmlElement.ChildNodes)
                    {
                        XmlElement item = xmlNode as XmlElement;
                        var npc = new npcc();
                        npc.Name = item.Attributes["Name"].Value;
                        npc.TemplateID = int.Parse(item.Attributes["TemplateID"].Value);
                        npc.DisplayName = item.Attributes["DisplayName"].Value;
                        npc.NpcType = int.Parse(item.Attributes["NpcType"].Value);
                        npc.NpcFuncType = int.Parse(item.Attributes["NpcFuncType"].Value);

                        var str = item.Attributes["Position"].Value.Remove(0, 2).Replace("Y=", ",").Replace("Z=", ",");
                        var spilts = str.Split(',');
                        npc.Position = new Vector3(float.Parse(spilts[0]), float.Parse(spilts[1]), float.Parse(spilts[2]));

                        _npcs.Add(npc);
                    }*/

                    /*if (_npcs.Count > 0)
                    {
                        FileInfo fileInfo = new FileInfo(file);
                        var v1 = fileInfo.Name.Replace(fileInfo.Extension, "");
                        var v2 = Enum.Parse(typeof(scene), v1);

                        int id = (int)v2;
                        using var stream = File.Create(string.Format("{0}.data", id));
                        using var binaryWriter = new BinaryWriter(stream);

                        binaryWriter.Write(_npcs.Count);

                        foreach (var item in _npcs)
                        {
                            var b1 = new byte[256];
                            Encoding.UTF8.GetBytes(item.Name).CopyTo(b1, 0);
                            binaryWriter.Write(b1);
                            binaryWriter.Write(id);
                            binaryWriter.Write(item.TemplateID);

                            var b2 = new byte[32];
                            Encoding.UTF8.GetBytes(item.DisplayName).CopyTo(b2, 0);
                            binaryWriter.Write(b2);
                            binaryWriter.Write(item.NpcType);
                            binaryWriter.Write(item.NpcFuncType);
                            binaryWriter.Write(1024);
                            binaryWriter.Write(item.Position.X);
                            binaryWriter.Write(item.Position.Y);
                            binaryWriter.Write(item.Position.Z);
                        }
                    }*/





                    //BinaryWriter binaryWriter=new BinaryWriter()
                    /*string xmlStr = string.Empty;
                    byte[] bomBuffer = new byte[] { 0xef, 0xbb, 0xbf };
                    if (buffer[0] == bomBuffer[0] && buffer[1] == bomBuffer[1] && buffer[2] == bomBuffer[2])
                    {
                        xmlStr = System.Text.Encoding.UTF8.GetString(buffer, 3, buffer.Length - 3);
                    }
                    else
                    {
                        xmlStr = System.Text.Encoding.UTF8.GetString(buffer);
                    }

                    xmlDocument.LoadXml(xmlStr);*/
                }

                if (!Directory.Exists("Packs"))
                    Directory.CreateDirectory("Packs");

                if (!Directory.Exists("Packs\\Protocol"))
                    Directory.CreateDirectory("Packs\\Protocol");

                new Thread(Action =>
                {
                    if (File.Exists(_config))
                    {
                        var file = _config;
                        using var fileStream = new FileStream(file, FileMode.Open);
                        XmlReader reader = XmlReader.Create(fileStream, new XmlReaderSettings() { IgnoreComments = true });

                        XmlSerializer serializer = new XmlSerializer(typeof(Package));
                        _package = serializer.Deserialize(reader) as Package;
                        _subPackages = _package.Packages.OrderByDescending(q => q.Type).ToList();

                        foreach (var item in _subPackages)
                        {
                            Invoke(new Action(() =>
                            {
                                _checkedListBox.Items.Add(item);
                            }));
                        }

                        Invoke(new Action(() =>
                        {
                            _totalProtcol = _checkedListBox.Items.Count;
                            toolStripStatusLabel1.Text = $"统计: {_totalProtcol}";
                        }));

                    }

                    if (File.Exists(_format))
                        _format = File.ReadAllText(_format);

                }).Start();
            };

            Shown += (sender, args) =>
            {

            };

            _addProtocol.Click += (sender, args) =>
            {
                SubPackage package = new SubPackage()
                { Name = "package" };

                if (_subPackages.Where(q => q.Name == package.Name).FirstOrDefault() == null
                    && _subPackages.Where(q => q.Type == package.Type).FirstOrDefault() == null)
                {
                    _subPackages.Add(package);
                    _currentSelected = _checkedListBox.Items.Add(package);

                    propertyGrid.SelectedObject = package;
                    _checkedListBox.SetSelected(_currentSelected, true);
                    _checkedListBox.SetItemChecked(_currentSelected, true);

                    toolStripStatusLabel1.Text = $"统计: {++_totalProtcol}";
                }
            };

            _saveProtocol.Click += (sender, args) =>
            {
                _package.Packages = _subPackages;

                if (File.Exists(_config)) File.Delete(_config);
                using var stream = new FileStream(_config, FileMode.Create, FileAccess.Write);
                using var writer = new XmlTextWriter(stream, Encoding.UTF8);

                XmlSerializer serializer = new XmlSerializer(typeof(Package));
                serializer.Serialize(writer, _package);
            };

            _inputProtocol.Click += (sender, args) =>
            {

            };

            _exportProtocol.Click += (sender, args) =>
            {
                StreamWriter streamWriter;
                if (_checkedListBox.SelectedIndex >= 0)
                {
                    var package = _subPackages[_checkedListBox.SelectedIndex];

                    string vars = string.Empty;
                    foreach (var variable in package.Variables)
                        vars += $"\t\tpublic {variable.type} {variable.Name};\n";

                    string writer = string.Empty;
                    foreach (var variable in package.Variables)
                        writer += $"\t\t\tbyteBlock.Write({variable.Name});\n";

                    string reader = string.Empty;
                    foreach (var variable in package.Variables)
                    {
                        switch(variable.type)
                        {
                            case TypeItem.Boolean:
                                reader += $"\t\t\t{variable.Name} = byteBlock.ReadBoolean();\n";
                                break;
                            case TypeItem.Char:
                                reader += $"\t\t\t{variable.Name} = byteBlock.ReadChar();\n";
                                break;
                            case TypeItem.Byte:
                                reader += $"\t\t\t{variable.Name} = byteBlock.ReadByte();\n";
                                break;
                            case TypeItem.Int16:
                                reader += $"\t\t\t{variable.Name} = byteBlock.ReadInt16();\n";
                                break;
                            case TypeItem.Int32:
                                reader += $"\t\t\t{variable.Name} = byteBlock.ReadInt32();\n";
                                break;
                            case TypeItem.Int64:
                                reader += $"\t\t\t{variable.Name} = byteBlock.ReadInt64();\n";
                                break;
                            case TypeItem.UInt16:
                                reader += $"\t\t\t{variable.Name} = byteBlock.ReadUInt16();\n";
                                break;
                            case TypeItem.UInt32:
                                reader += $"\t\t\t{variable.Name} = byteBlock.ReadUInt32();\n";
                                break;
                            case TypeItem.UInt64:
                                reader += $"\t\t\t{variable.Name} = byteBlock.ReadUInt64();\n";
                                break;
                            case TypeItem.Single:
                                reader += $"\t\t\t{variable.Name} = byteBlock.ReadFloat();\n";
                                break;
                            case TypeItem.Double:
                                reader += $"\t\t\t{variable.Name} = byteBlock.ReadDouble();\n";
                                break;
                            case TypeItem.Array:
                                reader += $"\t\t\tbyteBlock.Read({variable.Name});\n";
                                break;
                        }
                    }                    

                    var value = string.Format(_format, new Object[] {
                        "GameServer",
                        package.Description,
                        $"x{package.Type.ToString("X4")}",
                        vars,
                        $"0x{package.Type.ToString("X4")}",
                        package.Size,
                        "",
                        //writer,
                        reader,
                        "GameSession",
                        package.Name });

                    streamWriter = new StreamWriter(Path.Combine("Packs", "Protocol", $"x{package.Type.ToString("X4")}.cs"), false, Encoding.UTF8);
                    streamWriter.WriteLine(value);

                    streamWriter.Dispose();
                    streamWriter.Close();
                    return;
                }


                foreach (var item in _subPackages)
                {
                    string vars = string.Empty;
                    foreach (var variable in item.Variables)
                    {
                        if (variable.type == TypeItem.Array)
                            vars += $"\t\tpublic byte[] {variable.Name};\n";
                        else vars += $"\t\tpublic {variable.type} {variable.Name};\n";
                    }

                    string writer = string.Empty;
                    foreach (var variable in item.Variables)
                        writer += $"\t\t\tbyteBlock.Write({variable.Name});\n";

                    string reader = string.Empty;
                    foreach (var variable in item.Variables)
                    {
                        switch (variable.type)
                        {
                            case TypeItem.Boolean:
                                reader += $"\t\t\t{variable.Name} = byteBlock.ReadBoolean();\n";
                                break;
                            case TypeItem.Char:
                                reader += $"\t\t\t{variable.Name} = byteBlock.ReadChar();\n";
                                break;
                            case TypeItem.Byte:
                                reader += $"\t\t\t{variable.Name} = byteBlock.ReadByte();\n";
                                break;
                            case TypeItem.Int16:
                                reader += $"\t\t\t{variable.Name} = byteBlock.ReadInt16();\n";
                                break;
                            case TypeItem.Int32:
                                reader += $"\t\t\t{variable.Name} = byteBlock.ReadInt32();\n";
                                break;
                            case TypeItem.Int64:
                                reader += $"\t\t\t{variable.Name} = byteBlock.ReadInt64();\n";
                                break;
                            case TypeItem.UInt16:
                                reader += $"\t\t\t{variable.Name} = byteBlock.ReadUInt16();\n";
                                break;
                            case TypeItem.UInt32:
                                reader += $"\t\t\t{variable.Name} = byteBlock.ReadUInt32();\n";
                                break;
                            case TypeItem.UInt64:
                                reader += $"\t\t\t{variable.Name} = byteBlock.ReadUInt64();\n";
                                break;
                            case TypeItem.Single:
                                reader += $"\t\t\t{variable.Name} = byteBlock.ReadFloat();\n";
                                break;
                            case TypeItem.Double:
                                reader += $"\t\t\t{variable.Name} = byteBlock.ReadDouble();\n";
                                break;
                            case TypeItem.Array:
                                reader += $"\t\t\tbyteBlock.Read({variable.Name});\n";
                                break;
                        }                        
                    }

                    if (reader != string.Empty)
                        reader += $"\t\t\treturn byteBlock;";
                    else reader = "\t\t\tthrow new NotImplementedException();";

                    var value = string.Format(_format, new object[] {
                            "GameServer",
                            item.Description,
                            $"x{item.Type.ToString("X4")}",
                            vars,
                            $"0x{item.Type.ToString("X4")}",
                            item.Size,
                            "",
                            //writer,
                            reader,
                            "GameSession gameSession",
                            item.Name,
                            $"x{item.Type.ToString("X4")}",
                            "GameServer",
                        });

                    streamWriter = new StreamWriter(Path.Combine("Packs", "Protocol", $"x{item.Type.ToString("X4")}.cs"), false, Encoding.UTF8);
                    streamWriter.WriteLine(value);

                    streamWriter.Dispose();
                    streamWriter.Close();
                }
            };

            _deleteProtocol.Click += (sender, args) =>
            {
                StreamWriter streamWriter;
                var writer = string.Empty;
                foreach (var item in _subPackages)
                {
                    var value = string.Format(_proto, new Object[] {
                        $"0x{item.Type.ToString("X4")}",
                        item.Size,
                        item.Name,
                        item.Description,
                    });

                    writer += $"{value}\n";
                }

                streamWriter = new StreamWriter(Path.Combine("Packs", "protocol.cs"), false, Encoding.UTF8);
                streamWriter.WriteLine(writer);

                streamWriter.Dispose();
                streamWriter.Close();
                /*if (_checkedListBox.SelectedIndex < 0) return;

                var package = _subPackages[_checkedListBox.SelectedIndex];
                _subPackages.Remove(package);

                _checkedListBox.Items.Remove(_checkedListBox.SelectedIndex);
                _checkedListBox.Refresh();*/
            };

            _checkedListBox.MouseClick += (sender, args) =>
            {
                if (args.Button == MouseButtons.Right)
                {
                    _checkedListBox.SelectedIndex = -1;
                }
            };

            _checkedListBox.SelectedIndexChanged += (sender, args) =>
            {                
                if (_checkedListBox.SelectedIndex < 0) return;

                var current = propertyGrid.SelectedObject as SubPackage ?? new SubPackage();

                if (current.Name == null)
                    current = _checkedListBox.SelectedItem as SubPackage;

                if (_subPackages.Where(q => q.Name == current.Name).Count() > 0)
                {
                    var package = _checkedListBox.SelectedItem as SubPackage;

                    if (current != null || !current.Equals(package))
                    {
                        propertyGrid.SelectedObject = package;
                        _subPackages[_checkedListBox.SelectedIndex] = package;

                        _currentSelected = _checkedListBox.SelectedIndex;
                        return;
                    }
                }

                _checkedListBox.SelectedIndex = _currentSelected;
            };
        }

        private string _proto = "{{{0},\tnew BaseProtocol() {{ Size={1},\t\tName=\"{2}\", Description=\"{3}\" }} }},";
        private string _format = "Packs\\formart.txt";
        private string _config = "Packs\\config.xml";

        private int _totalProtcol = 0;
        private int _currentSelected = -1;

        root _root = new root();
        List<npcc> _npcs = new List<npcc>();

        private Package _package = new Package();
        private List<SubPackage> _subPackages = new List<SubPackage>();
    }
}