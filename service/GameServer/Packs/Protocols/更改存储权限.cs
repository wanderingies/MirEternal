#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// 更改存储权限
    /// </summary>
    internal class 更改存储权限 : Package
    {
        #region public field

public Byte GuildJobs;
public Byte 原有位置;
public Byte 目标页面;

        public short ResultType;
        public byte[] ResultMessage;
        #endregion

        #region public attribute

        public ushort Type => 0x023C;
        public ushort Size => 5;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
byteBlock.Write(GuildJobs);
byteBlock.Write(原有位置);
byteBlock.Write(目标页面);

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

