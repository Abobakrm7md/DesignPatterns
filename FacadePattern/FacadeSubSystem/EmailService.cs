using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.FacadeSubSystem
{
    public class EmailService
    {
        public void Send()
        {
            Console.WriteLine("Email sent");
        }
    }
}
