﻿using System;
using Controller;
using System.Windows.Forms;
using Model.Pessoa_e_Usuario;
using System.Data;

namespace View.Pessoas
{
    public partial class Frm_ListarFisica : Form
    {
        public Frm_ListarFisica()
        {
            InitializeComponent();
        }

        private void Frm_ListarFisica_Load(object sender, EventArgs e)
        {
           Data_Os.DataSource = ControllerPessoa.CarregarLista();
        }
    }
}