using pET.Model.ParentsModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pET.Support;

namespace pET.Model
{
    internal class Dog : Animal, IAnimal
    {
        public Dog(int id) : base(id)
        {
        }

        public override string petSkill()
        {
            return Resour.petSkill(petSkillEnum.Dog);
        }

        public string sayNam()
        {
            return $"Hi Iam {name}";
        }

        public override string showInfo()
        {
            return $"Hi Iam {name} Iam {age} and my nick name is {nickName}";
        }

    }
    internal class Cat : Animal, IAnimal
    {
        public Cat(int id) : base(id)
        {
        }

        public override string petSkill()
        {
            return Resour.petSkill(petSkillEnum.Cat);
        }

        public string sayNam()
        {
            return $"Hi Iam {name}";
        }

        public override string showInfo()
        {
            return $"Hi Iam {name} Iam {age} and my nick name is {nickName}";
        }

    }
}
