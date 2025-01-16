using System.Runtime.InteropServices;

namespace WpfApp
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void Callback(IntPtr data);

    public class Interop
    {
        [DllImport("CppLib.dll")]
        public static extern void SetCallback(Callback callback);

        [DllImport("CppLib.dll")]
        public static extern void Start();
    }
}