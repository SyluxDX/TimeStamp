namespace TimeStamp
{
    partial class ComboSelection
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
            this.filesComboBox = new System.Windows.Forms.ComboBox();
            this.useButton = new System.Windows.Forms.Button();
            this.window_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // filesComboBox
            // 
            this.filesComboBox.FormattingEnabled = true;
            this.filesComboBox.Location = new System.Drawing.Point(47, 96);
            this.filesComboBox.Name = "filesComboBox";
            this.filesComboBox.Size = new System.Drawing.Size(190, 24);
            this.filesComboBox.TabIndex = 0;
            // 
            // useButton
            // 
            this.useButton.Location = new System.Drawing.Point(65, 170);
            this.useButton.Name = "useButton";
            this.useButton.Size = new System.Drawing.Size(153, 32);
            this.useButton.TabIndex = 1;
            this.useButton.Text = "Use selected file";
            this.useButton.UseVisualStyleBackColor = true;
            this.useButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // window_label
            // 
            this.window_label.AutoSize = true;
            this.window_label.Location = new System.Drawing.Point(69, 41);
            this.window_label.Name = "window_label";
            this.window_label.Size = new System.Drawing.Size(140, 17);
            this.window_label.TabIndex = 2;
            this.window_label.Text = "Select one file name:";
            // 
            // ComboSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.window_label);
            this.Controls.Add(this.useButton);
            this.Controls.Add(this.filesComboBox);
            this.Name = "ComboSelection";
            this.Text = "ComboSelection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox filesComboBox;
        private System.Windows.Forms.Button useButton;
        private System.Windows.Forms.Label window_label;
    }
}