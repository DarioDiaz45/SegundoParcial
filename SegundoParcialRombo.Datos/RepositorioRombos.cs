using SegundoParcialRombo.Entidades;

namespace SegundoParcialRombo.Datos
{
    public class RepositorioRombos
    {
        private List<Rombos> rombos;
        private string? nombreArchivo = "Rombo.txt";
        private string? rutaProyecto = Environment.CurrentDirectory;
        private string? rutaCompletaArchivo;
        public void AgregarRombo(Rombos rombo)
        {
            rombos!.Add(rombo);
        }
        public void EliminarRombo(Rombos rombo)
        {
            rombos!.Remove(rombo);
        }
        public bool Existe( Rombos rombo)
        {
            return rombos.Any(e => e.DiagonalMayor == rombo.DiagonalMenor &&
                e.DiagonalMayor == rombo.DiagonalMayor);
        }
        public List<Rombos>? Filtrar(Contorno ContornoSeleccionado)
        {
            return rombos.Where(e => e.TipoContorno == ContornoSeleccionado).ToList();
        }
        public int GetCantidad(Contorno? ContornoSeleccionado = null)
        {
            if (ContornoSeleccionado == null)
                return rombos.Count;
            return rombos.Count(e => e.TipoContorno == ContornoSeleccionado);
        }
        public List<Rombos> ObtenerRombo()
        {
            return new List<Rombos>(rombos);
        }
        public List<Rombos>? OrdenarAsc()
        {
            return rombos.OrderBy(e => e.CalcularArea()).ToList();
        }
        public List<Rombos>? OrdenarDesc()
        {
            return rombos.OrderByDescending(e => e.CalcularArea()).ToList();
        }
        
        public void GuardarDatos()
        {
            rutaCompletaArchivo = Path.Combine(rutaProyecto, nombreArchivo);
            using (var escritor = new StreamWriter(rutaCompletaArchivo))
            {
                foreach (var rombo in rombos)
                {
                    string linea = ConstruirLinea(rombo);
                    escritor.WriteLine(linea);
                }
            }
        }

        private string ConstruirLinea(Rombos rombo)
        {
            return $"{rombo.DiagonalMayor}|{rombo.DiagonalMenor}|{rombo.TipoContorno.GetHashCode()}";
        }
        private List<Rombos> LeerDatos()
        {
            var listaRombos = new List<Rombos>();
            rutaCompletaArchivo = Path.Combine(rutaProyecto, nombreArchivo);
            if (!File.Exists(rutaCompletaArchivo))
            {
                return listaRombos;
            }
            using (var lector = new StreamReader(rutaCompletaArchivo))
            {
                while (!lector.EndOfStream)
                {
                    string? linea = lector.ReadLine();
                    Rombos? rombo = ConstruirRombo(linea);
                    listaRombos.Add(rombo!);
                }
            }
            return listaRombos;

        }

        private Rombos? ConstruirRombo(string? linea)
        {
            var campos = linea!.Split('|');
            var dM = int.Parse(campos[0]);
            var dm = int.Parse(campos[1]);
            var tipoContorno = (Contorno)int.Parse(campos[2]);
            var color = (TipoColores)int.Parse(campos[3]);
            return new Rombos(dM, dm, tipoContorno );
        }

        public bool Existe(int dM, int dm)
        {
            return rombos.Any(e => e.DiagonalMayor == dM &&
            e.DiagonalMenor == dm);
        }

        public List<Rombos> ObtenerContornos()
        {
            return new List<Rombos>(rombos);
        }

        
    }
}
