using System;
namespace PP.Library.Models
{
    public class Client
    {
        public int Id { get; set; }
        public DateTime OpenDate { get; set; }
        public DateTime? ClosedDate { get; set; }
        public Boolean IsActive { get; set; }
        public String? Name { get; set; }
        public String? Notes { get; set; }
        public List<Project>? Projects { get; set; }

        public override string ToString()
        {
            return $"{Id}. {Name}.";

        }


        public string Display
        {
            get
            {
                return ToString();
            }
        }
    }


}