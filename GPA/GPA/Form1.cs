namespace GPA
{
    public partial class Form1 : Form
    {
        GPACAlculater oGPAcal = new GPACAlculater();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = this.textBoxGPA_input.Text;
            string name = this.textBoxName_input.Text;

            double dInput = Convert.ToDouble(input);
            oGPAcal.addGPA(dInput, name);

            double gpax = oGPAcal.getGPAx();
            textBoxGPAx.Text = gpax.ToString();

            double max = oGPAcal.getMax();
            textBoxMaxGPA.Text = max.ToString();
            textBoxMaxName.Text = oGPAcal.getMaxName().ToString();

            double min = oGPAcal.getMin();
            textBoxMinGPA.Text = min.ToString();
            textBoxMinName.Text = oGPAcal.getminName().ToString();

            textBoxGPA_input.Text = "";
            textBoxName_input.Text = String.Empty;
            textBoxALLData.Text = oGPAcal.getAlldata();
        
        
        }


        private void botton2_Click(object sender, EventArgs e)
        {
            textBoxGPAx.Text = "";
            textBoxGPA_input.Text = "";
            textBoxMaxGPA.Text = "";
            textBoxMinGPA.Text = "";
            textBoxName_input.Text = "";
            textBoxMaxName.Text = "";
            textBoxMinName.Text = "";
            textBoxALLData.Text = "";
        }



    }
}