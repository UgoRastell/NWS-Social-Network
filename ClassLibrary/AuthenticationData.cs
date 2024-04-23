using System;

namespace Models
{
    public class AuthenticationData
    {
        public string AuthenticationDataId { get; set; }
        public string AccessToken { get; set; }
        public DateTime Expiry { get; set; }
        public string UserId { get; set; } // Clé étrangère pour User

        // Propriété de navigation pour relier au modèle User
        public virtual User User { get; set; }
    }
}
