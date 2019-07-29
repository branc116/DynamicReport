using System;
using System.Collections.Generic;
using System.Linq;

namespace ReportDynamic.Core
{
    public class Composite<T>
    {
        public T Data { get; set; }
        public List<Composite<T>> Children { get; set; }
        public IEnumerable<T> GetAll()
        {
            if (Children == null)
            {
                if (Data != null)
                    yield return Data;
                yield break;
            }
            foreach(var c in Children)
            {
                foreach(var cc in c.GetAll())
                {
                    yield return cc;
                }
            }

        }
        public IEnumerable<T> GetChildren()
        {
            return Children.Select(i => i.Data);
        }
        public static implicit operator T(Composite<T> input)
        {
            return input.Data;
        }
    }
    public class Table : Composite<Table>
    {
        public 
    }
    public class Column<T>
    {

    }
}
