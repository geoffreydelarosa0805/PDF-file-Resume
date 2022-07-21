using System.Text.Json;
using PdfSharp;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System.Diagnostics;
using System.Text;

namespace PDF_Resume
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            String pdf_file = (@"C: \Users\HP\Documents\Outputs\MyResume.json");
            String Json = File.ReadAllText(pdf_file);
            Pdf resume = JsonSerializer.Deserialize<Pdf>(Json)!;

            String Name = resume.Name;
            String Position = resume.Position;

            String Objectives = resume.Objectives;
            String Skill1 = resume.Skill1;
            String Skill1Description = resume.Skill1Description;
            String Skill2 = resume.Skill2;
            String Skill2Description = resume.Skill2Description;
            String Skill3 = resume.Skill3;
            String Skill3Description = resume.Skill3Description;

            String College = resume.College;
            String CollegeCourse = resume.CollegeCourse;
            String CollegeSchoolYear = resume.CollegeSchoolYear;
            String SHS = resume.SHS;
            String SHSStrand = resume.SHSStrand;
            String SHSSchoolYear = resume.SHSSchoolYear;
            String HS = resume.HS;
            String HSSchoolYear = resume.HSSchoolYear;

            String Recognition1 = resume.Recognition1;
            String Recognition2 = resume.Recognition2;
            String Recognition3 = resume.Recognition3;
            String Recognition4 = resume.Recognition4;

            String Address = resume.Address;
            String ContactNumber = resume.ContactNumber;
            String EmailAddress = resume.EmailAddress;
            String Facebook = resume.Facebook;

        }
    }
}