using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExempleUnitTest
{
    public class Operations
    {
        private int _a, _b;

        public Operations()
        {

        }

        public Operations(int A, int b)
        {
            this._b = b;
            this._a = A;
        }

        public int Addition()
        {
            try
            {
                return _a + _b;
            }
            catch (OverflowException ex)
            {
                File.WriteAllText(@"test.log", $"Echec de l'addition : {ex.Message}");
                return 0;
            }
        }

        public int Soustraction()
        {
            return 2;
        }
    }
}
