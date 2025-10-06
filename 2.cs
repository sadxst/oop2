using System;
using System.Windows.Forms;

namespace ООП_ПР3
{
    public class LegacyPrinter
    {
        public void Print(string message)
        {
            Console.WriteLine("LegacyPrinter: " + message);
        }
    }
    public interface IPrinter
    {
        void PrintToForm(string message, TextBox textBox);
    }
    public class PrinterAdapter : IPrinter
    {
        private LegacyPrinter _legacyPrinter;

        public PrinterAdapter(LegacyPrinter legacyPrinter)
        {
            _legacyPrinter = legacyPrinter;
        }
        public void PrintToForm(string message, TextBox textBox)
        {
            _legacyPrinter.Print(message);
            textBox.AppendText(message + Environment.NewLine);
        }
    }
}
