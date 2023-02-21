using System;
using System.Collections;
using System.Data;
using System.Text;

namespace RomanCalculator.Domain.Services
{
    public class Solver : ISolver
    {
        public RomanNumber Solve(ArrayList collection)
        {
            var table = new DataTable();
            var builder = new StringBuilder();
            foreach (var item in collection)
            {
                builder.Append(item.ToString());
            }

            var result = table.Compute(builder.ToString(), "");
            return new RomanNumber((int)result);
        }
    }
}
