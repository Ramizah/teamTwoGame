using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

// Created by Caleb

public class CreateAccount : MonoBehaviour
{

    [SerializeField] Text errorText;
    [SerializeField] Canvas canvas;

    string username, password, emailAddress;

    //Like Sign in, checks useraccount manager and sends whether the account succeded or failed. It then logs the player in and loads Loading if it works and if not, will send error

    void OnEnable()
    {
        UserAccountManager.OnCreateAccountFailed.AddListener(OnCreateAccountFailed);
        UserAccountManager.OnSignInSuccess.AddListener(OnSignInSuccess);
    }

    void OnDisable()
    {
        UserAccountManager.OnCreateAccountFailed.RemoveListener(OnCreateAccountFailed);
         UserAccountManager.OnSignInSuccess.RemoveListener(OnSignInSuccess);
    }

    void OnCreateAccountFailed(string error)
    {
        errorText.gameObject.SetActive(true);
        errorText.text = error;
    }

    void OnSignInSuccess()
    {
        canvas.enabled = false;
        SceneManager.LoadScene("Loading");
    }

    public void UpdateUsername(string _username)
    {
        username = _username;
    }

    public void Updatepassword(string _password)
    {
        password = _password;
    }

    public void UpdateEmailAddress(string _emailAddress)
    {
        emailAddress = _emailAddress;
    }

    //Creates account with username emailaddress and password inputs

    public void AccountCreation()
    {
        UserAccountManager.instance.CreateAccount(username, emailAddress, password);
    }
}
