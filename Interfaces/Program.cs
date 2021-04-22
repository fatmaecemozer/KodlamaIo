using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //interface new'lenemez
            // IPersonManager personManager = new IPersonManager(); YANLIŞ!!
            
            IPersonManager customerManager = new CustomerManager();
            //customerManager.Add();
            
            //interfaceler referans tiptir
            //kendisini implemente eden classın referans numarasını tutabilir
            IPersonManager employeeManager = new EmployeeManager();
            // employeeManager.Add();

            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(customerManager);
            projectManager.Add(employeeManager);
            projectManager.Add(new InternManager());
        }
    }

    interface IPersonManager
    {
        //unimplemented operation!!
        public void Add();
        public void Update();
        
    }
    //interface olduğu için imza aynı ama implementasyonu farklı
    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Müşteri eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Müşteri güncellendi");
        }
    }
    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Personel eklendi");
        }
        public void Update()
        {
            Console.WriteLine("Personel güncellendi");
        }
    }
    class InternManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Stajyer eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Stajyer güncellendi");
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
