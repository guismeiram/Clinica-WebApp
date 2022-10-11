﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevIO.App.ViewModels
{
    public class ClinicaViewModel
    {

        public string id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Ddd { get; set; }

        // relacionamentos
        public virtual List<ConsultaViewModel> Consultas { get; set; }


        public virtual EnderecoViewModel Endereco { get; set; }

        public String ClinicaId { get; set; }

    }
}