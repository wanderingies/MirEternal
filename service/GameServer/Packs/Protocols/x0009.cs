using GameServer.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouchSocket.Core;

namespace GameServer.Packs.Protocols
{
    internal class x0009 : Package
    {
        #region public

        #endregion

        #region marshal

        public Int32 code;
        public Int32 param;
        public Int32 extra;
        #endregion

        #region attribute

        public ushort Type => 0x0009;
        public ushort Size => 6;
        public ushort rSize => 14;
        #endregion

        public x0009()
        {
        }

        #region private


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
            byteBlock.Write(code);
            byteBlock.Write(param);
            byteBlock.Write(extra);
            return byteBlock;
        }

        public ByteBlock UnMarshal(ByteBlock byteBlock)
        {
            throw new NotImplementedException();
        }

        public void Process(GameSession session)
        {
            throw new NotImplementedException();
        }
    }
}
