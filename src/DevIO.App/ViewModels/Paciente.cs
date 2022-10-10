﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevIO.App.ViewModels
{
    public class Paciente
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Idade { get; set; }
        public String Rg { get; set; }
        public String Cpf { get; set; }
        public Consulta Consulta { get; set; }
        public string Telefone { get; set; }
        public string Ddd { get; set; }
        public virtual List<PacienteTipoPagamento> PacienteTipoPagamentos { get; set; }


    }
}
