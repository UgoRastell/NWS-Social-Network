using System;
using System.Collections.Generic;

namespace Models
{
    public class User
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }

        // Propriété de navigation pour les posts de l'utilisateur
        public virtual ICollection<Post> Posts { get; set; } = new List<Post>();

        public string AvatarUrl => GetGravatarUrl(this.Email);

        private static string GetGravatarUrl(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return null;

            var normalizedEmail = email.Trim().ToLower();
            var hash = ComputeSha256Hash(normalizedEmail);
            return $"https://www.gravatar.com/avatar/{hash}";
        }

        private static string ComputeSha256Hash(string rawData)
        {
            using (var sha256Hash = System.Security.Cryptography.SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(System.Text.Encoding.UTF8.GetBytes(rawData));

                var builder = new System.Text.StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}
