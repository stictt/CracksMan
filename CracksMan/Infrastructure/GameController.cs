using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CracksMan.Infrastructure.Interfaces;
using CracksMan.Models.Enums;

namespace CracksMan.Infrastructure
{
    public class GameController
    {
        private ISwitcherLogic _switcherLogic;
        private Table _handles;
        public GameController(ISwitcherLogic switcherLogic)
        {
            _switcherLogic = switcherLogic;
        }

        public void StartGame(DifficultyLevel difficulty, int columns, int lines)
        {
            _handles = new Table(columns, lines);
            _switcherLogic.StartSwitcher(_handles, difficulty);
        }
    }
}
