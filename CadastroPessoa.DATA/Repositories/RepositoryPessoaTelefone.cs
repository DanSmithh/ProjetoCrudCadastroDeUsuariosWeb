using CadastroPessoa.DATA.Interfaces;
using CadastroPessoa.DATA.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroPessoa.DATA.Repositories
{

    public class RepositoryPessoaTelefone : RepositoryBase<PessoaTelefone>, IRepositoryPessoaTelefone
    {
        public RepositoryPessoaTelefone(bool SaveChanges = true) : base(SaveChanges)
        {

        }
    }

}