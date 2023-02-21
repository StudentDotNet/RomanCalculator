using RomanCalculator.Domain.Services;
using RomanCalculator.Exceptions;
using System;

namespace RomanCalculator
{
    public class CalculatorClient : ICalculatorClient
    {
        private readonly IParser _parser;
        private readonly ISolver _solver;

        public CalculatorClient()
        {
            _parser = new Parser();
            _solver = new Solver();
        }

        public string Evaluate(string expression)
        {
            try
            {
                var parsedExp = _parser.Parse(expression);
                var res = _solver.Solve(parsedExp);

                return res.Value;
            }
            catch(Exception ex)
            {
                throw new RomanCalculatorException($"Could't solve this expression. Message {ex.Message}");
            }


        }
    }
}
