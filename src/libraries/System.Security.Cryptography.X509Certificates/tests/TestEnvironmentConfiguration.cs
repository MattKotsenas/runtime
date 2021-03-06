// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace System.Security.Cryptography.X509Certificates.Tests
{
    internal static class TestEnvironmentConfiguration
    {
        internal static bool RunManualTests { get; } =
            !string.IsNullOrEmpty(Environment.GetEnvironmentVariable("CRYPTOGRAPHY_MANUAL_TESTS"));
    }
}
