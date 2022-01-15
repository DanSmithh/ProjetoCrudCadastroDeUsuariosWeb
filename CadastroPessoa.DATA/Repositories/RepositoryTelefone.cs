using CadastroPessoa.DATA.Interfaces;
using CadastroPessoa.DATA.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroPessoa.DATA.Repositories
{

    public class RepositoryTelefone : RepositoryBase<Telefone>, IRepositoryTelefone
    {
        public RepositoryTelefone(bool SaveChanges = true) : base(SaveChanges)
        {

        }
    }

}