using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libenc
{
    /// <summary>
    /// Performs Encoding of texts
    /// </summary>
    public static class TextEncoding
    {
        /// <summary>
        /// Converts text to the equivalent string representation encoded in base-64 digits.
        /// </summary>
        /// <param name="text">Represents text as a sequence of UTF-16 code units.</param>
        /// <returns>The string representation, in base 64, of the contents of texts.</returns>
        public static string Base64Encode(string text)
        {
            byte[] textBytes = UTF8Encoding.UTF8.GetBytes(text);
            return Convert.ToBase64String(textBytes);
        }
        /// <summary>
        /// Encodes a URL string.
        /// </summary>
        /// <param name="url">The text to encode.</param>
        /// <returns>An encoded string.</returns>
        public static string UrlEncode(string url)
        {
            return System.Web.HttpUtility.UrlEncode(url);
        }
        /// <summary>
        /// Encodes a URL string.
        /// </summary>
        /// <param name="url">The Uri type of text to encode.</param>
        /// <returns>An encoded string.</returns>
        public static string UrlEncode(Uri url)
        {
            return System.Web.HttpUtility.UrlEncode(url.AbsoluteUri);
        }
        /// <summary>
        /// Converts a string to an HTML-encoded string.
        /// </summary>
        /// <param name="html">The string to encode.</param>
        /// <returns>An encoded string.</returns>
        public static string HtmlEncode(string html)
        {
            return System.Web.HttpUtility.HtmlEncode(html);
        }
    }
}
