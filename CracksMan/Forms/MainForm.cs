using CracksMan.Infrastructure;
using CracksMan.Infrastructure.Interfaces;
using CracksMan.Models;

namespace CracksMan
{
    public partial class MainForm : Form
    {
        Score _score;
        IBinaryCaching _binaryCaching;
        public MainForm(IBinaryCaching binaryCaching)
        {
            InitializeComponent();
            _binaryCaching = binaryCaching;
            InitializeScore();
        }

        private void InitializeScore()
        {
            if (_binaryCaching.TryLoad<Score>(out var data,out var exception))
            {
                _score = data;
            }
            else
            {
                _score = new Score();
                _binaryCaching.TrySave<Score>(_score, out _);
            }
            lableScore.Text = _score.Value.ToString();
        }

        private void AddScore(int value)
        {
            _score.Value += value;
            _binaryCaching.TrySave<Score>(_score, out _);
            lableScore.Text = _score.Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CrossSwitcher crossSwitcher = new CrossSwitcher();
            GameController gameController = new GameController(crossSwitcher);

            crossSwitcher.OnGameOver += (x,arg) => 
            {
                AddScore(arg);
            };

            gameController.StartGame(Models.Enums.DifficultyLevel.Default,(int)numericX.Value, (int)numericY.Value);
        }
    }
}