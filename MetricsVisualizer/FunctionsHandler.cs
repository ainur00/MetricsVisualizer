using System;
using System.Collections.Generic;
using System.Globalization;

namespace MetricsVisualizer
{
    internal class FunctionsHandler
    {
        private static Boolean IsPositiveNumber(String token)
        {
            if (token == "pi" || token == "e")
                return true;
            String doubleCh = ".0123456789";
            foreach (Char ch in token)
                if (!doubleCh.Contains(ch.ToString()))
                    return false;
            return true;
        }
        private static Boolean IsToken(String seq)
        {
            if (seq.Length == 0)
                return true;
            if (IsPositiveNumber(seq))
                return true;
            HashSet<String> tokens = new HashSet<String>();

            tokens.Add("sin");
            tokens.Add("cos");
            tokens.Add("ln");
            tokens.Add("pi");
            tokens.Add("e");
            tokens.Add("(");
            tokens.Add(")");
            tokens.Add("+");
            tokens.Add("-");
            tokens.Add("*");
            tokens.Add("/");
            tokens.Add("^");
            tokens.Add("abs");

            tokens.Add("x1");
            tokens.Add("x2");
            tokens.Add("y1");
            tokens.Add("y2");

            foreach (String token in tokens)
                if (token.Contains(seq) && token.IndexOf(seq) == 0)
                    return true;
            return false;
        }
        private static Boolean IsUnary(List<String> tokens, Int32 i)
        {
            if (i == 0)
                return true;
            if (IsPositiveNumber(tokens[i - 1]) || tokens[i - 1] == ")"
                || tokens[i - 1] == "x1" || tokens[i - 1] == "x2"
                || tokens[i - 1] == "y1" || tokens[i - 1] == "y2")
                return false;
            return true;
        }
        private static Boolean IsFunction(String token)
        {
            return (token == "ln"
                || token == "sin"
                || token == "cos"
                || token == "abs");
        }
        private static Boolean IsOperator(String token)
        {
            return (token == "+"
                || token == "-"
                || token == "*"
                || token == "/"
                || token == "^"
                || token == "~"
                || token == "&");
        }

        private static UInt16 GetPriority(String op)
        {
            if (op == "+" || op == "-")
                return 0;
            if (op == "*" || op == "/")
                return 1;
            if (op == "~" || op == "&")
                return 2;
            if (op == "^")
                return 3;
            return UInt16.MaxValue;
        }
        private static String GetAssociativity(String op)
        {
            if (op == "^" || op == "~" || op == "&")
                return "right";
            return "left";
        }

        private static Double GetValue(String arg)
        {
            if (arg == "pi")
                return Math.PI;
            if (arg == "e")
                return Math.E;
            return Convert.ToDouble(arg, new NumberFormatInfo { NumberDecimalSeparator = "." });
        }

        private static List<String> GetTokenized(String exprStr)
        {
            exprStr += "_";

            for (int i = 0; exprStr[i] != '_'; ++i)
            {
                for (int j = 0; j < exprStr.Length; ++j)
                {
                    if (exprStr[j] == ' ')
                    {
                        exprStr = exprStr.Remove(j, 1);
                        break;
                    }
                }
            }

            List<String> tokens = new List<String>();
            String seq = "";

            for (Int32 i = 0; !((seq.Length == 0) && exprStr[i] == '_'); ++i)
            {
                if (IsToken(seq))
                    seq = seq.Insert(seq.Length, exprStr[i].ToString());
                else
                {
                    seq = seq.Remove(seq.Length - 1);
                    i -= 2;
                    tokens.Add(seq);
                    seq = "";
                }
            }

            for (Int32 i = 0; i < tokens.Count; ++i)
            {
                if (tokens[i] == "-" && IsUnary(tokens, i))
                    tokens[i] = "~";
                if (tokens[i] == "+" && IsUnary(tokens, i))
                    tokens[i] = "&";
            }

            return tokens;
        }
        private static List<String> ConvertInToRpn(List<String> exprIn)
        {
            List<String> exprRpn = new List<String>();
            Stack<String> operators = new Stack<String>();
            foreach (String token in exprIn)
            {
                if (IsPositiveNumber(token) || token == "x1" || token == "x2" || token == "y1" || token == "y2")
                    exprRpn.Add(token);
                if (IsFunction(token))
                    operators.Push(token);
                if (IsOperator(token))
                {
                    while (!(operators.Count == 0)
                        && IsOperator(operators.Peek())
                        && (GetPriority(operators.Peek()) > GetPriority(token)
                            || (GetPriority(operators.Peek()) == GetPriority(token) && GetAssociativity(token) == "left")))
                    {
                        exprRpn.Add(operators.Peek());
                        operators.Pop();
                    }
                    operators.Push(token);
                }
                if (token == "(")
                    operators.Push(token);
                if (token == ")")
                {
                    while (!(operators.Count == 0) && operators.Peek() != "(")
                    {
                        exprRpn.Add(operators.Peek());
                        operators.Pop();
                    }
                    operators.Pop();
                    if (!(operators.Count == 0) && IsFunction(operators.Peek()))
                    {
                        exprRpn.Add(operators.Peek());
                        operators.Pop();
                    }
                }
            }
            while (!(operators.Count == 0))
            {
                exprRpn.Add(operators.Peek());
                operators.Pop();
            }
            return exprRpn;
        }

        // Main
        public static Double GetDistance(List<String> exprRpn, double x1, double y1, double x2, double y2)
        {
            Stack<Double> handler = new Stack<Double>();
            foreach (String token in exprRpn)
            {
                if (token == "x1")
                    handler.Push(x1);
                if (token == "x2")
                    handler.Push(x2);
                if (token == "y1")
                    handler.Push(y1);
                if (token == "y2")
                    handler.Push(y2);
                if (IsPositiveNumber(token) || Double.TryParse(token, NumberStyles.Any, new NumberFormatInfo { NumberDecimalSeparator = "." }, out Double _))
                    handler.Push(GetValue(token));
                if (token == "~" || token == "&" || token == "ln" || token == "sin" || token == "cos" || token == "abs")
                {
                    Double arg0 = handler.Peek();
                    handler.Pop();
                    if (token == "~")
                        handler.Push(-arg0);
                    if (token == "&")
                        handler.Push(+arg0);
                    if (token == "ln")
                        handler.Push(Math.Log(arg0));
                    if (token == "sin")
                        handler.Push(Math.Sin(arg0));
                    if (token == "cos")
                        handler.Push(Math.Cos(arg0));
                    if (token == "abs")
                        handler.Push(Math.Abs(arg0));
                }
                if (token == "+" || token == "-" || token == "*" || token == "/" || token == "^")
                {
                    Double arg1 = handler.Peek();
                    handler.Pop();
                    Double arg0 = handler.Peek();
                    handler.Pop();
                    if (token == "+")
                        handler.Push(arg0 + arg1);
                    if (token == "-")
                        handler.Push(arg0 - arg1);
                    if (token == "*")
                        handler.Push(arg0 * arg1);
                    if (token == "/")
                        handler.Push(arg0 / arg1);
                    if (token == "^")
                        handler.Push(Math.Pow(arg0, arg1));
                }
            }
            return handler.Peek();
        }
        public static List<String> GetDistanceFunction(String distanceFunctionString)
        {
            return ConvertInToRpn(GetTokenized(distanceFunctionString));
        }
    }
}
