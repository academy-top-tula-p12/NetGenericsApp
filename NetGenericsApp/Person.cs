using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetGenericsApp
{
    class Person<T> where T : class

    {
        public T Id { get; set; }
        public string? Name { get; set; }

        public Person(T id, string? name)
        {
            Id = id;
            Name = name;
        }
    }

    class Student<T> : Person<T>
        where T : class
    {
        public Student(T id, string? name) : base(id, name) { }
    }

    class Teacher : Person<string>
    {
        public Teacher(string id, string? name) : base(id, name)
        {
        }
    }

    class Manager<T> : Person<string>
    {
        public T Passport { get; set; }

        public Manager(string id, string? name) : base(id, name)
        {
        }
    }
}
