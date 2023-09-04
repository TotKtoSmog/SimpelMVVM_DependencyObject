using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpelMVVM_DependencyObject.Models
{
    internal class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public static Person[] GetPerrsons() 
        {
            Person[] result = new Person[]
            {
                new Person(){LastName ="Супрунов",FirstName = "Трофим", Phone="+7 (943) 700-72-15", Email="trofim61@rambler.ru"},
                new Person(){LastName ="Заболотный",FirstName = "Илья", Phone="+7 (998) 722-50-62", Email="ilya47@outlook.com"},
                new Person(){LastName ="Курушина",FirstName = "Лана", Phone="+7 (980) 522-98-79", Email="lana14021964@mail.ru"},
                new Person(){LastName ="Мамонтова",FirstName = "Алина", Phone="+7 (947) 917-47-28", Email="alina1966@outlook.com"},
                new Person(){LastName ="Лягушов",FirstName = "Трофим", Phone="+7 (931) 671-99-13", Email="trofim9911@ya.ru"},
                new Person(){LastName ="Поджио",FirstName = "Даниил", Phone="+7 (906) 830-70-71", Email="daniil.podjio@rambler.ru"},
                new Person(){LastName ="Заседателев",FirstName = "Никита", Phone="+7 (953) 185-49-71", Email="nikita.zasedatelev@rambler.ru"},
                new Person(){LastName ="Ерофеева",FirstName = "Татьяна", Phone="+7 (992) 166-95-46", Email="tatyana7433@outlook.com"},
                new Person(){LastName ="Осинова",FirstName = "Вероника", Phone="+7 (995) 462-35-49", Email="veronika70@gmail.com"},
                new Person(){LastName ="Бендлина",FirstName = "Анна", Phone="+7 (944) 374-44-93", Email="anna26101984@hotmail.com"}
            };
            return result;
        }
    }
}
