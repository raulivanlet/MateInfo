using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        string equation = Console.ReadLine();

        equation = "( " + equation + " )";
        string[] tokens = equation.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        List<string> rpn = RPN(tokens);

        foreach (var item in rpn)
        {
            Console.Write($"{item} ");
        }
        Console.WriteLine("\n" + $"Valoarea expresiei este {EvaluateRPN(rpn)}");
    }

    private static int EvaluateRPN(List<string> rpn)
    {
        Stack<int> stack = new Stack<int>();

        foreach (var item in rpn)
        {
            if (IsOperator(item))
            {
                int op1, op2;
                op2 = stack.Pop();
                op1 = stack.Pop();
                stack.Push(Operate(op1, op2, item));
            }
            else
            {
                stack.Push(int.Parse(item));
            }
        }

        return stack.Pop();
    }

    private static bool IsOperator(string item)
    {
        switch (item)
        {
            case "+":
            case "-":
            case "*":
            case "/":
            case "%":
                return true;
            default:
                return false;
        }
    }

    private static int Operate(int op1, int op2, string item)
    {
        int retValue;
        switch (item)
        {
            case "+":
                retValue = op1 + op2;
                break;
            case "-":
                retValue = op1 - op2;
                break;
            case "*":
                retValue = op1 * op2;
                break;
            case "/":
                retValue = op1 / op2;
                break;
            case "%":
                retValue = op1 + op2;
                break;
            default:
                retValue = 0;
                break;
        }
        return retValue;
    }

    private static List<string> RPN(string[] tokens)
    {
        Stack<string> stack = new Stack<string>();
        List<string> rpn = new List<string>();

        foreach (var token in tokens)
        {
            if (token == "(")
            {
                stack.Push(token);
            }
            else if (IsOperator(token))
            {
                string op;
                while (stack.Peek() != "(" && Priority(stack.Peek()) >= Priority(token))
                {
                    op = stack.Pop();
                    rpn.Add(op);
                }
                stack.Push(token);
            }
            else if (token == ")")
            {
                string op;
                op = stack.Pop();
                while (op != "(")
                {
                    rpn.Add(op);
                    op = stack.Pop();
                }
            }
            else
            {
                rpn.Add(token);
            }
        }
        return rpn;
    }

    private static int Priority(string op)
    {
        int retValue;
        switch (op)
        {
            case "+":
            case "-":
                retValue = 1;
                break;
            case "*":
            case "/":
            case "%":
                retValue = 2;
                break;
            default:
                retValue = 0;
                break;
        }
        return retValue;
    }
}