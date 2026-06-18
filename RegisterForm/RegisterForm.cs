using LoginSystem.Context;
using LoginSystem.Models;
using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginSystem
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            LoadRoles();
        }

        private void LoadRoles()
        {
            using var db = new AppDbContext();
            var roles = db.Roles.ToList();
            cmbRole.DataSource = roles;
            cmbRole.DisplayMember = "Name";
            cmbRole.ValueMember = "Id";

        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;
            string confirm = txtConfirm.Text;
            string selectedRole = (cmbRole.SelectedItem as Role)?.Name;


            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(password))

            {
                MessageBox.Show("Todos os campos são obrigatório.");
                return;
            }

            if (password != confirm)
            {
                MessageBox.Show("As senhas não coincidem.");
                return;
            }

            bool success = AuthService.RegisterUser(username, email, password,
    selectedRole);
            if (success)
            {
                MessageBox.Show("Usuário cadastrado com sucesso! Faça login.");
                this.Close();

            }
            else
            {
                MessageBox.Show("Nome de usuário ou email já existente.");
            }


        }
    }

    public static partial class AuthService
    {
        public static bool RegisterUser(string username, string email, string password, string role)
        {
            using var db = new AppDbContext();

            if (db.Users.Any(u => u.Username == username || u.Email == email))
                return false;

            var user = new User
            {
                Username = username,
                Email = email,
                Password = password, // consider hashing in real app
                Role = role
            };

            db.Users.Add(user);
            db.SaveChanges();
            return true;
        }
    }
}

