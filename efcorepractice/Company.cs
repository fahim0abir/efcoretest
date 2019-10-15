using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace efcorepractice
{
    public class Company 
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public DateTime DBServerDateTime { get; set; } = DateTime.Now;
        public int DBServerUserID { get; set; } = -6;

        public string Name { get; set; }
        public string CompanyPrefix { get; set; }
        public int ParentCompanyID { get; set; }
    }
}
