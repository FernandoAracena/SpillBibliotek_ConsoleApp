
using System;

namespace SpillBibliotek_ConsoleApp
{
    internal class Spillbibliotek
    {
        public static void Run()
        {
            Menu();
        }

        private static void Menu()
        {
            var konsollSpill = new IKonsollspill[]
            {
                new Nintendo64("Nintendo64"),
                new Playstation2("Playstation2"),
                new GameCube("GameCube")
            };

            ShowAllGames(konsollSpill);

            ShowRandomGame(konsollSpill);

            Console.WriteLine();
            AddNewGame(konsollSpill);
            Console.WriteLine();

            RemoveGame(konsollSpill);
            Console.WriteLine();
        }

        private static void ShowRandomGame(IKonsollspill[] konsollSpill)
        {
            foreach (var konsoll in konsollSpill)
            {
                konsoll.TrekkeUtRandomSpill();
                Console.WriteLine();
            }
        }

        private static void RemoveGame(IKonsollspill[] konsollSpill)
        {
            Console.WriteLine();
            Console.WriteLine("Select Konsoll to Remove a Game :");
            for (int i = 0; i < konsollSpill.Length; i++)
            {
                Console.Write($"{i} - ");
                konsollSpill[i].ShowKonsollType();
            }

            int konsollValg = int.Parse(Console.ReadLine());
            if (konsollValg == 0)
            {
                konsollSpill[0].ShowKonsollspillInfo();
                Console.WriteLine("Input the Index for the Game to Remove :");
                int index = int.Parse(Console.ReadLine());
                konsollSpill[0].FjerneSpill(index);
                Console.WriteLine();
                Console.WriteLine("Games in the List : ");
                konsollSpill[0].ShowKonsollspillInfo();
            }
            else if (konsollValg == 1)
            {
                konsollSpill[1].ShowKonsollspillInfo();
                Console.WriteLine("Input the Index for the Game to Remove :");
                int index = int.Parse(Console.ReadLine());
                konsollSpill[1].FjerneSpill(index);
                Console.WriteLine();
                Console.WriteLine("Games in the List : ");
                konsollSpill[1].ShowKonsollspillInfo();
            }
            else if (konsollValg == 2)
            {
                konsollSpill[2].ShowKonsollspillInfo();
                Console.WriteLine("Input the Index for the Game to Remove :");
                int index = int.Parse(Console.ReadLine());
                konsollSpill[2].FjerneSpill(index);
                Console.WriteLine();
                Console.WriteLine("Games in the List : ");
                konsollSpill[2].ShowKonsollspillInfo();
            }
        }

        private static void AddNewGame(IKonsollspill[] konsollSpill)
        {
            Console.WriteLine("Input a Name Game :");
            string spillName = Console.ReadLine();
            Console.WriteLine("Input a Description Game :");
            string spillDescription = Console.ReadLine();
            Console.WriteLine("Input a Type Game :");
            string spillType = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Select Konsoll to Add a Game :");
            for (int i = 0; i < konsollSpill.Length; i++)
            {
                Console.Write($"{i} - ");
                konsollSpill[i].ShowKonsollType();
            }
            int konsollValg = int.Parse(Console.ReadLine());
            if (konsollValg == 0)
            {
                konsollSpill[0].LeggeTilSpill(new Spill(spillName, spillDescription, spillType));
                Console.WriteLine($"The Game : {spillName} - {spillDescription} - {spillType} was added.");
                Console.WriteLine();
                konsollSpill[0].ShowKonsollspillInfo();
            }
            else if (konsollValg == 1)
            {
                konsollSpill[1].LeggeTilSpill(new Spill(spillName, spillDescription, spillType));
                Console.WriteLine($"The Game : {spillName} - {spillDescription} - {spillType} was added.");
                Console.WriteLine();
                konsollSpill[1].ShowKonsollspillInfo();
            }
            else if (konsollValg == 2)
            {
                konsollSpill[2].LeggeTilSpill(new Spill(spillName, spillDescription, spillType));
                Console.WriteLine($"The Game : {spillName} - {spillDescription} - {spillType} was added.");
                Console.WriteLine();
                konsollSpill[2].ShowKonsollspillInfo();
            }
        }

        private static void ShowAllGames(IKonsollspill[] konsollSpill)
        {
            foreach (var konsoll in konsollSpill)
            {
                Console.WriteLine();
                konsoll.ShowKonsollspillInfo();
                Console.WriteLine();
            }
        }
    }
}
