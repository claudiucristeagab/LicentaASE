using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LicentaCristeaClaudiu
{
    public partial class LoginForm : Form
    {
        private Boolean loggedIn;
        public LoginForm()
        {
            InitializeComponent();
            this.loggedIn = false;
        }

        public LoginForm(String server, String database)
        {
            InitializeComponent();
            this.loggedIn = false;
            this.textBox1.Text = server;
            this.textBox4.Text = database;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm.builder = null;
            SqlConnectionStringBuilder builderLocal = new SqlConnectionStringBuilder();
            loggedIn = false;
            builderLocal.DataSource = textBox1.Text;
            builderLocal.UserID = textBox2.Text;
            builderLocal.Password = textBox3.Text;
            builderLocal.InitialCatalog = textBox4.Text;
            labelLoginSuccessful.ForeColor = DefaultForeColor;
            labelLoginSuccessful.Visible = true;
            if (!String.IsNullOrEmpty(textBox1.Text))
            {
                Thread thread = new Thread(() => { executeCheckConnectionThread(builderLocal); });
                thread.Start();
            }
            
        }

        private void buttonLoginDebug_Click(object sender, EventArgs e)
        {
            MainForm.builder = null;
            SqlConnectionStringBuilder builderLocal = new SqlConnectionStringBuilder();
            loggedIn = false;
            ImportExportHelper ieh = new ImportExportHelper();
            String[] loginData = ieh.LoadFromFile("loginDebug.txt").Split(new String[] { "\r\n", "\n" }, StringSplitOptions.None);
            builderLocal.DataSource = loginData[0];
            builderLocal.UserID = loginData[1];
            builderLocal.Password = loginData[2];
            builderLocal.InitialCatalog = loginData[3];
            labelLoginSuccessful.Text = "Logging in...";
            labelLoginSuccessful.ForeColor = DefaultForeColor;
            labelLoginSuccessful.Visible = true;
            Thread thread = new Thread(() => { executeCheckConnectionThread(builderLocal); });
            thread.Start();
        }

        private void executeCheckConnectionThread(SqlConnectionStringBuilder builderLocal)
        {
            try
            {
                SqlConnection connection = new SqlConnection(builderLocal.ConnectionString);
                connection.Open();
                Console.WriteLine(connection.State.ToString());
                connection.Close();
                MainForm.builder = builderLocal;
                Action action = async () =>
                {
                    loggedIn = true;
                    labelLoginSuccessful.Text = "Connexion established!";
                    labelLoginSuccessful.ForeColor = Color.Green;
                    labelLoginSuccessful.Visible = true;
                    if (loggedIn)
                    {
                        await Task.Delay(1000);
                        this.Close();
                    } 
                };
                this.BeginInvoke(action);   
            }
            catch (SqlException ex)
            {
                Action action = () =>
                {
                    labelLoginSuccessful.Text = "Could not connect!";
                    labelLoginSuccessful.ForeColor = Color.Red;
                    labelLoginSuccessful.Visible = true;
                };
                this.BeginInvoke(action);
            }
            catch (InvalidOperationException ex)
            {
                Action action = () =>
                {
                    labelLoginSuccessful.Text = "Could not connect!";
                    labelLoginSuccessful.ForeColor = Color.Red;
                    labelLoginSuccessful.Visible = true;
                };
                this.BeginInvoke(action);
            }
            catch (TimeoutException ex)
            {
                Action action = () =>
                {
                    labelLoginSuccessful.Text = "Could not connect!";
                    labelLoginSuccessful.ForeColor = Color.Red;
                    labelLoginSuccessful.Visible = true;
                };
                this.BeginInvoke(action);
            }
        }

        private void buttonLoginQuitApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
