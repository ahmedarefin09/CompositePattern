using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern.CompositeElements
{
    public class CompositeElement : BaseElement
    {
        public List<BaseElement> _elementList = new List<BaseElement>();
        public override void Add(BaseElement element)
        {
            _elementList.Add(element);
        }

        public override bool IsValid()
        {
            bool isValid = true;

            foreach(BaseElement element in _elementList)
            {
                isValid = element.IsValid() && isValid;
                Message = string.Concat(Message, element.Message, Environment.NewLine);
            }
            return isValid;
        }

        public override void Remove(BaseElement elemnt)
        {
            if(_elementList.Contains(elemnt))
                _elementList.Remove(elemnt);
        }
    }
}
