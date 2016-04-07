using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ismai.AED.EstruturasLineares;

namespace ismai.AED.EstrutrasLineares.Tests {
   [TestClass] public partial class TestarListaInteiros {
      [TestMethod] public void CriarNovaLista() {
         ListaInteiros l = new ListaInteiros();

         Assert.IsNotNull(l);
         Assert.AreEqual(0u, l.Count); //0u => ((uint) 0)
      }

      [TestMethod] public void AdicionarElemento1NoFinal() {
         var l = new ListaInteiros();
         l.Add(1);

         Assert.AreEqual(1u, l.Count);
         Assert.AreEqual(1, l[0]); //l[N] => l.this[N]
      }

      [TestMethod] public void AdicionarDoisElementoNoFinal() {
         var l = new ListaInteiros();
         l.Add(1);
         l.Add(2);

         Assert.AreEqual(2u, l.Count);
         Assert.AreEqual(1, l[0]);
         Assert.AreEqual(2, l[1]);
      }

      [TestMethod]
      public void AdicionarCincoElementoNoFinal() {
         var l = new ListaInteiros();
         var elementos = new[] { 10, 20, 5, 3, 2, };
         for (int j = 0; j < elementos.Length; ++j)
            l.Add(elementos[j]);

         Assert.AreEqual((uint) elementos.Length, l.Count);
         for (int j = 0; j < elementos.Length; ++j)
            Assert.AreEqual(elementos[j], l[j]);
      }

      [TestMethod] public void RemoverElementosValor10() {
         var l = new ListaInteiros();
         var elementos = new[] { 10, 20, 10, 3, 8, 5, 10, };
         for (int j = 0; j < elementos.Length; ++j)
            l.Add(elementos[j]);

         int quantos = l.RemoveAll(10);
         Assert.AreEqual(3, quantos);
         Assert.AreEqual((uint)elementos.Length, l.Count + quantos);

         Assert.AreEqual(20, l[0]);
         Assert.AreEqual(03, l[1]);
         Assert.AreEqual(08, l[2]);
         Assert.AreEqual(05, l[3]);
      }

      [TestMethod] public void ExemploNoQuadro() {
         var l = new ListaInteiros();
         l.Add(1); 
         Assert.AreEqual(1u, l.Count, "Add(1)");
         Assert.AreEqual("1", l.ToString(), "Add(1)");

         l.Add(2);
         Assert.AreEqual(2u, l.Count, "Add(2)");
         Assert.AreEqual("1 2", l.ToString(), "Add(2)");

         l.Add(3);
         Assert.AreEqual(3u, l.Count, "Add(3)");
         Assert.AreEqual("1 2 3", l.ToString(), "Add(3)");
         
         l.RemoveAt(2);
         Assert.AreEqual(2u, l.Count, "RemoveAt(2)");
         Assert.AreEqual("1 2", l.ToString(), "RemoveAt(2)");

         l.InsertAt(0, 3);
         Assert.AreEqual(3u, l.Count, "InsertAt(0, 3)");
         Assert.AreEqual("3 1 2", l.ToString(), "InsertAt(0, 3)");

         l.RemoveAll(3);
         Assert.AreEqual(2u, l.Count, "RemoveAll(3)");
         Assert.AreEqual("1 2", l.ToString(), "RemoveAll(3)");

         l.RemoveAll(1);
         l.RemoveAll(2);
         Assert.AreEqual(0u, l.Count, "RemoveAll(1)");
         Assert.AreEqual(String.Empty, l.ToString(), "RemoveAll(1)");
      }
   }
}
