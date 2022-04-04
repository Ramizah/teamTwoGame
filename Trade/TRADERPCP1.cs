using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine.UI;

// Created by Caleb

//Trade RPC will change the values for player ownership within this file and complete the trade

//Trade window for inital trading player reactivates and trade can begin anew

public class TRADERPCP1 : MonoBehaviour
{
    public InputField Goldberg;
    public InputField Quinn;
    public InputField Sang;
    public InputField Sae;
    public InputField Gi;
    public InputField Holmes;
    public InputField Watson;
    public InputField Lestrade;
    public InputField Harry;
    public InputField Dumble;
    public InputField Snape;
    public InputField Skywalker;
    public InputField Kenobi;
    public InputField Solo;
    public InputField Eleven;
    public InputField Wheeler;
    public InputField Hopper;
    public InputField Summer;
    public InputField Morty;
    public InputField Rick;
    public InputField Myer;
    public InputField Strode;

    public MoneySystem Money;
    public static TRADERPCP1 instance;

    public int InputedInt;
    public int PlaceholderValue;
    
    public bool GoldbergNo = false;
    public bool QuinnNo = false;
    public bool SangNo = false;
    public bool SaeNo = false;
    public bool GiNo = false;
    public bool HolmesNo = false;
    public bool WatsonNo = false;
    public bool LestradeNo = false;
    public bool HarryNo = false;
    public bool DumbleNo = false;
    public bool SnapeNo = false;
    public bool SkywalkerNo = false;
    public bool KenobiNo = false;
    public bool SoloNo = false;
    public bool ElevenNo = false;
    public bool WheelerNo = false;
    public bool HopperNo = false;
    public bool SummerNo = false;
    public bool MortyNo = false;
    public bool RickNo = false;
    public bool MyerNo = false;
    public bool StrodeNo = false;

    public string GoldbergName = "Goldberg";
    public string QuinnName = "Quinn";
    public string SangName = "Sang";
    public string SaeName = "Sae";
    public string GiName = "Gi";
    public string HolmesName = "Holmes";
    public string WatsonName = "Watson";
    public string LestradeName = "Lestrade";
    public string HarryName = "Harry";
    public string DumbleName = "Dumble";
    public string SnapeName = "Snape";
    public string SkywalkerName = "Skywalker";
    public string KenobiName = "Kenobi";
    public string SoloName = "Solo";
    public string ElevenName = "Eleven";
    public string WheelerName = "Wheeler";
    public string HopperName = "Hopper";
    public string SummerName = "Summer";
    public string MortyName = "Morty";
    public string RickName = "Ricks";
    public string MyerName = "Myer";
    public string StrodeName = "Strode";


    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        Money = FindObjectOfType<MoneySystem>();
    }

    public void NoTrade(int Count)
    {
        if(Count == 1)
        {
            GoldbergNo = true;
        }
        if(Count == 2)
        {
            QuinnNo = true;
        }
        if(Count == 3)
        {
            SangNo = true;
        }
        if(Count == 4)
        {
            SaeNo = true;
        }
        if(Count == 5)
        {
            GiNo = true;
        }
        if(Count == 6)
        {
            HolmesNo = true;
        }
        if(Count == 7)
        {
            WatsonNo = true;
        }
        if(Count == 8)
        {
            LestradeNo = true;
        }
        if(Count == 9)
        {
            HarryNo = true;
        }
        if(Count == 10)
        {
            DumbleNo = true;
        }
        if(Count == 11)
        {
            SnapeNo = true;
        }
        if(Count == 12)
        {
            SkywalkerNo = true;
        }
        if(Count == 13)
        {
            KenobiNo = true;
        }
        if(Count == 14)
        {
            SoloNo = true;
        }
        if(Count == 15)
        {
            ElevenNo = true;
        }
        if(Count == 16)
        {
            WheelerNo = true;
        }
        if(Count == 17)
        {
            HopperNo = true;
        }
        if(Count == 18)
        {
            SummerNo = true;
        }
        if(Count == 19)
        {
            MortyNo = true;
        }
        if(Count == 20)
        {
            RickNo = true;
        }
        if(Count == 21)
        {
            MyerNo = true;
        }
        if(Count == 22)
        {
            StrodeNo = true;
        }
    }

    public void TradeGoldberg()
    {
        PhotonView Trade = GetComponent<PhotonView>();

        if(string.IsNullOrEmpty(Goldberg.text) || GoldbergNo == true)
        {
            Debug.Log("Can't trade with houses or wrong input");
        }
        else 
        {
            InputedInt = int.Parse(Goldberg.text);

            if(InputedInt > Money.moneyPlay2)
            {
                Debug.Log("Player does not have enough money to trade!");
            }
            if(InputedInt <= Money.moneyPlay2)
            {
                Trade.RPC("RPCGoldberg", RpcTarget.Others, InputedInt, GoldbergName);
                TRADEP1.instance.RestartTrade();
            }
        }
    }

    public void TradeQuinn()
    {
        PhotonView Trade = GetComponent<PhotonView>();

        if(string.IsNullOrEmpty(Quinn.text) || QuinnNo == true)
        {
            Debug.Log("Can't trade with houses or wrong input");
        }
        else 
        {
            InputedInt = int.Parse(Quinn.text);

            if(InputedInt > Money.moneyPlay2)
            {
                Debug.Log("Player does not have enough money to trade!");
            }
            if(InputedInt <= Money.moneyPlay2)
            {
                Trade.RPC("RPCQuinn", RpcTarget.Others, InputedInt, QuinnName);
                TRADEP1.instance.RestartTrade();
            }
        }
    }

    public void TradeSang()
    {
        PhotonView Trade = GetComponent<PhotonView>();

        if(string.IsNullOrEmpty(Sang.text) || SangNo == true)
        {
            Debug.Log("Can't trade with houses or wrong input");
        }
        else 
        {
            InputedInt = int.Parse(Sang.text);

            if(InputedInt > Money.moneyPlay2)
            {
                Debug.Log("Player does not have enough money to trade!");
            }
            if(InputedInt <= Money.moneyPlay2)
            {
                Trade.RPC("RPCSang", RpcTarget.Others, InputedInt, SangName);
                TRADEP1.instance.RestartTrade();
            }
        }
    }

    public void TradeSae()
    {
        PhotonView Trade = GetComponent<PhotonView>();

        if(string.IsNullOrEmpty(Sae.text) || SaeNo == true)
        {
            Debug.Log("Can't trade with houses or wrong input");
        }
        else 
        {
            InputedInt = int.Parse(Sae.text);

            if(InputedInt > Money.moneyPlay2)
            {
                Debug.Log("Player does not have enough money to trade!");
            }
            if(InputedInt <= Money.moneyPlay2)
            {
                Trade.RPC("RPCSae", RpcTarget.Others, InputedInt, SaeName);
                TRADEP1.instance.RestartTrade();
            }
        }
    }

    public void TradeGi()
    {
        PhotonView Trade = GetComponent<PhotonView>();

        if(string.IsNullOrEmpty(Gi.text) || GiNo == true)
        {
            Debug.Log("Can't trade with houses or wrong input");
        }
        else 
        {
            InputedInt = int.Parse(Gi.text);

            if(InputedInt > Money.moneyPlay2)
            {
                Debug.Log("Player does not have enough money to trade!");
            }
            if(InputedInt <= Money.moneyPlay2)
            {
                Trade.RPC("RPCGi", RpcTarget.Others, InputedInt, GiName);
                TRADEP1.instance.RestartTrade();
            }
        }
    }
    
    public void TradeHolmes()
    {
        PhotonView Trade = GetComponent<PhotonView>();

        if(string.IsNullOrEmpty(Holmes.text) || HolmesNo == true)
        {
            Debug.Log("Can't trade with houses or wrong input");
        }
        else 
        {
            InputedInt = int.Parse(Holmes.text);

            if(InputedInt > Money.moneyPlay2)
            {
                Debug.Log("Player does not have enough money to trade!");
            }
            if(InputedInt <= Money.moneyPlay2)
            {
                Trade.RPC("RPCHolmes", RpcTarget.Others, InputedInt, HolmesName);
                TRADEP1.instance.RestartTrade();
            }
        }
    }

    public void TradeWatson()
    {
        PhotonView Trade = GetComponent<PhotonView>();

        if(string.IsNullOrEmpty(Watson.text) || WatsonNo == true)
        {
            Debug.Log("Can't trade with houses or wrong input");
        }
        else 
        {
            InputedInt = int.Parse(Watson.text);

            if(InputedInt > Money.moneyPlay2)
            {
                Debug.Log("Player does not have enough money to trade!");
            }
            if(InputedInt <= Money.moneyPlay2)
            {
                Trade.RPC("RPCWatson", RpcTarget.Others, InputedInt, WatsonName);
                TRADEP1.instance.RestartTrade();
            }
        }
    }

    public void TradeLestrade()
    {
        PhotonView Trade = GetComponent<PhotonView>();

        if(string.IsNullOrEmpty(Lestrade.text) || LestradeNo == true)
        {
            Debug.Log("Can't trade with houses or wrong input");
        }
        else 
        {
            InputedInt = int.Parse(Lestrade.text);

            if(InputedInt > Money.moneyPlay2)
            {
                Debug.Log("Player does not have enough money to trade!");
            }
            if(InputedInt <= Money.moneyPlay2)
            {
                Trade.RPC("RPCLestrade", RpcTarget.Others, InputedInt, LestradeName);
                TRADEP1.instance.RestartTrade();
            }
        }
    }

    public void TradeHarry()
    {
        PhotonView Trade = GetComponent<PhotonView>();

        if(string.IsNullOrEmpty(Harry.text) || HarryNo == true)
        {
            Debug.Log("Can't trade with houses or wrong input");
        }
        else 
        {
            InputedInt = int.Parse(Harry.text);

            if(InputedInt > Money.moneyPlay2)
            {
                Debug.Log("Player does not have enough money to trade!");
            }
            if(InputedInt <= Money.moneyPlay2)
            {
                Trade.RPC("RPCHarry", RpcTarget.Others, InputedInt, HarryName);
                TRADEP1.instance.RestartTrade();
            }
        }
    }

    public void TradeDumble()
    {
        PhotonView Trade = GetComponent<PhotonView>();

        if(string.IsNullOrEmpty(Dumble.text) || DumbleNo == true)
        {
            Debug.Log("Can't trade with houses or wrong input");
        }
        else 
        {
            InputedInt = int.Parse(Dumble.text);

            if(InputedInt > Money.moneyPlay2)
            {
                Debug.Log("Player does not have enough money to trade!");
            }
            if(InputedInt <= Money.moneyPlay2)
            {
                Trade.RPC("RPCDumble", RpcTarget.Others, InputedInt, DumbleName);
                TRADEP1.instance.RestartTrade();
            }
        }
    }

    public void TradeSnape()
    {
        PhotonView Trade = GetComponent<PhotonView>();

        if(string.IsNullOrEmpty(Snape.text) || SnapeNo == true)
        {
            Debug.Log("Can't trade with houses or wrong input");
        }
        else 
        {
            InputedInt = int.Parse(Snape.text);

            if(InputedInt > Money.moneyPlay2)
            {
                Debug.Log("Player does not have enough money to trade!");
            }
            if(InputedInt <= Money.moneyPlay2)
            {
                Trade.RPC("RPCSnape", RpcTarget.Others, InputedInt, SnapeName);
                TRADEP1.instance.RestartTrade();
            }
        }
    }

    public void TradeSkywalker()
    {
        PhotonView Trade = GetComponent<PhotonView>();

        if(string.IsNullOrEmpty(Skywalker.text) || SkywalkerNo == true)
        {
            Debug.Log("Can't trade with houses or wrong input");
        }
        else 
        {
            InputedInt = int.Parse(Skywalker.text);

            if(InputedInt > Money.moneyPlay2)
            {
                Debug.Log("Player does not have enough money to trade!");
            }
            if(InputedInt <= Money.moneyPlay2)
            {
                Trade.RPC("RPCSkywalker", RpcTarget.Others, InputedInt, SkywalkerName);
                TRADEP1.instance.RestartTrade();
            }
        }
    }

    public void TradeKenobi()
    {
        PhotonView Trade = GetComponent<PhotonView>();

        if(string.IsNullOrEmpty(Kenobi.text) || KenobiNo == true)
        {
            Debug.Log("Can't trade with houses or wrong input");
        }
        else 
        {
            InputedInt = int.Parse(Kenobi.text);

            if(InputedInt > Money.moneyPlay2)
            {
                Debug.Log("Player does not have enough money to trade!");
            }
            if(InputedInt <= Money.moneyPlay2)
            {
                Trade.RPC("RPCKenobi", RpcTarget.Others, InputedInt, KenobiName);
                TRADEP1.instance.RestartTrade();
            }
        }
    }

    public void TradeSolo()
    {
        PhotonView Trade = GetComponent<PhotonView>();

        if(string.IsNullOrEmpty(Solo.text) || SoloNo == true)
        {
            Debug.Log("Can't trade with houses or wrong input");
        }
        else 
        {
            InputedInt = int.Parse(Solo.text);

            if(InputedInt > Money.moneyPlay2)
            {
                Debug.Log("Player does not have enough money to trade!");
            }
            if(InputedInt <= Money.moneyPlay2)
            {
                Trade.RPC("RPCSolo", RpcTarget.Others, InputedInt, SoloName);
                TRADEP1.instance.RestartTrade();
            }
        }
    }

    public void TradeEleven()
    {
        PhotonView Trade = GetComponent<PhotonView>();

        if(string.IsNullOrEmpty(Eleven.text) || ElevenNo == true)
        {
            Debug.Log("Can't trade with houses or wrong input");
        }
        else 
        {
            InputedInt = int.Parse(Eleven.text);

            if(InputedInt > Money.moneyPlay2)
            {
                Debug.Log("Player does not have enough money to trade!");
            }
            if(InputedInt <= Money.moneyPlay2)
            {
                Trade.RPC("RPCEleven", RpcTarget.Others, InputedInt, ElevenName);
                TRADEP1.instance.RestartTrade();
            }
        }
    }

    public void TradeWheeler()
    {
        PhotonView Trade = GetComponent<PhotonView>();

        if(string.IsNullOrEmpty(Wheeler.text) || WheelerNo == true)
        {
            Debug.Log("Can't trade with houses or wrong input");
        }
        else 
        {
            InputedInt = int.Parse(Wheeler.text);

            if(InputedInt > Money.moneyPlay2)
            {
                Debug.Log("Player does not have enough money to trade!");
            }
            if(InputedInt <= Money.moneyPlay2)
            {
                Trade.RPC("RPCWheeler", RpcTarget.Others, InputedInt, WheelerName);
                TRADEP1.instance.RestartTrade();
            }
        }
    }

    public void TradeSummer()
    {
        PhotonView Trade = GetComponent<PhotonView>();

        if(string.IsNullOrEmpty(Summer.text) || SummerNo == true)
        {
            Debug.Log("Can't trade with houses or wrong input");
        }
        else 
        {
            InputedInt = int.Parse(Summer.text);

            if(InputedInt > Money.moneyPlay2)
            {
                Debug.Log("Player does not have enough money to trade!");
            }
            if(InputedInt <= Money.moneyPlay2)
            {
                Trade.RPC("RPCSummer", RpcTarget.Others, InputedInt, SummerName);
                TRADEP1.instance.RestartTrade();
            }
        }
    }

    public void TradeMorty()
    {
        PhotonView Trade = GetComponent<PhotonView>();

        if(string.IsNullOrEmpty(Morty.text) || MortyNo == true)
        {
            Debug.Log("Can't trade with houses or wrong input");
        }
        else 
        {
            InputedInt = int.Parse(Morty.text);

            if(InputedInt > Money.moneyPlay2)
            {
                Debug.Log("Player does not have enough money to trade!");
            }
            if(InputedInt <= Money.moneyPlay2)
            {
                Trade.RPC("RPCMorty", RpcTarget.Others, InputedInt, MortyName);
                TRADEP1.instance.RestartTrade();
            }
        }
    }

    public void TradeRick()
    {
        PhotonView Trade = GetComponent<PhotonView>();

        if(string.IsNullOrEmpty(Rick.text) || RickNo == true)
        {
            Debug.Log("Can't trade with houses or wrong input");
        }
        else 
        {
            InputedInt = int.Parse(Rick.text);

            if(InputedInt > Money.moneyPlay2)
            {
                Debug.Log("Player does not have enough money to trade!");
            }
            if(InputedInt <= Money.moneyPlay2)
            {
                Trade.RPC("RPCRick", RpcTarget.Others, InputedInt, RickName);
                TRADEP1.instance.RestartTrade();
            }
        }
    }

    public void TradeMyer()
    {
        PhotonView Trade = GetComponent<PhotonView>();

        if(string.IsNullOrEmpty(Myer.text) || MyerNo == true)
        {
            Debug.Log("Can't trade with houses or wrong input");
        }
        else 
        {
            InputedInt = int.Parse(Myer.text);

            if(InputedInt > Money.moneyPlay2)
            {
                Debug.Log("Player does not have enough money to trade!");
            }
            if(InputedInt <= Money.moneyPlay2)
            {
                Trade.RPC("RPCMyer", RpcTarget.Others, InputedInt, MyerName);
                TRADEP1.instance.RestartTrade();
            }
        }
    }

    public void TradeStrode()
    {
        PhotonView Trade = GetComponent<PhotonView>();

        if(string.IsNullOrEmpty(Strode.text) || StrodeNo == true)
        {
            Debug.Log("Can't trade with houses or wrong input");
        }
        else 
        {
            InputedInt = int.Parse(Strode.text);

            if(InputedInt > Money.moneyPlay2)
            {
                Debug.Log("Player does not have enough money to trade!");
            }
            if(InputedInt <= Money.moneyPlay2)
            {
                Trade.RPC("RPCStrode", RpcTarget.Others, InputedInt, StrodeName);
                TRADEP1.instance.RestartTrade();
            }
        }
    }

    public void TradeHopper()
    {
        PhotonView Trade = GetComponent<PhotonView>();

        if(string.IsNullOrEmpty(Hopper.text) || HopperNo == true)
        {
            Debug.Log("Can't trade with houses or wrong input");
        }
        else 
        {
            InputedInt = int.Parse(Hopper.text);

            if(InputedInt > Money.moneyPlay2)
            {
                Debug.Log("Player does not have enough money to trade!");
            }
            if(InputedInt <= Money.moneyPlay2)
            {
                Trade.RPC("RPCHopper", RpcTarget.Others, InputedInt, HopperName);
                TRADEP1.instance.RestartTrade();
            }
        }
    }


    [PunRPC]
    public void RPCGoldberg(int Value, string GoldbergName)
    {
        Debug.Log(Value);
        TRADEACTIVEP2.instance.TradeAcceptP2(Value, GoldbergName);
    }

    [PunRPC]
    public void RPCQuinn(int Value, string QuinnName)
    {
        Debug.Log(Value);
        TRADEACTIVEP2.instance.TradeAcceptP2(Value, QuinnName);
    }

    [PunRPC]
    public void RPCSang(int Value, string SangName)
    {
        Debug.Log(Value);
        TRADEACTIVEP2.instance.TradeAcceptP2(Value, SangName);
    }

    [PunRPC]
    public void RPCSae(int Value, string SaeName)
    {
        Debug.Log(Value);
        TRADEACTIVEP2.instance.TradeAcceptP2(Value, SaeName);
    }

    [PunRPC]
    public void RPCGi(int Value, string GiName)
    {
        Debug.Log(Value);
        TRADEACTIVEP2.instance.TradeAcceptP2(Value, GiName);
    }

    [PunRPC]
    public void RPCHolmes(int Value, string HolmesName)
    {
        Debug.Log(Value);
        TRADEACTIVEP2.instance.TradeAcceptP2(Value, HolmesName);
    }

    [PunRPC]
    public void RPCWatson(int Value, string WatsonName)
    {
        Debug.Log(Value);
        TRADEACTIVEP2.instance.TradeAcceptP2(Value, WatsonName);
    }

    [PunRPC]
    public void RPCLestrade(int Value, string LestradeName)
    {
        Debug.Log(Value);
        TRADEACTIVEP2.instance.TradeAcceptP2(Value, LestradeName);
    }

    [PunRPC]
    public void RPCHarry(int Value, string HarryName)
    {
        Debug.Log(Value);
        TRADEACTIVEP2.instance.TradeAcceptP2(Value, HarryName);
    }

    [PunRPC]
    public void RPCDumble(int Value, string DumbleName)
    {
        Debug.Log(Value);
        TRADEACTIVEP2.instance.TradeAcceptP2(Value, DumbleName);
    }

    [PunRPC]
    public void RPCSnape(int Value, string SnapeName)
    {
        Debug.Log(Value);
        TRADEACTIVEP2.instance.TradeAcceptP2(Value, SnapeName);
    }

    [PunRPC]
    public void RPCSkywalker(int Value, string SkywalkerName)
    {
        Debug.Log(Value);
        TRADEACTIVEP2.instance.TradeAcceptP2(Value, SkywalkerName);
    }

    [PunRPC]
    public void RPCKenobi(int Value, string KenobiName)
    {
        Debug.Log(Value);
        TRADEACTIVEP2.instance.TradeAcceptP2(Value, KenobiName);
    }

    [PunRPC]
    public void RPCSolo(int Value, string SoloName)
    {
        Debug.Log(Value);
        TRADEACTIVEP2.instance.TradeAcceptP2(Value, SoloName);
    }

    [PunRPC]
    public void RPCEleven(int Value, string ElevenName)
    {
        Debug.Log(Value);
        TRADEACTIVEP2.instance.TradeAcceptP2(Value, ElevenName);
    }

    [PunRPC]
    public void RPCWheeler(int Value, string WheelerName)
    {
        Debug.Log(Value);
        TRADEACTIVEP2.instance.TradeAcceptP2(Value, WheelerName);
    }

    [PunRPC]
    public void RPCHopper(int Value, string HopperName)
    {
        Debug.Log(Value);
        TRADEACTIVEP2.instance.TradeAcceptP2(Value, HopperName);
    }
    
    [PunRPC]
    public void RPCSummer(int Value, string SummerName)
    {
        Debug.Log(Value);
        TRADEACTIVEP2.instance.TradeAcceptP2(Value, SummerName);
    }

    [PunRPC]
    public void RPCMorty(int Value, string MortyName)
    {
        Debug.Log(Value);
        TRADEACTIVEP2.instance.TradeAcceptP2(Value, MortyName);
    }

    [PunRPC]
    public void RPCRick(int Value, string RickName)
    {
        Debug.Log(Value);
        TRADEACTIVEP2.instance.TradeAcceptP2(Value, RickName);
    }

    [PunRPC]
    public void RPCMyer(int Value, string MyerName)
    {
        Debug.Log(Value);
        TRADEACTIVEP2.instance.TradeAcceptP2(Value, MyerName);
    }

    [PunRPC]
    public void RPCStrode(int Value, string StrodeName)
    {
        Debug.Log(Value);
        TRADEACTIVEP2.instance.TradeAcceptP2(Value, StrodeName);
    }



}
