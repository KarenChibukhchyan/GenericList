using System;

namespace GenericList
{
    public class Program
    {
        public static void Main(string[] args)
        {
            GenericListClass<string> list = new GenericListClass<string>();
            list.Add("aaa");
            list.Add("bbb");
            list.Add("ccc");
            list.Add( "ddd");
            list.Insert(2, "qqq");
            Console.WriteLine(list);


            list.Remove("ccc");
            Console.WriteLine(list);

            list.Add("aaa");

            foreach (var element in list)
            {
                Console.WriteLine(element);
            }


            Console.WriteLine(list.LastIndexOf("aaa"));
        }
    }

}