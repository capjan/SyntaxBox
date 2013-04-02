using System;
using Alsing.Windows;
using System.Drawing;

namespace Alsing.Drawing
{
    public class DesktopGraphics : IDisposable
    {
        public readonly Graphics Graphics;
        private readonly IntPtr handle = IntPtr.Zero;
        private readonly IntPtr hdc = IntPtr.Zero;

        public DesktopGraphics()
        {
            handle = NativeMethods.GetDesktopWindow();
            hdc = NativeMethods.GetWindowDC(hdc);
            Graphics = Graphics.FromHdc(hdc);
        }

        // NOTE: Leave out the finalizer altogether if this class
        // doesn't own unmanaged resoureces, but leave the methods exactly
        // as they are
        ~DesktopGraphics()
        {
            // Finalizer calls Dispose(false)
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        // The bulk of the clean-up code is implemented in Dispose(bool)
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                // free managed resources                                
            }
            // free native resources if there are any.
            if (handle != IntPtr.Zero)
            {
                NativeMethods.ReleaseDC(handle, hdc);
            }            
        }

    }
}
