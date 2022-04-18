using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ProjectMVP.Model.Box;

using static ProjectMVP.Model.Shelf;

namespace ProjectMVP.Model
{
    [Serializable]
    public class Shelf : IReadOnlyShelf
    {
        public List<Box> Boxes { get; private set; }
        public int MaxCountBox { get; private set; }

        public Shelf(List<Box> boxes)
        {
            Boxes = boxes;
            MaxCountBox = 5;
        }

        public interface IReadOnlyShelf
        {
            List<Box> Boxes { get; }
            int MaxCountBox { get; }
        }
    }
}
