using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Boss_az
{
    public class FileHelper
    {
        public static void WriteJsonWorker(List<Worker> workers)
        {
            var serializer = new JsonSerializer();
            using (var sw = new StreamWriter("Worker.json"))
            {
                using (var jw = new JsonTextWriter(sw))
                {
                    jw.Formatting = Newtonsoft.Json.Formatting.Indented;
                    serializer.Serialize(jw, workers);
                }
            }
        }
        public static void WriteJsonEmployer(List<Employer> employers)
        {
            var serializer = new JsonSerializer();
            using (var sw = new StreamWriter("Employer.json"))
            {
                using (var jw = new JsonTextWriter(sw))
                {
                    jw.Formatting = Newtonsoft.Json.Formatting.Indented;
                    serializer.Serialize(jw, employers);
                }
            }
        }
        public static List<Worker> ReadJsonWorker()
        {
            List<Worker> workers = null;
            var serializer = new JsonSerializer();
            using (var sr = new StreamReader("Worker.json"))
            {
                using (var jr = new JsonTextReader(sr))
                {
                    workers = serializer.Deserialize<List<Worker>>(jr);
                }
            }
            return workers;
        }
        public static List<Employer> ReadJsonEmployer()
        {
            List<Employer> employers = null;
            var serializer1 = new JsonSerializer();
            using (var sr1 = new StreamReader("Employer.json"))
            {
                using (var jr1 = new JsonTextReader(sr1))
                {
                    employers = serializer1.Deserialize<List<Employer>>(jr1);
                }
            }
            return employers;
        }
    }
}
