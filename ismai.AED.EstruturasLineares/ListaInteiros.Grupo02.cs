using System;

namespace ismai.AED.EstruturasLineares {
   partial class ListaInteiros {
      public int RemoveAt(int posicao) {
         var retorno = primeiro.Valor;
         if (posicao == 0) {
            primeiro = primeiro.Seguinte;
         } else {
            var no = nodeAtPosition(posicao - 1);
            retorno = no.Valor;
            no.Seguinte = no.Seguinte.Seguinte;
         }
         qtd--;
         return retorno;
      }
   }
}
