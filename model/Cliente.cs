using Efenex.model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Efenex
{
    public class Cliente:BaseModel
    {
        public string nome { get; set; }
        public DateTime nascimento { get; set; }
        public string cpf { get; set; }
        public int idade { get; set; }
        public string rg { get; set; }

        public Cliente(string nome, DateTime nascimento, string cpf, int idade, string rg)
        {
            this.nome = nome;
            this.nascimento = nascimento;
            this.cpf = cpf;
            this.idade = idade;
            this.rg = rg;
        }
    }
}
