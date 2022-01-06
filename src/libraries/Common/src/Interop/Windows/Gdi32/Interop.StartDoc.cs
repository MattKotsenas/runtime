// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Runtime.InteropServices;

internal static partial class Interop
{
    internal static partial class Gdi32
    {
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
        internal sealed class DOCINFO
        {
            internal int cbSize = 20;
            internal string? lpszDocName;
            internal string? lpszOutput;
            internal string? lpszDatatype;
            internal int fwType;
        }

        [DllImport(Libraries.Gdi32, SetLastError = true, CharSet = CharSet.Auto)]
        internal static extern int StartDoc(HandleRef hDC, DOCINFO lpDocInfo);
    }
}
