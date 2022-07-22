using Newtonsoft.Json;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace PDF_Resume
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonReadFile_Click(object sender, EventArgs e)
        {
            var JsonFile = @"C:\Users\HP\Documents\Visual Studio 2022\PDF Resume\My Resume\DELA-ROSA_GEOFFREY.json";
            String JsonInfo = File.ReadAllText(JsonFile);
            Pdf resume = JsonConvert.DeserializeObject<Pdf>(JsonInfo);

            textBoxName.Text = resume.Name;
            textBoxPosition.Text = resume.Position;
            textBoxObjectives.Text = resume.Objective;
            textBoxSkills.Text = resume.Skill1 + "\r\n" + resume.Skill1Description + "\r\n" + resume.Skill2 + "\r\n" + resume.Skill2Description + "\r\n" + resume.Skill3 + "\r\n" + resume.Skill3Description;
            textBoxEducBG.Text = resume.College + "\r\n" + resume.CollegeCourse + "\r\n" + resume.CollegeSchoolYear + "\r\n" + resume.SHS + "\r\n" + resume.SHSStrand + "\r\n" + resume.SHSSchoolYear + "\r\n" + resume.HS + "\r\n" + resume.HSSchoolYear;
            textBoxAchvmts.Text = resume.Recognition1 + "\r\n" + resume.Recognition2 + "\r\n" + resume.Recognition3 + "\r\n" + resume.Recognition4;
            textBoxContacts.Text = resume.Address + "\r\n" + resume.ContactNumber + "\r\n" + resume.EmailAddress + "\r\n" + resume.Facebook;

        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            Document document = new Document(iTextSharp.text.PageSize.LETTER, 60, 60, 90, 60);
            PdfWriter write = PdfWriter.GetInstance(document, new FileStream(@"C:\Users\HP\Documents\Visual Studio 2022\PDF Resume\My Resume\DELA-ROSA_GEOFFREY.pdf", FileMode.Create));
            document.Open();

            iTextSharp.text.Image PNG = iTextSharp.text.Image.GetInstance(@"C:\Users\HP\Documents\Visual Studio 2022\PDF Resume\My Resume\DELA-ROSA.jpg");
            PNG.ScalePercent(5f);
            PNG.SetAbsolutePosition(document.PageSize.Width - 110f - 72f, document.PageSize.Height - 0f - 195f);
            document.Add(PNG);

            Paragraph name = new Paragraph(textBoxName.Text);
            name.Font.Size = 20f;
            name.IndentationLeft = 0f;
            name.Font.SetStyle("bold");
 
            Paragraph potn = new Paragraph(textBoxPosition.Text);

            Paragraph spaceA = new Paragraph("--------------------------------------------------------------------------------");
            Paragraph spaceB = new Paragraph(" ");
            Paragraph objtTitle = new Paragraph("Objectives");
            objtTitle.Font.Size = 15f;
            objtTitle.IndentationLeft = 0f;
            objtTitle.Font.SetStyle("bold");

            Paragraph spaceC = new Paragraph("---------------------------------------------------------------------------------------------------------------------------");
            Paragraph objt = new Paragraph(textBoxObjectives.Text);
            Paragraph SkillsHeading = new Paragraph("Skills");
            SkillsHeading.Font.Size = 15f;
            SkillsHeading.IndentationLeft = 0f;
            SkillsHeading.Font.SetStyle("bold");

            Paragraph spaceD = new Paragraph("---------------------------------------------------------------------------------------------------------------------------");
            Paragraph skills = new Paragraph(textBoxSkills.Text);
            Paragraph EducBG = new Paragraph("Educational Background");
            EducBG.Font.Size = 15f;
            EducBG.IndentationLeft = 0f;
            EducBG.Font.SetStyle("bold");

            Paragraph spaceE = new Paragraph("---------------------------------------------------------------------------------------------------------------------------");
            Paragraph EBG = new Paragraph(textBoxEducBG.Text);
            Paragraph Achvmt = new Paragraph("Recognitions");
            Achvmt.Font.Size = 15f;
            Achvmt.IndentationLeft = 0f;
            Achvmt.Font.SetStyle("bold");

            Paragraph spaceF = new Paragraph("---------------------------------------------------------------------------------------------------------------------------");
            Paragraph Recog = new Paragraph(textBoxAchvmts.Text);
            Paragraph Cont = new Paragraph("Contacts");
            Cont.Font.Size = 15f;
            Cont.IndentationLeft = 0f;
            Cont.Font.SetStyle("bold");
            Paragraph Contacts = new Paragraph(textBoxContacts.Text);

                       
            document.Add(name);
            document.Add(potn);
            document.Add(spaceA);
            document.Add(spaceB);
            document.Add(objtTitle);
            document.Add(objt);
            document.Add(spaceC);
            document.Add(SkillsHeading);
            document.Add(skills);
            document.Add(spaceD);
            document.Add(EducBG);
            document.Add(EBG);
            document.Add(spaceE);
            document.Add(Achvmt);
            document.Add(Recog);
            document.Add(spaceF);
            document.Add(Cont);
            document.Add(Contacts);       

            document.Close();

            MessageBox.Show("The Resume is Successfully Converted");
        }
    }
}