using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern.CompositeElements
{
    public class WebElement : BaseElement
    {
        public WebElement(string value)
        {
            Value = value;
        }
        public override void Add(BaseElement element)
        {
            throw new NotImplementedException();
        }
        readonly string errorMessage = "Invalid Web Address";

        public override bool IsValid()
        {
            try
            {
                bool isUri = Uri.IsWellFormedUriString(Value, UriKind.RelativeOrAbsolute);
                if(isUri && !string.IsNullOrEmpty(Value))
                {
                    Message = "";
                    return true;
                }
                else
                {
                    Message = errorMessage;
                    return false;
                }
            }
            catch (FormatException)
            {
                Message = errorMessage;
                return false;
            }
        }

        public override void Remove(BaseElement elemnt)
        {
            throw new NotImplementedException();
        }
    }
}
