using System.Collections;

namespace RomanCalculator.Domain.Services
{

    public class Parser : IParser
    {
        public ArrayList Parse(string expression)
        {
            var array = new ArrayList();
            var splitedExp = expression.Split(" ");

            foreach (var el in splitedExp)
            {
                if (el.Contains('(')) array.Add("(");
                var number = new RomanNumber(el).ToNumber();

                if (number == 0)
                {
                    array.Add(el);
                }
                else
                {
                    array.Add(number);
                }

                if (el.Contains(')')) array.Add(')');
            }

            return array;
        }
    }
}
