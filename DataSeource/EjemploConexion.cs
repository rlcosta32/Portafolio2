using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataSeource
{
    public partial class EjemploConexion : Form
    {
        public EjemploConexion()
        {
            InitializeComponent();
        }

        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.northwindDataSet);

        }

        private void EjemploConexion_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'northwindDataSet.Customers' Puede moverla o quitarla según sea necesario.
            this.customersTableAdapter.Fill(this.northwindDataSet.Customers);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            customersBindingSource.AddNew();
        }

        private void toolStripTextBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                
                var index = customersBindingSource3.Find("customerID", toolStripTextBox4);
                if (index > -1)
                {
                    customersBindingSource.Position = index;
                    return;
                }
                else
                {
                    MessageBox.Show("Elemento no encontrado");
                }
            };
        }

        private void customersBindingSource1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource1.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.northwindDataSet1);

        }

        private void EjemploConexion_Load_1(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'northwindDataSet1.Customers' Puede moverla o quitarla según sea necesario.
            this.customersTableAdapter1.Fill(this.northwindDataSet1.Customers);

        }

        private void customersBindingSource2BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource2.EndEdit();
            this.tableAdapterManager2.UpdateAll(this.northwindDataSet2);

        }

        private void EjemploConexion_Load_2(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'northwindDataSet2.Customers' Puede moverla o quitarla según sea necesario.
            this.customersTableAdapter2.Fill(this.northwindDataSet2.Customers);

        }

        private void customersBindingSource3BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource3.EndEdit();
            this.tableAdapterManager3.UpdateAll(this.northwindDataSet3);

        }

        private void EjemploConexion_Load_3(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'northwindDataSet3.Customers' Puede moverla o quitarla según sea necesario.
            this.customersTableAdapter3.Fill(this.northwindDataSet3.Customers);

        }
    }
}
