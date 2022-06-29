using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrazyBooks_Models.Models
{
    public class CalendarEvent
    {
        [Key]
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public string Description { get; set; }

        public string Title { get; set; }
    }
}
