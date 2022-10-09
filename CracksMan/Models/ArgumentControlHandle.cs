using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CracksMan.Infrastructure;
using CracksMan.Models.Enums;

namespace CracksMan.Models
{
    public class ArgumentControlHandle
    {
        public Vector2 Vector2 { get; set; }
        public bool IsClick { get; set; }
        public Position Position { get; set; }
    }
}
