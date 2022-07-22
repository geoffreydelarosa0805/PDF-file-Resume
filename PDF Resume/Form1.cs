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
            textBoxSkills.Text = resume.Skill1 + "\n" + resume.Skill1Description + "\n" + resume.Skill2 + "\n" + resume.Skill2Description + "\n" + resume.Skill3 + "\n" + resume.Skill3Description;
            textBoxEducBG.Text = resume.College + "\n" + resume.CollegeCourse + "\n" + resume.CollegeSchoolYear + "\n" + resume.SHS + "\n" + resume.SHSStrand + "\n" + resume.SHSSchoolYear + "\n" + resume.HS + "\n" + resume.HSSchoolYear;
            textBoxAchvmts.Text = resume.Recognition1 + "\n" + resume.Recognition2 + "\n" + resume.Recognition3 + "\n" + resume.Recognition4;
            textBoxContacts.Text = resume.Address + "\n" + resume.ContactNumber + "\n" + resume.EmailAddress + "\n" + resume.Facebook;

        }
    }
}