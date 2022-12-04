using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace WizardForms.Aluno

{

    internal class Aluno
    {
        private int id;
        private string Nome;
        private string Sobrenome;
        private string Email;
        private string RepEmail;
        private string Senha;
        private string RepSenha;
        private string Celular;
        private string Linguagem;
        private string Estado;
        private string Cidade;
        private string Experiencia;

        public Aluno()
        {
            this.id = 0;
            this.Nome = "";
            this.Sobrenome = "";
            this.Email = "";
            this.RepEmail = "";
            this.Senha = "";
            this.RepSenha = "";
            this.Celular = "";
            this.Linguagem = "";
            this.Estado = "";
            this.Cidade = "";
            this.Experiencia = "true";
        }
        public Aluno(
            int p_id,
            string p_Experiencia,
            string p_Cidade,
            string p_Estado,
            string p_Linguagem,
            string p_Nome,
            string p_Sobrenome,
            string p_Email,
            string p_RepEmail,
            string p_Senha,
            string p_RepSenha,
            string p_Celular
            )
        {
            this.id = p_id;
            this.Nome = p_Nome;
            this.Sobrenome = p_Sobrenome;
            this.Email = p_Email;
            this.RepEmail = p_RepEmail;
            this.Senha = p_Senha;
            this.RepSenha = p_RepSenha;
            this.Celular = p_Celular;
            this.Linguagem = p_Linguagem;
            this.Estado = p_Estado;
            this.Cidade = p_Cidade;
            this.Experiencia = p_Experiencia;

        }
        //Id - Metodos
        public int getId() { return id; }
        public void setId(int id ) { this.id = id;}

        //Nome- Metodos 
        public string getNome() { return Nome; }
        public void setNome(string p_Nome) { this.Nome = p_Nome; }

        //Sobrenome- Metodos 
        public string getSobreNome() { return Sobrenome; }
        public void setSobreNome(string p_Sobrenome) { this.Sobrenome = p_Sobrenome; }

        //Email- Metodos 
        public string getEmail() { return Email; }
        public void setEmail(string p_Email) { this.Email = p_Email; }

        //Rep email
        public string getRepEmail() { return RepEmail; }
        public void setRepEmail(string p_RepEmail) { this.RepEmail = p_RepEmail; }

        //Senha- Metodos 
        public string getSenha() { return Senha; }
        public void setSenha(string p_Senha) { this.Senha = p_Senha; }

        //Rep Senha- Metodos 
        public string geRepSenha() { return RepSenha; }
        public void setRepSenha(string p_RepSenha) { this.RepSenha = p_RepSenha; }

        //Celular- Metodos 
        public string getCelular() { return Celular; }
        public void setCelular(string p_Celular) { this.Celular = p_Celular; }

        //Linguagem-- Metodos 
        public string getLinguagem() { return Linguagem; }
        public void setLiguagem(string p_Linguagem) { this.Linguagem = p_Linguagem; }

        //Estado- Metodos 
        public string getEstado() { return Estado; }
        public void setEstado(string p_Estado) { this.Estado = p_Estado; }

        //Cidade- Metodos 
        public string getCidade() { return Cidade; }
        public void setCidade(string p_Cidade) { this.Cidade = p_Cidade; }

        //Experiencia- Metodos 
        public string getExperiencia() { return Experiencia; }
        public void setExperiencia(string p_Experiencia) { this.Experiencia = p_Experiencia; }

    }
}


