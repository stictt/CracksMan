using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CracksMan.Infrastructure;
using CracksMan.Models;
using CracksMan.Models.Enums;

namespace CracksMan
{
    public partial class Handle : UserControl
    {
        private Position _state = Position.Up;
        public event EventHandler<ArgumentControlHandle> OnChangeState;
        public Vector2 Vector2 { get; private set; }
        public Handle()
        {
            InitializeComponent();
        }

        public Handle(Vector2 vector2)
        {
            InitializeComponent();
            Vector2 = vector2;  
        }

        public Position GetState()
        {
            return _state;
        }

        private void ToggleArgumentState(ArgumentControlHandle argumentControlHandle)
        {
            if (Position.Up == _state)
            {
                this.BackgroundImage = Properties.Resources.Handle_State_Down;
                _state = Position.Down;
            }
            else if (Position.Down == _state)
            {
                this.BackgroundImage = Properties.Resources.Handle_State_UP;
                _state = Position.Up;
            }
            argumentControlHandle.Position = _state;
            OnChangeState?.Invoke(this, argumentControlHandle);
        }

        public void ToggleState()
        {
            ToggleArgumentState(new ArgumentControlHandle() { IsClick = false,  Vector2 = Vector2 });
        }

        private void Handle_MouseUp(object sender, MouseEventArgs e)
        {
            ToggleArgumentState(new ArgumentControlHandle() { IsClick = true, Vector2 = Vector2 });
        }
    }
}
