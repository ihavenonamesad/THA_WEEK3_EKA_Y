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
    public partial class Second_Window_Form : Form
    {
        public MainForm reference { get; set; }
        public Second_Window_Form()
        {
            InitializeComponent();

        }

        private void Wow_lbl_Click(object sender, EventArgs e)
        {

        }

        private void MAGIC_btn_Click(object sender, EventArgs e)
        {
            if ((Red_rad.Checked || Blue_rad.Checked || Green_rad.Checked || Yellow_rad.Checked || Pink_rad.Checked) && (Purple_rad.Checked || Gold_rad.Checked || Silver_rad.Checked))
            {
                if (True_check.Checked && Agree_check.Checked)
                {
                    if (Red_rad.Checked)
                    {
                        reference.BackColor = Color.Red;
                    }
                    if (Blue_rad.Checked)
                    {
                        reference.BackColor = Color.Blue;
                    }
                    if (Green_rad.Checked)
                    {
                        reference.BackColor = Color.Green;
                    }
                    if (Yellow_rad.Checked)
                    {
                        reference.BackColor = Color.Yellow;
                    }
                    if (Pink_rad.Checked)
                    {
                        reference.BackColor = Color.Pink;
                    }
                    if (Purple_rad.Checked)
                    {
                        reference.ForeColor = Color.Purple;
                    }
                    if (Gold_rad.Checked)
                    {
                        reference.ForeColor = Color.Gold;
                    }
                    if (Silver_rad.Checked)
                    {
                        reference.ForeColor = Color.Silver;
                    }
                }
                else
                {
                    MessageBox.Show("Enter the correct input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
            }
            else
            {
                MessageBox.Show("Enter the correct input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        } 

        private void TextCol_lbl_Click(object sender, EventArgs e)
        {

        }

        private void Second_Window_Form_Load(object sender, EventArgs e)
        {
            
        }
        public void Title(string a)
        {
            Wow_lbl.Text = a;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Agree_check_CheckedChanged(object sender, EventArgs e)
        {
           if (Agree_check.Checked && True_check.Checked)
           {
                MAGIC_btn.Enabled=true;
            }
            else
            {
                MAGIC_btn.Enabled =false;
            }
        }

        private void True_check_CheckedChanged(object sender, EventArgs e)
        {
            if (Agree_check.Checked && True_check.Checked)
            {
                MAGIC_btn.Enabled = true;
            } else
            {
                MAGIC_btn.Enabled = false;
            }
        }
    }
}
