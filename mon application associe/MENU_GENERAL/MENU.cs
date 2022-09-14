using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace mon_application_associe.MENU_GENERAL
{
    public partial class MENU_GENERAL : Form
    {
        
        public MENU_GENERAL()
        {
            InitializeComponent();
        }

        private void MENU_GENERAL_Load(object sender, EventArgs e)
        {

        }

        private void listeArticlesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // LISTE ARTICLE
            OpenUniqueForm("Liste Articles", new ARTICLE.LISTE_ARTICLES());
            //affiche_boite_outil();
        }
        private void OpenUniqueForm(string Nom_F, Form Type_F)
        {
            Form[] fille = this.MdiChildren;
            foreach (Form CH in fille)
            {
                if (CH.Name == Nom_F)
                {
                    CH.Visible = true;
                    return;
                }
            }
            Form MdiCH = Type_F;
            MdiCH.MdiParent = this;
            MdiCH.Visible = true;
            MdiCH.TopMost = true;
        }
        
    }
}
