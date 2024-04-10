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
    public partial class FormEmployee : Form
    {
        public FormEmployee()
        {
            InitializeComponent();
        }

        private void buttonAddSkill_Click(object sender, EventArgs e)
        {
            var form = new FormProfessionEmployeeSkillLevel();
            form.ShowDialog();
        }

        private void buttonDepartment_Click(object sender, EventArgs e)
        {
            var form = new FormEmployeeDepartments();
            form.ShowDialog();
        }

        private void buttonDeleteDepartment_Click(object sender, EventArgs e)
        {

        }

        private void buttonDeleteSkill_Click(object sender, EventArgs e)
        {

        }

        private void buttonUpdateSkills_Click(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {

        }

        private void buttonUpdateDepartment_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddDepartment_Click(object sender, EventArgs e)
        {

        }
    }
}
