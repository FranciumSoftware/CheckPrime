using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrimeCheck
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CheckNumber_Click(object sender, EventArgs e)
        {
            //Définition des variables nécessaire
            long nombre =Convert.ToInt64(ImputNumber.Value);
            if (EstPremier(nombre))
            {
                Result.Text = $"Le nombre {nombre} est premier";
            }
            else
            {
                Result.Text = $"Le nombre {nombre} n'est pas premier";
            }
        }
        
        //Ecriture de la formule de vérification de nombre premier
        
        static bool EstPremier(long nombre)
        {
            if (nombre <= 1) return false;
            if (nombre == 2) return true;

            for (int i = 2; i <= Math.Sqrt(nombre); i++)
            {
                if (nombre % i == 0) return false;
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutBox1 = new AboutBox1();
            aboutBox1.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitLink();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open link that was clicked.");
            }
        }

        private void VisitLink()
        {
            
            //Call the Process.Start method to open the default browser
            //with a URL:
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=dQw4w9WgXcQ");
        }
    }
}
