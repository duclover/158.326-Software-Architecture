using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial7Pizza
{
    public partial class HomeOrder : Form
    {
        private PizzaStore _store;
        private List<string> _pizzaList;
        private SimplePizzaFactory _factory;
        private Pizza _pizza;


        public HomeOrder()
        {
            InitializeComponent();
        }

        private void ShowPizzaList()
        {
            _pizzaList = new List<string>
            {
                "ham",
                "cheese",
                "funghi"
            };
            for (int i = 0; i < 3; ++i)
            {
                lstPizza.Items.Insert(i, _pizzaList[i]);
            }
        }


        private void HomeOrder_Load(object sender, EventArgs e)
        {
            ShowPizzaList();
            _factory = new SimplePizzaFactory();
            _store = new PizzaStore(_factory);
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            _pizza = _store.OrderPizza(lstPizza.GetItemText(lstPizza.SelectedItem));
            lblOrders.Text = _pizza.Prepare() + "\n" + _pizza.Bake() + "\n" + _pizza.Box();
        }
    }
}
