using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Boss_az
{
    public class VACANCY
    {
        public int Id { get; set; }
        public static int ID { get; set; } = 1;
        public string Speciality { get; set; }
        public double Salary { get; set; }
        public int PractiseYear { get; set; }
        public VACANCY()
        {
            Id = ID++;
        }
        public VACANCY(string speciality, double salary, int practiseYear)
        {
            Speciality = speciality;
            Salary = salary;
            PractiseYear = practiseYear;
        }

        public override string ToString()
        {
            return $"\t\t\t\t\t\t\tID : {Id}\n\t\t\t\t\t\t\tSpeciality : {Speciality}\n\t\t\t\t\t\t\tPractise year : {PractiseYear}\n\t\t\t\t\t\t\tSalary : {Salary}\n\n";
        }
        public void ShowVacancy()
        {
            ToString();
        }
    }

}
