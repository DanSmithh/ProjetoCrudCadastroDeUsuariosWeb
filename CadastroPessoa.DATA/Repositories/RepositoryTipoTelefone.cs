using CadastroPessoa.DATA.Interfaces;
using CadastroPessoa.DATA.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroPessoa.DATA.Repositories
{

    public class RepositoryTelefoneTipo : RepositoryBase<TelefoneTipo>, IRepositoryTelefoneTipo
    {
        public RepositoryTelefoneTipo(bool SaveChanges = true) : base(SaveChanges)
        {

        }
    }

}
