using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkTeaManagement.Application.Common.Models.Categories
{
    public class CategoriesDTO
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Poster { get; set; }

        public string CreatorId { get; set; }

        public string Creator { get; set; }

        public string CreatedDate { get; set; }
    }
}
