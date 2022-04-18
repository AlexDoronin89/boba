using ProjectMVP.Model.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ProjectMVP.Model.Box;
using static ProjectMVP.Model.Item;
using static ProjectMVP.Model.Rack;
using static ProjectMVP.Model.Shelf;

namespace ProjectMVP.Model
{
    class Warehouse
    {
        public List<Rack> Racks { get; private set; }

        public event Action AddedBox;
        public event Action RemovedBox;
        public event Action UpdatedBox;

        public event Action AddedShelf;
        public event Action RemovedShelf;
        public event Action UpdatedShelf;

        public event Action AddedRack;
        public event Action RemovedRack;
        public event Action UpdatedRack;

        public Warehouse(List<Rack> racks)
        {
            Loader loader = new Loader();

            Racks = loader.LoadRacks();
            UpdatedBox?.Invoke();
        }

        public void Create(int racksCount, int shelfsCount)
        {
            Racks.Clear();

            for (int i = 0; i < racksCount; i++)
            {
                AddRack(new List<Shelf>());

                for (int j = 0; j < shelfsCount; j++)
                {
                    AddShelf(new List<Box>(), i);
                }
            }

            UpdatedRack?.Invoke();
        }

        public void AddBoxInShelf(string name, int count, DateTime startDate, DateTime endDate)
        {
            bool isStop = false;

            for (int i = 0; i < Racks.Count; i++)
            {
                for (int j = 0; j < Racks[i].Shelfs.Count; j++)
                {
                    if (Racks[i].Shelfs[j].Boxes.Count < Racks[0].Shelfs[0].MaxCountBox)
                    {
                        AddBox(name, count, i, j, startDate, endDate);
                        Racks[i].Shelfs[j].Boxes[Racks[i].Shelfs[j].Boxes.Count - 1].AssignmentSpace(i + 1, j + 1);
                        isStop = true;
                        break;
                    }
                }

                if (isStop == true)
                    break;
            }
        }

        public void DeleteBoxInShelf(int index)
        {
            bool isStop = false;

            for (int i = 0; i < Racks.Count; i++)
            {
                for (int j = 0; j < Racks[i].Shelfs.Count; j++)
                {
                    for (int z = 0; z < Racks[i].Shelfs[j].Boxes.Count; z++)
                    {
                        if (i + j * Racks[0].Shelfs[0].MaxCountBox + z == index)
                        {
                            RemoveBox(index - (i + j * Racks[0].Shelfs[0].MaxCountBox), i, j);
                            isStop = true;
                            break;
                        }
                    }

                    if (isStop == true)
                        break;
                }

                if (isStop == true)
                    break;
            }
        }

        public void UpdateBoxInShelf(int index, string name, int count, DateTime endDate)
        {
            bool isStop = false;

            for (int i = 0; i < Racks.Count; i++)
            {
                for (int j = 0; j < Racks[i].Shelfs.Count; j++)
                {
                    for (int z = 0; z < Racks[i].Shelfs[j].Boxes.Count; z++)
                    {
                        if (i + j * Racks[0].Shelfs[0].MaxCountBox + z == index)
                        {
                            Racks[i].Shelfs[j].Boxes[z].Update(name, count, endDate);
                            UpdatedBox?.Invoke();
                            isStop = true;
                            break;
                        }
                    }

                    if (isStop == true)
                        break;
                }

                if (isStop == true)
                    break;
            }
        }

        public void CheckBoxesInShelf()
        {
            for (int i = 0; i < Racks.Count; i++)
            {
                for (int j = 0; j < Racks[i].Shelfs.Count; j++)
                {
                    for (int z = 0; z < Racks[i].Shelfs[j].Boxes.Count; z++)
                    {
                        if (Racks[i].Shelfs[j].Boxes[z].EndDate.Date == DateTime.Today)
                        {
                            Racks[i].Shelfs[j].Boxes[z].Unpaiding();
                            UpdatedBox?.Invoke();
                        }
                    }
                }
            }
        }

        public void Save()
        {
            Saver saver = new Saver();
            saver.Save(this);
        }

        public void AddBox(string name, int count, int rackNumber, int shelfNumber, DateTime startDate, DateTime endDate)
        {
            Racks[rackNumber].Shelfs[shelfNumber].Boxes.Add(new Box(new Item(name), count, startDate, endDate));
            AddedBox?.Invoke();
        }

        public void RemoveBox(int index, int rackNumber, int shelfNumber)
        {
            Racks[rackNumber].Shelfs[shelfNumber].Boxes.RemoveAt(index);
            RemovedBox?.Invoke();
        }

        public void UpdateBox(int index, string name, int count, int rackNumber, int shelfNumber, DateTime startDate, DateTime endDate)
        {
            Racks[rackNumber].Shelfs[shelfNumber].Boxes[index] = new Box(new Item(name), count, startDate, endDate);
            UpdatedBox?.Invoke();
        }

        public IReadOnlyList<IReadOnlyBox> GetBoxesByFilter(bool isName, bool isDate, bool isUnpaid, string name, DateTime findDate)
        {
            IReadOnlyList<IReadOnlyBox> boxes;
            List<Box> boxList = new List<Box>();

            if (isName == true)
            {
                for (int i = 0; i < Racks.Count; i++)
                {
                    for (int j = 0; j < Racks[i].Shelfs.Count; j++)
                    {
                        for (int z = 0; z < Racks[i].Shelfs[j].Boxes.Count; z++)
                        {
                            if (isUnpaid == true && isDate == true)
                            {
                                if (Racks[i].Shelfs[j].Boxes[z].Item.Name == name && Racks[i].Shelfs[j].Boxes[z].EndDate.Date == findDate.Date && Racks[i].Shelfs[j].Boxes[z].IsPaid == false)
                                    boxList.Add(Racks[i].Shelfs[j].Boxes[z]);
                            }
                            else
                            {
                                if (isDate == true)
                                {
                                    if (Racks[i].Shelfs[j].Boxes[z].Item.Name == name && Racks[i].Shelfs[j].Boxes[z].EndDate.Date == findDate.Date)
                                        boxList.Add(Racks[i].Shelfs[j].Boxes[z]);
                                }
                                else
                                {
                                    if (isUnpaid == true)
                                    {
                                        if (Racks[i].Shelfs[j].Boxes[z].Item.Name == name && Racks[i].Shelfs[j].Boxes[z].IsPaid == false)
                                            boxList.Add(Racks[i].Shelfs[j].Boxes[z]);
                                    }
                                    else
                                    {
                                        if (Racks[i].Shelfs[j].Boxes[z].Item.Name == name)
                                            boxList.Add(Racks[i].Shelfs[j].Boxes[z]);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                if (isDate == true)
                {
                    for (int i = 0; i < Racks.Count; i++)
                    {
                        for (int j = 0; j < Racks[i].Shelfs.Count; j++)
                        {
                            for (int z = 0; z < Racks[i].Shelfs[j].Boxes.Count; z++)
                            {
                                if (isUnpaid == true && isName == true)
                                {
                                    if (Racks[i].Shelfs[j].Boxes[z].Item.Name == name && Racks[i].Shelfs[j].Boxes[z].EndDate.Date == findDate.Date && Racks[i].Shelfs[j].Boxes[z].IsPaid == false)
                                        boxList.Add(Racks[i].Shelfs[j].Boxes[z]);
                                }
                                else
                                {
                                    if (isName == true)
                                    {
                                        if (Racks[i].Shelfs[j].Boxes[z].Item.Name == name && Racks[i].Shelfs[j].Boxes[z].EndDate.Date == findDate.Date)
                                            boxList.Add(Racks[i].Shelfs[j].Boxes[z]);
                                    }
                                    else
                                    {
                                        if (isUnpaid == true)
                                        {
                                            if (Racks[i].Shelfs[j].Boxes[z].EndDate.Date == findDate.Date && Racks[i].Shelfs[j].Boxes[z].IsPaid == false)
                                                boxList.Add(Racks[i].Shelfs[j].Boxes[z]);
                                        }
                                        else
                                        {
                                            if (Racks[i].Shelfs[j].Boxes[z].EndDate.Date == findDate.Date)
                                                boxList.Add(Racks[i].Shelfs[j].Boxes[z]);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                else
                {
                    if (isUnpaid == true)
                    {
                        for (int i = 0; i < Racks.Count; i++)
                        {
                            for (int j = 0; j < Racks[i].Shelfs.Count; j++)
                            {
                                for (int z = 0; z < Racks[i].Shelfs[j].Boxes.Count; z++)
                                {
                                    if (isUnpaid == true && isName == true)
                                    {
                                        if (Racks[i].Shelfs[j].Boxes[z].Item.Name == name && Racks[i].Shelfs[j].Boxes[z].EndDate.Date == findDate.Date && Racks[i].Shelfs[j].Boxes[z].IsPaid == false)
                                            boxList.Add(Racks[i].Shelfs[j].Boxes[z]);
                                    }
                                    else
                                    {
                                        if (isName == true)
                                        {
                                            if (Racks[i].Shelfs[j].Boxes[z].Item.Name == name && Racks[i].Shelfs[j].Boxes[z].IsPaid == false)
                                                boxList.Add(Racks[i].Shelfs[j].Boxes[z]);
                                        }
                                        else
                                        {
                                            if (isDate == true)
                                            {
                                                if (Racks[i].Shelfs[j].Boxes[z].IsPaid == false && Racks[i].Shelfs[j].Boxes[z].EndDate.Date == findDate.Date)
                                                    boxList.Add(Racks[i].Shelfs[j].Boxes[z]);
                                            }
                                            else
                                            {
                                                if (Racks[i].Shelfs[j].Boxes[z].IsPaid == false)
                                                    boxList.Add(Racks[i].Shelfs[j].Boxes[z]);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            boxes = boxList;

            return boxes;
        }

        public IReadOnlyList<IReadOnlyBox> GetBoxes()
        {
            IReadOnlyList<IReadOnlyBox> boxes;
            List<Box> boxList = new List<Box>();

            for (int i = 0; i < Racks.Count; i++)
            {
                for (int j = 0; j < Racks[i].Shelfs.Count; j++)
                {
                    for (int z = 0; z < Racks[i].Shelfs[j].Boxes.Count; z++)
                        boxList.Add(Racks[i].Shelfs[j].Boxes[z]);
                }
            }

            boxes = boxList;

            return boxes;
        }

        public IReadOnlyList<IReadOnlyBox> GetUnpaidBoxes()
        {
            IReadOnlyList<IReadOnlyBox> boxes;
            List<Box> boxList = new List<Box>();

            for (int i = 0; i < Racks.Count; i++)
            {
                for (int j = 0; j < Racks[i].Shelfs.Count; j++)
                {
                    for (int z = 0; z < Racks[i].Shelfs[j].Boxes.Count; z++)
                    {
                        if (Racks[i].Shelfs[j].Boxes[z].IsPaid == false)
                            boxList.Add(Racks[i].Shelfs[j].Boxes[z]);
                    }
                }
            }

            boxes = boxList;

            return boxes;
        }

        public IReadOnlyList<IReadOnlyBox> GetBoxesByDate(DateTime findDate)
        {
            IReadOnlyList<IReadOnlyBox> boxes;
            List<Box> boxList = new List<Box>();

            for (int i = 0; i < Racks.Count; i++)
            {
                for (int j = 0; j < Racks[i].Shelfs.Count; j++)
                {
                    for (int z = 0; z < Racks[i].Shelfs[j].Boxes.Count; z++)
                    {
                        if (Racks[i].Shelfs[j].Boxes[z].EndDate.Date == findDate.Date)
                            boxList.Add(Racks[i].Shelfs[j].Boxes[z]);
                    }
                }
            }

            boxes = boxList;

            return boxes;
        }

        public IReadOnlyList<IReadOnlyBox> GetBoxesByName(string name)
        {
            IReadOnlyList<IReadOnlyBox> boxes;
            List<Box> boxList = new List<Box>();

            for (int i = 0; i < Racks.Count; i++)
            {
                for (int j = 0; j < Racks[i].Shelfs.Count; j++)
                {
                    for (int z = 0; z < Racks[i].Shelfs[j].Boxes.Count; z++)
                    {
                        if (Racks[i].Shelfs[j].Boxes[z].Item.Name == name)
                            boxList.Add(Racks[i].Shelfs[j].Boxes[z]);
                    }
                }
            }

            boxes = boxList;

            return boxes;
        }

        public void AddShelf(List<Box> boxes, int rackNumber)
        {
            Racks[rackNumber].Shelfs.Add(new Shelf(boxes));
            AddedShelf?.Invoke();
        }

        public void RemoveShelf(int index, int rackNumber)
        {
            Racks[rackNumber].Shelfs.RemoveAt(index);
            RemovedShelf?.Invoke();
        }

        public void UpdateShelf(int i, List<Box> boxes, int rackNumber)
        {
            Racks[rackNumber].Shelfs[i] = new Shelf(boxes);
            UpdatedShelf?.Invoke();
        }

        public IReadOnlyList<IReadOnlyShelf> GetShelfs()
        {
            IReadOnlyList<IReadOnlyShelf> shelf = null;
            List<Shelf> shelfsList = new List<Shelf>();

            for (int i = 0; i < Racks.Count; i++)
            {
                for (int j = 0; j < Racks[i].Shelfs.Count; j++)
                {
                    for (int c = 0; c < Racks[i].Shelfs[j].Boxes.Count; c++)
                    {
                        shelfsList.Add(Racks[i].Shelfs[j]);
                    }
                }
            }

            shelf = shelfsList;

            return shelf;
        }

        public void AddRack(List<Shelf> shelfs)
        {
            Racks.Add(new Rack(shelfs));
            AddedRack?.Invoke();
        }

        public void RemoveRack(int index)
        {
            Racks.RemoveAt(index);
            RemovedRack?.Invoke();
        }

        public void UpdateRack(int rackNumber, List<Shelf> shelfs)
        {
            Racks[rackNumber] = new Rack(shelfs);
            UpdatedRack?.Invoke();
        }

        public IReadOnlyList<IReadOnlyRack> GetRacks() => Racks;
    }
}
