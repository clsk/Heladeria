﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer;

namespace Heladeria
{
    public partial class FormCaja : BaseForm
    {
        public FormCaja(Form previousForm, Caja caja) : base(previousForm)
        {
            InitializeComponent();
        }
    }
}
