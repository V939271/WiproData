using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace UserManagement
{
    public static class CryptoService
    {
        // ---------- PBKDF2-based password hashing ----------
        public static Tuple<byte[], byte[]> HashPassword(string password)
        {
            // 128-bit salt
            var salt = new byte[16];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
            }

            var hash = HashWithSalt(password, salt);
            return Tuple.Create(hash, salt);
        }

        public static bool VerifyPassword(string password, byte[] hash, byte[] salt)
        {
            if (hash == null || salt == null) return false;
            var computed = HashWithSalt(password, salt);
            return FixedTimeEquals(hash, computed);
        }

        private static byte[] HashWithSalt(string password, byte[] salt)
        {
            using (var pbkdf2 = new Rfc2898DeriveBytes(
                   password, salt, 100_000, HashAlgorithmName.SHA256))
            {
                return pbkdf2.GetBytes(32);          // 256-bit hash
            }
        }

        private static bool FixedTimeEquals(byte[] a, byte[] b)
        {
            if (a.Length != b.Length) return false;
            var diff = 0;
            for (var i = 0; i < a.Length; i++)
                diff |= a[i] ^ b[i];
            return diff == 0;
        }

        // ---------- AES-256 encryption ----------
        public static byte[] Encrypt(string plainText, byte[] key, byte[] iv)
        {
            using (var aes = Aes.Create())
            {
                aes.Key = key;
                aes.IV = iv;
                using (var enc = aes.CreateEncryptor())
                {
                    return Transform(Encoding.UTF8.GetBytes(plainText), enc);
                }
            }
        }

        public static string Decrypt(byte[] cipher, byte[] key, byte[] iv)
        {
            using (var aes = Aes.Create())
            {
                aes.Key = key;
                aes.IV = iv;
                using (var dec = aes.CreateDecryptor())
                {
                    var plain = Transform(cipher, dec);
                    return Encoding.UTF8.GetString(plain);
                }
            }
        }

        private static byte[] Transform(byte[] data, ICryptoTransform tx)
        {
            using (var ms = new MemoryStream())
            {
                using (var cs = new CryptoStream(ms, tx, CryptoStreamMode.Write))
                {
                    cs.Write(data, 0, data.Length);
                    cs.FlushFinalBlock();
                    return ms.ToArray();
                }
            }
        }
    }
}
