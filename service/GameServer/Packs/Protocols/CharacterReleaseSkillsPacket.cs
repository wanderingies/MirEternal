#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// 释放技能
    /// </summary>
    internal class CharacterReleaseSkillsPacket : Package
    {
        #region public field

public UInt16 SkillId;
public Byte 动作编号;
public Int32 目标编号;
public UInt16 锚点高度;

        public short ResultType;
        public byte[] ResultMessage;
        #endregion

        #region public attribute

        public ushort Type => 0x0022;
        public ushort Size => 16;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
byteBlock.Write(SkillId);
byteBlock.Write(动作编号);
byteBlock.Write(目标编号);
byteBlock.Write(锚点高度);

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

