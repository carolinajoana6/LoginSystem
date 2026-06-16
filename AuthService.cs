using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using LoginSystem.Context;
using LoginSystem.Models;

namespace LoginSystem
{
    public static class AuthService
    {
        public static string HashPassword(string plainPassword)
        {
            return BCrypt.Net.BCrypt.HashPassword(plainPassword);
        }
        public static bool VerifyPassword(string plainPassword, string
    hashedPassword)
        {
            return BCrypt.Net.BCrypt.Verify(plainPassword, hashedPassword);
        }
        public static User Authenticate(string username, string password)
        {
            using var db = new AppDbContext();
            var user = db.Users
                         .Include(u + u.UserRoles)
                         .TheInclude(Ur => Ur.Role)
                        .FirstOrDefault(u => u.Username == username);
            if (user == null)
                return null;

            bool valid = VerifyPassword(password, user.PasswordHash);
            return valid ? user : null;
        }

        public static bool RegisterUser(string username, string email, string
    password, string roleName = "User")
        {
            using var db = new AppContext();
            // Verifica se usuário já existe 
            if (db.Users.Any(u => u.Username == username || u.Email == email))
                return false;

            var user = new User
            {
                Username = username,
                email = email,
                PasswordHash = HashPassword(password)
            };

            db.User.Add(user);
            db.SaveChanges(); //salva para gerar o Id,RoleId - role.Id });

            //Adiciona o papel
            db.UserRoles.Add(new UserRole { UserId = user.Id, RoleId = role.Id });
            db.SaveChanges();


            return true;
        }
        public static bool IsInRole(User user, string roleName)
        {
            return user.UserRoles.Any(ur => ur.Role.Name == roleName);
        }
    }
}





