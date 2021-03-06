﻿using System;
using System.Windows.Interop;

namespace MCDA
{
    internal sealed class WLCToolButton : ESRI.ArcGIS.Desktop.AddIns.Button
    {    
        protected override void OnClick()
        {
            var parentHandle = new IntPtr(ArcMap.Application.hWnd);

            var wpfWindow = new WLCToolView();

            var helper = new WindowInteropHelper(wpfWindow) {Owner = parentHandle};

            wpfWindow.Show();
        }

    }
}
