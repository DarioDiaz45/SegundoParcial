namespace SegundoParcialRombo.Entidades
{
    public class Rombos
    {
        private int dM;
        private int dm;

        public Rombos()
        {
        }

        public Rombos(int dM, int dm, Contorno tipoContorno)
        {
            this.dM = dM;
            this.dm = dm;
            TipoContorno = tipoContorno;
        }

        public int DiagonalMayor {  get; set; } 
        public int DiagonalMenor {  get; set; }
        public Contorno TipoContorno {  get; set; }
        public TipoColores Color {  get; set; }

        public double Lado
        {
            get
            {
                
                return Math.Sqrt(Math.Pow(DiagonalMayor / 2.0, 2) + Math.Pow(DiagonalMenor / 2.0, 2));
            }
        }

        public double CalcularArea()
        {
           
            return (DiagonalMayor * DiagonalMenor) / 2.0;
        }

        public double CalcularPerimetro()
        {
            
            return 4 * Lado;
        }
    }
}

