using System;
using System.Net;
using System.IO;
using System.Windows.Forms;

namespace Practice_2__Local_Web_Bookmark
{
    public static class WebValidator
    {
        public static bool URLExists(string url)
        {
            bool result = false;
            WebRequest webrequest = WebRequest.Create(url);
            webrequest.Timeout = 5000; //in milliseconds
            webrequest.Method = "HEAD";


            HttpWebResponse response = null;

            try
            {
                response = (HttpWebResponse)webrequest.GetResponse();
                result = true;
            }
            catch (WebException webException)
            {
                MessageBox.Show(url + "does not exist:" + webException.Message);

            }
            finally
            {
                if (response != null)
                    response.Close();
            }
            return result;
        }
        public static bool URLIsValid(string url)
        {
            bool result = true;
            try
            {
                HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(url);
                HttpWebResponse webResponse = (HttpWebResponse)webRequest.GetResponse();
                using (Stream sStream = webResponse.GetResponseStream())
                {
                    string read = new StreamReader(sStream).ReadToEnd();
                    sStream.Close();
                }                               
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message, "Empty Url error");
                result = false;
            }
            catch (UriFormatException ex)
            {
                MessageBox.Show(ex.Message, "URL error");
                result = false;
            }           
            catch(WebException ex)
            {
                MessageBox.Show(ex.Message, "Website error");
                result = false;
            }
            return result;
        }       
    }
}
