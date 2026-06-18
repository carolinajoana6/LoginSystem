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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnAdminPanel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Área administrativa (você pode listar usuárioss, " +
   "etc.)");
            //Abrir um form de administração, etc.
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Session.LoggedUser = null;
            this.Close();
            Application.Restart(); // Ou reabrir o loginForm

        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = $"Bem-Vindo, {Session.LoggedUser.Username}!";
            if (AuthService.IsInRole(Session.LoggedUser, "Admin"))
            {
                btnAdminPanel.Visible = true;
            }
            else
            {
                btnAdminPanel.Visible = false;
            }
        }
    }
}
