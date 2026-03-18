using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cardgame.core.models
{
    // Represents a player in the game
    public class Player
    {
        public string Name { get; set; }
        public List<Card> Hand { get; } = new();

        public Player(string name)
        {
            Name = name;
        }

        public void DrawCard<T>(Deck<T> deck) where T : Card
        {
            Hand.Add(deck.DrawCard());
        }

        public override string ToString() => $"{Name} (Cards in hand: {Hand.Count})";
    }
}
