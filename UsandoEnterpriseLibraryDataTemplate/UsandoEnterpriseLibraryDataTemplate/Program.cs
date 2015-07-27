using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsandoEnterpriseLibraryDataTemplate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira um número: ");
            var id = Console.ReadLine();

            using (Data.ClassManipulation db = new Data.ClassManipulation())
            {
                var lista = db.ObterDados(Convert.ToInt32(id));

                if(lista != null)
                {
                    foreach(var item in lista)
                    {
                        Console.WriteLine(item.Nome);
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
