using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMS_10
{
    class GameController
    {
        public int playerRolls = 0;
        public int playerScore = 0;
        public int aiScore = 0;


        public static int RollsCount = 0;
        Dice aiDice;
        public static bool isHard = false;
        public bool isPlayer = false;

        public GameController(int playerRoll)
        {
            if (isHard)
                aiDice = new HardDice();
            else
                aiDice = new Dice();
            firstStepDecision(playerRoll);
        }

        public int aiRoll
        {
            get
            {
                return aiDice.Roll();
            }
        }

        void firstStepDecision(int playerRoll)
        {            
            if (playerRoll > aiRoll)
                isPlayer = true;
            else
                isPlayer = false;
        }
    }
}
