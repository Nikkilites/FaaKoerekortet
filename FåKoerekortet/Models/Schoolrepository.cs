using FåKoerekortet.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FåKoerekortet.Models
{
    public class Schoolrepository
    {
        public List<School> Schools { get; set; }

        public Schoolrepository(List<School> schools)
        {
            Schools = schools;
        }
    }
}
