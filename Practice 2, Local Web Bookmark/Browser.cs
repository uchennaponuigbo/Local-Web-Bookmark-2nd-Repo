using Microsoft.Win32;
using System;

namespace Practice_2__Local_Web_Bookmark
{
    internal static class Browser
    {
        public static string GetDefault()
        {
            string name = "";
            RegistryKey regKey = null;
            try
            {
                var regDefault = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FileExts\\.htm\\UserChoice", false);
                var stringDefault = regDefault.GetValue("ProgId");

                regKey = Registry.ClassesRoot.OpenSubKey(stringDefault + "\\shell\\open\\command", false);
                name = regKey.GetValue(null).ToString().ToLower().Replace('"'.ToString(), "");

                if (!name.EndsWith("exe"))
                    name = name.Substring(0, name.LastIndexOf(".exe") + 4);

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "There is no Default Browser on this system.");
            }
            finally
            {
                if (regKey != null)
                    regKey.Close();
            }
            return name;
        }
    }
}
