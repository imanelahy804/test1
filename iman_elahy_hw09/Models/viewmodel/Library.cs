namespace iman_elahy_hw09.Models
{
    public class Library
    { 
        public int Id { get; set; }
        public string  Name { get; set; }
        public string Addres { get; set; }
        public List<Book> Listbooks { get; set; }
        public City librarycity { get; set; }
    }
}
