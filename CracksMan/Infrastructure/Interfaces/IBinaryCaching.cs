using CracksMan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CracksMan.Infrastructure.Interfaces
{
    public interface IBinaryCaching
    {
        bool TryLoad<T>(out T loadData, out Exception errorMessage) where T : ResourceCaching, new();

        bool TrySave<T>(T loadData, out Exception errorMessage) where T : ResourceCaching, new();
    }
}
