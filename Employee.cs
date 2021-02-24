using System;

namespace Assignment1
{
    public delegate void MethodAddedDelegate(object sender, EventArgs args);
    class Employee
    {
        private int Id;
        private string Name, DepartmentName;
        public Employee(int id, string name, string departmentname)
        {
            Id = id;
            Name = name;
            DepartmentName = departmentname;
        }
        public int GetId
        {
            get
            {
                IdAdded(this, new EventArgs());
                return Id;
            }
        }
        public string GetName
        {
            get
            {
                NameAdded(this, new EventArgs());
                return Name;
            }
        }
        public string GetDepartmentName
        {
            get
            {
                DepartmentAdded(this, new EventArgs());
                return DepartmentName;
            }
        }
        public void modifymethod(int id)
        {
            Id = id;
        }
        public void modifymethod(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public void modifymethod(int id, string name, string departmentname)
        {
            Id = id;
            Name = name;
            DepartmentName = departmentname;
        }
        public event MethodAddedDelegate IdAdded;
        public event MethodAddedDelegate NameAdded;
        public event MethodAddedDelegate DepartmentAdded; 
    }
}
