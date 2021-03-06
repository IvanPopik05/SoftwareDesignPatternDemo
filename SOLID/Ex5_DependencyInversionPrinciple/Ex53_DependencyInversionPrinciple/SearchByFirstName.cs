using System;
using System.Linq;

namespace Ex53_DependencyInversionPrinciple
{
    public class SearchByFirstName
    {
        IFindStorage storage;
        public SearchByFirstName(IFindStorage storage) => this.storage = storage;

        public void Search()
        {
            foreach (var p in storage.FindAll(e => e.FirstName.Contains("Name_3")))
            {
                Console.WriteLine($"{p.FirstName} {p.Age}");
            }
            Console.WriteLine();
        }
    }
}
