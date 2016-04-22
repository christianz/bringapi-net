using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BringApi.Net
{
    public class BringProduct
    {
        public string ProductId { get; set; }
        public int ProductCodeInProductionSystem { get; set; }
        public BringPrice Price { get; set; }
    }
}
