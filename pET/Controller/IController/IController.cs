using pET.Model.ParentsModel;
using pET.Support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pET.Controller.IController
{
    internal interface IController
    {
        List<Animal> getList();
         Err addNew(Animal a);
        Err remove(int id);
        Err remake(Animal a);
        Err show();
    }
}
