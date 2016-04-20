﻿using System;
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
        public FormConfig()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        /* private void FormConfig1_Load(object sender, EventArgs e)
         {
             String connStr = Properties.Settings.Default.firstConnectionString;
             SqlConnection conn = new SqlConnection(connStr);           

             SqlCommand selectcmd = new SqlCommand("SELECT * FROM Table_Post Where Id=0",conn);
             //上面的语句中使用select 0，不是为了查询出数据，而是要查询出表结构以向DataTable中填充表结构
             selectcmd.CommandType = CommandType.Text;
             selectcmd.Connection = conn;

             conn.Open();

             SqlDataAdapter da = new SqlDataAdapter(selectcmd);
             DataSet ds = new DataSet(); 
             da.Fill(ds);
             dataGridView1.DataSource = ds.Tables[0].DefaultView;    

             conn.Close();
             MessageBox.Show("查");


         }
         */
       /* private void button1_Click(object sender, EventArgs e)
        {

            String connStr = Properties.Settings.Default.firstConnectionString;
            SqlConnection conn = new SqlConnection(connStr);

            DataTable dt = new DataTable();
            DataColumn dc;

            DataSet ds = new DataSet();

        }*/
      /*
        private void Select_postbutton_Click(object sender, EventArgs e)
        {
            String connStr = Properties.Settings.Default.firstConnectionString;
            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand selectcmd = new SqlCommand("SELECT * FROM Table_Post", conn);
            selectcmd.CommandType = CommandType.Text;
            selectcmd.Connection = conn;

            conn.Open();

            SqlDataAdapter da = new SqlDataAdapter(selectcmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridViewPost.DataSource = ds.Tables[0].DefaultView;

            conn.Close();

        }*/

        private void Update_button_Click(object sender, EventArgs e)
        {
            String connStr = Properties.Settings.Default.firstConnectionString;
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            DataTable dt = new DataTable();
            DataColumn dc;
        
            for (int i = 0; i < dataGridViewPost.ColumnCount; i++)
            {
                dc = new DataColumn();
                dc.ColumnName = dataGridViewPost.Columns[i].DataPropertyName.ToString();
                dt.Columns.Add(dc);
            }
            for (int j = 0; j < dataGridViewPost.RowCount-1; j++)
            {
                DataRow dr = dt.NewRow();
                for (int x = 0; x < dataGridViewPost.ColumnCount; x++)
                {
                    dr[x] = dataGridViewPost.Rows[j].Cells[x].Value;
                }
                dt.Rows.Add(dr);               
            }
           dt.AcceptChanges();
            // SqlCommand cmd = new SqlCommand("SELECT * FROM Table_Post", conn);   


            SqlBulkCopy bulkCopy = new SqlBulkCopy(conn);

            bulkCopy.DestinationTableName = "Table_Post";//要插入的表的表明  
           // bulkCopy.ColumnMappings.Add("Id","Id");//映射字段名 DataTable列名 ,数据库 对应的列名  
            bulkCopy.ColumnMappings.Add("Height","Height");
            bulkCopy.ColumnMappings.Add("Type","Type");
            bulkCopy.ColumnMappings.Add("Voltage","Voltage");
            bulkCopy.ColumnMappings.Add("Degree","Degree");
            bulkCopy.NotifyAfter = 10;
            bulkCopy.WriteToServer(dt);
            bulkCopy.Close();
            conn.Close();

            MessageBox.Show("添加成功");
        }
        



        /*conn.Open();

          using (SqlBulkCopy bulkCopy = new SqlBulkCopy(conn))
                {               

                     try
                {

                   bulkCopy.DestinationTableName = "Table_Post";//要插入的表的表明  
                   bulkCopy.ColumnMappings.Add("Id", "Id");//映射字段名 DataTable列名 ,数据库 对应的列名  
                   bulkCopy.ColumnMappings.Add("Height", "Height");
                   bulkCopy.ColumnMappings.Add("Type", "Type");
                   bulkCopy.ColumnMappings.Add("Name", "Name");
                   bulkCopy.ColumnMappings.Add("Degree", "Degree");

                   bulkCopy.WriteToServer(dt);
                 }
                            catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);

                     }
                       finally
                {
                                   // Close the SqlDataReader. The SqlBulkCopy  
            // object is automatically closed at the end  
           // of the using block.  

                 }
         }

        conn.Close(); 

        */





        /*  SqlCommand updatecmd = new SqlCommand("INSERT INTO Table_Post VALUES (@Id,@Height,@Type,@Name,@Degree)", conn);
                updatecmd.Parameters.Add("@Name", SqlDbType.NVarChar, 10).Value = dataGridView1.Rows[j].Cells[x].Value;
                SqlDataAdapter sda = new SqlDataAdapter(updatecmd);
                SqlCommandBuilder scb = new SqlCommandBuilder(sda);
                sda.Fill(dt);
                this.dataGridView1.DataSource = dt;*/
        //上面的语句中使用select 0，不是为了查询出数据，而是要查询出表结构以向DataTable中填充表结构
        //selectcmd.CommandType = CommandType.Text;
        //updatcmd.Connection = conn;

        //conn.Open();







        //  for (int i = 0; i < dt.Rows.Count; i++)
        //{
        //    dt.Rows[i][0] = dt.Rows.Count/2;
        //}
        //sda.Update(dt);
        //conn.Close();



        private void button4_Click(object sender, EventArgs e)
        {
            String connStr = Properties.Settings.Default.firstConnectionString;
            SqlConnection conn = new SqlConnection(connStr);

            DataTable dt = new DataTable();
            DataColumn dc;

            for (int i = 0; i < dataGridViewWire.ColumnCount; i++)
            {
                dc = new DataColumn();
                dc.ColumnName = dataGridViewWire.Columns[i].DataPropertyName.ToString();
                dt.Columns.Add(dc);
            }
            for (int j = 0; j < dataGridViewWire.RowCount - 1; j++)
            {
                DataRow dr = dt.NewRow();
                for (int x = 0; x < dataGridViewWire.ColumnCount; x++)
                {
                    dr[x] = dataGridViewWire.Rows[j].Cells[x].Value;
                }
                dt.Rows.Add(dr);
                dt.AcceptChanges();
            }
          

            conn.Open();



            SqlCommand cmd = new SqlCommand("SELECT * FROM Table_Wire", conn);


            SqlBulkCopy bulkCopy = new SqlBulkCopy(conn);

            bulkCopy.DestinationTableName = "Table_Wire";//要插入的表的表明  
            //bulkCopy.ColumnMappings.Add("Id", "Id");//映射字段名 DataTable列名 ,数据库 对应的列名  
            bulkCopy.ColumnMappings.Add("Type", "Type");
            bulkCopy.ColumnMappings.Add("Diameter", "Diameter");            
            bulkCopy.ColumnMappings.Add("Density", "Density");
            bulkCopy.ColumnMappings.Add("Modulus", "Modulus");
            bulkCopy.NotifyAfter = 10;
            bulkCopy.WriteToServer(dt);                      
            MessageBox.Show("添加成功");
            bulkCopy.Close();          
            conn.Close();


        }
        
        private void button2_Click_1(object sender, EventArgs e)
        {
            if (dataGridViewWire.DataSource == null)
            {
                dataGridViewWire.Rows.Clear();
            }
            else
            {
                DataTable dt = new DataTable();
                DataColumn dc;
                for (int i = 0; i < dataGridViewWire.ColumnCount; i++)
                {
                    dc = new DataColumn();
                    dc.ColumnName = dataGridViewWire.Columns[i].DataPropertyName.ToString();
                    dt.Columns.Add(dc);
                }
                dataGridViewWire.DataSource = dt;
            }
        }

        private void FormConfig1_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“ds.Table_Post”中。您可以根据需要移动或删除它。
            //this.table_PostTableAdapter1.Fill(this.ds.Table_Post);
            // TODO: 这行代码将数据加载到表“firstDataSet11.Table_Post”中。您可以根据需要移动或删除它。





            String connStr = Properties.Settings.Default.firstConnectionString;
            SqlConnection conn = new SqlConnection(connStr);

            //SqlCommand cmd = new SqlCommand("SELECT Id,Name FROM Table_Post", conn);
            SqlCommand cm = new SqlCommand("SELECT Id, Type FROM Table_Wire", conn);
            SqlCommand cmm = new SqlCommand();      

            cm.Connection = conn;
            cmm.Connection = conn;
           // cmd.Connection = conn;

            conn.Open();

            //选择Posttype_comboBox
            cmm.CommandType = CommandType.Text;
            cmm.CommandText = "SELECT distinct Type FROM Table_Post";
            SqlDataReader reader = cmm.ExecuteReader();
            // Data is accessible through the DataReader object here.
            while (reader.Read())
            {

                Posttype_comboBox.Items.Add(reader.GetString(0));

            }

            reader.Close();
          //选择listbox
            SqlDataAdapter dap = new SqlDataAdapter(cm);
            DataSet das = new DataSet();
            dap.Fill(das);
            WireName_listBox.DataSource = das.Tables[0].DefaultView;
           
            conn.Close();      

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (dataGridViewPost.DataSource == null)
            {
                dataGridViewPost.Rows.Clear();
            }
            else
            { 
                DataTable dt = new DataTable();
                DataColumn dc; 
                for (int i = 0; i < dataGridViewPost.ColumnCount; i++)
                {
                    dc = new DataColumn();
                    dc.ColumnName = dataGridViewPost.Columns[i].DataPropertyName.ToString();
                    dt.Columns.Add(dc);
                }
                dataGridViewPost.DataSource = dt;
            }

        }
 /*
        private void button3_Click(object sender, EventArgs e)
        {
            String connStr = Properties.Settings.Default.firstConnectionString;
            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand selectcmd = new SqlCommand("SELECT * FROM Table_Wire", conn);
            //上面的语句中使用select 0，不是为了查询出数据，而是要查询出表结构以向DataTable中填充表结构
            selectcmd.CommandType = CommandType.Text;
            selectcmd.Connection = conn;

            conn.Open();

            SqlDataAdapter da = new SqlDataAdapter(selectcmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridViewWire.DataSource = ds.Tables[0].DefaultView;

            conn.Close();
        }
        */
        private void Posttype_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            String connStr = Properties.Settings.Default.firstConnectionString;
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT Voltage FROM Table_Post WHERE Type=@Type",conn);
            cmd.Parameters.Add("@Type", SqlDbType.NVarChar, 50).Value = Posttype_comboBox.Text;    
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            PostName_listBox.DataSource = ds.Tables[0].DefaultView;

            conn.Close();
        }       

        private void PostName_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] a = new string[] { "Height", "Type", "Voltage", "Degree" };
            for (int i=0;i<a.LongLength; i++)
            {
                String connStr = Properties.Settings.Default.firstConnectionString;
                SqlConnection conn = new SqlConnection(connStr);              
                string s=a[i]; 
                SqlCommand cmd = new SqlCommand("SELECT "+s+ " FROM Table_Post WHERE Type=@Type and Voltage=@Voltage", conn);
                //cmd.Parameters.Add("@Type", SqlDbType.NVarChar, 50).Value = PostName_listBox.SelectedItem.ToString();
                cmd.Parameters.Add("@Type", SqlDbType.NVarChar, 50).Value = Posttype_comboBox.SelectedItem;
                cmd.Parameters.Add("@Voltage", SqlDbType.NVarChar, 50).Value = PostName_listBox.SelectedValue;
                cmd.Connection = conn;
                conn.Open();

                SqlDataReader dr = cmd.ExecuteReader();
             
                
                if (i==0)
                {
                    
                    while (dr.Read())
                    {
                        Height_textBox.Text =Convert.ToString(dr["Height"]);

                    }
                }
                else if (i == 1)
                {
                    while (dr.Read())
                    {
                         Posttype_textBox.Text =Convert.ToString(dr["Type"]);

                    }
                }
                else if (i == 2)
                {
                    while (dr.Read())
                    {
                        Voltage_textBox.Text = Convert.ToString(dr["Voltage"]);
                    }
                }
                else if (i == 3)
                {
                    while (dr.Read())
                    {
                        Degree_textBox.Text = Convert.ToString(dr["Degree"]);

                    }
                }




                // Degree_textBox.Text =
                //Posttype_comboBox.Text = Posttype_comboBox.Text;
                //Name_textBox.Text = PostName_listBox.Text;

                dr.Close();
                conn.Close();

          
             }
            }

        private void WireName_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            String[] s =new String[]{"Type","Diameter","Density","Modulus"};
            for (int i = 0; i < s.LongLength; i++)
            {
                String connStr = Properties.Settings.Default.firstConnectionString;
                SqlConnection conn = new SqlConnection(connStr);
                String a = s[i];

                SqlCommand cmd = new SqlCommand("SELECT " + a+ " FROM Table_Wire WHERE Type=@Type", conn);
                cmd.Parameters.Add("@Type", SqlDbType.NVarChar, 50).Value=WireName_listBox.SelectedValue;
                cmd.Connection = conn;
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if(i==0)
                { 
                             while (reader.Read())
                         {
                             Wiretype_textBox.Text = Convert.ToString(reader["Type"]);
                        // Diameter_textBox.Text = Convert.ToString(reader["Diameter"]);
                        //Modulus_Box.Text = Convert.ToString(reader["Modulus"]);
                        //Density_textBox.Text = Convert.ToString(reader["Density"]);
                        }

                }

                if (i == 1)
                {
                    while (reader.Read())
                    {
                        
                         Diameter_textBox.Text = Convert.ToString(reader["Diameter"]);
                     
                    }

                }
                if (i == 3)
                {
                    while (reader.Read())
                    {
                      
                        Modulus_Box.Text = Convert.ToString(reader["Modulus"]);
                        
                    }

                }
                if (i == 2)
                {
                    while (reader.Read())
                    {
                       
                       Density_textBox.Text = Convert.ToString(reader["Density"]);
                    }

                }
            }


        }

        private void Delectpost_button_Click(object sender, EventArgs e)
        {
            String conStr = Properties.Settings.Default.firstConnectionString;
            SqlConnection conn = new SqlConnection(conStr);

            SqlCommand cmd = new SqlCommand("Delete From Table_Post where Type=@Type and Voltage=@Voltage", conn);
            cmd.Parameters.Add("@Type", SqlDbType.NVarChar, 50).Value = Posttype_comboBox.SelectedItem;
            cmd.Parameters.Add("@Voltage", SqlDbType.NVarChar, 50).Value = PostName_listBox.SelectedValue;
            cmd.Connection = conn;
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();     
            MessageBox.Show("删除成功");
            this.Refresh();
        }

        private void Delectwire_button_Click(object sender, EventArgs e)
        {
            String conStr = Properties.Settings.Default.firstConnectionString;
            SqlConnection conn = new SqlConnection(conStr);

            SqlCommand cmd = new SqlCommand("Delete From Table_Wire where Type=@Type",conn);
            cmd.Parameters.Add("Type", SqlDbType.NVarChar, 50).Value = Wiretype_textBox.Text;

            cmd.Connection = conn;
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            this.Refresh();
            MessageBox.Show("删除成功");       
       
        }

        private void Postupdata_button_Click(object sender, EventArgs e)
        {

            String[] s = new string[] { "Height", "Type", "Voltage", "Degree" };
            String[] p = new string[] { Height_textBox.Text,Posttype_textBox.Text, Voltage_textBox.Text,Degree_textBox.Text};
            String conStr = Properties.Settings.Default.firstConnectionString;
            SqlConnection conn = new SqlConnection(conStr);
            conn.Open();
            for (int i = 0; i < s.LongLength; i++)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("Update Table_Post set " + s[i] + " = " + p[i] + " where Type=@Type and Voltage=@Voltage", conn);
                    cmd.Parameters.Add("@Type", SqlDbType.NVarChar, 50).Value = Posttype_comboBox.SelectedItem;
                    cmd.Parameters.Add("@Voltage", SqlDbType.NVarChar, 50).Value = PostName_listBox.SelectedValue;
                    cmd.Connection = conn;
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException odbcEx)
                { }
                catch (Exception ex)
                {

                }                


            }
            conn.Close();
            MessageBox.Show("修改成功");
        }

        private void Updatewire_button_Click(object sender, EventArgs e)
        {
            String[] s = new string[] { "Type", "Diameter", "Density", "Modulus" };
            String[] p = new string[] { Wiretype_textBox.Text, Diameter_textBox.Text, Density_textBox.Text, Modulus_Box.Text };
            String conStr = Properties.Settings.Default.firstConnectionString;
            SqlConnection conn = new SqlConnection(conStr);
            conn.Open();
            for (int i = 0; i < s.LongLength; i++)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("Update Table_wire set " + s[i] + " = " + p[i] + " where Type=@Type", conn);
                    cmd.Parameters.Add("@Type", SqlDbType.NVarChar, 50).Value = WireName_listBox.SelectedValue;                   
                    cmd.Connection = conn;
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException odbcEx)
                { }
                catch (Exception ex)
                {

                }



            }
            conn.Close();
            MessageBox.Show("修改成功");

        }


        /*   private void PostName_listBox_MouseEnter(object sender, EventArgs e)
           {
               String connStr = Properties.Settings.Default.firstConnectionString;
               SqlConnection conn = new SqlConnection(connStr);
               conn.Open();

               SqlCommand cmd = new SqlCommand("SELECT Height FROM Table_Post WHERE Type = @Type", conn);
               cmd.Parameters.Add("@Type", SqlDbType.NVarChar, 50).Value = PostName_listBox.Text;
               SqlDataAdapter da = new SqlDataAdapter();
               DataSet ds = new DataSet();
               da.Fill(ds);
               Height_textBox.Text = ds.ToString();
              // Degree_textBox.Text =
               Posttype_comboBox.Text = Posttype_comboBox.Text;
               Name_textBox.Text = PostName_listBox.Text;
               conn.Close();
           }*/

        /* private void PostName_listBox_SelectedIndexChanged(object sender, EventArgs e)
            {
               String connStr = Properties.Settings.Default.firstConnectionString;
               SqlConnection conn = new SqlConnection(connStr);
                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT Height FROM Table_Post WHERE Type = @Type",conn);
                cmd.Parameters.Add("@Type", SqlDbType.NVarChar, 50).Value = PostName_listBox.Text;
               SqlDataAdapter da = new SqlDataAdapter();
               DataSet ds = new DataSet();
                da.Fill(ds);
                Height_textBox.Text = ds.ToString();

                conn.Close();
            }*/









        /*  public static DataSet GetDataSetFromDataGridView(DataGridView ucgrd)
 {
     DataSet ds = new DataSet();
     DataTable dt = new DataTable();

     for (int j = 0; j < ucgrd.Columns.Count; j++)
     {
         dt.Columns.Add(ucgrd.Columns[j].HeaderCell.Value.ToString());
     }

     for (int j = 0; j < ucgrd.Rows.Count; j++)
     {
         DataRow dr = dt.NewRow();
         for (int i = 0; i < ucgrd.Columns.Count; i++)
         {
             if (ucgrd.Rows[j].Cells[i].Value != null)
             {
                 dr[i] = ucgrd.Rows[j].Cells[i].Value.ToString();
             }
             else
             {
                 dr[i] = "";
             }
         }
         dt.Rows.Add(dr);
     }
     ds.Tables.Add(dt);

     return ds;
 }*/


    }




}
