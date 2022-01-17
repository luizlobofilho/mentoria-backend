using DesafioMentoria.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace DesafioMentoria.Domain.Validators
{
    public class PessoaValidator
    {
        public void ValidarObjPessoa(Pessoa pessoaDto)
        {
            if (pessoaDto == null)
            {
                throw new FormatException("Não foram informados os dados da Pessoa");

            }
        }

        
    }
}
