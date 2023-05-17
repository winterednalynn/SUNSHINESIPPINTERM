using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SUNSHINESIPPINTERM
{
    /// <summary>
    /// Interaction logic for Products.xaml
    /// </summary>
    public partial class Products : Window
    {
        ObservableCollection<Product> _productAdd = new ObservableCollection<Product>(); //OBSERVABLE COLLECTION FOR PRODUCT 


        public Products()
        {
            InitializeComponent();
            SizePopulationCB(); 
        }

        public void SizePopulationCB() //SIZE POPULATION METHOD 
        {
            cbSize.Items.Add("Short");
            cbSize.Items.Add("Tall");
            cbSize.Items.Add("Grande");
            cbSize.Items.Add("Venti");
            cbSize.Items.Add("Trenta");
            cbSize.SelectedIndex = 0;

        }

        private void btnCoffee_Click(object sender, RoutedEventArgs e) //BUTTON EVEN FOR COFFEE 
        {

            string productName = txtProductName.Text;
            string price = txtPrice.Text; 
            double productPrice=double.Parse(price);
            string points = txtPoints.Text; 
            int productPoints=int.Parse(points);
            string roastortea = txtRoastTea.Text;

            string Size = cbSize.SelectedValue.ToString();

            Coffee coffee = new Coffee(productName, productPrice, productPoints, Size, roastortea); // FILLING CONSTRUCTOR
            lbProducts.Items.Add(coffee.ToString()  + " " + ",  Cup Size: " + cbSize.SelectedItem);
            _productAdd.Add(coffee);
            Data.AddProducts(coffee); //ADDING INPUT INFORMATION TO DATE CLASS



        }

        private void btnTea_Click(object sender, RoutedEventArgs e) // BUTTON EVENT FOR TEA 
        {
            string productName = txtProductName.Text;
            string price = txtPrice.Text;
            double productPrice = double.Parse(price);
            string points = txtPoints.Text;
            int productPoints = int.Parse(points);
            string roastortea = txtRoastTea.Text;

            string Size = cbSize.SelectedValue.ToString();

            Tea tea = new Tea(productName, productPrice, productPoints,Size, roastortea);
            lbProducts.Items.Add(tea.ToString() + " " + ", Cup Size: " +cbSize.SelectedItem);
            _productAdd.Add(tea);
            Data.AddProducts(tea); //ADDING INPUT INFORMATION TO DATE CLASS

        }

        private void btnBreakfast_Click(object sender, RoutedEventArgs e) //BUTTON EVENT FOR BREAKFAST 
        {
            string productName = txtProductName.Text;
            string price = txtPrice.Text;
            double productPrice = double.Parse(price);
            string points = txtPoints.Text;
            int productPoints = int.Parse(points);


            bool isHeated = chbHotDrink.IsChecked.Value;

            if (isHeated)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
 
            Breakfast breakfast = new Breakfast(productName, productPrice, productPoints,isHeated);
            lbProducts.Items.Add(breakfast.ToString()); 
            _productAdd.Add(breakfast); 
            Data.AddProducts(breakfast); //ADDING INPUT INFORMATION TO DATE CLASS


        }

        private void btnLunch_Click(object sender, RoutedEventArgs e) //BUTTON EVENT FOR LUNCH 
        {
            string productName = txtProductName.Text;
            string price = txtPrice.Text;
            double productPrice = double.Parse(price);
            string points = txtPoints.Text;
            int productPoints = int.Parse(points);


            bool isCombo = chbDairyCombo.IsChecked.Value;

            if (isCombo)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }

            Lunch lunch = new Lunch(productName, productPrice, productPoints, isCombo);
            lbProducts.Items.Add(lunch.ToString());
            _productAdd.Add(lunch);
            Data.AddProducts(lunch); //ADDING INPUT INFORMATION TO DATE CLASS

        }

        private void btnTumbler_Click(object sender, RoutedEventArgs e) //BUTTON EVENT FOR TUMBLER 
        {
            string productName = txtProductName.Text;
            string price = txtPrice.Text;
            double productPrice = double.Parse(price);
            string points = txtPoints.Text;
            int productPoints = int.Parse(points);
            string colorOftumbler = txtColorStyle.Text;

            Tumblers tumblers = new Tumblers(productName, productPrice, productPoints, colorOftumbler);
            lbProducts.Items.Add(tumblers.ToString());
            _productAdd.Add(tumblers);
            Data.AddProducts(tumblers);  //ADDING INPUT INFORMATION TO DATE CLASS
        }

        private void btnMug_Click(object sender, RoutedEventArgs e) // BUTTON EVENT FOR MUG 
        {
            string productName = txtProductName.Text;
            string price = txtPrice.Text;
            double productPrice = double.Parse(price);
            string points = txtPoints.Text;
            int productPoints = int.Parse(points);
            string styleOfmug = txtColorStyle.Text;

            Mugs mug = new Mugs(productName, productPrice, productPoints, styleOfmug);
            lbProducts.Items.Add(mug.ToString());
            _productAdd.Add(mug);
            Data.AddProducts(mug); //ADDING INPUT INFORMATION TO DATE CLASS
        }

        private void btnGiftCard_Click(object sender, RoutedEventArgs e) //BUTTON EVENT FOR GIFT CARD 
        {
            string productName = txtProductName.Text;
            string price = txtPrice.Text;
            double productPrice = double.Parse(price);
            string points = txtPoints.Text;
            int productPoints = int.Parse(points);
            string amount = txtgiftCardAmount.Text;
            double giftCardAmount = double.Parse(amount); 
            

            GiftCard giftCard = new GiftCard(productName, productPrice, productPoints, giftCardAmount);
            lbProducts.Items.Add(giftCard.ToString());
            _productAdd.Add(giftCard);
            Data.AddProducts(giftCard); //ADDING INPUT INFORMATION TO DATE CLASS

        }

       
    }
}
