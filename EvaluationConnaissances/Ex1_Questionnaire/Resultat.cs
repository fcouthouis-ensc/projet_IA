﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex1_Questionnaire
{
    public partial class Resultat : Form
    {
        Questionnaire questionnaire;
        public Resultat(Questionnaire questionnaire)
        {
            InitializeComponent();
            this.questionnaire = questionnaire;
            scoreReel_lb.Text = questionnaire.score*20/questionnaire.scoreMaxPossible + " / 20";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void scoreReel_lb_Click(object sender, EventArgs e)
        {

        }

        private void restart_btn_Click(object sender, EventArgs e)
        {
            Questionnaire questionnaire = new Questionnaire();
            this.Hide();
            questionnaire.Show();
        }

        private void accueil_btn_Click(object sender, EventArgs e)
        {
            Accueil accueil = new Accueil();
            this.Hide();
            accueil.Show();
        }
    }
}
