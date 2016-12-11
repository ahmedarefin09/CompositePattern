using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CompositePattern.CompositeElements
{
    public class ContactNumberElement : BaseElement
    {
        public ContactNumberElement(string value)
        {
            Value = value;
        }
        public override void Add(BaseElement element)
        {
            throw new NotImplementedException();
        }

        public override bool IsValid()
        {
            var regexItem = new Regex(@"^\d+$");
            if (!string.IsNullOrEmpty(Value) && Value.Length == 11 && regexItem.IsMatch(Value))
            {
                Message = string.Empty;
                return true;
            }
            else
            {
                Message = "Contact number must be a 11 digit number";
                return false;
            }
        }

        public override void Remove(BaseElement elemnt)
        {
            throw new NotImplementedException();
        }
    }
}
