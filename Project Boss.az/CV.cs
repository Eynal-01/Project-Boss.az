using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Boss_az
{
    public class CV
    {
        public string Speciality { get; set; }
        public string School { get; set; }
        public double AcceptanceScore { get; set; }
        public List<string> Skills { get; set; } = new List<string>();
        public List<string> Companies { get; set; } = new List<string>();
        public string StartWorkTime { get; set; }
        public string EndWorkTime { get; set; }
        public List<string> Languages { get; set; } = new List<string>();
        public string GitLink { get; set; }
        public string LinkedLink { get; set; }
        public int SkillsCount { get; set; }
        public CV()
        {
        }
        public CV(string speciality, string school, double acceptanceScore, List<string> companies, string startworkTime, string endworkTime, List<string> languages, string gitLink, string linkedLink)
        {
            Speciality = speciality;
            School = school;
            AcceptanceScore = acceptanceScore;
            Companies = companies;
            StartWorkTime = startworkTime;
            EndWorkTime = endworkTime;
            Languages = languages;
            GitLink = gitLink;
            LinkedLink = linkedLink;
        }
        public override string ToString()
        {
            Console.Write("\t\t\t\t\t\t\tWorking companies : ");
            Companies.ForEach(c => Console.WriteLine(c));
            Console.Write("\t\t\t\t\t\t\tLanguage skills : ");
            Languages.ForEach(l => Console.WriteLine(l));
            Console.Write("\t\t\t\t\t\t\tSkills : ");
            Skills.ForEach(s => Console.WriteLine(s));
            return $"\t\t\t\t\t\t\tYour spaciality : {Speciality}\n\t\t\t\t\t\t\tYour school : {School}\n\t\t\t\t\t\t\tYour acceptance score : {AcceptanceScore}\n" +
                $"\t\t\t\t\t\t\tYour start working time : {StartWorkTime}" +
                $"\n\t\t\t\t\t\t\tYour end of working time : {EndWorkTime}";
        }
        public void ShowCV()
        {
            Console.Write($"\t\t\t\t\t\t\tYour spaciality : {Speciality}");
            Console.Write($"\t\t\t\t\t\t\tYour school : {School}");
            Console.Write($"\t\t\t\t\t\t\tYour acceptance score : {AcceptanceScore}");
            foreach (var skill in Skills)
            {
                Console.WriteLine($"Your skill : {skill}");
            }
            Console.Write($"\t\t\t\t\t\t\tYour working companies : {Companies}");
            Console.Write($"\t\t\t\t\t\t\tYour start working time : {StartWorkTime}");
            Console.Write($"\t\t\t\t\t\t\tYour end of working time : {EndWorkTime}");
            Console.WriteLine($"\t\t\t\t\t\t\tYour languages skills : {Languages}");
        }
        public void AddSkill(string newskill)
        {
            Skills.Add(newskill);
        }
    }
}
