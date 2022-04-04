using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

// Created by Caleb

public class SignIn : MonoBehaviour
{

    [SerializeField] Text errorText;
    [SerializeField] Canvas canvas;

    string username, password; //strings for the username and password that are typed by the player

    //Calls user account and checks if sign in has succeded or failed. Will then either send the user to Loading or set error text to true

    void OnEnable()
    {
        UserAccountManager.OnSignInFailed.AddListener(OnSignInFailed);
        UserAccountManager.OnSignInSuccess.AddListener(OnSignInSuccess);
    }

    void OnDisable()
    {
        UserAccountManager.OnSignInFailed.RemoveListener(OnSignInFailed);
        UserAccountManager.OnSignInSuccess.RemoveListener(OnSignInSuccess);
    }

    //Red error text below the input boxes

    void OnSignInFailed(string error)
    {
        errorText.gameObject.SetActive(true);
        errorText.text = error;
    }

    //When called, sets canvas to false and sends palyer to Loading

    void OnSignInSuccess()
    {
        canvas.enabled = false;
        SceneManager.LoadScene("Loading");
    }

    //Updates the variables for username and password respectively

    public void UpdateUsername(string _username)
    {
        username = _username;
    }

    public void Updatepassword(string _password)
    {
        password = _password;
    }

    //Finally, sings in the person

     public void SigningIn()
    {
        UserAccountManager.instance.SignIn(username, password);
    }
}
