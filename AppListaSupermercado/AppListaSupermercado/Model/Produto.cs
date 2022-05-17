using System;
using System.Collections.Generic;
using System.Text;

using SQLite;

namespace AppListaSupermercado.Model
{
    public class Produto
    {
        [PrimaryKey, AutoIncrement]
        public string Id { get; set; }
        public string NomeProduto { get; set; }
        public double Quantidade { get; set; }
        public double PrecoEstimado { get; set; }
        public double PrecoPago { get; set; }
    }
}
