using cardgame.core.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cardgame.core
{

    // Helper Data Structures
    public class MatchData
    {
        public int CurrentRound { get; set; }
        public DateTime StartTime { get; set; }
        public bool IsFinished { get; set; }

        public MatchData()
        {
            CurrentRound = 1;
            StartTime = DateTime.Now;
            IsFinished = false;
        }
    }

    public struct RoundRecord
    {
        public int RoundNumber { get; set; }
        public string PlayerName { get; set; }
        public string Action { get; set; }

        public RoundRecord(int roundNumber, string playerName, string action)
        {
            RoundNumber = roundNumber;
            PlayerName = playerName;
            Action = action;
        }
    }

    // Represents the game logic
    public abstract class CardGame
    {
        public List<Player> Players { get; } = new();

        public MatchData Match { get; protected set; } = new();
        public List<RoundRecord> History { get; } = new();

        public abstract void StartGame();
        public abstract void PlayTurn(Player player);
        public abstract bool IsGameOver();
        public abstract Player GetWinner();

        protected void RecordAction(Player player, string action)
        {
            History.Add(new RoundRecord(
                Match.CurrentRound,
                player.Name,
                action
            ));
        }
    }
}
