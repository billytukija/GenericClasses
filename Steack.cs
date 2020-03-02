using OfficeOpenXml.FormulaParsing.Excel.Functions.Text;
using System;

namespace GenericClasses
{
    public class Steack<T>
    {
        int Pos = 0;
        public T[] Itens = new T[50];

        public void Push(T item)
        {
            Itens[Pos] = item;
            Pos++;
        }

        public Object Pop()
        {
            Pos--;
            return Itens[Pos];
        }
    }
}
