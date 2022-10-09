using CracksMan.Models;
using CracksMan.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CracksMan.Infrastructure.Interfaces
{
    public interface ISwitcherLogic
    {
        public event EventHandler<int> OnGameOver;

        void StartSwitcher(Table table, DifficultyLevel difficulty);
        void StopSwitcher();
    }
}
