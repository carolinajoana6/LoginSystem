using System.Windows.Forms;
using System;
using LoginSystem.Context;

namespace LoginSystem;
static class Program
{

    [STAThread]
    static void Main()
    {
        Application.SetHighDpiMode(HighDpiMode.SystemAware);
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);

        //Garante que o banco seja criado e as Migrations aplicadas 
        using ( var db = new AppDbContext())
        {
            db.Database.EnsureCreated(); //Cria o banco se não existir
        }

        while (true)
        {
            using (var loginForm = new LoginForm())

            {
                var result = loginForm.ShowDialog();
                if (result == DialogResult.OK && Session.LoggedUser != null)
                {

                    Application.Run(new MainForm());
                    //Se o MainForm fechar, volta para o loop (logout ou
                    //restart)
                    
                   // Se quiser realmente encerrar, braek;
                }
                else
                {
                    break; // Fechou o login sem sucesso
                }
            }
        }
    }
}
    
    
  