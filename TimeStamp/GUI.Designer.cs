namespace TimeStamp
{
    partial class GUI
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
            this.button_log = new System.Windows.Forms.Button();
            this.button_compute = new System.Windows.Forms.Button();
            this.button_check = new System.Windows.Forms.Button();
            this.textbox = new System.Windows.Forms.TextBox();
            this.select_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_log
            // 
            this.button_log.Location = new System.Drawing.Point(88, 26);
            this.button_log.Name = "button_log";
            this.button_log.Size = new System.Drawing.Size(160, 30);
            this.button_log.TabIndex = 0;
            this.button_log.Text = "Log Time";
            this.button_log.UseVisualStyleBackColor = true;
            this.button_log.Click += new System.EventHandler(this.button_log_Click);
            // 
            // button_compute
            // 
            this.button_compute.Location = new System.Drawing.Point(88, 90);
            this.button_compute.Name = "button_compute";
            this.button_compute.Size = new System.Drawing.Size(160, 30);
            this.button_compute.TabIndex = 1;
            this.button_compute.Text = "Compute Time";
            this.button_compute.UseVisualStyleBackColor = true;
            this.button_compute.Click += new System.EventHandler(this.button_compute_Click);
            // 
            // button_check
            // 
            this.button_check.Location = new System.Drawing.Point(88, 156);
            this.button_check.Name = "button_check";
            this.button_check.Size = new System.Drawing.Size(160, 30);
            this.button_check.TabIndex = 2;
            this.button_check.Text = "Check Time";
            this.button_check.UseVisualStyleBackColor = true;
            this.button_check.Click += new System.EventHandler(this.button_check_Click);
            // 
            // textbox
            // 
            this.textbox.Location = new System.Drawing.Point(44, 230);
            this.textbox.Multiline = true;
            this.textbox.Name = "textbox";
            this.textbox.ReadOnly = true;
            this.textbox.Size = new System.Drawing.Size(250, 200);
            this.textbox.TabIndex = 3;
            // 
            // select_button
            // 
            this.select_button.Location = new System.Drawing.Point(266, 90);
            this.select_button.Name = "select_button";
            this.select_button.Size = new System.Drawing.Size(34, 30);
            this.select_button.TabIndex = 4;
            this.select_button.Text = "...";
            this.select_button.UseVisualStyleBackColor = true;
            this.select_button.Click += new System.EventHandler(this.select_button_Click);
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 453);
            this.Controls.Add(this.select_button);
            this.Controls.Add(this.textbox);
            this.Controls.Add(this.button_check);
            this.Controls.Add(this.button_compute);
            this.Controls.Add(this.button_log);
            this.Name = "GUI";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_log;
        private System.Windows.Forms.Button button_compute;
        private System.Windows.Forms.Button button_check;
        private System.Windows.Forms.TextBox textbox;
        private System.Windows.Forms.Button select_button;
    }
}