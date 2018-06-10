using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LicentaCristeaClaudiu
{
    class LoginHelper
    {
        private LoginForm loginForm;
        private SqlConnectionStringBuilder builder;

        public LoginHelper()
        {
            this.loginForm = new LoginForm();
            this.builder = MainForm.builder;
        }

        public void StartLoginForm()
        {
            loginForm.ShowDialog();
        }

        public void StartLoginFormPartiallyFilled()
        {
            loginForm = new LoginForm(builder.DataSource, builder.InitialCatalog);
            loginForm.ShowDialog();
        }
    }
}
