using System;

namespace Interfaces
{
    class Program
    {
        //interfaceler new lenemez!
        static void Main(string[] args)
        {
            //IPersonManager customerManager = new CustomerManager();

            //IPersonManager employeeManager = new EmployeeManager();

            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(new CustomerManager());
           
        }
    }

    interface IPersonManager
    {
        //unİmplemented operation
        void Add();
        
        void Update();
    }

    //inherits - class ------------ implements - interface

    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            //musteri ekleme
            Console.WriteLine("Musteri Eklendi");

        }

        public void Update()
        {
            Console.WriteLine("Musteri Güncellendi");

        }
    }



    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            //personel ekleme kodları
            Console.WriteLine("Personel Eklendi");

        }

        public void Update()
        {
            Console.WriteLine("Personel Güncellendi");

        }
    }

    class ProjectManager
    {
        public void Add(IPersonManager personManager)
        {
             personManager.Add();
        }

    }
}
