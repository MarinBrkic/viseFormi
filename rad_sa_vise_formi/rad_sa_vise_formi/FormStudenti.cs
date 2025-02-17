﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rad_sa_vise_formi
{
    public partial class FormStudenti : Form
    {
        public FormStudenti()
        {
            InitializeComponent();
        }

        private void FormStudenti_Load(object sender, EventArgs e)
        {

        }

        private void buttonObrisiSve_Click(object sender, EventArgs e)
        {
            listBoxStudenti.Items.Clear();
        }

        private void buttonObrisiStudenta_Click(object sender, EventArgs e)
        {
            if (!(listBoxStudenti.SelectedIndex < 0))
            {

                listBoxStudenti.Items.RemoveAt(listBoxStudenti.SelectedIndex);
            }
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            FormUnosNovogStudenta frm = new FormUnosNovogStudenta();

            DialogResult rez = frm.ShowDialog();

            if (rez == System.Windows.Forms.DialogResult.OK)
            {

                listBoxStudenti.Items.Add(frm.Student1.ToString());
            }
        }
    }
}
