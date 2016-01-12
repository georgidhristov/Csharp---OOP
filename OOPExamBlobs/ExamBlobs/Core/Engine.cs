using ExamBlobs.GameData;
using ExamBlobs.Interfaces;
using ExamBlobs.IO;
using ExamBlobs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamBlobs.Core
{
    public class Engine : IRunnable
    {
        public void Run()
        {
            ConsoleRead consoleRead = new ConsoleRead();
            ConsoleWrite consoleWrite = new ConsoleWrite();
            CreateBlobs createBlob = new CreateBlobs();
            Attacking attacking = new Attacking();
            Data data = new Data();

            string input = "";

            while (input != "drop")
            {
                input = consoleRead.Read();

                string[] commant = input.Split();

                if (commant[0] == "create")
                {
                    string name = commant[1];
                    int health = Int32.Parse(commant[2]);
                    int damage = Int32.Parse(commant[3]);
                    string behavior = commant[4];
                    string attack = commant[5];

                    data.AddBlob(createBlob.Create(name, health, damage, behavior, attack));
                }
                else if (commant[0] == "attack")
                {
                    attacking.Attack(data.Blobs, commant[1], commant[2]);
                }
                else if (commant[0] == "status")
                {
                    consoleWrite.WriteList(data.Blobs);
                }
                else if (commant[0] == "pass")
                {

                }
                else if (commant[0] == "drop")
                {
                    Environment.Exit(0);
                }
            }
        }
    }
}
