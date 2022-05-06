using Enums;
using Extensions;
using Models;
using UnityEngine;
using UnityEngine.UI;

namespace Controllers
{
    public class PaymentController : MonoBehaviour
    {
        private enum InputError
        {
            InvalidCCNumber,
            InvalidCCMonth,
            InvalidCCYear,
            InvalidCCCVV,
            PaymentFailed,
            None
        }

        [SerializeField] private InputField ccNumberInput;
        [SerializeField] private InputField ccMonthInput;
        [SerializeField] private InputField ccYearInput;
        [SerializeField] private InputField ccCVVInput;
        [SerializeField] private Text errorMessageText;

        private string ccNumber;
        private string ccMonth;
        private string ccYear;
        private string ccCVV;
        private InputError _error;

        private void Awake()
        {
            ClearPage();
            _error = InputError.None;
        }

        public void PayButton()
        {
            ccNumber = ccNumberInput.text;
            ccMonth = ccMonthInput.text;
            ccYear = ccYearInput.text;
            ccCVV = ccCVVInput.text;

            if (!ValidateInput())
                ShowError();

            errorMessageText.gameObject.SetActive(false);

            var paymentInfo = new Payment(ccNumber, ccMonth, ccYear, ccCVV);
            if (!ProcessPayment(paymentInfo))
            {
                ShowError();
                return;
            }

            PageController.Instance.ShowPage(Pages.Main);
        }

        private bool ProcessPayment(Payment paymentInfo)
        {
            return true;
        }


        private bool ValidateInput()
        {
            if (ccNumber.IsNullOrWhiteSpace() || ccNumber.Length != 16)
            {
                _error = InputError.InvalidCCNumber;
                return false;
            }

            if (ccMonth.IsNullOrWhiteSpace() || ccMonth.Length != 2)
            {
                _error = InputError.InvalidCCMonth;
                return false;
            }

            if (ccYear.IsNullOrWhiteSpace() || ccYear.Length != 4)
            {
                _error = InputError.InvalidCCYear;
                return false;
            }

            if (ccCVV.IsNullOrWhiteSpace() || ccCVV.Length != 3)
            {
                _error = InputError.InvalidCCCVV;
                return false;
            }

            return true;
        }

        private void ShowError()
        {
            var errorMessage = _error switch
            {
                InputError.InvalidCCNumber => "Please enter a valid credit card number",
                InputError.InvalidCCMonth => "Please enter a valid month",
                InputError.InvalidCCYear => "Please enter a valid year",
                InputError.InvalidCCCVV => "Please enter a valid CVV",
                InputError.PaymentFailed => "Payment failed",
                _ => ""
            };
            errorMessageText.text = errorMessage;
            errorMessageText.gameObject.SetActive(true);
        }

        private void ClearPage()
        {
            ccNumberInput.text = "";
            ccMonthInput.text = "";
            ccYearInput.text = "";
            ccCVVInput.text = "";
        }
    }
}