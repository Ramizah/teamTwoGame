using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using Photon.Realtime;

// Created by Caleb

//File needs massive refactoring but due to lack of time, Unfortunatley remains, as visual vomit

//On further introspection, refactoring would be a massive improvement if implemented within the codes creation in a later project

//Refactoring was used halfway through the games creation due to my later understanding of its importance, however this file was not refactored in time for the final build

//Saying that, the file still works as intended and allows building of houses on both players propertys along with RPC calls over the network to notify the other player.

public class HousingP1 : MonoBehaviour
{
    public SetsandHousing House;
    public MoneySystem Money;
    public AudioManager Audio;
    public SpawnPlayer ID;

    public GameObject UPGRADE;
    public GameObject HouseSite1;
    public GameObject HouseSite2;
    public GameObject HouseSite3;
    public GameObject HouseSite4;
    public GameObject HouseSite5;
    public GameObject HouseSite6;
    public GameObject HouseSite7;
    public GameObject HouseSite8;
    public GameObject HouseSite9;
    public GameObject HouseSite10;
    public GameObject HouseSite11;
    public GameObject HouseSite12;
    public GameObject HouseSite13;
    public GameObject HouseSite14;
    public GameObject HouseSite15;
    public GameObject HouseSite16;
    public GameObject HouseSite17;
    public GameObject HouseSite18;
    public GameObject HouseSite19;
    public GameObject HouseSite20;
    public GameObject HouseSite21;
    public GameObject HouseSite22;

    public GameObject House1;
    public GameObject House2;
    public GameObject House3;
    public GameObject House4;
    public GameObject House5;
    public GameObject House6;
    public GameObject House7;
    public GameObject House8;
    public GameObject House9;
    public GameObject House10;
    public GameObject House11;
    public GameObject House12;
    public GameObject House13;
    public GameObject House14;
    public GameObject House15;
    public GameObject House16;
    public GameObject House17;
    public GameObject House18;
    public GameObject House19;
    public GameObject House20;
    public GameObject House21;
    public GameObject House22;
    public GameObject House23;
    public GameObject House24;
    public GameObject House25;
    public GameObject House26;
    public GameObject House27;
    public GameObject House28;
    public GameObject House29;
    public GameObject House30;
    public GameObject House31;
    public GameObject House32;
    public GameObject House33;
    public GameObject House34;
    public GameObject House35;
    public GameObject House36;
    public GameObject House37;
    public GameObject House38;
    public GameObject House39;
    public GameObject House40;
    public GameObject House41;
    public GameObject House42;
    public GameObject House43;
    public GameObject House44;
    public GameObject House45;
    public GameObject House46;
    public GameObject House47;
    public GameObject House48;
    public GameObject House49;
    public GameObject House50;
    public GameObject House51;
    public GameObject House52;
    public GameObject House53;
    public GameObject House54;
    public GameObject House55;
    public GameObject House56;
    public GameObject House57;
    public GameObject House58;
    public GameObject House59;
    public GameObject House60;
    public GameObject House61;
    public GameObject House62;
    public GameObject House63;
    public GameObject House64;
    public GameObject House65;
    public GameObject House66;
    public GameObject House67;
    public GameObject House68;
    public GameObject House69;
    public GameObject House70;
    public GameObject House71;
    public GameObject House72;
    public GameObject House73;
    public GameObject House74;
    public GameObject House75;
    public GameObject House76;
    public GameObject House77;
    public GameObject House78;
    public GameObject House79;
    public GameObject House80;
    public GameObject House81;
    public GameObject House82;
    public GameObject House83;
    public GameObject House84;
    public GameObject House85;
    public GameObject House86;
    public GameObject House87;
    public GameObject House88;

    public bool Site1House1;
    public bool Site1House2;
    public bool Site1House3;
    public bool Site1House4;
    public bool Site2House1;
    public bool Site2House2;
    public bool Site2House3;
    public bool Site2House4;
    public bool Site3House1;
    public bool Site3House2;
    public bool Site3House3;
    public bool Site3House4;
    public bool Site4House1;
    public bool Site4House2;
    public bool Site4House3;
    public bool Site4House4;
    public bool Site5House1;
    public bool Site5House2;
    public bool Site5House3;
    public bool Site5House4;
    public bool Site6House1;
    public bool Site6House2;
    public bool Site6House3;
    public bool Site6House4;
    public bool Site7House1;
    public bool Site7House2;
    public bool Site7House3;
    public bool Site7House4;
    public bool Site8House1;
    public bool Site8House2;
    public bool Site8House3;
    public bool Site8House4;
    public bool Site9House1;
    public bool Site9House2;
    public bool Site9House3;
    public bool Site9House4;
    public bool Site10House1;
    public bool Site10House2;
    public bool Site10House3;
    public bool Site10House4;
    public bool Site11House1;
    public bool Site11House2;
    public bool Site11House3;
    public bool Site11House4;
    public bool Site12House1;
    public bool Site12House2;
    public bool Site12House3;
    public bool Site12House4;
    public bool Site13House1;
    public bool Site13House2;
    public bool Site13House3;
    public bool Site13House4;
    public bool Site14House1;
    public bool Site14House2;
    public bool Site14House3;
    public bool Site14House4;
    public bool Site15House1;
    public bool Site15House2;
    public bool Site15House3;
    public bool Site15House4;
    public bool Site16House1;
    public bool Site16House2;
    public bool Site16House3;
    public bool Site16House4;
    public bool Site17House1;
    public bool Site17House2;
    public bool Site17House3;
    public bool Site17House4;
    public bool Site18House1;
    public bool Site18House2;
    public bool Site18House3;
    public bool Site18House4;
    public bool Site19House1;
    public bool Site19House2;
    public bool Site19House3;
    public bool Site19House4;
    public bool Site20House1;
    public bool Site20House2;
    public bool Site20House3;
    public bool Site20House4;
    public bool Site21House1;
    public bool Site21House2;
    public bool Site21House3;
    public bool Site21House4;
    public bool Site22House1;
    public bool Site22House2;
    public bool Site22House3;
    public bool Site22House4;

    public int Count1;
    public int Count2;
    public int Count3;
    public int Count4;
    public int Count5;
    public int Count6;
    public int Count7;
    public int Count8;
    public int Count9;
    public int Count10;
    public int Count11;
    public int Count12;
    public int Count13;
    public int Count14;
    public int Count15;
    public int Count16;
    public int Count17;
    public int Count18;
    public int Count19;
    public int Count20;
    public int Count21;
    public int Count22;

    public int SwitchUpgrade = 0;


    void Start()
    {
        House = FindObjectOfType<SetsandHousing>();
        Money = FindObjectOfType<MoneySystem>();
        ID = FindObjectOfType<SpawnPlayer>();
        Audio = FindObjectOfType<AudioManager>();

        Count1 = 0;
        Count2 = 0;
        Count3 = 0;
        Count4 = 0;
        Count5 = 0;
        Count6 = 0;
        Count7 = 0;
        Count8 = 0;
        Count9 = 0;
        Count10 = 0;
        Count11 = 0;
        Count12 = 0;
        Count13 = 0;
        Count14 = 0;
        Count15 = 0;
        Count16 = 0;
        Count17 = 0;
        Count18 = 0;
        Count19 = 0;
        Count20 = 0;
        Count21 = 0;
        Count22 = 0;

        Site1House1 = false;
        Site1House2 = false;
        Site1House3 = false;
        Site1House4 = false;
        Site2House1 = false;
        Site2House2 = false;
        Site2House3 = false;
        Site2House4 = false;
        Site3House1 = false;
        Site3House2 = false;
        Site3House3 = false;
        Site3House4 = false;
        Site4House1 = false;
        Site4House2 = false;
        Site4House3 = false;
        Site4House4 = false;
        Site5House1 = false;
        Site5House2 = false;
        Site5House3 = false;
        Site5House4 = false;
        Site6House1 = false;
        Site6House2 = false;
        Site6House3 = false;
        Site6House4 = false;
        Site7House1 = false;
        Site7House2 = false;
        Site7House3 = false;
        Site7House4 = false;
        Site8House1 = false;
        Site8House2 = false;
        Site8House3 = false;
        Site8House4 = false;
        Site9House1 = false;
        Site9House2 = false;
        Site9House3 = false;
        Site9House4 = false;
        Site10House1 = false;
        Site10House2 = false;
        Site10House3 = false;
        Site10House4 = false;
        Site11House1 = false;
        Site11House2 = false;
        Site11House3 = false;
        Site11House4 = false;
        Site12House1 = false;
        Site12House2 = false;
        Site12House3 = false;
        Site12House4 = false;
        Site13House1 = false;
        Site13House2 = false;
        Site13House3 = false;
        Site13House4 = false;
        Site14House1 = false;
        Site14House2 = false;
        Site14House3 = false;
        Site14House4 = false;
        Site15House1 = false;
        Site15House2 = false;
        Site15House3 = false;
        Site15House4 = false;
        Site16House1 = false;
        Site16House2 = false;
        Site16House3 = false;
        Site16House4 = false;
        Site17House1 = false;
        Site17House2 = false;
        Site17House3 = false;
        Site17House4 = false;
        Site18House1 = false;
        Site18House2 = false;
        Site18House3 = false;
        Site18House4 = false;
        Site19House1 = false;
        Site19House2 = false;
        Site19House3 = false;
        Site19House4 = false;
        Site20House1 = false;
        Site20House2 = false;
        Site20House3 = false;
        Site20House4 = false;
        Site21House1 = false;
        Site21House2 = false;
        Site21House3 = false;
        Site21House4 = false;
        Site22House1 = false;
        Site22House2 = false;
        Site22House3 = false;
        Site22House4 = false;
        
        HouseSite1.SetActive(false);
        HouseSite2.SetActive(false);
        HouseSite3.SetActive(false);
        HouseSite4.SetActive(false);
        HouseSite5.SetActive(false);
        HouseSite6.SetActive(false);
        HouseSite7.SetActive(false);
        HouseSite8.SetActive(false);
        HouseSite9.SetActive(false);
        HouseSite10.SetActive(false);
        HouseSite11.SetActive(false);
        HouseSite12.SetActive(false);
        HouseSite13.SetActive(false);
        HouseSite14.SetActive(false);
        HouseSite15.SetActive(false);
        HouseSite16.SetActive(false);
        HouseSite17.SetActive(false);
        HouseSite18.SetActive(false);
        HouseSite19.SetActive(false);
        HouseSite20.SetActive(false);
        HouseSite21.SetActive(false);
        HouseSite22.SetActive(false);

        

        House1.SetActive(false);
        House2.SetActive(false);
        House3.SetActive(false);
        House4.SetActive(false);
        House5.SetActive(false);
        House6.SetActive(false);
        House7.SetActive(false);
        House8.SetActive(false);
        House9.SetActive(false);
        House10.SetActive(false);
        House11.SetActive(false);
        House12.SetActive(false);
        House13.SetActive(false);
        House14.SetActive(false);
        House15.SetActive(false);
        House16.SetActive(false);
        House17.SetActive(false);
        House18.SetActive(false);
        House19.SetActive(false);
        House20.SetActive(false);

        House20.SetActive(false);
        House21.SetActive(false);
        House22.SetActive(false);
        House23.SetActive(false);
        House24.SetActive(false);
        House25.SetActive(false);
        House26.SetActive(false);
        House27.SetActive(false);
        House28.SetActive(false);
        House29.SetActive(false);
        House30.SetActive(false);
        House31.SetActive(false);
        House32.SetActive(false);
        House33.SetActive(false);
        House34.SetActive(false);
        House35.SetActive(false);
        House36.SetActive(false);
        House37.SetActive(false);
        House38.SetActive(false);
        House39.SetActive(false);
        House40.SetActive(false);

        House41.SetActive(false);
        House42.SetActive(false);
        House43.SetActive(false);
        House44.SetActive(false);
        House45.SetActive(false);
        House46.SetActive(false);
        House47.SetActive(false);
        House48.SetActive(false);
        House49.SetActive(false);
        House50.SetActive(false);
        House51.SetActive(false);
        House52.SetActive(false);
        House53.SetActive(false);
        House54.SetActive(false);
        House55.SetActive(false);
        House56.SetActive(false);
        House57.SetActive(false);
        House58.SetActive(false);
        House59.SetActive(false);
        House60.SetActive(false);

        House61.SetActive(false);
        House62.SetActive(false);
        House63.SetActive(false);
        House64.SetActive(false);
        House64.SetActive(false);
        House65.SetActive(false);
        House66.SetActive(false);
        House67.SetActive(false);
        House68.SetActive(false);
        House69.SetActive(false);
        House70.SetActive(false);
        House71.SetActive(false);
        House72.SetActive(false);
        House73.SetActive(false);
        House74.SetActive(false);
        House75.SetActive(false);
        House76.SetActive(false);
        House77.SetActive(false);
        House78.SetActive(false);
        House79.SetActive(false);
        House80.SetActive(false);

        House81.SetActive(false);
        House82.SetActive(false);
        House82.SetActive(false);
        House83.SetActive(false);
        House84.SetActive(false);
        House85.SetActive(false);
        House86.SetActive(false);
        House87.SetActive(false);
        House88.SetActive(false);


    }

    void Update()
    {
        if(ID.ConstantID == 0)
        {
            UPGRADE.SetActive(true);
        }
        if(ID.ConstantID == 1)
        {
            UPGRADE.SetActive(false);
        }
    }
   
    public void UpgradeProperty()
    {

    if(SwitchUpgrade == 0)
    {
        Audio.Play("Press");
        if(House.P1OwnSet1 == true)
        {
            HouseSite1.SetActive(true);
            HouseSite2.SetActive(true);
        }
        if(House.P1OwnSet2 == true)
        {
            HouseSite3.SetActive(true);
            HouseSite4.SetActive(true);
            HouseSite5.SetActive(true);
        }
        if(House.P1OwnSet3 == true)
        {
            HouseSite6.SetActive(true);
            HouseSite7.SetActive(true);
            HouseSite8.SetActive(true);
        }
        if(House.P1OwnSet4 == true)
        {
            HouseSite9.SetActive(true);
            HouseSite10.SetActive(true);
            HouseSite11.SetActive(true);
        }
        if(House.P1OwnSet5 == true)
        {
            HouseSite12.SetActive(true);
            HouseSite13.SetActive(true);
            HouseSite14.SetActive(true);
        }
        if(House.P1OwnSet6 == true)
        {
            HouseSite15.SetActive(true);
            HouseSite16.SetActive(true);
            HouseSite17.SetActive(true);
        }
        if(House.P1OwnSet7 == true)
        {
            HouseSite18.SetActive(true);
            HouseSite19.SetActive(true);
            HouseSite20.SetActive(true);
        }
        if(House.P1OwnSet8 == true)
        {
            HouseSite21.SetActive(true);
            HouseSite22.SetActive(true);
        }

    }

    if(SwitchUpgrade == 1)
    {
        Audio.Play("Close");
            if(House.P1OwnSet1 == true)
        {
            HouseSite1.SetActive(false);
            HouseSite2.SetActive(false);
        }
        if(House.P1OwnSet2 == true)
        {
            HouseSite3.SetActive(false);
            HouseSite4.SetActive(false);
            HouseSite5.SetActive(false);
        }
        if(House.P1OwnSet3 == true)
        {
            HouseSite6.SetActive(false);
            HouseSite7.SetActive(false);
            HouseSite8.SetActive(false);
        }
        if(House.P1OwnSet4 == true)
        {
            HouseSite9.SetActive(false);
            HouseSite10.SetActive(false);
            HouseSite11.SetActive(false);
        }
        if(House.P1OwnSet5 == true)
        {
            HouseSite12.SetActive(false);
            HouseSite13.SetActive(false);
            HouseSite14.SetActive(false);
        }
        if(House.P1OwnSet6 == true)
        {
            HouseSite15.SetActive(false);
            HouseSite16.SetActive(false);
            HouseSite17.SetActive(false);
        }
        if(House.P1OwnSet7 == true)
        {
            HouseSite18.SetActive(false);
            HouseSite19.SetActive(false);
            HouseSite20.SetActive(false);
        }
        if(House.P1OwnSet8 == true)
        {
            HouseSite21.SetActive(false);
            HouseSite22.SetActive(false);
        }
    }
    SwitchUpgrade++;
    SwitchUpgrade %= 2;

}

    public void Site1()
    {   
        Audio.Play("Money");
        if(Count1 == 0 && Money.moneyPlay1 > 50)
        {
            ActiveSite1();
            RPC1();
            return;
        }
        if(Count1 == 1 && Money.moneyPlay1 > 50)
        {
            ActiveSite1();
            RPC1();
            return;
        }
        if(Count1 == 2 && Money.moneyPlay1 > 50)
        {
            ActiveSite1();
            RPC1();
            return;
        }
        if(Count1 == 3 && Money.moneyPlay1 > 50)
        {
            ActiveSite1();
            RPC1();
            return;
        }
    }

    public void Site2()
    {
        Audio.Play("Money");
        if(Count2 == 0 && Money.moneyPlay1 > 50)
        {
            ActiveSite2();
            RPC2();
            return;
        }
        if(Count2 == 1 && Money.moneyPlay1 > 50)
        {
            ActiveSite2();
            RPC2();
            return;
        }
        if(Count2 == 2 && Money.moneyPlay1 > 50)
        {
            ActiveSite2();
            RPC2();
            return;
        }
        if(Count2 == 3 && Money.moneyPlay1 > 50)
        {
            ActiveSite2();
            RPC2();
            return;
        }
    }

    public void Site3()
    {
        Audio.Play("Money");
        if(Count3 == 0 && Money.moneyPlay1 > 50)
        {
            ActiveSite3();
            RPC3();
            return;
        }
        if(Count3 == 1 && Money.moneyPlay1 > 50)
        {
            ActiveSite3();
            RPC3();
            return;
        }
        if(Count3 == 2 && Money.moneyPlay1 > 50)
        {
            ActiveSite3();
            RPC3();
            return;
        }
        if(Count3 == 3 && Money.moneyPlay1 > 50)
        {
            ActiveSite3();
            RPC3();
            return;
        }
    }

    public void Site4()
    {
        Audio.Play("Money");
        if(Count4 == 0 && Money.moneyPlay1 > 50)
        {
            ActiveSite4();
            RPC4();
            return;
        }
        if(Count4 == 1 && Money.moneyPlay1 > 50)
        {
            ActiveSite4();
            RPC4();
            return;
        }
        if(Count4 == 2 && Money.moneyPlay1 > 50)
        {
            ActiveSite4();
            RPC4();
            return;
        }
        if(Count4 == 3 && Money.moneyPlay1 > 50)
        {
            ActiveSite4();
            RPC4();
            return;
        }
    }

    public void Site5()
    {
        Audio.Play("Money");
        if(Count5 == 0 && Money.moneyPlay1 > 50)
        {
            ActiveSite5();
            RPC5();
            return;
        }
        if(Count5 == 1 && Money.moneyPlay1 > 50)
        {
            ActiveSite5();
            RPC5();
            return;
        }
        if(Count5 == 2 && Money.moneyPlay1 > 50)
        {
            ActiveSite5();
            RPC5();
            return;
        }
        if(Count5 == 3 && Money.moneyPlay1 > 50)
        {
            ActiveSite5();
            RPC5();
            return;
        }
    }

    public void Site6()
    {
        Audio.Play("Money");
        if(Count6 == 0 && Money.moneyPlay1 > 50)
        {
            ActiveSite6();
            RPC6();
            return;
        }
        if(Count6 == 1 && Money.moneyPlay1 > 50)
        {
            ActiveSite6();
            RPC6();
            return;
        }
        if(Count6 == 2 && Money.moneyPlay1 > 50)
        {
            ActiveSite6();
            RPC6();
            return;
        }
        if(Count6 == 3 && Money.moneyPlay1 > 50)
        {
            ActiveSite6();
            RPC6();
            return;
        }
    }

    public void Site7()
    {
        Audio.Play("Money");
        if(Count7 == 0 && Money.moneyPlay1 > 50)
        {
            ActiveSite7();
            RPC7();
            return;
        }
        if(Count7 == 1 && Money.moneyPlay1 > 50)
        {
            ActiveSite7();
            RPC7();
            return;
        }
        if(Count7 == 2 && Money.moneyPlay1 > 50)
        {
            ActiveSite7();
            RPC7();
            return;
        }
        if(Count7 == 3 && Money.moneyPlay1 > 50)
        {
            ActiveSite7();
            RPC7();
            return;
        }
    }

    public void Site8()
    {   
        Audio.Play("Money");
        if(Count8 == 0 && Money.moneyPlay1 > 50)
        {
            ActiveSite8();
            RPC8();
            return;
        }
        if(Count8 == 1 && Money.moneyPlay1 > 50)
        {
            ActiveSite8();
            RPC8();
            return;
        }
        if(Count8 == 2 && Money.moneyPlay1 > 50)
        {
            ActiveSite8();
            RPC8();

            return;
        }
        if(Count8 == 3 && Money.moneyPlay1 > 50)
        {
            ActiveSite8();
            RPC8();
            return;
        }
    }

    public void Site9()
    {
        Audio.Play("Money");
        if(Count9 == 0 && Money.moneyPlay1 > 50)
        {
            ActiveSite9();
            RPC9();
            return;
        }
        if(Count9 == 1 && Money.moneyPlay1 > 50)
        {
            ActiveSite9();
            RPC9();
            return;
        }
        if(Count9 == 2 && Money.moneyPlay1 > 50)
        {
            ActiveSite9();
            RPC9();
            return;
        }
        if(Count9 == 3 && Money.moneyPlay1 > 50)
        {
            ActiveSite9();
            RPC9();
            return;
        }
    }

    public void Site10()
    {
        Audio.Play("Money");
        if(Count10 == 0 && Money.moneyPlay1 > 50)
        {
            ActiveSite10();
            RPC10();
            return;
        }
        if(Count10 == 1 && Money.moneyPlay1 > 50)
        {
            ActiveSite10();
            RPC10();
            return;
        }
        if(Count10 == 2 && Money.moneyPlay1 > 50)
        {
            ActiveSite10();
            RPC10();
            return;
        }
        if(Count10 == 3 && Money.moneyPlay1 > 50)
        {
            ActiveSite10();
            RPC10();
            return;
        }
    }

        public void Site11()
    {
        Audio.Play("Money");
        if(Count11 == 0 && Money.moneyPlay1 > 50)
        {
            ActiveSite11();
            RPC11();
            return;
        }
        if(Count11 == 1 && Money.moneyPlay1 > 50)
        {
            ActiveSite11();
            RPC11();
            return;
        }
        if(Count11 == 2 && Money.moneyPlay1 > 50)
        {
            ActiveSite11();
            RPC11();
            return;
        }
        if(Count11 == 3 && Money.moneyPlay1 > 50)
        {
            ActiveSite11();
            RPC11();
            return;
        }
    }

        public void Site12()
    {
        Audio.Play("Money");
        if(Count12 == 0 && Money.moneyPlay1 > 50)
        {
            ActiveSite12();
            RPC12();
            return;
        }
        if(Count12 == 1 && Money.moneyPlay1 > 50)
        {
            ActiveSite12();
            RPC12();
            return;
        }
        if(Count12 == 2 && Money.moneyPlay1 > 50)
        {
            ActiveSite12();
            RPC12();
            return;
        }
        if(Count12 == 3 && Money.moneyPlay1 > 50)
        {
            ActiveSite12();
            RPC12();
            return;
        }
    }

        public void Site13()
    {
        Audio.Play("Money");
        if(Count13 == 0 && Money.moneyPlay1 > 50)
        {
            ActiveSite13();
            RPC13();
            return;
        }
        if(Count13 == 1 && Money.moneyPlay1 > 50)
        {
            ActiveSite13();
            RPC13();
            return;
        }
        if(Count13 == 2 && Money.moneyPlay1 > 50)
        {
            ActiveSite13();
            RPC13();
            return;
        }
        if(Count13 == 3 && Money.moneyPlay1 > 50)
        {
            ActiveSite13();
            RPC13();
            return;
        }
    }
        
        public void Site14()
    {
        Audio.Play("Money");
        if(Count14 == 0 && Money.moneyPlay1 > 50)
        {
            ActiveSite14();
            RPC14();
            return;
        }
        if(Count14 == 1 && Money.moneyPlay1 > 50)
        {
            ActiveSite14();
            RPC14();
            return;
        }
        if(Count14 == 2 && Money.moneyPlay1 > 50)
        {
            ActiveSite14();
            RPC14();
            return;
        }
        if(Count14 == 3 && Money.moneyPlay1 > 50)
        {
            ActiveSite14();
            RPC14();
            return;
        }

    }

        public void Site15()
    {
        Audio.Play("Money");
        if(Count15 == 0 && Money.moneyPlay1 > 50)
        {
            ActiveSite15();
            RPC15();
            return;
        }
        if(Count15 == 1 && Money.moneyPlay1 > 50)
        {
            ActiveSite15();
            RPC15();
            return;
        }
        if(Count15 == 2 && Money.moneyPlay1 > 50)
        {
            ActiveSite15();
            RPC15();
            return;
        }
        if(Count15 == 3 && Money.moneyPlay1 > 50)
        {
            ActiveSite15();
            RPC15();
            return;
        }

    }

        public void Site16()
    {
        Audio.Play("Money");
        if(Count16 == 0 && Money.moneyPlay1 > 50)
        {
            ActiveSite16();
            RPC16();
            return;
        }
        if(Count16 == 1 && Money.moneyPlay1 > 50)
        {
            ActiveSite16();
            RPC16();
            return;
        }
        if(Count16 == 2 && Money.moneyPlay1 > 50)
        {
            ActiveSite16();
            RPC16();
            return;
        }
        if(Count16 == 3 && Money.moneyPlay1 > 50)
        {
            ActiveSite16();
            RPC16();
            return;
        }

    }

        public void Site17()
    {
        Audio.Play("Money");
        if(Count17 == 0 && Money.moneyPlay1 > 50)
        {
            ActiveSite17();
            RPC17();
            return;
        }
        if(Count17 == 1 && Money.moneyPlay1 > 50)
        {
            ActiveSite17();
            RPC17();
            return;
        }
        if(Count17 == 2 && Money.moneyPlay1 > 50)
        {
            ActiveSite17();
            RPC17();
            return;
        }
        if(Count17 == 3 && Money.moneyPlay1 > 50)
        {
            ActiveSite17();
            RPC17();
            return;
        }

    }

        public void Site18()
    {   
        Audio.Play("Money");
        if(Count18 == 0 && Money.moneyPlay1 > 50)
        {
            ActiveSite18();
            RPC18();
            return;
        }
        if(Count18 == 1 && Money.moneyPlay1 > 50)
        {
            ActiveSite18();
            RPC18();
            return;
        }
        if(Count18 == 2 && Money.moneyPlay1 > 50)
        {
            ActiveSite18();
            RPC18();
            return;
        }
        if(Count18 == 3 && Money.moneyPlay1 > 50)
        {
            ActiveSite18();
            RPC18();
            return;
        }
    }

    public void Site19()
    {
        Audio.Play("Money");
        if(Count19 == 0 && Money.moneyPlay1 > 50)
        {
            ActiveSite19();
            RPC19();
            return;
        }
        if(Count19 == 1 && Money.moneyPlay1 > 50)
        {
            ActiveSite19();
            RPC19();
            return;
        }
        if(Count19 == 2 && Money.moneyPlay1 > 50)
        {
            ActiveSite19();
            RPC19();
            return;
        }
        if(Count19 == 3 && Money.moneyPlay1 > 50)
        {
            ActiveSite19();
            RPC19();
            return;
        }
    }

    public void Site20()
    {
        Audio.Play("Money");
        if(Count20 == 0 && Money.moneyPlay1 > 50)
        {
            ActiveSite20();
            RPC20();
            return;
        }
        if(Count20 == 1 && Money.moneyPlay1 > 50)
        {
            ActiveSite20();
            RPC20();
            return;
        }
        if(Count20 == 2 && Money.moneyPlay1 > 50)
        {
            ActiveSite20();
            RPC20();
            return;
        }
        if(Count20 == 3 && Money.moneyPlay1 > 50)
        {
            ActiveSite20();
            RPC20();
            return;
        }
    }

    public void Site21()
    {   
        Audio.Play("Money");
        if(Count21 == 0 && Money.moneyPlay1 > 50)
        {
            ActiveSite21();
            RPC21();
            return;
        }
        if(Count21 == 1 && Money.moneyPlay1 > 50)
        {
            ActiveSite21();
            RPC21();
            return;
        }
        if(Count21 == 2 && Money.moneyPlay1 > 50)
        {
            ActiveSite21();
            RPC21();
            return;
        }
        if(Count21 == 3 && Money.moneyPlay1 > 50)
        {
            ActiveSite21();
            RPC21();
            return;
        }
    }

    public void Site22()
    {
        Audio.Play("Money");
        if(Count22 == 0 && Money.moneyPlay1 > 50)
        {
            ActiveSite22();
            RPC22();
            return;
        }
        if(Count22 == 1 && Money.moneyPlay1 > 50)
        {
            ActiveSite22();
            RPC22();
            return;
        }
        if(Count22 == 2 && Money.moneyPlay1 > 50)
        {
            ActiveSite22();
            RPC22();
            return;
        }
        if(Count22 == 3 && Money.moneyPlay1 > 50)
        {
            ActiveSite22();
            RPC22();
            return;
        }
    }

    

    [PunRPC]
    public void ActiveSite1()
    {
        if(Count1 == 0)
        {
            House1.SetActive(true);
            TRADERPCP1.instance.NoTrade(1);
            Site1House1 = true;
            Money.moneyPlay1 -= 50;
            Count1 = 1;
            return;

        }
        if(Count1 == 1)
        {
            House2.SetActive(true);

            Site1House2 = true;
            Site1House1 = false;
            Money.moneyPlay1 -= 50;
            Count1 = 2;
            return;

        }
        if(Count1 == 2)
        {
            House3.SetActive(true);

            Site1House3 = true;
            Site1House2 = false;
            Money.moneyPlay1 -= 50;
            Count1 = 3;
            return;

        }
        if(Count1 == 3)
        {
            House4.SetActive(true);

            Site1House4 = true;
            Site1House3 = false;
            Money.moneyPlay1 -= 50;

            HouseSite1.SetActive(false);
            Count1 = 4;
            return;
        }
    }

    [PunRPC]
    public void ActiveSite2()
    {
        if(Count2 == 0)
        {
            House5.SetActive(true);
            TRADERPCP1.instance.NoTrade(2);
            Site2House1 = true;
            Money.moneyPlay1 -= 50;
            Count2 = 1;
            return;

        }
        if(Count2 == 1)
        {
            House6.SetActive(true);
            Site2House2 = true;
            Site2House1 = false;
            Money.moneyPlay1 -= 50;
            Count2 = 2;
            return;

        }
        if(Count2 == 2)
        {
            House7.SetActive(true);
            Site2House3 = true;
            Site2House2 = false;
            Money.moneyPlay1 -= 50;
            Count2 = 3;
            return;

        }
        if(Count2 == 3)
        {
            House8.SetActive(true);
            Site2House4 = true;
            Site2House3 = false;
            Money.moneyPlay1 -= 50;
            HouseSite2.SetActive(false);
            Count2 = 4;
            return;
        }
    }

    [PunRPC]
    public void ActiveSite3()
    {
        if(Count3 == 0)
        {
            House9.SetActive(true);
            TRADERPCP1.instance.NoTrade(3);
            Site3House1 = true;
            Money.moneyPlay1 -= 50;
            Count3 = 1;
            return;

        }
        if(Count3 == 1)
        {
            House10.SetActive(true);
            Site3House2 = true;
            Site3House1 = false;
            Money.moneyPlay1 -= 50;
            Count3 = 2;
            return;

        }
        if(Count3 == 2)
        {
            House11.SetActive(true);
            Site3House3 = true;
            Site3House2 = false;
            Money.moneyPlay1 -= 50;
            Count3 = 3;
            return;

        }
        if(Count3 == 3)
        {
            House12.SetActive(true);
            Site3House4 = true;
            Site3House3 = false;
            Money.moneyPlay1 -= 50;
            HouseSite3.SetActive(false);
            Count3 = 4;
            return;
        }
    }

    [PunRPC]
    public void ActiveSite4()
    {
        if(Count4 == 0)
        {
            House13.SetActive(true);
            TRADERPCP1.instance.NoTrade(4);
            Site4House1 = true;
            Money.moneyPlay1 -= 50;
            Count4 = 1;
            return;

        }
        if(Count4 == 1)
        {
            House14.SetActive(true);
            Site4House2 = true;
            Site4House1 = false;
            Money.moneyPlay1 -= 50;
            Count4 = 2;
            return;

        }
        if(Count4 == 2)
        {
            House15.SetActive(true);
            Site4House3 = true;
            Site4House2 = false;
            Money.moneyPlay1 -= 50;
            Count4 = 3;
            return;

        }
        if(Count4 == 3)
        {
            House16.SetActive(true);
            Site4House4 = true;
            Site4House3 = false;
            Money.moneyPlay1 -= 50;
            HouseSite4.SetActive(false);
            Count4 = 4;
            return;
        }
    }

    [PunRPC]
    public void ActiveSite5()
    {
        if(Count5 == 0)
        {
            House17.SetActive(true);
            TRADERPCP1.instance.NoTrade(5);
            Site5House1 = true;
            Money.moneyPlay1 -= 50;
            Count5 = 1;
            return;

        }
        if(Count5 == 1)
        {
            House18.SetActive(true);
            Site5House2 = true;
            Site5House1 = false;
            Money.moneyPlay1 -= 50;
            Count5 = 2;
            return;

        }
        if(Count5 == 2)
        {
            House19.SetActive(true);
            Site5House3 = true;
            Site5House2 = false;
            Money.moneyPlay1 -= 50;
            Count5 = 3;
            return;

        }
        if(Count5 == 3)
        {
            House20.SetActive(true);
            Site5House4 = true;
            Site5House3 = false;
            Money.moneyPlay1 -= 50;
            HouseSite5.SetActive(false);
            Count5 = 4;
            return;
        }
    }

    [PunRPC]
    public void ActiveSite6()
    {
        if(Count6 == 0)
        {
            House21.SetActive(true);
            TRADERPCP1.instance.NoTrade(6);
            Site6House1 = true;
            Money.moneyPlay1 -= 50;
            Count6 = 1;
            return;

        }
        if(Count6 == 1)
        {
            House22.SetActive(true);
            Site6House2 = true;
            Site6House1 = false;
            Money.moneyPlay1 -= 50;
            Count6 = 2;
            return;

        }
        if(Count6 == 2)
        {
            House23.SetActive(true);
            Site6House3 = true;
            Site6House2 = false;
            Money.moneyPlay1 -= 50;
            Count6 = 3;
            return;

        }
        if(Count6 == 3)
        {
            House24.SetActive(true);
            Site6House4 = true;
            Site6House3 = false;
            Money.moneyPlay1 -= 50;
            HouseSite6.SetActive(false);
            Count6 = 4;
            return;
        }
    }

    [PunRPC]
    public void ActiveSite7()
    {
        if(Count7 == 0)
        {
            House25.SetActive(true);
            TRADERPCP1.instance.NoTrade(7);
            Site7House1 = true;
            Money.moneyPlay1 -= 50;
            Count7 = 1;
            return;

        }
        if(Count7 == 1)
        {
            House26.SetActive(true);
            Site7House2 = true;
            Site7House1 = false;
            Money.moneyPlay1 -= 50;
            Count7 = 2;
            return;

        }
        if(Count7 == 2)
        {
            House27.SetActive(true);
            Site7House3 = true;
            Site7House2 = false;
            Money.moneyPlay1 -= 50;
            Count7 = 3;
            return;

        }
        if(Count7 == 3)
        {
            House28.SetActive(true);
            Site7House4 = true;
            Site7House3 = false;
            Money.moneyPlay1 -= 50;
            HouseSite7.SetActive(false);
            Count7 = 4;
            return;
        }
    }

    [PunRPC]
    public void ActiveSite8()
    {
        if(Count8 == 0)
        {
            House29.SetActive(true);
            TRADERPCP1.instance.NoTrade(8);
            Site8House1 = true;
            Money.moneyPlay1 -= 50;
            Count8 = 1;
            return;

        }
        if(Count8 == 1)
        {
            House30.SetActive(true);
            Site8House2 = true;
            Site8House1 = false;
            Money.moneyPlay1 -= 50;
            Count8 = 2;
            return;

        }
        if(Count8 == 2)
        {
            House31.SetActive(true);
            Site8House3 = true;
            Site8House2 = false;
            Money.moneyPlay1 -= 50;
            Count8 = 3;
            return;

        }
        if(Count8 == 3)
        {
            House32.SetActive(true);
            Site8House4 = true;
            Site8House3 = false;
            Money.moneyPlay1 -= 50;
            HouseSite8.SetActive(false);
            Count8 = 4;
            return;
        }
    }

    [PunRPC]
    public void ActiveSite9()
    {
        if(Count9 == 0)
        {
            House33.SetActive(true);
            TRADERPCP1.instance.NoTrade(9);
            Site9House1 = true;
            Money.moneyPlay1 -= 50;
            Count9 = 1;
            return;

        }
        if(Count9 == 1)
        {
            House34.SetActive(true);
            Site9House2 = true;
            Site9House1 = false;
            Money.moneyPlay1 -= 50;
            Count9 = 2;
            return;

        }
        if(Count9 == 2)
        {
            House35.SetActive(true);
            Site9House3 = true;
            Site9House2 = false;
            Money.moneyPlay1 -= 50;
            Count9 = 3;
            return;

        }
        if(Count9 == 3)
        {
            House36.SetActive(true);
            Site9House4 = true;
            Site9House3 = false;
            Money.moneyPlay1 -= 50;
            HouseSite9.SetActive(false);
            Count9 = 4;
            return;
        }
    }

    [PunRPC]
    public void ActiveSite10()
    {
        if(Count10 == 0)
        {
            House37.SetActive(true);
            TRADERPCP1.instance.NoTrade(10);
            Site10House1 = true;
            Money.moneyPlay1 -= 50;
            Count10 = 1;
            return;

        }
        if(Count10 == 1)
        {
            House38.SetActive(true);
            Site10House2 = true;
            Site10House1 = false;
            Money.moneyPlay1 -= 50;
            Count10 = 2;
            return;

        }
        if(Count10 == 2)
        {
            House39.SetActive(true);
            Site10House3 = true;
            Site10House2 = false;
            Money.moneyPlay1 -= 50;
            Count10 = 3;
            return;

        }
        if(Count10 == 3)
        {
            House40.SetActive(true);
            Site10House4 = true;
            Site10House3 = false;
            Money.moneyPlay1 -= 50;
            HouseSite10.SetActive(false);
            Count10 = 4;
            return;
        }
    }

    [PunRPC]
    public void ActiveSite11()
    {
        if(Count11 == 0)
        {
            House41.SetActive(true);
            TRADERPCP1.instance.NoTrade(11);
            Site11House1 = true;
            Money.moneyPlay1 -= 50;
            Count11 = 1;
            return;

        }
        if(Count11 == 1)
        {
            House42.SetActive(true);
            Site11House2 = true;
            Site11House1 = false;
            Money.moneyPlay1 -= 50;
            Count11 = 2;
            return;

        }
        if(Count11 == 2)
        {
            House43.SetActive(true);
            Site11House3 = true;
            Site11House2 = false;
            Money.moneyPlay1 -= 50;
            Count11 = 3;
            return;

        }
        if(Count11 == 3)
        {
            House44.SetActive(true);
            Site11House4 = true;
            Site11House3 = false;
            Money.moneyPlay1 -= 50;
            HouseSite11.SetActive(false);
            Count11 = 4;
            return;
        }
    }

    [PunRPC]
    public void ActiveSite12()
    {
        if(Count12 == 0)
        {
            House45.SetActive(true);
            TRADERPCP1.instance.NoTrade(12);
            Site12House1 = true;
            Money.moneyPlay1 -= 50;
            Count12 = 1;
            return;

        }
        if(Count12 == 1)
        {
            House46.SetActive(true);
            Site12House2 = true;
            Site12House1 = false;
            Money.moneyPlay1 -= 50;
            Count12 = 2;
            return;

        }
        if(Count12 == 2)
        {
            House47.SetActive(true);
            Site12House3 = true;
            Site12House2 = false;
            Money.moneyPlay1 -= 50;
            Count12 = 3;
            return;

        }
        if(Count12 == 3)
        {
            House48.SetActive(true);
            Site12House4 = true;
            Site12House3 = false;
            Money.moneyPlay1 -= 50;
            Count12 = 4;
            HouseSite12.SetActive(false);
            return;

        }
    }

    [PunRPC]
    public void ActiveSite13()
    {
        if(Count13 == 0)
        {
            House49.SetActive(true);
            TRADERPCP1.instance.NoTrade(13);
            Site13House1 = true;
            Money.moneyPlay1 -= 50;
            Count13 = 1;
            return;

        }
        if(Count13 == 1)
        {
            House50.SetActive(true);
            Site13House2 = true;
            Site13House1 = false;
            Money.moneyPlay1 -= 50;
            Count13 = 2;
            return;

        }
        if(Count13 == 2)
        {
            House51.SetActive(true);
            Site13House3 = true;
            Site13House2 = false;
            Money.moneyPlay1 -= 50;
            Count13 = 3;
            return;

        }
        if(Count13 == 3)
        {
            House52.SetActive(true);
            Site13House4 = true;
            Site13House3 = false;
            Money.moneyPlay1 -= 50;
            HouseSite13.SetActive(false);
            Count13 = 4;
            return;
        }
    }

    [PunRPC]
    public void ActiveSite14()
    {
        if(Count14 == 0)
        {
            House53.SetActive(true);
            TRADERPCP1.instance.NoTrade(14);
            Site14House1 = true;
            Money.moneyPlay1 -= 50;
            Count14 = 1;
            return;

        }
        if(Count14 == 1)
        {
            House54.SetActive(true);
            Site14House2 = true;
            Site14House1 = false;
            Money.moneyPlay1 -= 50;
            Count14 = 2;
            return;

        }
        if(Count14 == 2)
        {
            House55.SetActive(true);
            Site14House3 = true;
            Site14House2 = false;
            Money.moneyPlay1 -= 50;
            Count14 = 3;
            return;

        }
        if(Count14 == 3)
        {
            House56.SetActive(true);
            Site14House4 = true;
            Site14House3 = false;
            Money.moneyPlay1 -= 50;
            HouseSite14.SetActive(false);
            Count14 = 4;
            return;
        }
    }

    [PunRPC]
    public void ActiveSite15()
    {
        if(Count15 == 0)
        {
            House57.SetActive(true);
            TRADERPCP1.instance.NoTrade(15);
            Site15House1 = true;
            Money.moneyPlay1 -= 50;
            Count15 = 1;
            return;

        }
        if(Count15 == 1)
        {
            House58.SetActive(true);
            Site15House2 = true;
            Site15House1 = false;
            Money.moneyPlay1 -= 50;
            Count15 = 2;
            return;

        }
        if(Count15 == 2)
        {
            House59.SetActive(true);
            Site15House3 = true;
            Site15House2 = false;
            Money.moneyPlay1 -= 50;
            Count15 = 3;
            return;

        }
        if(Count15 == 3)
        {
            House60.SetActive(true);
            Site15House4 = true;
            Site15House3 = false;
            Money.moneyPlay1 -= 50;
            HouseSite15.SetActive(false);
            Count15 = 4;
            return;
        }
    }

    [PunRPC]
    public void ActiveSite16()
    {
        if(Count16 == 0)
        {
            House61.SetActive(true);
            TRADERPCP1.instance.NoTrade(16);
            Site16House1 = true;
            Money.moneyPlay1 -= 50;
            Count16 = 1;
            return;

        }
        if(Count16 == 1)
        {
            House62.SetActive(true);
            Site16House2 = true;
            Site16House1 = false;
            Money.moneyPlay1 -= 50;
            Count16 = 2;
            return;

        }
        if(Count16 == 2)
        {
            House63.SetActive(true);
            Site16House3 = true;
            Site16House2 = false;
            Money.moneyPlay1 -= 50;
            Count16 = 3;
            return;

        }
        if(Count16 == 3)
        {
            House64.SetActive(true);
            Site16House4 = true;
            Site16House3 = false;
            Money.moneyPlay1 -= 50;
            HouseSite16.SetActive(false);
            Count16 = 4;
            return;
        }
    }

    [PunRPC]
    public void ActiveSite17()
    {
        if(Count17 == 0)
        {
            House65.SetActive(true);
            TRADERPCP1.instance.NoTrade(17);
            Site17House1 = true;
            Money.moneyPlay1 -= 50;
            Count17 = 1;
            return;

        }
        if(Count17 == 1)
        {
            House66.SetActive(true);
            Site17House2 = true;
            Site17House1 = false;
            Money.moneyPlay1 -= 50;
            Count17 = 2;
            return;

        }
        if(Count17 == 2)
        {
            House67.SetActive(true);
            Site17House3 = true;
            Site17House2 = false;
            Money.moneyPlay1 -= 50;
            Count17 = 3;
            return;

        }
        if(Count17 == 3)
        {
            House68.SetActive(true);
            Site17House4 = true;
            Site17House3 = false;
            Money.moneyPlay1 -= 50;
            HouseSite17.SetActive(false);
            Count17 = 4;
            return;
        }
    }

    [PunRPC]
    public void ActiveSite18()
    {
        if(Count18 == 0)
        {
            House69.SetActive(true);
            TRADERPCP1.instance.NoTrade(18);
            Site18House1 = true;
            Money.moneyPlay1 -= 50;
            Count18 = 1;
            return;

        }
        if(Count18 == 1)
        {
            House70.SetActive(true);
            Site18House2 = true;
            Site18House1 = false;
            Money.moneyPlay1 -= 50;
            Count18 = 2;
            return;

        }
        if(Count18 == 2)
        {
            House71.SetActive(true);
            Site18House3 = true;
            Site18House2 = false;
            Money.moneyPlay1 -= 50;
            Count18 = 3;
            return;

        }
        if(Count18 == 3)
        {
            House72.SetActive(true);
            Site18House4 = true;
            Site18House3 = false;
            Money.moneyPlay1 -= 50;
            HouseSite18.SetActive(false);
            Count18 = 4;
            return;
        }
    }

    [PunRPC]
    public void ActiveSite19()
    {
        if(Count19 == 0)
        {
            House73.SetActive(true);
            TRADERPCP1.instance.NoTrade(19);
            Site19House1 = true;
            Money.moneyPlay1 -= 50;
            Count19 = 1;
            return;

        }
        if(Count19 == 1)
        {
            House74.SetActive(true);
            Site19House2 = true;
            Site19House1 = false;
            Money.moneyPlay1 -= 50;
            Count19 = 2;
            return;

        }
        if(Count19 == 2)
        {
            House75.SetActive(true);
            Site19House3 = true;
            Site19House2 = false;
            Money.moneyPlay1 -= 50;
            Count19 = 3;
            return;

        }
        if(Count19 == 3)
        {
            House76.SetActive(true);
            Site19House4 = true;
            Site19House3 = false;
            Money.moneyPlay1 -= 50;
            HouseSite19.SetActive(false);
            Count19 = 4;
            return;
        }
    }

    [PunRPC]
    public void ActiveSite20()
    {
        if(Count20 == 0)
        {
            House77.SetActive(true);
            TRADERPCP1.instance.NoTrade(20);
            Site20House1 = true;
            Money.moneyPlay1 -= 50;
            Count20 = 1;
            return;

        }
        if(Count20 == 1)
        {
            House78.SetActive(true);
            Site20House2 = true;
            Site20House1 = false;
            Money.moneyPlay1 -= 50;
            Count20 = 2;
            return;

        }
        if(Count20 == 2)
        {
            House79.SetActive(true);
            Site20House3 = true;
            Site20House2 = false;
            Money.moneyPlay1 -= 50;
            Count20 = 3;
            return;

        }
        if(Count20 == 3)
        {
            House80.SetActive(true);
            Site20House4 = true;
            Site20House3 = false;
            Money.moneyPlay1 -= 50;
            HouseSite20.SetActive(false);
            Count20 = 4;
            return;
        }
    }

    [PunRPC]
    public void ActiveSite21()
    {
        if(Count21 == 0)
        {
            House81.SetActive(true);
            TRADERPCP1.instance.NoTrade(21);
            Site21House1 = true;
            Money.moneyPlay1 -= 50;
            Count21 = 1;
            return;

        }
        if(Count21 == 1)
        {
            House82.SetActive(true);
            Site21House2 = true;
            Site21House1 = false;
            Money.moneyPlay1 -= 50;
            Count21 = 2;
            return;

        }
        if(Count21 == 2)
        {
            House83.SetActive(true);
            Site21House3 = true;
            Site21House2 = false;
            Money.moneyPlay1 -= 50;
            Count21 = 3;
            return;

        }
        if(Count21 == 3)
        {
            House84.SetActive(true);
            Site21House4 = true;
            Site21House3 = false;
            Money.moneyPlay1 -= 50;
            HouseSite21.SetActive(false);
            Count21 = 4;
            return;
        }
    }

    [PunRPC]
    public void ActiveSite22()
    {
        if(Count22 == 0)
        {
            House85.SetActive(true);
            TRADERPCP1.instance.NoTrade(22);
            Site22House1 = true;
            Money.moneyPlay1 -= 50;
            Count22 = 1;
            return;

        }
        if(Count22 == 1)
        {
            House86.SetActive(true);
            Site22House2 = true;
            Site22House1 = false;
            Money.moneyPlay1 -= 50;
            Count22 = 2;
            return;

        }
        if(Count22 == 2)
        {
            House87.SetActive(true);
            Site22House3 = true;
            Site22House2 = false;
            Money.moneyPlay1 -= 50;
            Count22 = 3;
            return;

        }
        if(Count22 == 3)
        {
            House88.SetActive(true);
            Site22House4 = true;
            Site22House3 = false;
            Money.moneyPlay1 -= 50;
            HouseSite22.SetActive(false);
            Count22 = 4;
            return;
        }
    }

    public void RPC1()
    {
        PhotonView UpdateHouse = GetComponent<PhotonView>();
        UpdateHouse.RPC("ActiveSite1", RpcTarget.Others);
    }

    public void RPC2()
    {
        PhotonView UpdateHouse = GetComponent<PhotonView>();
        UpdateHouse.RPC("ActiveSite2", RpcTarget.Others);
    }

    public void RPC3()
    {
        PhotonView UpdateHouse = GetComponent<PhotonView>();
        UpdateHouse.RPC("ActiveSite3", RpcTarget.Others);
    }

    public void RPC4()
    {
        PhotonView UpdateHouse = GetComponent<PhotonView>();
        UpdateHouse.RPC("ActiveSite4", RpcTarget.Others);
    }

    public void RPC5()
    {
        PhotonView UpdateHouse = GetComponent<PhotonView>();
        UpdateHouse.RPC("ActiveSite5", RpcTarget.Others);
    }

    public void RPC6()
    {
        PhotonView UpdateHouse = GetComponent<PhotonView>();
        UpdateHouse.RPC("ActiveSite6", RpcTarget.Others);
    }

    public void RPC7()
    {
        PhotonView UpdateHouse = GetComponent<PhotonView>();
        UpdateHouse.RPC("ActiveSite7", RpcTarget.Others);
    }

    public void RPC8()
    {
        PhotonView UpdateHouse = GetComponent<PhotonView>();
        UpdateHouse.RPC("ActiveSite8", RpcTarget.Others);
    }

    public void RPC9()
    {
        PhotonView UpdateHouse = GetComponent<PhotonView>();
        UpdateHouse.RPC("ActiveSite9", RpcTarget.Others);
    }

    public void RPC10()
    {
        PhotonView UpdateHouse = GetComponent<PhotonView>();
        UpdateHouse.RPC("ActiveSite10", RpcTarget.Others);
    }

    public void RPC11()
    {
        PhotonView UpdateHouse = GetComponent<PhotonView>();
        UpdateHouse.RPC("ActiveSite11", RpcTarget.Others);
    }

    public void RPC12()
    {
        PhotonView UpdateHouse = GetComponent<PhotonView>();
        UpdateHouse.RPC("ActiveSite12", RpcTarget.Others);
    }

    public void RPC13()
    {
        PhotonView UpdateHouse = GetComponent<PhotonView>();
        UpdateHouse.RPC("ActiveSite13", RpcTarget.Others);
    }

    public void RPC14()
    {
        PhotonView UpdateHouse = GetComponent<PhotonView>();
        UpdateHouse.RPC("ActiveSite14", RpcTarget.Others);
    }

    public void RPC15()
    {
        PhotonView UpdateHouse = GetComponent<PhotonView>();
        UpdateHouse.RPC("ActiveSite15", RpcTarget.Others);
    }

    public void RPC16()
    {
        PhotonView UpdateHouse = GetComponent<PhotonView>();
        UpdateHouse.RPC("ActiveSite16", RpcTarget.Others);
    }

    public void RPC17()
    {
        PhotonView UpdateHouse = GetComponent<PhotonView>();
        UpdateHouse.RPC("ActiveSite17", RpcTarget.Others);
    }

    public void RPC18()
    {
        PhotonView UpdateHouse = GetComponent<PhotonView>();
        UpdateHouse.RPC("ActiveSite18", RpcTarget.Others);
    }

    public void RPC19()
    {
        PhotonView UpdateHouse = GetComponent<PhotonView>();
        UpdateHouse.RPC("ActiveSite19", RpcTarget.Others);
    }

    public void RPC20()
    {
        PhotonView UpdateHouse = GetComponent<PhotonView>();
        UpdateHouse.RPC("ActiveSite20", RpcTarget.Others);
    }

    public void RPC21()
    {
        PhotonView UpdateHouse = GetComponent<PhotonView>();
        UpdateHouse.RPC("ActiveSite21", RpcTarget.Others);
    }

    public void RPC22()
    {
        PhotonView UpdateHouse = GetComponent<PhotonView>();
        UpdateHouse.RPC("ActiveSite22", RpcTarget.Others);
    }






}
