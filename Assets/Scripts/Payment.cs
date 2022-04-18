using UnityEngine.UI;

public class PaymentController
{
    public InputField ccNumberInput;
    public InputField ccMonthInput;
    public InputField ccYearInput;
    public InputField ccCVVInput;

    public void PayButton()
    {
    }

    public void ValidateInput()
    {
    }
}


public class Payment
{
    private string ccNumber;
    private string ccMonth;
    private string ccYear;
    private string ccCVV;

    public string CCNumber
    {
        get { return ccNumber; }
        set { ccNumber = value; }
    }

    public string CCMonth
    {
        get { return ccMonth; }
        set { ccMonth = value; }
    }

    public string CCYear
    {
        get { return ccYear; }
        set { ccYear = value; }
    }

    public string CCCVV
    {
        get { return ccCVV; }
        set { ccCVV = value; }
    }
}