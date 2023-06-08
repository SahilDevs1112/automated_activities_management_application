using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automated_Activities
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        public SqlConnection con = new SqlConnection(@"Data Source=USHYDSAKHUNTIA4;Initial Catalog=AutomatedActivites;Integrated Security=True;Connect Timeout=30;Encrypt=False");
        private void button1_Click(object sender, EventArgs e)
        {

            if (UserNameTB.Text == "" || PasswordTB.Text == "")
            {
                MessageBox.Show("Required fields are empty");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "Select * From Users Where UserName = '" + UserNameTB.Text + "' and Password = '" + PasswordTB.Text + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    if(dt.Rows.Count > 0) {
                        this.Hide();
                        MainPage mp = new MainPage();
                        mp.Show();
                    }
                    con.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void ShowPasswordCB_CheckedChanged(object sender, EventArgs e)
        {   
            if (ShowPasswordCB.Checked)
            {
                PasswordTB.PasswordChar = '\0';
            }
            else
            {
                PasswordTB.PasswordChar = '*';
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            if (UserNameTB.Text == "" || PasswordTB.Text == "")
            {
                MessageBox.Show("Required fields are empty");
            }
            else
            {
                try
                {   
                    con.Open();
                    string query = "Select * From Users Where UserName = '" + UserNameTB.Text + "' and Password = '" + PasswordTB.Text + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("This User is already Existing");
                    }
                    else
                    {
                        string query2 = "Insert Into Users (UserName,Password) Values('" + UserNameTB.Text + "','" + PasswordTB.Text + "')";
                        SqlCommand cmd = new SqlCommand(query2, con);   
                        cmd.ExecuteNonQuery();
                        this.Hide();
                        MainPage mp = new MainPage();
                        mp.Show();
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
