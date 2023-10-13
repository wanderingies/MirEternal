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
    /// <para>不知道干嘛的, 离开进入安全区触发</para>
    /// <para>特权信息</para>
    /// </summary>
    internal class x0142 : Package
    {
        #region public


        #endregion

        #region marshal

        public byte[] PrivilegedInfo;
        #endregion

        #region attribute

        public ushort Type => 0x0142;
        public ushort Size => 0;
        public ushort rSize => 0;
        #endregion

        public x0142()
        {
            PrivilegedInfo = new byte[] { 2 };
        }

        #region private


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
            byteBlock.Write(PrivilegedInfo);
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
