using System.Collections;

namespace RomanCalculator.Domain.Services
{
    public interface IParser
    {
        public ArrayList Parse(string expression);
    }
}
