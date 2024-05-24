using MilkTeaManagement.Domain.Entities;

namespace MilkTeaManagement.WindowsApp.UserControls.Home
{
    public partial class CategoryItem : UserControl
    {
        public Category? Category { get; set; } = null!;

        public CategoryItem()
        {
            InitializeComponent();
        }

        public async Task OnLoad(Category category)
        {
            Category = category;
            this.CategoryImage.ImageLocation = category.Poster;
            this.CategoryName.Text = category.Name;
        }

        public void OnLoadClickEvent(EventHandler handler)
        {
            this.Click += handler;
            foreach (Control control in Controls)
                control.Click += new EventHandler((_, e) => handler(this, e));
        }
    }
}
