using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_Delegate_Demo
{
    internal class MailService
  
    {
        public void OnVideoEncoded(object source, EventArgs e)
        {
            Console.WriteLine("MailService : Sending  an email.....");
        }

    }



}
