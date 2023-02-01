using Project_Boss_az;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Boss_az
{
    public class Worker : Human
    {
        public CV Cv { get; set; } = null;
        public int CvCount { get; set; }
        public Notification Notification { get; set; } = new Notification();
        public int NotificationCount { get; set; }
        public static int ID { get; set; } = 0;
        public int id { get; set; }
        public string NotificationMessage { get; set; }
        public List<Employer> Applicant { get; set; } = new List<Employer>();
        public List<VACANCY> ApplicantVacancy { get; set; } = new List<VACANCY>();
        public Worker()
        {
            id = ++ID;
        }
        public Worker(string name, string surname, string city, int age, string username, string password)
            : base(name, surname, city, age, username, password)
        {

        }
        public void ShowWorker()
        {
            base.ShowHuman();
            Console.WriteLine($"\t\t\t\t\t\t\tID : {id}");
        }
        public void ShowCVWorker()
        {
            Console.WriteLine(Cv);
            Console.ReadKey();
        }
        public void AddCV(CV cv)
        {
            this.Cv = cv;
        }
    }
}
