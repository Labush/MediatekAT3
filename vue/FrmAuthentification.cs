using Mediatek86.controleur;
using Mediatek86.metier;
using Mediatek86.vue;
using System;
using System.Windows.Forms;

namespace Mediatek86.vue
{
    public partial class FrmAuthentification : Form
    {
        private readonly Controle controle;

        public bool authentificationVerif { get; private set; }

        internal FrmAuthentification(Controle controle)
        {
            InitializeComponent();
            this.controle = controle;
        }

        private void FrmAuthentification_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string utilisateur = textBox1.Text;
            string mdp = textBox2.Text;
            Service leService = controle.Authentification(utilisateur, mdp);
            if (leService != null)
            {
                if (leService.Libelle == "culture")
                {
                    MessageBox.Show("L'accès à l'application ne vous est pas autorisé.");
                    textBox1.Clear();
                    textBox2.Clear();
                }
                else
                {
                    authentificationVerif = true;
                    Close();
                }
            }
            else
            {
                MessageBox.Show("Vos identifiants sont incorrects.");
                textBox1.Clear();
                textBox2.Clear();
            }
        }
    }
}
