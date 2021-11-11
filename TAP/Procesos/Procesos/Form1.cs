using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Procesos
{
    public partial class Form1 : Form
    {
        /* 3 vectores donde guardo los nombres, tamaños y uno temporal
         */
        int[] tamaño = new int[10];
        string[] nombre = new string[10];
        int[] a = new int[10];
        int i = 0;
        int k = 0;
        public Form1()
        {
            InitializeComponent();
        }
        /*El botón de asignar guarda en la memoria y su respectivo tamaño, guardados en las tareas actuales
         * y mostranto el uso de la memoria marcando un "1"
         */
        private void button1_Click(object sender, EventArgs e)
        {
            nombre[i] = txb19.Text;
            tamaño[i] = int.Parse(txb20.Text);
            Condicion();
            lbx1.Items.Add(nombre[i]);
            i = i + 1;
        } 

        /*Ignorar no falta explicar, PASAR RÁPIDO PA'BAJO
         */
        private void Condicion()
        {
            if (tamaño[i] >= 100 && tamaño[i] < 200)
            {
                txb1.Text = "1";
            }
            if (tamaño[i] >= 200 && tamaño[i] < 300)
            {
                txb2.Text = "1";
            }
            if (tamaño[i] >= 300 && tamaño[i] < 400)
            {
                txb3.Text = "1";
            }
            if (tamaño[i] >= 400 && tamaño[i] < 500)
            {
                txb4.Text = "1";
            }
            if (tamaño[i] >= 500 && tamaño[i] < 600)
            {
                txb5.Text = "1";
            }
            if (tamaño[i] >= 600 && tamaño[i] < 700)
            {
                txb6.Text = "1";
            }
            if (tamaño[i] >= 700 && tamaño[i] < 800)
            {
                txb7.Text = "1";
            }
            if (tamaño[i] >= 800 && tamaño[i] < 900)
            {
                txb8.Text = "1";
            }
            if (tamaño[i] >= 900 && tamaño[i] < 1000)
            {
                txb9.Text = "1";
            }
            if (tamaño[i] >= 1000 && tamaño[i] < 1100)
            {
                txb10.Text = "1";
            }
        }

        /*
         */
        private void button2_Click(object sender, EventArgs e)
        {
            string temp;
            temp = lbx1.SelectedItem.ToString();
           // MessageBox.Show("Tengo el nombre");
            for (int j = 0; j < 10; j++)
            {
                if (nombre[j].Equals(temp))
                {
                   // MessageBox.Show("comparo");
                    //MessageBox.Show("Encontré el nombre, mando vector: " + nombre[j]);
                    for(int l = 0; l < 10; l++)
                    {
                        if(tamaño[l] == tamaño[j])
                        {
                            //MessageBox.Show("encontré el tamaño, mando: " + a[j]);
                            a[j] = tamaño[l];
                            Condicion2(a, j);
                            lbx1.Items.RemoveAt(lbx1.SelectedIndex);
                            break;
                        }
                    }
                    break;
                }
            }
            txb19.Clear();
            txb20.Clear();
        }
        private void Condicion2(int [] a, int j)
        {
            if (tamaño[k] == a[j])
            {
                txb1.Text = "0";
            }
            k = k + 1;
            if (tamaño[k] == a[j])
            {
                txb2.Text = "0";
            }
            k = k++;
            if (tamaño[k] == a[j])
            {
                txb3.Text = "0";
            }
            k = k++;
            if (tamaño[k] == a[j])
            {
                txb4.Text = "0";
            }
            k = k++;
            if (tamaño[k] == a[j])
            {
                txb5.Text = "0";
            }
            k = k++;
            if (tamaño[k] == a[j])
            {
                txb6.Text = "0";
            }
            k = k++;
            if (tamaño[k] == a[j])
            {
                txb7.Text = "0";
            }
            k = k++;
            if (tamaño[k] == a[j])
            {
                txb8.Text = "0";
            }
            k = k++;
            if (tamaño[k] == a[j])
            {
                txb9.Text = "0";
            }
            k = k++;
            if (tamaño[k] == a[j])
            {
                txb10.Text = "0";
            }
            k = k++;
            //un objeto con dos propiedas con nombre y tamaño, teniendo el nombre y tamaño se pueden modificar
        }
    }
}
