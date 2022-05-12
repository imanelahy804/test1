namespace iman_elahy_hw09.Models
{
    public class Member
    {
        public int ID{ get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string NationalCode { get; set; }
        public int levelindex { get; set; }
        public enum Level { Gold=0, silver=1, Bronze=2 }
        public int PhoneNumber { get; set; }
        public int Genderindex { get; set; }
        public enum Gender
        {
            Male=0,
            Famale=1,
        }
       
        public int libraryId { get; set; }



    }
}
