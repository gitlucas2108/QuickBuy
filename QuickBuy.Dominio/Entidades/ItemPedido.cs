using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    public class ItemPedido : Entidade
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }

        public override void Validate()
        {
            //throw new NotImplementedException();

            if (ProdutoId == 0)
                AdicionarCritica("Não foi identificado qual a referência di produto.");

            if (Quantidade == 0)
                AdicionarCritica("Quantidade não foi informado.");

        }
    }
}
 