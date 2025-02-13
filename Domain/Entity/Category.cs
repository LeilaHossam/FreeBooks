﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Category
    {
        public Guid Id { get; set; }
        [Required(ErrorMessageResourceType =typeof(Resource.ResourceData_Arb),ErrorMessageResourceName = "CategoryName")]
        [MaxLength(20,ErrorMessageResourceType =typeof(Resource.ResourceData_Arb),ErrorMessageResourceName = "MaxLength")]
        [MinLength(3,ErrorMessageResourceType =typeof(Resource.ResourceData_Arb),ErrorMessageResourceName = "MinLenght")]
        public string Name { get; set; }
        public string Description { get; set; }

        public int CurrentStatus { get; set; }
    }
}
