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
    public partial class NewCheck : Form
    {
        private SqlConnection sqlConnection;
        private string admin;
        public NewCheck(SqlConnection connection, string admin)
        {
            InitializeComponent();
            sqlConnection = connection;
            SqlCommand getIdLastClient = new SqlCommand("Select MAX(Id) from [Check]", connection);
            int id = (int)getIdLastClient.ExecuteScalar() + 1;
            numberLabel.Text = "Квитанція №" + id;
            this.admin = admin;
            label2.Text = "Адміністратор: " + admin;

        }

        private void NewCheck_Load(object sender, EventArgs e)
        {
            int ScreenWidth = Screen.PrimaryScreen.Bounds.Width;
            int ScreenHeight = Screen.PrimaryScreen.Bounds.Height;

            this.Location = new Point((ScreenWidth / 2) - (this.Width / 2), (ScreenHeight / 2) - (this.Height / 2));

            
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

    

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }

        string nameValue;
        private int numberValue;
        private async void login_Click(object sender, EventArgs e)
        {
           
            SqlCommand insertCheckCommand = new SqlCommand("INSERT INTO [Check] (number,name, dataVisit,dataStart,dataEnd,value,status,note) VALUES (@number,@name, @dataVisit,@dataStart,@dataEnd,@value,@status,@note)", sqlConnection);
       
            if (nameValue == null)
            {
                MessageBox.Show("Помилка! Клієнт з таким id не існує!");
            }
            else if (idTextBox.Text == "" || dataVisitDateTimePicker.Text == "" || dataStartTimePicker.Text == "" || dataEndTimePicker.Text == "" || valueTextBox.Text == "")
            {
                MessageBox.Show("Помилка! Не всі данні введенні!");
            }
            else if (radioButtonYes.Checked == false && radioButtonNo.Checked == false)
            {
                MessageBox.Show("Помилка! Укажіть статус оплати!");
            }
            else
            {
                insertCheckCommand.Parameters.AddWithValue("number", numberValue);
                insertCheckCommand.Parameters.AddWithValue("name", nameValue);
                insertCheckCommand.Parameters.AddWithValue("dataVisit",
                    Convert.ToDateTime(dataVisitDateTimePicker.Text));
                insertCheckCommand.Parameters.AddWithValue("dataStart", Convert.ToDateTime(dataStartTimePicker.Text));
                insertCheckCommand.Parameters.AddWithValue("dataEnd", Convert.ToDateTime(dataEndTimePicker.Text));
                insertCheckCommand.Parameters.AddWithValue("value", Convert.ToInt32(valueTextBox.Text));
                if (radioButtonYes.Checked == true)
                    insertCheckCommand.Parameters.AddWithValue("status", "Оплачено");
                else
                    insertCheckCommand.Parameters.AddWithValue("status", "Не оплачено");
                insertCheckCommand.Parameters.AddWithValue("note", admin);
                try
                {
                    await insertCheckCommand.ExecuteNonQueryAsync();
                    MessageBox.Show("Новий рахунок був додан!");
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void idTextBox_TextChanged(object sender, EventArgs e)
        {
            SqlCommand getClientInfoCommand = new SqlCommand("SELECT [name] FROM [Clients] WHERE [Id]=@Id", sqlConnection);
            SqlDataReader sqlReader = null;
            bool test = false;
            if (idTextBox.Text == "")
                numberValue = 0;
            else
                numberValue = Convert.ToInt32(idTextBox.Text);
            getClientInfoCommand.Parameters.AddWithValue("Id", numberValue);
            try
            {
                sqlReader = await getClientInfoCommand.ExecuteReaderAsync();
                while
                    (await sqlReader.ReadAsync())
                {
                    nameValue = Convert.ToString(sqlReader["name"]);
                    nameLabel.Text = "ПІБ:" + Convert.ToString(nameValue);
                    test = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlReader != null && !sqlReader.IsClosed)
                    sqlReader.Close();
            }

            if (test == false)
            {
                nameLabel.Text = "ПІБ:";
                nameValue = null;
            }
                
        }
    }
}
