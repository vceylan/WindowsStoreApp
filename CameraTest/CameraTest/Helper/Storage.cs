using System;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CameraTest.Helper
{
    public class Storage
    {
        //public const string KeyPushRegistered = "mflowPushRegistered";
        //public const string KeyPushURI = "mFlowPushURL";
        //public const string KeyServiceURL = "mFlowServiceURL";
        //public const string KeyUsername = "mFlowUsername";
        //public const string KeyPassword = "mFlowPassword";

        //static IsolatedStorageSettings settings = IsolatedStorageSettings.ApplicationSettings;

        //public static bool HasSettings
        //{
        //    get
        //    {
        //        var value = Get<string>(KeyServiceURL);
        //        if (string.IsNullOrEmpty(value))
        //        {
        //            return false;
        //        }
        //        value = Get<string>(KeyUsername);
        //        if (string.IsNullOrEmpty(value))
        //        {
        //            return false;
        //        }
        //        return true;
        //    }
        //}

        //public static TValue Get<TValue>(string key)
        //{
        //    return Get<TValue>(key, default(TValue));
        //}

        //public static TValue Get<TValue>(string key, TValue @default)
        //{
        //    try
        //    {
        //        TValue value;
        //        if (settings.TryGetValue(key, out value))
        //        {
        //            return value;
        //        }
        //        else
        //        {
        //            return @default;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //        return @default;
        //    }
        //}

        //public static void Set(string key, object value)
        //{
        //    settings[key] = value;
        //    settings.Save();
        //}


    }
}
