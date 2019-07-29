using System;
using System.Collections.Generic;
using System.Text;

namespace ReportDynamic.Core
{
    public enum Operators
    {
        LessThen = 'l',
        LessOrEqualThen = 'L',
        GreaterThen = 'g',
        GreaterOrEqualThen = 'G',
        Equal = 'e',
        NotEqual = 'E',
        In = 'i',
        NotIn = 'I',

    }
    public class Operators<T, G>
    {
        public Func<T, T, char, bool> Implementaion { get; set; }
    }
    public static class Operations
    {
        public static List<Operators<object, object>> AllOperations;
        public static Operators<IComparable, IComparable> IntInt = new Operators<IComparable, IComparable>
        {
            Implementaion = (a, b, str) =>
            {
                var o = (Operators)str;
                switch (o)
                {
                    case Operators.LessThen:
                        return a.CompareTo(b) > 0;
                    case Operators.LessOrEqualThen:
                        return a.CompareTo(b) >= 0;
                    case Operators.GreaterThen:
                        return a.CompareTo(b) < 0;
                    case Operators.GreaterOrEqualThen:
                        return a.CompareTo(b) <= 0;
                    case Operators.Equal:
                        return a.CompareTo(b) == 0;
                    case Operators.NotEqual:
                        return a.CompareTo(b) == 0;
                    case Operators.In:
                    case Operators.NotIn:
                        return false;
                    default:
                        return false;
                }
            }
        };
    }
}
