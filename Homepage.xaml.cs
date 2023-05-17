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
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SUNSHINESIPPINTERM
{
    /// <summary>
    /// Interaction logic for Homepage.xaml
    /// </summary>
    public partial class Homepage : Window
    {
        ObservableCollection<MembershipInfo> _membershipList;
        ObservableCollection<Product> _productsList;
        FlowDocument flowDocument = new FlowDocument();
        public Homepage()
        {
            InitializeComponent();

            

            //RUN DISPLAY HOMEPAGE 

            rtbHPDisplay.Document = flowDocument;
            Paragraph paragraph = new Paragraph();
            Run run = new Run("☼Connect your membership to add or use points!\r\n " +
                " -------------------------\r\n Not A Member? \r\n " +
                "Sign up with us today! \r\n --------------------\r\n" + "Sip, Relax, and Love Today ♥");
            paragraph.Inlines.Add(run);
            flowDocument.Blocks.Add(paragraph);
            rtbHPDisplay.FontSize = 14; 
            rtbHPDisplay.FontWeight = FontWeights.Bold;
            rtbHPDisplay.Background = new SolidColorBrush(Colors.Beige);
            rtbHPDisplay.Foreground = new SolidColorBrush(Colors.Navy);


            //CB MEMBERS TO PROMPT HOMEPAGE CB MEMBERS (TOP RIGHT CORNER) 
            cbMembers.ItemsSource = Data.Member;
            cbMembers.SelectedItem = lbPurchase.ItemsSource = Data.Member;

            //Basket List , Addeed products from Product Screen. 
            lbBasket.ItemsSource = Data.Product;

        }

        private void btnAddMembership_Click(object sender, RoutedEventArgs e) //MEMBERSHIP BUTTON , OPENS MEMBERSHIP WINDOW TO PROMPT MEMBERSHIP DETAILS 
        {
            Membership membershippage=new Membership();
            membershippage.Show();
        }

        private void btnAddtoBasket_Click(object sender, RoutedEventArgs e) // ADD BASKET EVENT , SHOWS NEW WINDOW W/ MENU OPTIONS 
        {
            Products addProducts = new Products();
            addProducts.Show(); 
        }

        private void btnPurchase_Click(object sender, RoutedEventArgs e) //PURCHASE BUTTON PROMPTS DATA. PRODUCT INFO IN THE BOX ABOVE USE POINTS 
        {
            lbPurchase.ItemsSource = Data.Product;
           
            
        }

        private void btnUsePoints_Click(object sender, RoutedEventArgs e)
        {
            // The goal for this button was to implement an addition action between the purchase points and member point. 

            MembershipInfo chosenMember = Data.Member[0]; 
            chosenMember.AddPoints(50); 


            
            
        }
    }
}
