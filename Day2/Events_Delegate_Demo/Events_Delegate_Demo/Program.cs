using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_Delegate_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var video = new Video() { Title = "Video 1" };
            var videoEncoder = new VideoEncoder(); //publisher
            var mailservice = new MailService(); //subscriber 
            var messageservice = new MessageService(); // new subscriber 



            videoEncoder.VideoEncoded += mailservice.OnVideoEncoded; // ref or pointer to the menthod 
            videoEncoder.VideoEncoded += messageservice.OnVideoEncoded;  // ref or pointer to the menthod 


            videoEncoder.Encode(video);
            Console.ReadKey();
        }



    }

    


}
