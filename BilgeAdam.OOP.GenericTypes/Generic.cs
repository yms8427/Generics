using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeAdam.OOP.GenericTypes
{
    class Generic
    {
        public Generic()
        {
            //ArrayList a = new ArrayList();
            //a.Add("sdfsdf");
            //a.Add(4);

            //var names = new string[2];
            //names[0] = "Can";
            //names[1] = "Canan";
            //Array.Resize(ref names, 3);
            //names[2] = "Cem";
            //Array.Resize(ref names, 2);

            var list1 = new List<string>();
            var list2 = new List<int>();
            var list3 = new List<Fake>();

            list1.Add("Elma");
            list1.Add("Armut");
            //list1.Add(4);

            list2.Add(2);
            list2.Add(122);

            list3.Add(new Fake { Number = 2 });
            list3.Add(new Fake { Number = 5 });
        }
    }

    class Fake
    {
        public int Number { get; set; }
    }
}
