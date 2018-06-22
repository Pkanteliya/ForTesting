using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForTest
{
    class Program
    {
        static void Main(string[] args)
        {
            MyGenericClass<int> MG = new MyGenericClass<int>(10,11);

            Console.WriteLine(MG.genericMethod(10));

            Console.Read();
        }
    }

    #region Generic Example

    class MyGenericClass<T>
    {
        private T genericMemberVariable;

       // Generic constructor
        public MyGenericClass(T value1, T value2)
        {
            genericMemberVariable = value1;
            Console.WriteLine(genericMemberVariable);
        }

        //Generic Method
        public T genericMethod(T genericParameter)
        {
            Console.WriteLine("Parameter type: {0}, value: {1}", typeof(T).ToString(), genericParameter);
            Console.WriteLine("Return type: {0}, value: {1}", typeof(T).ToString(), genericMemberVariable);

            return genericMemberVariable;
        }

        public T genericProperty { get; set; }
    }

    #endregion

}
