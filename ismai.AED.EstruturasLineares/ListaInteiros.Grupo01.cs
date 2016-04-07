using System;


namespace ismai.AED.EstruturasLineares {
   partial class ListaInteiros {
      public void InsertAt(int posicao, int valor) {
         if (posicao == 0) {
            primeiro = new Node { Valor = valor, Seguinte = primeiro, };
         } else {
            Node pos = nodeAtPosition(posicao - 1);
            pos.Seguinte = new Node { Valor = valor, Seguinte = pos.Seguinte, };
         }
         qtd++;
      }
   }
}
