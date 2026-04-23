using ETL.Intepreter.Model.Lex;
using System.Text;

namespace ETL.Intepreter
{
    public class LexService
    {
        public static List<Token> Lex(string input)
        {
            var result = new List<Token>();
            for(int i = 0; i < input.Length; i++)
            {
                switch (input[i])
                {
                    case '+':
                        result.Add(new Token (Token.Type.Plus, "+"));
                        break;
                    case '-':
                        result.Add(new Token (Token.Type.Minus, "-"));
                        break;
                    case '(':
                        result.Add(new Token (Token.Type.LParen, "("));
                        break;
                    case ')':
                        result.Add(new Token (Token.Type.RParen, ")"));
                        break;
                    default:
                        if (char.IsDigit(input[i]))
                        {
                            var sb = new StringBuilder();
                            while (i < input.Length && char.IsDigit(input[i]))
                            {
                                sb.Append(input[i]);
                                i++;
                            }
                            result.Add(new Token(Token.Type.Integer, sb.ToString()));
                            i--;
                        }
                        break;
                }
            }

            return result;
        }
    }
}
