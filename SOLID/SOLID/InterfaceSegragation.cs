using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Before_I
{
    // Asagidaki numunede sadece bir interface var ve iki class implement olunur ancaq bu class-lardan biri oxunub deyise bilen
    // digeri ise sadece oxuna bilen document obyectleri yaradir.
    // Ancaq bizim IDocument interface-imizde he Delete hem Save hemde ki, Open method-lari var. Bele olduqda ReadonlyDocument-in mentiqi pozulur
    interface IDocument
    {
        public void Open();
        public void Save();
        public void Delete();
        public void Write();
    }
    internal class Document:IDocument
    {
        public string Title { get; set; }
        public string Body { get; set; }
        public Document() { }

        public void Delete()
        {
            Console.WriteLine("Document Deleted!");
        }

        public void Open()
        {
            Console.WriteLine("Document Open!");
        }

        public void Save()
        {
            Console.WriteLine("Document Save!");
        }

        public void Write()
        {
            Console.WriteLine("Document Written!");
        }
    }

    class ReadonlyDocument:Document,IDocument
    {
        public ReadonlyDocument()
        {
            
        }

        public void Delete()
        {
            Console.WriteLine("Document Deleted!");
        }

        public void Open()
        {
            Console.WriteLine("Document Open!");
        }

        public void Save()
        {
            Console.WriteLine("Document Save!");
        }

        public void Write()
        {
            Console.WriteLine("Document Written!");
        }
    }


}

namespace After_I
{
    // Burda ise prinsipe emel ederek Interface-leri hisselere boluruk ve hansi method lazimdirsa onu implement edirik
    // Bir class-i istenilen sayda interface-den implement ede bildiyimiz ucun istenilen sayda interface yarada bilersiniz
    interface ISaveDoc
    {
        public void Save();
    }
    interface IOpenDoc
    {
        public void Open();

    }
    interface IDeleteDoc
    {
        public void Delete();
    }
    interface IWriteDoc
    {
        public void Write();
    }

    internal class Document:IDeleteDoc,ISaveDoc,IOpenDoc,IWriteDoc
    {
        public string Title { get; set; }
        public string Body { get; set; }
        public Document() { }


        public void Delete()
        {
            Console.WriteLine("Document Deleted!");
        }

        public void Open()
        {
            Console.WriteLine("Document Open!");
        }

        public void Save()
        {
            Console.WriteLine("Document Save!");
        }

        public void Write()
        {
            Console.WriteLine("Document Written!");
        }
    }

    class ReadonlyDocument : Document, IDeleteDoc, ISaveDoc, IOpenDoc
    {
        public ReadonlyDocument()
        {

        }

        public void Delete()
        {
            Console.WriteLine("Document Deleted!");
        }

        public void Open()
        {
            Console.WriteLine("Document Open!");
        }

    }


}
