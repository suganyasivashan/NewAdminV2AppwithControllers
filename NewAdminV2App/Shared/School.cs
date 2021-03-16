using System.ComponentModel.DataAnnotations;

namespace NewAdminV2App.Shared
{
    public class School
    {
        [Key]
        public int ID { get; set; }
        public string SchoolName { get; set; }
    }
}
