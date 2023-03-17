using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THA_W3_EKA_Y
{
    public partial class MainForm : Form
    {
        Second_Window_Form second_window = new Second_Window_Form();
        public TextBox name_plz;
        public TextBox artist_plz;
        public bool open=false;
        public MainForm()
        {
            InitializeComponent();
            name_plz = Name_txt;
            artist_plz = Artist_txt;
        }

        private void Name_lbl_Click(object sender, EventArgs e)
        {

        }

        private void Next_btn_Click(object sender, EventArgs e)
        {
            second_window.reference = this;
            second_window.Show();
            open = true;
        }

        private void Submit_btn_Click(object sender, EventArgs e)
        {
            if (True_check.Checked &&  open==true)
            {
                second_window.Title("My name is " + name_plz.Text + ". My favorite artist is " + artist_plz.Text);
            }
            if (Name_txt.Text == "" && Artist_txt.Text=="")
            {
                MessageBox.Show("Enter the correct input.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
    }
}
