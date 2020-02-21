using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance_Repo
{
    public enum ClaimType { Car = 1, Home, Theft }
    public class ClaimContents
    {
        public int ID { get; set; }
        public ClaimType TypeOfClaim { get; set; }
        public string Description { get; set; }
        public int ClaimAmount { get; set; }
        public DateTime DateOfIncident { get; set; }
        public DateTime DateOfClaim { get; set; }

        public bool IsValid
        {
            get
            {
                TimeSpan daysSince = DateOfClaim - DateOfIncident;
                double daysDouble = daysSince.Days;
                int days = Convert.ToInt32(Math.Floor(daysDouble));

                if (days <= 30)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public ClaimContents () { }
        public ClaimContents(int id, ClaimType typeOfClaim, string description, int claimAmount, DateTime dateOfIncident, DateTime dateOfClaim, bool isValid)
        {
            ID = id;
            TypeOfClaim = typeOfClaim;
            Description = description;
            ClaimAmount = claimAmount;
            DateOfIncident = dateOfIncident;
            DateOfClaim = dateOfClaim;
            //IsValid = isValid;
        }
    }

}
