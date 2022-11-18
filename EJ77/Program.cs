using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ77
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList dicc_ing_esp = new SortedList();
            dicc_ing_esp.Add("hola", "hello");
            dicc_ing_esp.Add("chau", "good bye");
            dicc_ing_esp.Add("azul", "blue");
            dicc_ing_esp.Add("año", "year");
            dicc_ing_esp.Add("manzana", "apple");

            if (dicc_ing_esp.Contains("hola")) ;
            Console.WriteLine("La traduccion de hola es:");
            Console.WriteLine(dicc_ing_esp["hola"]);

            if (dicc_ing_esp.Contains("chau")) ;
            Console.WriteLine("La traduccion de chau es:");
            Console.WriteLine(dicc_ing_esp["chau"]);

            if (dicc_ing_esp.Contains("azul")) ;
            Console.WriteLine("La traduccion de azul es:");
            Console.WriteLine(dicc_ing_esp["azul"]);

            if (dicc_ing_esp.Contains("año")) ;
            Console.WriteLine("La traduccion de año es:");
            Console.WriteLine(dicc_ing_esp["año"]);

            if (dicc_ing_esp.Contains("manzana")) ;
            Console.WriteLine("La traduccion de manzana es:");
            Console.WriteLine(dicc_ing_esp["manzana"]);



            Console.ReadKey();
        }
    }
}
