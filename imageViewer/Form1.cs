using System.CodeDom;

namespace imageViewer
{
    public partial class Form1 : Form
    {
        string currentDir = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var fb = new FolderBrowserDialog();
                if (fb.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    currentDir = fb.SelectedPath;//get selected folder from user

                    // display the current image
                    textBox1.Text = currentDir;
                    // get all images files 
                    var dirInfo = new DirectoryInfo(currentDir);

                    // get the files
                    var files = dirInfo.GetFiles().Where(c => c.Extension.Equals(".jpg") || c.Extension.Equals(".jpeg") || c.Extension.Equals(".png"));
                    foreach (var image in files)
                    {
                        listBox1.Items.Add(image.Name);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("There is an error" + ex.Message + "" + ex.Source);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var selectedImage = listBox1.SelectedItems[0].ToString();

                if (!string.IsNullOrEmpty(selectedImage) && !string.IsNullOrEmpty(currentDir))
                {
                    var fullPath = Path.Combine(currentDir, selectedImage);

                    pictureBox1.Image=Image.FromFile(fullPath);
                }

            }
            catch
            {

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}