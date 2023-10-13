using GameServer.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouchSocket.Core;

namespace GameServer.Packs.Protocols
{
    /// <summary>
    /// <para></para>
    /// <para>物品快捷键</para>
    /// </summary>
    internal class x00BA : Package
    {
        #region public


        #endregion

        #region marshal

        public byte[] Result;
        #endregion

        #region attribute

        public ushort Type => 0x00BA;
        public ushort Size => 0;
        public ushort rSize => 0;
        #endregion

        public x00BA()
        {
            Result = new byte[511];
        }

        #region private


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
            byteBlock.Write(Result);
            return byteBlock;
        }        

        public ByteBlock UnMarshal(ByteBlock byteBlock)
        {
            throw new NotImplementedException();
        }

        public void Process(GameSession gateSession)
        {
            throw new NotImplementedException();
        }
    }
}
