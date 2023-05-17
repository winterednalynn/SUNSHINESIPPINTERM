using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SUNSHINESIPPINTERM
{
    /// <summary>
    /// Interaction logic for Membership.xaml
    /// </summary>
    public partial class Membership : Window
    {
        ObservableCollection<MembershipInfo> members = new ObservableCollection<MembershipInfo>();  

        public Membership()
        {
            InitializeComponent();
            
        }

        private void btnAddMembers_Click(object sender, RoutedEventArgs e)
        {
            Random rand = new Random();

            

            string _memberID = rand.Next(1234, 9545).ToString();
            

            bool selectedStandard = rbStandard.IsChecked.Value;
            bool selectedGold = rbGold.IsChecked.Value;

            


            if (selectedStandard)
            {
                //USE STANDARD & GOLD CLASS TO OBTAIN INFORMATION 
                
                string firstName = txtFirstName.Text;
                string lastName = txtLastName.Text;
                int _standardPoints = rand.Next(25, 999); //Randomizing Standard Points 
                StandardMemberClass1 Standard = new StandardMemberClass1(firstName, lastName,_standardPoints);
                lbMember.Items.Add(Standard.ToString() + " Standard Member");
                members.Add(Standard);
                Data.AddMembership(Standard);
                


            }
            else if (selectedGold)
            {
          
                string firstName = txtFirstName.Text;
                string lastName = txtLastName.Text;
                int _goldPoints = rand.Next(25, 999); //Randomizing GoldPoints 
                GoldMembershipClass GoldMember = new GoldMembershipClass(firstName, lastName,_goldPoints);
                lbMember.Items.Add(GoldMember.ToString() + " Gold Member");
                members.Add(GoldMember); //Added Items for Gold , to MembershipInfo 
                Data.AddMembership(GoldMember); // ADDED INFO INTO DATA CLASS
                
            }
        }
    }
}
