using System;
using Newtonsoft.Json;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading;
using Project_Boss_az;
namespace Project_Boss_az
{
    //public class WorkerNotification
    //{
    //    public int WorkerNotificationCount { get; set; }
    //    public string Content { get; set; }
    //    public Worker Workers { get; set; }
    //    public WorkerNotification(string content)
    //    {
    //        Content = content;
    //    }
    //    public void ShowNotification()
    //    {
    //        if (WorkerNotificationCount >= 0)
    //        {
    //            for (int i = 0; i < WorkerNotificationCount; i++)
    //            {
    //                Console.WriteLine(Content);
    //            }
    //            WorkerNotificationCount--;
    //        }
    //        else
    //        {
    //            Console.WriteLine("\t\t\t\t\t\t\tYou have not any notification");
    //        }
    //    }
    //}
    //public class EmployerNotification
    //{
    //    public int EmployerNotificationCount { get; set; }
    //    public string Content { get; set; }
    //    public Employer Employers { get; set; }
    //    public EmployerNotification(string content)
    //    {
    //        Content = content;
    //    }
    //    public void ShowNotification()
    //    {

    //        if (EmployerNotificationCount >= 0)
    //        {

    //            for (int i = 0; i < EmployerNotificationCount; i++)
    //            {
    //                Console.WriteLine(Content);
    //            }
    //            EmployerNotificationCount--;
    //        }
    //        else
    //        {
    //            Console.WriteLine("\t\t\t\t\t\t\tYou have not any notification");
    //        }
    //    }
    //}
    public class Program
    {
        static void Main(string[] args)
        {
            Controller.Start();
        }
    }
}