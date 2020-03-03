using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// import  SqlClient Data Database
using System.Data.SqlClient;

namespace pjConexion2
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }


        //Methods

        public void ListarClientes()
        {
            using (SqlDataAdapter SQLDTAPTR_adapter = new SqlDataAdapter("Select * from Clientes", SQLCON_connection))
            {
                using (DataSet DTASET_dataset = new DataSet())
                {
                    SQLDTAPTR_adapter.Fill(DTASET_dataset.Tables["Clientes"]);
                    lblTotal.Text = DTASET_dataset.Tables["Clientes"].Rows.Count.ToString();
                }
            }
        }
      
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            ListarClientes();
        }

        //Conection BD
        SqlConnection SQLCON_connection = new SqlConnection("Data Source=(local);Initial Catalog=Neptuno;Integrated Security=True");


    }
}
