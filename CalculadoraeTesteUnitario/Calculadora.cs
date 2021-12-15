using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraeTesteUnitario
{
    public class Calculadora
    {
        private List<String> ListaHistorico;

        public Calculadora()
        {
            ListaHistorico = new List<string>();
        }

        public int soma (int val1, int val2)
        {
            int res = val1 + val2;
            ListaHistorico.Insert(0, "Res:" + res);
            return res;
        }

        public int subtrair(int val1, int val2)
        {
            int res = val1 - val2;
            ListaHistorico.Insert(0, "Res:" + res);
            return res; 
        }

        public int multiplicar(int val1, int val2)
        {
           int res = val1 * val2;
            ListaHistorico.Insert(0, "Res:" + res);
            return res;
        }

        public int dividir(int val1, int val2)
        {
            int res = val1 / val2;
            ListaHistorico.Insert(0, "Res:" + res);
            return res;
        }
        public List<string> historico()
        {
            ListaHistorico.RemoveRange(3, ListaHistorico.Count - 3);
            return ListaHistorico; 
        }
        
    }
}
