using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notecards
{
    public class Notecard
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public int TimesViewed { get; set; }
        public DateTime CreatedOn { get; set; }
        
        public Notecard(string id, string title, string description, string category, int timesViewed, DateTime createdOn)
        {
            this.Id = id;
            this.Title = title;
            this.Description = description;
            this.Category = category;
            this.TimesViewed = timesViewed;
            this.CreatedOn = createdOn;
        }
    }
}
