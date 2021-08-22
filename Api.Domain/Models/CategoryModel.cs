using System;
namespace Api.Domain.Models
{
    public class CategoryModel : BaseModel
    {
        private string _description;
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        private string _category;
        public string Category
        {
            get { return _category; }
            set { _category = value; }
        }
    }
}
