using System.ComponentModel.DataAnnotations;

namespace Hamza_assignment.Models
{
    public class customerMessage
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public int phone { get; set; }
        public string address { get; set; }
    }
}
