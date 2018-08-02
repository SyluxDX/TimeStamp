using System;
using System.Windows.Forms;

namespace TimeStamp{
    public partial class ComboSelection : Form{
        public string selectedFile = "";
        public GUI gui;
        public ComboSelection(string[] files, GUI gui){
            InitializeComponent();
            filesComboBox.DataSource = files;
            filesComboBox.SelectedIndex = -1;
            this.gui = gui;
        }

        private void button1_Click(object sender, EventArgs e){
            if (filesComboBox.SelectedItem == null){
                MessageBox.Show("Please choose one file name from the Combo Box");
            }else{
                selectedFile = filesComboBox.SelectedItem.ToString();
                Close();
                gui.Show();
            }
        }

    }
}
