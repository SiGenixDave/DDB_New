using System;
using System.Windows.Forms;

namespace DDB
{
    public partial class FormImport : Form
    {
        private Boolean fileCancelled = false;
        private String import;
        private String fileName;

        public FormImport(String importType)
        {
            import = importType;

            InitializeComponent();

            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Title = "Import " + importType;
            openFile.DefaultExt = "xml";
            openFile.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";
            openFile.FilterIndex = 0;
            openFile.CheckFileExists = true;
            openFile.CheckPathExists = true;
            if (openFile.ShowDialog() != DialogResult.OK)
            {
                fileCancelled = true;
            }
            else
            {
                fileName = openFile.FileName;
            }
        }

        private void ImportForm_Load(object sender, EventArgs e)
        {
            if (fileCancelled)
            {
                Close();
            }
            else
            {
                //TODO populate vList box with watch variables
                this.Text = "Select " + import;
                lbl.Text = "Import " + import + " from file " + System.Environment.NewLine + fileName;
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormImport_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                btnAccept_Click(null, null);
            }
            else if (e.KeyCode == Keys.Escape)
            {
                btnCancel_Click(null, null);
            }
        }
    }
}