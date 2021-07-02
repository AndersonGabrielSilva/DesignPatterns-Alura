namespace DesignPatterns._10_Memento
{
    public class Estado
    {
        public Contrato Contrato { get; private set; }

        public Estado(Contrato contrato)
        {
            Contrato = contrato;
        }
    }
}
