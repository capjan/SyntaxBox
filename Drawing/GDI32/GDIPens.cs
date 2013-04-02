// *
// * Copyright (C) 2008 Roger Alsing : http://www.RogerAlsing.com
// *
// * This library is free software; you can redistribute it and/or modify it
// * under the terms of the GNU Lesser General Public License 2.1 or later, as
// * published by the Free Software Foundation. See the included license.txt
// * or http://www.gnu.org/copyleft/lesser.html for details.
// *
// *

using System;
using System.Drawing;
using Alsing.Windows;

namespace Alsing.Drawing.GDI
{
    public class GDIPen : GDIObject
    {
        internal IntPtr hPen;

        public GDIPen(Color color, int width)
        {
            hPen = NativeMethods.CreatePen(0, width, NativeMethods.ColorToInt(color));
            Create();
        }

        protected override void Dispose(bool disposing)
        {
            if (hPen != IntPtr.Zero )
                NativeMethods.DeleteObject(hPen);
            base.Dispose(disposing);
            hPen = IntPtr.Zero;
        }
        
    }
}