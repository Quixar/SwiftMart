using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Provides functionality for securely hashing and verifying passwords using PBKDF2 (Password-Based Key Derivation Function 2).
/// The hashing process involves the use of a salt, a secure hash algorithm (SHA-256), and a high number of iterations to ensure strong security.
/// </summary>
namespace SwiftMart.Hash
{
    public class PasswordHasher
    {

        /// <summary>
        /// The size of the salt used in the password hashing process.
        /// </summary>
        private const int SaltSize = 16;

        /// <summary>
        /// The size of the hash used in the password hashing process.
        /// </summary>
        private const int HashSize = 32;

        /// <summary>
        /// The number of iterations used in the PBKDF2 algorithm to strengthen the hash.
        /// A higher number of iterations increases security.
        /// </summary>
        private const int Iterations = 100_000;

        /// <summary>
        /// Hashes a password using a salt and the PBKDF2 algorithm with SHA-256.
        /// The resulting hash is returned as a Base64 encoded string.
        /// </summary>
        /// <param name="password">The plain-text password to be hashed.</param>
        /// <returns>A Base64 encoded string representing the hashed password and the salt.</returns>

        public static string HashPassword(string password)
        {
            byte[] salt = RandomNumberGenerator.GetBytes(SaltSize);

            using (var pbkdf2 = new Rfc2898DeriveBytes(password, salt, Iterations, HashAlgorithmName.SHA256))
            {
                byte[] hash = pbkdf2.GetBytes(HashSize);

                byte[] hashBytes = new byte[SaltSize + HashSize];
                Array.Copy(salt, 0, hashBytes, 0, SaltSize);
                Array.Copy(hash, 0, hashBytes, SaltSize, HashSize);

                return Convert.ToBase64String(hashBytes);
            }
        }

        /// <summary>
        /// Verifies if a given password matches the stored hash.
        /// This method uses the salt from the stored hash to re-compute the password hash and compares it in constant time to prevent timing attacks.
        /// </summary>
        /// <param name="password">The plain-text password to verify.</param>
        /// <param name="storedHash">The stored hash (Base64 encoded) to compare against.</param>
        /// <returns>True if the password is valid, false otherwise.</returns>

        public static bool VerifyPassword(string password, string storedHash)
        {
            byte[] hashBytes = Convert.FromBase64String(storedHash);

            byte[] salt = new byte[SaltSize];
            Array.Copy(hashBytes, 0, salt, 0, SaltSize);

            byte[] storedPasswordHash = new byte[HashSize];
            Array.Copy(hashBytes, SaltSize, storedPasswordHash, 0, HashSize);

            using (var pbkdf2 = new Rfc2898DeriveBytes(password, salt, Iterations, HashAlgorithmName.SHA256))
            {
                byte[] computedHash = pbkdf2.GetBytes(HashSize);

                return CryptographicOperations.FixedTimeEquals(storedPasswordHash, computedHash);
            }
        }
    }
}
