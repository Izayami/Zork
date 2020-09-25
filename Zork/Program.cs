using System;

namespace Zork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Zork!");

            Commands command = Commands.UNKNOWN;
            while (command != Commands.QUIT)
            {
                Console.WriteLine(Rooms[CurrentRoomIndex]);
                Console.Write("> ");
                command = ToCommand(Console.ReadLine().Trim());

                string outputString;
                switch (command)
                {
                    case Commands.QUIT:
                        outputString = "Thank you for playing!";
                        break;
                
                    case Commands.LOOK:
                        outputString = "This is an open field west of a white house, with a boarded front door.\nA rubber mat mat saying 'Welcome to Zork!' lies by the door.";
                        break;

                    case Commands.NORTH:
                    case Commands.SOUTH:
                    case Commands.WEST:
                    case Commands.EAST:
                        outputString = Move(command) ? $"You move {command}" : "The way is shut!";
                        break;

                    default:
                        outputString = "Unknown Command.";
                        break;
                }

                Console.WriteLine(outputString);
            }
        }
        private static Commands ToCommand(string commandString) => Enum.TryParse(commandString, true, out Commands result) ? result : Commands.UNKNOWN;

        private static bool Move(Commands command)
        {
            bool didMove = false;
            switch(command)
            {
                case Commands.EAST when CurrentRoomIndex < Rooms.Length - 1:
                    CurrentRoomIndex++;
                    didMove = true;
                    break;

                case Commands.WEST when CurrentRoomIndex > 0:
                    CurrentRoomIndex--;
                    didMove = true;
                    break;
            }
            return didMove;
        }

        private static string[] Rooms =
        {
            "Forest", "West of House", "Behind House", "Clearing", "Canyon View"
        };

        private static int CurrentRoomIndex = 1;
    }
}
    