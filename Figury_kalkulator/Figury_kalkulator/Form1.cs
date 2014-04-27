using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Nunit;

namespace Figury_kalkulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

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

        private void obliczPole()
        {
            String wynik = "";
            if (okrag_rb.Checked)
            {
                Okrag o = new Okrag();
                o.promien=Convert.ToDouble(wysokosc_txb.Text);
                wynik = "" + o.pole();
                

            }
            else if (osmiokat_rb.Checked)
            {
                Osmiokat o = new Osmiokat();
                o.bok_a = Convert.ToDouble(wysokosc_txb.Text);
                wynik=""+o.pole();
            }
            else if (prostokat_rb.Checked)
            {
                Prostokat p = new Prostokat(Convert.ToDouble(wysokosc_txb.Text), Convert.ToDouble(szerokosc_txb.Text));
                wynik = "" + p.pole();

            }
            else if (rownoleglobok_rb.Checked)
            {
                Rownoleglobok r = new Rownoleglobok(Convert.ToDouble(wysokosc_txb.Text), 1, Convert.ToDouble(szerokosc_txb.Text));

            }
            else if (trapez_rb.Checked)
            {
                Trapez t = new Trapez();
                t.podstawa_dolna = Convert.ToDouble(wysokosc_txb.Text);
                t.podstawa_gorna = Convert.ToDouble(szerokosc_txb);
                t.wysokosc = Convert.ToDouble(textBox1.Text);
                wynik= ""+t.pole();

            }
            else if (trojkat_rb.Checked)
            {
                Trojkat t = new Trojkat(Convert.ToDouble(szerokosc_txb.Text),Convert.ToDouble(wysokosc_txb.Text));
                wynik = "" + t.pole();

            }
            wynik_txb.Text = wynik;

        }

        private void obliczObwod()
        {
            String wynik = "";
            if (okrag_rb.Checked)
            {
                Okrag o = new Okrag();
                o.promien = Convert.ToDouble(wysokosc_txb.Text);
                wynik =""+ o.obwod();

            }
            else if (osmiokat_rb.Checked)
            {
                Osmiokat o = new Osmiokat();
                o.bok_a=Convert.ToDouble(wysokosc_txb.Text);
                wynik = "" + o.obwod();
            }
            else if (prostokat_rb.Checked)
            {
                Prostokat p = new Prostokat(Convert.ToDouble(wysokosc_txb.Text), Convert.ToDouble(szerokosc_txb.Text));
                wynik = "" + p.obwod();

            }
            else if (rownoleglobok_rb.Checked)
            {
                Rownoleglobok r = new Rownoleglobok(Convert.ToDouble(wysokosc_txb.Text), Convert.ToDouble(szerokosc_txb.Text), 1);
                wynik = "" + r.obwod();

            }
            else if (trapez_rb.Checked)
            {
                Trapez t = new Trapez();
                t.podstawa_dolna = Convert.ToDouble(wysokosc_txb.Text);
                t.podstawa_gorna = Convert.ToDouble(szerokosc_txb.Text);
                t.ramie_c = Convert.ToDouble(textBox1.Text);
                t.ramie_d = Convert.ToDouble(textBox2.Text);
                wynik = "" + t.obwod();

            }
            else if (trojkat_rb.Checked)
            {
                Trojkat t = new Trojkat(1,Convert.ToDouble(wysokosc_txb.Text),Convert.ToDouble(szerokosc_txb.Text),Convert.ToDouble(textBox1.Text));
                wynik = "" + t.obwod();
            }
            wynik_txb.Text = wynik;
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
                if (!czyDouble(textBox1.Text))
                {
                    textBox1.BackColor = Color.Red;
                    this.ActiveControl = textBox1;
                }
                else
                {
                    textBox1.BackColor = Color.White;
                }
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
                if (!czyDouble(textBox2.Text))
                {
                    textBox2.BackColor = Color.Red;
                    this.ActiveControl = textBox2;
                }
                else
                {
                    textBox2.BackColor = Color.White;
                }

        }

        private void policz_Click(object sender, EventArgs e)
        {
            if (pole_rb.Checked)
            {
                obliczPole();
            }
            else if (obwod_rb.Checked)
            {
                obliczObwod();
            }
        }

        private void trojkat_rb_CheckedChanged(object sender, EventArgs e)
        {
            if (trojkat_rb.Checked )
            {
                if (obwod_rb.Checked)
                {
                    label4.Visible = true;
                    label4.Text = "Podstawa C";
                    textBox1.Visible = true;
                    label1.Text = "Podstawa A";
                    label2.Text = "Podstawa B";
                }
                else if (pole_rb.Checked)
                {
                    label4.Visible = false;
                    textBox1.Visible = false;
                    label1.Text = "Podstawa A";
                    label2.Text = "Wysokośc";

                }
                

            }
            else if (!trojkat_rb.Checked)
            {
                label4.Visible = false;
                textBox1.Visible = false;
                label1.Text = "Wysokość";
                label2.Text = "Szerokośc";
                
            }

        }

        private void okrag_rb_CheckedChanged(object sender, EventArgs e)
        {
            if (okrag_rb.Checked)
            {
                label2.Visible = false;
                szerokosc_txb.Visible = false;
                label1.Text = "Promień";
            }
            else
            {
                label2.Visible = true;
                szerokosc_txb.Visible = true;
                label1.Text = "Wysokość";
            }

        }

        private void osmiokat_rb_CheckedChanged(object sender, EventArgs e)
        {
            if (osmiokat_rb.Checked)
            {
                label2.Visible = false;
                szerokosc_txb.Visible = false;
                label1.Text = "Bok A";
            }
            else
            {
                label2.Visible = true;
                szerokosc_txb.Visible = true;
                label1.Text = "Wysokość";
            }

        }
        
        private void rownoleglobok_rb_CheckedChanged(object sender, EventArgs e)
        {
            if (rownoleglobok_rb.Checked )
            {
                if (obwod_rb.Checked)
                {
                    label1.Text = "Ramie A";
                    label2.Text = "Ramie B";
                }
                else if (pole_rb.Checked)
                {
                    label1.Text = "Ramie A";
                    label2.Text = "Wysokość";
                }


            }
            else if (!rownoleglobok_rb.Checked )
            {
                label4.Visible = false;
                textBox1.Visible = false;
                label1.Text = "Wysokość";
                label2.Text = "Szerokośc";

            }

        }

        private void trapez_rb_CheckedChanged(object sender, EventArgs e)
        {
            if (trapez_rb.Checked)
            {
                if (pole_rb.Checked)
                {
                    label1.Text = "Podstawa dolna";
                    label2.Text = "Podstawa górna";
                    label4.Visible = true;
                    label4.Text = "Wysokość";
                    textBox1.Visible = true;
                }
                else if (obwod_rb.Checked)
                {
                    label1.Text = "Podstawa dolna";
                    label2.Text = "Podstawa górna";
                    label4.Visible = true;
                    label4.Text = "Ramie C";
                    textBox1.Visible = true;
                    label5.Visible = true;
                    label5.Text = "Ramie D";
                    textBox2.Visible = true;
                }
            }
            else
            {
                label1.Text = "Wysokość";
                label2.Text = "Szerokość";
                label4.Visible = false;
                textBox1.Visible = false;
                label5.Visible = false;
                textBox2.Visible = false;

            }
        }

        private void pole_rb_CheckedChanged(object sender, EventArgs e)
        {
            if (pole_rb.Checked)
            {
                if (trojkat_rb.Checked)
                {
                    label4.Visible = false;
                    textBox1.Visible = false;
                    label1.Text = "Podstawa A";
                    label2.Text = "Wysokośc";
                }
                else if (rownoleglobok_rb.Checked)
                {
                    label1.Text = "Ramie A";
                    label2.Text = "Wysokość";
                }
                else if (trapez_rb.Checked)
                {
                    label1.Text = "Podstawa dolna";
                    label2.Text = "Podstawa górna";
                    label4.Visible = true;
                    label4.Text = "Wysokość";
                    textBox1.Visible = true;
                    label5.Visible = false;
                    textBox2.Visible = false;
                }
            }
            else if (obwod_rb.Checked)
            {
                if (trojkat_rb.Checked)
                {
                    label4.Visible = true;
                    label4.Text = "Podstawa C";
                    textBox1.Visible = true;
                    label1.Text = "Podstawa A";
                    label2.Text = "Podstawa B";
                }
                else if (rownoleglobok_rb.Checked)
                {
                    label1.Text = "Ramie A";
                    label2.Text = "Ramie B";
                }
                else if (trapez_rb.Checked)
                {
                    label1.Text = "Podstawa dolna";
                    label2.Text = "Podstawa górna";
                    label4.Visible = true;
                    label4.Text = "Ramie C";
                    textBox1.Visible = true;
                    label5.Visible = true;
                    label5.Text = "Ramie D";
                    textBox2.Visible = true;
                }
            }

        }

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        

       

       

      

       


        

       
       
    }
}
