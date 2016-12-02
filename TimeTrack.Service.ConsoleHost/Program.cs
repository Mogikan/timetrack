using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using TimeTrack.BusinessLogic;

namespace TimeTrack.Service.ConsoleHost
{
    class Program
    {
        static void Main(string[] args)
        {
            var timeTrackHost = new ServiceHost(typeof(TimeTrackService));
            timeTrackHost.Open();
            Console.WriteLine("serviceStarted");
            Console.ReadKey();
            timeTrackHost.Close();
        }
    }
}
