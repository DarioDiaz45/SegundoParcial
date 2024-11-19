using SegundoParcialRombo.Datos;
using SegundoParcialRombo.Entidades;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace SegundoParcialRombo.Windows
{
    public partial class frmRombos : Form
    {
        private RepositorioRombos? repositorio;
        private int cantidadRegistros;
        private List<Rombos>? rombos;
        public frmRombos()
        {
            InitializeComponent();
            repositorio = new RepositorioRombos();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            frmRombosAE frm = new frmRombosAE(repositorio) { Text = "Agregar Elipse" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel) return;
            Rombos? rombo = frm.GetRombo();
            try
            {
                if (!repositorio!.Existe(rombo!))
                {
                    repositorio.AgregarRombo(rombo!);
                    DataGridViewRow r = ConstruirFila(dgvDatos);
                    SetearFila(r, rombo!);
                    AgregarFila(r, dgvDatos);
                    MessageBox.Show("Registro agregado", "Mensaje",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {

                    MessageBox.Show("Registro existente!!!", "Error",
        MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception)
            {

                MessageBox.Show("Algún error!!!", "Error",
    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void AgregarFila(DataGridViewRow r, DataGridView dgv)
        {
            dgv.Rows.Add(r);
        }

        public void LimpiarGrilla(DataGridView grid)
        {
            grid.Rows.Clear();
        }

        private void SetearFila(DataGridViewRow r, Rombos obj)
        {
            r.Cells[0].Value = obj.DiagonalMayor;
            r.Cells[1].Value = obj.DiagonalMenor;
            r.Cells[2].Value = obj.TipoContorno.ToString();
            r.Cells[3].Value = obj.Color.ToString();
            r.Cells[4].Value = obj.CalcularArea().ToString("N2");
            r.Cells[5].Value = obj.CalcularPerimetro().ToString("N2");

            r.Tag = obj;
        }

        private DataGridViewRow ConstruirFila(DataGridView grid)
        {
            var r = new DataGridViewRow();
            r.CreateCells(grid);
            return r;
        }
        private void CargarComboContornos(ref ToolStripComboBox tsCboContornos)
        {
            var listaBordes = Enum.GetValues(typeof(Contorno));
            foreach (var item in listaBordes)
            {
                tsCboContornos.Items.Add(item);
            }
            tsCboContornos.DropDownStyle = ComboBoxStyle.DropDownList;
            tsCboContornos.SelectedIndex = 0;

        }

        private void frmRombos_Load(object sender, EventArgs e)
        {
            CargarComboContornos(ref tsCboContornos);
            cantidadRegistros = repositorio!.GetCantidad();
            if (cantidadRegistros > 0)
            {
                rombos = repositorio.ObtenerContornos();
                MostrarDatosGrilla();
                MostrarCantidadRegistros();
            }
        }

        private void MostrarCantidadRegistros()
        {
            txtCantidad.Text = cantidadRegistros.ToString();
        }

        private void MostrarDatosGrilla()
        {
            LimpiarGrilla(dgvDatos);
            foreach (var item in rombos!)
            {
                var r = ConstruirFila(dgvDatos);
                SetearFila(r, item);
                AgregarFila(r, dgvDatos);
            }
        }

        private void tsbBorrar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0)
            {
                return;
            }
            DataGridViewRow r = dgvDatos.SelectedRows[0];
            Rombos rombos = (Rombos)r.Tag!;
            DialogResult dr = MessageBox.Show("¿Desea borrar la elipse?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.No) { return; }
            try
            {
                repositorio!.EliminarRombo(rombos);
                EliminarFila(r, dgvDatos);
                MessageBox.Show("Registro agregado", "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            catch (Exception)
            {

                MessageBox.Show("Algún error!!!", "Error",
    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void EliminarFila(DataGridViewRow r, DataGridView grid)
        {
            grid.Rows.Remove(r);
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0)
            {
                return;
            }
            DataGridViewRow r = dgvDatos.SelectedRows[0];
            Rombos? rombo = (Rombos)r.Tag!;
            frmRombosAE frm = new frmRombosAE(repositorio) { Text = "Editar Rombo" };
            frm.SetRombo(rombo);
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel) { return; }
            try
            {
                rombo = frm.GetRombo();
                SetearFila(r, rombo);
                MessageBox.Show("Registro editado", "Mensaje",
                 MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception)
            {

                MessageBox.Show("Algún error!!!", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void tsbActualizar_Click(object sender, EventArgs e)
        {
            rombos = repositorio!.ObtenerRombo();
            MostrarDatosGrilla();
        }

        private void tsbSalir_Click(object sender, EventArgs e)
        {
            repositorio!.GuardarDatos();
            MessageBox.Show("Fin del Programa", "Mensaje",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }
    }
}
