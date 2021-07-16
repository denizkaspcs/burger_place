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
    public partial class SignupForm : Form
    {
        public SignupForm()
        {
            InitializeComponent();
        }
        private bool mouseDown;
        private Point lastLocation;

        private void SignupForm_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void SignupForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void SignupForm_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        private void SignupForm_Load(object sender, EventArgs e)
        {

        }

        private void exit_button_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void burger_logo_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void email_label_Click(object sender, EventArgs e)
        {

        }
        public string conString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=BurgerPlace;Integrated Security=True";

        private void register_button_Click(object sender, EventArgs e)
        {
            string name, surname, email, pwd;
            name = name_tb.Text;
            surname = surname_tb.Text;
            email = email_tb.Text;
            pwd = pwd_tb.Text;


            SqlConnection conn = new SqlConnection(conString);
            conn.Open();
            if (conn.State == System.Data.ConnectionState.Open)
            {
                try
                {
                    string comp = "_";
                    string sql = "INSERT INTO [User](email,password) VALUES('" + email + "'" + ",'" + pwd + "')";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    register_button.Text = "Sign-up sucessfull";
                    
                }
                catch
                {
                    register_button.Text = "Email already exist";
                }
            }
        }
    }
}
