﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjVendas
{
    public partial class FrmSplash : Form
    {
        public FrmSplash()
        {
            InitializeComponent();
        }

        private void tmrProgresso_Tick(object sender, EventArgs e)
        {
            pgbSplash.PerformStep();
            if(pgbSplash.Value == 100)
            {
                tmrProgresso.Enabled = false;
                this.Visible = false;

                Close();
            }
        }
    }
}
