using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Before_D
{
    // Dependency Inversion prinsipine esasen boyuk classlar kicik class-lardan asili olmamalidir
    // Asagidaki numunede Store class-i Dress(don) classindan asilidir basqa constructor olmadigina gore Dress classinin obyecti olmadan Store yarana bilmez
    // Bes eyer biz sadece Jacket satan magaza yaratmaq istesek ne olacaq? Beli Store classinin obyecti yara bilmeyecek
    class Cloth
    {
        public string Color { get; set; }
        public string Material { get; set; }
        public Cloth()
        {
            
        }
    }
    class Dress : Cloth
    {
        public string Size { get; set; }
        public Dress() { }
    }
    class Jacket : Cloth
    {
        public int Size { get; set; }
        public Jacket() { }
    }

    internal class Store
    {
        public Store(Dress dress)
        {
            
        }
    }
}

namespace After_D
{
    // Burada ise Store class-i birbasa Cloth class-indan asili oldugu ucunu Cloth classindan yaranmis butun obyectleri qebul ede biler
    class Cloth
    {
        public string Color { get; set; }
        public string Material { get; set; }
        public Cloth()
        {

        }
    }
    class Dress : Cloth
    {
        public string Size { get; set; }
        public Dress() { }
    }
    class Jacket : Cloth
    {
        public int Size { get; set; }
        public Jacket() { }
    }

    internal class Store
    {
        public Store(Cloth clothes)
        {

        }
    }
}
