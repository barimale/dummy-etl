namespace ETL.Intepreter.Model.Lex
{
    public class Token
    {
        public Token.Type MyType;
        public string Text;

        public enum Type
        {
            Integer, Plus, Minus, LParen, RParen
        }

        public Token(Token.Type type, string text)
        {
            MyType = type;
            Text = text;
        }

        public override string ToString()
        {
            return $"`{Text}`";
        }
    }
}
