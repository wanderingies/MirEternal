#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// <para>开启行会活动</para>
    /// <para>开启行会活动</para>
    /// </summary>
    internal class x0245 : Package
    {
        #region public

		public Int32 活动编号;
        #endregion

        #region marshal


        #endregion

        #region attribute

        public ushort Type => 0x0245;
        public ushort Size => 6;     
        public ushort rSize => 0;
        #endregion
        
        public x0245() 
        {
        }

        #region private


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
            throw new NotImplementedException();
        }

        public ByteBlock UnMarshal(ByteBlock byteBlock)
        {
			活动编号 = byteBlock.ReadInt32();
			return byteBlock;
        }

        public void Process(GameSession gameSession)
        {
            throw new NotImplementedException();
        }
    }
}

