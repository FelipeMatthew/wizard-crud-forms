using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WizardForms.Aluno;
using WizardForms.Professor;

namespace WizardForms
{
    public partial class TelaPrincipal : Form
    {


        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

  


        private void calvoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
             
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Deseja realmente sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(DialogResult == DialogResult.Yes){ this.Close(); }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip2_ItemClicked_2(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void cadastroToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            CadastroProfessor professorCadastro = new CadastroProfessor();
            professorCadastro.MdiParent = this;
            professorCadastro.Show();
        }

        private void consultarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultarProfessor professorConsultar = new ConsultarProfessor();
            professorConsultar.MdiParent = this;
            professorConsultar.Show();
        }

        private void atualizarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AtualizarProfessor professorAtualizar = new AtualizarProfessor();
            professorAtualizar.MdiParent = this;
            professorAtualizar.Show();
        }

        private void apagarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ExcluirProfessor professorApagar = new ExcluirProfessor();
            professorApagar.MdiParent = this;
            professorApagar.Show();
        }

        private void cadastroToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            CadastroAluno cadastroAluno = new CadastroAluno();
            cadastroAluno.MdiParent = this;
            cadastroAluno.Show();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarAluno consultarAluno = new ConsultarAluno();
            consultarAluno.MdiParent = this;
            consultarAluno.Show();
        }

        private void atualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AtualizarAluno atualizarAluno = new AtualizarAluno();
            atualizarAluno.MdiParent= this;
            atualizarAluno.Show();
        }

        private void apagarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExcluirAluno excluirAluno= new ExcluirAluno();
            excluirAluno.MdiParent = this;
            excluirAluno.Show();
        }

        private void sairToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
