using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Popups;

namespace CameraTest.Helper
{
    public static class MessageHelper
    {
        public static async void ShowMessageBox(string title, string content)
        {
            var messageDialog = new MessageDialog(content, title);
            messageDialog.ShowAsync();
        }

        public static async void ShowMessageBox(string title, string content, Dictionary<string, Delegate> options)
        {
            if (options == null)
            {
                ShowMessageBox(title, content);
            }

            var messageDialog = new MessageDialog(content, title);

            foreach (var option in options)
            {
                messageDialog.Commands.Add(new UICommand(option.Key, null, option.Key));
            }

            var result = await messageDialog.ShowAsync();

            var callbackResult = options.FirstOrDefault(c => c.Key == result.Id.ToString());

            if (callbackResult.Value != null)
            {
                callbackResult.Value.DynamicInvoke();
            }
        }

        public static async Task<bool> ShowConfirmBox(string title, string content)
        {
            var messageDialog = new MessageDialog(content, title);

            messageDialog.Commands.Add(new UICommand("Yes", null, true));
            messageDialog.Commands.Add(new UICommand("No", null, false));

            var result = await messageDialog.ShowAsync();
            return (bool)result.Id;
        }
    }
}
