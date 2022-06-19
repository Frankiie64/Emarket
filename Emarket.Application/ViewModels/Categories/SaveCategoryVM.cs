﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emarket.Core.Application.ViewModels.Categories
{
    public class SaveCategoryVM
    {
        public int Id { get; set; }
        [Required (ErrorMessage ="Este campo es obligatorio")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Description { get; set; }

    }
}
