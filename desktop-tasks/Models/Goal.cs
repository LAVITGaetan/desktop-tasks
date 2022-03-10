using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desktop_tasks.Models
{
    public class Goal
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Comment { get; set; }
        public bool isDone { get; set; }
        public bool isArchived { get; set; }

    }
}
