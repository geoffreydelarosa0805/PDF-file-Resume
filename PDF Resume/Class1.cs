using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDF_Resume
{
    internal class Pdf
    {
        public string Name { get; set; }
        public string Position { get; set; }

        public string Objectives { get; set; }
        public string Skill1 { get; set; }
        public string Skill1Description { get; set; }
        public string Skill2 { get; set; }
        public string Skill2Description { get; set; }
        public string Skill3 { get; set; }
        public string Skill3Description { get; set; }

        public string College { get; set; }
        public string CollegeCourse { get; set; }
        public string CollegeSchoolYear { get; set; }
        public string SHS { get; set; }
        public string SHSStrand { get; set; }
        public string SHSSchoolYear { get; set; }
        public string HS { get; set; }
        public string HSSchoolYear { get; set; }

        public string Recognition1 { get; set; }
        public string Recognition2 { get; set; }
        public string Recognition3 { get; set; }
        public string Recognition4 { get; set; }

        public string Address { get; set; }
        public string ContactNumber { get; set; }
        public string EmailAddress { get; set; }
        public string Facebook { get; set; }

    }
}
