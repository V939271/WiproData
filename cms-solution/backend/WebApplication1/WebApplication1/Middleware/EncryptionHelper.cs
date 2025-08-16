// File: Middleware/EncryptionHelper.cs
// .NET 6 / 7 / 8 compatible – uses modern Rfc2898DeriveBytes overload and SHA-256

using System.Security.Cryptography;
using System.Text;

namespace WebApplication1.Middleware
{
    public static class EncryptionHelper
    {
        // In production move this to appsettings or a secure store (Azure Key Vault, AWS Secrets Manager, etc.)
        private const string Key = "abc123";

        // Salt must be at least 8 bytes; keep it constant so the same input produces the same cipher.
        private static readonly byte[] Salt =
        {
            0x49, 0x76, 0x61, 0x6E, 0x20,
            0x4D, 0x65, 0x64, 0x76, 0x65,
            0x64, 0x65, 0x76
        };

        // NIST SP 800-132 recommends ≥ 100 000 iterations
        private const int Iterations = 100_000;

        public static string Encrypt(string clearText)
        {
            byte[] clearBytes = Encoding.UTF8.GetBytes(clearText);

            using Aes aes = Aes.Create();
            using var pdb = new Rfc2898DeriveBytes(
                password: Key,
                salt: Salt,
                iterations: Iterations,
                hashAlgorithm: HashAlgorithmName.SHA256);

            aes.Key = pdb.GetBytes(32);   // 256-bit key
            aes.IV = pdb.GetBytes(16);   // 128-bit IV

            using var ms = new MemoryStream();
            using (var cs = new CryptoStream(ms, aes.CreateEncryptor(), CryptoStreamMode.Write))
            {
                cs.Write(clearBytes, 0, clearBytes.Length);
                cs.FlushFinalBlock();
            }
            return Convert.ToBase64String(ms.ToArray());
        }

        public static string Decrypt(string cipherText)
        {
            byte[] cipherBytes = Convert.FromBase64String(cipherText);

            using Aes aes = Aes.Create();
            using var pdb = new Rfc2898DeriveBytes(
                password: Key,
                salt: Salt,
                iterations: Iterations,
                hashAlgorithm: HashAlgorithmName.SHA256);

            aes.Key = pdb.GetBytes(32);
            aes.IV = pdb.GetBytes(16);

            using var ms = new MemoryStream();
            using (var cs = new CryptoStream(ms, aes.CreateDecryptor(), CryptoStreamMode.Write))
            {
                cs.Write(cipherBytes, 0, cipherBytes.Length);
                cs.FlushFinalBlock();
            }
            return Encoding.UTF8.GetString(ms.ToArray());
        }
    }
}
