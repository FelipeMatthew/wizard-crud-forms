using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WizardForms.Aluno
{
    public partial class ExcluirAluno : Form
    {
        public ExcluirAluno()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Aluno aluno = new Aluno();
            aluno.setId(int.Parse(textBox1.Text));


            AlunoDAO alunoDAO = new AlunoDAO();

            if (alunoDAO.excluir(aluno))
            {
                MessageBox.Show("Apagado sucesso!", "Apagado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Nao excluido!", "Apagado", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
    }
}
