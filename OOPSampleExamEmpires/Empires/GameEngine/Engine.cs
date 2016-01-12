using Empires.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Empires.IO;
using Empires.Models.Units;
using Empires.Models.Buildings;

namespace Empires.GameEngine
{
    public class Engine : IRunnable
    {
        private IBuilding iBuilding;
        private IInput iInput;
        private IOutput iOutput;

        public Engine(IBuilding iBuilding, IInput iInput, IOutput iOutput)
        {
            this.iBuilding = iBuilding;
            this.iInput = iInput;
            this.iOutput = iOutput;
        }

        public void Run()
        {
            List<string> archerys = new List<string>();
            List<string> barracks = new List<string>(); 
            string input = "";
            int turnsCounter = 0;
            int turnsCeateBuildingCounter = 0;

            List<string> arch = new List<string>();
            List<string> barr = new List<string>();
            List<string> finalResult = new List<string>();
            while (input != "armistice")
            {
                input = iInput.Read();

                switch (input)
                {
                    case "build archery": archerys.Add("Archery" + turnsCeateBuildingCounter); ;
                        break;
                    case "build barracks": barracks.Add("Barracks" + turnsCeateBuildingCounter); ;
                        break;
                    case "empire-status":

                        finalResult.Add("Treasury:");
                        int gold = goldResource(archerys, turnsCeateBuildingCounter);
                        int steel = steelResource(barracks, turnsCeateBuildingCounter);
                        finalResult.Add("--Gold: " + gold);
                        finalResult.Add("--Steel: " + steel);

                        finalResult.Add("Buildings:");
                        arch = FormatAndCalculateArchery(archerys, turnsCeateBuildingCounter); ;
                        for (int i = 0; i < arch.Count(); i++)
                        {
                            finalResult.Add(arch[i]);
                        }

                        barr = FormatAndCalculateBarracks(barracks, turnsCeateBuildingCounter); ;
                        for (int i = 0; i < barr.Count(); i++)
                        {
                            finalResult.Add(barr[i]);
                        }

                        finalResult.Add("Units:");
                        int allArchers = allArchersCreated(archerys, turnsCeateBuildingCounter);
                        int allSwordmans = allSwordmansCreated(barracks, turnsCeateBuildingCounter);
                        if (allArchers > 0)
                        {
                            finalResult.Add("--Archer: " + allArchers);
                        }
                        if (allSwordmans > 0)
                        {
                            finalResult.Add("--Swordsman: " + allSwordmans);
                        }
                        if (allArchers <= 0 && allSwordmans <= 0)
                        {
                            finalResult.Add("N/A");
                        }

                        
                        for (int i = 0; i < finalResult.Count(); i++)
                        {
                            Console.WriteLine(finalResult[i]);
                        }
                        finalResult.Clear();
                        break;
                    case "skip": //skip;
                        break;
                    default:
                        break;

                }

                turnsCounter++;
                turnsCeateBuildingCounter++;
            }
        }

        public List<string> FormatAndCalculateArchery(List<string> list, int turnsCreateBuildingCounter) 
        {
            List<string> result = new List<string>();
            int allArchers = 0;
            int allGold = 0;

            for (int i = 0; i < list.Count(); i++) 
            {
                //archery turns logic...
                int turns = 0;
                string str = list[i].Replace("Archery", "");
                int num = 0;
                num = Int32.Parse(str); 
                turns = (turnsCreateBuildingCounter - num) - 1;
                
                //archer turns left logic...
                int createArcher = 3;
                int archerTurns = turns;
                int archerTurnsLeft = 0;
                while (archerTurns >= createArcher)
                {
                    archerTurns = archerTurns - createArcher;
                    allArchers++;
                }
                while (archerTurns < createArcher)
                {
                    archerTurns = archerTurns + 1;
                    archerTurnsLeft++;
                }
                
                //gold turns left logic...
                int createGold = 2;
                int goldTurns = turns;
                int goldTurnsLeft = 0;
                while (goldTurns >= createGold)
                {
                    goldTurns = goldTurns - createGold;
                    allGold++;
                }
                while (goldTurns < createGold)
                {
                    goldTurns = goldTurns + 1;
                    goldTurnsLeft++;
                }

                result.Add("--Archery: " + turns + " turns (" + archerTurnsLeft + " turns until Archer, " + goldTurnsLeft + " turns until Gold)");
            }
            return result;
        }

        public List<string> FormatAndCalculateBarracks(List<string> list, int turnsCreateBuildingCounter) 
        {
            List<string> result = new List<string>();
            int allSwordman = 0;
            int allSteel = 0;

            for (int i = 0; i < list.Count(); i++)
            {
                //archery turns logic...
                int turns = 0;
                string str = list[i].Replace("Barracks", "");
                int num = 0;
                num = Int32.Parse(str);
                turns = (turnsCreateBuildingCounter - num) - 1;

                //archer turns left logic...
                int createSwordman = 4;
                int swordmanTurns = turns;
                int swordmanTurnsLeft = 0;
                while (swordmanTurns >= createSwordman)
                {
                    swordmanTurns = swordmanTurns - createSwordman;
                    allSwordman++;
                }
                while (swordmanTurns < createSwordman)
                {
                    swordmanTurns = swordmanTurns + 1;
                    swordmanTurnsLeft++;
                }

                //gold turns left logic...
                int createSteel = 3;
                int steelTurns = turns;
                int streelTurnsLeft = 0;
                while (steelTurns >= createSteel)
                {
                    steelTurns = steelTurns - createSteel;
                    allSteel++;
                }
                while (steelTurns < createSteel)
                {
                    steelTurns = steelTurns + 1;
                    streelTurnsLeft++;
                }

                result.Add("--Barracks: " + turns + " turns (" + swordmanTurnsLeft + " turns until Swordsman, " + streelTurnsLeft + " turns until Steel)");
            }
            return result;
        }
        public int goldResource(List<string> list, int turnsCreateBuildingCounter)
        {
            int allGold = 0;
            for (int i = 0; i < list.Count(); i++)
            {
                int turns = 0;
                string str = list[i].Replace("Archery", "");
                int num = 0;
                num = Int32.Parse(str);
                turns = (turnsCreateBuildingCounter - num) - 1;

                int createGold = 2;
                int goldTurns = turns;
                int goldTurnsLeft = 0;
                while (goldTurns >= createGold)
                {
                    goldTurns = goldTurns - createGold;
                    allGold = allGold + 5;
                }
                while (goldTurns < createGold)
                {
                    goldTurns = goldTurns + 1;
                    goldTurnsLeft++;
                }
            }

            return allGold;
        }

        public int steelResource(List<string> list, int turnsCreateBuildingCounter)
        {
            int allSteel = 0;

            for (int i = 0; i < list.Count(); i++)
            {
                int turns = 0;
                string str = list[i].Replace("Barracks", "");
                int num = 0;
                num = Int32.Parse(str);
                turns = (turnsCreateBuildingCounter - num) - 1;

                int createSteel = 3;
                int steelTurns = turns;
                int streelTurnsLeft = 0;
                while (steelTurns >= createSteel)
                {
                    steelTurns = steelTurns - createSteel;
                    allSteel = allSteel + 10;
                }
                while (steelTurns < createSteel)
                {
                    steelTurns = steelTurns + 1;
                    streelTurnsLeft++;
                }
            }
            return allSteel;
        }

        public int allArchersCreated(List<string> list, int turnsCreateBuildingCounter)
        {
            int allArchers = 0;

            for (int i = 0; i < list.Count(); i++)
            {
                int turns = 0;
                string str = list[i].Replace("Archery", "");
                int num = 0;
                num = Int32.Parse(str);
                turns = (turnsCreateBuildingCounter - num) - 1;

                int createArcher = 3;
                int archerTurns = turns;
                while (archerTurns >= createArcher)
                {
                    archerTurns = archerTurns - createArcher;
                    allArchers++;
                }
            }
            return allArchers;
        }

        public int allSwordmansCreated(List<string> list, int turnsCreateBuildingCounter)
        {
            int allSwordman = 0;

            for (int i = 0; i < list.Count(); i++)
            {
                int turns = 0;
                string str = list[i].Replace("Barracks", "");
                int num = 0;
                num = Int32.Parse(str);
                turns = (turnsCreateBuildingCounter - num) - 1;

                int createSwordman = 4;
                int swordmanTurns = turns;
                while (swordmanTurns >= createSwordman)
                {
                    swordmanTurns = swordmanTurns - createSwordman;
                    allSwordman++;
                }
            }
            return allSwordman;
        }
    }
}
