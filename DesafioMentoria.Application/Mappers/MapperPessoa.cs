using DesafioMentoria.Application.Dtos;
using DesafioMentoria.Application.Interfaces.Mappers;
using DesafioMentoria.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace DesafioMentoria.Application.Mappers
{
    public class MapperPessoa : IMapperPessoa
    {
        Regex rgx = new Regex("[^0-9]");

        public Pessoa MapperDtoToEntity(PessoaDto pessoaDto)
        {

            var pessoa = new Pessoa()
            {
                Id = pessoaDto.Id,
                Nome = pessoaDto.Nome,
                Cpf = rgx.Replace(pessoaDto.Cpf, ""),
                DataNascimento = Convert.ToDateTime(pessoaDto.DataNascimento),
                Sexo = pessoaDto.Sexo,
                Ativo = pessoaDto.Ativo

            };
            return pessoa;
        }

        public PessoaDto MapperEntityToDto(Pessoa pessoa)
        {
            var pessoaDto = new PessoaDto()
            {
                Id = pessoa.Id,
                Nome = pessoa.Nome,
                Cpf = pessoa.Cpf,
                DataNascimento = pessoa.DataNascimento.ToString(),
                Sexo = pessoa.Sexo,
                Ativo = pessoa.Ativo
            };
            return pessoaDto;
        }

        public IEnumerable<PessoaDto> MapperListPessoaDto(IEnumerable<Pessoa> pessoas)
        {
            var dto = pessoas.Select(c => new PessoaDto
            {
               Id = c.Id,
               Nome = c.Nome,
               Sexo= c.Sexo,    
               Cpf= c.Cpf,
               DataNascimento= c.DataNascimento.ToString(),   
               Ativo= c.Ativo
            });
            return dto;
        }
    }
}
