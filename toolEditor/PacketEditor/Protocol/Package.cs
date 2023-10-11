using System.ComponentModel;
using System.Xml.Serialization;

#pragma warning disable CS8618

namespace PacketEditor.Protocol
{
    [Serializable]
    public enum TypeItem
    {
        @Boolean,
        @Char,
        @SByte,
        @Byte,
        @Int16,
        @UInt16,
        @Int32,
        @UInt32,
        @Int64,
        @UInt64,
        @Single,
        @Double,
        @Decimal,
        @Array,
        @String,
    }

    [Serializable]
    public enum LimitAttr
    {
        None,
        @ref,
        @out
    }

    [Serializable]
    public enum Modifiers
    {
        @private,
        @public,
    }

    [Serializable]
    [DefaultProperty("属性值对"), DisplayName("属性值对")]
    public class Variable
    {
        [XmlAttribute]
        [Category("常规"), DisplayName("属性名称"), Description("")]
        public string Name { get; set; }

        [XmlAttribute]
        [Category("常规"), DisplayName("属性类型"), Description("")]
        public TypeItem type { get; set; }

        [XmlAttribute]
        [Category("常规"), DisplayName("属性数值"), Description("")]
        public string Value { get; set; }

        [XmlAttribute]
        [Category("常规"), DisplayName("可见级别"), Description("")]
        public Modifiers Modifier { get; set; }

        [XmlAttribute]
        [Category("常规"), DisplayName("限定符号"), Description("")]
        public LimitAttr Attr { get; set; }
    }

    [Serializable]
    public class SubPackage
    {
        /// <summary>
        /// 协议编号
        /// </summary>
        [XmlAttribute]
        [Category("常规"), DisplayName("协议编号"), Description("协议唯一识别码")]
        public short Type { get; set; }

        /// <summary>
        /// 协议大小
        /// </summary>
        [XmlAttribute]
        [Category("常规"), DisplayName("协议大小"), Description("用于接收客户端时的协议尺寸")]
        public short Size { get; set; }


        /// <summary>
        /// 协议名称
        /// </summary>
        [XmlAttribute]
        [Category("常规"), DisplayName("协议名称"), Description("用于生成类的类名")]
        public string Name { get; set; }

        /// <summary>
        /// 协议说明
        /// </summary>
        [XmlAttribute]
        [Category("常规"), DisplayName("协议说明"), Description("用于生成类的注释")]
        public string Description { get; set; }

        /// <summary>
        /// 属性值
        /// </summary>
        [XmlElement]
        [Category("属性"), DisplayName("属性值对"), Description("用于接收客户端时的协议尺寸")]
        public List<Variable> Variables { get; set; } = new List<Variable>();

        public override string ToString()
        {
            return Name;
        }
    }

    [Serializable]
    public class Package
    {
        [XmlElement]
        public List<SubPackage> Packages = new List<SubPackage>();        
    }
}
