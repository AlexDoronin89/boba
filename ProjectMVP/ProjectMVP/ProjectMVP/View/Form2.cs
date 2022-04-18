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

namespace ProjectMVP.View
{
    public partial class Form2 : Form
    {
        public event Action<int, int> AddedWarehouse;

        public Form2()
        {
            InitializeComponent();
        }

        private void buttonAddWarehouse_Click(object sender, EventArgs e)
        {
            AddedWarehouse?.Invoke(int.Parse(textBoxCountRacks.Text), int.Parse(textBoxCountShelfs.Text));
        }
    }
}
