using System;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool ans = true;
            while(ans)
            {
                Console.WriteLine("Enter the Employee Id: ");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Employee Name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Enter the Department Name: ");
                string departmentname = Console.ReadLine();
                Employee emp = new Employee(id, name, departmentname);
                emp.IdAdded += OnIdAdded;
                emp.NameAdded += OnNameAdded;
                emp.DepartmentAdded += OnDepartmentAdded;
                Console.WriteLine("\n");
                Console.WriteLine("Employee Id: {0}", emp.GetId);
                Console.WriteLine("Employee Name: {0}", emp.GetName);
                Console.WriteLine("Employee Department Name: {0}", emp.GetDepartmentName);
                Console.WriteLine("\nDo you want to modify the details (y/n)? ");
                string c = Console.ReadLine();
                if(c == "y")
                {
                    while(c=="y")
                    {
                        Console.WriteLine("\nEnter the property to modify: ");
                        Console.WriteLine("\nPress 1 to change Id.");
                        Console.WriteLine("\nPress 2 to change Id & Name.");
                        Console.WriteLine("\nPress 3 to change Id, Name & Department Name.");
                        int choice = Convert.ToInt32(Console.ReadLine());
                        switch(choice)
                        {
                        case 1:
                        {
                            Console.WriteLine("\nEnter Id: ");
                            int a = Convert.ToInt32(Console.ReadLine());
                            emp.modifymethod(a);
                            break;
                        }
                        case 2:
                        {
                            Console.WriteLine("\nEnter Id: ");
                            int a = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("\nEnter Name: ");
                            string b = Console.ReadLine();
                            emp.modifymethod(a, b);
                            break;
                        }
                        case 3:
                        {
                            Console.WriteLine("\nEnter Id: ");
                            int a = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("\nEnter Name: ");
                            string b = Console.ReadLine();
                            Console.WriteLine("\nEnter Department Name: ");
                            string s = Console.ReadLine();
                            emp.modifymethod(a, b, s);
                            break;
                        }
                        }
                        Console.WriteLine("After modifying: \n");
                        Console.WriteLine("Employee Id: {0}", emp.GetId);
                        Console.WriteLine("Employee Name: {0}", emp.GetName);
                        Console.WriteLine("Employee Department Name: {0}", emp.GetDepartmentName);
                        Console.WriteLine("\n\nDo you want to modify the details again (y/n)? ");
                        c = Console.ReadLine();
                    }
                    
                }
                Console.WriteLine("\n");
                Console.WriteLine("Enter 'stop' to exit or press 'Enter' to continue.");
                string ch = Console.ReadLine();
                if(ch=="stop")
                {
                    ans = false;
                }
            }
            static void OnIdAdded(object sender, EventArgs e)
            {
                Console.WriteLine("\nGetId() method called.\n");
            }
            static void OnNameAdded(object sender, EventArgs e)
            {
                Console.WriteLine("\nGetName() method called.\n");
            }
            static void OnDepartmentAdded(object sender, EventArgs e)
            {
                Console.WriteLine("\nGetDepartmentName() method called.\n");
            }
        }
    }
}
