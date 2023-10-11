#pragma warning disable CS0649
#pragma warning disable CS8618

using TouchSocket.Core;
using LoginServer.Service;

namespace LoginServer.Packs.Protocol
{
    /// <summary>
    /// 更改角色名称
    /// </summary>
    internal class x03F0 : Package
    {
        #region public field

        public int roleid;

        public short ResultType;
        public byte[] ResultMessage;
        #endregion

        #region public attribute

        public ushort Type => 0x03F0;
        public ushort Size => 38;        
        #endregion
        
        #region private field

        
        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
            byteBlock.Write(roleid);
            return byteBlock;
        }

        public ByteBlock UnMarshal(ByteBlock byteBlock)
        {

            return byteBlock;
        }

        public void Process(LoginSession session)
        {
            
        }
    }
}

