﻿using System;
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
    public partial class FormProfession : Form
    {
        public FormProfession()
        {
            InitializeComponent();
        }

        private void buttonAddSkill_Click(object sender, EventArgs e)
        {
            var form = new FormProfessionEmployeeSkillLevel();
            form.ShowDialog();
        }
    }
}
