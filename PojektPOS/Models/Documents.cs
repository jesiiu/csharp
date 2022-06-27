using PojektPOS.Extensions;
using System.ComponentModel.DataAnnotations;

namespace PojektPOS.Models
{
    public class Documents
    {
        public int Id { get; set; }
        public string Type { get; set; }
        [CustomValidation(typeof(DateValidator), "ValidationResultDate")]
        public DateTime InsertDate { get; set; }
        public string Description { get; set; }
        [Range (1, int.MaxValue)]
        public int TotalPrice { get; set; }
        [Range(1, int.MaxValue)]
        public int TotalCount { get; set; }
        public string Payment { get; set; }
        public string User { get; set; }

    }
}

