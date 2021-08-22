using System;
namespace Api.Domain.Models
{
    public class EntriesAmountModel : BaseModel
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _descriptionValue;
        public string DescriptionValue
        {
            get { return _descriptionValue; }
            set { _descriptionValue = value; }
        }

        private string _typeEntry;
        public string TypeEntry
        {
            get { return _typeEntry; }
            set { _typeEntry = value; }
        }

        private double _amount;
        public double Amount
        {
            get { return _amount; }
            set { _amount = value; }
        }

        private DateTime _dateLaunch;
        public DateTime DateLaunch
        {
            get { return _dateLaunch; }
            set { _dateLaunch = value; }
        }

        private Guid _categoryId;
        public Guid CategoryId
        {
            get { return _categoryId; }
            set { _categoryId = value; }
        }  
       
    }
}
