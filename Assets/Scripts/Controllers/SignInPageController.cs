using System;
using Enums;
using Extensions;
using Models;
using UnityEngine;
using UnityEngine.UI;

namespace Controllers
{
    public class SignInPageController : MonoBehaviour
    {
        private enum InputError
        {
            InvalidUsernameInput,
            InvalidPasswordInput,
            CredentialsIncorrect,
            None
        }

        [SerializeField] private InputField usernameInput;
        [SerializeField] private InputField passwordInput;
        [SerializeField] private Text errorMessageText;

        private string username;
        private string password;
        private User user;
        private InputError _error;

        private void Awake()
        {
            ClearPage();
            _error = InputError.None;
        }

        public void SignInButtonClicked()
        {
            username = usernameInput.text;
            password = passwordInput.text;

            if (!ValidateInput())
            {
                ShowError();
                return;
            }

            errorMessageText.gameObject.SetActive(false);

            user = DatabaseController.Instance.GetUser(username);
            // TODO Save user to GameManager kind of controller to use it later. possibly => UserController
            PageController.Instance.ShowPage(Pages.Main);
            gameObject.SetActive(false);
        }

        public void SignUpButtonClicked()
        {
            PageController.Instance.ShowPage(Pages.SignUp);
        }


        private bool ValidateInput()
        {
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

            return true;
        }

        private void ShowError()
        {
            var errorMessage = _error switch
            {
                InputError.InvalidPasswordInput => "Password must be at least 8 characters long",
                InputError.InvalidUsernameInput => "Username must be at least 5 characters long",
                InputError.CredentialsIncorrect => "Username or password is incorrect",
                _ => ""
            };
            errorMessageText.text = errorMessage;
            errorMessageText.gameObject.SetActive(true);
        }

        private void OnDisable()
        {
            ClearPage();
        }

        private void ClearPage()
        {
            usernameInput.text = "";
            passwordInput.text = "";
        }
    }
}