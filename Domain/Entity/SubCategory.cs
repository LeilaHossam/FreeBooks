using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class SubCategory
    {
        public Guid Id { get; set; }
        [Required(ErrorMessageResourceType = typeof(Resource.ResourceData_Arb), ErrorMessageResourceName = "SubCategoryName")]
        [MaxLength(20, ErrorMessageResourceType = typeof(Resource.ResourceData_Arb), ErrorMessageResourceName = "MaxLength")]
        [MinLength(3, ErrorMessageResourceType = typeof(Resource.ResourceData_Arb), ErrorMessageResourceName = "MinLenght")]
        public string Name { get; set; }
        public Guid CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public Category Category { get; set; }
        public int CurrentStatus { get; set; }
    }
}
