using CadastroPessoa.DATA.Interfaces;
using CadastroPessoa.DATA.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroPessoa.DATA.Repositories
{

    public class RepositoryEndereco : RepositoryBase<Endereco>, IRepositoryEndereco
    {
        public RepositoryEndereco(bool SaveChanges = true) : base(SaveChanges)
        {

        }
    }

}