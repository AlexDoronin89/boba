using ProjectMVP.Model;
using ProjectMVP.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ProjectMVP.Model.Box;
using static ProjectMVP.Model.Rack;
using static ProjectMVP.Model.Shelf;

namespace ProjectMVP.Presenter
{
    class MainPresenter
    {
        private Warehouse _model;
        private FormMain _view;

        public MainPresenter(Warehouse model, FormMain view)
        {
            _model = model;
            _view = view;

            _model.AddedBox += OnAddedBox;
            _model.RemovedBox += OnRemovedBox;
            _model.UpdatedBox += OnUpdatedBox;

            _view.GettingAllBoxes += OnGettingAllBoxes;
            _view.GettingBoxesByFilter += OnGettingBoxesByFilter;


            _model.AddedShelf += OnAddedShelf;
            _model.RemovedShelf += OnRemovedShelf;
            _model.UpdatedShelf += OnUpdatedShelf;

            _view.GettingAllShelfs += OnGettingAllShelfs;


            _model.AddedRack += OnAddedRack;
            _model.RemovedRack += OnRemovedRack;
            _model.UpdatedRack += OnUpdatedRack;

            _view.GettingAllRacks += OnGettingAllRacks;


            _view.AddingBox += OnSearchingShelf;
            _view.DeletingBox += OnDeletingBox;
            _view.UpdatingBox += OnUpdatingBox;
            _view.CheckingBox += OnCheckingBox;
            _view.OpeningCreateForm += OnOpeningCreateForm;
            _view.SavingRacks += OnSavingRacks;
        }

        private void OnAddedBox() => _view.RefreshBoxData();

        private void OnRemovedBox() => _view.RefreshBoxData();

        private void OnUpdatedBox() => _view.RefreshBoxData();

        private IReadOnlyList<IReadOnlyBox> OnGettingAllBoxes() => _model.GetBoxes();

        private IReadOnlyList<IReadOnlyBox> OnGettingBoxesByFilter(bool isName, bool isDate, bool isPaid,
                                                               string name, DateTime findDate) => _model.GetBoxesByFilter(isName, isDate, isPaid, name, findDate);


        private void OnAddedShelf() => _view.RefreshShelfData();

        private void OnRemovedShelf() => _view.RefreshShelfData();

        private void OnUpdatedShelf() => _view.RefreshShelfData();

        private IReadOnlyList<IReadOnlyShelf> OnGettingAllShelfs() => _model.GetShelfs();


        private void OnAddedRack() => _view.RefreshRackData();

        private void OnRemovedRack() => _view.RefreshRackData();

        private void OnUpdatedRack() => _view.RefreshRackData();

        private IReadOnlyList<IReadOnlyRack> OnGettingAllRacks() => _model.GetRacks();


        private void OnSearchingShelf(string name, int count, DateTime startDate, DateTime endDate) => _model.AddBoxInShelf(name, count, startDate, endDate);

        private void OnDeletingBox(int index) => _model.DeleteBoxInShelf(index);

        private void OnUpdatingBox(int index, string name, int count, DateTime endDate) => _model.UpdateBoxInShelf(index, name, count, endDate);

        private void OnCheckingBox() => _model.CheckBoxesInShelf();

        private void OnOpeningCreateForm()
        {
            Form2 view = new Form2();
            WarehouseAddPresenter warehouseAddPresenter = new WarehouseAddPresenter(_model, view);
            view.ShowDialog();
        }

        private void OnSavingRacks() => _model.Save();
    }
}
