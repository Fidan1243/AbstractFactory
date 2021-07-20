using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    interface GUIFactory
    {
        Button CreateButton();
        CheckBox CreateCheckBox();
    }
    abstract class Button
    {
        public abstract void Paint();
        
    }

    abstract class CheckBox
    {
        public abstract void CheckBox1();
    }

    class MacButton : Button
    {
        public override void Paint()
        {
            Console.WriteLine("Hello, I'm Mac Button") ;
        }
    }
    class MacCheckBox : CheckBox
    {
        public override void CheckBox1()
        {
            Console.WriteLine("Hello I'm Mac Check Box"); ;
        }
    }

    class WinButton : Button
    {
        public override void Paint()
        {
            Console.WriteLine("Hello, I'm Windows Button");
        }
    }
    class WinCheckBox : CheckBox
    {
        public override void CheckBox1()
        {
            Console.WriteLine("Hello, I'm Windows Check Box");
        }
    }


    class MacFactory : GUIFactory
    {
        public Button CreateButton()
        {
            return new MacButton();
        }

        public CheckBox CreateCheckBox()
        {
            return new MacCheckBox();
        }
    }

    class WinFactory : GUIFactory
    {
        public Button CreateButton()
        {
            return new WinButton();
        }

        public CheckBox CreateCheckBox()
        {
            return new WinCheckBox();
        }
    }
    class Aplication
    {
        private GUIFactory Factory { get; set; }
        private Button Button { get; set; }
        public Aplication(GUIFactory factory)
        {
            Factory = factory;
        }
        public void CreateUI()
        {
            Button = Factory.CreateButton();
        }
        public void Paint()
        {
            Button.Paint();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            GUIFactory mac = new MacFactory();
            Aplication ap1 = new Aplication(mac);
            ap1.CreateUI();
            ap1.Paint();
        }
    }
}
