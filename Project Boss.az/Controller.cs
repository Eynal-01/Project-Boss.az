using Project_Boss_az;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Project_Boss_az
{
    public class Controller
    {
        public static void Name()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t\t\t\t ▄▄▄▄    ▒█████    ██████   ██████     ▄▄▄      ▒███████▒");
            Console.WriteLine("\t\t\t\t▓█████▄ ▒██▒  ██▒▒██    ▒ ▒██    ▒    ▒████▄    ▒ ▒ ▒ ▄▀░");
            Console.WriteLine("\t\t\t\t▒██▒ ▄██▒██░  ██▒░ ▓██▄   ░ ▓██▄      ▒██  ▀█▄  ░ ▒ ▄▀▒░ ");
            Console.WriteLine("\t\t\t\t▒██░█▀  ▒██   ██░  ▒   ██▒  ▒   ██▒   ░██▄▄▄▄██   ▄▀▒   ░");
            Console.WriteLine("\t\t\t\t░▓█  ▀█▓░ ████▓▒░▒██████▒▒▒██████▒▒    ▓█   ▓██▒▒███████▒");
            Console.WriteLine("\t\t\t\t░▒▓███▀▒░ ▒░▒░▒░ ▒ ▒▓▒ ▒ ░▒ ▒▓▒ ▒ ░    ▒▒   ▓▒█░░▒▒ ▓░▒░▒");
            Console.WriteLine("\t\t\t\t▒░▒   ░   ░ ▒ ▒░ ░ ░▒  ░ ░░ ░▒  ░ ░     ▒   ▒▒ ░░░▒ ▒ ░ ▒");
            Console.WriteLine("\t\t\t\t ░    ░ ░ ░ ░ ▒  ░  ░  ░  ░  ░  ░       ░   ▒   ░ ░ ░ ░ ░");
            Console.WriteLine("\t\t\t\t ░          ░ ░        ░        ░           ░  ░  ░ ░    ");
            Console.WriteLine("\t\t\t\t      ░                                         ░        ");
            Console.ResetColor();
        }
        public static void WorkerWord()
        {
            Console.WriteLine("\t\t\t\t██╗    ██╗ ██████╗ ██████╗ ██╗  ██╗███████╗██████╗ ");
            Console.WriteLine("\t\t\t\t██║    ██║██╔═══██╗██╔══██╗██║ ██╔╝██╔════╝██╔══██╗");
            Console.WriteLine("\t\t\t\t██║ █╗ ██║██║   ██║██████╔╝█████╔╝ █████╗  ██████╔╝");
            Console.WriteLine("\t\t\t\t██║███╗██║██║   ██║██╔══██╗██╔═██╗ ██╔══╝  ██╔══██╗");
            Console.WriteLine("\t\t\t\t╚███╔███╔╝╚██████╔╝██║  ██║██║  ██╗███████╗██║  ██║");
            Console.WriteLine("\t\t\t\t ╚══╝╚══╝  ╚═════╝ ╚═╝  ╚═╝╚═╝  ╚═╝╚══════╝╚═╝  ╚═╝");
        }
        public static void EmlpoyerWord()
        {
            Console.WriteLine("\t\t\t\t███████╗███╗   ███╗██████╗ ██╗      ██████╗ ██╗   ██╗███████╗██████╗ ");
            Console.WriteLine("\t\t\t\t██╔════╝████╗ ████║██╔══██╗██║     ██╔═══██╗╚██╗ ██╔╝██╔════╝██╔══██╗");
            Console.WriteLine("\t\t\t\t█████╗  ██╔████╔██║██████╔╝██║     ██║   ██║ ╚████╔╝ █████╗  ██████╔╝");
            Console.WriteLine("\t\t\t\t██╔══╝  ██║╚██╔╝██║██╔═══╝ ██║     ██║   ██║  ╚██╔╝  ██╔══╝  ██╔══██╗");
            Console.WriteLine("\t\t\t\t███████╗██║ ╚═╝ ██║██║     ███████╗╚██████╔╝   ██║   ███████╗██║  ██║");
            Console.WriteLine("\t\t\t\t╚══════╝╚═╝     ╚═╝╚═╝     ╚══════╝ ╚═════╝    ╚═╝   ╚══════╝╚═╝  ╚═╝");
        }
        public static void Worker(Worker worker, List<Employer> employers, Employer employer)
        {
            DateTime starttime = new DateTime(2020, 11, 11);
            DateTime endtime = new DateTime(2022, 11, 11);
            Console.Clear();
            WorkerWord();
            worker.ShowWorker();
            Console.WriteLine("\t\t\t\t\t\t\t[1] Show CV");
            Console.WriteLine("\t\t\t\t\t\t\t[2] Show notification");
            Console.WriteLine("\t\t\t\t\t\t\t[3] Update CV");
            Console.WriteLine("\t\t\t\t\t\t\t[4] Create CV");
            Console.WriteLine("\t\t\t\t\t\t\t[5] Show advertising");
            Console.WriteLine("\t\t\t\t\t\t\t[6] Back to main menu");
            Console.WriteLine("\t\t\t\t\t\t\tEnter select : ");
            int select1 = int.Parse(Console.ReadLine());
            if (select1 == 1)
            {
                worker.ShowCVWorker();
                Worker(worker, employers, employer);
            }
            else if (select1 == 2)
            {
                Console.WriteLine(worker.Notification);
                Worker(worker, employers, employer);
            }
            else if (select1 == 3)
            {
                Console.WriteLine("\t\t\t\t\t\t\t[1] Update speciality");
                Console.WriteLine("\t\t\t\t\t\t\t[2] Update school");
                Console.WriteLine("\t\t\t\t\t\t\t[3] Update acceptance score");
                Console.WriteLine("\t\t\t\t\t\t\t[4] Update skills ");
                Console.WriteLine("\t\t\t\t\t\t\t[5] Update companies ");
                Console.WriteLine("\t\t\t\t\t\t\t[6] Update languages ");
                Console.WriteLine("\t\t\t\t\t\t\t[7] Update GitLink ");
                Console.WriteLine("\t\t\t\t\t\t\t[8] Update LinkedLink");
                int selectupdate = int.Parse(Console.ReadLine());
                if (selectupdate == 1)
                {
                    Console.Write("\t\t\t\t\t\t\tEnter new speciality name : ");
                    string newname = Console.ReadLine();
                    worker.Cv.Speciality = newname;
                }
                else if (selectupdate == 2)
                {
                    Console.Write("\t\t\t\t\t\t\tEnter new school : ");
                    string schoolnum = Console.ReadLine();
                    worker.Cv.School = schoolnum;
                }
                else if (selectupdate == 3)
                {
                    Console.Write("\t\t\t\t\t\t\tEnter new acceptance score : ");
                    double newscore = double.Parse(Console.ReadLine());
                    worker.Cv.AcceptanceScore = newscore;
                }
                else if (selectupdate == 4)
                {
                    Console.Write("\t\t\t\t\t\t\tEnter new skills : ");
                    string skills = Console.ReadLine();
                    worker.Cv.AddSkill(skills);
                }
                else if (selectupdate == 5)
                {
                    Console.Write("\t\t\t\t\t\t\tEnter new companies : ");
                    string companies = Console.ReadLine();
                    List<string> companies1 = new List<string> { };
                    companies1.Add(companies);
                    worker.Cv.Companies = companies1;
                }
                else if (selectupdate == 6)
                {
                    Console.Write("\t\t\t\t\t\t\tEnter new languages : ");
                    string newlanguages = Console.ReadLine();
                    List<string> newlanguages1 = new List<string> { };
                    newlanguages1.Add(newlanguages);
                    worker.Cv.Languages = newlanguages1;
                }
                else if (selectupdate == 7)
                {
                    Console.WriteLine("\t\t\t\t\t\t\tEnter new GitHub link : ");
                    string newgitlink = Console.ReadLine();
                    worker.Cv.GitLink = newgitlink;
                }
                else if (selectupdate == 8)
                {
                    Console.WriteLine("\t\t\t\t\t\t\tEnter new LinkedIn link : ");
                    string newlinkedlink = Console.ReadLine();
                    worker.Cv.LinkedLink = newlinkedlink;
                }
                Worker(worker, employers, employer);
            }
            else if (select1 == 4)
            {
                if (worker.Cv == null)
                {

                    Console.Write("\t\t\t\t\t\t\tEnter speciality : ");
                    string cvspeciality = Console.ReadLine();
                    Console.Write("\t\t\t\t\t\t\tEnter school name : ");
                    string cvschool = Console.ReadLine();
                    Console.Write("\t\t\t\t\t\t\tEnter acceptance score : ");
                    double cvscore = double.Parse(Console.ReadLine());
                    Console.Write("\t\t\t\t\t\t\tEnter skills : ");
                    string cvskills = Console.ReadLine();
                    Console.Write("\t\t\t\t\t\t\tEnter companies : ");
                    string cvcompanies = Console.ReadLine();
                    List<string> cvcompanies1 = new List<string> { };
                    cvcompanies1.Add(cvcompanies);
                    Console.Write("\t\t\t\t\t\t\tEnter start of work time (year, month, day) : ");
                    string starttime1 = Console.ReadLine();
                    Console.Write("\t\t\t\t\t\t\tEnter end of work time (year, month, day): ");
                    string endtime1 = Console.ReadLine();
                    Console.Write("\t\t\t\t\t\t\tEnter languages : ");
                    string cvlanguages = Console.ReadLine();
                    List<string> cvlanguages1 = new List<string> { };
                    cvlanguages1.Add(cvlanguages);
                    Console.Write("\t\t\t\t\t\t\tEnter GitHub link : ");
                    string cvgitlink = Console.ReadLine();
                    Console.Write("\t\t\t\t\t\t\tEnter LinkedIn link : ");
                    string cvlinkedlink = Console.ReadLine();
                    CV newCv = new CV(cvspeciality, cvschool, cvscore, cvcompanies1, starttime1, endtime1, cvlanguages1, cvgitlink, cvlinkedlink);
                    worker.AddCV(newCv);
                    Worker(worker, employers, employer);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\t\t\t\t\t\t\tYou already have your CV");
                    Console.ResetColor();
                    Console.ReadKey();
                }
            }
            else if (select1 == 5)
            {
                while (true)
                {

                    string search = String.Empty;
                    int result;
                    while (true)
                    {
                        var letter = Console.ReadKey();
                        if (letter.Key == ConsoleKey.D1 || letter.Key == ConsoleKey.D2 ||
                            letter.Key == ConsoleKey.D3 || letter.Key == ConsoleKey.D4 ||
                            letter.Key == ConsoleKey.D5 || letter.Key == ConsoleKey.D6 ||
                            letter.Key == ConsoleKey.D7 || letter.Key == ConsoleKey.D8 ||
                            letter.Key == ConsoleKey.D9)
                        {
                            var result1 = letter.Key.ToString();
                            result1 = result1.Replace('D', ' ');
                            result = int.Parse(result1);
                            break;
                        }
                        Console.Clear();
                        search += letter.KeyChar;
                        search = search.ToLower();
                        if (letter.Key == ConsoleKey.Backspace)
                        {
                            search = "";
                        }
                        Console.WriteLine(search);
                        var selectedVacancy = from e in employers
                                              from v in e.Vacancies
                                              where v.Speciality.ToLower().Contains(search)
                                              select v;
                        foreach (var vacancy in selectedVacancy)
                        {
                            Console.WriteLine($"{vacancy.Id} - {vacancy.Speciality}");
                        }
                        Console.WriteLine("\n\n");
                    }
                    Console.Clear();
                    var vacancy1 = from e in employers
                                   from v in e.Vacancies
                                   where v.Id == result
                                   select v;
                    VACANCY vacancyResult = new VACANCY();
                    foreach (var vacancy in vacancy1)
                    {
                        vacancyResult = vacancy;
                    }
                    vacancyResult.ShowVacancy();
                    Console.WriteLine("[1] Apply");
                    Console.WriteLine("[2] Back");
                    Console.Write("Select : ");
                    int select11 = int.Parse(Console.ReadLine());
                    if (select11 == 1)
                    {
                        //Console.Write("Choose job you want to apply : ");
                        //int apply = int.Parse(Console.ReadLine());
                        for (int i = 0; i < employers.Count; i++)
                        {
                            for (int k = 0; k < employers[i].Vacancies.Count; k++)
                            {
                                if (vacancyResult.Id == employers[i].Vacancies[k].Id)
                                {
                                    employers[i].Notifications.Count += 1;
                                    employers[i].Applicant.Add(worker);
                                    //employers[i].Vacancies[k].ShowVacancy();
                                    employers[i].ApplicantVacancy.Add(vacancyResult);
                                }
                            }
                        }
                        Notification notification = new Notification();
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("Request sent successfully");
                        Console.ResetColor();
                        Console.ReadKey();

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Worker(worker, employers, employer);

                    }
                    //else if (select == 2) { }

                }
            }
            else if (select1 == 6)
            {
                Start();
            }
        }
        public static void Employer(Employer employer, List<Employer> employers)
        {
            Console.Clear();
            EmlpoyerWord();
            employer.ShowEmployer();
            Console.WriteLine("\t\t\t\t\t\t\t[1] Add vacancy");
            Console.WriteLine("\t\t\t\t\t\t\t[2] Update your vacancy");
            Console.WriteLine("\t\t\t\t\t\t\t[3] Notifications");
            Console.WriteLine("\t\t\t\t\t\t\t[4] Show vacancy");
            Console.WriteLine("\t\t\t\t\t\t\t[5] Back to main menu");
            int employerselect = int.Parse(Console.ReadLine());
            if (employerselect == 1)
            {
                Console.Write("\t\t\t\t\t\t\tEnter speciality : ");
                string speciality1 = Console.ReadLine();
                Console.Write("\t\t\t\t\t\t\tEnter salary : ");
                double salary1 = double.Parse(Console.ReadLine());
                Console.Write("\t\t\t\t\t\t\tEnter practise year : ");
                int practiseyear = int.Parse(Console.ReadLine());
                VACANCY newvac = new VACANCY(speciality1, salary1, practiseyear);
                employer.AddVacancy(newvac);
            }
            else if (employerselect == 2)
            {
                while (true)
                {
                    Console.Clear();
                    employer.Vacancies.ForEach(v => Console.WriteLine(v));
                    Console.Write("\t\t\t\t\t\t\tEnter Id of vacancy : ");
                    int idselect = int.Parse(Console.ReadLine());
                    foreach (var item in employer.Vacancies)
                    {
                        if (idselect == item.Id)
                        {
                            Console.WriteLine("\t\t\t\t\t\t\tDo you want update which one");
                            Console.WriteLine("\t\t\t\t\t\t\t[1] Speciality");
                            Console.WriteLine("\t\t\t\t\t\t\t[2] Salary");
                            Console.WriteLine("\t\t\t\t\t\t\t[3] Experience year");
                            Console.Write("\t\t\t\t\t\t\tEnter select : ");
                            int selectupdatevac = int.Parse(Console.ReadLine());
                            if (selectupdatevac == 1)
                            {
                                Console.Write("\t\t\t\t\t\t\tEnter new speciality : ");
                                string newspecilatyvac = Console.ReadLine();
                                item.Speciality = newspecilatyvac;
                            }
                            else if (selectupdatevac == 2)
                            {
                                Console.Write("\t\t\t\t\t\t\tEnter new salary : ");
                                double newvacsalary = double.Parse(Console.ReadLine());
                                item.Salary = newvacsalary;
                            }
                            else if (selectupdatevac == 3)
                            {
                                Console.Write("\t\t\t\t\t\t\tEnter new experience year : ");
                                int newexyear = int.Parse(Console.ReadLine());
                                item.PractiseYear = newexyear;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("\t\t\t\t\t\t\tWrong select!!!\nTry again");
                                Console.ResetColor();
                                Employer(employer, employers);
                            }
                        }
                    }
                    Console.ReadKey();
                    Console.Clear();
                    Employer(employer, employers);
                }
            }
            else if (employerselect == 3)
            {
                if (employer.Applicant.Count != 0)
                {
                    VACANCY vacancy = new VACANCY();
                    var result1 = employer.ApplicantVacancy.Select(v => v);
                    foreach (var v in result1)
                    {
                        vacancy = v;
                    }
                    employer.Applicant.ForEach(w => w.ShowWorker());
                    employer.Applicant.ForEach(m => m.ShowCVWorker());
                    employer.ApplicantVacancy.ForEach(v => v.ShowVacancy());
                    Console.WriteLine("[1] Accept");
                    Console.WriteLine("[2] Reject");
                    Console.Write("Select : ");
                    var choise = Console.ReadLine();
                    if (choise == "1")
                    {
                        Worker worker = null;
                        var result = employer.Applicant.Select(w => w);
                        foreach (var w in result)
                        {
                            worker = w;
                        }
                        worker.Applicant.Add(employer);
                        worker.ApplicantVacancy.Add(vacancy);
                        worker.Notification.Message = "Was accepted";
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Message sended");
                        Console.ResetColor();
                        Console.ReadKey();
                        employer.Applicant.Clear();
                        employer.ApplicantVacancy.Clear();
                        employer.Vacancies.Remove(vacancy);
                        FileHelper.WriteJsonEmployer(employers);
                    }
                    else if (choise == "2")
                    {
                        Worker worker = null;
                        var result = employer.Applicant.Select(w => w);
                        foreach (var w in result)
                        {
                            worker = w;
                        }
                        worker.Applicant.Add(employer);
                        worker.ApplicantVacancy.Add(vacancy);
                        worker.Notification.Message = "Was rejected";
                        Console.ReadKey();
                        employer.Applicant.Clear();
                        employer.ApplicantVacancy.Clear();
                    }

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("There is no information.");
                    Console.ResetColor();
                    Thread.Sleep(2000);
                    Console.Clear();
                }
            }
            else if (employerselect == 4)
            {
                employer.Vacancies.ForEach(v => Console.WriteLine(v));
            }
            else if (employerselect == 5)
            {
                Start();
            }
        }
        public static void Sign(Worker workers, Employer employers)
        {
            Console.WriteLine("\t\t\t\t\t\t\t\t[1] Worker");
            Console.WriteLine("\t\t\t\t\t\t\t\t[2] Employer");
            int signin = int.Parse(Console.ReadLine());
            if (signin == 1)
            {

            }
        }
        public static void Start()
        {
            string starttime = "2020, 11, 11";
            string endtime = "2022, 11, 11";

            VACANCY vacancy1 = new VACANCY()
            {
                Speciality = "Programmer",
                Salary = 5000,
                PractiseYear = 3
            };
            VACANCY vacancy2 = new VACANCY()
            {
                Speciality = "Front end dev",
                Salary = 3000,
                PractiseYear = 2
            };
            CV cv1 = new CV()
            {
                Speciality = "Front end dev",
                School = "Any school",
                AcceptanceScore = 562,
                Companies = new List<string> { "Amazon" },
                StartWorkTime = starttime,
                EndWorkTime = endtime,
                Languages = new List<string> { "English, Russian, Franch" },
                GitLink = "Github/link111",
                LinkedLink = "Linkedlink/linked111"
            };
            CV cv2 = new CV()
            {
                Speciality = "Programmer",
                School = "Baku modern school",
                AcceptanceScore = 562,
                Companies = new List<string> { "Microsoft" },
                StartWorkTime = starttime,
                EndWorkTime = endtime,
                Languages = new List<string> { "English, Russian" },
                GitLink = "Github/link",
                LinkedLink = "Linkedlink/linked"
            };
            cv1.AddSkill("Java, JavaScript, HTML");
            cv2.AddSkill("C#, C++, PHP, ASP.NET");
            Employer employer1 = new Employer()
            {
                Name = "Corc",
                Surname = "Corclu",
                City = "California",
                Age = 30,
                Username = "c111",
                Password = "c111"
            };
            employer1.AddVacancy(vacancy1);
            Employer employer2 = new Employer()
            {
                Name = "Mark",
                Surname = "Markli",
                City = "Alaska",
                Age = 40,
                Username = "m111",
                Password = "m111"
            };
            employer2.AddVacancy(vacancy2);
            List<Employer> employers = new List<Employer>();
            employers.Add(employer1);
            employers.Add(employer2);
            FileHelper.WriteJsonEmployer(employers);
            employers = FileHelper.ReadJsonEmployer();
            Worker worker1 = new Worker()
            {
                Name = "John",
                Surname = "Johnlu",
                City = "NYC",
                Age = 34,
                Username = "j111",
                Password = "j111"
            };
            Worker worker2 = new Worker()
            {
                Name = "Bob",
                Surname = "Boblu",
                City = "Texas",
                Age = 24,
                Username = "b111",
                Password = "b111",
            };
            List<Worker> workers = new List<Worker>();
            workers.Add(worker1);
            workers.Add(worker2);
            worker1.AddCV(cv1);
            worker2.AddCV(cv2);
            FileHelper.WriteJsonWorker(workers);
            workers = FileHelper.ReadJsonWorker();
            while (true)
            {
                Console.Clear();
                Name();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\t\t\t\t\t\t\t[1] Sign in");
                Console.Write("\t\t\t\t\t\t\t[2] Sign up ");
                int signselect = int.Parse(Console.ReadLine());
                if (signselect == 1)
                {
                    Console.Write("\t\t\t\t\t\t\tEnter username : ");
                    string username = Console.ReadLine();
                    Console.Write("\t\t\t\t\t\t\tEnter password : ");
                    string password = Console.ReadLine();
                    Worker worker = null;
                    Employer employer = null;
                    for (int i = 0; i < workers.Count; i++)
                    {
                        if (username == workers[i].Username && password == workers[i].Password)
                        {
                            worker = workers[i];
                        }
                    }
                    for (int i = 0; i < employers.Count; i++)
                    {
                        if (username == employers[i].Username && password == employers[i].Password)
                        {
                            employer = employers[i];
                        }
                    }
                    if (worker != null)
                    {
                        Worker(worker, employers, employer);
                    }
                    else if (employer != null)
                    {
                        Employer(employer, employers);
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n\t\t\t\t\t\tUser not found. Please try again !");
                        Console.ResetColor();
                        Console.ReadKey();
                    }
                }
                else if (signselect == 2)
                {
                    Console.WriteLine("\n\t\t\t\t\t\t\t[1] Worker");
                    Console.WriteLine("\t\t\t\t\t\t\t[2] Employer");
                    var select1 = Console.ReadLine();
                    if (select1 == "1")
                    {
                        Console.Write("\t\t\t\t\t\t\tEnter name : ");
                        var name = Console.ReadLine();
                        Console.Write("\t\t\t\t\t\t\tEnter surname : ");
                        var surname = Console.ReadLine();
                        Console.Write("\t\t\t\t\t\t\tAge : ");
                        var age = int.Parse(Console.ReadLine());
                        Console.Write("\t\t\t\t\t\t\tEnter city : ");
                        var city = Console.ReadLine();
                        Console.Write("\t\t\t\t\t\t\tEnter username : ");
                        var username = Console.ReadLine();
                        Console.Write("\t\t\t\t\t\t\tCreate password : ");
                        var password = Console.ReadLine();
                        Worker worker = new Worker(name, surname, city, age, username, password);
                        workers.Add(worker);
                        Console.WriteLine("\t\t\t\t\t\t\tDo you want add CV ?");
                        Console.WriteLine("\t\t\t\t\t\t\t[1] Yes");
                        Console.WriteLine("\t\t\t\t\t\t\t[2] No");
                        var choise1 = Console.ReadLine();
                        if (choise1 == "1")
                        {
                            Console.Write("\t\t\t\t\t\t\tEnter speciality : ");
                            var speciality = Console.ReadLine();
                            Console.Write("\t\t\t\t\t\t\tEnter school : ");
                            var school = Console.ReadLine();
                            Console.Write("\t\t\t\t\t\t\tEnter acceptance score : ");
                            double uni = double.Parse(Console.ReadLine());
                            Console.Write("\t\t\t\t\t\t\tEnter skills : ");
                            var skill = Console.ReadLine();
                            var skills = new List<string> { };
                            skills.Add(skill);
                            while (true)
                            {
                                Console.WriteLine("\t\t\t\t\t\t\tYes / No : ");
                                var result = Console.ReadLine();
                                if (result.ToLower() == "yes")
                                {
                                    Console.Write("\t\t\t\t\t\t\tEnter skill : ");
                                    var skill1 = Console.ReadLine();
                                    skills.Add(skill1);
                                }
                                else if (result.ToLower() == "no")
                                {
                                    break;
                                }
                            }
                            Console.Write("\t\t\t\t\t\t\tEnter companies : ");
                            var companies = Console.ReadLine();
                            var companiess = new List<string> { };
                            companiess.Add(companies);
                            Console.WriteLine("\t\t\t\t\t\t\tWant to improve your companies?");
                            while (true)
                            {
                                Console.WriteLine("Yes / No : ");
                                var result = Console.ReadLine();
                                if (result.ToLower() == "yes")
                                {
                                    Console.Write("\t\t\t\t\t\t\tEnter companies : ");
                                    var companies1 = Console.ReadLine();
                                    companiess.Add(companies1);
                                }
                                else if (result.ToLower() == "no")
                                {
                                    break;
                                }
                            }
                            Console.Write("\t\t\t\t\t\t\tEnter language : ");
                            var language = Console.ReadLine();
                            var languages = new List<string> { };
                            languages.Add(language);
                            Console.WriteLine("\t\t\t\t\t\t\tWant to improve your companies?");
                            while (true)
                            {
                                Console.WriteLine("\t\t\t\t\t\t\tYes / No : ");
                                var result = Console.ReadLine();
                                if (result.ToLower() == "yes")
                                {
                                    Console.Write("\t\t\t\t\t\t\tEnter companies : ");
                                    var language1 = Console.ReadLine();
                                    languages.Add(language1);
                                }
                                else if (result.ToLower() == "no")
                                {
                                    break;
                                }
                            }
                            Console.Write("\t\t\t\t\t\t\tEnter work start date : ");
                            var start = Console.ReadLine();
                            Console.WriteLine("\t\t\t\t\t\t\tEnter work end date : ");
                            var end = Console.ReadLine();
                            Console.WriteLine("\t\t\t\t\t\t\tHonors Diploma (Yes / No ) : ");
                            var result1 = Console.ReadLine();
                            Console.WriteLine("\t\t\t\t\t\t\tGitlink (Yes / No ) : ");
                            var result3 = Console.ReadLine();
                            string gitlink = null;
                            if (result3.ToLower() == "yes")
                            {
                                gitlink = Console.ReadLine();
                            }
                            Console.WriteLine("\t\t\t\t\t\t\tLinkedin (Yes / No ) : ");
                            var result2 = Console.ReadLine();
                            string linkedin = null;
                            if (result2.ToLower() == "yes")
                            {
                                linkedin = Console.ReadLine();
                            }
                            CV cV = new CV()
                            {
                                Speciality = speciality,
                                School = school,
                                AcceptanceScore = uni,
                                Companies = companiess,
                                StartWorkTime = start,
                                EndWorkTime = end,
                                Languages = languages,
                                GitLink = gitlink,
                                LinkedLink = linkedin
                            };
                            worker.AddCV(cV);
                        }
                    }
                    else if (select1 == "2")
                    {
                        Console.Write("\t\t\t\t\t\t\tEnter name : ");
                        var name = Console.ReadLine();
                        Console.Write("\t\t\t\t\t\t\tEnter surname : ");
                        var surname = Console.ReadLine();
                        Console.Write("\t\t\t\t\t\t\tAge : ");
                        var age = int.Parse(Console.ReadLine());
                        Console.Write("\t\t\t\t\t\t\tEnter city : ");
                        var city = Console.ReadLine();
                        Console.Write("\t\t\t\t\t\t\tEnter phone number : ");
                        var phone = Console.ReadLine();
                        Console.Write("\t\t\t\t\t\t\tEnter username : ");
                        var username = Console.ReadLine();
                        Console.Write("\t\t\t\t\t\t\tCreat password : ");
                        var password = Console.ReadLine();
                        Employer employer = new Employer(username, password, name, age, surname, city);
                        employers.Add(employer);
                    }
                    Console.WriteLine("\t\t\t\t\t\t\tUser added succesfully ! ");
                    Console.ReadKey();
                }
            }
        }
    }
}
