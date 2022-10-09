using CracksMan.Infrastructure.Interfaces;
using CracksMan.Models;
using CracksMan.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vector2 = CracksMan.Models.Vector2;

namespace CracksMan.Infrastructure
{
    public class CrossSwitcher : ISwitcherLogic
    {
        public event EventHandler<int> OnGameOver;
        private Table _table;
        private DifficultyLevel _difficulty;
        private bool _isPlay;
        private Safe _form;
        public void StartSwitcher(Table table, DifficultyLevel difficulty)
        {
            _table = table;
            _table.OnChangeElementState += HandlerChangeState;

            _form = new Safe(table);
            _form.Show();
            GameInitialization();
            _isPlay = true;
        }

        public void StopSwitcher()
        {
            _isPlay = false;
        }

        private void HandlerChangeState(object obj, ArgumentControlHandle argumentControlHandle)
        {
            if (!_isPlay)
            {
                return;
            }
            if (argumentControlHandle.IsClick)
            {
                ToggleElemeint(argumentControlHandle.Vector2);
                CheckFinal();
            }
        }

        private void GameInitialization()
        {
            int minCount = new int[] { _table.CountColumns, _table.CountLines }.Min();
            List<Handle> handles = new List<Handle>();
            minCount -= 1;
            for (int i = 0; i < minCount;)
            {
                var tempHandle = _table.Random();
                if (handles.All(x=>x != tempHandle))
                {
                    handles.Add(tempHandle);
                    i++;
                }
            }
            handles.ForEach((x) => ToggleElemeint(x.Vector2,true));
        }

        private void ToggleElemeint(Vector2 vector2,bool click = false)
        {
            _table.ColumnsCallBack(vector2.X,(x)=>x.ToggleState(), vector2);
            _table.LineCallBack(vector2.Y , (x) => x.ToggleState(), vector2);
            if (click)
            {
                _table[vector2.X - 1, vector2.Y - 1].ToggleState();
            }

        }

        private void CheckFinal()
        {
            if (!_table.AllUnLock)
            {
                return;
            }
            int countBalance = _table.CountColumns * _table.CountLines;
            MessageBox.Show($"Набранно очков {countBalance}");
            OnGameOver?.Invoke(this, countBalance);
            _form.Close();
        }
    }
}
