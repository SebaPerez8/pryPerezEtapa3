using pryPerezEtapa2;
using System.Windows.Forms;

namespace pryPerezEtapa3
{
    public partial class frmEtapa3 : Form
    {

        clsVehiculo objVehiculo;

        public frmEtapa3()
        {
            InitializeComponent();
        }

        private void btnAuto_Click(object sender, EventArgs e)
        {
            objVehiculo = new clsVehiculo();

            objVehiculo.crearVehiculo(picImagen, Properties.Resources.auto);

            objVehiculo.nombre = "Cybertruck";
            txtNombre.Text = objVehiculo.nombre;

            objVehiculo.tipo = "auto";
            txtTipo.Text = objVehiculo.tipo;

        }

        private void btnAvion_Click(object sender, EventArgs e)
        {
            objVehiculo = new clsVehiculo();

            objVehiculo.crearVehiculo(picImagen, Properties.Resources.avion);

            objVehiculo.nombre = "Boeing-797";
            txtNombre.Text = objVehiculo.nombre;

            objVehiculo.tipo = "avion";
            txtTipo.Text = objVehiculo.tipo;

        }

        private void btnBarco_Click(object sender, EventArgs e)
        {
            objVehiculo = new clsVehiculo();

            objVehiculo.crearVehiculo(picImagen, Properties.Resources.barco);

            objVehiculo.nombre = "Barco pirata";
            txtNombre.Text = objVehiculo.nombre;

            objVehiculo.tipo = "barco";
            txtTipo.Text = objVehiculo.tipo;
        }
    }
}
