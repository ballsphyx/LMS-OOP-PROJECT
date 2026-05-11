using ColegioLibrarySystem.GlobalEnums;
using System.Xml.Linq;

namespace ColegioLibrarySystem.Models
{
    public class Category
    {
        public int CatId { get; set; }
        public CategoryEnum CatName { get; set; }
        public override string ToString()
        {
            return CatName.ToString();
        }
    }
}
