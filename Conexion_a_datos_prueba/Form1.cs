using Capa_modelo_de_negocio;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Conexion_a_datos_prueba
{
    public partial class Form1 : Form
    {
        Negocios personaBLL = new Negocios();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txt_nombre.Text;
                string apellido = txt_apellido.Text;
                personaBLL.AgregarPersona(nombre, apellido);
                MessageBox.Show("Persona agregada correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
