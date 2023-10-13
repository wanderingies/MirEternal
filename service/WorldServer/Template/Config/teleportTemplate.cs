#pragma warning disable CS8618
#pragma warning disable CS8601

using System.Xml;
using System.Xml.Serialization;

namespace WorldServer.Template.Config
{
    internal class TeleportTemplate : TemplateInterface
    {
        public int TemplateLevel => 0;

        public string TemplateName => "传送阵";

        public string TemplateDescription => "teleport";

        public static TeleportTemplate Instance { get; set; }

        public TeleportTemplate()
        {
            Instance = this;
        }

        public Dictionary<string ,root> ValuePairs { get; set; }

        public bool ReaderTemplate()
        {
            ValuePairs = new Dictionary<string, root>();

            var folder = Path.Combine(Environment.CurrentDirectory, @"data\globalinfo");
            var files = Directory.GetFiles(folder, "*.teleport", SearchOption.AllDirectories);

            int index = 0;
            int postion = Console.CursorLeft;
            Console.WriteLine("读取 传送阵\t\t\t");
            Console.ForegroundColor = ConsoleColor.Green;            
            foreach (var file in files)
            {
                ++index;
                using var fileStream = new FileStream(file, FileMode.Open, FileAccess.Read, FileShare.Read);
                XmlReader reader = XmlReader.Create(fileStream, new XmlReaderSettings() { IgnoreComments = true });

                if (reader.NodeType == XmlNodeType.None) continue;
                XmlSerializer serializer = new XmlSerializer(typeof(root));
                var _root = serializer.Deserialize(reader) as root;

                FileInfo fileInfo = new FileInfo(file);
                ValuePairs.Add(fileInfo.Name, _root);

                postion = Console.CursorLeft;
                Console.Write($"{index / files.Count() * 100}");
                Console.CursorLeft = postion;
            }

            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.White;
            return true;
        }

        public class A3dVector
        {
            public float X { get; set; }
            public float Y { get; set; }
            public float Z { get; set; }
        }

        public class root
        {
            public string CanvasDrawSize { get; set; }
            public string ServerMapType { get; set; }

            public List<TeleportTarget> TeleportTarget { get; set; }

            public root()
            {
                TeleportTarget = new List<TeleportTarget>();
            }
        }

        public class TeleportTarget
        {
            public string Name { get; set; }
            public string Position {  get; set; }
            public string DisplayName {  get; set; }
            public string Radius { get; set; }
            public string Rotation {  get; set; }
            public string NpcId {  get; set; }
        }
    }
}
