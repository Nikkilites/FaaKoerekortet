using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FåKoerekortet.Models;
using Microsoft.AspNetCore.Mvc;

namespace FåKoerekortet.Controllers
{
    public class DatabaseController
    {
        public List<School> GetSchools()
        {
            //Her bør være kode der henter skoler fra DB
            //SqlCommand command = new SqlCommand("SELECT * FROM TableName", conn);
            //Adding hard coded schools until Database is working
            List<School> schools = new List<School>();

            School school1 = new School("Birgittes skole", 12000);
            School school2 = new School("Henriks køreskole", 13500);
            School school3 = new School("Odenses Bedste Køreskole", 15000);
            School school4 = new School("Licence4U.dk", 14500);
            schools.Add(school1);
            schools.Add(school2);
            schools.Add(school3);
            schools.Add(school4);

            return schools;
        }
    }
}