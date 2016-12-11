using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern.CompositeElements
{
    public class EmailElement : BaseElement
    {
        public EmailElement(string value)
        {
            Value = value;
        }
        public override void Add(BaseElement element)
        {
            throw new NotImplementedException();
        }

        public override bool IsValid()
        {
            try
            {
                MailAddress m = new MailAddress(Value);
                Message = string.Empty;
                return true;
            }
            catch (Exception)
            {
                Message = "Invalid Email Address";
                return false;
            }
        }

        public override void Remove(BaseElement elemnt)
        {
            throw new NotImplementedException();
        }
    }
}
