using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Figury_kalkulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
<<<<<<< HEAD
        private bool czyDouble(String dana)
        {
            bool czy = true;
            try
            {
                Convert.ToDouble(dana);
            }
            catch (FormatException e)
            {
                czy = false;
                MessageBox.Show("Podana wartość nie jest liczbą ");
            }

            return czy;

        }

        private void wysokosc_txb_TextChanged(object sender, EventArgs e)
        {
            if(wysokosc_txb.Text !="")
                if (!czyDouble(wysokosc_txb.Text))
                {
                    wysokosc_txb.BackColor = Color.Red;
                    this.ActiveControl = wysokosc_txb;
                }
                else
                {
                    wysokosc_txb.BackColor = Color.White;
                }
        }

        private void szerokosc_txb_TextChanged(object sender, EventArgs e)
        {
            if(szerokosc_txb.Text !="")
                if (!czyDouble(szerokosc_txb.Text))
                {
                    szerokosc_txb.BackColor = Color.Red;
                    this.ActiveControl = szerokosc_txb;
                }
                else
                {
                    szerokosc_txb.BackColor = Color.White;
                }
        }
=======
>>>>>>> d4b53367ebb6710eef0f682733572ff617c4bc4f
    }
}
