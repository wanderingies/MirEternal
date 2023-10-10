#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// 创建角色
    /// </summary>
    internal class UserCreateRolePacket : Package
    {
        #region public field

public String name;
public Byte gender;
public Byte career;
public Byte hairstyle;
public Byte haircolor;
public Byte facestyle;

        public short ResultType;
        public byte[] ResultMessage;
        #endregion

        #region public attribute

        public ushort Type => 0x03EA;
        public ushort Size => 40;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
byteBlock.Write(name);
byteBlock.Write(gender);
byteBlock.Write(career);
byteBlock.Write(hairstyle);
byteBlock.Write(haircolor);
byteBlock.Write(facestyle);

            return byteBlock;
        }

        public ByteBlock UnMarshal(ByteBlock byteBlock)
        {

            return byteBlock;
        }

        public void Process(GameSession session)
        {
            
        }
    }
}

