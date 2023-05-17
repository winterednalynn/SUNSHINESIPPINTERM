using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace SUNSHINESIPPINTERM
{
    internal class StandardMemberClass1 : MembershipInfo // Standard Membership inherits from MembershipInfo 
    {
        int _totalsum; // Total Equation 
        int _deductiontotal; // Deduction total 
        int _StandardMemberPoints; //Standard Points 

        public StandardMemberClass1(string firstName, string lastName, int StandardMemberPoints) : base(firstName, lastName)
        {
            _StandardMemberPoints = StandardMemberPoints; // Added to construction 
        }

       

        public override int AddPoints(int points) // ADD POINT METHODS 
        {
            Random rand = new Random();
            int _standardPoints = rand.Next(1000, 9999);

            _totalsum = _standardPoints += points; 

            return _standardPoints += points; 
        }

        public override int DeductPoints(int points)// ADD POINT METHODS 
        {
            Random rand = new Random();
            int _standardPoints = rand.Next(1000, 9999);

            _deductiontotal= _standardPoints -= points;

            return _standardPoints -= points; 



        }

        public override string ToString() //BASE STRING + STANDARD STRING 
        {
            return base.ToString() + "" + $" Current Points {_StandardMemberPoints}; Added Points: {_totalsum}" + ";" + $" DeductedPoints: {_deductiontotal}"; 
        }
    }
}
