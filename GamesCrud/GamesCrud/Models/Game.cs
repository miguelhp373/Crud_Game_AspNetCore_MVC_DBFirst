using System;
using System.Collections.Generic;

#nullable disable

namespace GamesCrud.Models
{
    public partial class Game
    {
        public int Codigo { get; set; }
        public string CodigoBarras { get; set; }
        public string Marca { get; set; }
        public string Plataforma { get; set; }
        public string Idiomas { get; set; }
        public string FaixaEtaria { get; set; }
        public string ConteudoEmbalagem { get; set; }
        public string ReferenciaModelo { get; set; }
        public string Fornecedor { get; set; }
    }
}
