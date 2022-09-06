using System;
using System.Collections.Generic;

namespace ShootingDice
{
    // A SmackTalkingPlayer who randomly selects a taunt from a list to say to the other player
    public class CreativeSmackTalkingPlayer : Player
    {
        private List<string> _taunts = new List<string>()
        {
            "You're bad dice!",
            "Learn how to roll better",
            "You have a bad wrist"
        };

        public override int Roll()
        {
            Console.WriteLine(_taunts[new Random().Next(_taunts.Count)]);
            return base.Roll();
        }

    }
}