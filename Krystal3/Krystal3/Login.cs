﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Krystal3
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            //txt_usuario.Text = "admin";
            //txt_contraseña.Text = "hola123";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            if (txt_usuario.Text.Length != 0 && txt_contraseña.Text.Length != 0)
            {
                Usuario u = new Usuario();

                if (u.verificarLogin(txt_usuario.Text, txt_contraseña.Text))
                {
                    MessageBox.Show("Se ha ingresado correctamente");
                    Dashboard ventana = new Dashboard();
                    //Welcome ventana = new Welcome();
                    ventana.Show();
                    this.Visible = false;
                } else
                {
                    MessageBox.Show("Los datos son incorrectos");
                }

            } else
            {
                MessageBox.Show("Por favor llena todos los campos");
            }
            
        }

        private void boton_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
