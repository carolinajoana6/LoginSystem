using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace LoginSystem.Models
{
    public class User
    {
        [Key] 
        public int Id { get; set; }

        [Required,MaxLength(50)]
        public string Username { get; set; }

        [Required, MaxLength(100)]
        public string Email { get; set; }

        [Required]
        public string PasswordHash { get; set; }
        public DateTime CreateAt { get; set; } = DateTime.Now;

        // Relacionamento muitos-para-muitos com Role
         public ICollection<UserRole> UserRoles { get; set; }

    }
}
