using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Events_Delegate_Demo
{

    internal class VideoEncoder
    {
        // 1 : Define a delegate 
        // 2 : Define an event based on that delegate
        // 3 : Raise the Event 

        public delegate void VideoEncodedEventHandler(object source , EventArgs args );  //event Name is VideoEncoder  // 1. we define a delegate of the EventHandler 
        public event VideoEncodedEventHandler VideoEncoded; //  2. we define the event on the bases of delegate 


        public void Encode(Video video)
        {
            Console.WriteLine("Encoding the Video.... ");
            Thread.Sleep(3000);
            OnVideoEncoded(); // after Encode Method this OnvideoEncoded method will notify all suscriber 

            Console.WriteLine("press Any key to Continue !");

        }

        //Rasie the event 
         
        protected virtual void OnVideoEncoded() { 
        
        if(VideoEncoded != null) 
                VideoEncoded(this, EventArgs.Empty);    
        }
        
           
    }
}


// with events you can create a publisher and you can add suscriber without changing the publisher in our case videoEncoder is the Publisher and 
//Mailservice and MessageService is the Suscriber which is using  publisher event to notify the videoEncoded method after that
//that event will notify  the respective class method after vedioEncoded Method exicutes 
