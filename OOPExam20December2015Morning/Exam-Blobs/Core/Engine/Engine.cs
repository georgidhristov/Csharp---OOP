using Exam_Blobs.Interfaces;
using Exam_Blobs.IO;
using Exam_Blobs.Models;
using Exam_Blobs.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Blobs.Core.Engine
{
    public class Engine : IRunnable
    {
        private IBlob blob;
        ConsoleRead consoleRead = new ConsoleRead();
        ConsoleWrite consoleWrite = new ConsoleWrite();
        BlobCreator blobCreator = new BlobCreator();
        AttackBlob attackBlob = new AttackBlob();
        Data.Data data = new Data.Data();

        public void Run()
        {
            string input = null;

            while (input != "drop")
            {
                input = consoleRead.Read();

                string[] command = input.Split();

                switch (command[0])
                {
                    case "create":
                        string name = command[1];
                        int health = Int32.Parse(command[2]);
                        int damage = Int32.Parse(command[3]);
                        string behavior = command[4];
                        string attack = command[5];

                        blob = blobCreator.Create(name, health, damage, behavior, attack);
                        data.AddBlob(blob);
                        break;
                    case "attack":
                        string attacker = command[1];
                        string defender = command[2];
                        data.Blobs = attackBlob.Attack(data.Blobs, attacker, defender);
                        break;
                    case "status":
                        consoleWrite.WriteList(data.Blobs);
                        break;
                    case "pass":
                        break;
                    default:
                        break;
                } 
            }
        }
    }
}
