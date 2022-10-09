using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CracksMan.Models
{
    public readonly struct Vector2
    {
        public Vector2(int x,int y)
        {
            X = x; 
            Y = y; 
        }
        public readonly int X;
        public readonly int Y;
    }
}
