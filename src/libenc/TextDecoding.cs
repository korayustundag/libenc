using System;
using System.Text;

namespace libenc
{
    /// <summary>
    /// Performs Decoding of texts
    /// </summary>
    public static class TextDecoding
    {
        /// <summary>
        /// The base64-encoded text is converted to string data type.
        /// </summary>
        /// <param name="base64string">String data of type Base64.</param>
        /// <returns>A decoded string.</returns>
        public static string Base64Decode(string base64string)
        {
            try
            {
                byte[] data = Convert.FromBase64String(base64string);
                return Encoding.UTF8.GetString(data);
            }
            catch (FormatException)
            {
                new FormatException("It's not Base64 string.");
                return null;
            }
        }
        /// <summary>
        /// Converts a string that has been encoded for transmission in a URL into a decoded string.
        /// </summary>
        /// <param name="url">The string to decode</param>
        /// <returns>A decoded string.</returns>
        public static string UrlDecode(string url)
        {
            return System.Web.HttpUtility.UrlDecode(url);
        }
        /// <summary>
        /// Converts a string that has been HTML-encoded for HTTP transmission into a decoded string.
        /// </summary>
        /// <param name="encodedHtml">The string to decode.</param>
        /// <returns>A decoded string.</returns>
        public static string HtmlDecode(string encodedHtml)
        {
            return System.Web.HttpUtility.HtmlDecode(encodedHtml);
        }
    }
}
