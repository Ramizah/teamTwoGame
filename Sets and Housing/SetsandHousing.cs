using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

// Created by Caleb

//Sets and housing checks whether the player has successfuly obtained a colour set. 

//It then calls House and MoneySystem to determine whether the set should be worth no houses or 1 - 4 houses.

//This value is sent to MoneySystem to then take and add to the players who land on it and own it respectivley.

public class SetsandHousing : MonoBehaviour
{
    public static SetsandHousing instance;
    public HousingP1 House;
    public HousingP2 House2;
    public MoneySystem Money;

    public bool P1OwnSet1;
    public bool P1OwnSet2;
    public bool P1OwnSet3;
    public bool P1OwnSet4;
    public bool P1OwnSet5;
    public bool P1OwnSet6;
    public bool P1OwnSet7;
    public bool P1OwnSet8;
    
    public bool P2OwnSet1;
    public bool P2OwnSet2;
    public bool P2OwnSet3;
    public bool P2OwnSet4;
    public bool P2OwnSet5;
    public bool P2OwnSet6;
    public bool P2OwnSet7;
    public bool P2OwnSet8;

    public int Build1Money1;

    public int Build1Money2;



    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        P1OwnSet1 = false;
        P1OwnSet2 = false;
        P1OwnSet3 = false;
        P1OwnSet4 = false;
        P1OwnSet5 = false;
        P1OwnSet6 = false;
        P1OwnSet7 = false;
        P1OwnSet8 = false;

        P2OwnSet1 = false;
        P2OwnSet2 = false;
        P2OwnSet3 = false;
        P2OwnSet4 = false;
        P2OwnSet5 = false;
        P2OwnSet6 = false;
        P2OwnSet7 = false;
        P2OwnSet8 = false;
        Build1Money1 = 0;
        Build1Money2 = 0;
        House = FindObjectOfType<HousingP1>();
        House2 = FindObjectOfType<HousingP2>();
        Money = FindObjectOfType<MoneySystem>();
    }

    // Start is called before the first frame update
    public void Update()
    {

        

        //------------------------------------------------P1--------------------------------------------//

        
        if(Money.isBrought1 == true && Money.isBrought2 == true && Money.P1IsMine1 == true && Money.P1IsMine2 == true)
        {
            P1OwnSet1 = true;
        }
        else
        {
           P1OwnSet1 = false; 
        }

        if(Money.isBrought4 == true && Money.isBrought5 == true && Money.isBrought6 == true && Money.P1IsMine4 == true && Money.P1IsMine5 == true && Money.P1IsMine6 == true)
        {
            P1OwnSet2 = true;
        }
        else
        {
           P1OwnSet2 = false; 
        }


        if(Money.isBrought7 == true && Money.isBrought9 == true && Money.isBrought10 == true && Money.P1IsMine7 == true && Money.P1IsMine9 == true && Money.P1IsMine10 == true)
        {
            P1OwnSet3 = true;
        }
        else
        {
           P1OwnSet3 = false; 
        }


        if(Money.isBrought12 == true && Money.isBrought13 == true && Money.isBrought14 == true && Money.P1IsMine12 == true && Money.P1IsMine13 == true && Money.P1IsMine14 == true)
        {
            P1OwnSet4 = true;
        }
        else
        {
           P1OwnSet4 = false; 
        }


        if(Money.isBrought15 == true && Money.isBrought16 == true && Money.isBrought17 == true && Money.P1IsMine15 == true && Money.P1IsMine16 == true && Money.P1IsMine17 == true)
        {
            P1OwnSet5 = true;
        }
        else
        {
           P1OwnSet5 = false; 
        }


        if(Money.isBrought19 == true && Money.isBrought20 == true && Money.isBrought22 == true && Money.P1IsMine19 == true && Money.P1IsMine20 == true && Money.P1IsMine22 == true)
        {
            P1OwnSet6 = true;
        }
        else
        {
           P1OwnSet6 = false; 
        }


        if(Money.isBrought23 == true && Money.isBrought24 == true && Money.isBrought25 == true && Money.P1IsMine23 == true && Money.P1IsMine24 == true && Money.P1IsMine25 == true)
        {
            P1OwnSet7 = true;
        }
        else
        {
           P1OwnSet7 = false; 
        }


        if(Money.isBrought27 == true && Money.isBrought28 == true && Money.P1IsMine27 == true && Money.P1IsMine28 == true)
        {
            P1OwnSet8 = true;
        }
        else
        {
           P1OwnSet8 = false; 
        }


    //------------------------------------------------------------------P2--------------------------------------------------------//

        if(Money.isBrought1 == true && Money.isBrought2 == true && Money.P2IsMine1 == true && Money.P2IsMine2 == true)
        {
            P2OwnSet1 = true;
        }
        else
        {
           P2OwnSet1 = false; 
        }


        if(Money.isBrought4 == true && Money.isBrought5 == true && Money.isBrought6 == true && Money.P2IsMine4 == true && Money.P2IsMine5 == true && Money.P2IsMine6 == true)
        {
            P2OwnSet2 = true;
        }
        else
        {
           P2OwnSet2 = false; 
        }


        if(Money.isBrought7 == true && Money.isBrought9 == true && Money.isBrought10 == true && Money.P2IsMine7 == true && Money.P2IsMine9 == true && Money.P2IsMine10 == true)
        {
            P2OwnSet3 = true;
        }
        else
        {
           P2OwnSet3 = false; 
        }


        if(Money.isBrought12 == true && Money.isBrought13 == true && Money.isBrought14 == true && Money.P2IsMine12 == true && Money.P2IsMine13 == true && Money.P2IsMine14 == true)
        {
            P2OwnSet4 = true;
        }
        else
        {
           P2OwnSet4 = false; 
        }


        if(Money.isBrought15 == true && Money.isBrought16 == true && Money.isBrought17 == true && Money.P2IsMine15 == true && Money.P2IsMine16 == true && Money.P2IsMine17 == true)
        {
            P2OwnSet5 = true;
        }
        else
        {
           P2OwnSet5 = false; 
        }


        if(Money.isBrought19 == true && Money.isBrought20 == true && Money.isBrought22 == true && Money.P2IsMine19 == true && Money.P2IsMine20 == true && Money.P2IsMine22 == true)
        {
            P2OwnSet6 = true;
        }
        else
        {
           P2OwnSet6 = false; 
        }


        if(Money.isBrought23 == true && Money.isBrought24 == true && Money.isBrought25 == true && Money.P2IsMine23 == true && Money.P2IsMine24 == true && Money.P2IsMine25 == true)
        {
            P2OwnSet7 = true;
        }
        else
        {
           P2OwnSet7 = false; 
        }


        if(Money.isBrought27 == true && Money.isBrought28 == true && Money.P2IsMine27 == true && Money.P2IsMine28 == true)
        {
            P2OwnSet8 = true;
        }
        else
        {
           P2OwnSet8 = false; 
        } 
    }  


    public void P1CheckProperty1()
    {
        if(P2OwnSet1 == true)
        {
            if(House2.Site1House1 == false && House2.Site1House2 == false && House2.Site1House3 == false && House2.Site1House4 == false)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 7");
                Build1Money1 = 7;
                Build1Money2 = 7;
            }
            if(House2.Site1House1 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 15");
                Build1Money1 = 15;
                Build1Money2 = 15;
            }
            if(House2.Site1House2 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 30");
                Build1Money1 = 30;
                Build1Money2 = 30;
            }
            if(House2.Site1House3 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 60");
                Build1Money1 = 60;
                Build1Money2 = 60;
            }
            if(House2.Site1House4 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 90");
                Build1Money1 = 90;
                Build1Money2 = 90;
            }
        }
        else if(P2OwnSet1 == false)
        {
            Debug.Log("You landed on someones property!! Pay: ");
            Info.instance.ShowMessage("You Landed on Someone's Property!!! Pay: 2");
            Build1Money1 = 2;
            Build1Money2 = 2;
        }
    }

    public void P1CheckProperty2()
    {
        if(P2OwnSet1 == true)
        {
            if(House2.Site2House1 == false && House2.Site2House2 == false && House2.Site2House3 == false && House2.Site2House4 == false)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 7");
                Build1Money1 = 7;
                Build1Money2 = 7;
            }
            if(House2.Site2House1 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 15");
                Build1Money1 = 15;
                Build1Money2 = 15;
            }
            if(House2.Site2House2 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 30");
                Build1Money1 = 30;
                Build1Money2 = 30;
            }
            if(House2.Site2House3 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 60");
                Build1Money1 = 60;
                Build1Money2 = 60;
            }
            if(House2.Site2House4 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 90");
                Build1Money1 = 90;
                Build1Money2 = 90;
            }
        }
        else if(P2OwnSet1 == false)
        {
            Debug.Log("You landed on someones property!! Pay: ");
            Info.instance.ShowMessage("You Landed on Someone's Property!!! Pay: 4");
            Build1Money1 = 4;
            Build1Money2 = 4;
        }
    }

    public void P1CheckProperty3()
    {
        if(P2OwnSet2 == true)
        {
            if(House2.Site3House1 == false && House2.Site3House2 == false && House2.Site3House3 == false && House2.Site3House4 == false)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 15");
                Build1Money1 = 15;
                Build1Money2 = 15;
            }
            if(House2.Site3House1 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 25");
                Build1Money1 = 25;
                Build1Money2 = 25;
            }
            if(House2.Site3House2 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 50");
                Build1Money1 = 50;
                Build1Money2 = 50;
            }
            if(House2.Site3House3 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 75");
                Build1Money1 = 75;
                Build1Money2 = 75;
            }
            if(House2.Site3House4 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 100");
                Build1Money1 = 100;
                Build1Money2 = 100;
            }
        }
        else if(P2OwnSet2 == false)
        {
            Debug.Log("You landed on someones property!! Pay: ");
            Info.instance.ShowMessage("You Landed on Someone's Property!!! Pay: 6");
            Build1Money1 = 6;
            Build1Money2 = 6;
        }
    }

    public void P1CheckProperty4()
    {
        if(P2OwnSet2 == true)
        {
            if(House2.Site4House1 == false && House2.Site4House2 == false && House2.Site4House3 == false && House2.Site4House4 == false)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 15");
                Build1Money1 = 15;
                Build1Money2 = 15;
            }
            if(House2.Site4House1 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 30");
                Build1Money1 = 30;
                Build1Money2 = 30;
            }
            if(House2.Site4House2 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 60");
                Build1Money1 = 60;
                Build1Money2 = 60;
            }
            if(House2.Site4House3 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 90");
                Build1Money1 = 90;
                Build1Money2 = 90;
            }
            if(House2.Site4House4 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 160");
                Build1Money1 = 160;
                Build1Money2 = 160;
            }
        }
        else if(P2OwnSet2 == false)
        {
            Debug.Log("You landed on someones property!! Pay: ");
            Info.instance.ShowMessage("You Landed on Someone's Property!!! Pay: 6");
            Build1Money1 = 6;
            Build1Money2 = 6;
        }
    }

    public void P1CheckProperty5()
    {
        if(P2OwnSet2 == true)
        {
            if(House2.Site5House1 == false && House2.Site5House2 == false && House2.Site5House3 == false && House2.Site5House4 == false)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 15");
                Build1Money1 = 15;
                Build1Money2 = 15;
            }
            if(House2.Site5House1 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 30");
                Build1Money1 = 30;
                Build1Money2 = 30;
            }
            if(House2.Site5House2 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 60");
                Build1Money1 = 60;
                Build1Money2 = 60;
            }
            if(House2.Site5House3 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 90");
                Build1Money1 = 90;
                Build1Money2 = 90;
            }
            if(House2.Site5House4 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 160");
                Build1Money1 = 160;
                Build1Money2 = 160;
            }
        }
        else if(P2OwnSet2 == false)
        {
            Debug.Log("You landed on someones property!! Pay: ");
            Info.instance.ShowMessage("You Landed on Someone's Property!!! Pay: 8");
            Build1Money1 = 8;
            Build1Money2 = 8;
        }
    }

    public void P1CheckProperty6()
    {
        if(P2OwnSet3== true)
        {
            if(House2.Site6House1 == false && House2.Site6House2 == false && House2.Site6House3 == false && House2.Site6House4 == false)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 25");
                Build1Money1 = 25;
                Build1Money2 = 25;
            }
            if(House2.Site6House1 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 50");
                Build1Money1 = 50;
                Build1Money2 = 50;
            }
            if(House2.Site6House2 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 80");
                Build1Money1 = 80;
                Build1Money2 = 80;
            }
            if(House2.Site6House3 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 120");
                Build1Money1 = 120;
                Build1Money2 = 120;
            }
            if(House2.Site6House4 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 180");
                Build1Money1 = 180;
                Build1Money2 = 180;
            }
        }
        else if(P2OwnSet3 == false)
        {
            Debug.Log("You landed on someones property!! Pay: ");
            Info.instance.ShowMessage("You Landed on Someone's Property!!! Pay: 10");
            Build1Money1 = 10;
            Build1Money2 = 10;
        }
    }

    public void P1CheckProperty7()
    {
        if(P2OwnSet3== true)
        {
            if(House2.Site7House1 == false && House2.Site7House2 == false && House2.Site7House3 == false && House2.Site7House4 == false)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 25");
                Build1Money1 = 25;
                Build1Money2 = 25;
            }
            if(House2.Site7House1 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 50");
                Build1Money1 = 50;
                Build1Money2 = 50;
            }
            if(House2.Site7House2 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 80");
                Build1Money1 = 80;
                Build1Money2 = 80;
            }
            if(House2.Site7House3 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 120");
                Build1Money1 = 120;
                Build1Money2 = 120;
            }
            if(House2.Site7House4 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 180");
                Build1Money1 = 180;
                Build1Money2 = 180;
            }
        }
        else if(P2OwnSet3 == false)
        {
            Debug.Log("You landed on someones property!! Pay: ");
            Info.instance.ShowMessage("You Landed on Someone's Property!!! Pay: 10");
            Build1Money1 = 10;
            Build1Money2 = 10;
        }
    }
    
    public void P1CheckProperty8()
    {
        if(P2OwnSet3== true)
        {
            if(House2.Site8House1 == false && House2.Site8House2 == false && House2.Site8House3 == false && House2.Site8House4 == false)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 30");
                Build1Money1 = 30;
                Build1Money2 = 30;
            }
            if(House2.Site8House1 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 60");
                Build1Money1 = 60;
                Build1Money2 = 60;
            }
            if(House2.Site8House2 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 90");
                Build1Money1 = 90;
                Build1Money2 = 90;
            }
            if(House2.Site8House3 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 140");
                Build1Money1 = 140;
                Build1Money2 = 140;
            }
            if(House2.Site8House4 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 190");
                Build1Money1 = 190;
                Build1Money2 = 190;
            }
        }
        else if(P2OwnSet3 == false)
        {
            Debug.Log("You landed on someones property!! Pay: ");
            Info.instance.ShowMessage("You Landed on Someone's Property!!! Pay: 12");
            Build1Money1 = 12;
            Build1Money2 = 12;
        }
    }

    public void P1CheckProperty9()
    {
        if(P2OwnSet4== true)
        {
            if(House2.Site9House1 == false && House2.Site9House2 == false && House2.Site9House3 == false && House2.Site9House4 == false)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 40");
                Build1Money1 = 40;
                Build1Money2 = 40;
            }
            if(House2.Site9House1 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 80");
                Build1Money1 = 80;
                Build1Money2 = 80;
            }
            if(House2.Site9House2 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 110");
                Build1Money1 = 110;
                Build1Money2 = 110;
            }
            if(House2.Site9House3 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 160");
                Build1Money1 = 160;
                Build1Money2 = 160;
            }
            if(House2.Site9House4 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 230");
                Build1Money1 = 230;
                Build1Money2 = 230;
            }
        }
        else if(P2OwnSet4 == false)
        {
            Debug.Log("You landed on someones property!! Pay: ");
            Info.instance.ShowMessage("You Landed on Someone's Property!!! Pay: 14");
            Build1Money1 = 14;
            Build1Money2 = 14;
        }
    }

    public void P1CheckProperty10()
    {
        if(P2OwnSet4 == true)
        {
            if(House2.Site10House1 == false && House2.Site10House2 == false && House2.Site10House3 == false && House2.Site10House4 == false)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 40");
                Build1Money1 = 40;
                Build1Money2 = 40;
            }
            if(House2.Site10House1 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 80");
                Build1Money1 = 80;
                Build1Money2 = 80;
            }
            if(House2.Site10House2 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 110");
                Build1Money1 = 110;
                Build1Money2 = 110;
            }
            if(House2.Site10House3 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 160");
                Build1Money1 = 160;
                Build1Money2 = 160;
            }
            if(House2.Site10House4 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 230");
                Build1Money1 = 230;
                Build1Money2 = 230;
            }
        }
        else if(P2OwnSet4 == false)
        {
            Debug.Log("You landed on someones property!! Pay: ");
            Info.instance.ShowMessage("You Landed on Someone's Property!!! Pay: 14");
            Build1Money1 = 14;
            Build1Money2 = 14;
        }
    }

    public void P1CheckProperty11()
    {
        if(P2OwnSet4== true)
        {
            if(House2.Site11House1 == false && House2.Site11House2 == false && House2.Site11House3 == false && House2.Site11House4 == false)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 45");
                Build1Money1 = 45;
                Build1Money2 = 45;
            }
            if(House2.Site11House1 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 90");
                Build1Money1 = 90;
                Build1Money2 = 90;
            }
            if(House2.Site11House2 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 130");
                Build1Money1 = 130;
                Build1Money2 = 130;
            }
            if(House2.Site11House3 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 180");
                Build1Money1 = 180;
                Build1Money2 = 180;
            }
            if(House2.Site11House4 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 270");
                Build1Money1 = 270;
                Build1Money2 = 270;
            }
        }
        else if(P2OwnSet4 == false)
        {
            Debug.Log("You landed on someones property!! Pay: ");
            Info.instance.ShowMessage("You Landed on Someone's Property!!! Pay: 16");
            Build1Money1 = 16;
            Build1Money2 = 16;
        }
    }

    public void P1CheckProperty12()
    {
        if(P2OwnSet5== true)
        {
            if(House2.Site12House1 == false && House2.Site12House2 == false && House2.Site12House3 == false && House2.Site12House4 == false)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 50");
                Build1Money1 = 50;
                Build1Money2 = 50;
            }
            if(House2.Site12House1 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 100");
                Build1Money1 = 100;
                Build1Money2 = 100;
            }
            if(House2.Site12House2 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 150");
                Build1Money1 = 150;
                Build1Money2 = 150;
            }
            if(House2.Site12House3 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 200");
                Build1Money1 = 200;
                Build1Money2 = 200;
            }
            if(House2.Site12House4 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 300");
                Build1Money1 = 300;
                Build1Money2 = 300;
            }
        }
        else if(P2OwnSet5 == false)
        {
            Debug.Log("You landed on someones property!! Pay: ");
            Info.instance.ShowMessage("You Landed on Someone's Property!!! Pay: 18");
            Build1Money1 = 18;
            Build1Money2 = 18;
        }
    }

    public void P1CheckProperty13()
    {
        if(P2OwnSet5== true)
        {
            if(House2.Site13House1 == false && House2.Site13House2 == false && House2.Site13House3 == false && House2.Site13House4 == false)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 60");
                Build1Money1 = 60;
                Build1Money2 = 60;
            }
            if(House2.Site13House1 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 120");
                Build1Money1 = 120;
                Build1Money2 = 120;
            }
            if(House2.Site13House2 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 190");
                Build1Money1 = 190;
                Build1Money2 = 190;
            }
            if(House2.Site13House3 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 240");
                Build1Money1 = 240;
                Build1Money2 = 240;
            }
            if(House2.Site13House4 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 315");
                Build1Money1 = 315;
                Build1Money2 = 315;
            }
        }
        else if(P2OwnSet5 == false)
        {
            Debug.Log("You landed on someones property!! Pay: ");
            Info.instance.ShowMessage("You Landed on Someone's Property!!! Pay: 18");
            Build1Money1 = 18;
            Build1Money2 = 18;
        }
    }

    public void P1CheckProperty14()
    {
        if(P2OwnSet5== true)
        {
            if(House2.Site14House1 == false && House2.Site14House2 == false && House2.Site14House3 == false && House2.Site14House4 == false)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 60");
                Build1Money1 = 60;
                Build1Money2 = 60;
            }
            if(House2.Site14House1 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 120");
                Build1Money1 = 120;
                Build1Money2 = 120;
            }
            if(House2.Site14House2 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 190");
                Build1Money1 = 190;
                Build1Money2 = 190;
            }
            if(House2.Site14House3 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 240");
                Build1Money1 = 240;
                Build1Money2 = 240;
            }
            if(House2.Site14House4 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 315");
                Build1Money1 = 315;
                Build1Money2 = 315;
            }
        }
        else if(P2OwnSet5 == false)
        {
            Debug.Log("You landed on someones property!! Pay: ");
            Info.instance.ShowMessage("You Landed on Someone's Property!!! Pay: 20");
            Build1Money1 = 20;
            Build1Money2 = 20;
        }
    }


    public void P1CheckProperty15()
    {
        if(P2OwnSet6== true)
        {
            if(House2.Site15House1 == false && House2.Site15House2 == false && House2.Site15House3 == false && House2.Site15House4 == false)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 65");
                Build1Money1 = 65;
                Build1Money2 = 65;
            }
            if(House2.Site15House1 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 130");
                Build1Money1 = 130;
                Build1Money2 = 130;
            }
            if(House2.Site15House2 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 210");
                Build1Money1 = 210;
                Build1Money2 = 210;
            }
            if(House2.Site15House3 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 260");
                Build1Money1 = 260;
                Build1Money2 = 260;
            }
            if(House2.Site15House4 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 325");
                Build1Money1 = 325;
                Build1Money2 = 325;
            }
        }
        else if(P2OwnSet6 == false)
        {
            Debug.Log("You landed on someones property!! Pay: ");
            Info.instance.ShowMessage("You Landed on Someone's Property!!! Pay: 22");
            Build1Money1 = 22;
            Build1Money2 = 22;
        }
    }

    public void P1CheckProperty16()
    {
        if(P2OwnSet6== true)
        {
            if(House2.Site16House1 == false && House2.Site16House2 == false && House2.Site16House3 == false && House2.Site16House4 == false)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 70");
                Build1Money1 = 70;
                Build1Money2 = 70;
            }
            if(House2.Site16House1 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 135");
                Build1Money1 = 135;
                Build1Money2 = 135;
            }
            if(House2.Site16House2 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 220");
                Build1Money1 = 220;
                Build1Money2 = 220;
            }
            if(House2.Site16House3 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 270");
                Build1Money1 = 270;
                Build1Money2 = 270;
            }
            if(House2.Site16House4 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 340");
                Build1Money1 = 340;
                Build1Money2 = 340;
            }
        }
        else if(P2OwnSet6 == false)
        {
            Debug.Log("You landed on someones property!! Pay: ");
            Info.instance.ShowMessage("You Landed on Someone's Property!!! Pay: 22");
            Build1Money1 = 22;
            Build1Money2 = 22;
        }
    }

    public void P1CheckProperty17()
    {
        if(P2OwnSet6== true)
        {
            if(House2.Site17House1 == false && House2.Site17House2 == false && House2.Site17House3 == false && House2.Site17House4 == false)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 70");
                Build1Money1 = 70;
                Build1Money2 = 70;
            }
            if(House2.Site17House1 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 140");
                Build1Money1 = 140;
                Build1Money2 = 140;
            }
            if(House2.Site17House2 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 250");
                Build1Money1 = 250;
                Build1Money2 = 250;
            }
            if(House2.Site17House3 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 300");
                Build1Money1 = 300;
                Build1Money2 = 300;
            }
            if(House2.Site17House4 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 350");
                Build1Money1 = 350;
                Build1Money2 = 350;
            }
        }
        else if(P2OwnSet6 == false)
        {
            Debug.Log("You landed on someones property!! Pay: ");
            Info.instance.ShowMessage("You Landed on Someone's Property!!! Pay: 24");
            Build1Money1 = 24;
            Build1Money2 = 24;
        }
    }

    public void P1CheckProperty18()
    {
        if(P2OwnSet7== true)
        {
            if(House2.Site18House1 == false && House2.Site18House2 == false && House2.Site18House3 == false && House2.Site18House4 == false)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 70");
                Build1Money1 = 70;
                Build1Money2 = 70;
            }
            if(House2.Site18House1 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 150");
                Build1Money1 = 150;
                Build1Money2 = 150;
            }
            if(House2.Site18House2 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 270");
                Build1Money1 = 270;
                Build1Money2 = 270;
            }
            if(House2.Site18House3 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 320");
                Build1Money1 = 320;
                Build1Money2 = 320;
            }
            if(House2.Site18House4 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 470");
                Build1Money1 = 470;
                Build1Money2 = 470;
            }
        }
        else if(P2OwnSet7 == false)
        {
            Debug.Log("You landed on someones property!! Pay: ");
            Info.instance.ShowMessage("You Landed on Someone's Property!!! Pay: 26");
            Build1Money1 = 26;
            Build1Money2 = 26;
        }
    }

    public void P1CheckProperty19()
    {
        if(P2OwnSet7== true)
        {
            if(House2.Site19House1 == false && House2.Site19House2 == false && House2.Site19House3 == false && House2.Site19House4 == false)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 70");
                Build1Money1 = 70;
                Build1Money2 = 70;
            }
            if(House2.Site19House1 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 150");
                Build1Money1 = 150;
                Build1Money2 = 150;
            }
            if(House2.Site19House2 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 270");
                Build1Money1 = 270;
                Build1Money2 = 270;
            }
            if(House2.Site19House3 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 320");
                Build1Money1 = 320;
                Build1Money2 = 320;
            }
            if(House2.Site19House4 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 470");
                Build1Money1 = 470;
                Build1Money2 = 470;
            }
        }
        else if(P2OwnSet7 == false)
        {
            Debug.Log("You landed on someones property!! Pay: ");
            Info.instance.ShowMessage("You Landed on Someone's Property!!! Pay: 26");
            Build1Money1 = 26;
            Build1Money2 = 26;
        }
    }

    public void P1CheckProperty20()
    {
        if(P2OwnSet7== true)
        {
            if(House2.Site20House1 == false && House2.Site20House2 == false && House2.Site20House3 == false && House2.Site20House4 == false)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 80");
                Build1Money1 = 80;
                Build1Money2 = 80;
            }
            if(House2.Site20House1 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 160");
                Build1Money1 = 160;
                Build1Money2 = 160;
            }
            if(House2.Site20House2 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 310");
                Build1Money1 = 310;
                Build1Money2 = 310;
            }
            if(House2.Site20House3 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 360");
                Build1Money1 = 360;
                Build1Money2 = 360;
            }
            if(House2.Site20House4 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 490");
                Build1Money1 = 490;
                Build1Money2 = 490;
            }
        }
        else if(P2OwnSet7 == false)
        {
            Debug.Log("You landed on someones property!! Pay: ");
            Info.instance.ShowMessage("You Landed on Someone's Property!!! Pay: 28");
            Build1Money1 = 28;
            Build1Money2 = 28;
        }
    }

    public void P1CheckProperty21()
    {
        if(P2OwnSet8== true)
        {
            if(House2.Site21House1 == false && House2.Site21House2 == false && House2.Site21House3 == false && House2.Site21House4 == false)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 90");
                Build1Money1 = 90;
                Build1Money2 = 90;
            }
            if(House2.Site21House1 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 170");
                Build1Money1 = 170;
                Build1Money2 = 170;
            }
            if(House2.Site21House2 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 350");
                Build1Money1 = 350;
                Build1Money2 = 350;
            }
            if(House2.Site21House3 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 500");
                Build1Money1 = 500;
                Build1Money2 = 500;
            }
            if(House2.Site21House4 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 750");
                Build1Money1 = 750;
                Build1Money2 = 750;
            }
        }
        else if(P2OwnSet8 == false)
        {
            Debug.Log("You landed on someones property!! Pay: ");
            Info.instance.ShowMessage("You Landed on Someone's Property!!! Pay: 35");
            Build1Money1 = 35;
            Build1Money2 = 35;
        }
    }

    public void P1CheckProperty22()
    {
        if(P2OwnSet8== true)
        {
            if(House2.Site22House1 == false && House2.Site22House2 == false && House2.Site22House3 == false && House2.Site22House4 == false)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 100");
                Build1Money1 = 100;
                Build1Money2 = 100;
            }
            if(House2.Site22House1 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 200");
                Build1Money1 = 200;
                Build1Money2 = 200;
            }
            if(House2.Site22House2 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 300");
                Build1Money1 = 300;
                Build1Money2 = 300;
            }
            if(House2.Site22House3 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 500");
                Build1Money1 = 500;
                Build1Money2 = 500;
            }
            if(House2.Site22House4 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 800");
                Build1Money1 = 800;
                Build1Money2 = 800;
            }
        }
        else if(P2OwnSet8 == false)
        {
            Debug.Log("You landed on someones property!! Pay: ");
            Info.instance.ShowMessage("You Landed on Someone's Property!!! Pay: 50");
            Build1Money1 = 50;
            Build1Money2 = 50;
        }
    }






    public void P2CheckProperty1()
    {
        if(P1OwnSet1== true)
        {
            if(House.Site1House1 == false && House.Site1House2 == false && House.Site1House3 == false && House.Site1House4 == false)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 7");
                Build1Money1 = 7;
                Build1Money2 = 7;
            }
            if(House.Site1House1 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 15");
                Build1Money1 = 15;
                Build1Money2 = 15;
            }
            if(House.Site1House2 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 30");
                Build1Money1 = 30;
                Build1Money2 = 30;
            }
            if(House.Site1House3 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 60");
                Build1Money1 = 60;
                Build1Money2 = 60;
            }
            if(House.Site1House4 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 90");
                Build1Money1 = 90;
                Build1Money2 = 90;
            }
        }
        else if(P1OwnSet1 == false)
        {
            Debug.Log("You Landed on someones Property!! Pay: ");
            Info.instance.ShowMessage("You Landed on Someone's Property!!! Pay: 2");
            Build1Money2 = 2;
            Build1Money1 = 2;
        }
    }

    public void P2CheckProperty2()
    {
        if(P1OwnSet1== true)
        {
            if(House.Site2House1 == false && House.Site2House2 == false && House.Site2House3 == false && House.Site2House4 == false)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 7");
                Build1Money1 = 7;
                Build1Money2 = 7;
            }
            if(House.Site2House1 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 15");
                Build1Money1 = 15;
                Build1Money2 = 15;
            }
            if(House.Site2House2 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 30");
                Build1Money1 = 30;
                Build1Money2 = 30;
            }
            if(House.Site2House3 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 60");
                Build1Money1 = 60;
                Build1Money2 = 60;
            }
            if(House.Site2House4 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 90");
                Build1Money1 = 90;
                Build1Money2 = 90;
            }
        }
        else if(P1OwnSet1 == false)
        {
            Debug.Log("You Landed on someones Property!! Pay: ");
            Info.instance.ShowMessage("You Landed on Someone's Property!!! Pay: 4");
            Build1Money2 = 4;
            Build1Money1 = 4;
        }
    }

    public void P2CheckProperty3()
    {
        if(P1OwnSet2== true)
        {
            if(House.Site3House1 == false && House.Site3House2 == false && House.Site3House3 == false && House.Site3House4 == false)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 15");
                Build1Money1 = 15;
                Build1Money2 = 15;
            }
            if(House.Site3House1 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 25");
                Build1Money1 = 25;
                Build1Money2 = 25;
            }
            if(House.Site3House2 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 50");
                Build1Money1 = 50;
                Build1Money2 = 50;
            }
            if(House.Site3House3 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 75");
                Build1Money1 = 75;
                Build1Money2 = 75;
            }
            if(House.Site3House4 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 100");
                Build1Money1 = 100;
                Build1Money2 = 100;
            }
        }
        else if(P1OwnSet2 == false)
        {
            Debug.Log("You Landed on someones Property!! Pay: ");
            Info.instance.ShowMessage("You Landed on Someone's Property!!! Pay: 6");
            Build1Money2 = 6;
            Build1Money1 = 6;
        }
    }

    public void P2CheckProperty4()
    {
        if(P1OwnSet2== true)
        {
            if(House.Site4House1 == false && House.Site4House2 == false && House.Site4House3 == false && House.Site4House4 == false)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 15");
                Build1Money1 = 15;
                Build1Money2 = 15;
            }
            if(House.Site4House1 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 30");
                Build1Money1 = 30;
                Build1Money2 = 30;
            }
            if(House.Site4House2 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 60");
                Build1Money1 = 60;
                Build1Money2 = 60;
            }
            if(House.Site4House3 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 90");
                Build1Money1 = 90;
                Build1Money2 = 90;
            }
            if(House.Site4House4 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 160");
                Build1Money1 = 160;
                Build1Money2 = 160;
            }
        }
        else if(P1OwnSet2 == false)
        {
            Debug.Log("You Landed on someones Property!! Pay: ");
            Info.instance.ShowMessage("You Landed on Someone's Property!!! Pay: 6");
            Build1Money2 = 6;
            Build1Money1 = 6;
        }
    }

    public void P2CheckProperty5()
    {
        if(P1OwnSet2== true)
        {
            if(House.Site5House1 == false && House.Site5House2 == false && House.Site5House3 == false && House.Site5House4 == false)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 15");
                Build1Money1 = 15;
                Build1Money2 = 15;
            }
            if(House.Site5House1 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 30");
                Build1Money1 = 30;
                Build1Money2 = 30;
            }
            if(House.Site5House2 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 60");
                Build1Money1 = 60;
                Build1Money2 = 60;
            }
            if(House.Site5House3 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 90");
                Build1Money1 = 90;
                Build1Money2 = 90;
            }
            if(House.Site5House4 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 160");
                Build1Money1 = 160;
                Build1Money2 = 160;
            }
        }
        else if(P1OwnSet2 == false)
        {
            Debug.Log("You Landed on someones Property!! Pay: ");
            Info.instance.ShowMessage("You Landed on Someone's Property!!! Pay: 8");
            Build1Money2 = 8;
            Build1Money1 = 8;
        }
    }

    public void P2CheckProperty6()
    {
        if(P1OwnSet3 == true)
        {
            if(House.Site6House1 == false && House.Site6House2 == false && House.Site6House3 == false && House.Site6House4 == false)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 25");
                Build1Money1 = 25;
                Build1Money2 = 25;
            }
            if(House.Site6House1 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 50");
                Build1Money1 = 50;
                Build1Money2 = 50;
            }
            if(House.Site6House2 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 80");
                Build1Money1 = 80;
                Build1Money2 = 80;
            }
            if(House.Site6House3 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 120");
                Build1Money1 = 120;
                Build1Money2 = 120;
            }
            if(House.Site6House4 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 180");
                Build1Money1 = 180;
                Build1Money2 = 180;
            }
        }
        else if(P1OwnSet3 == false)
        {
            Debug.Log("You Landed on someones Property!! Pay: ");
            Info.instance.ShowMessage("You Landed on Someone's Property!!! Pay: 10");
            Build1Money2 = 10;
            Build1Money1 = 10;
        }
    }

    public void P2CheckProperty7()
    {
        if(P1OwnSet3 == true)
        {
            if(House.Site7House1 == false && House.Site7House2 == false && House.Site7House3 == false && House.Site7House4 == false)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 25");
                Build1Money1 = 25;
                Build1Money2 = 25;
            }
            if(House.Site7House1 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 50");
                Build1Money1 = 50;
                Build1Money2 = 50;
            }
            if(House.Site7House2 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 80");
                Build1Money1 = 80;
                Build1Money2 = 80;
            }
            if(House.Site7House3 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 120");
                Build1Money1 = 120;
                Build1Money2 = 120;
            }
            if(House.Site7House4 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 180");
                Build1Money1 = 180;
                Build1Money2 = 180;
            }
        }
        else if(P1OwnSet3 == false)
        {
            Debug.Log("You Landed on someones Property!! Pay: ");
            Info.instance.ShowMessage("You Landed on Someone's Property!!! Pay: 10");
            Build1Money2 = 10;
            Build1Money1 = 10;
        }
    }

    public void P2CheckProperty8()
    {
        if(P1OwnSet3== true)
        {
            if(House.Site8House1 == false && House.Site8House2 == false && House.Site8House3 == false && House.Site8House4 == false)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 30");
                Build1Money1 = 30;
                Build1Money2 = 30;
            }
            if(House.Site8House1 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 60");
                Build1Money1 = 60;
                Build1Money2 = 60;
            }
            if(House.Site8House2 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 90");
                Build1Money1 = 90;
                Build1Money2 = 90;
            }
            if(House.Site8House3 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 140");
                Build1Money1 = 140;
                Build1Money2 = 140;
            }
            if(House.Site8House4 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 190");
                Build1Money1 = 190;
                Build1Money2 = 190;
            }
        }
        else if(P1OwnSet3 == false)
        {
            Debug.Log("You Landed on someones Property!! Pay: ");
            Info.instance.ShowMessage("You Landed on Someone's Property!!! Pay: 12");
            Build1Money2 = 12;
            Build1Money1 = 12;
        }
    }

    public void P2CheckProperty9()
    {
    if(P1OwnSet4== true)
    {
            if(House.Site9House1 == false && House.Site9House2 == false && House.Site9House3 == false && House.Site9House4 == false)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 40");
                Build1Money1 = 40;
                Build1Money2 = 40;
            }
            if(House.Site9House1 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 80");
                Build1Money1 = 80;
                Build1Money2 = 80;
            }
            if(House.Site9House2 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 110");
                Build1Money1 = 110;
                Build1Money2 = 110;
            }
            if(House.Site9House3 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 160");
                Build1Money1 = 160;
                Build1Money2 = 160;
            }
            if(House.Site9House4 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 230");
                Build1Money1 = 230;
                Build1Money2 = 230;
            }
        }
        else if(P1OwnSet4 == false)
        {
            Debug.Log("You Landed on someones Property!! Pay: ");
            Info.instance.ShowMessage("You Landed on Someone's Property!!! Pay: 14");
            Build1Money2 = 14;
            Build1Money1 = 14;
        }
    }

    public void P2CheckProperty10()
    {
        if(P1OwnSet4== true)
        {
            if(House.Site10House1 == false && House.Site10House2 == false && House.Site10House3 == false && House.Site10House4 == false)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 40");
                Build1Money1 = 40;
                Build1Money2 = 40;
            }
            if(House.Site10House1 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 80");
                Build1Money1 = 80;
                Build1Money2 = 80;
            }
            if(House.Site10House2 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 110");
                Build1Money1 = 110;
                Build1Money2 = 110;
            }
            if(House.Site10House3 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 160");
                Build1Money1 = 160;
                Build1Money2 = 160;
            }
            if(House.Site10House4 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 230");
                Build1Money1 = 230;
                Build1Money2 = 230;
            }
        }
        else if(P1OwnSet4 == false)
        {
            Debug.Log("You Landed on someones Property!! Pay: ");
            Info.instance.ShowMessage("You Landed on Someone's Property!!! Pay: 14");
            Build1Money2 = 14;
            Build1Money1 = 14;
        }
    }

    public void P2CheckProperty11()
    {
        if(P1OwnSet4== true)
        {
            if(House.Site11House1 == false && House.Site11House2 == false && House.Site11House3 == false && House.Site11House4 == false)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 45");
                Build1Money1 = 45;
                Build1Money2 = 45;
            }
            if(House.Site11House1 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 90");
                Build1Money1 = 90;
                Build1Money2 = 90;
            }
            if(House.Site11House2 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 130");
                Build1Money1 = 130;
                Build1Money2 = 130;
            }
            if(House.Site11House3 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 180");
                Build1Money1 = 180;
                Build1Money2 = 180;
            }
            if(House.Site11House4 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 270");
                Build1Money1 = 270;
                Build1Money2 = 270;
            }
        }
        else if(P1OwnSet4 == false)
        {
            Debug.Log("You Landed on someones Property!! Pay: ");
            Info.instance.ShowMessage("You Landed on Someone's Property!!! Pay: 16");
            Build1Money2 = 16;
            Build1Money1 = 16;
        }
    }

    public void P2CheckProperty12()
    {
        if(P1OwnSet5== true)
        {
            if(House.Site12House1 == false && House.Site12House2 == false && House.Site12House3 == false && House.Site12House4 == false)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 50");
                Build1Money1 = 50;
                Build1Money2 = 50;
            }
            if(House.Site12House1 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 100");
                Build1Money1 = 100;
                Build1Money2 = 100;
            }
            if(House.Site12House2 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 150");
                Build1Money1 = 150;
                Build1Money2 = 150;
            }
            if(House.Site12House3 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 200");
                Build1Money1 = 200;
                Build1Money2 = 200;
            }
            if(House.Site12House4 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 300");
                Build1Money1 = 300;
                Build1Money2 = 300;
            }
        }
        else if(P1OwnSet5 == false)
        {
            Debug.Log("You Landed on someones Property!! Pay: ");
            Info.instance.ShowMessage("You Landed on Someone's Property!!! Pay: 18");
            Build1Money2 = 18;
            Build1Money1 = 18;
        }
    }

    public void P2CheckProperty13()
    {
        if(P1OwnSet5== true)
        {
            if(House.Site13House1 == false && House.Site13House2 == false && House.Site13House3 == false && House.Site13House4 == false)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 60");
                Build1Money1 = 60;
                Build1Money2 = 60;
            }
            if(House.Site13House1 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 120");
                Build1Money1 = 120;
                Build1Money2 = 120;
            }
            if(House.Site13House2 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 190");
                Build1Money1 = 190;
                Build1Money2 = 190;
            }
            if(House.Site13House3 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 240");
                Build1Money1 = 240;
                Build1Money2 = 240;
            }
            if(House.Site13House4 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 315");
                Build1Money1 = 315;
                Build1Money2 = 315;
            }
        }
        else if(P1OwnSet5 == false)
        {
            Debug.Log("You Landed on someones Property!! Pay: ");
            Info.instance.ShowMessage("You Landed on Someone's Property!!! Pay: 18");
            Build1Money2 = 18;
            Build1Money1 = 18;
        }
    }

    public void P2CheckProperty14()
    {
        if(P1OwnSet5== true)
        {
            if(House.Site14House1 == false && House.Site14House2 == false && House.Site14House3 == false && House.Site14House4 == false)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 60");
                Build1Money1 = 60;
                Build1Money2 = 60;
            }
            if(House.Site14House1 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 120");
                Build1Money1 = 120;
                Build1Money2 = 120;
            }
            if(House.Site14House2 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 190");
                Build1Money1 = 190;
                Build1Money2 = 190;
            }
            if(House.Site14House3 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 240");
                Build1Money1 = 240;
                Build1Money2 = 240;
            }
            if(House.Site14House4 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 315");
                Build1Money1 = 315;
                Build1Money2 = 315;
            }
        }
        
        else if(P1OwnSet5 == false)
        {
            Debug.Log("You Landed on someones Property!! Pay: ");
            Info.instance.ShowMessage("You Landed on Someone's Property!!! Pay: 20");
            Build1Money2 = 20;
            Build1Money1 = 20;
        }
    }
    

    public void P2CheckProperty15()
    {
        if(P1OwnSet6== true)
        {
            if(House.Site15House1 == false && House.Site15House2 == false && House.Site15House3 == false && House.Site15House4 == false)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 60");
                Build1Money1 = 60;
                Build1Money2 = 60;
            }
            if(House.Site15House1 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 130");
                Build1Money1 = 130;
                Build1Money2 = 130;
            }
            if(House.Site15House2 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 210");
                Build1Money1 = 210;
                Build1Money2 = 210;
            }
            if(House.Site15House3 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 260");
                Build1Money1 = 260;
                Build1Money2 = 260;
            }
            if(House.Site15House4 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 325");
                Build1Money1 = 325;
                Build1Money2 = 325;
            }
        }
        else if(P1OwnSet6 == false)
        {
            Debug.Log("You Landed on someones Property!! Pay: ");
            Info.instance.ShowMessage("You Landed on Someone's Property!!! Pay: 22");
            Build1Money2 = 22;
            Build1Money1 = 22;
        }
    }

    public void P2CheckProperty16()
    {
        if(P1OwnSet6== true)
        {
            if(House.Site16House1 == false && House.Site16House2 == false && House.Site16House3 == false && House.Site16House4 == false)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 65");
                Build1Money1 = 65;
                Build1Money2 = 65;
            }
            if(House.Site16House1 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 135");
                Build1Money1 = 135;
                Build1Money2 = 135;
            }
            if(House.Site16House2 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 220");
                Build1Money1 = 220;
                Build1Money2 = 220;
            }
            if(House.Site16House3 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 270");
                Build1Money1 = 270;
                Build1Money2 = 270;
            }
            if(House.Site16House4 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 340");
                Build1Money1 = 340;
                Build1Money2 = 340;
            }
        }
        else if(P1OwnSet6 == false)
        {
            Debug.Log("You Landed on someones Property!! Pay: ");
            Info.instance.ShowMessage("You Landed on Someone's Property!!! Pay: 22");
            Build1Money2 = 22;
            Build1Money1 = 22;
        }
    }

    public void P2CheckProperty17()
    {
        if(P1OwnSet6== true)
        {
            if(House.Site17House1 == false && House.Site17House2 == false && House.Site17House3 == false && House.Site17House4 == false)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 70");
                Build1Money1 = 70;
                Build1Money2 = 70;
            }
            if(House.Site17House1 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 140");
                Build1Money1 = 140;
                Build1Money2 = 140;
            }
            if(House.Site17House2 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 250");
                Build1Money1 = 250;
                Build1Money2 = 250;
            }
            if(House.Site17House3 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 300");
                Build1Money1 = 300;
                Build1Money2 = 300;
            }
            if(House.Site17House4 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 350");
                Build1Money1 = 350;
                Build1Money2 = 350;
            }
        }
        else if(P1OwnSet6 == false)
        {
            Debug.Log("You Landed on someones Property!! Pay: ");
            Info.instance.ShowMessage("You Landed on Someone's Property!!! Pay: 24");
            Build1Money2 = 24;
            Build1Money1 = 24;
        }
    }

    public void P2CheckProperty18()
    {
        if(P1OwnSet7== true)
        {
            if(House.Site18House1 == false && House.Site18House2 == false && House.Site18House3 == false && House.Site18House4 == false)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 75");
                Build1Money1 = 75;
                Build1Money2 = 75;
            }
            if(House.Site18House1 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 150");
                Build1Money1 = 150;
                Build1Money2 = 150;
            }
            if(House.Site18House2 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 270");
                Build1Money1 = 270;
                Build1Money2 = 270;
            }
            if(House.Site18House3 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 320");
                Build1Money1 = 320;
                Build1Money2 = 320;
            }
            if(House.Site18House4 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 470");
                Build1Money1 = 470;
                Build1Money2 = 470;
            }
        }
        else if(P1OwnSet7 == false)
        {
            Debug.Log("You Landed on someones Property!! Pay: ");
            Info.instance.ShowMessage("You Landed on Someone's Property!!! Pay: 26");
            Build1Money2 = 26;
            Build1Money1 = 26;
        }
    }

    public void P2CheckProperty19()
    {
        if(P1OwnSet7== true)
        {
            if(House.Site19House1 == false && House.Site19House2 == false && House.Site19House3 == false && House.Site19House4 == false)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 75");
                Build1Money1 = 75;
                Build1Money2 = 75;
            }
            if(House.Site19House1 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 150");
                Build1Money1 = 150;
                Build1Money2 = 150;
            }
            if(House.Site19House2 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 270");
                Build1Money1 = 270;
                Build1Money2 = 270;
            }
            if(House.Site19House3 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 320");
                Build1Money1 = 320;
                Build1Money2 = 320;
            }
            if(House.Site19House4 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 470");
                Build1Money1 = 470;
                Build1Money2 = 470;
            }
        }
        else if(P1OwnSet7 == false)
        {
            Debug.Log("You Landed on someones Property!! Pay: ");
            Info.instance.ShowMessage("You Landed on Someone's Property!!! Pay: 26");
            Build1Money2 = 26;
            Build1Money1 = 26;
        }
    }

    public void P2CheckProperty20()
    {
        if(P1OwnSet7== true)
        {
            if(House.Site20House1 == false && House.Site20House2 == false && House.Site20House3 == false && House.Site20House4 == false)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 80");
                Build1Money1 = 80;
                Build1Money2 = 80;
            }
            if(House.Site20House1 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 160");
                Build1Money1 = 160;
                Build1Money2 = 160;
            }
            if(House.Site20House2 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 310");
                Build1Money1 = 310;
                Build1Money2 = 310;
            }
            if(House.Site20House3 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 360");
                Build1Money1 = 360;
                Build1Money2 = 360;
            }
            if(House.Site20House4 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 490");
                Build1Money1 = 490;
                Build1Money2 = 490;
            }
        }
        else if(P1OwnSet7 == false)
        {
            Debug.Log("You Landed on someones Property!! Pay: ");
            Info.instance.ShowMessage("You Landed on Someone's Property!!! Pay: 28");
            Build1Money2 = 28;
            Build1Money1 = 28;
        }
    }

    public void P2CheckProperty21()
    {
        if(P1OwnSet8== true)
        {
            if(House.Site21House1 == false && House.Site21House2 == false && House.Site21House3 == false && House.Site21House4 == false)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 85");
                Build1Money1 = 85;
                Build1Money2 = 85;
            }
            if(House.Site21House1 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 170");
                Build1Money1 = 170;
                Build1Money2 = 170;
            }
            if(House.Site21House2 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 350");
                Build1Money1 = 350;
                Build1Money2 = 350;
            }
            if(House.Site21House3 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 500");
                Build1Money1 = 500;
                Build1Money2 = 500;
            }
            if(House.Site21House4 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 750");
                Build1Money1 = 750;
                Build1Money2 = 750;
            }
        }
        else if(P1OwnSet8 == false)
        {
            Debug.Log("You Landed on someones Property!! Pay: ");
            Info.instance.ShowMessage("You Landed on Someone's Property!!! Pay: 35");
            Build1Money2 = 35;
            Build1Money1 = 35;
        }
    }

    public void P2CheckProperty22()
    {
        if(P1OwnSet8== true)
        {
            if(House.Site22House1 == false && House.Site22House2 == false && House.Site22House3 == false && House.Site22House4 == false)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 100");
                Build1Money1 = 100;
                Build1Money2 = 100;
            }
            if(House.Site22House1 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 200");
                Build1Money1 = 200;
                Build1Money2 = 200;
            }
            if(House.Site22House2 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 300");
                Build1Money1 = 300;
                Build1Money2 = 300;
            }
            if(House.Site22House3 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 500");
                Build1Money1 = 500;
                Build1Money2 = 500;
            }
            if(House.Site22House4 == true)
            {
                Info.instance.ShowMessage("Property Upgrade 1!! Pay: 800");
                Build1Money1 = 800;
                Build1Money2 = 800;
            }
        }
        else if(P1OwnSet8 == false)
        {
            Debug.Log("You Landed on someones Property!! Pay: ");
            Info.instance.ShowMessage("You Landed on Someone's Property!!! Pay: 50");
            Build1Money2 = 50;
            Build1Money1 = 50;
        }
    }

}













    