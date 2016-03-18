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
    public partial class Data_Choice : Form
    {
        public String dataSrcName;
        public Post_Wire thePostWire;
        public Data_Choice()
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

            /* else if (radioButton_Wifi.Checked)
             {
                 dataSrc = DataSource.WIFI;
                 dataSrcName = textBox_File.Text;
             }*/
            //将选定参数输入到类中
            if (thePostWire == null) return;
            float.TryParse(Post_dataGridView.Rows[0].Cells[1].Value.ToString(), out thePostWire.thePost.H);
            float.TryParse(Post_dataGridView.Rows[0].Cells[4].Value.ToString(), out thePostWire.thePost.theta);
            thePostWire.thePost.type = Post_dataGridView.Rows[0].Cells[2].Value.ToString();
            float.TryParse(Wire_dataGridView.Rows[0].Cells[2].Value.ToString(), out thePostWire.theWire.D);
            float.TryParse(Wire_dataGridView.Rows[0].Cells[3].Value.ToString(), out thePostWire.theWire.rho);
        }

        /*private void button_Open_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (DialogResult.OK == ofd.ShowDialog())
            {
                textBox_File.Text = ofd.FileName;
            }

        }*/




        private void FormConfig_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“firstDataSet1.Table_Post”中。您可以根据需要
            String connStr = Properties.Settings.Default.firstConnectionString;
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;

            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;

            conn.Open();

            cmd.CommandText = "SELECT distinct Type FROM Table_Post";
            reader = cmd.ExecuteReader();
            // Data is accessible through the DataReader object here.
            while (reader.Read()) {

                 postBox.Items.Add(reader.GetString(0));

            }
            reader.Close();

            cmd.CommandText = "SELECT  Type FROM Table_Wire";
            reader = cmd.ExecuteReader();
            // Data is accessible through the DataReader object here.
            while (reader.Read())
            {
                wireBox.Items.Add(reader.GetString(0));
            }
            reader.Close();       
            conn.Close();
        }   

        private void postBox_TextChanged(object sender, EventArgs e)
        {
            String connStr = Properties.Settings.Default.firstConnectionString;
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();

            SqlCommand cmd = new SqlCommand("Select Voltage From Table_Post where Type = @Type",conn);
            cmd.Parameters.Add("@Type", SqlDbType.NVarChar, 10).Value = postBox.Text;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            Voltage_listbox.DataSource = ds.Tables[0].DefaultView; 

            /* SqlCommand cmd = new SqlCommand("select * from Table_Post where Type = @Type", conn);
             cmd.Parameters.Add("@Type", SqlDbType.NVarChar, 10).Value = postBox.Text;
             SqlDataAdapter da = new SqlDataAdapter(cmd);
             DataSet ds = new DataSet();
             da.Fill(ds);
             dataGridView1.DataSource = ds.Tables[0].DefaultView; */
            conn.Close();

           // DataTable tbl = ds.Tables[0];
            //foreach (DataColumn col in tbl.Columns)

              // Console.WriteLine(col.ColumnName);
              


            //MessageBox.Show("查询完毕");
        }

        private void wireBox_TextChanged(object sender, EventArgs e)
        {
            String connStr = Properties.Settings.Default.firstConnectionString;
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;
            
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;

            conn.Open();           
            
            String s =string.Format( "SELECT * FROM Table_Wire Where Type='{0}'",wireBox.Text);
            //MessageBox.Show(s);
            SqlDataAdapter da = new SqlDataAdapter(s, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            Wire_dataGridView.DataSource = ds.Tables[0].DefaultView;
            conn.Close();
            //MessageBox.Show("查询成功");
        }        


        private void Voltage_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            String connStr = Properties.Settings.Default.firstConnectionString;
            SqlConnection conn = new SqlConnection(connStr);

            conn.Open();

            /*int numb = Voltage_listbox.SelectedIndex;
            DataTable dt = new DataTable();
            dt = (DataTable)Voltage_listbox.DataSource;
            DataRow row = dt.Rows[numb];*/
            SqlCommand cmd = new SqlCommand("SELECT  *  FROM Table_Post WHERE Type=@Type and Voltage=@Voltage", conn);
            cmd.Parameters.Add("@Type", SqlDbType.NVarChar, 50).Value = postBox.Text.ToString();
            cmd.Parameters.Add("@Voltage", SqlDbType.NVarChar, 50).Value = Voltage_listbox.SelectedValue;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            Post_dataGridView.DataSource = ds.Tables[0].DefaultView; 
                                                                                                             
            conn.Close();
        }
    }
}
