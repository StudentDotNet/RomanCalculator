using System.Collections;

namespace RomanCalculator.Domain.Services
{
    public interface ISolver
    {
        public RomanNumber Solve(ArrayList collection);
    }
}
