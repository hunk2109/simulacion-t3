using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ej3
{
    public partial class Form1 : Form
    {

        public void Limpiar()
        {
            txtcarn.Clear();
            txtnomb.Clear();
            txtsal.Clear();
        }
        Queue<Empleados> trabajadores = new Queue<Empleados>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Btnrgis_Click(object sender, EventArgs e)
        {
            try {
                Empleados emp = new Empleados();
                emp.carnet = txtcarn.Text;
                emp.nombre = txtnomb.Text;
                emp.salario = decimal.Parse(txtsal.Text);
                emp.fecha = dtpfecha.Value;
                trabajadores.Enqueue(emp);
                dgvempl.DataSource = null;
                dgvempl.DataSource = trabajadores.ToArray();
                Limpiar();
                txtcarn.Focus();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Btnelimi_Click(object sender, EventArgs e)
        {
            if (trabajadores.Count != 0)
            {
                
                    Empleados emp = new Empleados();
                    emp = trabajadores.Dequeue();
                    txtcarn.Text = emp.carnet;
                    txtnomb.Text = emp.nombre;
                    txtsal.Text = emp.salario.ToString();
                    dtpfecha.Value = emp.fecha;
                    dgvempl.DataSource = trabajadores.ToList();
                    MessageBox.Show("Se elimino un Empleado de la Lista", "Aviso");
                    Limpiar();
                }
                
                

            else
            {
                MessageBox.Show("No hay Empleados en espera!");
                Limpiar();
            }

            txtcarn.Focus();
        }

        private void Btnsal_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Txtcarn_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtcarn.Text))
            {
                txtcarn.Focus();
                errorProvider1.SetError(txtcarn, "Introduzca su Carnet !");

            }

            else
            {
                errorProvider1.SetError(txtcarn, null);

            }
        }

        private void Txtsal_Validating(object sender, CancelEventArgs e)
        {

           
        
    }

        private void Txtnomb_Validating(object sender, CancelEventArgs e)
        {

           
        }

        private void Txtnomb_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtnomb.Text))
            {
                txtcarn.Focus();
                errorProvider1.SetError(txtnomb, "Introduzca su Nombre !");

            }

            else
            {
                errorProvider1.SetError(txtnomb, null);

            }
        }

        private void Txtsal_VisibleChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtsal.Text))
            {
                txtcarn.Focus();
                errorProvider1.SetError(txtsal, "Introduzca su Nombre !");

            }

            else
            {
                errorProvider1.SetError(txtsal, null);

            }
        }
    }
    }
    

