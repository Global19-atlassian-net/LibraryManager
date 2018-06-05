﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.Web.LibraryManager.Tools.Contracts;

namespace Microsoft.Web.LibraryManager.Tools.Test
{
    internal class TestEnvironmentHelper
    {
        public static EnvironmentSettings GetTestSettings(string workingDirectory, string cacheDirectory)
        {
            return new EnvironmentSettings()
            {
                Logger = new TestLogger(),
                InputReader = new TestInputReader(),
                CurrentWorkingDirectory = workingDirectory,
                CacheDirectory = cacheDirectory
            };
        }

        public static HostEnvironment GetTestHostEnvironment(string workingDirectory, string cacheDirectory)
        {
            return HostEnvironment.Initialize(GetTestSettings(workingDirectory, cacheDirectory));
        }
    }
}
