using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetGenericsApp
{
    // Bad solution
    /*
    internal class Employee
    {
        public object? Id { get; set; }

        public string? Name { get; set; }
        public int Age {  get; set; }

        public Employee(object? id, string? name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }
    }
    */

    class Passport<T>
    {
        public string? Series { get; set; }
        public T? Number { get; set; }

        public override string ToString()
        {
            return $"Passport: {Series}/{Number}";
        }
    }

    class Employee<T, U>
    {
        public T Id { get; set; }

        public static U? Code;


        public string? Name { get; set; }
        public int Age { get; set; }

        public Employee(T id, string? name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Age: {Age}";
        }
    }
}
