using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zork
{
    public static  class MovementCommands
    {
        [Command("NORTH", new string[] { "NORTH", "N" })]
        public static void North(Game game, CommandContext commandContext) => Move(game, Directions.North);

        [Command("SOUTH", new string[] { "EAST", "E" })]
        public static void East(Game game, CommandContext commandContext) => Move(game, Directions.East);

        [Command("WEST", new string[] { "WEST", "W" })]
        public static void West(Game game, CommandContext commandContext) => Move(game, Directions.West);

        private static void Move(Game game, Directions direction)
        {
            bool playerMoved = game.Player.Move(direction);
            if(playerMoved == false)
            {
                Console.WriteLine("The way is shut!");
            }
        }
    }
}
