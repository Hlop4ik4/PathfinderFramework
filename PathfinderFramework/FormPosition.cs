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
    public partial class FormPosition : Form
    {
        public FormPosition()
        {
            InitializeComponent();
        }

        private void buttonAddProfession_Click(object sender, EventArgs e)
        {
            var form = new FormPositionProfession();
            form.ShowDialog();
        }

        private void buttonDeleteProfession_Click(object sender, EventArgs e)
        {

        }

        private void buttonUpdateProfessions_Click(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {

        }

        private void FormPosition_Load(object sender, EventArgs e)
        {

        }
    }
}
