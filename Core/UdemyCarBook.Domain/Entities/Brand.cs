using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCarBook.Domain.Entities
{
    public class Brand
    {
        //marka 
        public int BrandID { get; set; }
        public string Name { get; set; }

        public List<Car> Cars { get; set; }
    }
}
