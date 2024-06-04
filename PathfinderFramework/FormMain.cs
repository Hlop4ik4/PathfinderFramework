using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PathfinderFramework
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void SkillsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormSkills();

            form.ShowDialog();
        }

        private void SkillLevelsНавыковToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormSkillLevels();
            form.ShowDialog();
        }

        private void ProfessionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormProfessions();

            form.ShowDialog();
        }

        private void EmplyeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormEmployees();
            form.ShowDialog();
        }

        private void PositionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormPositions();
            form.ShowDialog();
        }

        private void DepartmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormDepartments();
            form.ShowDialog();
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void TrainingCoursesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void TrainingCourseCompletingsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void CertificatesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void positionChangesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
