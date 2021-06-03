namespace Week3.Calciatori.Classi
{
    public abstract class CalciatoreBase
    {
        public abstract Ruolo Ruolo { get; }

        public virtual int NumeroMaglia { get; set; }
    }
}