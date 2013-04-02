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

namespace Alsing.Drawing.GDI
{
    /// <summary>
    /// Summary description for GDIObject.
    /// </summary>
    public abstract class GDIObject : IDisposable
    {
        protected bool IsCreated;

        protected void Create()
        {
            IsCreated = true;
        }

        #region Implementation of IDisposable
        
        // Dispose() calls Dispose(true)
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
                IsCreated = false;                    

            }
            // free native resources if there are any.

        }




        #endregion
    }
}