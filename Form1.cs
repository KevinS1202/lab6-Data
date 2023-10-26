using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double calcular = 0;
            double calcular1 = 0;
            double calcular2 = 0;
            double calcular3 = 0;
            double calcular4 = 0;
            
            foreach (DataGridViewRow row in Matriz.Rows)
            {
                calcular += Convert.ToInt32(row.Cells["Column1"].Value);
               
            }
            foreach (DataGridViewRow row in Matriz.Rows)
            {
                calcular1 += Convert.ToInt32(row.Cells["Column2"].Value);
            }
            foreach (DataGridViewRow row in Matriz.Rows)
            {
                calcular2 += Convert.ToInt32(row.Cells["Column3"].Value);
            }
            foreach (DataGridViewRow row in Matriz.Rows)
            {
                calcular3 += Convert.ToInt32(row.Cells["Column4"].Value);
            }
            foreach (DataGridViewRow row in Matriz.Rows)
            {
                calcular4 += Convert.ToInt32(row.Cells["Column5"].Value);
            }

            double max = calcular;

            if (max < calcular1)
            {
                max = calcular1;
            }
            if (max < calcular2)
            {
                max = calcular2;
            }
            if (max < calcular3)
            {
                max = calcular3;
            }
            if (max < calcular4)
            {
                max = calcular4;
            }
            textBox1.Text = Convert.ToString(max);

        }



        private void Matriz_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
