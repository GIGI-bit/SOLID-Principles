namespace Before_S
{
    //Single Responsibility prinsipine emel etmedikde bir classin onlarla field ve memberi yaranir. Bele olduqda 1 obyekt yaratmaq ucun onlarla parametr yaratmaliyiq.
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int BirthDay { get; set; }
        public int BirthMonth { get; set; }
        public int BirthYear { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public Person()
        {
        }
        public Person(string name, string surname, int birthDay, int birthMonth, int birthYear, string country, string city, string street)
        {
            Name = name;
            Surname = surname;
            BirthDay = birthDay;
            BirthMonth = birthMonth;
            BirthYear = birthYear;
            Country = country;
            City = city;
            Street = street;
        }
    }

}

namespace After_S
{
    //Single responsibility prinsipine emel etsek yeni her bir classin sadece bir mesuliyyeti olsa obyekt yaratmaq asanlasar ve constructorlar daha seliqeli olar.
    //Prinsipe emel etmek ucun aralarinda aile hierarxiyasi olan deyisenleri bir class adi altinda birlesdirmek lazimdir
    public class Address
    {
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public Address() { }
        public Address(string city, string state, string country)
        {
            City = city;
            State = state;
            Country = country;
        }
    }
    public class Date
    {
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public Date(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public Date BithDate { get; set; }
        public Address Address { get; set; }
        public Person() { }
        public Person(string name, string surname, Date bithDate, Address address)
        {
            Name = name;
            Surname = surname;
            BithDate = bithDate;
            Address = address;
        }
    }

}