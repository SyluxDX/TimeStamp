using System;
using System.Windows.Forms;
using System.IO;

namespace TimeStamp{
    public partial class GUI : Form{
        public GUI(){
            InitializeComponent();
        }

        private void button_log_Click(object sender, EventArgs e){
            string output = Program.LogTime();
            textbox.Text = output;
        }

        private void button_compute_Click(object sender, EventArgs e){
            string[] output = Program.ComputeTimeLogs(new string[1]);
            textbox.Text = output[1];
        }

        private void button_check_Click(object sender, EventArgs e){
            string output = Program.CheckTime();
            textbox.Text = output;
        }

        private void select_button_Click(object sender, EventArgs e){
            string path = Path.Combine(Directory.GetCurrentDirectory(), "timestamp");
            string[] files = Directory.GetFiles(path);
            for (int i = 0; i < files.Length; i++){
                files[i] = files[i].Replace(path, "");
                files[i] = files[i].Replace("\\", "");
            }
            ComboSelection combo = new ComboSelection(files, this);
            //Application.Run(combo);
            //this.Hide();
            combo.ShowDialog();
            string[] args = new string[2];
            args[1] = combo.selectedFile;
            string[] log=Program.ComputeTimeLogs(args);
            textbox.Text = log[1];
        }
    }
}
