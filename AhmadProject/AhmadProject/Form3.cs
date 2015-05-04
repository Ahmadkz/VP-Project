﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AhmadProject
{
    public partial class Form3 : Form
    {
        Label firstclicked = null;
        Label secondclicked = null;
        Random random = new Random();
        List<string> icons = new List<string>()
    {
             "!","!","N","N",",",",","K","K",
             "b","b","v","v","w","w","z","z"
    };
        public Form3()
        {
            
            InitializeComponent();
            AssignIconsToSquares();

        }
        private void AssignIconsToSquares()
        {
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconlabel = control as Label;
                if (iconlabel != null)
                {
                    int randomno = random.Next(icons.Count);
                    iconlabel.Text = icons[randomno];
                    icons.RemoveAt(randomno);
                    iconlabel.ForeColor = iconlabel.BackColor;
                }


            }



        }

        private void Cards_Click(object sender, EventArgs e)
        {
            
            Label clickedlabel = sender as Label;
            if (clickedlabel != null)
            {
                if (clickedlabel.ForeColor == Color.Black)
                    return;
                if (firstclicked == null)
                {
                    firstclicked = clickedlabel;
                    firstclicked.ForeColor = Color.Black;
                }
                else if (secondclicked == null)
                {
                    secondclicked = clickedlabel;
                    secondclicked.ForeColor = Color.Black;
                }

                else if (firstclicked != secondclicked)
                {
                    firstclicked.ForeColor = firstclicked.BackColor;
                    secondclicked.ForeColor = secondclicked.BackColor;
                }

            }


        }

       
    }
}
