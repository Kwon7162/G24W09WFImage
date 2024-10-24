namespace G24W09WFImage
{
    public partial class Form1 : Form
    {
        private int ImageIndex = 0;
        private Image[] Images;
        public Form1()
        {
            InitializeComponent();

            Images = new Image[]
            {
                Properties.Resources.image1,
                Properties.Resources.Cat,
                Properties.Resources.Dog,
            };
        }

        private void OnChange(object sender, EventArgs e)
        {
            ImageIndex = (ImageIndex + 1) % Images.Length;

            pictureBox1.Image = Images[ImageIndex];
        }
    }
}
