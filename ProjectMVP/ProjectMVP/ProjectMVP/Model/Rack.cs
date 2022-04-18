using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ProjectMVP.Model.Rack;
using static ProjectMVP.Model.Shelf;

namespace ProjectMVP.Model
{
    [Serializable]
    public class Rack : IReadOnlyRack
    {
        public List<Shelf> Shelfs { get; private set; }

        public Rack(List<Shelf> shelfs)
        {
            Shelfs = shelfs;
        }

        public interface IReadOnlyRack
        {
            List<Shelf> Shelfs { get; }
        }
    }
}
