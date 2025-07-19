using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cadastroAlunos.Models
{
    public class Aluno
    {
        public Aluno(string nome, int idade, string curso, int matricula)
        {
            Nome = nome;
            Idade = idade;
            Curso = curso;
            Matricula = matricula;
        }

        private string _nome;
        private int _idade;
        private string _curso;
        private int _matricula;
        private List<Aluno> listaAlunos = new List<Aluno>();

        public string Nome
        {
            get => _nome;

            set
            {
                if (value == "")
                {
                    throw new Exception("O nome do aluno não pode ser vazio.");
                }
                _nome = value;
            }
        }

        public int Idade
        {
            get => _idade;

            set
            {
                if (value <= 0)
                {
                    throw new Exception("A idade não pode ser igual ou menor que zero");
                }
                _idade = value;
            }
        }

        public string Curso
        {
            get => _curso;

            set
            {
                if (value == "")
                {
                    throw new Exception("O nome do curso não pode ser vazio.");
                }
                _curso = value;
            }
        }

        public int Matricula
        {
            get => _matricula;

            set
            {
                if (value <= 0)
                {
                    throw new Exception("A matrícula não pode ser igual ou menor que zero");
                }
                _matricula = value;
            }
        }
         
    }
}