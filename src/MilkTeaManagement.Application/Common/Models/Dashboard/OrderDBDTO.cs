using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkTeaManagement.Application.Common.Models.Dashboard
{
    public class OrderDBDTO
    {
        public string Id { get; set; }

        public decimal TotalPrice { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}
