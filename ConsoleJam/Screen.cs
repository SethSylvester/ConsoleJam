using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleJam
{
    public enum Level
    {
        title,
        win,
        loss
    };

    class Screen
    {
        Level screen;

        public Screen(int id)
        {
            screen = (Level)id;
            LoadScreen();
        }

        public void LoadScreen()
        {
            switch (screen)
            {
                case Level.title:
                {
                        Console.WriteLine("  _______ _           __      ___                ");
                        Console.WriteLine(" |__   __| |          \\ \\    / (_)               ");
                        Console.WriteLine("    | |  | |__   ___   \\ \\  / / _ _ __ _   _ ___ ");
                        Console.WriteLine("    | |  | '_ \\ / _ \\   \\ \\/ / | | '__| | | / __|");
                        Console.WriteLine("    | |  | | | |  __/    \\  /  | | |  | |_| \\__ \\");
                        Console.WriteLine("    |_|  |_| |_|\\___|     \\/   |_|_|   \\__,_|___/");
                        Console.WriteLine("");
                        Console.WriteLine("                        .");
                        Console.WriteLine("                     ,'/ \\`.");
                        Console.WriteLine("                    |\\/___\\/|");
                        Console.WriteLine("                    \'\\   /`/");
                        Console.WriteLine("                     `\\ /,'");
                        Console.WriteLine("                     `.\\ /,'");
                        Console.WriteLine("                        |");
                        Console.WriteLine("                        |");
                        Console.WriteLine("                       |=|");
                        Console.WriteLine("                  /\\  ,|=|.  /\\");
                        Console.WriteLine("            ,'    `.|\\ `-' /|,'    `.");
                        Console.WriteLine("          ,'   .-._ \\ `---' / _,-.   `.");
                        Console.WriteLine("             ,'    `-`-._,-'-'    `.");
                        Console.WriteLine("            '                       `");
                        Console.WriteLine("Press any key to start.");
                        Console.WriteLine("A/D to move, Space to fire, Esc to exit.");
                        Console.ReadKey(true);
                        break;
                }
                case Level.loss:
                {
                        Console.WriteLine("  _______    _        _    ____        _   _                    _    ");
                        Console.WriteLine(" |__   __|  | |      | |  / __ \\      | | | |                  | |   ");
                        Console.WriteLine("    | | ___ | |_ __ _| | | |  | |_   _| |_| |__  _ __ ___  __ _| | __");
                        Console.WriteLine("    | |/ _ \\| __/ _` | | | |  | | | | | __| '_ \\| '__/ _ \\/ _` | |/ /");
                        Console.WriteLine("    | | (_) | || (_| | | | |__| | |_| | |_| |_) | | |  __/ (_| |   < ");
                        Console.WriteLine("    |_|\\___/ \\__\\__,_|_|  \\____/ \\__,_|\\__|_.__/|_|  \\___|\\__,_|_|\\_\\");
                        Console.WriteLine("");
                        Console.WriteLine("              .");
                        Console.WriteLine("           ,'/ \\`.");
                        Console.WriteLine("          |\\/___\\/|");
                        Console.WriteLine("          \'\\   /`/");
                        Console.WriteLine("           `\\ /,'");
                        Console.WriteLine("           `.\\ /,'");
                        Console.WriteLine("              |");
                        Console.WriteLine("              |");
                        Console.WriteLine("             |=|");
                        Console.WriteLine("        /\\  ,|=|.  /\\");
                        Console.WriteLine("  ,'    `.|\\ `-' /|,'    `.");
                        Console.WriteLine(",'   .-._ \\ `---' / _,-.   `.");
                        Console.WriteLine("   ,'    `-`-._,-'-'    `.");
                        Console.WriteLine("  '                       `");
                        Console.WriteLine("Press enter to exit.");
                        Program.running = false;
                        Console.ReadLine();
                        break;
                }
                case Level.win:
                    {
                        Console.WriteLine(" __      ___      _                   ");
                        Console.WriteLine(" \\ \\    / (_)    | |                  ");
                        Console.WriteLine("  \\ \\  / / _  ___| |_ ___  _ __ _   _ ");
                        Console.WriteLine("   \\ \\/ / | |/ __| __/ _ \\| '__| | | |");
                        Console.WriteLine("    \\  /  | | (__| || (_) | |  | |_| |");
                        Console.WriteLine("     \\/   |_|\\___|\\__\\___/|_|   \\__, |");
                        Console.WriteLine("                                 __/ |");
                        Console.WriteLine("                                |___/ ");
                        Console.WriteLine("             .:::::::::.");
                        Console.WriteLine("          .::::::::::::::::.");
                        Console.WriteLine("         :::        ...:::::");
                        Console.WriteLine("        :::   .:::::::::::::");
                        Console.WriteLine("        ::'  ::::'        :::::");
                        Console.WriteLine("  .::::::   :::::            ::");
                        Console.WriteLine(" ::::::::   :::::::::::::::::");
                        Console.WriteLine(" :::  :::    ::::::::::::::::");
                        Console.WriteLine(" :::  :::     ::::::::::::::");
                        Console.WriteLine(" ::'  :::                ::⣧  ");
                        Console.WriteLine(" ::   :::                :::  ");
                        Console.WriteLine(" ::   :::                :::  ");
                        Console.WriteLine(" :::  :::                :::  ");
                        Console.WriteLine(" :::. :::                :::  ");
                        Console.WriteLine("  ::::::⣇     ::::::::: ⢠::   ");
                        Console.WriteLine("       ::     ::: :::'  :::   ");
                        Console.WriteLine("       ::     ::: :::   :::   ");
                        Console.WriteLine("       :::::.:::' ':::::::    ");
                        Console.WriteLine("       ::::::::'             ");
                        Console.WriteLine("Press enter to exit.");
                        Program.running = false;
                        Console.ReadLine();
                        break;
                    }
            }
        }

    }
}
