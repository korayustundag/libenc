using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace libenc
{
    /// <summary>
    /// Performs checksums of files
    /// </summary>
    public static class FileHashLib
    {
        /// <summary>
        /// Making SHA1 checksum of any file.
        /// </summary>
        /// <param name="path">The file to open for reading.</param>
        /// <returns>Returns the SHA1 checksum of the selected file.</returns>
        public static string SHA1Checksum(string path)
        {
            using (SHA1 sha1hash = new SHA1CryptoServiceProvider())
            {
                byte[] file = File.ReadAllBytes(path);
                byte[] hash = sha1hash.ComputeHash(file);
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hash.Length; i++)
                {
                    sb.Append(hash[i].ToString("x2"));
                }
                return sb.ToString();
            }
        }
        /// <summary>
        /// Making SHA256 checksum of any file.
        /// </summary>
        /// <param name="path">The file to open for reading.</param>
        /// <returns>Returns the SHA256 checksum of the selected file.</returns>
        public static string SHA256Checksum(string path)
        {
            using (SHA256 sha256hash = new SHA256CryptoServiceProvider())
            {
                byte[] file = File.ReadAllBytes(path);
                byte[] hash = sha256hash.ComputeHash(file);
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hash.Length; i++)
                {
                    sb.Append(hash[i].ToString("x2"));
                }
                return sb.ToString();
            }
        }
        /// <summary>
        /// Making SHA384 checksum of any file.
        /// </summary>
        /// <param name="path">The file to open for reading.</param>
        /// <returns>Returns the SHA384 checksum of the selected file.</returns>
        public static string SHA384Checksum(string path)
        {
            using (SHA384 sha384hash = new SHA384CryptoServiceProvider())
            {
                byte[] file = File.ReadAllBytes(path);
                byte[] hash = sha384hash.ComputeHash(file);
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hash.Length; i++)
                {
                    sb.Append(hash[i].ToString("x2"));
                }
                return sb.ToString();
            }
        }
        /// <summary>
        /// Making SHA512 checksum of any file.
        /// </summary>
        /// <param name="path">The file to open for reading.</param>
        /// <returns>Returns the SHA512 checksum of the selected file.</returns>
        public static string SHA512Checksum(string path)
        {
            using (SHA512 sha512hash = new SHA512CryptoServiceProvider())
            {
                byte[] file = File.ReadAllBytes(path);
                byte[] hash = sha512hash.ComputeHash(file);
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hash.Length; i++)
                {
                    sb.Append(hash[i].ToString("x2"));
                }
                return sb.ToString();
            }
        }
        /// <summary>
        /// Making MD5 checksum of any file.
        /// </summary>
        /// <param name="path">The file to open for reading.</param>
        /// <returns>Returns the MD5 checksum of the selected file.</returns>
        public static string MD5Checksum(string path)
        {
            using (MD5 md5hash = new MD5CryptoServiceProvider())
            {
                byte[] file = File.ReadAllBytes(path);
                byte[] hash = md5hash.ComputeHash(file);
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
