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

namespace Base
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
           
        }

        private void close_Click(object sender, EventArgs e)
        {
            if (connection != null && connection.State != ConnectionState.Closed)
                connection.Close();
            Application.Exit();
        }

        private void close_MouseEnter(object sender, EventArgs e)
        {
            close.ForeColor = Color.Red;
        }

        private void close_MouseLeave(object sender, EventArgs e)
        {
            close.ForeColor = Color.White;
        }

        private Point lastPoint;

        private void Authorization_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Authorization_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private SqlConnection connection;

        private void login_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\1\Desktop\Base\Base\Database.mdf;Integrated Security=True";
            connection = new SqlConnection(connectionString);
        
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM [Admin] WHERE login='"+ loginUser.Text + "' AND password='" + passUser.Text + "'", connection);

                

            adapter.Fill(table);    
            if (table.Rows.Count>0)
            {
                this.Hide();
              
                BD db = new BD(connection,loginUser.Text);
                db.Show();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль!");
            }

           
        }

        private void Authorization_Load(object sender, EventArgs e)
        {
            int ScreenWidth = Screen.PrimaryScreen.Bounds.Width;
            int ScreenHeight = Screen.PrimaryScreen.Bounds.Height;

            this.Location = new Point((ScreenWidth / 2) - (this.Width / 2), (ScreenHeight / 2) - (this.Height / 2));
        }
    }
}
