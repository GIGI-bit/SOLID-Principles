using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Before_L
{
    // Xanim Liskov-un dediyine gore derived class base class-i evez ede bilmelidir
    // Asagidaki numunede bu prinsipi yerine yetirmek olmur cunki introduceYourself (ozunu teqdim et) adli funksiya sadece Person class-ina mexsusdur
    // student class-i person-dan yaranmasina baxmayaraq base class-i evez ede bilmez
    internal class Person
    {
        public int Age { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public Person()
        {

        }
        public string introduceYourself()
        {
            return $"Hello my name is {FirstName} {LastName}. I'm {Age} years old.";
        }
    }

   class Student : Person
    {
        public Student()
        {
            
        }
        public void Study()
        {
            Console.WriteLine("Study func called.");
        }
    }

}

namespace After_L
{
    // Liskov Substitution prinsipine emel ede bilmek ucun introduceYourself funksiyasini virtual edirik ve derived-lerde override edirik 
    // belece artiq studentde ozunu teqdim ede biler
    internal class Person
    {
        public int Age { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public Person()
        {

        }
        public virtual string introduceYourself()
        {
            return $"Hello my name is {FirstName} {LastName}. I'm {Age} years old.";
        }
    }
    class Student : Person
    {
        public Student()
        {

        }
        public void Study()
        {
            Console.WriteLine("Study func called.");
        }
        public override string introduceYourself()
        {
            return (base.introduceYourself() + "Currently I am a student.");
        }
    }
}
