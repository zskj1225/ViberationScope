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
    
    public partial class FormInput_box : Form
    {
        public inputFrequencySpacing addspacing;
        public FormInput_box()
        {
            InitializeComponent();
        }

        private void yes_button_Click(object sender, EventArgs e)
        {
            if (addspacing == null) return;
            int.TryParse(Frequency_comboBox.Text, out addspacing.theSp.sp);
           
            this.DialogResult = DialogResult.OK;
          
        }

        private void no_button_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.None;
            this.Close();
            
        }
    }
}
