using System;
namespace ООП_ПР3
{
    public interface ITextStrategy
    {
        string Execute(string input);
    }

    public class UpperCaseStrategy : ITextStrategy
    {
        public string Execute(string input) => input.ToUpper();
    }

    public class LowerCaseStrategy : ITextStrategy
    {
        public string Execute(string input) => input.ToLower();
    }
    public class StarStrategy : ITextStrategy
    {
        public string Execute(string input) => string.Join("*", input.ToCharArray());
    }
    public class TextContext
    {
        private ITextStrategy _strategy;

        public void SetStrategy(ITextStrategy strategy)
        {
            _strategy = strategy;
        }
        public string ExecuteStrategy(string input)
        {
            if (_strategy == null) return input;
            return _strategy.Execute(input);
        }
    }
}