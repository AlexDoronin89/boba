using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMVP.Model.Tools
{
    class Saver
    {
        public void Save(Warehouse warehouse)
        {
            BinaryFormatter formatter = new BinaryFormatter();

            using (FileStream stream = new FileStream("racks.itp", FileMode.OpenOrCreate))
            {
                formatter.Serialize(stream, warehouse.GetRacks());
            }
        }
    }
}
