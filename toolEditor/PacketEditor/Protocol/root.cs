using System.ComponentModel;
using System.Xml.Serialization;
using System.Numerics;

#pragma warning disable CS8618

namespace PacketEditor.Protocol
{
    [Serializable]
    public class root
    {
        [XmlElement]
        List<npcc> NPC = new List<npcc>();
    }

    [Serializable]
    public class npcc
    {
        [XmlAttribute]
        [Category("常规"), DisplayName("地图实例"), Description("协议唯一识别码")]
        public string Name { get; set; }

        [XmlAttribute]
        [Category("常规"), DisplayName("怪物编号"), Description("协议唯一识别码")]
        public int TemplateID { get; set; }

        [XmlAttribute]
        [Category("常规"), DisplayName("怪物名称"), Description("协议唯一识别码")]
        public string DisplayName { get; set; }

        [XmlAttribute]
        [Category("常规"), DisplayName("怪物类型"), Description("协议唯一识别码")]
        public int NpcType { get; set; }

        [XmlAttribute]
        [Category("常规"), DisplayName("动作类型"), Description("协议唯一识别码")]
        public int NpcFuncType { get; set; }

        [XmlAttribute]
        [Category("常规"), DisplayName("怪物坐标"), Description("协议唯一识别码")]
        public Vector3 Position { get; set; }
    }
}
