using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sessrion5
{
    internal class Employee
    {
        #region Attributes
        public int ID;
        public string name;
        decimal salary;
        #endregion
        #region Constructor
        public Employee(int _id, string _name, decimal _Salary)
        {
            ID = _id;
            name = _name;
            salary = _Salary;
        }
        #endregion
        #region Methods
        public override string ToString()
        {
            return $"ID = {ID}, Name = {name}, Salary = {salary}";
        }
        #endregion
        #region Encapsulation
        //1-Encapsulation separate data definition (attributes) from its use(getter,setter - property - indexer)

        //getter
        public string getter() { return name; }

        //setter
        public void setter(string value)
        {
            name = value.Length <= 5 ? value : value.Substring(0, 5);
            //control data validation
        }

        //property
        //1-full property
        public decimal Salary
        {
            get {  return salary; } set { salary = value >= 4000 ? value : value = 4000; }
        }
        //2-automatic property
        public int age
        {
            get;
            set;
        }
        #endregion
    }
}
