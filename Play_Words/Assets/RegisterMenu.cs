using System;
using FiroozehGameService.Core;
using FiroozehGameService.Models;
using FiroozehGameService.Models.BasicApi;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class RegisterMenu : MonoBehaviour
{   
    public string userName;
    public string password;
    public string email;
    private string _phoneNumber;
    private string _smsCode;
    public GameObject loggin;
    public GameObject register;
    public GameObject haveAnAccount;
    public InputField passwordInputField;
    public InputField emailInputField;
    public InputField nameInputField;
    public InputField phoneNumberInputField;
    public InputField smsCodeInputField;
    public Text error;
    public Text waiting;
    public Text phoneNumberText;
    public Text pleaseEnterYourPhoneNumber;
    public GameObject panel;
    public GameObject enterThePhoneNumberPanel;
    public GameObject enterTheSmsCodePanel;
    public GameObject enterTheUserNamePanel;
    async void Start()
    {
        try
        {
            if (Application.internetReachability != NetworkReachability.NotReachable)
            {
                if (GameSaveSystem.Instans.IsLoginBefore())
                {
                    var userToken = GameSaveSystem.Instans.GetUserToken();
                    await GameService.Login(userToken);
                    SceneManager.LoadScene(2);

                }
                else
                {
                    panel.SetActive(true);
                    waiting.gameObject.SetActive(false);
                }
            }
            else
            {
                SceneManager.LoadScene(2);

            }

        }
        catch(GameServiceException e)
        {
            Debug.LogError(e.Message);
            error.text = e.Message;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    public void HaveAccountAlready()
    {
        register.SetActive(false);
        haveAnAccount.SetActive(false);
        nameInputField.gameObject.SetActive(false);
        loggin.SetActive(true);
    }

    public  async  void Login()
    {        error.text = null;

        try
        {
            var userToken = await GameService.Login( email, password);
            GameSaveSystem.Instans.SetLoginBefore(1);
            GameSaveSystem.Instans.SetUserToken(userToken);
            GameSaveSystem.Instans.SetPassword(password);
            SceneManager.LoadScene(1);
        }
        catch (GameServiceException e)
        {
            Console.WriteLine(e);
            error.text = e.Message;
            throw;
            
        }
       
    }

    public async void Register()
    {
        error.text = null;

        try
        {
            var userToken = await GameService.SignUp(userName, email, password);
            GameSaveSystem.Instans.SetUserToken(userToken);
            GameSaveSystem.Instans.SetPassword(password);
            

            SceneManager.LoadScene(1);
        }
        catch (GameServiceException e)
        {
            Console.WriteLine(e);
            error.text = e.Message;

            throw;
        }
       
    }

    public void PasswordField()
    {
        password = passwordInputField.text;
    }

    public void EmailField()
    {
        email = emailInputField.text;
    }

    public void NameField()
    {
        userName = nameInputField.text;
        Debug.Log(userName);
    }

    public void PhoneNumber()
    {
        _phoneNumber = phoneNumberInputField.text;
        phoneNumberText.text = _phoneNumber;
        Debug.Log(_phoneNumber);
    }

    public  async void SendSms()
    {
        try
        {
         await GameService.SendLoginCodeWithSms(_phoneNumber);
         enterThePhoneNumberPanel.SetActive(false);
         enterTheSmsCodePanel.SetActive(true);

        }
        catch (Exception e)
        
        {  Debug.LogError(e.Message);
            throw new GameServiceException("Please Enter Your Phone Number");
            
        }
    }

    public void smsCode()
    {
        _smsCode = smsCodeInputField.text;
        Debug.Log(_smsCode);
    }
    //
    public async void SignIn()
    {
        try
        {
            var token = await GameService.LoginWithPhoneNumber(name, _phoneNumber, _smsCode);
            GameSaveSystem.Instans.SetLoginBefore(1);
            GameSaveSystem.Instans.SetUserToken(token);
            enterTheSmsCodePanel.SetActive(false);
            enterTheUserNamePanel.SetActive(true);

        }
        catch (Exception e)
        { pleaseEnterYourPhoneNumber.gameObject.SetActive(true);
            Debug.LogError(e.Message);
            throw new GameServiceException("your sms Code is Wrong");
           
        }
      
    }
    
    public  void changeUserName()
    {
        SceneManager.LoadScene(2);

    }
}
