using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkTeaManagement.Application.Common.Models.Filter
{
    public class FilterInCategoriesPage
    {
        private string _searchText = string.Empty;
        public string? SearchText
        {
            get => _searchText;
            set { _searchText = value ?? ""; }
        }

        private int _filterComboboxSelectedIndex = 0;
        public int FilterComboboxSelectedIndex
        {
            get => _filterComboboxSelectedIndex;
            set { _filterComboboxSelectedIndex = value; }
        }
    }
}
