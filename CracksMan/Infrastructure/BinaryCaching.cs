using CracksMan.Infrastructure.Interfaces;
using CracksMan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace CracksMan.Infrastructure
{
    public class BinaryCaching : IBinaryCaching
    {
        public bool TryLoad<T>(out T loadData, out Exception errorMessage) where T : ResourceCaching, new()
        {
            errorMessage = null;
            loadData = null;
            BinaryFormatter formatter = new BinaryFormatter();

            try
            {
                using (FileStream fs = new FileStream(Application.CommonAppDataPath + "/" + new T().FileName + ".dat", FileMode.Open))
                {
                    loadData = (T)formatter.Deserialize(fs);
                }
                return true;
            }
            catch (Exception e)
            {
                errorMessage = e;
                return false;
            }
        }

        public bool TrySave<T>(T loadData, out Exception errorMessage) where T : ResourceCaching, new()
        {
            errorMessage = null;
            try
            {
                BinaryFormatter formatter = new BinaryFormatter();
                using (FileStream fs = new FileStream(Application.CommonAppDataPath + "/" + new T().FileName + ".dat", FileMode.Create))
                {
                    formatter.Serialize(fs, loadData);
                }
                return true;
            }
            catch (Exception e)
            {
                errorMessage = e;
                return false;
            }
        }
    }
}
