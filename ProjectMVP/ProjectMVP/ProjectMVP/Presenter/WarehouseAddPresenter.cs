using ProjectMVP.Model;
using ProjectMVP.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMVP.Presenter
{
    class WarehouseAddPresenter
    {
        private Warehouse _model;
        private Form2 _view;

        public WarehouseAddPresenter(Warehouse model, Form2 view)
        {
            _model = model;
            _view = view;

            _view.AddedWarehouse += OnAddedWarehouse;
        }

        private void OnAddedWarehouse(int racksCount, int shelfsCount)
        {
            _model.Create(racksCount, shelfsCount);
            _view.Close();
        }
    }
}
