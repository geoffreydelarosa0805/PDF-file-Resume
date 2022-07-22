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

            // Objectives
            String Objectives = resume.Objectives;

            // Skills
            String Skill1 = resume.Skill1;
            String Skill1Description = resume.Skill1Description;
            String Skill2 = resume.Skill2;
            String Skill2Description = resume.Skill2Description;
            String Skill3 = resume.Skill3;
            String Skill3Description = resume.Skill3Description;

            // Educational Background
            String College = resume.College;
            String CollegeCourse = resume.CollegeCourse;
            String CollegeSchoolYear = resume.CollegeSchoolYear;
            String SHS = resume.SHS;
            String SHSStrand = resume.SHSStrand;
            String SHSSchoolYear = resume.SHSSchoolYear;
            String HS = resume.HS;
            String HSSchoolYear = resume.HSSchoolYear;

            // Achievements
            String Recognition1 = resume.Recognition1;
            String Recognition2 = resume.Recognition2;
            String Recognition3 = resume.Recognition3;
            String Recognition4 = resume.Recognition4;

            // Contacts
            String Address = resume.Address;
            String ContactNumber = resume.ContactNumber;
            String EmailAddress = resume.EmailAddress;
            String Facebook = resume.Facebook;

            using (SaveFileDialog save = new SaveFileDialog())
            {
                save.InitialDirectory = (@"C: \Users\HP\Documents\Outputs\Resume");
                save.FileName = Name + ".pdf";
                save.Filter = "PDF|*.pdf";

                if (save.ShowDialog() == DialogResult.OK)
                {
                    PdfDocument pdfdocument = new PdfDocument();
                    PdfPage pagedocument = pdfdocument.AddPage();
                    pdfdocument.Info.Title = "APPLICATION RESUME";

                    XGraphics grp = XGraphics.FromPdfPage(pagedocument);

                    XFont afont = new XFont("Cambria", 30, XFontStyle.Bold);
                    XFont bfont = new XFont("Bookman Old Style", 20, XFontStyle.Bold);
                    XFont cfont = new XFont("Cambria", 12, XFontStyle.Regular);

                    int down = 150;
                    int left = 50;

                    {
                        String picture = (@"C: \Users\HP\Pictures\Saved Pictures\Dela-Rosa.jpg");
                        XImage image = XImage.FromFile(picture);


                        grp.DrawString(Name, afont, XBrushes.Black, new XRect(0, 0, pagedocument.Width, pagedocument.Height), XStringFormats.Center);

                    }

                    pdfdocument.Save(save.FileName);
                }
            }
        }
    }
}