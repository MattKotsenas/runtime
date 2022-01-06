// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Runtime.InteropServices;

internal static partial class Interop
{
    internal static partial class Gdi32
    {
        [DllImport(Libraries.Gdi32, SetLastError = true, ExactSpelling = true)]
        internal static extern IntPtr CreateCompatibleBitmap(HandleRef hDC, int width, int height);

        [DllImport(Libraries.Gdi32)]
        internal static extern int GetDIBits(HandleRef hdc, HandleRef hbm, int arg1, int arg2, IntPtr arg3, ref BITMAPINFO_FLAT bmi, int arg5);

        [DllImport(Libraries.Gdi32)]
        internal static extern uint GetPaletteEntries(HandleRef hpal, int iStartIndex, int nEntries, byte[] lppe);

        [DllImport(Libraries.Gdi32, SetLastError = true, ExactSpelling = true)]
        internal static extern IntPtr CreateDIBSection(HandleRef hdc, ref BITMAPINFO_FLAT bmi, int iUsage, ref IntPtr ppvBits, IntPtr hSection, int dwOffset);

        [GeneratedDllImport(Libraries.Gdi32, CharSet = CharSet.Auto, SetLastError = true)]
        internal static partial int AddFontResourceEx(string lpszFilename, int fl, IntPtr pdv);

        internal static int AddFontFile(string fileName)
        {
            return AddFontResourceEx(fileName, /*FR_PRIVATE*/ 0x10, IntPtr.Zero);
        }

        [DllImport(Libraries.Gdi32, SetLastError = true, ExactSpelling = true, CharSet = CharSet.Auto)]
        internal static extern int IntersectClipRect(HandleRef hDC, int x1, int y1, int x2, int y2);

        [DllImport(Libraries.Gdi32, SetLastError = true)]
        internal static extern int GetObject(HandleRef hObject, int nSize, ref BITMAP bm);

        [DllImport(Libraries.Gdi32, SetLastError = true, CharSet = CharSet.Unicode)]
        internal static extern int GetObject(HandleRef hObject, int nSize, ref Interop.User32.LOGFONT lf);

        internal static unsafe int GetObject(HandleRef hObject, ref Interop.User32.LOGFONT lp)
            => GetObject(hObject, sizeof(Interop.User32.LOGFONT), ref lp);

        [StructLayout(LayoutKind.Sequential)]
        public struct BITMAP
        {
            public uint bmType;
            public uint bmWidth;
            public uint bmHeight;
            public uint bmWidthBytes;
            public ushort bmPlanes;
            public ushort bmBitsPixel;
            public IntPtr bmBits;
        }

        internal const int BITMAPINFO_MAX_COLORSIZE = 256;

        [StructLayout(LayoutKind.Sequential)]
        internal unsafe struct BITMAPINFO_FLAT
        {
            public int bmiHeader_biSize; // = sizeof(BITMAPINFOHEADER)
            public int bmiHeader_biWidth;
            public int bmiHeader_biHeight;
            public short bmiHeader_biPlanes;
            public short bmiHeader_biBitCount;
            public int bmiHeader_biCompression;
            public int bmiHeader_biSizeImage;
            public int bmiHeader_biXPelsPerMeter;
            public int bmiHeader_biYPelsPerMeter;
            public int bmiHeader_biClrUsed;
            public int bmiHeader_biClrImportant;

            public fixed byte bmiColors[BITMAPINFO_MAX_COLORSIZE * 4]; // RGBQUAD structs... Blue-Green-Red-Reserved, repeat...
        }
    }
}
