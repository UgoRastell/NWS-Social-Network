using System;
using System.Collections.Generic;

namespace Models
{
    public class Post
    {
        public string PostId { get; set; }
        public string UserId { get; set; } // Clé étrangère pour User
        public string Content { get; set; }
        public DateTime Timestamp { get; set; }
        public List<string> ImageUrls { get; set; } = new List<string>();

        // Propriété de navigation pour relier au modèle User
        public virtual User User { get; set; }
    }
}
