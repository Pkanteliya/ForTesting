using System;
using System.Collections;
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

            Console.WriteLine(MG.genericMethod(20,1));

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
        public T genericMethod(T genericParameter1, T genericparameter2)
        {
            //Console.WriteLine("Parameter type: {0}, value: {1}", typeof(T).ToString(), genericParameter);
            //Console.WriteLine("Return type: {0}, value: {1}", typeof(T).ToString(), genericMemberVariable);            

            Console.WriteLine(genericparameter2);

            return genericParameter1;
        }

        public T genericProperty { get; set; }
    }

    #endregion

    #region Collections Example

    public class CollectionExample
    {
        public void ArrayListEx()
        {
            //It takes argument of variable types
            ArrayList al = new ArrayList();
            al.Add("Piyush"); 
            al.Add(1);
        }

        public void HashTableEx()
        {
            Hashtable ht = new Hashtable();
            ht.Add("Key1", "Value1");
            ht.Add("key2", "Value2");
        }

        public void SortedListEx()
        {

        }
    }
    #endregion

}
