// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics;
using Microsoft.Win32;

namespace MMT.Core
{
    public class RegistryManager
    {
        private readonly RegistryKey _registryKey;

        public RegistryManager()
        {
            _registryKey = Registry.CurrentUser.OpenSubKey(StaticResources.StartupApplications, true);
        }

        public bool IsApplicationInStartup(string name)
        {
            return _registryKey.GetValue(name) != null;
        }

        public void AddApplicationInStartup(string name)
        {
            _registryKey.SetValue(name, Process.GetCurrentProcess().MainModule.FileName);
        }

        public void RemoveApplicationFromStartup(string appName)
        {
            _registryKey.DeleteValue(appName, false);
        }
    }
}
