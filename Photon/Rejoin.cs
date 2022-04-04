using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine.SceneManagement;

public class Rejoin : MonoBehaviour
{

    public void CallRejoin()
    {
        StartCoroutine(Disconnect());
    }


    public IEnumerator Disconnect()
  {
    PhotonNetwork.Disconnect();
    while(PhotonNetwork.IsConnected)
    {
      yield return null;
      Debug.Log("Disconnecting...");
    }
    Debug.Log("Disconnected!");
    yield return new WaitForSeconds(1f);
    SceneManager.LoadScene("Loading");
  }

}
