using FileHandler.Models;
using FileHandler.Services;
using ReaLTaiizor.Forms;
using System.Data;
using System.Xml;

namespace FileHandler.Views
{
    public partial class DrinkOrderForm : MaterialForm
    {
        private XMLService xmlConfigService = new XMLService("Configurations", "drinks-config.xml");
        private XMLService xmlDrinkService = new XMLService("Data", "drinks.xml");
        private XmlDocument configDoc;
        private DataTable drinkOrders = new DataTable();
        public DrinkOrderForm()
        {
            InitializeComponent();
            configDoc = xmlConfigService.ReadXML()!;
            if (configDoc == null)
            {
                MessageBox.Show("Config file not found.");
                throw new Exception("Config file not found.");
            }
            InitializeFormData();
            InitializeDataGrid(LoadDrinksFromXML());
        }

        private DataTable LoadDrinksFromXML()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Price", typeof(double));
            dt.Columns.Add("Coffee", typeof(double));
            dt.Columns.Add("Milk", typeof(string));
            dt.Columns.Add("Sugar", typeof(double));

            XmlNode root = xmlDrinkService.GetNodeByName("Drinks")!;
            List<DrinkModel> nodes = xmlDrinkService.ToModel("Drinks", GetDrinkFromXMLNode)!;

            foreach (var node in nodes)
            {
                dt.Rows.Add(node.Name, node.Price, node.Coffee, node.Milk, node.Sugar);
            }

            return dt;
        }

        private void InitializeDataGrid(DataTable dt) =>
            dataGridView_drinks.DataSource = dt;


        private DrinkModel GetDrinkFromXMLNode(XmlNode drinkNode)
        {
            XmlNode ingredients = drinkNode.SelectSingleNode("Ingredients")!;
            if (drinkNode == null || ingredients == null)
            {
                throw new Exception("Invalid XML structure.");
            }

            return new DrinkModel()
            {
                Name = drinkNode.SelectSingleNode("Name")?.InnerText!,
                Price = double.Parse(drinkNode.SelectSingleNode("Price")?.InnerText ?? "0"),
                Coffee = double.Parse(ingredients.SelectSingleNode("Coffee")?.InnerText ?? "0"),
                Milk = ingredients.SelectSingleNode("Milk")?.InnerText!,
                Sugar = double.Parse(ingredients.SelectSingleNode("Sugar")?.InnerText ?? "0")
            };
        }


        private void InitializeFormData()
        {
            // read the config file and populate the form
            // get the root element
            XmlNode root = configDoc.DocumentElement!;
            // get the child nodes
            XmlNodeList drinkNodes = root.ChildNodes;

            List<double> coffeeOptions = xmlConfigService.GetOptions("Config.Coffee", text => double.Parse(text));
            List<double> sugarOptions = xmlConfigService.GetOptions("Config.Sugar", text => double.Parse(text));
            List<string> milkOptions = xmlConfigService.GetOptions("Config.Milk", text => text);

            // populate the form
            comboBox_coffee.DataSource = coffeeOptions;
            comboBox_milk.DataSource = milkOptions;
            comboBox_sugar.DataSource = sugarOptions;
        }

        private void textbox_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox)!.Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// add a drink order to the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label_add_Click(object sender, EventArgs e)
        {

        }
    }
}
