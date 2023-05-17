using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUNSHINESIPPINTERM
{
    abstract class MembershipInfo // Abstract Class 
    {
       //FIELDS 
        string _firstName;
        string _lastName;
        string _memberID;
        int _points;
        DateTime _memberSince;
        ObservableCollection<Products> _previousTransaction; // for Transactin HX 
        

        public MembershipInfo(string firstName, string lastName)
        {
            // CONSTRUCTOR of First naem & last name 

            Random random = new Random();
            _memberID = random.Next(100000, 999999).ToString();
            _points = 0; 
            _firstName = firstName;
            _lastName = lastName;
            _memberSince = DateTime.Now;   
            _previousTransaction = new ObservableCollection<Products>();
            
            

            
        }

        public ObservableCollection<Products> PreviousTransaction { get => _previousTransaction; } // Properties GET previous transaction 

        public abstract int DeductPoints(int points); //Abstract method of Add / Deduct 

        public abstract int AddPoints(int points); //Abstract method of Add / Deduct 



        public override string ToString()
        {
            return $"★ Member ID: {_memberID} - {_firstName} {_lastName} - Current Points: {_points}  - Member Since: {_memberSince} \n";
        }
    }
}
