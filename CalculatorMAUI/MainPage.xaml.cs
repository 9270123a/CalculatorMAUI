using CalculatorMAUI.Calc;

namespace CalculatorMAUI;

public partial class MainPage : ContentPage
{

    ParameterControl parametercontroller = new ParameterControl();
    bool newinput = true;



    private void EventHandlers_ResultEvent(object sender, string e)
    {

        DisplayEntry.Text = e.ToString();
    }

    private void EventHandlers_DisplayEvent(object sender, Data e)
    {

        ProcessyEntry.Text = e.number1 + e.operation + e.number2 + e.equal;

    }
    public MainPage()
	{
        InitializeComponent();
        Eventhandlers.ResultEvent += EventHandlers_ResultEvent;
        Eventhandlers.DisplayEvent += EventHandlers_DisplayEvent;
    }

	private void Number_Clicked(object sender, EventArgs e)
	{
        Button button = (Button)sender;

        if (!newinput)
        {
            Clear();
            newinput = true;
        }

        DisplayEntry.Text += button.Text;
        ClickButton(button.Text);
    }

    private void Equals_Clicked(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        ClickButton(button.Text);
        parametercontroller.Check_Calculator();
    }

    private void Operator_Clicked(object sender, EventArgs e)
    {

        Button button = (Button)sender;
        ClickButton(button.Text);
        parametercontroller.check_operator();
        newinput = false;
    }

    private void Clear_Clicked(object sender, EventArgs e)
    {
        Clear();   
            }

    private void Clear()
    {
        DisplayEntry.Text = "";
    }
    private void ClickButton(string button)
    {
        switch (button)
        {
            case "+":
            case "-":
            case "/":
            case "*":
                parametercontroller.SetParameter(button, ButtonType.Oper);
                break;
            case "0":
            case "1":
            case "2":
            case "3":
            case "4":
            case "5":
            case "6":
            case "7":
            case "8":
            case "9":
                parametercontroller.SetParameter(button, ButtonType.Number);
                break;
            case "=":
                parametercontroller.SetParameter(button, ButtonType.Equals);
                break;

        }


    }
}

