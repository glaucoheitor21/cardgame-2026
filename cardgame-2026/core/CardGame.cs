using cardgame.core.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cardgame.core
{
    // Represents the game logic
    public abstract class CardGame
    {
        public List<Player> Players { get; } = new();
        public abstract void StartGame();
        public abstract void PlayTurn(Player player);
        public abstract bool IsGameOver();
        public abstract Player GetWinner();
    }
}
