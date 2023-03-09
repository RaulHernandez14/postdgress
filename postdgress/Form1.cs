using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace postdgress
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Bitmap img = new Bitmap(Application.StartupPath + @"\img\ima2.jpg");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }
        ConexionPostgresql conectandose = new ConexionPostgresql();
        private void btn_Conectar_Click(object sender, EventArgs e)
        {

            conectandose.Conectar();
        }

        private void btn_Desconectar_Click(object sender, EventArgs e)
        {
            conectandose.Desconectar();
        }

        private void btn_Consulta_Click(object sender, EventArgs e)
        {

            dgv_Consulta.DataSource = conectandose.Consultar(txt_Consulta.Text);
            //Limpiar Nombre
            txt_Consulta.Text = "";
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            conectandose.Insertar(
                Convert.ToInt32(txt_Id.Text),
                txt_Nombre.Text,
                txt_Pais.Text,
                Convert.ToInt32(txt_Edad.Text));

            //Actualiza el Datagridview
            dgv_Consulta.DataSource = conectandose.Consultar();

            //Limpiar los textbox
            txt_Id.Text = "";
            txt_Nombre.Text = "";
            txt_Pais.Text = "";
            txt_Edad.Text = "";
        }

        private void btn_Mostrar_Click(object sender, EventArgs e)
        {
            dgv_Consulta.DataSource = conectandose.Consultar();
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Se envian los datos por parametro
            conectandose.Eliminar(txt_Eliminar.Text);

            //Actualiza el Datagridview
            dgv_Consulta.DataSource = conectandose.Consultar();

            //Limpiar los textbox
            txt_Eliminar.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conectandose.Actualizar(
                Convert.ToInt32(txt_Id.Text),
                txt_Nombre.Text,
                txt_Pais.Text,
                Convert.ToInt32(txt_Edad.Text),
                txt_Actualizar.Text);

            //Actualiza el Datagridview
            dgv_Consulta.DataSource = conectandose.Consultar();
            //Limpiar los textbox
            txt_Id.Text = "";
            txt_Nombre.Text = "";
            txt_Pais.Text = "";
            txt_Edad.Text = "";
            txt_Actualizar.Text = "";
        }
    }
}
