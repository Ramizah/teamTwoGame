using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

// Created by Caleb

//This file Checks whether Player 1 currently has been sent a trade by Player 2 from the TRADE files. 

//The code will then set trade to active to prevent additional trading by the same player

public class TRADEACTIVEP1 : MonoBehaviour
{
    public SpawnPlayer ID;
    public MoneySystem Money;
    public SetsandHousing Upgrade;
    public static TRADEACTIVEP1 instance;

    public GameObject MainButtonP2;
    public GameObject TradeUI;
    public GameObject Text;
    public GameObject Yes;
    public GameObject No;

    public string PropertyName;
    public int PropertyPrice;
    public int PriceToRpc;

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        ID = FindObjectOfType<SpawnPlayer>();
        Money = FindObjectOfType<MoneySystem>();
        Upgrade = FindObjectOfType<SetsandHousing>();
        TradeUI.SetActive(false);
        Text.SetActive(false);
        Yes.SetActive(false);
        No.SetActive(false);

        if(ID.ConstantID == 0)
        {
            MainButtonP2.SetActive(false);
        }
    }

    [PunRPC]
    public void UpdateValues(int RPCPrice)
    {
        PriceToRpc = RPCPrice;
    }

    public void TradeAcceptP1(int Trade, string Name)
    {
        PhotonView TradeView = GetComponent<PhotonView>();
        PropertyName = Name;
        PropertyPrice = Trade;

        TradeView.RPC("UpdateValues", RpcTarget.All, PropertyPrice);

        TradeUI.SetActive(true);
        Text.SetActive(true);
        Yes.SetActive(true);
        No.SetActive(true);

        InfoTrade2.instance.TradeText("Player would like to trade " + Name + " for " + Trade);
    }

    public void TradeNo()
    {
        PhotonView TradeView = GetComponent<PhotonView>();
        TradeUI.SetActive(false);
        TradeView.RPC("RestartOnNo", RpcTarget.Others);
    }

    [PunRPC]
    public void RestartOnNo()
    {
        TRADEP2.instance.TradeReactivate();
    }

    public void TradeYes()
    {
        PhotonView TradeView = GetComponent<PhotonView>();

        if(PropertyName == "Goldberg")
        {
            TradeView.RPC("RPCGoldberg", RpcTarget.All);
        }
        if(PropertyName == "Quinn")
        {
            TradeView.RPC("RPCQuinn", RpcTarget.All);
        }
        if(PropertyName == "Sang")
        {
            TradeView.RPC("RPCSang", RpcTarget.All);
        }
        if(PropertyName == "Sae")
        {
            TradeView.RPC("RPCSae", RpcTarget.All);
        }
        if(PropertyName == "Gi")
        {
            TradeView.RPC("RPCGi", RpcTarget.All);
        }
        if(PropertyName == "Holmes")
        {
            TradeView.RPC("RPCHolmes", RpcTarget.All);
        }
        if(PropertyName == "Watson")
        {
            TradeView.RPC("RPCWatson", RpcTarget.All);
        }
        if(PropertyName == "Lestrade")
        {
            TradeView.RPC("RPCLestrade", RpcTarget.All);
        }
        if(PropertyName == "Harry")
        {
            TradeView.RPC("RPCHarry", RpcTarget.All);
        }
        if(PropertyName == "Dumble")
        {
            TradeView.RPC("RPCDumble", RpcTarget.All);
        }
        if(PropertyName == "Snape")
        {
            TradeView.RPC("RPCSnape", RpcTarget.All);
        }
        if(PropertyName == "Skywalker")
        {
            TradeView.RPC("RPCSkywalker", RpcTarget.All);
        }
        if(PropertyName == "Kenobi")
        {
            TradeView.RPC("RPCKenobi", RpcTarget.All);
        }
        if(PropertyName == "Solo")
        {
            TradeView.RPC("RPCSolo", RpcTarget.All);
        }
        if(PropertyName == "Eleven")
        {
            TradeView.RPC("RPCEleven", RpcTarget.All);
        }
        if(PropertyName == "Wheeler")
        {
            TradeView.RPC("RPCWheeler", RpcTarget.All);
        }
        if(PropertyName == "Hopper")
        {
            TradeView.RPC("RPCHopper", RpcTarget.All);
        }
        if(PropertyName == "Summer")
        {
            TradeView.RPC("RPCSummer", RpcTarget.All);
        }
        if(PropertyName == "Morty")
        {
            TradeView.RPC("RPCMorty", RpcTarget.All);
        }
        if(PropertyName == "Ricks")
        {
            TradeView.RPC("RPCRick", RpcTarget.All);
        }
        if(PropertyName == "Myer")
        {
            TradeView.RPC("RPCMyer", RpcTarget.All);
        }
        if(PropertyName == "Strode")
        {
            TradeView.RPC("RPCStrode", RpcTarget.All);
        }
    }


    [PunRPC]
    public void RPCGoldberg()
    {
        Money.Player1Property1.SetActive(true);
        Money.Player2Property1.SetActive(false);
        Money.P1IsMine1 = true;
        Money.P2IsMine1 = false;
        Upgrade.P2OwnSet1 = false;
        Money.moneyPlay1 -= PriceToRpc;
        Money.moneyPlay2 += PriceToRpc;
        TradeUI.SetActive(false);
        TRADEP2.instance.TradeReactivate();
    }

    [PunRPC]
    public void RPCQuinn()
    {
        Money.Player1Property2.SetActive(true);
        Money.Player2Property2.SetActive(false);
        Money.P1IsMine2 = true;
        Money.P2IsMine2 = false;
        Upgrade.P2OwnSet1 = false;
        Money.moneyPlay1 -= PriceToRpc;
        Money.moneyPlay2 += PriceToRpc;
        TradeUI.SetActive(false);
        TRADEP2.instance.TradeReactivate();
    }

    [PunRPC]
    public void RPCSang()
    {
        Money.Player1Property4.SetActive(true);
        Money.Player2Property4.SetActive(false);
        Money.P1IsMine4 = true;
        Money.P2IsMine4 = false;
        Debug.Log(Money.P1IsMine4);
        Money.moneyPlay1 -= PriceToRpc;
        Money.moneyPlay2 += PriceToRpc;
        TradeUI.SetActive(false);
        TRADEP2.instance.TradeReactivate();
    }

    [PunRPC]
    public void RPCSae()
    {
        Money.Player1Property5.SetActive(true);
        Money.Player2Property5.SetActive(false);
        Money.P1IsMine5 = true;
        Money.P2IsMine5 = false;
        Debug.Log(Money.P1IsMine5);
        Money.moneyPlay1 -= PriceToRpc;
        Money.moneyPlay2 += PriceToRpc;
        TradeUI.SetActive(false);
        TRADEP2.instance.TradeReactivate();
    }

    [PunRPC]
    public void RPCGi()
    {
        Money.Player1Property6.SetActive(true);
        Money.Player2Property6.SetActive(false);
        Money.P1IsMine6 = true;
        Money.P2IsMine6 = false;
        Debug.Log(Money.P1IsMine6);
        Money.moneyPlay1 -= PriceToRpc;
        Money.moneyPlay2 += PriceToRpc;
        TradeUI.SetActive(false);
        TRADEP2.instance.TradeReactivate();
    }

    [PunRPC]
    public void RPCHolmes()
    {
        Money.Player1Property7.SetActive(true);
        Money.Player2Property7.SetActive(false);
        Money.P1IsMine7 = true;
        Money.P2IsMine7 = false;
        Debug.Log(Money.P1IsMine7);
        Money.moneyPlay1 -= PriceToRpc;
        Money.moneyPlay2 += PriceToRpc;
        TradeUI.SetActive(false);
        TRADEP2.instance.TradeReactivate();
    }

    [PunRPC]
    public void RPCWatson()
    {
        Money.Player1Property9.SetActive(true);
        Money.Player2Property9.SetActive(false);
        Money.P1IsMine9 = true;
        Money.P2IsMine9 = false;
        Debug.Log(Money.P1IsMine9);
        Money.moneyPlay1 -= PriceToRpc;
        Money.moneyPlay2 += PriceToRpc;
        TradeUI.SetActive(false);
        TRADEP2.instance.TradeReactivate();
    }

    [PunRPC]
    public void RPCLestrade()
    {
        Money.Player1Property10.SetActive(true);
        Money.Player2Property10.SetActive(false);
        Money.P1IsMine10 = true;
        Money.P2IsMine10 = false;
        Debug.Log(Money.P1IsMine10);
        Money.moneyPlay1 -= PriceToRpc;
        Money.moneyPlay2 += PriceToRpc;
        TradeUI.SetActive(false);
        TRADEP2.instance.TradeReactivate();
    }

    [PunRPC]
    public void RPCHarry()
    {
        Money.Player1Property12.SetActive(true);
        Money.Player2Property12.SetActive(false);
        Money.P1IsMine12 = true;
        Money.P2IsMine12 = false;
        Debug.Log(Money.P1IsMine12);
        Money.moneyPlay1 -= PriceToRpc;
        Money.moneyPlay2 += PriceToRpc;
        TradeUI.SetActive(false);
        TRADEP2.instance.TradeReactivate();
    }

    [PunRPC]
    public void RPCDumble()
    {
        Money.Player1Property13.SetActive(true);
        Money.Player2Property13.SetActive(false);
        Money.P1IsMine13 = true;
        Money.P2IsMine13 = false;
        Debug.Log(Money.P1IsMine13);
        Money.moneyPlay1 -= PriceToRpc;
        Money.moneyPlay2 += PriceToRpc;
        TradeUI.SetActive(false);
        TRADEP2.instance.TradeReactivate();
    }

    [PunRPC]
    public void RPCSnape()
    {
        Money.Player1Property14.SetActive(true);
        Money.Player2Property14.SetActive(false);
        Money.P1IsMine14 = true;
        Money.P2IsMine14 = false;
        Debug.Log(Money.P1IsMine14);
        Money.moneyPlay1 -= PriceToRpc;
        Money.moneyPlay2 += PriceToRpc;
        TradeUI.SetActive(false);
        TRADEP2.instance.TradeReactivate();
    }

    [PunRPC]
    public void RPCSkywalker()
    {
        Money.Player1Property15.SetActive(true);
        Money.Player2Property15.SetActive(false);
        Money.P1IsMine15 = true;
        Money.P2IsMine15 = false;
        Debug.Log(Money.P1IsMine15);
        Money.moneyPlay1 -= PriceToRpc;
        Money.moneyPlay2 += PriceToRpc;
        TradeUI.SetActive(false);
        TRADEP2.instance.TradeReactivate();
    }

    [PunRPC]
    public void RPCKenobi()
    {
        Money.Player1Property16.SetActive(true);
        Money.Player2Property16.SetActive(false);
        Money.P1IsMine16 = true;
        Money.P2IsMine16 = false;
        Debug.Log(Money.P1IsMine16);
        Money.moneyPlay1 -= PriceToRpc;
        Money.moneyPlay2 += PriceToRpc;
        TradeUI.SetActive(false);
        TRADEP2.instance.TradeReactivate();
    }

    [PunRPC]
    public void RPCSolo()
    {
        Money.Player1Property17.SetActive(true);
        Money.Player2Property17.SetActive(false);
        Money.P1IsMine17 = true;
        Money.P2IsMine17 = false;
        Debug.Log(Money.P1IsMine17);
        Money.moneyPlay1 -= PriceToRpc;
        Money.moneyPlay2 += PriceToRpc;
        TradeUI.SetActive(false);
        TRADEP2.instance.TradeReactivate();
    }

    [PunRPC]
    public void RPCEleven()
    {
        Money.Player1Property19.SetActive(true);
        Money.Player2Property19.SetActive(false);
        Money.P1IsMine19 = true;
        Money.P2IsMine19 = false;
        Debug.Log(Money.P1IsMine19);
        Money.moneyPlay1 -= PriceToRpc;
        Money.moneyPlay2 += PriceToRpc;
        TradeUI.SetActive(false);
        TRADEP2.instance.TradeReactivate();
    }

    [PunRPC]
    public void RPCWheeler()
    {
        Money.Player1Property20.SetActive(true);
        Money.Player2Property20.SetActive(false);
        Money.P1IsMine20 = true;
        Money.P2IsMine20 = false;
        Debug.Log(Money.P1IsMine20);
        Money.moneyPlay1 -= PriceToRpc;
        Money.moneyPlay2 += PriceToRpc;
        TradeUI.SetActive(false);
        TRADEP2.instance.TradeReactivate();
    }

    [PunRPC]
    public void RPCHopper()
    {
        Money.Player1Property22.SetActive(true);
        Money.Player2Property22.SetActive(false);
        Money.P1IsMine22 = true;
        Money.P2IsMine22 = false;
        Debug.Log(Money.P1IsMine22);
        Money.moneyPlay1 -= PriceToRpc;
        Money.moneyPlay2 += PriceToRpc;
        TradeUI.SetActive(false);
        TRADEP2.instance.TradeReactivate();
    }

    [PunRPC]
    public void RPCSummer()
    {
        Money.Player1Property23.SetActive(true);
        Money.Player2Property23.SetActive(false);
        Money.P1IsMine23 = true;
        Money.P2IsMine23 = false;
        Debug.Log(Money.P1IsMine23);
        Money.moneyPlay1 -= PriceToRpc;
        Money.moneyPlay2 += PriceToRpc;
        TradeUI.SetActive(false);
        TRADEP2.instance.TradeReactivate();
    }

    [PunRPC]
    public void RPCMorty()
    {
        Money.Player1Property24.SetActive(true);
        Money.Player2Property24.SetActive(false);
        Money.P1IsMine24 = true;
        Money.P2IsMine24 = false;
        Debug.Log(Money.P1IsMine24);
        Money.moneyPlay1 -= PriceToRpc;
        Money.moneyPlay2 += PriceToRpc;
        TradeUI.SetActive(false);
        TRADEP2.instance.TradeReactivate();
    }

    [PunRPC]
    public void RPCRick()
    {
        Money.Player1Property25.SetActive(true);
        Money.Player2Property25.SetActive(false);
        Money.P1IsMine25 = true;
        Money.P2IsMine25 = false;
        Debug.Log(Money.P1IsMine25);
        Money.moneyPlay1 -= PriceToRpc;
        Money.moneyPlay2 += PriceToRpc;
        TradeUI.SetActive(false);
        TRADEP2.instance.TradeReactivate();
    }

    [PunRPC]
    public void RPCMyer()
    {
        Money.Player1Property27.SetActive(true);
        Money.Player2Property27.SetActive(false);
        Money.P1IsMine27 = true;
        Money.P2IsMine27 = false;
        Debug.Log(Money.P1IsMine27);
        Money.moneyPlay1 -= PriceToRpc;
        Money.moneyPlay2 += PriceToRpc;
        TradeUI.SetActive(false);
        TRADEP2.instance.TradeReactivate();
    }

    [PunRPC]
    public void RPCStrode()
    {
        Money.Player1Property28.SetActive(true);
        Money.Player2Property28.SetActive(false);
        Money.P1IsMine28 = true;
        Money.P2IsMine28 = false;
        Debug.Log(Money.P1IsMine28);
        Money.moneyPlay1 -= PriceToRpc;
        Money.moneyPlay2 += PriceToRpc;
        TradeUI.SetActive(false);
        TRADEP2.instance.TradeReactivate();
    }

}
