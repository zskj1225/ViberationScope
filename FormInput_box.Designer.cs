namespace ViberationScope
{
    partial class FormInput_box
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
            this.yes_button = new System.Windows.Forms.Button();
            this.no_button = new System.Windows.Forms.Button();
            this.cha_label = new System.Windows.Forms.Label();
            this.Frequency_comboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // yes_button
            // 
            this.yes_button.Location = new System.Drawing.Point(53, 99);
            this.yes_button.Name = "yes_button";
            this.yes_button.Size = new System.Drawing.Size(68, 23);
            this.yes_button.TabIndex = 0;
            this.yes_button.Text = "确定";
            this.yes_button.UseVisualStyleBackColor = true;
            this.yes_button.Click += new System.EventHandler(this.yes_button_Click);
            // 
            // no_button
            // 
            this.no_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.no_button.Location = new System.Drawing.Point(127, 99);
            this.no_button.Name = "no_button";
            this.no_button.Size = new System.Drawing.Size(58, 23);
            this.no_button.TabIndex = 1;
            this.no_button.Text = "取消";
            this.no_button.UseVisualStyleBackColor = true;
            this.no_button.Click += new System.EventHandler(this.no_button_Click);
            // 
            // cha_label
            // 
            this.cha_label.AutoSize = true;
            this.cha_label.Location = new System.Drawing.Point(23, 19);
            this.cha_label.Name = "cha_label";
            this.cha_label.Size = new System.Drawing.Size(137, 12);
            this.cha_label.TabIndex = 2;
            this.cha_label.Text = "请输入两点间峰值间隔：";
            // 
            // Frequency_comboBox
            // 
            this.Frequency_comboBox.FormattingEnabled = true;
            this.Frequency_comboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.Frequency_comboBox.Location = new System.Drawing.Point(53, 52);
            this.Frequency_comboBox.Name = "Frequency_comboBox";
            this.Frequency_comboBox.Size = new System.Drawing.Size(117, 20);
            this.Frequency_comboBox.TabIndex = 3;
            // 
            // FormInput_box
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CancelButton = this.no_button;
            this.ClientSize = new System.Drawing.Size(220, 143);
            this.Controls.Add(this.Frequency_comboBox);
            this.Controls.Add(this.cha_label);
            this.Controls.Add(this.no_button);
            this.Controls.Add(this.yes_button);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormInput_box";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "谐波差数";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button yes_button;
        private System.Windows.Forms.Button no_button;
        private System.Windows.Forms.Label cha_label;
        private System.Windows.Forms.ComboBox Frequency_comboBox;
    }
}