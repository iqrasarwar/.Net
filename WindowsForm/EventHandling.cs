/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm
{
    delegate void MyEventHandler();
    class Button
    {
        public event MyEventHandler click;     
        public void onClick()
        {
            if(click != null)
            {
                click(); //syntax to fire event is same as function call
            }
        }
    }
    class Event
    { 
        static void Main(string[] args)
        {
            Button b1 = new Button();
            //use += always to add function
            b1.click += () =>
            {
                Console.WriteLine("Enent is fired");
            };
        }
    }
}
*/