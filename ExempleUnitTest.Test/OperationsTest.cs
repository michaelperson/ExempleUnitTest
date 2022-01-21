using NUnit.Framework;
using System;

namespace ExempleUnitTest.Test
{
    public class OperationsTest
    {
        Operations op;

        [SetUp]
        public void Setup()
        {
            op = new Operations(4,2);
        }

        /// <summary>
        /// NE JAMAIS FAIRE CE GENRE DE UNIT TEST
        /// Un UNIT TEST test 1! unité
        /// </summary>
        //[Test]
        //public void OpTest()
        //{
        //    int somme = op.Addition();
        //    Assert.AreEqual(6, somme);
        //    int resultat = op.Soustraction();
        //    Assert.AreEqual(2, resultat);
        //}



        [Test]
        public void AdditionTest()
        {
            int somme = op.Addition();          
            Assert.AreEqual(6, somme);

            Assert.Inconclusive("La méthode n'échoue pas MAIS le test est trop petit pour être certain que la fonction est opérationnelle");
        }

        [Test]
        public void AdditionFailedTest()
        {
            op = new Operations(8, 12);
            int somme = op.Addition();
            Assert.AreNotEqual(6, somme);
            Assert.AreEqual(20, somme);
        }

        [Test]
        public void AdditionExceptionTest()
        {
            op = new Operations(int.MaxValue, int.MaxValue);

            Assert.DoesNotThrow(()=>op.Addition());
        }

        [Test(Author ="mike",Description ="Tester la soustraction")]
        [Category("Basic Test")]
        public void SoustractionTest()
        {
            int resultat = op.Soustraction();          
            Assert.AreEqual(2, resultat);
        }

        [Test]
        [Category("Basic Test")]
        public void MultiplicationTest()
        {
            long resultat = op.Multiplication(2, 3);
            Assert.AreEqual(6, resultat);
        }
    }
}