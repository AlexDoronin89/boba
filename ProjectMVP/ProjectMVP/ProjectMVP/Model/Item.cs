using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ProjectMVP.Model.Item;

namespace ProjectMVP.Model
{
    [Serializable]
    public class Item : IReadOnlyItem
    {
        public string Name { get; private set; }

        public Item(string name)
        {
            Name = name;
        }

        public void UpdateName(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }

        public interface IReadOnlyItem
        {
            string Name { get; }
        }
    }
}
