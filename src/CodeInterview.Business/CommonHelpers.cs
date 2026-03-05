using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace CodeInterview.Business
{
    public static class CommonHelpers
    {
        public static string GetHash(string input)
        {
            var bytes = Encoding.UTF8.GetBytes(input); 
            var hashBytes = SHA256.HashData(bytes); 
            return Convert.ToHexString(hashBytes).ToLowerInvariant();
        }

        public static string GetHash<T>(T input)
        {
            var json = System.Text.Json.JsonSerializer.Serialize(input);
            return GetHash(json);
        }
    }
}
