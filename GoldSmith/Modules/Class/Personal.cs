using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldSmith.Modules.Class
{
    public class Personal
    {
        private int personalId;
        private string personalName;
        private string personalSurname;
        private string personalNationalNumber;
        private string personalNumber;
        private string personalAddress;
        private string personalEmail;
        private string personalTitle;
        private string personalNickName;
        private string personalPassword;
        private string personalAutID;

        public int PersonalId { get => personalId; set => personalId = value; }
        public string PersonalName { get => personalName; set => personalName = value; }
        public string PersonalSurname { get => personalSurname; set => personalSurname = value; }
        public string PersonalNationalNumber { get => personalNationalNumber; set => personalNationalNumber = value; }
        public string PersonalNumber { get => personalNumber; set => personalNumber = value; }
        public string PersonalAddress { get => personalAddress; set => personalAddress = value; }
        public string PersonalEmail { get => personalEmail; set => personalEmail = value; }
        public string PersonalTitle { get => personalTitle; set => personalTitle = value; }
        public string PersonalNickName { get => personalNickName; set => personalNickName = value; }
        public string PersonalPassword { get => personalPassword; set => personalPassword = value; }
        public string PersonalAutID { get => personalAutID; set => personalAutID = value; }
    }
}
