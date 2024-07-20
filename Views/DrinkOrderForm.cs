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
                dt.Rows.Add(node.Name, node.Price, node.Ingredients.Coffee, node.Ingredients.Milk, node.Ingredients.Sugar);
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

            return new DrinkModel(
                drinkNode.SelectSingleNode("Name")?.InnerText!,
                double.Parse(drinkNode.SelectSingleNode("Price")?.InnerText ?? "0"),
                double.Parse(ingredients.SelectSingleNode("Coffee")?.InnerText ?? "0"),
                ingredients.SelectSingleNode("Milk")?.InnerText!,
                double.Parse(ingredients.SelectSingleNode("Sugar")?.InnerText ?? "0")
            );
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
        private void button_add_Click(object sender, EventArgs e)
        {
            // get all inputs
            string name = textBox_drinkName.Text;
            string price = textbox_price.Text;
            string coffee = comboBox_coffee.Text;
            string milk = comboBox_milk.Text;
            string sugar = comboBox_sugar.Text;

            if (IsInvalidValues(name, price, coffee, milk, sugar))
            {
                MessageBox.Show("Missing values");
                return;
            }

            DrinkModel drinkModel = new DrinkModel(
                name,
                double.Parse(price),
                double.Parse(coffee),
                milk,
                double.Parse(sugar));

            xmlDrinkService.CreateNodeFromModel<DrinkModel>(drinkModel);
            InitializeDataGrid(LoadDrinksFromXML());
        }

        private XmlNode CreateDrinkNodeFromModel(DrinkModel drink)
        {
            // Create the main Drink element
            XmlNode drinkNode = xmlDrinkService.CreateNode("Drink");

            // Create and append the Name element
            XmlNode nameNode = xmlDrinkService.CreateNode("Name", drink.Name);
            drinkNode.AppendChild(nameNode);

            // Create and append the Price element
            XmlNode priceNode = xmlDrinkService.CreateNode("Price", drink.Price.ToString());
            drinkNode.AppendChild(priceNode);

            // Create the Ingredients element
            XmlNode ingredientsNode = xmlDrinkService.CreateNode("Ingredients");

            // Create and append the Coffee element
            XmlNode coffeeNode = xmlDrinkService.CreateNode("Coffee", drink.Ingredients.Coffee.ToString());
            ingredientsNode.AppendChild(coffeeNode);

            // Create and append the Sugar element
            XmlNode sugarNode = xmlDrinkService.CreateNode("Sugar", drink.Ingredients.Sugar.ToString());
            ingredientsNode.AppendChild(sugarNode);

            // Create and append the Milk element
            XmlNode milkNode = xmlDrinkService.CreateNode("Milk", drink.Ingredients.Milk);
            ingredientsNode.AppendChild(milkNode);

            // Append the Ingredients element to the Drink element
            drinkNode.AppendChild(ingredientsNode);

            return drinkNode;
        }

        private bool IsInvalidValues(params string[] values) =>
           values.Any(string.IsNullOrWhiteSpace);
    }
}
