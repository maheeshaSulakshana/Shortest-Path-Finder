using ShortestPathFinder;

namespace ShortestPathFinder
{
    public partial class frmWelcome : Form
    {
        public frmWelcome()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            String source = cboSource.Text;
            String destination = cboDestination.Text;
            MapDb map = new MapDb();
            map.findDestination(source, destination);
            map.findMinDistance();
            List<String> path = map.getPath();
            double distance = map.getDistance();
            frmResults frmResults = new frmResults(path, distance, destination);
            this.Hide();
            frmResults.Show();
        }
    }
}
