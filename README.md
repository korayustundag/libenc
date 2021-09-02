# Libenc
Simplified Encryption Library
## Requirements
- [.NET Framework 4.7.2](https://dotnet.microsoft.com/download/dotnet-framework/net472) or higher version
## Download
[![GitHub Download Windows](https://img.shields.io/badge/Download-Windows-brightgreen)](https://github.com/korayustundag/libenc/releases)
## Examples
SHA256 Text Hash

    string sha_256_example = TextHashLib.SHA256Checksum("hello!");
SHA256 File Checksum

    string sha_256_file_example = FileHashLib.SHA256Checksum("demofile.txt");
Example Project
```
using System;
using libenc;

namespace Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Enclib Examples";

            string sha_256_example = TextHashLib.SHA256Checksum("hello!");

            string sha_512_example = TextHashLib.SHA512Checksum("hello!");

            string base64_encode_example = TextEncoding.Base64Encode("hello!");

            string base64_decode_example = TextDecoding.Base64Decode(base64_encode_example);

            string sha_256_file_example = FileHashLib.SHA256Checksum("demofile.txt");

            string url_encode_example = TextEncoding.UrlEncode("https://github.com/korayustundag/libenc");

            string url_decode_example = TextDecoding.UrlDecode(url_encode_example);

            Console.WriteLine("SHA256: " + sha_256_example);
            Console.WriteLine("SHA512: " + sha_512_example);
            Console.WriteLine("Base64 Encode: " + base64_encode_example);
            Console.WriteLine("Base64 Decode: " + base64_decode_example);
            Console.WriteLine("SHA256 File: " + sha_256_file_example);
            Console.WriteLine("URL Encode: " + url_encode_example);
            Console.WriteLine("URL Decode: " + url_decode_example);
            Console.ReadKey();
        }
    }
}
```

## Methods
- MD5
- SHA1
- SHA256
- SHA384
- SHA512
- Base64 Encoding
- Base64 Decoding
- Url Encoding
- Url Decoding
- Html Encoding
- Html Decoding
## Coming Soon
- RSA
- AES
