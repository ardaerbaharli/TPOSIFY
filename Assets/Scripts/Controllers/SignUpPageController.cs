using System;
using Enums;
using Extensions;
using Models;
using UnityEngine;
using UnityEngine.UI;

namespace Controllers
{
    public class SignUpPageController : MonoBehaviour
    {
        private enum InputError
        {
            EmailExists,
            UsernameExists,
            InvalidEmailInput,
            InvalidUsernameInput,
            InvalidPasswordInput,
            None
        }

        [SerializeField] private InputField emailInput;
        [SerializeField] private InputField usernameInput;
        [SerializeField] private InputField passwordInput;
        [SerializeField] private Text errorMessageText;

        private string username;
        private string password;
        private string email;
        private User user;

        private InputError _error;

        private void Awake()
        {
            ClearPage();
            _error = InputError.None;
        }

        public void SignUpButtonClicked()
        {
            email = emailInput.text;
            username = usernameInput.text;
            password = passwordInput.text;
            if (!ValidateInput())
                ShowError();

            errorMessageText.gameObject.SetActive(false);

            user = new User(username, password, email);
            // TODO Save user to GameManager kind of controller to use it later. possibly => UserController
            PageController.Instance.ShowPage(Pages.Payment);
        }

        public void SignInButtonClicked()
        {
            PageController.Instance.ShowPage(Pages.SignIn);
        }

        private void ShowError()
        {
            var errorMessage = _error switch
            {
                InputError.InvalidEmailInput => "Email must be at least 5 characters long",
                InputError.EmailExists => "Email already exists",
                InputError.InvalidPasswordInput => "Password must be at least 8 characters long",
                InputError.InvalidUsernameInput => "Username must be at least 5 characters long",
                InputError.UsernameExists => "Username already exists",
                _ => ""
            };
            errorMessageText.text = errorMessage;
            errorMessageText.gameObject.SetActive(true);
        }

        private bool ValidateInput()
        {
            if (email.IsNullOrWhiteSpace() || email.Length < 5)
            {
                _error = InputError.InvalidEmailInput;
                return false;
            }

            if (username.IsNullOrWhiteSpace() || username.Length < 5)
            {
                _error = InputError.InvalidUsernameInput;
                return false;
            }

            if (password.IsNullOrWhiteSpace() || password.Length < 8)
            {
                _error = InputError.InvalidPasswordInput;
                return false;
            }

            if (DatabaseController.Instance.DoesEmailExists(email))
            {
                _error = InputError.EmailExists;
                return false;
            }

            if (DatabaseController.Instance.DoesUsernameExists(username))
            {
                _error = InputError.UsernameExists;
                return false;
            }

            return true;
        }

        private void ClearPage()
        {
            usernameInput.text = "";
            passwordInput.text = "";
            emailInput.text = "";
        }
    }
}