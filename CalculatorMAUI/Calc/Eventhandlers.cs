using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorMAUI.Calc
{
    internal class Eventhandlers
    {
        //public static event EventHandler<string> MissingParameterEvent;
        public static event EventHandler<string> ResultEvent;
        public static event EventHandler<Data> DisplayEvent;


        public static void NotifyEvent(string number)
        {
            ResultEvent.Invoke(null, number);
        }
        public static void NotifyDisplayEvent(Data data)
        {
            DisplayEvent.Invoke(null, data);
        }




    }
}
