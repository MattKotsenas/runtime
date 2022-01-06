// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Runtime.InteropServices;

internal static partial class Interop
{
    internal static partial class Gdi32
    {
        internal const int QUERYESCSUPPORT = 8;
        internal const int CHECKJPEGFORMAT = 4119;
        internal const int CHECKPNGFORMAT = 4120;

        [DllImport(Libraries.Gdi32, SetLastError = true, ExactSpelling = true, CharSet = CharSet.Auto)]
        internal static extern int ExtEscape(HandleRef hDC, int nEscape, int cbInput, ref int inData, int cbOutput, [Out] out int outData);

        [DllImport(Libraries.Gdi32, SetLastError = true, ExactSpelling = true, CharSet = CharSet.Auto)]
        internal static extern int ExtEscape(HandleRef hDC, int nEscape, int cbInput, byte[] inData, int cbOutput, [Out] out int outData);
    }
}
