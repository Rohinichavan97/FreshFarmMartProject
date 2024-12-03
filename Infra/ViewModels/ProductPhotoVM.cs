using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.ViewModels
{
    public class ProductPhotoVM
    {
        public long ProductID { get; set; }
        public IFormFile NewPhoto { get; set; }
        public List<ProductPhotoVM> ExistingPhotos { get; set; }
        public long ProductPhotoID { get; set; }
        public string PhotoPath { get; set; }
    }
}
