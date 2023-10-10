#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// BattleStanceSwitchPacket
    /// </summary>
    internal class BattleStanceSwitchPacket : Package
    {
        #region public field

public Boolean 切回正常姿态;
public Boolean 系统自动切换;

        public short ResultType;
        public byte[] ResultMessage;
        #endregion

        #region public attribute

        public ushort Type => 0x0028;
        public ushort Size => 4;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
byteBlock.Write(切回正常姿态);
byteBlock.Write(系统自动切换);

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

