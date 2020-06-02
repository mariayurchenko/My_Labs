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
    public partial class NewClient : Form
    {
        private SqlConnection sqlConnection;
        public NewClient(SqlConnection connection)
        {
            InitializeComponent();
            sqlConnection = connection;

        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }

        

        private async void login_Click(object sender, EventArgs e)
        {
            SqlCommand insertClientCommand = new SqlCommand("INSERT INTO [Clients] (name, dataVisit,phoneNumber,email,dateOfBirth,note) VALUES (@name, @dataVisit,@phoneNumber,@email,@dateOfBirth,@note)", sqlConnection);

            if (nameTextBox.Text == "" || dataVisitDateTimePicker.Text == "" || dateOfBirthDateTimePicker.Text == "")
            {
                MessageBox.Show("Помилка! Не всі данні введенні!");
            }
            else if ((phoneNumberTextBox.Text == "" && emailTextBox.Text == ""))
            {
                MessageBox.Show("Помилка! Укажіть номер телефону або email!");
            }
            else
            {
               
                insertClientCommand.Parameters.AddWithValue("name", nameTextBox.Text);
                insertClientCommand.Parameters.AddWithValue("dataVisit",Convert.ToDateTime(dataVisitDateTimePicker.Text));
                insertClientCommand.Parameters.AddWithValue("phoneNumber", phoneNumberTextBox.Text);
                insertClientCommand.Parameters.AddWithValue("email", emailTextBox.Text);
                insertClientCommand.Parameters.AddWithValue("dateOfBirth", Convert.ToDateTime(dateOfBirthDateTimePicker.Text));
                insertClientCommand.Parameters.AddWithValue("note", noteTextBox.Text);
                
                try
                {
                    await insertClientCommand.ExecuteNonQueryAsync();
                    MessageBox.Show("Нового клієнта було додано!");
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }
        private Point lastPoint;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void close_MouseEnter(object sender, EventArgs e)
        {
            close.ForeColor = Color.Red;
        }

        private void close_MouseLeave(object sender, EventArgs e)
        {
            close.ForeColor = Color.White;
        }

        private void NewClient_Load(object sender, EventArgs e)
        {
            int ScreenWidth = Screen.PrimaryScreen.Bounds.Width;
            int ScreenHeight = Screen.PrimaryScreen.Bounds.Height;

            this.Location = new Point((ScreenWidth / 2) - (this.Width / 2), (ScreenHeight / 2) - (this.Height / 2));
        }
    }
}
