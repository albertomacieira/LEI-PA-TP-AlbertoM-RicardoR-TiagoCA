using System.Security.Cryptography;
using System;

namespace Ticket2Help.Utils
{
    /// <summary>
    /// Classe utilitária responsável por operações de hashing de palavras-passe.
    /// Utiliza o algoritmo PBKDF2 com salt para aumentar a segurança.
    /// </summary>
    public static class PasswordHasher
    {
        /// <summary>
        /// Gera um hash seguro a partir de uma palavra-passe em texto simples.
        /// Inclui um salt aleatório de 8 bytes concatenado ao hash.
        /// </summary>
        /// <param name="password">Palavra-passe em texto simples a ser cifrada.</param>
        /// <returns>String com o formato "salt:hash" codificada em Base64.</returns>
        public static string HashPassword(string password)
        {
            using var rng = RandomNumberGenerator.Create();
            byte[] salt = new byte[8];
            rng.GetBytes(salt);

            using var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 10000);
            byte[] hash = pbkdf2.GetBytes(32);

            return $"{Convert.ToBase64String(salt)}:{Convert.ToBase64String(hash)}";
        }

        /// <summary>
        /// Verifica se uma palavra-passe corresponde ao hash previamente gerado.
        /// </summary>
        /// <param name="password">Palavra-passe introduzida pelo utilizador.</param>
        /// <param name="hashedPassword">Hash guardado (com salt incluído) a verificar.</param>
        /// <returns>Verdadeiro se a palavra-passe corresponder ao hash, falso caso contrário.</returns>
        public static bool VerifyPassword(string password, string hashedPassword)
        {
            var parts = hashedPassword.Split(':');
            if (parts.Length != 2) return false;

            byte[] salt = Convert.FromBase64String(parts[0]);
            byte[] storedHash = Convert.FromBase64String(parts[1]);

            using var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 10000);
            byte[] hash = pbkdf2.GetBytes(32);

            return hash.SequenceEqual(storedHash);
        }
    }
}
