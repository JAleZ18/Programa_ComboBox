using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Collections;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Principal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }
       
        private  void btnCorrer_Click(object sender, EventArgs e)

        {  

            LlenarCombo( textBox1.Text, comboBox1, "id", "nombre");
          
        }
        
        public static void LlenarCombo(string consulta, ComboBox comboBox1, string id, string campo)
        {
            DataTable dt;
            dt = Conexion.EjecutaSeleccion(consulta);

            DataRow fila = dt.NewRow();
            
            fila[0] = 0;
            fila[1] = "Todos los datos";
           dt.Rows.InsertAt(fila, 0);
            if (dt == null)
            {
                return;
            }

            comboBox1.Items.Clear();
            comboBox1.DataSource = dt;         
            comboBox1.ValueMember = id;
            comboBox1.DisplayMember = campo;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = comboBox1.SelectedValue.ToString();
        }
    }
}
