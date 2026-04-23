using ETL.Intepreter;
using ETL.Intepreter.Model.Parse;

namespace ETL.Interpreter.UTs
{
    public class Execute
    {
        [Fact]
        public void ExampleOfUsage()
        {
            // given
            var input = "(13+4)-(5+6)";

            // when
            var tokens = LexService.Lex(input);
            var ast = ParseService.Parse(tokens);
            var result = ast.Value;

            // then
            Assert.Equal(6, result);
        }
    }
}
