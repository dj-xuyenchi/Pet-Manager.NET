using pET.Support;
using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pET.Controller.IController;
using static pET.Support.ErrSupport;
using pET.Model;

namespace pET.View
{
    internal class ApplicationProgram
    {
        private IController cont;

        public ApplicationProgram()
        {
            cont = new Controller.Controller();
            menu();
        }

        private void menu()
        {
            Clear();
            WriteLine("------------Pet Hhihi----------------");
            WriteLine("1.Thêm mới");
            WriteLine("2.Sửa");
            WriteLine("3.Xóa");
            WriteLine("4.Xem danh sách");
            WriteLine("5.Thóat");
            char checkMethod = char.Parse(InputStaticClass.stringReturn("Chọn chức năng: ", "Lỗi chọn lại", 0, 2));
            doMethod(checkMethod);
           
        }
        private void doMethod(char c)
        {
            int id;
            int find;

            switch (c)
            {
                case '1':
                    id = InputStaticClass.intReturn("Nhập ID: ", "Nhập sai nhập lại!", 0, 10);
                    find = cont.getList().FindIndex(x => id == x.id);
                    if (find == -1)
                    {
                        Console.WriteLine(log(cont.addNew(new Dog(id))));
                        break;
                    }
                    Console.WriteLine("Ma ton tai");
                    break;
                case '2':
                    Console.WriteLine(log(cont.remake(new Dog(InputStaticClass.intReturn("Nhap id", "Loi", 0, 10)))));
                    break;
                case '3':
                    id = InputStaticClass.intReturn("Nhập ID: ", "Nhập sai nhập lại!", 0, 10);
                    Console.WriteLine(log(cont.remove(id)));
                    break;
                case '4':
                    Console.WriteLine(log(cont.show()));
                    break;
                case '5':
                    Environment.Exit(0);
                    break;
                default:
                    break;
            }
            string s = InputStaticClass.stringReturn("Nhập để tiếp tục: ", "Lỗi!!!", -1, 10);
            menu();
        }
    }
}
