using System;

namespace DocumentFactoryDemo
{
    // Interface representing a generic document
    public interface IDocument
    {
        void Open();
    }

    // Concrete Document Classes
    public class WordDocument : IDocument
    {
        public void Open()
        {
            Console.WriteLine("Opening Microsoft Word document...");
        }
    }

    public class PdfDocument : IDocument
    {
        public void Open()
        {
            Console.WriteLine("Opening PDF document...");
        }
    }

    public class ExcelDocument : IDocument
    {
        public void Open()
        {
            Console.WriteLine("Opening Excel spreadsheet...");
        }
    }

    // Abstract Creator
    public abstract class DocumentFactory
    {
        public abstract IDocument CreateDocument();
    }

    // Concrete Factories
    public class WordDocumentFactory : DocumentFactory
    {
        public override IDocument CreateDocument()
        {
            return new WordDocument();
        }
    }

    public class PdfDocumentFactory : DocumentFactory
    {
        public override IDocument CreateDocument()
        {
            return new PdfDocument();
        }
    }

    public class ExcelDocumentFactory : DocumentFactory
    {
        public override IDocument CreateDocument()
        {
            return new ExcelDocument();
        }
    }

    // Main entry point
    class DocumentApp
    {
        static void Main(string[] args)
        {
            DocumentFactory wordFactory = new WordDocumentFactory();
            DocumentFactory pdfFactory = new PdfDocumentFactory();
            DocumentFactory excelFactory = new ExcelDocumentFactory();

            IDocument word = wordFactory.CreateDocument();
            IDocument pdf = pdfFactory.CreateDocument();
            IDocument excel = excelFactory.CreateDocument();

            word.Open();
            pdf.Open();
            excel.Open();
        }
    }
}
