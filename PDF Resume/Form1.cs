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
            var JsonFile = @"C:\Users\HP\Documents\My Resume";
            String JsonInfo = File.ReadAllText(JsonFile);
            Pdf resume = JsonConvert.DeserializeObject<Pdf>(JsonInfo);


        }
    }
}