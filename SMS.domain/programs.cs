using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SMS.domain
{
    public class Programs
    {
        [Key]
        public int ProgramId { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }

    }
}
