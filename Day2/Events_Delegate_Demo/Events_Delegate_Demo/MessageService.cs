using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_Delegate_Demo
{
    internal class MessageService
    {
       
            public void OnVideoEncoded(object source, EventArgs args)   // event 
            {

                Console.WriteLine("MessageService : Sending a text Messages..... ");

            }

        }

    }

