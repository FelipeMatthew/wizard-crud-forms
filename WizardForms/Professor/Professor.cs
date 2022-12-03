using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WizardForms.Professor
{
    internal class Professor
    {

        private string Nome;
        private string Sobrenome;
        private string Email;
        private string Senha;
        private string RepSenha;
        private string Celular;
        private string Linguagem;
        private string Estado;
        private string Cidade;
        private string Experiencia;

        public Professor()
        {

            this.Nome = "";
            this.Sobrenome = "";
            this.Email = "";
            this.Senha = "";
            this.RepSenha = "";
            this.Celular = "";
            this.Linguagem = "";
            this.Estado = "";
            this.Cidade = "";
            this.Experiencia = "true";
        }
        public Professor(string p_Experiencia, string p_Cidade, string p_Estado, string p_Linguagem, string p_Nome, string p_Sobrenome, string p_Email, string p_Senha, string p_RepSenha, string p_Celular)
        {
            this.Nome = p_Nome;
            this.Sobrenome = p_Sobrenome;
            this.Email = p_Email;
            this.Senha = p_Senha;
            this.RepSenha = p_RepSenha;
            this.Celular = p_Celular;
            this.Linguagem = p_Linguagem;
            this.Estado = p_Estado;
            this.Cidade = p_Cidade;
            this.Experiencia = p_Experiencia;

        }
        //Nome- Metodos 
        public string getNome()
        { return Nome; }
        public void setNome(string p_Nome)
        { this.Nome = p_Nome; }

        //Sobrenome- Metodos 
        public string getSobreNome()
        { return Sobrenome; }
        public void seSobreNome(string p_Sobrenome)
        { this.Sobrenome = p_Sobrenome; }

        //Email- Metodos 
        public string getEmail()
        { return Email; }
        public void setEmail(string p_Email)
        { this.Email = p_Email; }

        //Senha- Metodos 
        public string getSenha()
        { return Senha; }
        public void setSenha(string p_Senha)
        { this.Email = p_Senha; }

        //Rep Senha- Metodos 
        public string geRepSenha()
        { return RepSenha; }
        public void setRepSenha(string p_RepSenha)
        { this.RepSenha = p_RepSenha; }

        //Celular- Metodos 
        public string getCelular()
        { return Celular; }
        public void setCelular(string p_Celular)
        { this.Celular = p_Celular; }

        //Linguagem-- Metodos 
        public string getLinguagem()
        { return Linguagem; }
        public void setLiguagem(string p_Linguagem)
        { this.Linguagem = p_Linguagem; }

        //Estado- Metodos 
        public string getEstado()
        { return Estado; }
        public void setEstado(string p_Estado)
        { this.Estado = p_Estado; }

        //Cidade- Metodos 
        public string getCidade()
        { return Cidade; }
        public void setCidade(string p_Cidade)
        { this.Cidade = p_Cidade; }

        //Experiencia- Metodos 
        public string getExperiencia(){ return Experiencia; }
        public void setExperiencia(string p_Experiencia)
        { this.Experiencia = p_Experiencia; }

    }
}

