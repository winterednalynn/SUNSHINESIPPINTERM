using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUNSHINESIPPINTERM
{
    internal class GoldMembershipClass : MembershipInfo // Goldmembership class inherits from MembershipInfo 
    {
        int _totalsum; // total sum 
        int _deductiontotal; // deduction 
        int _goldPoints;  // points 
        public GoldMembershipClass(string firstName, string lastName, int goldPoints) : base(firstName, lastName) // Added to constructor 
        {
            _goldPoints = goldPoints;
        }

        public override int AddPoints(int points) // Method of Add ponits 
        {
            Random rand = new Random();
            int _goldPoints = rand.Next(1000, 9999);

            _totalsum = _goldPoints += points; 
            return _goldPoints += points;
        }

        public override int DeductPoints(int points) // Methods of add points 
        {
            Random rand = new Random();
            int _goldPoints = rand.Next(1000, 9999);

            _deductiontotal = _goldPoints -= points;
            return _goldPoints -= points;
        }
        public override string ToString() // Base string + Goldmembership string 
        {
            return base.ToString() + "" + $"Current Points {_goldPoints};  Added Points: {_totalsum}" + ";" + $" DeductedPoints: {_deductiontotal}";
        }
    }
}
