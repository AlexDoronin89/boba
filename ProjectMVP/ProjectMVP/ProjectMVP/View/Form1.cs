using ProjectMVP.Model;
using ProjectMVP.Presenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ProjectMVP.Model.Box;
using static ProjectMVP.Model.Item;
using static ProjectMVP.Model.Rack;
using static ProjectMVP.Model.Shelf;

namespace ProjectMVP.View
{
    public partial class FormMain : Form
    {
        public event Func<IReadOnlyList<IReadOnlyBox>> GettingAllBoxes;

        public event Func<bool, bool, bool, string, DateTime, IReadOnlyList<IReadOnlyBox>> GettingBoxesByFilter;

        public event Func<IReadOnlyList<IReadOnlyShelf>> GettingAllShelfs;

        public event Func<IReadOnlyList<IReadOnlyRack>> GettingAllRacks;

        public event Action<string, int, DateTime, DateTime> AddingBox;

        public event Action<int> DeletingBox;

        public event Action<int, string, int, DateTime> UpdatingBox;

        public event Action CheckingBox;

        public event Action OpeningCreateForm;

        public event Action SavingRacks;

        public FormMain()
        {
            InitializeComponent();
        }

        public void RefreshDataGrid(IReadOnlyList<IReadOnlyBox> data)
        {
            dataGridViewTable.DataSource = null;
            if (data[0] != null)
            {
                IReadOnlyBox template = data[0];
                dataGridViewTable.DataSource = data;

                dataGridViewTable.Columns[nameof(template.BoxNumber)].Visible = false;
                dataGridViewTable.Columns[nameof(template.Item)].HeaderText = "Название";
                dataGridViewTable.Columns[nameof(template.Count)].HeaderText = "Кол - во";
                dataGridViewTable.Columns[nameof(template.Count)].Width = 70;
                dataGridViewTable.Columns[nameof(template.StartDate)].HeaderText = "Начало";
                dataGridViewTable.Columns[nameof(template.EndDate)].HeaderText = "Конец";
                dataGridViewTable.Columns[nameof(template.RackSpace)].HeaderText = "Стелаж";
                dataGridViewTable.Columns[nameof(template.RackSpace)].Width = 60;
                dataGridViewTable.Columns[nameof(template.ShelfSpace)].HeaderText = "Полка";
                dataGridViewTable.Columns[nameof(template.ShelfSpace)].Width = 60;
                dataGridViewTable.Columns[nameof(template.IsPaid)].HeaderText = "Оплачен";
                dataGridViewTable.Columns[nameof(template.IsPaid)].Width = 60;
            }
        }

        public void RefreshBoxByFilter()
        {
            bool isName = false;
            bool isDate = false;
            bool isUnpaid = false;

            if (checkBoxName.Checked == true)
                isName = true;
            if (checkBoxData.Checked == true)
                isDate = true;
            if (checkBoxUnpaid.Checked == true)
                isUnpaid = true;

            IReadOnlyList<IReadOnlyBox> data = GettingBoxesByFilter?.Invoke(isName, isDate, isUnpaid, textBoxFindByName.Text, dateTimePickerFindByDate.Value);
            RefreshDataGrid(data);
        }

        public void RefreshBoxData()
        {
            IReadOnlyList<IReadOnlyBox> data = GettingAllBoxes?.Invoke();
            RefreshDataGrid(data);
        }

        public void RefreshShelfData()
        {
            IReadOnlyList<IReadOnlyShelf> data = GettingAllShelfs?.Invoke();
        }

        public void RefreshRackData()
        {
            IReadOnlyList<IReadOnlyRack> data = GettingAllRacks?.Invoke();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            RefreshBoxData();
        }

        private void buttonTableAdd_Click(object sender, EventArgs e)
        {
            AddingBox?.Invoke(textBoxTableName.Text, int.Parse(textBoxTableCount.Text), dateTimePickerStart.Value, dateTimePickerEnd.Value);
            textBoxTableName.Text = null;
            textBoxTableCount.Text = null;
        }

        private void buttonTableDelete_Click(object sender, EventArgs e)
        {
            DeletingBox?.Invoke(dataGridViewTable.SelectedCells[0].RowIndex);
        }

        private void buttonTableUpdateAll_Click(object sender, EventArgs e)
        {
            RefreshBoxData();
            checkBoxData.Checked = false;
            checkBoxName.Checked = false;
            checkBoxUnpaid.Checked = false;
            textBoxFindByName.Text = null;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            CheckingBox?.Invoke();
        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IReadOnlyList<IReadOnlyBox> data = GettingAllBoxes?.Invoke();
            OpeningCreateForm?.Invoke();
            if (data != null)
            {
                for (int i = 0; i < data.Count; i++)
                {
                    AddingBox?.Invoke(data[i].Item.Name, data[i].Count, data[i].StartDate, data[i].EndDate);
                }
            }
        }

        private void buttonFindByFilter_Click_1(object sender, EventArgs e)
        {
            RefreshBoxByFilter();
        }

        private void сохранитьСкладToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SavingRacks?.Invoke();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            UpdatingBox?.Invoke(dataGridViewTable.SelectedCells[0].RowIndex, textBoxUpdateName.Text, int.Parse(textBoxUpdateCount.Text), dateTimePickerUpdate.Value);
        }
    }
}
