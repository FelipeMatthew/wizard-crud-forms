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
    public partial class ConsultarAluno : Form
    {
        public ConsultarAluno()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AlunoDAO alunoDAO = new AlunoDAO();
            dataGridView1.DataSource = alunoDAO.consultar();
        }
    }
}
