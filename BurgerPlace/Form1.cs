using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace BurgerPlace
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        public string conString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=BurgerPlace;Integrated Security=True";
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void email_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void login_button_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(conString);
            conn.Open();
            if(conn.State == System.Data.ConnectionState.Open)
            {
                string email = email_tb.Text;
                string pwd = pwd_tb.Text;
                string comp = "_";
                string sql = "SELECT password FROM [User] WHERE email = '" + email + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                //cmd.ExecuteNonQuery();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        comp = reader[0].ToString();
                    }
                }
                if(comp == pwd)
                {
                    login_button.Text = "Log-in successfull";
                    MainForm mf = new MainForm(email);
                    mf.Show();
                    this.Hide();
                }
                else
                {
                    login_button.Text = "Wrong id/password combination";
                }
                return;
            }
            login_button.Text = "Wrong id/password combination";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        private void signup_button_Click(object sender, EventArgs e)
        {
            SignupForm newForm = new SignupForm();
            newForm.Show();
        }

        private bool mouseDown;
        private Point lastLocation;

        private void LoginForm_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void LoginForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void LoginForm_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void pwd_tb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login_button_Click(sender , e);
            }
        }
    }
}
