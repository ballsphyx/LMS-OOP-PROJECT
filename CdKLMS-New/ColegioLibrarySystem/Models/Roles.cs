using ColegioLibrarySystem.GlobalEnums;
namespace ColegioLibrarySystem.Models
{
    public class Roles
    {
        public int RoleId { get; set; }
        public RoleEnum RoleName { get; set; }

        public override string ToString()
        {
            return RoleName.ToString();
        }
    }
}
