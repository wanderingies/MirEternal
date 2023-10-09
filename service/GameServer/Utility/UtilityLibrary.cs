using System.Drawing;
using TouchSocket.Core;

namespace GameServer.Utility
{
    internal class UtilityLibrary
    {
        static UtilityLibrary()
        {
            SystemRelativeTime = Convert.ToDateTime("1970-01-01 08:00:00");
        }

        #region 坐标转换

        /// <summary>
        /// <para>true: 点阵坐标转协议坐标</para> 
        /// <para>false: 协议坐标转点阵坐标</para> 
        /// </summary>
        /// <param name="point">坐标</param>
        /// <returns></returns>
        public static Point 点阵坐标转协议坐标(Point point)
        {
            return new Point(point.X * 32 - 16, point.Y * 32 - 16);
        }


        public static Point 协议坐标转点阵坐标(Point location)
        {
            return new Point((int)Math.Round((double)(((float)location.X + 16f) / 32f)), (int)Math.Round((double)(((float)location.Y + 16f) / 32f)));
        }


        public static Point 游戏坐标转location(PointF 游戏坐标)
        {
            PointF pointF = default(PointF);
            pointF.Y = (游戏坐标.X + 游戏坐标.Y) / 0.707107f / 0.000976562f / 2f / 4096f;
            pointF.X = (游戏坐标.X / 0.707107f / 0.000976562f + 134217730f) / 4096f - pointF.Y;
            return new Point((int)((double)(pointF.X / 32f) + 0.5), (int)((double)(pointF.Y / 32f) + 0.5));
        }


        public static PointF location转游戏坐标(Point location)
        {
            PointF pointF = new PointF(((float)location.X - 0.5f) * 32f, ((float)location.Y - 0.5f) * 32f);
            return new PointF
            {
                X = ((pointF.Y + pointF.X) * 4096f - 134217730f) * 0.707107f * 0.000976562f,
                Y = ((pointF.Y - pointF.X) * 4096f + 134217730f) * 0.707107f * 0.000976562f
            };
        }
        #endregion

        #region 加密解密

        public static byte EncryptionKey = 129;

        public static byte[] EncryptionValue(byte[] data)
        {
            for (int i = 2; i < data.Length; i++)
                data[i] ^= EncryptionKey;

            return data;
        }

        public static byte[] EncryptionValue(byte[] data, int length)
        {
            for (int i = 4; i < length; i++)
                data[i] ^= EncryptionKey;

            return data;
        }

        public static ByteBlock EncryptionValue(ByteBlock byteBlock)
        {
            ByteBlock result = new ByteBlock(byteBlock.Len);
            for (int i = 4; i < byteBlock.Len; i++)
                result.Write(byteBlock.Buffer[i] ^ EncryptionKey);

            return result;
        }
        #endregion

        #region 时间转换

        public static readonly DateTime SystemRelativeTime;

        public static int TimeShift(DateTime time)
        {
            return (int)(time - SystemRelativeTime).TotalSeconds;
        }

        public static ushort DateShift(DateTime date)
        {
            return (ushort)(date - SystemRelativeTime).TotalDays;
        }
        #endregion
    }
}
