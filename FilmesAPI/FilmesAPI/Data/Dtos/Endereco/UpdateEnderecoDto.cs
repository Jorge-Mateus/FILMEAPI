﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmesAPI.Data.Dtos.Endereco
{
    public class UpdateEnderecoDto
    {
        public string Longradouro { get; set; }
        public string Bairro { get; set; }
        public int Numero { get; set; }
    }
}