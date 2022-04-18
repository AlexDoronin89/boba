using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ProjectMVP.Model.Box;

namespace ProjectMVP.Model
{
    [Serializable]
    public class Box : IReadOnlyBox
    {
        static private int _id = -1;

        public int BoxNumber { get; private set; }
        public Item Item { get; private set; }
        public int Count { get; private set; }
        public DateTime StartDate { get; private set; }
        public DateTime EndDate { get; private set; }
        public int RackSpace { get; private set; }
        public int ShelfSpace { get; private set; }
        public bool IsPaid { get; private set; }

        public Box(Item item, int count, DateTime startDate, DateTime endDate)
        {
            _id++;
            BoxNumber = _id;
            Item = item;
            Count = count;
            StartDate = startDate;
            EndDate = endDate;
            RackSpace = 0;
            ShelfSpace = 0;
            IsPaid = true;
        }

        public void AssignmentSpace(int rackNumber, int shelfNumber)
        {
            RackSpace = rackNumber;
            ShelfSpace = shelfNumber;
        }

        public void Unpaiding()
        {
            IsPaid = false;
        }

        public void Update(string name, int count, DateTime endDate)
        {
            Item.UpdateName(name);
            Count = count;
            EndDate = endDate;
        }

        public interface IReadOnlyBox
        {
            int BoxNumber { get; }
            Item Item { get; }
            int Count { get; }
            DateTime StartDate { get; }
            DateTime EndDate { get; }
            int RackSpace { get; }
            int ShelfSpace { get; }
            bool IsPaid { get; }
        }
    }
}
