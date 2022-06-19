using Emarket.Core.Application.ViewModels.Categories;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emarket.Core.Application.ViewModels.Ad
{
    public class SaveAdsVM
    {

        public int Id { get; set; }
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Name { get; set; }
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Description { get; set; }
        public List<string> Urls { get; set; }
        [Range(1, double.MaxValue, ErrorMessage = "Este campo es obligatorio")]
        public double Price { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Este campo es obligatorio")]
        public int CategoryId { get; set; }
        public List<CategoryVM> Categories { get; set; }
        [DataType(DataType.Upload, ErrorMessage = "Este campo es obligatorio")]
        public List<IFormFile> File{ get; set; }
    }
}
