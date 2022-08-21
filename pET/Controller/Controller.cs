using pET.Model.ParentsModel;
using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pET.Controller.IController;
using pET.Model;
using pET.Support;

namespace pET.Controller
{
    internal class Controller : IController.IController
    {
        private List<Animal> list;

        public Controller()
        {
            list = new List<Animal>();
            //  addNew();
        }


        public void addNew()
        {
            list.Add(new Dog(1));
            list.Add(new Cat(2));
        }

        public Err addNew(Animal a)
        {
            int findExist = list.FindIndex(x => x.id == a.id);
            if (findExist == -1)
            {
                list.Add(a);
                return Err.SUCCESSFULL;
            }
            else
            {
                return Err.EXIST;
            }
        }

        public List<Animal> getList()
        {
            return list;
        }

        public Err remake(Animal a)
        {
            int findExist = list.FindIndex(x => x.id == a.id);
            if (findExist == -1)
            {
                return Err.DOESTEXIST;
            }
            else
            {
                list[findExist] = a;
                return Err.SUCCESSFULL;
            }
        }

        public Err remove(int id)
        {
            int findExist = list.FindIndex(x => x.id == id);
            if (findExist == -1)
            {
                return Err.DOESTEXIST;
            }
            else
            {
                list.RemoveAt(findExist);
                return Err.SUCCESSFULL;
            }
        }

        public Err show()
        {
            if (list.Count == 0)
            {
                return Err.NULL;
            }
            else
            {
                foreach (Animal a in list)
                {
                    Console.WriteLine(a.showInfo());
                }
                return Err.SUCCESSFULL;
            }
        }
    }
}
