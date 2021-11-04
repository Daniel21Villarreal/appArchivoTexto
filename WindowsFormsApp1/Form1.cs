using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Camisa[] a;
        int p = 0;
        public Form1()
        {
            InitializeComponent();
            a = new Camisa[10];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialogo = new OpenFileDialog();
            if (dialogo.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(dialogo.FileName);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog dialogo = new SaveFileDialog();
            if (dialogo.ShowDialog()== DialogResult.OK)
            {

                //MessangeBox.show(dialogo.FileName);
                using (StreamWriter archivo = new StreamWriter(dialogo.FileName))
                {
                    for (int i = 0; i < a.Length; i++)
                    {
                        if (a[i] != null)
                        {
                            archivo.WriteLineAsync(a[i].ToString());
                        }
                    }
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void instalar_Click(object sender, EventArgs e)
        {
            Camisa n = new Camisa();
            n.Talla = double.Parse(txtTalla.Text);
            n.Color = txtColor.Text;
            a[p] = n;

            lstArreglo.Items.Add(a[p]);
            p++;
            
        }
    }
}
