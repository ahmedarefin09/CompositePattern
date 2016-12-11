using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern.CompositeElements
{
    public abstract class BaseElement
    {
        protected string Value { get; set; }
        public abstract void Add(BaseElement element);
        public abstract void Remove(BaseElement elemnt);
        public abstract bool IsValid();

        public string Message { get; set; }
    }
}
