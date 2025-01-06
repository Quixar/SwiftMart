using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SwiftMart.Hash
{
    public class PasswordHasher
    {
        private const int SaltSize = 16; // 16 байт для соли
        private const int HashSize = 32; // 32 байта для хэша
        private const int Iterations = 100_000; // Количество итераций (чем больше, тем безопаснее, но медленнее)

        /// <summary>
        /// Хэширует пароль с использованием соли и PBKDF2.
        /// </summary>
        /// <param name="password">Пароль в текстовом виде.</param>
        /// <returns>Строка, содержащая соль и хэш, закодированные в Base64.</returns>
        public static string HashPassword(string password)
        {
            // Генерация соли
            byte[] salt = RandomNumberGenerator.GetBytes(SaltSize);

            // Хэширование пароля с использованием соли
            using (var pbkdf2 = new Rfc2898DeriveBytes(password, salt, Iterations, HashAlgorithmName.SHA256))
            {
                byte[] hash = pbkdf2.GetBytes(HashSize);

                // Объединение соли и хэша
                byte[] hashBytes = new byte[SaltSize + HashSize];
                Array.Copy(salt, 0, hashBytes, 0, SaltSize);
                Array.Copy(hash, 0, hashBytes, SaltSize, HashSize);

                // Возврат результата в виде строки Base64
                return Convert.ToBase64String(hashBytes);
            }
        }

        /// <summary>
        /// Проверяет пароль, сравнивая его с сохраненным хэшем.
        /// </summary>
        /// <param name="password">Введенный пароль.</param>
        /// <param name="storedHash">Сохраненный хэш пароля.</param>
        /// <returns>True, если пароль верный, иначе False.</returns>
        public static bool VerifyPassword(string password, string storedHash)
        {
            // Декодируем хэш из Base64
            byte[] hashBytes = Convert.FromBase64String(storedHash);

            // Извлекаем соль (первые 16 байт)
            byte[] salt = new byte[SaltSize];
            Array.Copy(hashBytes, 0, salt, 0, SaltSize);

            // Извлекаем хэш из оставшейся части
            byte[] storedPasswordHash = new byte[HashSize];
            Array.Copy(hashBytes, SaltSize, storedPasswordHash, 0, HashSize);

            // Хэшируем введенный пароль с той же солью
            using (var pbkdf2 = new Rfc2898DeriveBytes(password, salt, Iterations, HashAlgorithmName.SHA256))
            {
                byte[] computedHash = pbkdf2.GetBytes(HashSize);

                // Сравниваем хэши
                return CryptographicOperations.FixedTimeEquals(storedPasswordHash, computedHash);
            }
        }
    }
}
