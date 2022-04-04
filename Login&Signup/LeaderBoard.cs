using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using PlayFab;
using PlayFab.ClientModels;

// Created by Caleb

public class LeaderBoard : MonoBehaviour
{
    public GameObject UILeaderboard;
    public GameObject rowPrefab;
    public Transform rowsParent;

    void Start()
    {
        UILeaderboard.SetActive(false);
    }

    public void OpenLeaderBoard()
    {
        UILeaderboard.SetActive(true);
    }

    public void CloseLeaderBoard()
    {
        UILeaderboard.SetActive(false);
    }

    public void GetLeaderboard()
    {
        var request = new GetLeaderboardRequest
        {
            StatisticName = "GamesWon",
            StartPosition = 0,
            MaxResultsCount = 10
        };
        PlayFabClientAPI.GetLeaderboard(request, OnLeaderboardGet, OnError);
    }
    
    void OnLeaderboardGet(GetLeaderboardResult result)
    {
        foreach(Transform item in rowsParent)
        {
            Destroy(item.gameObject);
        }

        foreach(var item in result.Leaderboard)
        {
            GameObject newGo = Instantiate(rowPrefab, rowsParent);
            Text[] texts = newGo.GetComponentsInChildren<Text>();

            texts[0].text = (item.Position + 1).ToString();
            texts[1].text = item.DisplayName;
            texts[2].text = item.StatValue.ToString();

            Debug.Log("Place: " + item.Position + " " + "Id: " + item.PlayFabId + " " + "Score: " + item.StatValue);
        }
    }

    void OnError(PlayFabError error)
    {
        Debug.Log("Error with Leaderboard being opened");
        Debug.Log(error.GenerateErrorReport());
    }

}
