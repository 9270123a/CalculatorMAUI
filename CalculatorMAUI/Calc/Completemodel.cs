using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorMAUI.Calc
{
    internal class CompleteModule
    {

        bool receiveNum1;
        bool receiveNum2;
        bool receiveOper;
        bool receiveEqual;

        string prenum2;
        string preresult;
        string preopertion;




        string result;

        public Data Complete_and_Calculator(string Number1, string Number2, string Operation, string Equal)
        {
            Data data = new Data();
            Calculator calculator = new Calculator();
            Display display = new Display();
            receiveNum1 = string.IsNullOrEmpty(Number1);
            receiveNum2 = string.IsNullOrEmpty(Number2);
            receiveOper = string.IsNullOrEmpty(Operation);
            receiveEqual = string.IsNullOrEmpty(Equal);


            string number1 = "";
            string number2 = "";
            string operation = "";




            if (receiveNum1 && receiveNum2 && receiveOper)
            {
                number1 = preresult;
                number2 = prenum2;
                operation = preopertion;

            }//=
            else if (receiveNum1 && receiveNum2)
            {
                number1 = preresult;
                number2 = preresult;
                operation = Operation;

            }//+=
            else if (receiveNum2)
            {
                number1 = Number1;
                number2 = Number1;
                operation = Operation;

            }//3+=
            else if (receiveOper && receiveNum1)
            {
                number1 = preresult;
                number2 = Number2;
                operation = preopertion;

            }//沒有operation情況
            else if (receiveNum1)
            {
                number1 = preresult;
                number2 = Number2;
                operation = Operation;
            }//+3
            else
            {
                number1 = Number1;
                number2 = Number2;
                operation = Operation;
            }




            result = calculator.calculater(double.Parse(number1), double.Parse(number2), operation).ToString();


            prenum2 = number2;
            preresult = result;
            preopertion = operation;


            data.number1 = number1;
            data.number2 = number2;
            data.operation = operation;
            data.result = result;

            return data;
        }



    }
}
