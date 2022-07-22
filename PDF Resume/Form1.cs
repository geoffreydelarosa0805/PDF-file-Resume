using Newtonsoft.Json;

namespace PDF_Resume
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonConvert_Click(object sender, EventArgs e)
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
    }
}