namespace Figury_kalkulator
{
    partial class Form1
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
<<<<<<< HEAD
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.wysokosc_txb = new System.Windows.Forms.TextBox();
            this.szerokosc_txb = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.obwod_rb = new System.Windows.Forms.RadioButton();
            this.pole_rb = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.okrag_rb = new System.Windows.Forms.RadioButton();
            this.trapez_rb = new System.Windows.Forms.RadioButton();
            this.rownoleglobok_rb = new System.Windows.Forms.RadioButton();
            this.osmiokat_rb = new System.Windows.Forms.RadioButton();
            this.trojkat_rb = new System.Windows.Forms.RadioButton();
            this.prostokat_rb = new System.Windows.Forms.RadioButton();
            this.wynik_txb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.policz = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wysokość";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Szerokosc";
            // 
            // wysokosc_txb
            // 
            this.wysokosc_txb.ForeColor = System.Drawing.SystemColors.MenuText;
            this.wysokosc_txb.Location = new System.Drawing.Point(89, 21);
            this.wysokosc_txb.Name = "wysokosc_txb";
            this.wysokosc_txb.Size = new System.Drawing.Size(100, 20);
            this.wysokosc_txb.TabIndex = 2;
            this.wysokosc_txb.TextChanged += new System.EventHandler(this.wysokosc_txb_TextChanged);
            // 
            // szerokosc_txb
            // 
            this.szerokosc_txb.Location = new System.Drawing.Point(89, 61);
            this.szerokosc_txb.Name = "szerokosc_txb";
            this.szerokosc_txb.Size = new System.Drawing.Size(100, 20);
            this.szerokosc_txb.TabIndex = 3;
            this.szerokosc_txb.TextChanged += new System.EventHandler(this.szerokosc_txb_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.obwod_rb);
            this.groupBox1.Controls.Add(this.pole_rb);
            this.groupBox1.Location = new System.Drawing.Point(247, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(78, 80);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Policz";
            // 
            // obwod_rb
            // 
            this.obwod_rb.AutoSize = true;
            this.obwod_rb.Location = new System.Drawing.Point(6, 42);
            this.obwod_rb.Name = "obwod_rb";
            this.obwod_rb.Size = new System.Drawing.Size(59, 17);
            this.obwod_rb.TabIndex = 1;
            this.obwod_rb.Text = "Obwód";
            this.obwod_rb.UseVisualStyleBackColor = true;
            // 
            // pole_rb
            // 
            this.pole_rb.AutoSize = true;
            this.pole_rb.Checked = true;
            this.pole_rb.Location = new System.Drawing.Point(7, 19);
            this.pole_rb.Name = "pole_rb";
            this.pole_rb.Size = new System.Drawing.Size(46, 17);
            this.pole_rb.TabIndex = 0;
            this.pole_rb.TabStop = true;
            this.pole_rb.Text = "Pole";
            this.pole_rb.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.okrag_rb);
            this.groupBox2.Controls.Add(this.trapez_rb);
            this.groupBox2.Controls.Add(this.rownoleglobok_rb);
            this.groupBox2.Controls.Add(this.osmiokat_rb);
            this.groupBox2.Controls.Add(this.trojkat_rb);
            this.groupBox2.Controls.Add(this.prostokat_rb);
            this.groupBox2.Location = new System.Drawing.Point(29, 146);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Figura";
            // 
            // okrag_rb
            // 
            this.okrag_rb.AutoSize = true;
            this.okrag_rb.Location = new System.Drawing.Point(97, 65);
            this.okrag_rb.Name = "okrag_rb";
            this.okrag_rb.Size = new System.Drawing.Size(54, 17);
            this.okrag_rb.TabIndex = 5;
            this.okrag_rb.Text = "Okrąg";
            this.okrag_rb.UseVisualStyleBackColor = true;
            // 
            // trapez_rb
            // 
            this.trapez_rb.AutoSize = true;
            this.trapez_rb.Location = new System.Drawing.Point(97, 42);
            this.trapez_rb.Name = "trapez_rb";
            this.trapez_rb.Size = new System.Drawing.Size(58, 17);
            this.trapez_rb.TabIndex = 4;
            this.trapez_rb.Text = "Trapez";
            this.trapez_rb.UseVisualStyleBackColor = true;
            // 
            // rownoleglobok_rb
            // 
            this.rownoleglobok_rb.AutoSize = true;
            this.rownoleglobok_rb.Location = new System.Drawing.Point(97, 19);
            this.rownoleglobok_rb.Name = "rownoleglobok_rb";
            this.rownoleglobok_rb.Size = new System.Drawing.Size(101, 17);
            this.rownoleglobok_rb.TabIndex = 3;
            this.rownoleglobok_rb.Text = "Równoległobok";
            this.rownoleglobok_rb.UseVisualStyleBackColor = true;
            // 
            // osmiokat_rb
            // 
            this.osmiokat_rb.AutoSize = true;
            this.osmiokat_rb.Location = new System.Drawing.Point(6, 65);
            this.osmiokat_rb.Name = "osmiokat_rb";
            this.osmiokat_rb.Size = new System.Drawing.Size(69, 17);
            this.osmiokat_rb.TabIndex = 2;
            this.osmiokat_rb.Text = "Ośmiokąt";
            this.osmiokat_rb.UseVisualStyleBackColor = true;
            // 
            // trojkat_rb
            // 
            this.trojkat_rb.AutoSize = true;
            this.trojkat_rb.Location = new System.Drawing.Point(6, 42);
            this.trojkat_rb.Name = "trojkat_rb";
            this.trojkat_rb.Size = new System.Drawing.Size(58, 17);
            this.trojkat_rb.TabIndex = 1;
            this.trojkat_rb.Text = "Trójkąt";
            this.trojkat_rb.UseVisualStyleBackColor = true;
            // 
            // prostokat_rb
            // 
            this.prostokat_rb.AutoSize = true;
            this.prostokat_rb.Checked = true;
            this.prostokat_rb.Location = new System.Drawing.Point(6, 19);
            this.prostokat_rb.Name = "prostokat_rb";
            this.prostokat_rb.Size = new System.Drawing.Size(70, 17);
            this.prostokat_rb.TabIndex = 0;
            this.prostokat_rb.TabStop = true;
            this.prostokat_rb.Text = "Prostokąt";
            this.prostokat_rb.UseVisualStyleBackColor = true;
            // 
            // wynik_txb
            // 
            this.wynik_txb.Location = new System.Drawing.Point(89, 102);
            this.wynik_txb.Name = "wynik_txb";
            this.wynik_txb.ReadOnly = true;
            this.wynik_txb.Size = new System.Drawing.Size(100, 20);
            this.wynik_txb.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Wynik";
            // 
            // policz
            // 
            this.policz.Location = new System.Drawing.Point(267, 156);
            this.policz.Name = "policz";
            this.policz.Size = new System.Drawing.Size(75, 23);
            this.policz.TabIndex = 8;
            this.policz.Text = "Policz";
            this.policz.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 394);
            this.Controls.Add(this.policz);
            this.Controls.Add(this.wynik_txb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.szerokosc_txb);
            this.Controls.Add(this.wysokosc_txb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox wysokosc_txb;
        private System.Windows.Forms.TextBox szerokosc_txb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton obwod_rb;
        private System.Windows.Forms.RadioButton pole_rb;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton okrag_rb;
        private System.Windows.Forms.RadioButton trapez_rb;
        private System.Windows.Forms.RadioButton rownoleglobok_rb;
        private System.Windows.Forms.RadioButton osmiokat_rb;
        private System.Windows.Forms.RadioButton trojkat_rb;
        private System.Windows.Forms.RadioButton prostokat_rb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button policz;
        protected System.Windows.Forms.TextBox wynik_txb;
=======
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Text = "Form1";
        }

        #endregion
>>>>>>> d4b53367ebb6710eef0f682733572ff617c4bc4f
    }
}

