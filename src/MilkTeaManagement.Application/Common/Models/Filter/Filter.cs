namespace MilkTeaManagement.Application.Common.Models.Filter
{
    public class Filter
    {
        private string _search = string.Empty;
        public string? Search
        {
            get => _search;
            set { _search = value ?? ""; }
        }

        private string _categoryId = string.Empty;
        public string CategoryId
        {
            get => _categoryId;
            set { _categoryId = value ?? ""; }
        }

    }
}
