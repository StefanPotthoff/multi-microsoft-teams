// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Threading.Tasks;
using System.Windows;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;

namespace MMT.UI
{
    public class MessageHelper
    {
        private static readonly string _title = "Multi MS Teams";

        public static async void Info(string message)
        {
            await ((MetroWindow)Application.Current.MainWindow).ShowMessageAsync(_title, message);
        }

        public static async Task<MessageDialogResult> Confirm(string message)
        {
            return await ((MetroWindow)Application.Current.MainWindow).ShowMessageAsync(_title, message, MessageDialogStyle.AffirmativeAndNegative);
        }

        public static async Task<ProgressDialogController> Wait(string message)
        {
            return await ((MetroWindow)Application.Current.MainWindow).ShowProgressAsync(_title, message);
        }
    }
}
