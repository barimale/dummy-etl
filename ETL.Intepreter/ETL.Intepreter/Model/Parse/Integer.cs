namespace ETL.Intepreter.Model.Parse
{
    public class Integer : IElement
    {
        public int Value { get; private set; }
        public Integer(int value)
        {
            Value = value;
        }
    }
}