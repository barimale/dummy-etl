namespace ETL.Intepreter.Model.Parse
{
    public class Double : IElement
    {
        public double Value { get; private set; }
        public Double(double value)
        {
            Value = value;
        }
    }
}