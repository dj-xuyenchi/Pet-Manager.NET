using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pET.Support
{
    enum petSkillEnum
    {
        Dog, Cat, Hamster
    }
    internal class Resour
    {

        public static string petSkill(petSkillEnum pse)
        {
            switch (pse)
            {
                case petSkillEnum.Dog:
                    return "Wow Wow";
                case petSkillEnum.Cat:
                    return "Mew Mew";
                case petSkillEnum.Hamster:
                    return "Chit Chit";
                default:
                    return "";
            }

        }
    }
}
