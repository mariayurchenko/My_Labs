using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace Base
{
    public partial class BD : Form
    {
        SqlConnection connection = new SqlConnection();
        string Admin;

        public BD(SqlConnection sqlConnection, string Admin)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.Admin = Admin;
            adminName.Text = "Адміністратор: " + Admin;
            updateClient.Visible = false;
            deleteClient.Visible = false;
            updateCheck.Visible = false;
            deleteCheck.Visible = false;
            this.connection = sqlConnection;
            
        }

        private void close_Click(object sender, EventArgs e)
        {
            if (connection != null && connection.State != ConnectionState.Closed)
                connection.Close();
            Application.Exit();
        }

        private async void BD_Load(object sender, EventArgs e)
        {
            await connection.OpenAsync();

            clientsTable.GridLines = true;
            clientsTable.FullRowSelect = true;
            clientsTable.View = View.Details;
            clientsTable.Columns.Add("Номер клієнта");
            clientsTable.Columns.Add("ПІБ");
            clientsTable.Columns.Add("Дата візиту");
            clientsTable.Columns.Add("Початок");
            clientsTable.Columns.Add("Кінець");
            clientsTable.Columns.Add("Телефон");
            clientsTable.Columns.Add("email");
            clientsTable.Columns.Add("День народження");
            clientsTable.Columns.Add("Примітка");
            clientsTable.Columns[0].Width = 90;
            clientsTable.Columns[1].Width = 300;
            clientsTable.Columns[2].Width = 120;
            clientsTable.Columns[3].Width = 120;
            clientsTable.Columns[4].Width = 120;
            clientsTable.Columns[5].Width = 130;
            clientsTable.Columns[6].Width = 180;
            clientsTable.Columns[7].Width = 120;
            clientsTable.Columns[8].Width = 250;

            checkTable.GridLines = true;
            checkTable.FullRowSelect = true;
            checkTable.View = View.Details;
            checkTable.Columns.Add("Номер рахунку");
            checkTable.Columns.Add("ПІБ");
            checkTable.Columns.Add("Дата візиту");
            checkTable.Columns.Add("Початок");
            checkTable.Columns.Add("Кінець");
            checkTable.Columns.Add("Ціна");
            checkTable.Columns.Add("Статус");
            checkTable.Columns.Add("Адміністратор");
            checkTable.Columns[0].Width = 90;
            checkTable.Columns[1].Width = 300;
            checkTable.Columns[2].Width = 120;
            checkTable.Columns[3].Width = 120;
            checkTable.Columns[4].Width = 120;
            checkTable.Columns[5].Width = 60;
            checkTable.Columns[6].Width = 120;
            checkTable.Columns[7].Width = 130;

            birthTable.GridLines = true;
            birthTable.FullRowSelect = true;
            birthTable.View = View.Details;
            birthTable.Columns.Add("Номер клієнта");
            birthTable.Columns.Add("ПІБ");
            birthTable.Columns.Add("Дата візиту");
            birthTable.Columns.Add("Початок");
            birthTable.Columns.Add("Кінець");
            birthTable.Columns.Add("Телефон");
            birthTable.Columns.Add("email");
            birthTable.Columns.Add("День народження");
            birthTable.Columns.Add("Примітка");
            birthTable.Columns[0].Width = 90;
            birthTable.Columns[1].Width = 300;
            birthTable.Columns[2].Width = 120;
            birthTable.Columns[3].Width = 120;
            birthTable.Columns[4].Width = 120;
            birthTable.Columns[5].Width = 130;
            birthTable.Columns[6].Width = 180;
            birthTable.Columns[7].Width = 120;
            birthTable.Columns[8].Width = 250;

            visitTable.GridLines = true;
            visitTable.FullRowSelect = true;
            visitTable.View = View.Details;
            visitTable.Columns.Add("Номер клієнта");
            visitTable.Columns.Add("ПІБ");
            visitTable.Columns.Add("Дата візиту");
            visitTable.Columns.Add("Початок");
            visitTable.Columns.Add("Кінець");
            visitTable.Columns.Add("Телефон");
            visitTable.Columns.Add("email");
            visitTable.Columns.Add("День народження");
            visitTable.Columns.Add("Примітка");
            visitTable.Columns[0].Width = 90;
            visitTable.Columns[1].Width = 300;
            visitTable.Columns[2].Width = 120;
            visitTable.Columns[3].Width = 120;
            visitTable.Columns[4].Width = 120;
            visitTable.Columns[5].Width = 130;
            visitTable.Columns[6].Width = 180;
            visitTable.Columns[7].Width = 120;
            visitTable.Columns[8].Width = 250;

            await LoadClientsAsync();
            await LoadCheckAsync();
            await LoadBirthAsync(DateTime.Now.Day, DateTime.Now.Month);

        }

        private async Task LoadClientsAsync()
        {
            SqlDataReader sqlReader = null;
            SqlCommand getClientSqlCommand = new SqlCommand("SELECT * FROM[Clients]", connection);
            try
            {
                sqlReader = await getClientSqlCommand.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                        Convert.ToString(sqlReader["Id"]),
                        Convert.ToString(sqlReader["name"]),
                        Convert.ToString(sqlReader["dataVisit"]),
                        Convert.ToString(sqlReader["dataStart"]),
                        Convert.ToString(sqlReader["dataEnd"]),
                        Convert.ToString(sqlReader["phoneNumber"]),
                        Convert.ToString(sqlReader["email"]),
                        Convert.ToString(sqlReader["dateOfBirth"]),
                        Convert.ToString(sqlReader["note"]),
                    });
                    clientsTable.Items.Add(item);
                    item.UseItemStyleForSubItems = false;
                    item.SubItems[3].BackColor = Color.LawnGreen;
                    item.SubItems[4].BackColor = Color.OrangeRed;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlReader != null && !sqlReader.IsClosed)
                {
                    sqlReader.Close();
                }
            }
        }

        private async Task LoadCheckAsync()
        {

            SqlDataReader sqlReader = null;
            SqlCommand getClientSqlCommand = new SqlCommand("SELECT * FROM[Check]", connection);
            try
            {
                sqlReader = await getClientSqlCommand.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                        Convert.ToString(sqlReader["Id"]),
                        Convert.ToString(sqlReader["name"]),
                        Convert.ToString(sqlReader["dataVisit"]),
                        Convert.ToString(sqlReader["dataStart"]),
                        Convert.ToString(sqlReader["dataEnd"]),
                        Convert.ToString(sqlReader["value"]),
                        Convert.ToString(sqlReader["status"]),
                        Convert.ToString(sqlReader["note"]),
                    });
                    checkTable.Items.Add(item);
                    if (Convert.ToString(sqlReader["status"]) == "Оплачено")
                        item.BackColor = Color.LawnGreen;
                    else
                    {
                        item.BackColor = Color.OrangeRed;
                        item.ForeColor = Color.White;
                    }



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlReader != null && !sqlReader.IsClosed)
                {
                    sqlReader.Close();
                }
            }
        }


        private void close_MouseEnter(object sender, EventArgs e)
        {
            close.ForeColor = Color.Red;
        }

        private void close_MouseLeave(object sender, EventArgs e)
        {
            close.ForeColor = Color.White;
        }

        private async void deleteCheck_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ві дійсно хочете видалити цей рахунок?", "Видалення",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);

            switch (result)
            {
                case DialogResult.OK:

                    SqlCommand deleteCheckCommand = new SqlCommand("DELETE FROM [Check] WHERE [Id]=@Id", connection);
                    deleteCheckCommand.Parameters.AddWithValue("id",
                        Convert.ToInt32(checkTable.SelectedItems[0].SubItems[0].Text));
                    try
                    {
                        await deleteCheckCommand.ExecuteNonQueryAsync();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    checkTable.Items.Clear();
                    await LoadClientsAsync();
                    break;
            }
        }

        private async void refreshCheck_Click(object sender, EventArgs e)
        {
            checkTable.Items.Clear();
            await LoadCheckAsync();
        }

        private async void deleteClient_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ві дійсно хочете видалити цього клієнта?", "Видалення",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);

            switch (result)
            {
                case DialogResult.OK:

                    SqlCommand deleteClientCommand = new SqlCommand("DELETE FROM [Clients] WHERE [Id]=@Id", connection);
                    deleteClientCommand.Parameters.AddWithValue("id",
                        Convert.ToInt32(clientsTable.SelectedItems[0].SubItems[0].Text));
                    try
                    {
                        await deleteClientCommand.ExecuteNonQueryAsync();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    clientsTable.Items.Clear();
                    await LoadClientsAsync();
                    break;
            }
        }

        private void clientsTable_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (!e.IsSelected)
            {
                updateClient.Visible = false;
                deleteClient.Visible = false;
            }
            else
            {
                updateClient.Visible = true;
                deleteClient.Visible = true;
            }
        }

        private void addCheck_Click(object sender, EventArgs e)
        {
            NewCheck nc = new NewCheck(connection, Admin);
            nc.Show();
        }

        private void addClient_Click(object sender, EventArgs e)
        {
            NewClient nc = new NewClient(connection);
            nc.Show();
        }

        private async void refreshClients_Click(object sender, EventArgs e)
        {
            clientsTable.Items.Clear();
            await LoadClientsAsync();
        }

        private void checkTable_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (!e.IsSelected)
            {
                updateCheck.Visible = false;
                deleteCheck.Visible = false;
            }
            else
            {
                updateCheck.Visible = true;
                deleteCheck.Visible = true;
            }
        }

        private void updateCheck_Click(object sender, EventArgs e)
        {
            UpdateCheck updateCheck =
                new UpdateCheck(connection, Convert.ToInt32(checkTable.SelectedItems[0].SubItems[0].Text));
            updateCheck.Show();
        }


        private async void scanClient_Click(object sender, EventArgs e)
        {
            int numbId;
            string text;
            if (textBoxClients.Text != "")
            {
                text = Convert.ToString(textBoxClients.Text);
                bool isNum = int.TryParse(text, out numbId);
                if (isNum) //Пошук по id
                {
                    numbId = Convert.ToInt32(text);
                    clientsTable.Items.Clear();
                    await ScanClientsId(numbId);
                }
                else //Пошук по ПІБ
                {
                    clientsTable.Items.Clear();
                    await ScanClientsName(text);
                }


            }

        }
    

        private async Task ScanClientsId(int numbId)
        {
            SqlDataReader sqlReader = null;
            SqlCommand getClientSqlCommand = new SqlCommand("SELECT * FROM[Clients]", connection);
            try
            {
                sqlReader = await getClientSqlCommand.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                        Convert.ToString(sqlReader["Id"]),
                        Convert.ToString(sqlReader["name"]),
                        Convert.ToString(sqlReader["dataVisit"]),
                        Convert.ToString(sqlReader["dataStart"]),
                        Convert.ToString(sqlReader["dataEnd"]),
                        Convert.ToString(sqlReader["phoneNumber"]),
                        Convert.ToString(sqlReader["email"]),
                        Convert.ToString(sqlReader["dateOfBirth"]),
                        Convert.ToString(sqlReader["note"]),
                    });
                    if (Convert.ToInt32(sqlReader["Id"]) == numbId)
                    {
                        clientsTable.Items.Add(item);
                        item.UseItemStyleForSubItems = false;
                        item.SubItems[3].BackColor = Color.LawnGreen;
                        item.SubItems[4].BackColor = Color.OrangeRed;
                        break;
                    }
                    
                        
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlReader != null && !sqlReader.IsClosed)
                {
                    sqlReader.Close();
                }
            }
        }
        private async Task ScanClientsName(string name)
        {
            string text;
            SqlDataReader sqlReader = null;
            SqlCommand getClientSqlCommand = new SqlCommand("SELECT * FROM[Clients]", connection);
            try
            {
                sqlReader = await getClientSqlCommand.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                        Convert.ToString(sqlReader["Id"]),
                        Convert.ToString(sqlReader["name"]),
                        Convert.ToString(sqlReader["dataVisit"]),
                        Convert.ToString(sqlReader["dataStart"]),
                        Convert.ToString(sqlReader["dataEnd"]),
                        Convert.ToString(sqlReader["phoneNumber"]),
                        Convert.ToString(sqlReader["email"]),
                        Convert.ToString(sqlReader["dateOfBirth"]),
                        Convert.ToString(sqlReader["note"]),
                    });
                    text = Convert.ToString(sqlReader["name"]);
                    if (Regex.IsMatch(text, name, RegexOptions.IgnoreCase))
                    {
                        clientsTable.Items.Add(item);
                        item.UseItemStyleForSubItems = false;
                        item.SubItems[3].BackColor = Color.LawnGreen;
                        item.SubItems[4].BackColor = Color.OrangeRed;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlReader != null && !sqlReader.IsClosed)
                {
                    sqlReader.Close();
                }
            }
        }

        private async void scanCheck_Click(object sender, EventArgs e)
        {
            int numbId;
            string text;
            text = Convert.ToString(textBoxCheck.Text);
            if (text != "")
            {
                bool isNum = int.TryParse(text, out numbId);
                if (isNum) //Пошук по id
                {
                    numbId = Convert.ToInt32(text);
                    checkTable.Items.Clear();
                    await ScanCheckId(numbId);
                }
                else //Пошук по ПІБ
                {
                    checkTable.Items.Clear();
                    await ScanCheckName(text);
                }


            }
        }
        private async Task ScanCheckId(int numbId)
        {
            SqlDataReader sqlReader = null;
            SqlCommand getClientSqlCommand = new SqlCommand("SELECT * FROM[Check]", connection);
            try
            {
                sqlReader = await getClientSqlCommand.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                        Convert.ToString(sqlReader["Id"]),
                        Convert.ToString(sqlReader["name"]),
                        Convert.ToString(sqlReader["dataVisit"]),
                        Convert.ToString(sqlReader["dataStart"]),
                        Convert.ToString(sqlReader["dataEnd"]),
                        Convert.ToString(sqlReader["value"]),
                        Convert.ToString(sqlReader["status"]),
                        Convert.ToString(sqlReader["note"]),
                    });
                    if (Convert.ToInt32(sqlReader["Id"]) == numbId)
                    {
                        checkTable.Items.Add(item);
                        item.UseItemStyleForSubItems = false;
                        item.SubItems[3].BackColor = Color.LawnGreen;
                        item.SubItems[4].BackColor = Color.OrangeRed;
                        break;
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlReader != null && !sqlReader.IsClosed)
                {
                    sqlReader.Close();
                }
            }
        }
        private async Task ScanCheckName(string name)
        {
            string text;
            SqlDataReader sqlReader = null;
            SqlCommand getClientSqlCommand = new SqlCommand("SELECT * FROM[Check]", connection);
            try
            {
                sqlReader = await getClientSqlCommand.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                        Convert.ToString(sqlReader["Id"]),
                        Convert.ToString(sqlReader["name"]),
                        Convert.ToString(sqlReader["dataVisit"]),
                        Convert.ToString(sqlReader["dataStart"]),
                        Convert.ToString(sqlReader["dataEnd"]),
                        Convert.ToString(sqlReader["value"]),
                        Convert.ToString(sqlReader["status"]),
                        Convert.ToString(sqlReader["note"]),
                    });
                    text = Convert.ToString(sqlReader["name"]);
                    if (Regex.IsMatch(text, name, RegexOptions.IgnoreCase))
                    {
                        checkTable.Items.Add(item);
                        item.UseItemStyleForSubItems = false;
                        item.SubItems[3].BackColor = Color.LawnGreen;
                        item.SubItems[4].BackColor = Color.OrangeRed;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlReader != null && !sqlReader.IsClosed)
                {
                    sqlReader.Close();
                }
            }
        }
        private async Task LoadBirthAsync(int day, int month)
        {
            DateTime date;
            SqlDataReader sqlReader = null;
            SqlCommand getClientSqlCommand = new SqlCommand("SELECT * FROM[Clients]", connection);
            try
            {
                sqlReader = await getClientSqlCommand.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                        Convert.ToString(sqlReader["Id"]),
                        Convert.ToString(sqlReader["name"]),
                        Convert.ToString(sqlReader["dataVisit"]),
                        Convert.ToString(sqlReader["dataStart"]),
                        Convert.ToString(sqlReader["dataEnd"]),
                        Convert.ToString(sqlReader["phoneNumber"]),
                        Convert.ToString(sqlReader["email"]),
                        Convert.ToString(sqlReader["dateOfBirth"]),
                        Convert.ToString(sqlReader["note"]),
                    });
                    date = Convert.ToDateTime(sqlReader["dateOfBirth"]);
                    if (day == date.Day && month == date.Month)
                    {
                        birthTable.Items.Add(item);
                        item.UseItemStyleForSubItems = false;
                        item.SubItems[3].BackColor = Color.LawnGreen;
                        item.SubItems[4].BackColor = Color.OrangeRed;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlReader != null && !sqlReader.IsClosed)
                {
                    sqlReader.Close();
                }
            }
        }
        private async Task LoadVisitAsync(DateTime date1, DateTime date2)
        {
            DateTime date=new DateTime();     
            SqlDataReader sqlReader = null;
            SqlCommand getClientSqlCommand = new SqlCommand("SELECT * FROM[Clients]", connection);
            try
            {
                sqlReader = await getClientSqlCommand.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                        Convert.ToString(sqlReader["Id"]),
                        Convert.ToString(sqlReader["name"]),
                        Convert.ToString(sqlReader["dataVisit"]),
                        Convert.ToString(sqlReader["dataStart"]),
                        Convert.ToString(sqlReader["dataEnd"]),
                        Convert.ToString(sqlReader["phoneNumber"]),
                        Convert.ToString(sqlReader["email"]),
                        Convert.ToString(sqlReader["dateOfBirth"]),
                        Convert.ToString(sqlReader["note"]),
                    });
                    date = Convert.ToDateTime(sqlReader["dataEnd"]);

                    if (date1<=date && date<=date2)
                    {
                        visitTable.Items.Add(item);
                        item.UseItemStyleForSubItems = false;
                        item.SubItems[3].BackColor = Color.LawnGreen;
                        item.SubItems[4].BackColor = Color.OrangeRed;
                    }

                }
            }
            catch (Exception ex)
            {
                
            }
            finally
            {
                if (sqlReader != null && !sqlReader.IsClosed)
                {
                    sqlReader.Close();
                }
            }
        }

        private async void scanBirth_Click(object sender, EventArgs e)
        {
            DateTime date = new DateTime();
            date = Convert.ToDateTime(dataBirthDateTimePicker.Text);
            birthTable.Items.Clear();
            await LoadBirthAsync(date.Day,date.Month);
        }

        private async void scanVisit_Click(object sender, EventArgs e)
        {
            DateTime date1 = new DateTime();
            DateTime date2 = new DateTime();
            date1 = Convert.ToDateTime(dateVisitTimePicker1.Text);
            date2 = Convert.ToDateTime(dateVisitTimePicker2.Text);
            visitTable.Items.Clear();
            await LoadVisitAsync(date1,date2);
        }

        private void updateClient_Click(object sender, EventArgs e)
        {
            Update updateClient =
                new Update(connection, Convert.ToInt32(clientsTable.SelectedItems[0].SubItems[0].Text));
            updateClient.Show();
        }
    }
}
