using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TDL
{
    public partial class Form1 : Form
    {

        CheckBox[] checkBoxes;
        int counter = 0;
        public Form1()
        {
            InitializeComponent();
            checkBoxes = new CheckBox[]
            {
                checkBox1, checkBox2, checkBox3, checkBox4,
                checkBox5, checkBox6, checkBox7, checkBox8, checkBox9, checkBox10, checkBox11,
                checkBox12, checkBox13, checkBox14, checkBox15
            };
        }

        private void addButtonClicked(object sender, MouseEventArgs e)
        {
            if(itemToBeAdded.Text != "")
            {
                checkBoxes[counter].Text = itemToBeAdded.Text;
                checkBoxes[counter].Visible = true;
                counter += 1;
                itemToBeAdded.Text = "";
            }
        }

        private void clearButtonClicked(object sender, MouseEventArgs e)
        {
            foreach(CheckBox cb in checkBoxes)
            {
                cb.Visible = false;
                cb.Text = "";
            }

            counter = 0;
        }

        private void enterPressed(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter && itemToBeAdded.Text != "")
            {
                checkBoxes[counter].Visible = true;
                checkBoxes[counter].Text = itemToBeAdded.Text;
                counter += 1;
                itemToBeAdded.Text = "";
            }
        }
    }
}
