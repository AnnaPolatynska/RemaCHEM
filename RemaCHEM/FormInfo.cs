using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RemaCHEM
{
    public partial class Frame : Form
    {
        public Frame(string s)
        {
            InitializeComponent();
            labelTekst.Text = s;
            labelTekst.Left = (this.Width - labelTekst.Width) / 2;
            labelTekst.Top = (this.Height - labelTekst.Height) / 2;
        }// FormInfo(string s)
    }//class FormInfo : Form
}//namespace RemaCHEM
