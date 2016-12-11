using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CompositePattern.CompositeElements
{
    public class AddressElement : BaseElement
    {
        public AddressElement(string value)
        {
            this.Value = value;
        }

        public override void Add(BaseElement element)
        {
            throw new NotImplementedException();
        }

        public override bool IsValid()
        {
            var regexItem = new Regex("^[a-zA-Z0-9 ]*$");
            if (!string.IsNullOrEmpty(Value) && Value.Length >= 10 && regexItem.IsMatch(Value))
            {
                Message = string.Empty;
                return true;
            }
            else
            {
                Message = "Max Length of address field 10 and no special chars allowed";
                return false;
            }
        }

        public override void Remove(BaseElement elemnt)
        {
            throw new NotImplementedException();
        }
    }
}
