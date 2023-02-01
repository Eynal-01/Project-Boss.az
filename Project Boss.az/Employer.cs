using Project_Boss_az;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Project_Boss_az
{
    public class Employer : Human
    {
        public List<VACANCY> Vacancies { get; set; } = new List<VACANCY>();
        public List<string> Emnotification { get; set; } = new List<string>();
        public int Emnotificount { get; set; } = 0;
        public static int IDe { get; set; } = 0;
        public int ide { get; set; }
        public List<Worker> Worker { get; set; } = new List<Worker>();
        public int WorkerCount { get; set; }
        public Notification Notifications { get; set; } = new Notification();
        public List<Worker> Applicant { get; set; } = new List<Worker>();
        public List<VACANCY> ApplicantVacancy { get; set; } = new List<VACANCY>();
        public Employer(string name, string surname, string city, int age, string username, string password)
            : base(name, surname, city, age, username, password)
        {
            Vacancies = new List<VACANCY>();
        }
        public Employer()
        {
            ide = ++IDe;
        }
        public void AddWorker(Worker w)
        {
            Worker.Add(w);
        }
        public void ShowEmployer()
        {
            Console.WriteLine($"\t\t\t\t\t\t\tID : {ide}");
            base.ShowHuman();
        }
        public void ShowVacancyEmployer()
        {
            Vacancies.ForEach(c => Console.WriteLine(c));
        }
        public void AddVacancy(VACANCY vac)
        {
            this.Vacancies.Add(vac);
        }
    }
}
