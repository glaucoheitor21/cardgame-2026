using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cardgame.core.models
{
    // Represents a deck of cards
    public class Deck<T> where T : Card
    {
        private readonly List<T> _cards = new();

        public void AddCard(T card) => _cards.Add(card);
        public void Shuffle()
        {
            var random = new Random();
            _cards.Sort((a, b) => random.Next(-1, 2));
        }

        public T DrawCard()
        {
            if (_cards.Count == 0) throw new InvalidOperationException("Deck is empty.");
            var card = _cards[0];
            _cards.RemoveAt(0);
            return card;
        }

        public int Count => _cards.Count;
    }
}
