using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
            if (radioButton_COM.Checked)
            {
                dataSrc = DataSource.COM;
                dataSrcName = textBox_COM.Text;
            }
            else if (radioButton_File.Checked)
            {
                dataSrc = DataSource.File;
                dataSrcName = textBox_File.Text;
            }
            else if (radioButton_Wifi.Checked)
            {
                dataSrc = DataSource.WIFI;
                dataSrcName = textBox_File.Text;
            }
        }

        private void button_Open_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (DialogResult.OK == ofd.ShowDialog())
            {
                textBox_File.Text = ofd.FileName;
            }

        }
    }

    public enum DataSource
    {
        COM,
        File,
        WIFI
    }
}
