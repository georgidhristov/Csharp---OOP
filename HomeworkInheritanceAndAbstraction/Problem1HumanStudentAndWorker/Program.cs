using System;
using System.Collections.Generic;
namespace Problem1HumanStudentAndWorker
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Student> listOfStudents = new List<Student>();
            listOfStudents.Add( new Student( "Georgi", "Hristov","12131401"));
            listOfStudents.Add( new Student( "Dimitar", "Pavlov","12131402"));
            listOfStudents.Add( new Student( "Alexandar", "Aloshev", "12131403"));
            listOfStudents.Add( new Student( "Hristo", "Hristov","12131404"));
            listOfStudents.Add( new Student( "Petar", "Kostov","12131405"));
            listOfStudents.Add( new Student( "Atanas", "Marinov","12131406"));
            listOfStudents.Add( new Student( "Radoslav", "Petkov","12131407"));
            listOfStudents.Add( new Student( "Milen", "Statkov","12131408"));
            listOfStudents.Add( new Student( "Mihail", "Ivanov","12131409"));
            listOfStudents.Add( new Student( "Petar", "Petrov","12131410"));

            List<Worker> listOfWorkers = new List<Worker>();
            listOfWorkers.Add( new Worker( "Hristo", "Hristov",225m, 9m));
            listOfWorkers.Add( new Worker( "Stoil", "Stoichev", 175m, 8m));
            listOfWorkers.Add( new Worker( "Borislav", "Ninov", 300m, 14m));
            listOfWorkers.Add( new Worker( "Miroslav", "Dimitrov", 90m, 4m));
            listOfWorkers.Add( new Worker( "Georgi", "Georgiev", 300m, 12m));
            listOfWorkers.Add( new Worker( "Simeon", "Kirchov", 300m, 10.30m));
            listOfWorkers.Add( new Worker( "Ivan", "Stoqnov", 200m, 8m));
            listOfWorkers.Add( new Worker( "Georgi", "Petrov", 176.30m, 10m));
            listOfWorkers.Add( new Worker( "Georgi", "Atanasov", 70m, 4m));
            listOfWorkers.Add( new Worker( "Nikolai", "Stefanov", 350m, 14m));

            List<string> listOfHumans = MergeLists(listOfStudents, listOfWorkers);
            foreach (var item in listOfHumans)
            {
                Console.WriteLine(item);
            }
        }

        public static List<string> MergeLists(List<Student> listOfStudents, List<Worker> listOfWorkers) 
        {
            List<string> listOfall = new List<string>();

            foreach (var item in listOfStudents)
            {
                listOfall.Add(item.ToString());
            }
            foreach (var item in listOfWorkers)
            {
                listOfall.Add(item.ToString());
            }

            listOfall.Sort();

            return listOfall;
        } 
    }
}
