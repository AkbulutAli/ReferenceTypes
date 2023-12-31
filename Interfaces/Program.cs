﻿namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // interfaceler newlenmezler.
            //IPersonManager customerManager = new CustomerManager();
            

            //IPersonManager employeeManager = new EmployeeManager();
            
            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(new InternManager());
        }
    }
    
    //class PersonManager
    //{
    //    //implemented opreation
    //    public void Add()
    //    {
    //        Console.WriteLine("Eklendi");
    //    }

    //}
    
    interface IPersonManager 
    {
        //unimplemented opration
        void Add();
        void Update();
    }

    //inherits - class -------------- implements - interface
    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            //müşteri ekleme kodları
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
            //personel ekleme kodları
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
       public void Add (IPersonManager personManager)
        {
            personManager.Add();
        }

        //public void AddCustomer( CustomerManager customerManager)
        //{
        //    customerManager.Add();
        //}

        //public void AddEmployee( EmployeeManager employeeManager)
        //{
        //    employeeManager.Add();
        //}
    }
}