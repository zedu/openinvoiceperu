﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenInvoicePeru.FirmadoSunat.Models
{
    public class ResumenDiario : DocumentoResumen
    {
        public List<GrupoResumen> Resumenes { get; set; }
    }
}