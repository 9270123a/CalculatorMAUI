using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorMAUI.Calc
{
    public class ParameterControl
    {

        string Number1;
        string Number2;
        string operation;
        string equal;
        bool resultExist = false;
        bool secondoperation = true;
        string PreResult;

        CompleteModule completeModule = new CompleteModule();
        Display display = new Display();
        Data data = new Data();
        public void SetParameter(string button, ButtonType type)
        {

            switch (type)
            {
                case ButtonType.Oper:
                    this.operation = button;
                    break;
                case ButtonType.Number:
                    if (string.IsNullOrEmpty(operation) && !resultExist)
                    {
                        this.Number1 += button;
                    }
                    else
                    {
                        this.Number2 += button;
                    }
                    break;
                case ButtonType.Equals:
                    this.equal = button;
                    break;
            }

        }

        public void Check_Calculator()
        {


            data = completeModule.Complete_and_Calculator(Number1, Number2, operation, equal);
            display.DisplayProcess(data.number1, data.number2, data.operation, "=");
            display.DisplayResult(data.result);

            PreResult = data.result;

            this.Number1 = "";
            this.Number2 = "";
            this.operation = "";
            this.equal = "";


        }


        public void check_operator()
        {
            if (string.IsNullOrEmpty(Number2))
            {


                if (!string.IsNullOrEmpty(PreResult))
                {
                    display.DisplayProcess(PreResult, operation, null, null);
                }
                else
                {
                    display.DisplayProcess(Number1, operation, null, null);

                }

            }
            else
            {
                data = completeModule.Complete_and_Calculator(Number1, Number2, operation, equal);
                display.DisplayProcess(data.result, data.operation, null, null);
                display.DisplayResult(data.result);
                PreResult = data.result;

                this.Number1 = "";
                this.Number2 = "";
                this.operation = "";
                this.equal = "";
            }




        }



    }
}
