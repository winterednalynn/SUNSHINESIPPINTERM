using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.Metrics;
using System.Diagnostics;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;
using System.Xml.Linq;

namespace SUNSHINESIPPINTERM
{
    internal static class Data // static class to collect all collection of information , Prof says this is an improtant class to implement display. 
    {
        static ObservableCollection<MembershipInfo> _members; 
        static ObservableCollection<Product> _products;
        

        static Data()
        {

            _members = new ObservableCollection<MembershipInfo>(); // Observable Collection for Membership 
            _products = new ObservableCollection<Product>();   // Observable Collection for Product 

        }

       public static ObservableCollection<MembershipInfo> Member { get => _members; } //Properties GET for Membership 
       public  static ObservableCollection<Product> Product { get => _products; } // Properties GET for PRoduct 

        public static void AddMembership(MembershipInfo members) // PSV for Adding membeer 
        {

            _members.Add(members);
            

        }
        public static void AddProducts(Product orderitems) // PSV Method for adding product 
        {
            _products.Add(orderitems); 
        }
        public static void UpdateCurrentProduct(Product updateproduct)
        {
           //Required method 

        }
        public static void UpdateCurrentMember(MembershipInfo updatemember)
        {
            //Required Method 
        }



                //        Data Class
                //STATIC Fields
                //- Observable Collection for Member
                //- Oberserable Collection for Products
                //- currentProduct = null
                //- current Member = null
            
        //STATIC Constructor
        //- Initialize both observable collections here
        //STATIC Property(All sets done by methods )
        //- Public MemberCollection { get; }
        //- Public ProductCollect { get; }
        //- Public CurrentProduct { get; }
        //- Public CurrentMember { get; }
        //        STATIC Methods
        //- Public Void AddProductToCollection(Product)
        //- Public Void AddMemberToCollection(Member)
        //- Public Void UpdateCurrentProduct(Product)
        //- Public Void UpdateCurrentMember(Member)
        //Your data class is vital to your project.All listboxes or combo boxes that need to display products or
        //members should be connected to the collections here. MAKE SURE TO USE selectionBox.ItemsSource =
        //CollectionName to make your life easier.
        //All Properties should be static, and only have getters.Adding anything to your fields should be done
        //        with methods.


    }
}
