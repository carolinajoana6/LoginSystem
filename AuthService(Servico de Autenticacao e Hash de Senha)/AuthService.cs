//
using LoginSystem.Context;
using LoginSystem.Models;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using Microsoft.EntityFrameworkCore;

namespace LoginSystem
{
    public static partial class AuthService
    {
        // NOVO: Método para gerar o hash da senha ao registrar o usuário
        public static string HashPassword(string plainPassword)
        {
            return BCrypt.Net.BCrypt.HashPassword(plainPassword);
        }

        // MANTIDO: Seu método original para verificar a senha no login
        public static bool VerifyPassword(string plainPassword, string hashedPassword)
        {
            return BCrypt.Net.BCrypt.Verify(plainPassword, hashedPassword);
        }

        public static User Authenticate(string username, string password)
        {
            using var db = new AppDbContext();
            var user = db.Users
                    .Include(u => u.UserRoles)
                    .ThenInclude(ur => ur.Role)
                    .FirstOrDefault(u => u.Username == username);
            if (user == null)
                return null;

            // AJUSTADO: Agora chama o VerifyPassword para validar as duas strings
            bool valid = VerifyPassword(password, user.PasswordHash);
            return valid ? user : null;
        }

        public static bool RegisterUser(string username, string email, string password, string roleName = "User")
        {
            using var db = new AppDbContext();
            // Verifica se o usuário já existe
            if (db.Users.Any(u => u.Username == username || u.Email == email))
                return false;

            var role = db.Roles.FirstOrDefault(r => r.Name == roleName);
            if (role == null) role = db.Roles.First(r => r.Name == "User");

            var user = new User
            {
                Username = username,
                Email = email,
                // CORRIGIDO: Agora chama a nova sobrecarga que aceita apenas 1 parâmetro e gera o hash correto
                PasswordHash = HashPassword(password)
            };
            db.Users.Add(user);
            db.SaveChanges(); // Salva para gerar o Id do usuário

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
