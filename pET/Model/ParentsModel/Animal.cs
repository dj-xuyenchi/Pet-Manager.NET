using pET.Support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pET.Model.ParentsModel
{
    internal abstract class Animal
    {
        protected Animal(int id)
        {
            this.id = id;
            name = InputStaticClass.stringReturn("Nhập tên", "Nhập Lại",5,100);
            nickName =InputStaticClass.stringReturn("Nhập biệt danh", "Nhập Lại", 5, 100);
            age = InputStaticClass.intReturn("Nhập tuổi", "Lỗi mời nhập lại", 0,15);
        }

        protected Animal(int id, string name, int age, string nickName)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.nickName = nickName;
        }

        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public string nickName { get; set; }
    
        public abstract string petSkill();
        public abstract string showInfo();
    }
}
