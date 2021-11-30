﻿using BL.Reposteria;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win.Pasteleria
{
    public partial class FormLogin : Form
    {
        SeguridadBL _seguridad;
        public FormLogin()
        {
            InitializeComponent();
            _seguridad = new SeguridadBL();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario;
            string contraseña;

            usuario = textBox1.Text;
            contraseña = textBox2.Text;

           var resultado = _seguridad.autorizar(usuario, contraseña);
            if (resultado == true)
            {
                this.Close();


            }
            else
            {
                MessageBox.Show("usuario o contraseña son incorrectas");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}