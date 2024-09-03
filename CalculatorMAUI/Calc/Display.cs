using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorMAUI.Calc
{
    public class Display
    {



        public void DisplayProcess(string Number1, string Number2, string operation, string equal)
        {
            Data data = new Data();
            {
                data.number1 = Number1;
                data.operation = operation;
                data.number2 = Number2;
                data.equal = equal;


                /// 一有就設置
                Eventhandlers.NotifyDisplayEvent(data);

            }


        }


        public void DisplayResult(string result)
        {
            Data data = new Data();
            data.result = result;

            Eventhandlers.NotifyEvent(data.result);
        }
    }
}
