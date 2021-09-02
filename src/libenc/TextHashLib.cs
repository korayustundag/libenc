using System;
using System.Security.Cryptography;
using System.Text;

namespace libenc
{
    /// <summary>
    /// Performs checksums of texts
    /// </summary>
    public static class TextHashLib
    {
        /// <summary>
        /// Making SHA1 checksum of any text.
        /// </summary>
        /// <param name="text">Represents text as a sequence of UTF-8 code units.</param>
        /// <returns>Returns the SHA1 checksum of the typed text.</returns>
        public static string SHA1Checksum(string text)
        {
            using (SHA1 sha1hash = new SHA1CryptoServiceProvider())
            {
                byte[] textbytes = UTF8Encoding.UTF8.GetBytes(text);
                byte[] hash = sha1hash.ComputeHash(textbytes);
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hash.Length; i++)
                {
                    sb.Append(hash[i].ToString("x2"));
                }
                return sb.ToString();
            }
        }
        /// <summary>
        /// Making SHA256 checksum of any text.
        /// </summary>
        /// <param name="text">Represents text as a sequence of UTF-8 code units.</param>
        /// <returns>Returns the SHA256 checksum of the typed text.</returns>
        public static string SHA256Checksum(string text)
        {
            using (SHA256 sha256hash = new SHA256CryptoServiceProvider())
            {
                byte[] textbytes = UTF8Encoding.UTF8.GetBytes(text);
                byte[] hash = sha256hash.ComputeHash(textbytes);
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hash.Length; i++)
                {
                    sb.Append(hash[i].ToString("x2"));
                }
                return sb.ToString();
            }
        }
        /// <summary>
        /// Making SHA384 checksum of any text.
        /// </summary>
        /// <param name="text">Represents text as a sequence of UTF-8 code units.</param>
        /// <returns>Returns the SHA384 checksum of the typed text.</returns>
        public static string SHA384Checksum(string text)
        {
            using (SHA384 sha384hash = new SHA384CryptoServiceProvider())
            {
                byte[] textbytes = UTF8Encoding.UTF8.GetBytes(text);
                byte[] hash = sha384hash.ComputeHash(textbytes);
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hash.Length; i++)
                {
                    sb.Append(hash[i].ToString("x2"));
                }
                return sb.ToString();
            }
        }
        /// <summary>
        /// Making SHA512 checksum of any text.
        /// </summary>
        /// <param name="text">Represents text as a sequence of UTF-8 code units.</param>
        /// <returns>Returns the SHA512 checksum of the typed text.</returns>
        public static string SHA512Checksum(string text)
        {
            using (SHA512 sha512hash = new SHA512CryptoServiceProvider())
            {
                byte[] textbytes = UTF8Encoding.UTF8.GetBytes(text);
                byte[] hash = sha512hash.ComputeHash(textbytes);
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hash.Length; i++)
                {
                    sb.Append(hash[i].ToString("x2"));
                }
                return sb.ToString();
            }
        }
        /// <summary>
        /// Making MD5 checksum of any text.
        /// </summary>
        /// <param name="text">Represents text as a sequence of UTF-8 code units.</param>
        /// <returns>Returns the MD5 checksum of the typed text.</returns>
        public static string MD5Checksum(string text)
        {
            using (MD5 md5hash = new MD5CryptoServiceProvider())
            {
                byte[] textbytes = UTF8Encoding.UTF8.GetBytes(text);
                byte[] hash = md5hash.ComputeHash(textbytes);
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hash.Length; i++)
                {
                    sb.Append(hash[i].ToString("x2"));
                }
                return sb.ToString();
            }
        }
    }
}
