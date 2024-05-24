namespace Full_GRASP_And_SOLID
{    
        public class FilePrinterCreator 
        {
            public FilePrinter filePrinter;
            public FilePrinterCreator()
            {
                FilePrinter filePrinter = new FilePrinter();
                this.filePrinter = filePrinter;
            }

        }
}