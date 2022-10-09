using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CracksMan.Models
{
    [Serializable]
    public class Score : ResourceCaching
    {
        public Score() => FileName = "Score";

        public int Value;
    }
}
