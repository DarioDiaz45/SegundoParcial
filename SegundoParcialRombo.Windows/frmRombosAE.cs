using SegundoParcialRombo.Entidades;
using SegundoParcialRombo.Datos;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using System.Windows.Forms;

namespace SegundoParcialRombo.Windows
{
    public partial class frmRombosAE : Form
    {
        private Rombos? rombos;
        private readonly RepositorioRombos? _repo;
        public frmRombosAE(RepositorioRombos? repo)
        {
            InitializeComponent();
            _repo = repo;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            CargarDatosCombo(ref cboColores);
            if (rombos != null)
            {
                txtDMayor.Text = rombos.DiagonalMayor.ToString();
                txtDMenor.Text = rombos.DiagonalMenor.ToString();
                switch (rombos.TipoContorno)
                {
                    case Contorno.Solido:
                        rbtSolido.Checked = true;
                        break;
                    case Contorno.Punteado:
                        rbtPunteado.Checked = true;
                        break;
                    case Contorno.Rayado:
                        rbtRayado.Checked = true;
                        break;
                    case Contorno.Doble:
                        rbtDoble.Checked = true;
                        break;
                }
                cboColores.SelectedItem = rombos.Color;
            }
        }

        private void CargarDatosCombo(ref ComboBox cbo)
        {
            cbo.DataSource = Enum.GetValues(typeof(TipoColores));
            cbo.SelectedIndex = 0;
        }

        public Rombos? GetRombo()
        {
            return rombos;
        }
        public void SetRombo(Rombos rombo)
        {
            this.rombos = rombo;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (rombos is null)
                {
                    rombos = new Rombos();
                }
                rombos.DiagonalMayor = int.Parse(txtDMayor.Text);
                rombos.DiagonalMenor = int.Parse(txtDMenor.Text);
               rombos.Color = (TipoColores)cboColores.SelectedItem!;
                if (rbtSolido.Checked)
                    rombos.TipoContorno = Contorno.Solido;
                else if (rbtPunteado.Checked)
                    rombos.TipoContorno = Contorno.Punteado;
                else if (rbtRayado.Checked)
                    rombos.TipoContorno = Contorno.Rayado;
                else
                    rombos.TipoContorno = Contorno.Doble;
                DialogResult = DialogResult.OK;
            }
            
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (!int.TryParse(txtDMayor.Text, out int dM) ||
                dM <= 0)
            {
                valido = false;
                errorProvider1.SetError(txtDMenor, "Diagonal Mayor mal ingresado");
            }
            if (!int.TryParse(txtDMenor.Text, out int dm) ||
              dm <= 0 || dm >= dM)
            {
                valido = false;
                errorProvider1.SetError(txtDMenor, "Semieje Menor mal ingresado");
            }
            if (_repo!.Existe(dM, dm))
            {
                valido = false;
                errorProvider1.SetError(txtDMayor, "Elipse existente!!!");
            }
            return valido;
        }
    }
    
}
