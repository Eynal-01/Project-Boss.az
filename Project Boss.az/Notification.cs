using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Boss_az
{
    public class Notification
    {
        public int Count { get; set; } = 0;
        public string Message { get; set; }
        public void Show()
        {
            Console.WriteLine(Message);
        }
    }
}