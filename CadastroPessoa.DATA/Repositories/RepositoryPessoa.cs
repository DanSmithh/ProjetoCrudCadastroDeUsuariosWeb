using CadastroPessoa.DATA.Interfaces;
using CadastroPessoa.DATA.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroPessoa.DATA.Repositories
{

    public class RepositoryPessoa : RepositoryBase<Pessoa>, IRepositoryPessoa
    {
        public RepositoryPessoa(bool SaveChanges = true) : base(SaveChanges)
        {

        }
    }

}