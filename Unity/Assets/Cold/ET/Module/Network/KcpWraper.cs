using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETCold
{
    public class KcpWraper
    {
        public IntPtr Instance;
        public KcpWraper(uint conn, uint usr)
        {
            Instance = Kcp.KcpCreate(conn, new IntPtr(usr));
        }
        public uint Check(uint c)
        {
            return Kcp.KcpCheck(Instance, c);
        }
        public int WndSize(int a, int b)
        {
            return Kcp.KcpWndsize(Instance, a, b);
        }
        public void Update(uint c)
        {
            Kcp.KcpUpdate(Instance, c);
        }

        [AOT.MonoPInvokeCallback(typeof(Func<byte[], uint, int>))]
        public static void SetOutput(Func<byte[],uint, int> c)
        {
            kcpOutput = c;
            Kcp.KcpSetoutput(KcpOutput);

        }
        public int Recv(byte[] data,int len)
        {
         return   Kcp.KcpRecv(Instance,data, len);

        }
        public int Peeksize()
        {
            return Kcp.KcpPeeksize(Instance);

        }
        public int Waitsnd()
        {
            return Kcp.KcpWaitsnd(Instance);

        }
        public int Input(byte[] data,int off,int len)
        {
           return Kcp.KcpInput(Instance, data, off, len);
        }
        public int Nodelay(int a,int b,int c,int d)
        {
            return Kcp.KcpNodelay(Instance,a,b,c,d);
        }
        public void Release()
        {
             Kcp.KcpRelease(Instance);
        }
        public int Send(byte[] data,int off,int len)
        {
         return   Kcp.KcpSend(Instance,data,off,len);
        }
        public void Setminrto(int c)
        {
            Kcp.KcpSetminrto(Instance,c);
        }
        public int Setmtu(int c)
        {
           return Kcp.KcpSetmtu(Instance, c);
        }
        private static Func<byte[],uint,int> kcpOutput;

        [AOT.MonoPInvokeCallback(typeof(KcpOutput))]
        static  int KcpOutput(IntPtr buf, int len, IntPtr kcp, IntPtr user){

            byte[] data = new byte[len];
            System.Runtime.InteropServices.Marshal.Copy(buf,
                data, 0, len);
            if (kcpOutput != null)
            {

                return kcpOutput.Invoke(data,(uint)user);
            }
            return 0;
        }
        private static Action<string> kcpLog;
        private static readonly byte[] logBuffer = new byte[1024];

        public static void Log(Action<string> action)
        {
            kcpLog = action;
            Kcp.KcpSetLog(KcpLog);
        }
         static void KcpLog(IntPtr bytes, int len, IntPtr kcp, IntPtr user)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.Copy(bytes, logBuffer, 0, len);
               kcpLog?.Invoke(logBuffer.ToStr(0, len));
            }
            catch (Exception e)
            {
                UnityEngine.Debug.LogError(e);
            }
        }
        public bool IsEnable()
        {
            return Instance != IntPtr.Zero;
        }
    }
}
