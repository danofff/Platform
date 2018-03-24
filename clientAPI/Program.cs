using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace clientAPI
{
    class Program
    {
        public enum beepType :uint
        {
            SimpleBeep=0xFFFFFFFF,
            Question=0x20
        }
        public static class UnmanagedCode
        {
            [DllImport("Bridge.dll", CallingConvention=CallingConvention.Cdecl)]
            public static extern double calculateDustanceIn3D(double xOne, double yOne, double zOne, double xTwo, double yTwo, double zTwo);

            [DllImport("Bridge.dll", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr GetPointerToInt();

            [DllImport("Bridge.dll", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr GetPointerToDouble();

            [DllImport("wininet.dll", SetLastError = true)]
            public static extern bool InternetCheckConnection(string IpszUrl, int dwFlags, int dwReserved);

            [DllImport("user32.dll", SetLastError = true)]
            public static extern bool LockWorkStation();

            [DllImport("user32.dll")]
            public static extern bool MessageBeep(beepType uType);

            [DllImport("user32.dll", SetLastError = true)]
            static extern int MessageBoxTimeout(IntPtr hwnd, String text, String title, uint type, Int16 wLanguageId, Int32 milliseconds);

        }
        static void Main(string[] args)
        {
            //UnmanagedCode.LockWorkStation();
            var result= UnmanagedCode.InternetCheckConnection("http://127.0.0.1", 1, 0);
            Console.WriteLine(result);
            var res = UnmanagedCode.GetPointerToInt();
            Console.WriteLine(res);
            double[] x = new double[1];
            Marshal.Copy(res,x,0,1);
            foreach (var item in x)
            {
                Console.WriteLine(item);
            }
        }
    }
}
