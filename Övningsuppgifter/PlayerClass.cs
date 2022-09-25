//using System;
//using System.Collections.Generic;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Övningsuppgifter
//{
//    public class PlayerClass
//    {
//        public string Name { get; set; }
//        public int XCoordinates { get; set; }
//        public int YCoordinates { get; set; }
        
//        private int _points;

//        public int Points
//        {
//            get { return _points; }
//            set
//            {
//                _points = value;
//                Console.SetCursorPosition(XCoordinates, YCoordinates);
//                Console.WriteLine($"{Name}'s points: {Points}");
//            }
//        }

//        public enum WinLoseTie
//        {
//            Win,
//            Lose,
//            Tie
//        }
//        public enum RPS
//        {
//            Rock,
//            Paper,
//            Scissors
//        }

//        public PlayerClass(string name, int xCoordinates, int yCoordinates)
//        {
//            Name = name;
//            XCoordinates = xCoordinates;
//            YCoordinates = yCoordinates;
//            Points = 0;
//        }

//        public RPS GetRockPaperScissors()
//        {
//            Random random = new Random();
//            RPS setRPS = (RPS)random.Next(3);
//            return setRPS;
//        }

//        public static WinLoseTie GetOutcome(RPS playerRPS, RPS computerRPS)
//        {
//            WinLoseTie outcome;
//            if (playerRPS == computerRPS)
//            {
//                outcome = WinLoseTie.Tie;
//            }
//            else if ((playerRPS == RPS.Paper && computerRPS == RPS.Rock) ||
//                     (playerRPS == RPS.Rock && computerRPS == RPS.Scissors) ||
//                     (playerRPS == RPS.Scissors && computerRPS == RPS.Paper))
//            {
//                outcome = WinLoseTie.Win;
//            }
//            else
//            {
//                outcome = WinLoseTie.Lose;
//            }
//            return outcome;
//        }
//    }
//}
