namespace ETL.Intepreter.Model.Parse.Operations
{
    public class BinaryOperation : IElement
    {
        public enum Type
        {
            Addition,
            Substraction
        }

        public Type MyType;
        public IElement Left, Right;

        public int Value
        {
            get
            {
                return MyType switch
                {
                    Type.Addition => Left.Value + Right.Value,
                    Type.Substraction => Left.Value - Right.Value,
                    _ => throw new NotImplementedException()
                };
            }
        }
    }
}
