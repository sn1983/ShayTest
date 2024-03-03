using System.Linq.Expressions;

public class T3
{
    public string Expression { get; set; }
    public T3(string _Expression)
    {
        Expression = _Expression;
    }

    public bool Validate()
    {
        Stack<char> stackParentheses = new Stack<char>();
        Stack<char> stackBars = new Stack<char>();

        foreach (char c in Expression)
        {
            if (c == '(' || c == '[' || c == '{')
            {
                stackParentheses.Push(c);
            }
            else if (c == ')' || c == ']' || c == '}')
            {
                if (stackParentheses.Count == 0)
                    return false;

                char top = stackParentheses.Pop();
                if (!IsMatching(top, c))
                    return false;
            }
            else if (c == '|')
            {
                stackBars.Push(c);
            }
        }

        if (stackParentheses.Count != 0 || stackBars.Count % 2 != 0)
            return false;

        return true;
    }
    private static bool IsMatching(char open, char close)
    {
        return (open == '(' && close == ')') ||
               (open == '[' && close == ']') ||
               (open == '{' && close == '}');
    }
}