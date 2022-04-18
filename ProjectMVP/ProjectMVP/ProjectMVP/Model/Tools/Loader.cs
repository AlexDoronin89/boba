using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMVP.Model.Tools
{
    class Loader
    {
        public List<Rack> LoadRacks()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileInfo fileInfo = new FileInfo("racks.itp");


            using (FileStream stream = new FileStream("racks.itp", FileMode.Open))
            {
                return (List<Rack>)formatter.Deserialize(stream);
            }
        }
    }
}
