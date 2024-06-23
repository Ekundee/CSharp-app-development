using System.ComponentModel.DataAnnotations;

namespace migration_tester.Model
{
    public class Test
    {
        [Key]
        public string one { get; set; }
        public string two { get; set; }
        public string three { get; set; }
    }
}
