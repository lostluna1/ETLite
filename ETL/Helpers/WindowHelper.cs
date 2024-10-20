//*********************************************************
//
// Copyright (c) Microsoft. All rights reserved.
// THIS CODE IS PROVIDED *AS IS* WITHOUT WARRANTY OF
// ANY KIND, EITHER EXPRESS OR IMPLIED, INCLUDING ANY
// IMPLIED WARRANTIES OF FITNESS FOR A PARTICULAR
// PURPOSE, MERCHANTABILITY, OR NON-INFRINGEMENT.
//
//*********************************************************

using Microsoft.UI;
using Microsoft.UI.Windowing;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Media;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Windows.Storage;
using WinRT.Interop;

namespace ETL.Helpers;

// Helper class to allow the app to find the Window that contains an
// arbitrary UIElement (GetWindowForElement).  To do this, we keep track
// of all active Windows.  The app code must call WindowHelper.CreateWindow
// rather than "new Window" so we can keep track of all the relevant
// windows.  In the future, we would like to support this in platform APIs.
public class WindowHelper
{
    static public Window CreateWindow()
    {
        Window newWindow = new Window
        {
            SystemBackdrop = new MicaBackdrop()
        };
        TrackWindow(newWindow);
        return newWindow;
    }

    static public void TrackWindow(Window window)
    {
        window.Closed += (sender, args) => {
            _activeWindows.Remove(window);
        };
        _activeWindows.Add(window);
    }

    static public AppWindow GetAppWindow(Window window)
    {
        IntPtr hWnd = WindowNative.GetWindowHandle(window);
        WindowId wndId = Win32Interop.GetWindowIdFromWindow(hWnd);
        return AppWindow.GetFromWindowId(wndId);
    }

    static public Window GetWindowForElement(UIElement element)
    {
        if (element.XamlRoot != null)
        {
            foreach (Window window in _activeWindows)
            {
                if (element.XamlRoot == window.Content.XamlRoot)
                {
                    return window;
                }
            }
        }
        return null;
    }
    // get dpi for an element
    static public double GetRasterizationScaleForElement(UIElement element)
    {
        if (element.XamlRoot != null)
        {
            foreach (Window window in _activeWindows)
            {
                if (element.XamlRoot == window.Content.XamlRoot)
                {
                    return element.XamlRoot.RasterizationScale;
                }
            }
        }
        return 0.0;
    }

    static public List<Window> ActiveWindows
    {
        get
        {
            return _activeWindows;
        }
    }

    static private List<Window> _activeWindows = new List<Window>();

    static public StorageFolder GetAppLocalFolder()
    {
        StorageFolder localFolder;
        if (!NativeHelper.IsAppPackaged)
        {
            localFolder = Task.Run(async () => await StorageFolder.GetFolderFromPathAsync(System.AppContext.BaseDirectory)).Result;
        }
        else
        {
            localFolder = ApplicationData.Current.LocalFolder;
        }
        return localFolder;
    }
}
internal class NativeHelper
{
    public const int ERROR_SUCCESS = 0;
    public const int ERROR_INSUFFICIENT_BUFFER = 122;
    public const int APPMODEL_ERROR_NO_PACKAGE = 15700;

    [DllImport("api-ms-win-appmodel-runtime-l1-1-1", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.U4)]
    internal static extern uint GetCurrentPackageId(ref int pBufferLength, out byte pBuffer);

    public static bool IsAppPackaged
    {
        get
        {
            int bufferSize = 0;
            byte byteBuffer = 0;
            uint lastError = NativeHelper.GetCurrentPackageId(ref bufferSize, out byteBuffer);
            bool isPackaged = true;

            if (lastError == NativeHelper.APPMODEL_ERROR_NO_PACKAGE)
            {
                isPackaged = false;
            }
            return isPackaged;
        }
    }
}