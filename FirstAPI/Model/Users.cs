using System.ComponenteModel.DataAnnotations;
using System.ComponenteModel.DataAnnotations.Schema;

namespace FirstAPI.Model
{
    [Table("users")]
    public class Users
    {
        [Key]
        public int id {  get; set; }
        public string name { get; set; }
        public int age { get; set; }

        public Users(int id, string name, int age)
        {
            this.id = id ?? throw new ArgumentNullException(nameof(name));
            this.name = name;
            this.age = age;
        }
    }
}
