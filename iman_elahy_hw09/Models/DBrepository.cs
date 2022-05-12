using iman_elahy_hw09.Models.viewmodel;
using iman_elahy_hw09.data;
namespace iman_elahy_hw09.Models
{
    public class DBrepository
    {
        public static List<listlibraryvm>? listlibrary()
        {
            memberDBContext memberDB = new();
            var result = (from p in memberDB.members
                          join c in memberDB.libraries on p.libraryId equals c.Id
                          join b in memberDB.books on p.ID equals b.Memberid
                          select new listlibraryvm
                          {
                              LibraryName = c.Name,
                              CityAndAddres = c.librarycity.Name + "," + c.Addres,
                              memberName = p.Name,
                              ID = p.ID,
                              bookname = b.Name


                          }).ToList();
            return result;
        }
        public static List<listlibraryvm>? searchDB(listlibraryvm searchlist)
        {
            memberDBContext memberDB = new();
            var result = (from p in memberDB.members
                          join c in memberDB.libraries on p.libraryId equals c.Id 
                          join b in memberDB.books on p.ID equals b.Memberid
                          where p.Name==searchlist.memberName || c.Name==searchlist.LibraryName||b.Name==searchlist.bookname
                          select new listlibraryvm
                          {
                              LibraryName = c.Name,
                              CityAndAddres = c.librarycity.Name + "," + c.Addres,
                              memberName = p.Name,
                              ID = p.ID,
                              bookname = b.Name


                          }).ToList();
            return result;

        }
    }
}
