using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using PlayFab;
using PlayFab.ClientModels;

// Created by Caleb and Jaskaran

public class UserAccountManager : MonoBehaviour
{

    //creates an instance so it can be read by the other file (singelton)

    public static UserAccountManager instance;
    public AudioManager Audio;

    public static UnityEvent OnSignInSuccess = new UnityEvent();

    public static UnityEvent<string> OnSignInFailed = new UnityEvent<string>();


    public static UnityEvent<string> OnCreateAccountFailed = new UnityEvent<string>();

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        Audio = FindObjectOfType<AudioManager>();
        Audio.Play("End");
    }

    //For account creation takes in 3 strings inputed from createaccount file

    public void CreateAccount(string username, string emailAddress, string password)
    {

        //Calls Playfab and sets the string of each variable to the actual Playfab variables for Email Password or Username
        PlayFabClientAPI.RegisterPlayFabUser(
            new RegisterPlayFabUserRequest()
            {
                Email = emailAddress,
                Password = password,
                Username = username,
            },
            //If successful, creates an account based in these variables
            //sets display name to username for leaderboard
            response => 
            {
                Debug.Log($"Successful Account Creation: {username}, {emailAddress}");
                PlayFabClientAPI.UpdateUserTitleDisplayName(new UpdateUserTitleDisplayNameRequest {DisplayName = username}, OnDisplayName, OnError);
                SignIn (username, password);
            },
            //If unsuccessful, sends error with username, email and error message
            error =>
            {
                Debug.Log($"Unsuccessful Account Creation: {username}, {emailAddress} \n {error.ErrorMessage}");
                OnCreateAccountFailed.Invoke(error.ErrorMessage);
            }
        );
    }

    //Shows display name when it is set in character creation

    void OnDisplayName(UpdateUserTitleDisplayNameResult result)
    {
        Debug.Log(result.DisplayName + "is your new display name");
    }

    //Chekcs database for specific username and password and either successfuly logs in or fails

    public void SignIn(string username, string password)
    {
        PlayFabClientAPI.LoginWithPlayFab (
            new LoginWithPlayFabRequest () 
            {
                Username = username,
                Password = password
            },
            response => 
            {
                Debug.Log($"Successful Account Login: {username}");
                OnSignInSuccess.Invoke();
            },
            error => 
            {
                Debug.Log($"Unsuccessful Account Login: {username} \n {error.ErrorMessage}");
                OnSignInFailed.Invoke(error.ErrorMessage);
            }
        );
    }

    //On error, sends error report

    void OnError(PlayFabError error)
    {
        Debug.Log("Error with Leaderboard entry");
        Debug.Log(error.GenerateErrorReport());
    }

    //Sends the values of leaderboard when player wins

    public void SendLeaderboard(int score)
    {
        var request = new UpdatePlayerStatisticsRequest
        {
            Statistics = new List<StatisticUpdate>
            {
                new StatisticUpdate 
                {
                    StatisticName = "GamesWon",
                    Value = score
                }
            }
        };
        PlayFabClientAPI.UpdatePlayerStatistics(request, OnLeaderboardUpdate, OnError);
    }


    void OnLeaderboardUpdate(UpdatePlayerStatisticsResult result)
    {
        Debug.Log("Successful Leaderboard entry sent!");
    }

}
