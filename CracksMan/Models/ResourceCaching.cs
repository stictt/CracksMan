using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CracksMan.Models
{
    [Serializable]
    public abstract class ResourceCaching
    {
        public ResourceCaching()
        {
            if (Attribute.GetCustomAttribute(this.GetType(), typeof(SerializableAttribute)) == null)
            {
                throw new NotImplementedException("No have SerializableAttribute.");
            }
        }
        public string FileName { get; protected set; }
    }
}
