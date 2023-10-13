#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// <para>UnknownC267</para>
    /// <para>UnknownC267</para>
    /// </summary>
    internal class x010B : Package
    {
        #region public

		public Int32 U1;
        #endregion

        #region marshal


        #endregion

        #region attribute

        public ushort Type => 0x010B;
        public ushort Size => 142;     
        public ushort rSize => 0;
        #endregion
        
        public x010B() 
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
			U1 = byteBlock.ReadInt32();
			return byteBlock;
        }

        public void Process(GameSession gameSession)
        {
            throw new NotImplementedException();
        }
    }
}

