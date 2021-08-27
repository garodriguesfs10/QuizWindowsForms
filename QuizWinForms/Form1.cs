using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        private void btnIniciar_Click(object sender, EventArgs e)
        {
            FormPerguntas formPerguntas = new FormPerguntas();
            formPerguntas.ShowDialog();
            //this.Dispose();
        }

        private void btnSairFormPrincipal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIniciar_MouseHover(object sender, EventArgs e)
        {
            btnIniciar.ForeColor = Color.Black;
            btnIniciar.BackColor = Color.White;
        }

        private void btnIniciar_MouseLeave(object sender, EventArgs e)
        {
            btnIniciar.ForeColor = Color.White;
            btnIniciar.BackColor = Color.Black;
        }
    }
}
