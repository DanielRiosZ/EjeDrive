﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EjeDrive.Algoritmos;

namespace EjeDrive
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Paso 0: Condición de vacío
            if(textBox1.Text.Equals("") || textBox2.Text.Equals(""))
            {
                MessageBox.Show("Los numeros tienen que ser mayor que 0, no vacíos");
                return;
            }
            
            // Paso 1: Inicialización de parámetros
            int totalValores = Convert.ToInt32(textBox1.Text);
            int ValorMuestra = Convert.ToInt32(textBox2.Text);

            // Paso 2: Declarar clase algoritmo genético

            AlgoritmoSimulacion algoritmo = new AlgoritmoSimulacion();

            // Paso 3: Llamar método principal

            List<int> listaEnteros = algoritmo.GenerarValores(totalValores);

            // Paso 4: Llenar el grid

            llenarGrid(listaEnteros);
        }

        public void llenarGrid(List<int> lista)
        {
            // Paso 0: Indicar el número de columnas

            string numeroColumna1 = "1";
            string numeroColumna2 = "2";

            // Paso 1: Determinar la cantidad de columnas

            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add(numeroColumna1, "Id");
            dataGridView1.Columns.Add(numeroColumna2, "Valor");

            // Paso 2: Recorrer el grid para cada fila y llenar de vaores aleatorios

            for (int i = 0; i < lista.Count; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[Int32.Parse(numeroColumna1) - 1].Value = (i + 1).ToString();
                dataGridView1.Rows[i].Cells[Int32.Parse(numeroColumna2) - 1].Value = lista[i].ToString();
            }

        }


        public void DescargaExcel(DataGridView data)

        private void button2_Click(object sender, EventArgs e)

    }
}
