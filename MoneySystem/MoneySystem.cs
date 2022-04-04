using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class MoneySystem : MonoBehaviour
{
    public int moneyPlay1;
    public int moneyPlay2;
    public int TrainCountP1;
    public int TrainCountP2;
    public int FATE1;
    public int FATE2;
    public SetsandHousing Housing;
    public EndGame GameOver;
    public AudioManager Audio;

    // Created by Caleb

    //Entire file deals with the money trading of each potential property on the board

    //Although refactoring was used in most files, some like the money system and trading can be quite repetitive. I wasn't able to find a solution quick enough, hence the horror inducing code.

    //My apologies for the shocking nature of the CTRL + C and CTRL + V it was left after extensive debugging.

    //I've never made a game before and as long as the code works, I consider that an achievement :)

    //-----------------------A lot of bools------------------------------//

    public bool isBrought1;
    public bool isBrought2;
    public bool isBrought3;
    public bool isBrought4;
    public bool isBrought5;
    public bool isBrought6;
    public bool isBrought7;
    public bool isBrought8;
    public bool isBrought9;
    public bool isBrought10;
    public bool isBrought11;
    public bool isBrought12;
    public bool isBrought13;
    public bool isBrought14;
    public bool isBrought15;
    public bool isBrought16;
    public bool isBrought17;
    public bool isBrought18;
    public bool isBrought19;
    public bool isBrought20;
    public bool isBrought21;
    public bool isBrought22;
    public bool isBrought23;
    public bool isBrought24;
    public bool isBrought25;
    public bool isBrought26;
    public bool isBrought27;
    public bool isBrought28;


    public bool P1IsMine1;
    public bool P1IsMine2;
    public bool P1IsMine3;
    public bool P1IsMine4;
    public bool P1IsMine5;
    public bool P1IsMine6;
    public bool P1IsMine7;
    public bool P1IsMine8;
    public bool P1IsMine9;
    public bool P1IsMine10;
    public bool P1IsMine11;
    public bool P1IsMine12;
    public bool P1IsMine13;
    public bool P1IsMine14;
    public bool P1IsMine15;
    public bool P1IsMine16;
    public bool P1IsMine17;
    public bool P1IsMine18;
    public bool P1IsMine19;
    public bool P1IsMine20;
    public bool P1IsMine21;
    public bool P1IsMine22;
    public bool P1IsMine23;
    public bool P1IsMine24;
    public bool P1IsMine25;
    public bool P1IsMine26;
    public bool P1IsMine27;
    public bool P1IsMine28;

    public bool P2IsMine1;
    public bool P2IsMine2;
    public bool P2IsMine3;
    public bool P2IsMine4;
    public bool P2IsMine5;
    public bool P2IsMine6;
    public bool P2IsMine7;
    public bool P2IsMine8;
    public bool P2IsMine9;
    public bool P2IsMine10;
    public bool P2IsMine11;
    public bool P2IsMine12;
    public bool P2IsMine13;
    public bool P2IsMine14;
    public bool P2IsMine15;
    public bool P2IsMine16;
    public bool P2IsMine17;
    public bool P2IsMine18;
    public bool P2IsMine19;
    public bool P2IsMine20;
    public bool P2IsMine21;
    public bool P2IsMine22;
    public bool P2IsMine23;
    public bool P2IsMine24;
    public bool P2IsMine25;
    public bool P2IsMine26;
    public bool P2IsMine27;
    public bool P2IsMine28;

    public GameObject Player1Property1;
    public GameObject Player1Property2;
    public GameObject Player1Property3;
    public GameObject Player1Property4;
    public GameObject Player1Property5;
    public GameObject Player1Property6;
    public GameObject Player1Property7;
    public GameObject Player1Property8;
    public GameObject Player1Property9;
    public GameObject Player1Property10;
    public GameObject Player1Property11;
    public GameObject Player1Property12;
    public GameObject Player1Property13;
    public GameObject Player1Property14;
    public GameObject Player1Property15;
    public GameObject Player1Property16;
    public GameObject Player1Property17;
    public GameObject Player1Property18;
    public GameObject Player1Property19;
    public GameObject Player1Property20;
    public GameObject Player1Property21;
    public GameObject Player1Property22;
    public GameObject Player1Property23;
    public GameObject Player1Property24;
    public GameObject Player1Property25;
    public GameObject Player1Property26;
    public GameObject Player1Property27;
    public GameObject Player1Property28;

    public GameObject Player2Property1;
    public GameObject Player2Property2;
    public GameObject Player2Property3;
    public GameObject Player2Property4;
    public GameObject Player2Property5;
    public GameObject Player2Property6;
    public GameObject Player2Property7;
    public GameObject Player2Property8;
    public GameObject Player2Property9;
    public GameObject Player2Property10;
    public GameObject Player2Property11;
    public GameObject Player2Property12;
    public GameObject Player2Property13;
    public GameObject Player2Property14;
    public GameObject Player2Property15;
    public GameObject Player2Property16;
    public GameObject Player2Property17;
    public GameObject Player2Property18;
    public GameObject Player2Property19;
    public GameObject Player2Property20;
    public GameObject Player2Property21;
    public GameObject Player2Property22;
    public GameObject Player2Property23;
    public GameObject Player2Property24;
    public GameObject Player2Property25;
    public GameObject Player2Property26;
    public GameObject Player2Property27;
    public GameObject Player2Property28;


    public void Start()
    {
        TrainCountP1 = 0;
        TrainCountP2 = 0;
        Housing = FindObjectOfType<SetsandHousing>();
        GameOver = FindObjectOfType<EndGame>();
        Audio = FindObjectOfType<AudioManager>();

        moneyPlay1 = 1500;
        moneyPlay2 = 1500;

        isBrought1 = false;
        isBrought2 = false;
        isBrought3 = false;
        isBrought4 = false;
        isBrought5 = false;
        isBrought6 = false;
        isBrought7 = false;
        isBrought8 = false;
        isBrought9 = false;
        isBrought10 = false;
        isBrought11 = false;
        isBrought12 = false;
        isBrought13 = false;
        isBrought14 = false;
        isBrought15 = false;
        isBrought16 = false;
        isBrought17 = false;
        isBrought18 = false;
        isBrought19 = false;
        isBrought20 = false;
        isBrought21 = false;
        isBrought22 = false;
        isBrought23 = false;
        isBrought24 = false;
        isBrought25 = false;
        isBrought26 = false;
        isBrought27 = false;
        isBrought28 = false;

        P1IsMine1 = false;
        P1IsMine2 = false;
        P1IsMine3 = false;
        P1IsMine4 = false;
        P1IsMine5 = false;
        P1IsMine6 = false;
        P1IsMine7 = false;
        P1IsMine8 = false;
        P1IsMine9 = false;
        P1IsMine10 = false;
        P1IsMine11 = false;
        P1IsMine12 = false;
        P1IsMine13 = false;
        P1IsMine14 = false;
        P1IsMine15 = false;
        P1IsMine16 = false;
        P1IsMine17 = false;
        P1IsMine18 = false;
        P1IsMine19 = false;
        P1IsMine20 = false;
        P1IsMine21 = false;
        P1IsMine22 = false;
        P1IsMine23 = false;
        P1IsMine24 = false;
        P1IsMine25 = false;
        P1IsMine26 = false;
        P1IsMine27 = false;
        P1IsMine28 = false;

        P2IsMine1 = false;
        P2IsMine2 = false;
        P2IsMine3 = false;
        P2IsMine4 = false;
        P2IsMine5 = false;
        P2IsMine6 = false;
        P2IsMine7 = false;
        P2IsMine8 = false;
        P2IsMine9 = false;
        P2IsMine10 = false;
        P2IsMine11 = false;
        P2IsMine12 = false;
        P2IsMine13 = false;
        P2IsMine14 = false;
        P2IsMine15 = false;
        P2IsMine16 = false;
        P2IsMine17 = false;
        P2IsMine18 = false;
        P2IsMine19 = false;
        P2IsMine20 = false;
        P2IsMine21 = false;
        P2IsMine22 = false;
        P2IsMine23 = false;
        P2IsMine24 = false;
        P2IsMine25 = false;
        P2IsMine26 = false;
        P2IsMine27 = false;
        P2IsMine28 = false;

        //P1IsMine1 = true;
        //P1IsMine2 = true;
        //P1IsMine3 = true;
    //    P1IsMine4 = true;
    //    P1IsMine5 = true;
        //P1IsMine6 = true;
        //P1IsMine7 = true;
        //P1IsMine8 = true;
        //P1IsMine9 = true;
        //P1IsMine10 = true;
        //P1IsMine11 = true;
    //    P1IsMine12 = true;
    //    P1IsMine13 = true;
    //    P1IsMine14 = true;
    //    P1IsMine15 = true;
    //    P1IsMine16 = true;
    //    P1IsMine17 = true;
        //P1IsMine18 = true;
    //    P1IsMine19 = true;
    //    P1IsMine20 = true;
        //P1IsMine21 = true;
    //    P1IsMine22 = true;
    //    P1IsMine23 = true;
    //    P1IsMine24 = true;
    //    P1IsMine25 = true;
        //P1IsMine26 = true;
    //    P1IsMine27 = true;
    //    P1IsMine28 = true;

        //isBrought1 = true;
        //isBrought2 = true;
        //isBrought3 = true;
        //isBrought4 = true;
        //isBrought5 = true;
        //isBrought6 = true;
        //isBrought7 = true;
        //isBrought8 = true;
        //isBrought9 = true;
        //isBrought10 = true;
        //isBrought11 = true;
        //isBrought12 = true;
        //isBrought13 = true;
        //isBrought14 = true;
       // isBrought15 = true;
        //isBrought16 = true;
      //  isBrought17 = true;
     //   isBrought18 = true;
      //  isBrought19 = true;
      //  isBrought20 = true;
        //isBrought21 = true;
        //isBrought22 = true;
        //isBrought23 = true;
        //isBrought24 = true;
        //isBrought25 = true;
        //isBrought26 = true;
        //isBrought27 = true;
        //isBrought28 = true;
        
        //P2IsMine1 = true;
        //P2IsMine2 = true;
    //    P2IsMine3 = true;
        //P2IsMine4 = true;
     //   P2IsMine5 = true;
    //    P2IsMine6 = true;
        //P2IsMine7 = true;
   //     P2IsMine8 = true;
   //     P2IsMine9 = true;
        //P2IsMine10 = true;
    //    P2IsMine11 = true;
   //     P2IsMine12 = true;
    //    P2IsMine13 = true;
     //   P2IsMine14 = true;
    //    P2IsMine15 = true;
        //P2IsMine16 = true;
   //     P2IsMine17 = true;
    //    P2IsMine18 = true;
     //   P2IsMine19 = true;
    //    P2IsMine20 = true;
        //P2IsMine21 = true;
        //P2IsMine22 = true;
        //P2IsMine23 = true;
        //P2IsMine24 = true;
        //P2IsMine25 = true;
        //P2IsMine26 = true;
        //P2IsMine27 = true;
        //P2IsMine28 = true;

        Player1Property1.SetActive(false);
        Player1Property2.SetActive(false);
        Player1Property3.SetActive(false);
        Player1Property4.SetActive(false);
        Player1Property5.SetActive(false);
        Player1Property6.SetActive(false);
        Player1Property7.SetActive(false);
        Player1Property8.SetActive(false);
        Player1Property9.SetActive(false);
        Player1Property10.SetActive(false);
        Player1Property11.SetActive(false);
        Player1Property11.SetActive(false);
        Player1Property12.SetActive(false);
        Player1Property13.SetActive(false);
        Player1Property14.SetActive(false);
        Player1Property15.SetActive(false);
        Player1Property16.SetActive(false);
        Player1Property17.SetActive(false);
        Player1Property18.SetActive(false);
        Player1Property19.SetActive(false);
        Player1Property20.SetActive(false);
        Player1Property21.SetActive(false);
        Player1Property22.SetActive(false);
        Player1Property23.SetActive(false);
        Player1Property24.SetActive(false);
        Player1Property25.SetActive(false);
        Player1Property26.SetActive(false);
        Player1Property27.SetActive(false);
        Player1Property28.SetActive(false);

        Player2Property1.SetActive(false);
        Player2Property2.SetActive(false);
        Player2Property3.SetActive(false);
        Player2Property4.SetActive(false);
        Player2Property5.SetActive(false);
        Player2Property6.SetActive(false);
        Player2Property7.SetActive(false);
        Player2Property8.SetActive(false);
        Player2Property9.SetActive(false);
        Player2Property10.SetActive(false);
        Player2Property11.SetActive(false);
        Player2Property12.SetActive(false);
        Player2Property13.SetActive(false);
        Player2Property14.SetActive(false);
        Player2Property15.SetActive(false);
        Player2Property16.SetActive(false);
        Player2Property17.SetActive(false);
        Player2Property18.SetActive(false);
        Player2Property19.SetActive(false);
        Player2Property20.SetActive(false);
        Player2Property21.SetActive(false);
        Player2Property22.SetActive(false);
        Player2Property23.SetActive(false);
        Player2Property24.SetActive(false);
        Player2Property25.SetActive(false);
        Player2Property26.SetActive(false);
        Player2Property27.SetActive(false);
        Player2Property28.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        InfoMoney.instance.P2Info("P2: " + moneyPlay2);
        InfoMoney.instance.P1Info("P1: " + moneyPlay1);

        if(moneyPlay1 <= 0)
        {
            GameOver.GameOverP1();
        }
        if(moneyPlay2 <= 0)
        {
            GameOver.GameOverP2();
        }
    }

    public void MONEY_CONTROLLER(int Count)
    {
        PhotonView MoneyView = GetComponent<PhotonView>();

        if(Count == 0)
        {
            addMoney1(200);
            MoneyView.RPC("addMoney1", RpcTarget.Others, 200);
        }
        if(Count == 100)
        {
            Tax1(200);
            MoneyView.RPC("Tax1", RpcTarget.Others, 200);
        }
        if(Count == 1)
        {
            Prop1(60);
            MoneyView.RPC("Prop1", RpcTarget.Others, 60);
        }
        if(Count == 2)
        {
            Prop2(60);
            MoneyView.RPC("Prop2", RpcTarget.Others, 60);
        }
        if(Count == 3)
        {
            Prop3(200);
            MoneyView.RPC("Prop3", RpcTarget.Others, 200);
        }
        if(Count == 4)
        {
            Prop4(100);
            MoneyView.RPC("Prop4", RpcTarget.Others, 100);
        }
        if(Count == 5)
        {
            Prop5(100);
            MoneyView.RPC("Prop5", RpcTarget.Others, 100);
        }
        if(Count == 6)
        {
            Prop6(120);
            MoneyView.RPC("Prop6", RpcTarget.Others, 120);
        }
        if(Count == 7)
        {
            Prop7(140);
            MoneyView.RPC("Prop7", RpcTarget.Others, 140);
        }
        if(Count == 8)
        {
            FATE1 = Random.Range(1,500);
            Prop8(150);
            MoneyView.RPC("Prop8", RpcTarget.Others, 150);
        }
        if(Count == 9)
        {
            Prop9(140);
            MoneyView.RPC("Prop9", RpcTarget.Others, 140);
        }
        if(Count == 10)
        {
            Prop10(160);
            MoneyView.RPC("Prop10", RpcTarget.Others, 160);
        }
        if(Count == 11)
        {
            Prop11(200);
            MoneyView.RPC("Prop11", RpcTarget.Others, 200);
        }
        if(Count == 12)
        {
            Prop12(180);
            MoneyView.RPC("Prop12", RpcTarget.Others, 180);
        }
        if(Count == 13)
        {
            Prop13(180);
            MoneyView.RPC("Prop13", RpcTarget.Others, 180);
        }
        if(Count == 14)
        {
            Prop14(200);
            MoneyView.RPC("Prop14", RpcTarget.Others, 200);
        }
        if(Count == 15)
        {
            Prop15(220);
            MoneyView.RPC("Prop15", RpcTarget.Others, 220);
        }
        if(Count == 16)
        {
            Prop16(220);
            MoneyView.RPC("Prop16", RpcTarget.Others, 220);
        }
        if(Count == 17)
        {
            Prop17(240);
            MoneyView.RPC("Prop17", RpcTarget.Others, 240);
        }
        if(Count == 18)
        {
            Prop18(200);
            MoneyView.RPC("Prop18", RpcTarget.Others, 200);
        }
        if(Count == 19)
        {
            Prop19(260);
            MoneyView.RPC("Prop19", RpcTarget.Others, 260);
        }
        if(Count == 20)
        {
            Prop20(260);
            MoneyView.RPC("Prop20", RpcTarget.Others, 260);
        }
        if(Count == 21)
        {
            FATE1 = Random.Range(1,500);
            Prop21(150);
            MoneyView.RPC("Prop21", RpcTarget.Others, 150);
        }
        if(Count == 22)
        {
            Prop22(280);
            MoneyView.RPC("Prop22", RpcTarget.Others, 280);
        }
        if(Count == 23)
        {
            Prop23(300);
            MoneyView.RPC("Prop23", RpcTarget.Others, 300);
        }
        if(Count == 24)
        {
            Prop24(300);
            MoneyView.RPC("Prop24", RpcTarget.Others, 300);
        }
        if(Count == 25)
        {
            Prop25(320);
            MoneyView.RPC("Prop25", RpcTarget.Others, 320);
        }
        if(Count == 26)
        {
            Prop26(200);
            MoneyView.RPC("Prop26", RpcTarget.Others, 200);
        }
        if(Count == 27)
        {
            Prop27(350);
            MoneyView.RPC("Prop27", RpcTarget.Others, 350);
        }
        if(Count == 28)
        {
            Prop28(400);
            MoneyView.RPC("Prop28", RpcTarget.Others, 400);
        }




        if(Count == 29)
        {
            addMoney2(200);
            MoneyView.RPC("addMoney2", RpcTarget.Others, 200);
        }
        if(Count == 200)
        {
            Tax2(200);
            MoneyView.RPC("Tax2", RpcTarget.Others, 200);
        }
        if(Count == 30)
        {
            P2Prop1(60);
            MoneyView.RPC("P2Prop1", RpcTarget.Others, 60);
        }
        if(Count == 31)
        {
            P2Prop2(60);
            MoneyView.RPC("P2Prop2", RpcTarget.Others, 60);
        }
        if(Count == 32)
        {
            P2Prop3(200);
            MoneyView.RPC("P2Prop3", RpcTarget.Others, 200);
        }
        if(Count == 33)
        {
            P2Prop4(100);
            MoneyView.RPC("P2Prop4", RpcTarget.Others, 100);
        }
        if(Count == 34)
        {
            P2Prop5(100);
            MoneyView.RPC("P2Prop5", RpcTarget.Others, 100);
        }
        if(Count == 35)
        {
            P2Prop6(120);
            MoneyView.RPC("P2Prop6", RpcTarget.Others, 120);
        }
        if(Count == 36)
        {
            P2Prop7(140);
            MoneyView.RPC("P2Prop7", RpcTarget.Others, 140);
        }
        if(Count == 37)
        {
            FATE2 = Random.Range(1,500);
            P2Prop8(150);
            MoneyView.RPC("P2Prop8", RpcTarget.Others, 150);
        }
        if(Count == 38)
        {
            P2Prop9(140);
            MoneyView.RPC("P2Prop9", RpcTarget.Others, 140);
        }
        if(Count == 39)
        {
            P2Prop10(160);
            MoneyView.RPC("P2Prop10", RpcTarget.Others, 160);
        }
        if(Count == 40)
        {
            P2Prop11(200);
            MoneyView.RPC("P2Prop11", RpcTarget.Others, 160);
        }
        if(Count == 41)
        {
            P2Prop12(180);
            MoneyView.RPC("P2Prop12", RpcTarget.Others, 180);
        }
        if(Count == 42)
        {
            P2Prop13(180);
            MoneyView.RPC("P2Prop13", RpcTarget.Others, 180);
        }
        if(Count == 43)
        {
            P2Prop14(200);
            MoneyView.RPC("P2Prop14", RpcTarget.Others, 200);
        }
        if(Count == 44)
        {
            P2Prop15(220);
            MoneyView.RPC("P2Prop15", RpcTarget.Others, 220);
        }
        if(Count == 45)
        {
            P2Prop16(220);
            MoneyView.RPC("P2Prop16", RpcTarget.Others, 220);
        }
        if(Count == 46)
        {
            P2Prop17(240);
            MoneyView.RPC("P2Prop17", RpcTarget.Others, 240);
        }
        if(Count == 47)
        {
            P2Prop18(200);
            MoneyView.RPC("P2Prop18", RpcTarget.Others, 200);
        }
        if(Count == 48)
        {
            P2Prop19(260);
            MoneyView.RPC("P2Prop19", RpcTarget.Others, 260);
        }
        if(Count == 49)
        {
            P2Prop20(260);
            MoneyView.RPC("P2Prop20", RpcTarget.Others, 260);
        }
        if(Count == 50)
        {
            FATE2 = Random.Range(1,500);
            P2Prop21(150);
            MoneyView.RPC("P2Prop21", RpcTarget.Others, 150);
        }
        if(Count == 51)
        {
            P2Prop22(280);
            MoneyView.RPC("P2Prop22", RpcTarget.Others, 280);
        }
        if(Count == 52)
        {
            P2Prop23(300);
            MoneyView.RPC("P2Prop23", RpcTarget.Others, 300);
        }
        if(Count == 53)
        {
            P2Prop24(300);
            MoneyView.RPC("P2Prop24", RpcTarget.Others, 300);
        }
        if(Count == 54)
        {
            P2Prop25(320);
            MoneyView.RPC("P2Prop25", RpcTarget.Others, 320);
        }
        if(Count == 55)
        {
            P2Prop26(200);
            MoneyView.RPC("P2Prop26", RpcTarget.Others, 200);
        }
        if(Count == 56)
        {
            P2Prop27(350);
            MoneyView.RPC("P2Prop27", RpcTarget.Others, 350);
        }
        if(Count == 57)
        {
            P2Prop28(400);
            MoneyView.RPC("P2Prop28", RpcTarget.Others, 400);
        }
    }




    [PunRPC]
    public void addMoney1(int AddMoney1)
    {
        Audio.Play("PassGo");
        moneyPlay1 += AddMoney1;
        InfoMoney.instance.P1Info("P1: " + moneyPlay1);
        Info.instance.ShowMessage("P1 Has passed Go!!!");
    }
    [PunRPC]
       public void addMoney2(int AddMoney2)
    {
        Audio.Play("PassGo");
        moneyPlay2 += AddMoney2;
        InfoMoney.instance.P2Info("P2: " + moneyPlay2);
        Info.instance.ShowMessage("P2 Has passed Go!!!");
    }

    [PunRPC]
    public void Tax1(int TaxMoney1)
    {
        Audio.Play("Loss");
        Audio.Play("Fail");
        moneyPlay1 -= TaxMoney1;
        Info.instance.ShowMessage("Pay tax: 200");
    }

    [PunRPC]
    public void Tax2(int TaxMoney2)
    {
        Audio.Play("Loss");
        Audio.Play("Fail");
        moneyPlay2 -= TaxMoney2;
        Info.instance.ShowMessage("Pay tax: 200");
    }

    [PunRPC]
    public void Prop1(int PropMinus1)
    {
        if(moneyPlay1 - PropMinus1 <= 0) 
        {
            Debug.Log("BANKRUPT!");
            Info.instance.ShowMessage("BANKRUPT!");
        }
        else if(isBrought1 == false )
        {
            Audio.Play("Money");
            moneyPlay1 -= PropMinus1;
            Player1Property1.SetActive(true);
            isBrought1 = true;
            P1IsMine1 = true;
            InfoMoney.instance.P1Info("P1: " + moneyPlay1);
            Info.instance.ShowMessage("P1 has brought Prop1");
        }
        if(isBrought1 == true && P1IsMine1 == true)
        {
            Debug.Log("You own this Property");
            Info.instance.ShowMessage("You Own This Property");
        }
        if(isBrought1 == true && P2IsMine1 == true)
        {
            Audio.Play("Loss");
            Audio.Play("Fail");
            SetsandHousing.instance.P1CheckProperty1();
            moneyPlay1 -= Housing.Build1Money1;
            moneyPlay2 += Housing.Build1Money2;
        }
    }
        [PunRPC]
        public void Prop2(int PropMinus2)
    {
        if(moneyPlay1 - PropMinus2 <= 0) 
        {
            Debug.Log("BANKRUPT!");
            Info.instance.ShowMessage("BANKRUPT!");
        }
        else if(isBrought2 == false )
        {
            Audio.Play("Money");
            moneyPlay1 -= PropMinus2;
            Player1Property2.SetActive(true);
            isBrought2 = true;
            P1IsMine2 = true;
            InfoMoney.instance.P1Info("P1: " + moneyPlay1);
            Info.instance.ShowMessage("P1 has brought Prop2");
        }
        if(isBrought2 == true && P1IsMine2 == true)
        {
            Debug.Log("You own this Property");
            Info.instance.ShowMessage("You Own This Property");
        }
        if(isBrought2 == true && P2IsMine2 == true)
        {
            Audio.Play("Loss");
            Audio.Play("Fail");
            SetsandHousing.instance.P1CheckProperty2();
            moneyPlay1 -= Housing.Build1Money1;
            moneyPlay2 += Housing.Build1Money2;
        }
    }
        [PunRPC]
        public void Prop3(int PropMinus3)
    {
        if(moneyPlay1 - PropMinus3 <= 0) 
        {
            Debug.Log("BANKRUPT!");
            Info.instance.ShowMessage("BANKRUPT!");
        }
        else if(isBrought3 == false )
        {
            Audio.Play("Money");
            moneyPlay1 -= PropMinus3;
            Player1Property3.SetActive(true);
            isBrought3 = true;
            P1IsMine3 = true;
            InfoMoney.instance.P1Info("P1: " + moneyPlay1);
            Info.instance.ShowMessage("P1 has brought Prop3");
            TrainCountP1++;
        }
        if(isBrought3 == true && P1IsMine3 == true)
        {
            Debug.Log("You own this Property");
            Info.instance.ShowMessage("You Own This Property");
        }
        if(isBrought3 == true && P2IsMine3 == true && TrainCountP2 == 1)
        {
            Audio.Play("Loss");
            Audio.Play("Fail");
            Debug.Log("Landed on Train Upgrade 1! Pay: ");
            Info.instance.ShowMessage("Landed on Train Upgrade 1! Pay: 50");
            moneyPlay1 -= 50;
            moneyPlay2 += 50;
        }
        if(isBrought3 == true && P2IsMine3 == true && TrainCountP2 == 2)
        {
            Audio.Play("Loss");
            Audio.Play("Fail");
            Debug.Log("Landed on Train Upgrade 2! Pay: ");
            Info.instance.ShowMessage("Landed on Train Upgrade 2! Pay: 100");
            moneyPlay1 -= 100;
            moneyPlay2 += 100;
        }
        if(isBrought3 == true && P2IsMine3 == true && TrainCountP2 == 3)
        {
            Audio.Play("Loss");
            Audio.Play("Fail");
            Debug.Log("Landed on Train Upgrade 3! Pay: ");
            Info.instance.ShowMessage("Landed on Train Upgrade 3! Pay: 150");
            moneyPlay1 -= 150;
            moneyPlay2 += 150;
        }
        if(isBrought3 == true && P2IsMine3 == true && TrainCountP2 == 4)
        {
            Audio.Play("Loss");
            Audio.Play("Fail");
            Debug.Log("Landed on Train Upgrade 4! Pay: ");
            Info.instance.ShowMessage("Landed on Train Upgrade 4! Pay: 300");
            moneyPlay1 -= 300;
            moneyPlay2 += 300;
        }
    }
        [PunRPC]
        public void Prop4(int PropMinus4)
    {
        if(moneyPlay1 - PropMinus4 <= 0) 
        {
            Debug.Log("BANKRUPT!");
            Info.instance.ShowMessage("BANKRUPT!");
        }
        else if(isBrought4 == false )
        {
            Audio.Play("Money");
            moneyPlay1 -= PropMinus4;
            Player1Property4.SetActive(true);
            isBrought4 = true;
            P1IsMine4 = true;
            InfoMoney.instance.P1Info("P1: " + moneyPlay1);
            Info.instance.ShowMessage("P1 has brought Prop4");
        }
        if(isBrought4 == true && P1IsMine4 == true)
        {
            Debug.Log("You own this Property");
            Info.instance.ShowMessage("You Own This Property");
        }
        if(isBrought4 == true && P2IsMine4 == true)
        {
            Audio.Play("Loss");
            Audio.Play("Fail");
            SetsandHousing.instance.P1CheckProperty3();
            moneyPlay1 -= Housing.Build1Money1;
            moneyPlay2 += Housing.Build1Money2;
        }
    }
        [PunRPC]
        public void Prop5(int PropMinus5)
    {
        if(moneyPlay1 - PropMinus5 <= 0) 
        {
            Debug.Log("BANKRUPT!");
            Info.instance.ShowMessage("BANKRUPT!");
        }
        else if(isBrought5 == false )
        {
            Audio.Play("Money");
            moneyPlay1 -= PropMinus5;
            Player1Property5.SetActive(true);
            isBrought5 = true;
            P1IsMine5 = true;
            InfoMoney.instance.P1Info("P1: " + moneyPlay1);
            Info.instance.ShowMessage("P1 has brought Prop5");
        }
        if(isBrought5 == true && P1IsMine5 == true)
        {
            Debug.Log("You own this Property");
            Info.instance.ShowMessage("You Own This Property");
        }
        if(isBrought5 == true && P2IsMine5 == true)
        {
            Audio.Play("Loss");
            Audio.Play("Fail");
            SetsandHousing.instance.P1CheckProperty4();
            moneyPlay1 -= Housing.Build1Money1;
            moneyPlay2 += Housing.Build1Money2;
        }
    }
        [PunRPC]
        public void Prop6(int PropMinus6)
    {
        if(moneyPlay1 - PropMinus6 <= 0) 
        {
            Debug.Log("BANKRUPT!");
            Info.instance.ShowMessage("BANKRUPT!");
            
        }
        else if(isBrought6 == false )
        {
            Audio.Play("Money");
            moneyPlay1 -= PropMinus6;
            Player1Property6.SetActive(true);
            isBrought6 = true;
            P1IsMine6 = true;
            InfoMoney.instance.P1Info("P1: " + moneyPlay1);
            Info.instance.ShowMessage("P1 has brought Prop6");
        }
        if(isBrought6 == true && P1IsMine6 == true)
        {
            Debug.Log("You own this Property");
            Info.instance.ShowMessage("You Own This Property");
        }
        if(isBrought6 == true && P2IsMine6 == true)
        {
            Audio.Play("Loss");
            Audio.Play("Fail");
            SetsandHousing.instance.P1CheckProperty5();
            moneyPlay1 -= Housing.Build1Money1;
            moneyPlay2 += Housing.Build1Money2;
        }
    }
        [PunRPC]
        public void Prop7(int PropMinus7)
    {
        if(moneyPlay1 - PropMinus7 <= 0) 
        {
            Debug.Log("BANKRUPT!");
            Info.instance.ShowMessage("BANKRUPT!");
        }
        else if(isBrought7 == false )
        {
            Audio.Play("Money");
            moneyPlay1 -= PropMinus7;
            Player1Property7.SetActive(true);
            isBrought7 = true;
            P1IsMine7 = true;
            InfoMoney.instance.P1Info("P1: " + moneyPlay1);
            Info.instance.ShowMessage("P1 has brought Prop7");
        }
        if(isBrought7 == true && P1IsMine7 == true)
        {
            Debug.Log("You own this Property");
            Info.instance.ShowMessage("You Own This Property");
        }
        if(isBrought7 == true && P2IsMine7 == true)
        {
            Audio.Play("Loss");
            Audio.Play("Fail");
            SetsandHousing.instance.P1CheckProperty6();
            moneyPlay1 -= Housing.Build1Money1;
            moneyPlay2 += Housing.Build1Money2;
        }
    }
        [PunRPC]
        public void Prop8(int PropMinus8)
    {
        if(moneyPlay1 - PropMinus8 <= 0) 
        {
            Debug.Log("BANKRUPT!");
            Info.instance.ShowMessage("BANKRUPT!");
        }
        else if(isBrought8 == false )
        {
            Audio.Play("Money");
            moneyPlay1 -= PropMinus8;
            Player1Property8.SetActive(true);
            isBrought8 = true;
            P1IsMine8 = true;
            InfoMoney.instance.P1Info("P1: " + moneyPlay1);
            Info.instance.ShowMessage("P1 has brought Prop8");
        }
        if(isBrought8 == true && P1IsMine8 == true)
        {
            Debug.Log("You own this Property");
            Info.instance.ShowMessage("You Own This Property");
        }
        if(isBrought8 == true && P2IsMine8 == true)
        {
            Audio.Play("Prison");
            moneyPlay1 -= FATE1;
            moneyPlay2 += FATE1;
            Debug.Log("Fate will decide what you pay! : " + FATE1);
            Info.instance.ShowMessage("Fate will decide what you pay! : " + FATE1);
        }
    }
        [PunRPC]
        public void Prop9(int PropMinus9)
    {
        if(moneyPlay1 - PropMinus9 <= 0) 
        {
            Debug.Log("BANKRUPT!");
            Info.instance.ShowMessage("BANKRUPT!");
        }
        else if(isBrought9 == false )
        {
            Audio.Play("Money");
            moneyPlay1 -= PropMinus9;
            Player1Property9.SetActive(true);
            isBrought9 = true;
            P1IsMine9 = true;
            InfoMoney.instance.P1Info("P1: " + moneyPlay1);
            Info.instance.ShowMessage("P1 has brought Prop9");
        }
        if(isBrought9 == true && P1IsMine9 == true)
        {
            Debug.Log("You own this Property");
            Info.instance.ShowMessage("You Own This Property");
        }
        if(isBrought9 == true && P2IsMine9 == true)
        {
            Audio.Play("Loss");
            Audio.Play("Fail");
            SetsandHousing.instance.P1CheckProperty7();
            moneyPlay1 -= Housing.Build1Money1;
            moneyPlay2 += Housing.Build1Money2;
        }
    }
        [PunRPC]
        public void Prop10(int PropMinus10)
    {
        if(moneyPlay1 - PropMinus10 <= 0) 
        {
            Debug.Log("BANKRUPT!");
            Info.instance.ShowMessage("BANKRUPT!");
        }
        else if(isBrought10 == false )
        {
            Audio.Play("Money");
            moneyPlay1 -= PropMinus10;
            Player1Property10.SetActive(true);
            isBrought10 = true;
            P1IsMine10 = true;
            InfoMoney.instance.P1Info("P1: " + moneyPlay1);
            Info.instance.ShowMessage("P1 has brought Prop10");
        }
        if(isBrought10 == true && P1IsMine10 == true)
        {
            Debug.Log("You own this Property");
            Info.instance.ShowMessage("You Own This Property");
        }
        if(isBrought10 == true && P2IsMine10 == true)
        {
            Audio.Play("Loss");
            Audio.Play("Fail");
            SetsandHousing.instance.P1CheckProperty8();
            moneyPlay1 -= Housing.Build1Money1;
            moneyPlay2 += Housing.Build1Money2;
        }
    }
        [PunRPC]
        public void Prop11(int PropMinus11)
    {
        if(moneyPlay1 - PropMinus11 <= 0) 
        {
            Debug.Log("BANKRUPT!");
            Info.instance.ShowMessage("BANKRUPT!");
        }
        else if(isBrought11 == false )
        {
            Audio.Play("Money");
            moneyPlay1 -= PropMinus11;
            Player1Property11.SetActive(true);
            isBrought11 = true;
            P1IsMine11 = true;
            InfoMoney.instance.P1Info("P1: " + moneyPlay1);
            Info.instance.ShowMessage("P1 has brought Prop11");
            TrainCountP1++;
        }
        if(isBrought11 == true && P1IsMine11 == true)
        {
            Debug.Log("You own this Property");
            Info.instance.ShowMessage("You Own This Property");
        }
        if(isBrought11 == true && P2IsMine11 == true && TrainCountP2 == 1)
        {
            Audio.Play("Loss");
            Audio.Play("Fail");
            Debug.Log("Landed on Train Upgrade 1! Pay: ");
            Info.instance.ShowMessage("Landed on Train Upgrade 1! Pay: 50");
            moneyPlay1 -= 50;
            moneyPlay2 += 50;
        }
        if(isBrought11 == true && P2IsMine11 == true && TrainCountP2 == 2)
        {
            Audio.Play("Loss");
            Audio.Play("Fail");
            Debug.Log("Landed on Train Upgrade 2! Pay: ");
            Info.instance.ShowMessage("Landed on Train Upgrade 2! Pay: 100");
            moneyPlay1 -= 100;
            moneyPlay2 += 100;
        }
        if(isBrought11 == true && P2IsMine11 == true && TrainCountP2 == 3)
        {
            Audio.Play("Loss");
            Audio.Play("Fail");
            Debug.Log("Landed on Train Upgrade 3! Pay: ");
            Info.instance.ShowMessage("Landed on Train Upgrade 3! Pay: 150");
            moneyPlay1 -= 150;
            moneyPlay2 += 150;
        }
        if(isBrought11 == true && P2IsMine11 == true && TrainCountP2 == 4)
        {
            Audio.Play("Loss");
            Audio.Play("Fail");
            Debug.Log("Landed on Train Upgrade 4! Pay: ");
            Info.instance.ShowMessage("Landed on Train Upgrade 4! Pay: 300");
            moneyPlay1 -= 300;
            moneyPlay2 += 300;
        }
    }
        [PunRPC]
        public void Prop12(int PropMinus12)
    {
        if(moneyPlay1 - PropMinus12 <= 0) 
        {
            Debug.Log("BANKRUPT!");
            Info.instance.ShowMessage("BANKRUPT!");
        }
        else if(isBrought12 == false )
        {
            Audio.Play("Money");
            moneyPlay1 -= PropMinus12;
            Player1Property12.SetActive(true);
            isBrought12 = true;
            P1IsMine12 = true;
            InfoMoney.instance.P1Info("P1: " + moneyPlay1);
            Info.instance.ShowMessage("P1 has brought Prop12");
        }
        if(isBrought12 == true && P1IsMine12 == true)
        {
            Debug.Log("You own this Property");
            Info.instance.ShowMessage("You Own This Property");
        }
        if(isBrought12 == true && P2IsMine12 == true)
        {
            Audio.Play("Loss");
            Audio.Play("Fail");
            SetsandHousing.instance.P1CheckProperty9();
            moneyPlay1 -= Housing.Build1Money1;
            moneyPlay2 += Housing.Build1Money2;
        }
    }
        [PunRPC]
        public void Prop13(int PropMinus13)
    {
        if(moneyPlay1 - PropMinus13 <= 0) 
        {
            Debug.Log("BANKRUPT!");
            Info.instance.ShowMessage("BANKRUPT!");
        }
        else if(isBrought13 == false )
        {
            Audio.Play("Money");
            moneyPlay1 -= PropMinus13;
            Player1Property13.SetActive(true);
            isBrought13 = true;
            P1IsMine13 = true;
            InfoMoney.instance.P1Info("P1: " + moneyPlay1);
            Info.instance.ShowMessage("P1 has brought Prop13");
        }
        if(isBrought13 == true && P1IsMine13 == true)
        {
            Debug.Log("You own this Property");
            Info.instance.ShowMessage("You Own This Property");
        }
        if(isBrought13 == true && P2IsMine13 == true)
        {
            Audio.Play("Loss");
            Audio.Play("Fail");
            SetsandHousing.instance.P1CheckProperty10();
            moneyPlay1 -= Housing.Build1Money1;
            moneyPlay2 += Housing.Build1Money2;
        }
    }
        [PunRPC]
        public void Prop14(int PropMinus14)
    {
        if(moneyPlay1 - PropMinus14 <= 0) 
        {
            Debug.Log("BANKRUPT!");
            Info.instance.ShowMessage("BANKRUPT!");
        }
        else if(isBrought14 == false )
        {
            Audio.Play("Money");
            moneyPlay1 -= PropMinus14;
            Player1Property14.SetActive(true);
            isBrought14 = true;
            P1IsMine14 = true;
            InfoMoney.instance.P1Info("P1: " + moneyPlay1);
            Info.instance.ShowMessage("P1 has brought Prop14");
        }
        if(isBrought14 == true && P1IsMine14 == true)
        {
            Debug.Log("You own this Property");
            Info.instance.ShowMessage("You Own This Property");
        }
        if(isBrought14 == true && P2IsMine14 == true)
        {
            Audio.Play("Loss");
            Audio.Play("Fail");
            SetsandHousing.instance.P1CheckProperty11();
            moneyPlay1 -= Housing.Build1Money1;
            moneyPlay2 += Housing.Build1Money2;
        }
    }
        [PunRPC]
        public void Prop15(int PropMinus15)
    {
        if(moneyPlay1 - PropMinus15 <= 0) 
        {
            Debug.Log("BANKRUPT!");
            Info.instance.ShowMessage("BANKRUPT!");
        }
        else if(isBrought15 == false )
        {
            Audio.Play("Money");
            moneyPlay1 -= PropMinus15;
            Player1Property15.SetActive(true);
            isBrought15 = true;
            P1IsMine15 = true;
            InfoMoney.instance.P1Info("P1: " + moneyPlay1);
            Info.instance.ShowMessage("P1 has brought Prop15");
        }
        if(isBrought15 == true && P1IsMine15 == true)
        {
            Debug.Log("You own this Property");
            Info.instance.ShowMessage("You Own This Property");
        }
        if(isBrought15 == true && P2IsMine15 == true)
        {
            Audio.Play("Loss");
            Audio.Play("Fail");
            SetsandHousing.instance.P1CheckProperty12();
            moneyPlay1 -= Housing.Build1Money1;
            moneyPlay2 += Housing.Build1Money2;
        }
    }
        [PunRPC]
        public void Prop16(int PropMinus16)
    {
        if(moneyPlay1 - PropMinus16 <= 0) 
        {
            Debug.Log("BANKRUPT!");
            Info.instance.ShowMessage("BANKRUPT!");
        }
        else if(isBrought16 == false )
        {
            Audio.Play("Money");
            moneyPlay1 -= PropMinus16;
            Player1Property16.SetActive(true);
            isBrought16 = true;
            P1IsMine16 = true;
            InfoMoney.instance.P1Info("P1: " + moneyPlay1);
            Info.instance.ShowMessage("P1 has brought Prop16");
        }
        if(isBrought16 == true && P1IsMine16 == true)
        {
            Debug.Log("You own this Property");
            Info.instance.ShowMessage("You Own This Property");
        }
        if(isBrought16 == true && P2IsMine16 == true)
        {
            Audio.Play("Loss");
            Audio.Play("Fail");
            SetsandHousing.instance.P1CheckProperty13();
            moneyPlay1 -= Housing.Build1Money1;
            moneyPlay2 += Housing.Build1Money2;
        }
    }
        [PunRPC]
        public void Prop17(int PropMinus17)
    {
        if(moneyPlay1 - PropMinus17 <= 0) 
        {
            Debug.Log("BANKRUPT!");
            Info.instance.ShowMessage("BANKRUPT!");
        }
        else if(isBrought17 == false )
        {
            Audio.Play("Money");
            moneyPlay1 -= PropMinus17;
            Player1Property17.SetActive(true);
            isBrought17 = true;
            P1IsMine17 = true;
            InfoMoney.instance.P1Info("P1: " + moneyPlay1);
            Info.instance.ShowMessage("P1 has brought Prop17");
        }
        if(isBrought17 == true && P1IsMine17 == true)
        {
            Debug.Log("You own this Property");
            Info.instance.ShowMessage("You Own This Property");
        }
        if(isBrought17 == true && P2IsMine17 == true)
        {
            Audio.Play("Loss");
            Audio.Play("Fail");
            SetsandHousing.instance.P1CheckProperty14();
            moneyPlay1 -= Housing.Build1Money1;
            moneyPlay2 += Housing.Build1Money2;
        }
    }
        [PunRPC]
        public void Prop18(int PropMinus18)
    {
        if(moneyPlay1 - PropMinus18 <= 0) 
        {
            Debug.Log("BANKRUPT!");
            Info.instance.ShowMessage("BANKRUPT!");
        }
        else if(isBrought18 == false )
        {
            Audio.Play("Money");
            moneyPlay1 -= PropMinus18;
            Player1Property18.SetActive(true);
            isBrought18 = true;
            P1IsMine18 = true;
            InfoMoney.instance.P1Info("P1: " + moneyPlay1);
            Info.instance.ShowMessage("P1 has brought Prop18");
            TrainCountP1++;
        }
        if(isBrought18 == true && P1IsMine18 == true)
        {
            Debug.Log("You own this Property");
            Info.instance.ShowMessage("You Own This Property");
        }
        if(isBrought18 == true && P2IsMine18 == true && TrainCountP2 == 1)
        {
            Audio.Play("Loss");
            Audio.Play("Fail");
            Debug.Log("Landed on Train Upgrade 1! Pay: ");
            Info.instance.ShowMessage("Landed on Train Upgrade 1! Pay: 50");
            moneyPlay1 -= 50;
            moneyPlay2 += 50;
        }
        if(isBrought18 == true && P2IsMine18 == true && TrainCountP2 == 2)
        {
            Audio.Play("Loss");
            Audio.Play("Fail");
            Debug.Log("Landed on Train Upgrade 2! Pay: ");
            Info.instance.ShowMessage("Landed on Train Upgrade 2! Pay: 100");
            moneyPlay1 -= 100;
            moneyPlay2 += 100;
        }
        if(isBrought18 == true && P2IsMine18 == true && TrainCountP2 == 3)
        {
            Audio.Play("Loss");
            Audio.Play("Fail");
            Debug.Log("Landed on Train Upgrade 3! Pay: ");
            Info.instance.ShowMessage("Landed on Train Upgrade 3! Pay: 150");
            moneyPlay1 -= 150;
            moneyPlay2 += 150;
        }
        if(isBrought18 == true && P2IsMine18 == true && TrainCountP2 == 4)
        {
            Audio.Play("Loss");
            Audio.Play("Fail");
            Debug.Log("Landed on Train Upgrade 4! Pay: ");
            Info.instance.ShowMessage("Landed on Train Upgrade 4! Pay: 300");
            moneyPlay1 -= 300;
            moneyPlay2 += 300;
        }
    }
        [PunRPC]
        public void Prop19(int PropMinus19)
    {
        if(moneyPlay1 - PropMinus19 <= 0) 
        {
            Debug.Log("BANKRUPT!");
            Info.instance.ShowMessage("BANKRUPT!");
        }
        else if(isBrought19 == false )
        {
            Audio.Play("Money");
            moneyPlay1 -= PropMinus19;
            Player1Property19.SetActive(true);
            isBrought19 = true;
            P1IsMine19 = true;
            InfoMoney.instance.P1Info("P1: " + moneyPlay1);
            Info.instance.ShowMessage("P1 has brought Prop19");
        }
        if(isBrought19 == true && P1IsMine19 == true)
        {
            Debug.Log("You own this Property");
            Info.instance.ShowMessage("You Own This Property");
        }
        if(isBrought19 == true && P2IsMine19 == true)
        {
            Audio.Play("Loss");
            Audio.Play("Fail");
            SetsandHousing.instance.P1CheckProperty15();
            moneyPlay1 -= Housing.Build1Money1;
            moneyPlay2 += Housing.Build1Money2;
        }
    }
        [PunRPC]
        public void Prop20(int PropMinus20)
    {
        if(moneyPlay1 - PropMinus20 <= 0) 
        {
            Debug.Log("BANKRUPT!");
            Info.instance.ShowMessage("BANKRUPT!");
        }
        else if(isBrought20 == false )
        {
            Audio.Play("Money");
            moneyPlay1 -= PropMinus20;
            Player1Property20.SetActive(true);
            isBrought20 = true;
            P1IsMine20 = true;
            InfoMoney.instance.P1Info("P1: " + moneyPlay1);
            Info.instance.ShowMessage("P1 has brought Prop20");
        }
        if(isBrought20 == true && P1IsMine20 == true)
        {
            Debug.Log("You own this Property");
            Info.instance.ShowMessage("You Own This Property");
        }
        if(isBrought20 == true && P2IsMine20 == true)
        {
            Audio.Play("Loss");
            Audio.Play("Fail");
            SetsandHousing.instance.P1CheckProperty16();
            moneyPlay1 -= Housing.Build1Money1;
            moneyPlay2 += Housing.Build1Money2;
        }
    }
        [PunRPC]
        public void Prop21(int PropMinus21)
    {
        if(moneyPlay1 - PropMinus21 <= 0) 
        {
            Debug.Log("BANKRUPT!");
            Info.instance.ShowMessage("BANKRUPT!");
        }
        else if(isBrought21 == false )
        {
            Audio.Play("Money");
            moneyPlay1 -= PropMinus21;
            Player1Property21.SetActive(true);
            isBrought21 = true;
            P1IsMine21 = true;
            InfoMoney.instance.P1Info("P1: " + moneyPlay1);
            Info.instance.ShowMessage("P1 has brought Prop21");
        }
        if(isBrought21 == true && P1IsMine21 == true)
        {
            Debug.Log("You own this Property");
            Info.instance.ShowMessage("You Own This Property");
        }
        if(isBrought21 == true && P2IsMine21 == true)
        {
            Audio.Play("Prison");
            moneyPlay1 -= FATE1;
            moneyPlay2 += FATE1;
            Debug.Log("Fate will decide what you pay! : " + FATE1);
            Info.instance.ShowMessage("Fate will decide what you pay! : " + FATE1);
        }
    }
        [PunRPC]
         public void Prop22(int PropMinus22)
    {
        if(moneyPlay1 - PropMinus22 <= 0) 
        {
            Debug.Log("BANKRUPT!");
            Info.instance.ShowMessage("BANKRUPT!");
        }
        else if(isBrought22 == false )
        {
            Audio.Play("Money");
            moneyPlay1 -= PropMinus22;
            Player1Property22.SetActive(true);
            isBrought22 = true;
            P1IsMine22 = true;
            InfoMoney.instance.P1Info("P1: " + moneyPlay1);
            Info.instance.ShowMessage("P1 has brought Prop22");
        }
        if(isBrought22 == true && P1IsMine22 == true)
        {
            Debug.Log("You own this Property");
            Info.instance.ShowMessage("You Own This Property");
        }
        if(isBrought22 == true && P2IsMine22 == true)
        {
            Audio.Play("Loss");
            Audio.Play("Fail");
            SetsandHousing.instance.P1CheckProperty17();
            moneyPlay1 -= Housing.Build1Money1;
            moneyPlay2 += Housing.Build1Money2;
        }
    }
        [PunRPC]
        public void Prop23(int PropMinus23)
    {
        if(moneyPlay1 - PropMinus23 <= 0) 
        {
            Debug.Log("BANKRUPT!");
            Info.instance.ShowMessage("BANKRUPT!");
        }
        else if(isBrought23 == false )
        {
            Audio.Play("Money");
            moneyPlay1 -= PropMinus23;
            Player1Property23.SetActive(true);
            isBrought23 = true;
            P1IsMine23 = true;
            InfoMoney.instance.P1Info("P1: " + moneyPlay1);
            Info.instance.ShowMessage("P1 has brought Prop23");
        }
        if(isBrought23 == true && P1IsMine23 == true)
        {
            Debug.Log("You own this Property");
            Info.instance.ShowMessage("You Own This Property");
        }
        if(isBrought23 == true && P2IsMine23 == true)
        {
            Audio.Play("Loss");
            Audio.Play("Fail");
            SetsandHousing.instance.P1CheckProperty18();
            moneyPlay1 -= Housing.Build1Money1;
            moneyPlay2 += Housing.Build1Money2;
        }
    }
        [PunRPC]
        public void Prop24(int PropMinus24)
    {
        if(moneyPlay1 - PropMinus24 <= 0) 
        {
            Debug.Log("BANKRUPT!");
            Info.instance.ShowMessage("BANKRUPT!");
        }
        else if(isBrought24 == false )
        {
            Audio.Play("Money");
            moneyPlay1 -= PropMinus24;
            Player1Property24.SetActive(true);
            isBrought24 = true;
            P1IsMine24 = true;
            InfoMoney.instance.P1Info("P1: " + moneyPlay1);
            Info.instance.ShowMessage("P1 has brought Prop24");
        }
        if(isBrought24 == true && P1IsMine24 == true)
        {
            Debug.Log("You own this Property");
            Info.instance.ShowMessage("You Own This Property");
        }
        if(isBrought24 == true && P2IsMine24 == true)
        {
            Audio.Play("Loss");
            Audio.Play("Fail");
            SetsandHousing.instance.P1CheckProperty19();
            moneyPlay1 -= Housing.Build1Money1;
            moneyPlay2 += Housing.Build1Money2;
        }
    }
        [PunRPC]
             public void Prop25(int PropMinus25)
    {
        if(moneyPlay1 - PropMinus25 <= 0) 
        {
            Debug.Log("BANKRUPT!");
            Info.instance.ShowMessage("BANKRUPT!");
        }
        else if(isBrought25 == false )
        {
            Audio.Play("Money");
            moneyPlay1 -= PropMinus25;
            Player1Property25.SetActive(true);
            isBrought25 = true;
            P1IsMine25 = true;
            InfoMoney.instance.P1Info("P1: " + moneyPlay1);
            Info.instance.ShowMessage("P1 has brought Prop25");
        }
        if(isBrought25 == true && P1IsMine25 == true)
        {
            Debug.Log("You own this Property");
            Info.instance.ShowMessage("You Own This Property");
        }
        if(isBrought25 == true && P2IsMine25 == true)
        {
            Audio.Play("Loss");
            Audio.Play("Fail");
            SetsandHousing.instance.P1CheckProperty20();
            moneyPlay1 -= Housing.Build1Money1;
            moneyPlay2 += Housing.Build1Money2;
        }
    }
        [PunRPC]
             public void Prop26(int PropMinus26)
    {
        if(moneyPlay1 - PropMinus26 <= 0) 
        {
            Debug.Log("BANKRUPT!");
            Info.instance.ShowMessage("BANKRUPT!");
        }
        else if(isBrought26 == false )
        {
            Audio.Play("Money");
            moneyPlay1 -= PropMinus26;
            Player1Property26.SetActive(true);
            isBrought26 = true;
            P1IsMine26 = true;
            InfoMoney.instance.P1Info("P1: " + moneyPlay1);
            Info.instance.ShowMessage("P1 has brought Prop26");
            TrainCountP1++;
        }
        if(isBrought26 == true && P1IsMine26 == true)
        {
            Debug.Log("You own this Property");
            Info.instance.ShowMessage("You Own This Property");
        }
        if(isBrought26 == true && P2IsMine26 == true && TrainCountP2 == 1)
        {
            Audio.Play("Loss");
            Audio.Play("Fail");
            Debug.Log("Landed on Train Upgrade 1! Pay: ");
            Info.instance.ShowMessage("Landed on Train Upgrade 1! Pay: 50");
            moneyPlay1 -= 50;
            moneyPlay2 += 50;
        }
        if(isBrought26 == true && P2IsMine26 == true && TrainCountP2 == 2)
        {
            Audio.Play("Loss");
            Audio.Play("Fail");
            Debug.Log("Landed on Train Upgrade 2! Pay: ");
            Info.instance.ShowMessage("Landed on Train Upgrade 2! Pay: 100");
            moneyPlay1 -= 100;
            moneyPlay2 += 100;
        }
        if(isBrought26 == true && P2IsMine26 == true && TrainCountP2 == 3)
        {
            Audio.Play("Loss");
            Audio.Play("Fail");
            Debug.Log("Landed on Train Upgrade 3! Pay: ");
            Info.instance.ShowMessage("Landed on Train Upgrade 3! Pay: 150");
            moneyPlay1 -= 150;
            moneyPlay2 += 150;
        }
        if(isBrought26 == true && P2IsMine26 == true && TrainCountP2 == 4)
        {
            Audio.Play("Loss");
            Audio.Play("Fail");
            Debug.Log("Landed on Train Upgrade 4! Pay: ");
            Info.instance.ShowMessage("Landed on Train Upgrade 4! Pay: 300");
            moneyPlay1 -= 300;
            moneyPlay2 += 300;
        }
    }
        [PunRPC]
             public void Prop27(int PropMinus27)
    {
        if(moneyPlay1 - PropMinus27 <= 0) 
        {
            Debug.Log("BANKRUPT!");
            Info.instance.ShowMessage("BANKRUPT!");
        }
        else if(isBrought27 == false )
        {
            Audio.Play("Money");
            moneyPlay1 -= PropMinus27;
            Player1Property27.SetActive(true);
            isBrought27 = true;
            P1IsMine27 = true;
            InfoMoney.instance.P1Info("P1: " + moneyPlay1);
            Info.instance.ShowMessage("P1 has brought Prop27");
        }
        if(isBrought27 == true && P1IsMine27 == true)
        {
            Debug.Log("You own this Property");
            Info.instance.ShowMessage("You Own This Property");
        }
        if(isBrought27 == true && P2IsMine27 == true)
        {
            Audio.Play("Loss");
            Audio.Play("Fail");
            SetsandHousing.instance.P1CheckProperty21();
            moneyPlay1 -= Housing.Build1Money1;
            moneyPlay2 += Housing.Build1Money2;
        }
    }
        [PunRPC]
             public void Prop28(int PropMinus28)
    {
        if(moneyPlay1 - PropMinus28 <= 0) 
        {
            Debug.Log("BANKRUPT!");
            Info.instance.ShowMessage("BANKRUPT!");
        }
        else if(isBrought28 == false )
        {
            Audio.Play("Money");
            moneyPlay1 -= PropMinus28;
            Player1Property28.SetActive(true);
            isBrought28 = true;
            P1IsMine28 = true;
            InfoMoney.instance.P1Info("P1: " + moneyPlay1);
            Info.instance.ShowMessage("P1 has brought Prop28");
        }
        if(isBrought28 == true && P1IsMine28 == true)
        {
            Debug.Log("You own this Property");
            Info.instance.ShowMessage("You Own This Property");
        }
        if(isBrought28 == true && P2IsMine28 == true)
        {
            Audio.Play("Loss");
            Audio.Play("Fail");
            SetsandHousing.instance.P1CheckProperty22();
            moneyPlay1 -= Housing.Build1Money1;
            moneyPlay2 += Housing.Build1Money2;
        }
    }
















//----------------------------------------Player2-----------------------------//
















    [PunRPC]
    public void P2Prop1(int P2PropMinus1)
    {
        if(moneyPlay2 - P2PropMinus1 <= 0) 
        {
            Debug.Log("BANKRUPT!");
            Info.instance.ShowMessage("BANKRUPT!");
        }
        else if(isBrought1 == false )
        {
            Audio.Play("Money");
            moneyPlay2 -= P2PropMinus1;
            Player2Property1.SetActive(true);
            isBrought1 = true;
            P2IsMine1 = true;
            InfoMoney.instance.P2Info("P2: " + moneyPlay2);
            Info.instance.ShowMessage("P2 has brought Prop1");
        }
        if(isBrought1 == true && P1IsMine1 == true)
        {
            Audio.Play("Loss");
            Audio.Play("Fail");
            SetsandHousing.instance.P2CheckProperty1();
            moneyPlay1 += Housing.Build1Money1;
            moneyPlay2 -= Housing.Build1Money2;
        }
        if(isBrought1 == true && P2IsMine1 == true)
        {
            Debug.Log("You Own this property");
            Info.instance.ShowMessage("You Own This Property");
        }
    }
        [PunRPC]
        public void P2Prop2(int P2PropMinus2)
    {
        if(moneyPlay2 - P2PropMinus2 <= 0) 
        {
            Debug.Log("BANKRUPT!");
        }
        else if(isBrought2 == false )
        {
            Audio.Play("Money");
            moneyPlay2 -= P2PropMinus2;
            Player2Property2.SetActive(true);
            isBrought2 = true;
            P2IsMine2 = true;
            InfoMoney.instance.P2Info("P2: " + moneyPlay2);
            Info.instance.ShowMessage("P2 has brought Prop2");
        }
        if(isBrought2 == true && P1IsMine2 == true)
        {
            Audio.Play("Loss");
            Audio.Play("Fail");
            SetsandHousing.instance.P2CheckProperty2();
            moneyPlay1 += Housing.Build1Money1;
            moneyPlay2 -= Housing.Build1Money2;
        }
        if(isBrought2 == true && P2IsMine2 == true)
        {
            Debug.Log("You Own this property");
            Info.instance.ShowMessage("You Own This Property");
        }
    }
        [PunRPC]
        public void P2Prop3(int P2PropMinus3)
    {
        if(moneyPlay2 - P2PropMinus3 <= 0) 
        {
            Debug.Log("BANKRUPT!");
            Info.instance.ShowMessage("BANKRUPT!");
        }
        else if(isBrought3 == false )
        {
            Audio.Play("Money");
            moneyPlay2 -= P2PropMinus3;
            Player2Property3.SetActive(true);
            isBrought3 = true;
            P2IsMine3 = true;
            InfoMoney.instance.P2Info("P2: " + moneyPlay2);
            Info.instance.ShowMessage("P2 has brought Prop3");
            TrainCountP2++;
        }
        if(isBrought3 == true && P2IsMine3 == true)
        {
            Debug.Log("You Own this Property");
            Info.instance.ShowMessage("You Own this Property!!");
        }
        if(isBrought3 == true && P1IsMine3 == true && TrainCountP1 == 1)
        {
            Audio.Play("Loss");
            Audio.Play("Fail");
            Debug.Log("Landed on Train Upgrade 1! Pay: ");
            Info.instance.ShowMessage("Landed on Train Upgrade 1! Pay: 50");
            moneyPlay1 += 50;
            moneyPlay2 -= 50;
        }
        if(isBrought3 == true && P1IsMine3 == true && TrainCountP1 == 2)
        {
            Audio.Play("Loss");
            Audio.Play("Fail");
            Debug.Log("Landed on Train Upgrade 2! Pay: ");
            Info.instance.ShowMessage("Landed on Train Upgrade 2! Pay: 100");
            moneyPlay1 += 100;
            moneyPlay2 -= 100;
        }
        if(isBrought3 == true && P1IsMine3 == true && TrainCountP1 == 3)
        {
            Audio.Play("Loss");
            Audio.Play("Fail");
            Debug.Log("Landed on Train Upgrade 3! Pay: ");
            Info.instance.ShowMessage("Landed on Train Upgrade 3! Pay: 150");
            moneyPlay1 += 150;
            moneyPlay2 -= 150;
        }
        if(isBrought3 == true && P1IsMine3 == true && TrainCountP1 == 4)
        {
            Audio.Play("Loss");
            Audio.Play("Fail");
            Debug.Log("Landed on Train Upgrade 4! Pay: ");
            Info.instance.ShowMessage("Landed on Train Upgrade 4! Pay: 300");
            moneyPlay1 += 300;
            moneyPlay2 -= 300;
        }
    }
        [PunRPC]
        public void P2Prop4(int P2PropMinus4)
    {
        if(moneyPlay2 - P2PropMinus4 <= 0) 
        {
            Debug.Log("BANKRUPT!");
            Info.instance.ShowMessage("BANKRUPT!");
        }
        else if(isBrought4 == false )
        {
            Audio.Play("Money");
            moneyPlay2 -= P2PropMinus4;
            Player2Property4.SetActive(true);
            isBrought4 = true;
            P2IsMine4 = true;
            InfoMoney.instance.P2Info("P2: " + moneyPlay2);
            Info.instance.ShowMessage("P2 has brought Prop4");
        }
        if(isBrought4 == true && P1IsMine4 == true)
        {
            Audio.Play("Loss");
            Audio.Play("Fail");
            SetsandHousing.instance.P2CheckProperty3();
            moneyPlay1 += Housing.Build1Money1;
            moneyPlay2 -= Housing.Build1Money2;
        }
        if(isBrought4 == true && P2IsMine4 == true)
        {
            Debug.Log("You Own this property");
            Info.instance.ShowMessage("You Own This Property");
        }
    }
        [PunRPC]
        public void P2Prop5(int P2PropMinus5)
    {
        if(moneyPlay2 - P2PropMinus5 <= 0) 
        {
            Debug.Log("BANKRUPT!");
            Info.instance.ShowMessage("BANKRUPT!");
        }
        else if(isBrought5 == false )
        {
            Audio.Play("Money");
            moneyPlay2 -= P2PropMinus5;
            Player2Property5.SetActive(true);
            isBrought5 = true;
            P2IsMine5 = true;
            InfoMoney.instance.P2Info("P2: " + moneyPlay2);
            Info.instance.ShowMessage("P2 has brought Prop5");
        }
        if(isBrought5 == true && P1IsMine5 == true)
        {
            Audio.Play("Loss");
            Audio.Play("Fail");
            SetsandHousing.instance.P2CheckProperty4();
            moneyPlay1 += Housing.Build1Money1;
            moneyPlay2 -= Housing.Build1Money2;
        }
        if(isBrought5 == true && P2IsMine5 == true)
        {
            Debug.Log("You Own this property");
            Info.instance.ShowMessage("You Own This Property");
        }
    }
        [PunRPC]
        public void P2Prop6(int P2PropMinus6)
    {
        if(moneyPlay2 - P2PropMinus6 <= 0) 
        {
            Debug.Log("BANKRUPT!");
            Info.instance.ShowMessage("BANKRUPT!");
        }
        else if(isBrought6 == false )
        {
            Audio.Play("Money");
            moneyPlay2 -= P2PropMinus6;
            Player2Property6.SetActive(true);
            isBrought6 = true;
            P2IsMine6 = true;
            InfoMoney.instance.P2Info("P2: " + moneyPlay2);
            Info.instance.ShowMessage("P2 has brought Prop6");
        }
        if(isBrought6 == true && P1IsMine6 == true)
        {
            Audio.Play("Loss");
            Audio.Play("Fail");
            SetsandHousing.instance.P2CheckProperty5();
            moneyPlay1 += Housing.Build1Money1;
            moneyPlay2 -= Housing.Build1Money2;
        }
        if(isBrought6 == true && P2IsMine6 == true)
        {
            Debug.Log("You Own this property");
            Info.instance.ShowMessage("You Own This Property");
        }
    }
        [PunRPC]
        public void P2Prop7(int P2PropMinus7)
    {
        if(moneyPlay2 - P2PropMinus7 <= 0) 
        {
            Debug.Log("BANKRUPT!");
            Info.instance.ShowMessage("BANKRUPT!");
        }
        else if(isBrought7 == false )
        {
            Audio.Play("Money");
            moneyPlay2 -= P2PropMinus7;
            Player2Property7.SetActive(true);
            isBrought7 = true;
            P2IsMine7 = true;
            InfoMoney.instance.P2Info("P2: " + moneyPlay2);
            Info.instance.ShowMessage("P2 has brought Prop7");
        }
        if(isBrought7 == true && P1IsMine7 == true)
        {
            Audio.Play("Loss");
            Audio.Play("Fail");
            SetsandHousing.instance.P2CheckProperty6();
            moneyPlay1 += Housing.Build1Money1;
            moneyPlay2 -= Housing.Build1Money2;
        }
        if(isBrought7 == true && P2IsMine7 == true)
        {
            Debug.Log("You Own this property");
            Info.instance.ShowMessage("You Own This Property");
        }
    }
        [PunRPC]
        public void P2Prop8(int P2PropMinus8)
    {
        if(moneyPlay2 - P2PropMinus8 <= 0) 
        {
            Debug.Log("BANKRUPT!");
            Info.instance.ShowMessage("BANKRUPT!");
        }
        else if(isBrought8 == false )
        {
            Audio.Play("Money");
            moneyPlay2 -= P2PropMinus8;
            Player2Property8.SetActive(true);
            isBrought8 = true;
            P2IsMine8 = true;
            InfoMoney.instance.P2Info("P2: " + moneyPlay2);
            Info.instance.ShowMessage("P2 has brought Prop8");
        }
        if(isBrought8 == true && P1IsMine8 == true)
        {
            Audio.Play("Prison");
            moneyPlay1 += FATE2;
            moneyPlay2 -= FATE2;
            Debug.Log("Fate will decide what you pay! : " + FATE2);
            Info.instance.ShowMessage("Fate will decide what you pay! : " + FATE2);
        }
        if(isBrought8 == true && P2IsMine8 == true)
        {
            Debug.Log("You Own this property");
            Info.instance.ShowMessage("You Own This Property");
        }
    }
        [PunRPC]
        public void P2Prop9(int P2PropMinus9)
    {
        if(moneyPlay2 - P2PropMinus9 <= 0) 
        {
            Debug.Log("BANKRUPT!");
            Info.instance.ShowMessage("BANKRUPT!");
        }
        else if(isBrought9 == false )
        {
            Audio.Play("Money");
            moneyPlay2 -= P2PropMinus9;
            Player2Property9.SetActive(true);
            isBrought9 = true;
            P2IsMine9 = true;
            InfoMoney.instance.P2Info("P2: " + moneyPlay2);
            Info.instance.ShowMessage("P2 has brought Prop9");
        }
        if(isBrought9 == true && P1IsMine9 == true)
        {
            Audio.Play("Loss");
            Audio.Play("Fail");
            SetsandHousing.instance.P2CheckProperty7();
            moneyPlay1 += Housing.Build1Money1;
            moneyPlay2 -= Housing.Build1Money2;
        }
        if(isBrought9 == true && P2IsMine9 == true)
        {
            Debug.Log("You Own this property");
            Info.instance.ShowMessage("You Own This Property");
        }
    }
        [PunRPC]
        public void P2Prop10(int P2PropMinus10)
    {
        if(moneyPlay2 - P2PropMinus10 <= 0) 
        {
            Debug.Log("BANKRUPT!");
            Info.instance.ShowMessage("BANKRUPT!");
        }
        else if(isBrought10 == false )
        {
            Audio.Play("Money");
            moneyPlay2 -= P2PropMinus10;
            Player2Property10.SetActive(true);
            isBrought10 = true;
            P2IsMine10 = true;
            InfoMoney.instance.P2Info("P2: " + moneyPlay2);
            Info.instance.ShowMessage("P2 has brought Prop10");
        }
        if(isBrought10 == true && P1IsMine10 == true)
        {
            Audio.Play("Loss");
            Audio.Play("Fail");
            SetsandHousing.instance.P2CheckProperty8();
            moneyPlay1 += Housing.Build1Money1;
            moneyPlay2 -= Housing.Build1Money2;
        }
        if(isBrought10 == true && P2IsMine10 == true)
        {
            Debug.Log("You Own this property");
            Info.instance.ShowMessage("You Own This Property");
        }
    }
        [PunRPC]
        public void P2Prop11(int P2PropMinus11)
    {
        if(moneyPlay2 - P2PropMinus11 <= 0) 
        {
            Debug.Log("BANKRUPT!");
            Info.instance.ShowMessage("BANKRUPT!");
        }
        else if(isBrought11 == false )
        {
            Audio.Play("Money");
            moneyPlay2 -= P2PropMinus11;
            Player2Property11.SetActive(true);
            isBrought11 = true;
            P2IsMine11 = true;
            InfoMoney.instance.P2Info("P2: " + moneyPlay2);
            Info.instance.ShowMessage("P2 has brought Prop11");
            TrainCountP2++;
        }
        if(isBrought11 == true && P2IsMine11 == true)
        {
            Debug.Log("You Own this Property");
            Info.instance.ShowMessage("You Own this Property");
        }
        if(isBrought11 == true && P1IsMine11 == true && TrainCountP1 == 1)
        {
            Audio.Play("Loss");
            Audio.Play("Fail");
            Debug.Log("Landed on Train Upgrade 1! Pay: ");
            Info.instance.ShowMessage("Landed on Train Upgrade 1! Pay: 50");
            moneyPlay1 += 50;
            moneyPlay2 -= 50;
        }
        if(isBrought11 == true && P1IsMine11 == true && TrainCountP1 == 2)
        {
            Audio.Play("Loss");
            Audio.Play("Fail");
            Debug.Log("Landed on Train Upgrade 2! Pay: ");
            Info.instance.ShowMessage("Landed on Train Upgrade 2! Pay: 100");
            moneyPlay1 += 100;
            moneyPlay2 -= 100;
        }
        if(isBrought11 == true && P1IsMine11 == true && TrainCountP1 == 3)
        {
            Audio.Play("Loss");
            Audio.Play("Fail");
            Debug.Log("Landed on Train Upgrade 3! Pay: ");
            Info.instance.ShowMessage("Landed on Train Upgrade 3! Pay: 150");
            moneyPlay1 += 150;
            moneyPlay2 -= 150;
        }
        if(isBrought11 == true && P1IsMine11 == true && TrainCountP1 == 4)
        {
            Audio.Play("Loss");
            Audio.Play("Fail");
            Debug.Log("Landed on Train Upgrade 4! Pay: ");
            Info.instance.ShowMessage("Landed on Train Upgrade 4! Pay: 300");
            moneyPlay1 += 300;
            moneyPlay2 -= 300;
        }
    }
        [PunRPC]
        public void P2Prop12(int P2PropMinus12)
    {
        if(moneyPlay2 - P2PropMinus12 <= 0) 
        {
            Debug.Log("BANKRUPT!");
            Info.instance.ShowMessage("BANKRUPT!");
        }
        else if(isBrought12 == false )
        {
            Audio.Play("Money");
            moneyPlay2 -= P2PropMinus12;
            Player2Property12.SetActive(true);
            isBrought12 = true;
            P2IsMine12 = true;
            InfoMoney.instance.P2Info("P2: " + moneyPlay2);
            Info.instance.ShowMessage("P2 has brought Prop12");
        }
        if(isBrought12 == true && P1IsMine12 == true)
        {
            Audio.Play("Loss");
            Audio.Play("Fail");
            SetsandHousing.instance.P2CheckProperty9();
            moneyPlay1 += Housing.Build1Money1;
            moneyPlay2 -= Housing.Build1Money2;
        }
        if(isBrought12 == true && P2IsMine12 == true)
        {
            Debug.Log("You Own this property");
            Info.instance.ShowMessage("You Own This Property");
        }
    }
        [PunRPC]
        public void P2Prop13(int P2PropMinus13)
    {
        if(moneyPlay2 - P2PropMinus13 <= 0) 
        {
            Debug.Log("BANKRUPT!");
            Info.instance.ShowMessage("BANKRUPT!");
        }
        else if(isBrought13 == false )
        {
            Audio.Play("Money");
            moneyPlay2 -= P2PropMinus13;
            Player2Property13.SetActive(true);
            isBrought13 = true;
            P2IsMine13 = true;
            InfoMoney.instance.P2Info("P2: " + moneyPlay2);
            Info.instance.ShowMessage("P2 has brought Prop13");
        }
        if(isBrought13 == true && P1IsMine13 == true)
        {
            Audio.Play("Loss");
            Audio.Play("Fail");
            SetsandHousing.instance.P2CheckProperty10();
            moneyPlay1 += Housing.Build1Money1;
            moneyPlay2 -= Housing.Build1Money2;
        }
        if(isBrought13 == true && P2IsMine13 == true)
        {
            Debug.Log("You Own this property");
            Info.instance.ShowMessage("You Own This Property");
        }
    }
        [PunRPC]
        public void P2Prop14(int P2PropMinus14)
    {
        if(moneyPlay2 - P2PropMinus14 <= 0) 
        {
            Debug.Log("BANKRUPT!");
            Info.instance.ShowMessage("BANKRUPT!");
        }
        else if(isBrought14 == false )
        {
            Audio.Play("Money");
            moneyPlay2 -= P2PropMinus14;
            Player2Property14.SetActive(true);
            isBrought14 = true;
            P2IsMine14 = true;
            InfoMoney.instance.P2Info("P2: " + moneyPlay2);
            Info.instance.ShowMessage("P2 has brought Prop14");
        }
        if(isBrought14 == true && P1IsMine14 == true)
        {
            Audio.Play("Loss");
            Audio.Play("Fail");
            SetsandHousing.instance.P2CheckProperty11();
            moneyPlay1 += Housing.Build1Money1;
            moneyPlay2 -= Housing.Build1Money2;
        }
        if(isBrought14 == true && P2IsMine14 == true)
        {
            Debug.Log("You Own this property");
            Info.instance.ShowMessage("You Own This Property");
        }
    }
        [PunRPC]
        public void P2Prop15(int P2PropMinus15)
    {
        if(moneyPlay2 - P2PropMinus15 <= 0) 
        {
            Debug.Log("BANKRUPT!");
            Info.instance.ShowMessage("BANKRUPT!");
        }
        else if(isBrought15 == false )
        {
            Audio.Play("Money");
            moneyPlay2 -= P2PropMinus15;
            Player2Property15.SetActive(true);
            isBrought15 = true;
            P2IsMine15 = true;
            InfoMoney.instance.P2Info("P2: " + moneyPlay2);
            Info.instance.ShowMessage("P2 has brought Prop15");
        }
        if(isBrought15 == true && P1IsMine15 == true)
        {
            Audio.Play("Loss");
            Audio.Play("Fail");
            SetsandHousing.instance.P2CheckProperty12();
            moneyPlay1 += Housing.Build1Money1;
            moneyPlay2 -= Housing.Build1Money2;
        }
        if(isBrought15 == true && P2IsMine15 == true)
        {
            Debug.Log("You Own this property");
            Info.instance.ShowMessage("You Own This Property");
        }
    }
        [PunRPC]
        public void P2Prop16(int P2PropMinus16)
    {
        if(moneyPlay2 - P2PropMinus16 <= 0) 
        {
            Debug.Log("BANKRUPT!");
            Info.instance.ShowMessage("BANKRUPT!");
        }
        else if(isBrought16 == false )
        {
            Audio.Play("Money");
            moneyPlay2 -= P2PropMinus16;
            Player2Property16.SetActive(true);
            isBrought16 = true;
            P2IsMine16 = true;
            InfoMoney.instance.P2Info("P2: " + moneyPlay2);
            Info.instance.ShowMessage("P2 has brought Prop16");
        }
        if(isBrought16 == true && P1IsMine16 == true)
        {
            Audio.Play("Loss");
            Audio.Play("Fail");
            SetsandHousing.instance.P2CheckProperty13();
            moneyPlay1 += Housing.Build1Money1;
            moneyPlay2 -= Housing.Build1Money2;
        }
        if(isBrought16 == true && P2IsMine16 == true)
        {
            Debug.Log("You Own this property");
            Info.instance.ShowMessage("You Own This Property");
        }
    }
        [PunRPC]
        public void P2Prop17(int P2PropMinus17)
    {
        if(moneyPlay2 - P2PropMinus17 <= 0) 
        {
            Debug.Log("BANKRUPT!");
            Info.instance.ShowMessage("BANKRUPT!");
        }
        else if(isBrought17 == false )
        {
            Audio.Play("Money");
            moneyPlay2 -= P2PropMinus17;
            Player2Property17.SetActive(true);
            isBrought17 = true;
            P2IsMine17 = true;
            InfoMoney.instance.P2Info("P2: " + moneyPlay2);
            Info.instance.ShowMessage("P2 has brought Prop17");
        }
        if(isBrought17 == true && P1IsMine17 == true)
        {
            Audio.Play("Loss");
            Audio.Play("Fail");
            SetsandHousing.instance.P2CheckProperty14();
            moneyPlay1 += Housing.Build1Money1;
            moneyPlay2 -= Housing.Build1Money2;
        }
        if(isBrought17 == true && P2IsMine17 == true)
        {
            Debug.Log("You Own this property");
            Info.instance.ShowMessage("You Own This Property");
        }
    }
        [PunRPC]
        public void P2Prop18(int P2PropMinus18)
    {
        if(moneyPlay2 - P2PropMinus18 <= 0) 
        {
            Debug.Log("BANKRUPT!");
            Info.instance.ShowMessage("BANKRUPT!");
        }
        else if(isBrought18 == false )
        {
            Audio.Play("Money");
            moneyPlay2 -= P2PropMinus18;
            Player2Property18.SetActive(true);
            isBrought18 = true;
            P2IsMine18 = true;
            InfoMoney.instance.P2Info("P2: " + moneyPlay2);
            Info.instance.ShowMessage("P2 has brought Prop18");
            TrainCountP2++;
        }
        if(isBrought18 == true && P2IsMine18 == true)
        {
            Debug.Log("You Own this Property");
            Info.instance.ShowMessage("You Own this Property");
        }
        if(isBrought18 == true && P1IsMine18 == true && TrainCountP1 == 1)
        {
            Audio.Play("Loss");
            Audio.Play("Fail");
            Debug.Log("Landed on Train Upgrade 1! Pay: ");
            Info.instance.ShowMessage("Landed on Train Upgrade 1! Pay: 50");
            moneyPlay1 += 50;
            moneyPlay2 -= 50;
        }
        if(isBrought18 == true && P1IsMine18 == true && TrainCountP1 == 2)
        {
            Audio.Play("Loss");
            Audio.Play("Fail");
            Debug.Log("Landed on Train Upgrade 2! Pay: ");
            Info.instance.ShowMessage("Landed on Train Upgrade 2! Pay: 100");
            moneyPlay1 += 100;
            moneyPlay2 -= 100;
        }
        if(isBrought18 == true && P1IsMine18 == true && TrainCountP1 == 3)
        {
            Audio.Play("Loss");
            Audio.Play("Fail");
            Debug.Log("Landed on Train Upgrade 3! Pay: ");
            Info.instance.ShowMessage("Landed on Train Upgrade 3! Pay: 150");
            moneyPlay1 += 150;
            moneyPlay2 -= 150;
        }
        if(isBrought18 == true && P1IsMine18 == true && TrainCountP1 == 4)
        {
            Audio.Play("Loss");
            Audio.Play("Fail");
            Debug.Log("Landed on Train Upgrade 4! Pay: ");
            Info.instance.ShowMessage("Landed on Train Upgrade 4! Pay: 300");
            moneyPlay1 += 300;
            moneyPlay2 -= 300;
        }
    }
        [PunRPC]
        public void P2Prop19(int P2PropMinus19)
    {
        if(moneyPlay2 - P2PropMinus19 <= 0) 
        {
            Debug.Log("BANKRUPT!");
            Info.instance.ShowMessage("BANKRUPT!");
        }
        else if(isBrought19 == false )
        {
            Audio.Play("Money");
            moneyPlay2 -= P2PropMinus19;
            Player2Property19.SetActive(true);
            isBrought19 = true;
            P2IsMine19 = true;
            InfoMoney.instance.P2Info("P2: " + moneyPlay2);
            Info.instance.ShowMessage("P2 has brought Prop19");
        }
        if(isBrought19 == true && P1IsMine19 == true)
        {
            Audio.Play("Loss");
            Audio.Play("Fail");
            SetsandHousing.instance.P2CheckProperty15();
            moneyPlay1 += Housing.Build1Money1;
            moneyPlay2 -= Housing.Build1Money2;
        }
        if(isBrought19 == true && P2IsMine19 == true)
        {
            Debug.Log("You Own this property");
            Info.instance.ShowMessage("You Own This Property");
        }
    }
        [PunRPC]
        public void P2Prop20(int P2PropMinus20)
    {
        if(moneyPlay2 - P2PropMinus20 <= 0) 
        {
            Debug.Log("BANKRUPT!");
            Info.instance.ShowMessage("BANKRUPT!");
        }
        else if(isBrought20 == false )
        {
            Audio.Play("Money");
            moneyPlay2 -= P2PropMinus20;
            Player2Property20.SetActive(true);
            isBrought20 = true;
            P2IsMine20 = true;
            InfoMoney.instance.P2Info("P2: " + moneyPlay2);
            Info.instance.ShowMessage("P2 has brought Prop20");
        }
        if(isBrought20 == true && P1IsMine20 == true)
        {
            Audio.Play("Loss");
            Audio.Play("Fail");
            SetsandHousing.instance.P2CheckProperty16();
            moneyPlay1 += Housing.Build1Money1;
            moneyPlay2 -= Housing.Build1Money2;
        }
        if(isBrought20 == true && P2IsMine20 == true)
        {
            Debug.Log("You Own this property");
            Info.instance.ShowMessage("You Own This Property");
        }
    }
        [PunRPC]
        public void P2Prop21(int P2PropMinus21)
    {
        if(moneyPlay2 - P2PropMinus21 <= 0) 
        {
            Debug.Log("BANKRUPT!");
            Info.instance.ShowMessage("BANKRUPT!");
        }
        else if(isBrought21 == false )
        {
            Audio.Play("Money");
            moneyPlay2 -= P2PropMinus21;
            Player2Property21.SetActive(true);
            isBrought21 = true;
            P2IsMine21 = true;
            InfoMoney.instance.P2Info("P2: " + moneyPlay2);
            Info.instance.ShowMessage("P2 has brought Prop21");
        }
        if(isBrought21 == true && P1IsMine21 == true)
        {
            Audio.Play("Prison");
            moneyPlay1 += FATE2;
            moneyPlay2 -= FATE2;
            Debug.Log("Fate will decide your fate! : " + FATE2);
            Info.instance.ShowMessage("Fate will decide your fate! : " + FATE2);
        }
        if(isBrought21 == true && P2IsMine21 == true)
        {
            Debug.Log("You Own this property");
            Info.instance.ShowMessage("You Own This Property");
        }
    }
        [PunRPC]
        public void P2Prop22(int P2PropMinus22)
    {
        if(moneyPlay2 - P2PropMinus22 <= 0) 
        {
            Debug.Log("BANKRUPT!");
            Info.instance.ShowMessage("BANKRUPT!");
        }
        else if(isBrought22 == false )
        {
            Audio.Play("Money");
            moneyPlay2 -= P2PropMinus22;
            Player2Property22.SetActive(true);
            isBrought22 = true;
            P2IsMine22 = true;
            InfoMoney.instance.P2Info("P2: " + moneyPlay2);
            Info.instance.ShowMessage("P2 has brought Prop22");
        }
        if(isBrought22 == true && P1IsMine22 == true)
        {
            Audio.Play("Loss");
            Audio.Play("Fail");
            SetsandHousing.instance.P2CheckProperty17();
            moneyPlay1 += Housing.Build1Money1;
            moneyPlay2 -= Housing.Build1Money2;
        }
        if(isBrought22 == true && P2IsMine22 == true)
        {
            Debug.Log("You Own this property");
            Info.instance.ShowMessage("You Own This Property");
        }
    }
        [PunRPC]
        public void P2Prop23(int P2PropMinus23)
    {
        if(moneyPlay2 - P2PropMinus23 <= 0) 
        {
            Debug.Log("BANKRUPT!");
            Info.instance.ShowMessage("BANKRUPT!");
        }
        else if(isBrought23 == false )
        {
            Audio.Play("Money");
            moneyPlay2 -= P2PropMinus23;
           Player2Property23.SetActive(true);
            isBrought23 = true;
            P2IsMine23 = true;
            InfoMoney.instance.P2Info("P2: " + moneyPlay2);
            Info.instance.ShowMessage("P2 has brought Prop23");
        }
        if(isBrought23 == true && P1IsMine23 == true)
        {
            Audio.Play("Loss");
            Audio.Play("Fail");
            SetsandHousing.instance.P2CheckProperty18();
            moneyPlay1 += Housing.Build1Money1;
            moneyPlay2 -= Housing.Build1Money2;
        }
        if(isBrought23 == true && P2IsMine23 == true)
        {
            Debug.Log("You Own this property");
            Info.instance.ShowMessage("You Own This Property");
        }
    }
        [PunRPC]
             public void P2Prop24(int P2PropMinus24)
    {
        if(moneyPlay2 - P2PropMinus24 <= 0) 
        {
            Debug.Log("BANKRUPT!");
            Info.instance.ShowMessage("BANKRUPT!");
        }
        else if(isBrought24 == false )
        {
            Audio.Play("Money");
            moneyPlay2 -= P2PropMinus24;
            Player2Property24.SetActive(true);
            isBrought24 = true;
            P2IsMine24 = true;
            InfoMoney.instance.P2Info("P2: " + moneyPlay2);
            Info.instance.ShowMessage("P2 has brought Prop24");
        }
        if(isBrought24 == true && P1IsMine24 == true)
        {
            Audio.Play("Loss");
            Audio.Play("Fail");
            SetsandHousing.instance.P2CheckProperty19();
            moneyPlay1 += Housing.Build1Money1;
            moneyPlay2 -= Housing.Build1Money2;
        }
        if(isBrought24 == true && P2IsMine24 == true)
        {
            Debug.Log("You Own this property");
            Info.instance.ShowMessage("You Own This Property");
        }
    }
        [PunRPC]
             public void P2Prop25(int P2PropMinus25)
    {
        if(moneyPlay2 - P2PropMinus25 <= 0) 
        {
            Debug.Log("BANKRUPT!");
            Info.instance.ShowMessage("BANKRUPT!");
        }
        else if(isBrought25 == false )
        {
            Audio.Play("Money");
            moneyPlay2 -= P2PropMinus25;
            Player2Property25.SetActive(true);
            isBrought25 = true;
            P2IsMine25 = true;
            InfoMoney.instance.P2Info("P2: " + moneyPlay2);
            Info.instance.ShowMessage("P2 has brought Prop25");
        }
        if(isBrought25 == true && P1IsMine25 == true)
        {
            Audio.Play("Loss");
            Audio.Play("Fail");
            SetsandHousing.instance.P2CheckProperty20();
            moneyPlay1 += Housing.Build1Money1;
            moneyPlay2 -= Housing.Build1Money2;
        }
        if(isBrought25 == true && P2IsMine25 == true)
        {
            Debug.Log("You Own this property");
            Info.instance.ShowMessage("You Own This Property");
        }
    }
        [PunRPC]
             public void P2Prop26(int P2PropMinus26)
    {
        if(moneyPlay2 - P2PropMinus26 <= 0) 
        {
            Debug.Log("BANKRUPT!");
            Info.instance.ShowMessage("BANKRUPT!");
        }
        else if(isBrought26 == false )
        {
            Audio.Play("Money");
            moneyPlay2 -= P2PropMinus26;
            Player2Property26.SetActive(true);
            isBrought26 = true;
            P2IsMine26 = true;
            InfoMoney.instance.P2Info("P2: " + moneyPlay2);
            Info.instance.ShowMessage("P2 has brought Prop26");
            TrainCountP2++;
        }
        if(isBrought26 == true && P2IsMine26 == true)
        {
            Debug.Log("You Own this Property");
            Info.instance.ShowMessage("You Own this Property");
        }
        if(isBrought26 == true && P1IsMine26 == true && TrainCountP1 == 1)
        {
            Audio.Play("Loss");
            Audio.Play("Fail");
            Debug.Log("Landed on Train Upgrade 1! Pay: ");
            Info.instance.ShowMessage("Landed on Train Upgrade 1! Pay: 50");
            moneyPlay1 += 50;
            moneyPlay2 -= 50;
        }
        if(isBrought26 == true && P1IsMine26 == true && TrainCountP1 == 2)
        {
            Audio.Play("Loss");
            Audio.Play("Fail");
            Debug.Log("Landed on Train Upgrade 2! Pay: ");
            Info.instance.ShowMessage("Landed on Train Upgrade 2! Pay: 100");
            moneyPlay1 += 100;
            moneyPlay2 -= 100;
        }
        if(isBrought26 == true && P1IsMine26 == true && TrainCountP1 == 3)
        {
            Audio.Play("Loss");
            Audio.Play("Fail");
            Debug.Log("Landed on Train Upgrade 3! Pay: ");
            Info.instance.ShowMessage("Landed on Train Upgrade 3! Pay: 150");
            moneyPlay1 += 150;
            moneyPlay2 -= 150;
        }
        if(isBrought26 == true && P1IsMine26 == true && TrainCountP1 == 4)
        {
            Audio.Play("Loss");
            Audio.Play("Fail");
            Debug.Log("Landed on Train Upgrade 4! Pay: ");
            Info.instance.ShowMessage("Landed on Train Upgrade 4! Pay: 300");
            moneyPlay1 += 300;
            moneyPlay2 -= 300;
        }
    }
        [PunRPC]
             public void P2Prop27(int P2PropMinus27)
    {
        if(moneyPlay2 - P2PropMinus27 <= 0) 
        {
            Debug.Log("BANKRUPT!");
            Info.instance.ShowMessage("BANKRUPT!");
        }
        else if(isBrought27 == false )
        {
            Audio.Play("Money");
            moneyPlay2 -= P2PropMinus27;
            Player2Property27.SetActive(true);
            isBrought27 = true;
            P2IsMine27 = true;
            InfoMoney.instance.P2Info("P2: " + moneyPlay2);
            Info.instance.ShowMessage("P2 has brought Prop27");
        }
        if(isBrought27 == true && P1IsMine27 == true)
        {
            Audio.Play("Loss");
            Audio.Play("Fail");
            SetsandHousing.instance.P2CheckProperty21();
            moneyPlay1 += Housing.Build1Money1;
            moneyPlay2 -= Housing.Build1Money2;
        }
        if(isBrought27 == true && P2IsMine27 == true)
        {
            Debug.Log("You Own this property");
            Info.instance.ShowMessage("You Own This Property");
        }
    }
        [PunRPC]
             public void P2Prop28(int P2PropMinus28)
    {
        if(moneyPlay2 - P2PropMinus28 <= 0) 
        {
            Debug.Log("BANKRUPT!");
            Info.instance.ShowMessage("BANKRUPT!");
        }
        else if(isBrought28 == false )
        {
            Audio.Play("Money");
            moneyPlay2 -= P2PropMinus28;
            Player2Property28.SetActive(true);
            isBrought28 = true;
            P2IsMine28 = true;
            InfoMoney.instance.P2Info("P2: " + moneyPlay2);
            Info.instance.ShowMessage("P2 has brought Prop28");
        }
        if(isBrought28 == true && P1IsMine28 == true)
        {
            Audio.Play("Loss");
            Audio.Play("Fail");
            SetsandHousing.instance.P2CheckProperty22();
            moneyPlay1 += Housing.Build1Money1;
            moneyPlay2 -= Housing.Build1Money2;
        }
        if(isBrought28 == true && P2IsMine28 == true)
        {
            Debug.Log("You Own this property");
            Info.instance.ShowMessage("You Own This Property");
        }
    }

}