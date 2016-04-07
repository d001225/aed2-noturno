using System;

namespace ismai.AED.EstruturasLineares {
   public partial class ListaInteiros {
      /// Estilo Java
      /// public uint getCount() { return qtd; }
      /// private void setCount(uint value) { qtd = value; }
      /// Estilo Java

      //public uint Count { get; private set; }
      private uint qtd;
      public uint Count { get { return qtd; } }

      public void Add(int valor) {
         if (primeiro == null)
            primeiro = new Node { Valor = valor, Seguinte = null, };
         else {
            Node ultimo = getUltimo();
            ultimo.Seguinte = new Node { Valor = valor, Seguinte = null, };
         }
         qtd++;
      }

      private Node getUltimo() {
         var atual = primeiro;
         while (atual.Seguinte != null)
            atual = atual.Seguinte;
         return atual;
      }

      /// <summary>
      /// Indexador da classe. Permite usar objetos desta classe
      /// como se fossem vetores.
      /// </summary>
      /// <param name="posicao"></param>
      /// <returns></returns>
      public int this[int posicao] {
         get {
            var atual = primeiro;
            for (int idx = 0; idx < posicao; ++idx)
               atual = atual.Seguinte;
            return atual.Valor;
         }
      }

      private Node nodeAtPosition(int index) {
         Node atual = primeiro;
         for (int idx = 0; idx < index; idx++)
            atual = atual.Seguinte;
         return atual;
      }

      public int RemoveAll(int valor) {
         var ret = 0;
         Node atual = primeiro, anterior = null;
         while (atual != null) {
            if (atual.Valor == valor) {
               if (anterior == null) 
                  primeiro = atual.Seguinte;
               else 
                  anterior.Seguinte = atual.Seguinte;
               atual = atual.Seguinte;
               ret++; 
               qtd--;
            } else {
               anterior = atual;
               atual = atual.Seguinte;
            }
         }
         return ret;
      }

      public override string ToString() {
         var ret = new System.Text.StringBuilder();
         var atual = primeiro;
         while (atual != null) {
            ret.Append(atual.Valor);
            atual = atual.Seguinte;
            if (atual != null) ret.Append(' ');
         }
         return ret.ToString();
      }

      private Node primeiro;
      private class Node {
         public int Valor { get; set; }
         public Node Seguinte { get; set; }
      }
   }
}
