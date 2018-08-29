using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //PlayerCharacter player = new PlayerCharacter();
            //player.DaysSinceLastLogin = 42;

            //player.Name = "Sarah";
            //player.DaysSinceLastLogin = 42;

            //PlayerDisplayer.Write(player);

            //int days = player?.DaysSinceLastLogin ?? -1; 



            //if (player != null)
            //{
            //    days = player.DaysSinceLastLogin ?? -1;
            //}
            //else
            //{
            //    days = -1;
            //}
            //int days = player.DaysSinceLastLogin.Value;


            //Console.WriteLine(days);

            //PlayerCharacter[] players = new PlayerCharacter[3]
            //{
            //    new PlayerCharacter {Name = "Sarah"},
            //    new PlayerCharacter(), //Name = null,
            //    null
            //};

            PlayerCharacter[] players = null;

            string p1 = players?[0]?.Name;
            string p2 = players?[1]?.Name;
            string p3 = players?[2]?.Name;

            Console.ReadLine();
        }
    }
}
