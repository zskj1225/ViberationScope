namespace ViberationScope
{
    partial class FormConfig
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.radioButton_COM = new System.Windows.Forms.RadioButton();
            this.radioButton_File = new System.Windows.Forms.RadioButton();
            this.button_OK = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.textBox_File = new System.Windows.Forms.TextBox();
            this.button_Open = new System.Windows.Forms.Button();
            this.textBox_COM = new System.Windows.Forms.TextBox();
            this.radioButton_Wifi = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // radioButton_COM
            // 
            this.radioButton_COM.AutoSize = true;
            this.radioButton_COM.Location = new System.Drawing.Point(33, 36);
            this.radioButton_COM.Name = "radioButton_COM";
            this.radioButton_COM.Size = new System.Drawing.Size(41, 16);
            this.radioButton_COM.TabIndex = 0;
            this.radioButton_COM.TabStop = true;
            this.radioButton_COM.Text = "COM";
            this.radioButton_COM.UseVisualStyleBackColor = true;
            // 
            // radioButton_File
            // 
            this.radioButton_File.AutoSize = true;
            this.radioButton_File.Location = new System.Drawing.Point(33, 69);
            this.radioButton_File.Name = "radioButton_File";
            this.radioButton_File.Size = new System.Drawing.Size(47, 16);
            this.radioButton_File.TabIndex = 1;
            this.radioButton_File.TabStop = true;
            this.radioButton_File.Text = "File";
            this.radioButton_File.UseVisualStyleBackColor = true;
            // 
            // button_OK
            // 
            this.button_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_OK.Location = new System.Drawing.Point(88, 137);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(75, 23);
            this.button_OK.TabIndex = 2;
            this.button_OK.Text = "OK";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_Cancel.Location = new System.Drawing.Point(216, 137);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.button_Cancel.TabIndex = 3;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            // 
            // textBox_File
            // 
            this.textBox_File.Location = new System.Drawing.Point(98, 68);
            this.textBox_File.Name = "textBox_File";
            this.textBox_File.Size = new System.Drawing.Size(176, 21);
            this.textBox_File.TabIndex = 4;
            // 
            // button_Open
            // 
            this.button_Open.Location = new System.Drawing.Point(297, 66);
            this.button_Open.Name = "button_Open";
            this.button_Open.Size = new System.Drawing.Size(75, 23);
            this.button_Open.TabIndex = 5;
            this.button_Open.Text = "Open";
            this.button_Open.UseVisualStyleBackColor = true;
            this.button_Open.Click += new System.EventHandler(this.button_Open_Click);
            // 
            // textBox_COM
            // 
            this.textBox_COM.Location = new System.Drawing.Point(98, 35);
            this.textBox_COM.Name = "textBox_COM";
            this.textBox_COM.Size = new System.Drawing.Size(100, 21);
            this.textBox_COM.TabIndex = 6;
            // 
            // radioButton_Wifi
            // 
            this.radioButton_Wifi.AutoSize = true;
            this.radioButton_Wifi.Location = new System.Drawing.Point(33, 105);
            this.radioButton_Wifi.Name = "radioButton_Wifi";
            this.radioButton_Wifi.Size = new System.Drawing.Size(47, 16);
            this.radioButton_Wifi.TabIndex = 7;
            this.radioButton_Wifi.TabStop = true;
            this.radioButton_Wifi.Text = "WIFI";
            this.radioButton_Wifi.UseVisualStyleBackColor = true;
            // 
            // FormConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 182);
            this.Controls.Add(this.radioButton_Wifi);
            this.Controls.Add(this.textBox_COM);
            this.Controls.Add(this.button_Open);
            this.Controls.Add(this.textBox_File);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.radioButton_File);
            this.Controls.Add(this.radioButton_COM);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormConfig";
            this.Text = "FormConfig";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton_COM;
        private System.Windows.Forms.RadioButton radioButton_File;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.TextBox textBox_File;
        private System.Windows.Forms.Button button_Open;
        private System.Windows.Forms.TextBox textBox_COM;
        private System.Windows.Forms.RadioButton radioButton_Wifi;
    }
}