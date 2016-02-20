using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace ViberationScope
{
    public partial class FormConfig : Form
    {
        public DataSource dataSrc = DataSource.COM;
        public String dataSrcName;
        public FormConfig()
        {
            InitializeComponent();
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            /*if (radioButton_COM.Checked)
            {
                dataSrc = DataSource.COM;
                dataSrcName = textBox_COM.Text;
            }
            else */
            if (radioButton_File.Checked)
            {
                dataSrc = DataSource.File;
                dataSrcName = textBox_File.Text;
            }
           /* else if (radioButton_Wifi.Checked)
            {
                dataSrc = DataSource.WIFI;
                dataSrcName = textBox_File.Text;
            }*/
        }

        private void button_Open_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (DialogResult.OK == ofd.ShowDialog())
            {
                textBox_File.Text = ofd.FileName;
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormConfig_Load(object sender, EventArgs e)
        {
            String connStr = Properties.Settings.Default.firstConnectionString;
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;

            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;

            conn.Open();

            cmd.CommandText = "SELECT Name FROM Table_Post";
            reader = cmd.ExecuteReader();
            // Data is accessible through the DataReader object here.
            while (reader.Read()) {
                comboBox1.Items.Add(reader.GetString(0));
            }
            reader.Close();

            cmd.CommandText = "SELECT Type FROM Table_Wire";
            reader = cmd.ExecuteReader();
            // Data is accessible through the DataReader object here.
            while (reader.Read())
            {
                comboBox2.Items.Add(reader.GetString(0));
            }

            conn.Close();
        }
    }

    public enum DataSource
    {
        COM,
        File,
        WIFI
    }
}
