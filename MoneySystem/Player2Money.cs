using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Money : MonoBehaviour
{
    public GameObject Money;
    public GameObject jail;
    public GameObject Yes, No, CheckStructure;
    private static GameObject player2;
    public MoneySystem Brought;
    public SpawnPlayer ID;
    
    public LoadingMiniGame Load;
    public AudioManager Audio;
    
    // Created by Caleb

    //Same process as explained in Player1Money

      //--------------------Distances-----------------------//

    public float totalDistance1;

    public float totalDistance2;
    public float totalDistance3;
    public float totalDistance4;
    public float totalDistance5;
    public float totalDistance6;
    public float totalDistance7;
    public float totalDistance8;
    public float totalDistance9;
    public float totalDistance10;
    public float totalDistance11;
    public float totalDistance12;
    public float totalDistance13;
    public float totalDistance14;
    public float totalDistance15;
    public float totalDistance16;
    public float totalDistance17;
    public float totalDistance18;
    public float totalDistance19;
    public float totalDistance20;
    public float totalDistance21;
    public float totalDistance22;
    public float totalDistance23;
    public float totalDistance24;
    public float totalDistance25;
    public float totalDistance26;
    public float totalDistance27;
    public float totalDistance28;
    public float totalDistance29;
    public float totalDistance30;
    public float totalDistance31;
    public float totalDistance32;
    public float totalDistance33;
    public float totalDistance34;
    public float totalDistance35;
    public float totalDistance36;
    public float totalDistance37;
    public float totalDistance38;
    

    //-----------------------------A LOTTA BOOLS----------------------------//
    public bool passGoRestart = true;
    public bool canBuy = false;

    public bool Restart1 = true;
    public bool Restart2 = true;
    public bool Restart3 = true;
    public bool Restart4 = true;
    public bool Restart5 = true;
    public bool Restart6 = true;
    public bool Restart7 = true;
    public bool Restart8 = true;
    public bool Restart9 = true;
    public bool Restart10 = true;
    public bool Restart11 = true;
    public bool Restart12 = true;
    public bool Restart13 = true;
    public bool Restart14 = true;
    public bool Restart15 = true;
    public bool Restart16 = true;
    public bool Restart17 = true;
    public bool Restart18 = true;
    public bool Restart19 = true;
    public bool Restart20 = true;
    public bool Restart21 = true;
    public bool Restart22 = true;
    public bool Restart23 = true;
    public bool Restart24 = true;
    public bool Restart25 = true;
    public bool Restart26 = true;
    public bool Restart27 = true;
    public bool Restart28 = true;

    public bool Restart30 = true;
    public bool Restart31 = true;
    public bool Restart32 = true;
    public bool Restart33 = true;
    public bool Restart34 = true;
    public bool Restart35 = true;
    public bool Restart36 = true;
    public bool Restart37 = true;
    public bool Restart38 = true;

    public bool BuyYes = false;
    public bool BuyNo = false;


    void Start()
    {
        Brought = FindObjectOfType<MoneySystem>();
        Yes.SetActive(false);
        No.SetActive(false);
        CheckStructure.SetActive(false);
        ID = FindObjectOfType<SpawnPlayer>();
        Load = FindObjectOfType<LoadingMiniGame>();
        Audio = FindObjectOfType<AudioManager>();
    }

    public void WantsToBuy()
            {
                BuyYes = true;
            }

    public void NoToBuy()
            {
                BuyNo = true;
            }

    void Update()
    {

        if(ID.ConstantID == 1)
        {


            player2 = GameObject.Find("Player2(Clone)");



            //----------------------------Vectors----------------------//

            Vector3 PlayerPosition = player2.transform.position;

            Vector3 FirstNode = new Vector3(5.2f,-4.5f,-3.6f);

            Vector3 GoldBerg = new Vector3(4.0f,-4.5f,-3.6f);
            Vector3 Quinn = new Vector3(2.2f,-4.5f,-3.6f);
            Vector3 Rogers = new Vector3(0.4f,-4.5f,-3.6f);
            Vector3 SangWoo = new Vector3(-0.4f,-4.5f,-3.6f);
            Vector3 SaeByeok = new Vector3(-2.3f,-4.6f,-3.6f);
            Vector3 GiHun = new Vector3(-3.1f,-4.6f,-3.6f);
            Vector3 Holmes = new Vector3(-4.4f,-3.5f,-3.6f);
            Vector3 Stark = new Vector3(-4.5f,-2.6f,-3.6f);
            Vector3 Watson = new Vector3(-4.5f,-1.8f,-3.6f);
            Vector3 Lestrade = new Vector3(-4.5f,-0.9f,-3.6f);
            Vector3 Strange = new Vector3(-4.5f,-0.1f,-3.6f);
            Vector3 Potter = new Vector3(-4.5f,0.7f,-3.6f);
            Vector3 Dumbeldore = new Vector3(-4.6f,2.4f,-3.6f);
            Vector3 Snape = new Vector3(-4.6f,3.3f,-3.6f);
            Vector3 Luke = new Vector3(-3.4f,4.4f,-3.6f);
            Vector3 Kenobi = new Vector3(-1.5f,4.4f,-3.6f);
            Vector3 Solo = new Vector3(-0.7f,4.4f,-3.6f);
            Vector3 Kent = new Vector3(0.2f,4.4f,-3.6f);
            Vector3 Eleven = new Vector3(1.1f,4.4f,-3.6f);
            Vector3 Hopper = new Vector3(2.0f,4.5f,-3.6f);
            Vector3 Wayne = new Vector3(2.9f,4.5f,-3.6f);
            Vector3 Wheeler = new Vector3(3.8f,4.5f,-3.6f);
            Vector3 Summer = new Vector3(5.1f,3.3f,-3.6f);
            Vector3 Morty = new Vector3(5.1f,2.5f,-3.6f);
            Vector3 Rick = new Vector3(5.2f,0.8f,-3.6f);
            Vector3 Curry = new Vector3(5.1f,0.0f,-3.6f);
            Vector3 Myers = new Vector3(5.1f,-1.7f,-3.6f);
            Vector3 Strode = new Vector3(5.2f,-3.4f,-3.6f);

            Vector3 Jail = new Vector3(-4.4f, -4.6f, -3.6f);
            Vector3 miniGame1 = new Vector3(-1.4f, -4.6f, -3.6f);
            Vector3 miniGame2 = new Vector3(-4.5f, 1.6f, -3.6f);
            Vector3 miniGame3 = new Vector3(-2.4f, 4.4f, -3.6f);
            Vector3 miniGame4 = new Vector3(5.1f, 1.6f, -3.6f);
            Vector3 miniGame5 = new Vector3(5.1f, -0.9f, -3.6f);
            Vector3 miniGame6 = new Vector3(3.1f, -4.5f, -3.6f);

            Vector3 PayTax = new Vector3(1.3f, -4.5f, -3.6f);
            Vector3 PayTax2 = new Vector3(5.1f, -2.5f, -3.6f);


            //--------------------------Distances---------------------//

            totalDistance1 = Vector3.Distance(PlayerPosition, FirstNode);

            totalDistance2 = Vector3.Distance(PlayerPosition, GoldBerg);
            totalDistance3 = Vector3.Distance(PlayerPosition, Quinn);
            totalDistance4 = Vector3.Distance(PlayerPosition, Rogers);
            totalDistance5 = Vector3.Distance(PlayerPosition, SangWoo);
            totalDistance6 = Vector3.Distance(PlayerPosition, SaeByeok);
            totalDistance7 = Vector3.Distance(PlayerPosition, GiHun);
            totalDistance8 = Vector3.Distance(PlayerPosition, Holmes);
            totalDistance9 = Vector3.Distance(PlayerPosition, Stark);
            totalDistance10 = Vector3.Distance(PlayerPosition, Watson);
            totalDistance11 = Vector3.Distance(PlayerPosition, Lestrade);
            totalDistance12 = Vector3.Distance(PlayerPosition, Strange);
            totalDistance13 = Vector3.Distance(PlayerPosition, Potter);
            totalDistance14 = Vector3.Distance(PlayerPosition, Dumbeldore);
            totalDistance15 = Vector3.Distance(PlayerPosition, Snape);
            totalDistance16 = Vector3.Distance(PlayerPosition, Luke);
            totalDistance17 = Vector3.Distance(PlayerPosition, Kenobi);
            totalDistance18 = Vector3.Distance(PlayerPosition, Solo);
            totalDistance19 = Vector3.Distance(PlayerPosition, Kent);
            totalDistance20 = Vector3.Distance(PlayerPosition, Eleven);
            totalDistance21 = Vector3.Distance(PlayerPosition, Hopper);
            totalDistance22 = Vector3.Distance(PlayerPosition, Wayne);
            totalDistance23 = Vector3.Distance(PlayerPosition, Wheeler);
            totalDistance24 = Vector3.Distance(PlayerPosition, Summer);
            totalDistance25 = Vector3.Distance(PlayerPosition, Morty);
            totalDistance26 = Vector3.Distance(PlayerPosition, Rick);
            totalDistance27 = Vector3.Distance(PlayerPosition, Curry);
            totalDistance28 = Vector3.Distance(PlayerPosition, Myers);
            totalDistance29 = Vector3.Distance(PlayerPosition, Strode);

            totalDistance30 = Vector3.Distance(PlayerPosition, Jail);
            totalDistance31 = Vector3.Distance(PlayerPosition, miniGame1);
            totalDistance32 = Vector3.Distance(PlayerPosition, miniGame2);
            totalDistance33 = Vector3.Distance(PlayerPosition, miniGame3);
            totalDistance34 = Vector3.Distance(PlayerPosition, miniGame4);
            totalDistance35 = Vector3.Distance(PlayerPosition, miniGame5);
            totalDistance36 = Vector3.Distance(PlayerPosition, miniGame6);

            totalDistance37 = Vector3.Distance(PlayerPosition, PayTax);
            totalDistance38 = Vector3.Distance(PlayerPosition, PayTax2);


            //-----------------------if statements--------------------//
            RestartPassGo();
            StartCoroutine("CheckStateActive");

            if(totalDistance30 < 0.0599 && totalDistance30 > 0.05970 &&  canBuy == true && Restart30 == true)
            {
                Audio.Play("Prison");
                jail.GetComponent<JAIL>().LandOnJail();
                Restart30 = false;
            }


            if(totalDistance1 < 0.046892 && totalDistance1 > 0.04688 && passGoRestart == true)
            {
                Money.GetComponent<MoneySystem>().MONEY_CONTROLLER(29);
                Debug.Log("You Passed Go!");
                passGoRestart = false;
            }

            if(totalDistance37 < 0.08 && totalDistance37 > 0.02 && canBuy == true && Restart37 == true)
            {
                Money.GetComponent<MoneySystem>().MONEY_CONTROLLER(200);
                Restart37 = false;
            }

            if(totalDistance38 < 0.08 && totalDistance38 > 0.02 && canBuy == true && Restart38 == true)
            {
                Money.GetComponent<MoneySystem>().MONEY_CONTROLLER(200);
                Restart38 = false;
            }

            if(totalDistance31 < 0.07278 && totalDistance31 > 0.07271 && canBuy == true && Restart31 == true)
            {
                Load.Starting(1);
                Restart31 = false;
            }

            if(totalDistance32 < 0.08 && totalDistance32 > 0.02 && canBuy == true && Restart32 == true)
            {
                Load.Starting(2);
                Restart32 = false;
            }
            
            if(totalDistance33 < 0.08 && totalDistance33 > 0.02 && canBuy == true && Restart33 == true)
            {
                Load.Starting(3);
                Restart33 = false;
            }

            if(totalDistance34 < 0.08 && totalDistance34 > 0.02 && canBuy == true && Restart34 == true)
            {
                Load.Starting(1);
                Restart34 = false;
            }

            if(totalDistance35 < 0.08 && totalDistance35 > 0.02 && canBuy == true && Restart35 == true)
            {
                Load.Starting(2);
                Restart35 = false;
            }

            if(totalDistance36 < 0.08 && totalDistance36 > 0.02 && canBuy == true && Restart36 == true)
            {
                Load.Starting(3);
                Restart36 = false;
            }
        //----------------------Prop1------------------------------//

            if(totalDistance2 < 0.08 && totalDistance2 > 0.02 && canBuy == true && Restart1 == true)

            {
                if(Brought.isBrought1 == true)
                {
                    Money.GetComponent<MoneySystem>().MONEY_CONTROLLER(30);
                    Restart1 = false;
                }
                else if(Brought.isBrought1 == false)
                {
                Yes.SetActive(true); No.SetActive(true); CheckStructure.SetActive(true);
                InfoProperty2.instance.StreetInfo("Property Name: Goldberg Avenue");
                InfoProperty2.instance.PriceInfo("Property Price: 60");
                InfoProperty2.instance.SetInfo("Colour Set: Brown");

                if(BuyYes == true)
                {
                    Yes.SetActive(false); No.SetActive(false); CheckStructure.SetActive(false);
                    Money.GetComponent<MoneySystem>().MONEY_CONTROLLER(30);
                    Restart1 = false; BuyYes = false;
                }
                if(BuyNo == true)
                {
                    Audio.Play("Close");
                    Yes.SetActive(false); No.SetActive(false); CheckStructure.SetActive(false);
                    Restart1 = false; BuyNo = false;
                }
            }
        }

        //----------------------Prop2------------------------------//

              if(totalDistance3 < 0.08 && totalDistance3 > 0.02 && canBuy == true  && Restart2 == true)

            {
                if(Brought.isBrought2 == true)
                {
                    Money.GetComponent<MoneySystem>().MONEY_CONTROLLER(31);
                    Restart2 = false;
                }
                else if(Brought.isBrought2 == false)
                {
                Yes.SetActive(true); No.SetActive(true); CheckStructure.SetActive(true);
                InfoProperty2.instance.StreetInfo("Property Name: Quinn Lane");
                InfoProperty2.instance.PriceInfo("Property Price: 60");
                InfoProperty2.instance.SetInfo("Colour Set: Brown");

                if(BuyYes == true)
                {
                    Yes.SetActive(false); No.SetActive(false); CheckStructure.SetActive(false);
                    Money.GetComponent<MoneySystem>().MONEY_CONTROLLER(31);
                    Restart2 = false; BuyYes = false;
                }
                if(BuyNo == true)
                {
                    Audio.Play("Close");
                    Yes.SetActive(false); No.SetActive(false); CheckStructure.SetActive(false);
                    Restart2 = false; BuyNo = false;
                }
            }
        }
            

        //----------------------Prop3------------------------------//

              if(totalDistance4 < 0.08 && totalDistance4 > 0.02 && canBuy == true  && Restart3 == true)

            {
                if(Brought.isBrought3 == true)
                {
                    Money.GetComponent<MoneySystem>().MONEY_CONTROLLER(32);
                    Restart3 = false;
                }
                else if(Brought.isBrought3 == false)
                {
                    Yes.SetActive(true); No.SetActive(true); CheckStructure.SetActive(true);
                    InfoProperty2.instance.StreetInfo("Property Name: Rogers Railway");
                    InfoProperty2.instance.PriceInfo("Property Price: 200");
                    InfoProperty2.instance.SetInfo("Colour Set: Station");
                if(BuyYes == true)
                {   
                    Yes.SetActive(false); No.SetActive(false); CheckStructure.SetActive(false);
                    Money.GetComponent<MoneySystem>().MONEY_CONTROLLER(32);
                    Restart3 = false; BuyYes = false;
                }
                if(BuyNo == true)
                {
                    Audio.Play("Close");
                    Yes.SetActive(false); No.SetActive(false); CheckStructure.SetActive(false);
                    Restart3 = false; BuyNo = false;
                    
                }
            }
                
        }

        //----------------------Prop4------------------------------//

              if(totalDistance5 < 0.08 && totalDistance5 > 0.02 && canBuy == true  && Restart4 == true)

            {
                if(Brought.isBrought4 == true)
                {
                    Money.GetComponent<MoneySystem>().MONEY_CONTROLLER(33);
                    Restart4 = false;
                }
                else if(Brought.isBrought4 == false)
                {
                Yes.SetActive(true); No.SetActive(true); CheckStructure.SetActive(true);
                InfoProperty2.instance.StreetInfo("Property Name: Sang Woo Street");
                InfoProperty2.instance.PriceInfo("Property Price: 100");
                InfoProperty2.instance.SetInfo("Colour Set: Light Blue");
                if(BuyYes == true)
                {
                    Yes.SetActive(false); No.SetActive(false); CheckStructure.SetActive(false);
                    Money.GetComponent<MoneySystem>().MONEY_CONTROLLER(33);
                    Restart4 = false; BuyYes = false;
                }
                if(BuyNo == true)
                {
                    Audio.Play("Close");
                    Yes.SetActive(false); No.SetActive(false); CheckStructure.SetActive(false);
                    Restart4 = false; BuyNo = false;
                }
            }
        }

        //----------------------Prop5------------------------------//

              if(totalDistance6 < 0.08 && totalDistance6 > 0.02 && canBuy == true  && Restart5 == true)

            {
                if(Brought.isBrought5 == true)
                {
                    Money.GetComponent<MoneySystem>().MONEY_CONTROLLER(34);
                    Restart5 = false;
                }
                else if(Brought.isBrought5 == false)
                {
                Yes.SetActive(true); No.SetActive(true); CheckStructure.SetActive(true);
                InfoProperty2.instance.StreetInfo("Property Name: Sae-Byeok");
                InfoProperty2.instance.PriceInfo("Property Price: 100");
                InfoProperty2.instance.SetInfo("Colour Set: Light Blue");
                if(BuyYes == true)
                {
                    Yes.SetActive(false); No.SetActive(false); CheckStructure.SetActive(false);
                    Money.GetComponent<MoneySystem>().MONEY_CONTROLLER(34);
                    Restart5 = false; BuyYes = false;
                }
                if(BuyNo == true)
                {
                    Audio.Play("Close");
                    Yes.SetActive(false); No.SetActive(false); CheckStructure.SetActive(false);
                    Restart5 = false; BuyNo = false;
                }
            }
        }

        //----------------------Prop6------------------------------//

              if(totalDistance7 < 0.08 && totalDistance7 > 0.02 && canBuy == true  && Restart6 == true)

            {
                if(Brought.isBrought6 == true)
                {
                    Money.GetComponent<MoneySystem>().MONEY_CONTROLLER(35);
                    Restart6 = false;
                }
                else if(Brought.isBrought6 == false)
                {
                Yes.SetActive(true); No.SetActive(true); CheckStructure.SetActive(true);
                InfoProperty2.instance.StreetInfo("Property Name: Gi-Hun"); 
                InfoProperty2.instance.PriceInfo("Property Price: 120");
                InfoProperty2.instance.SetInfo("Colour Set: Light Blue");
                if(BuyYes == true)
                {
                    Yes.SetActive(false); No.SetActive(false); CheckStructure.SetActive(false);
                    Money.GetComponent<MoneySystem>().MONEY_CONTROLLER(35);
                    Restart6 = false; BuyYes = false;
                }
                if(BuyNo == true)
                {
                    Audio.Play("Close");
                    Yes.SetActive(false); No.SetActive(false); CheckStructure.SetActive(false);
                    Restart6 = false; BuyNo = false;
                }
            }
        }

        //----------------------Prop7------------------------------//

              if(totalDistance8 < 0.08 && totalDistance8 > 0.02 && canBuy == true  && Restart7 == true)

            {
                if(Brought.isBrought7 == true)
                {
                    Money.GetComponent<MoneySystem>().MONEY_CONTROLLER(36);
                    Restart7 = false;
                }
                else if(Brought.isBrought7 == false)
                {
                Yes.SetActive(true); No.SetActive(true); CheckStructure.SetActive(true);
                InfoProperty2.instance.StreetInfo("Property Name: Holmes Road");
                InfoProperty2.instance.PriceInfo("Property Price: 140");
                InfoProperty2.instance.SetInfo("Colour Set: Pink");
                if(BuyYes == true)
                {
                    Yes.SetActive(false); No.SetActive(false); CheckStructure.SetActive(false);
                    Money.GetComponent<MoneySystem>().MONEY_CONTROLLER(36);
                    Restart7 = false; BuyYes = false;
                }
                if(BuyNo == true)
                {
                    Audio.Play("Close");
                    Yes.SetActive(false); No.SetActive(false); CheckStructure.SetActive(false);
                    Restart7 = false; BuyNo = false;
                }
            }
        }

        //----------------------Prop8------------------------------//


              if(totalDistance9 < 0.08 && totalDistance9 > 0.02 && canBuy == true  && Restart8 == true)

            {
                if(Brought.isBrought8 == true)
                {
                    Money.GetComponent<MoneySystem>().MONEY_CONTROLLER(37);
                    Restart8 = false;
                }
                else if(Brought.isBrought8 == false)
                {
                Yes.SetActive(true); No.SetActive(true); CheckStructure.SetActive(true);
                InfoProperty2.instance.StreetInfo("Property Name: Stark Industries");
                InfoProperty2.instance.PriceInfo("Property Price: 150");
                InfoProperty2.instance.SetInfo("Colour Set: Industry");
                if(BuyYes == true)
                {
                    Yes.SetActive(false); No.SetActive(false); CheckStructure.SetActive(false);
                    Money.GetComponent<MoneySystem>().MONEY_CONTROLLER(37);
                    Restart8 = false; BuyYes = false;
                }
                if(BuyNo == true)
                {
                    Audio.Play("Close");
                    Yes.SetActive(false); No.SetActive(false); CheckStructure.SetActive(false);
                    Restart8 = false; BuyNo = false;
                }
            }
        }

        //----------------------Prop9------------------------------//

              if(totalDistance10 < 0.08 && totalDistance10 > 0.02 && canBuy == true  && Restart9 == true)

            {
                if(Brought.isBrought9 == true)
                {
                    Money.GetComponent<MoneySystem>().MONEY_CONTROLLER(38);
                    Restart9 = false;
                }
                else if(Brought.isBrought9 == false)
                {
                Yes.SetActive(true); No.SetActive(true); CheckStructure.SetActive(true);
                InfoProperty2.instance.StreetInfo("Property Name: Watson Avenue");
                InfoProperty2.instance.PriceInfo("Property Price: 140");
                InfoProperty2.instance.SetInfo("Colour Set: Pink");
                if(BuyYes == true)
                {
                    Yes.SetActive(false); No.SetActive(false); CheckStructure.SetActive(false);
                    Money.GetComponent<MoneySystem>().MONEY_CONTROLLER(38);
                    Restart9 = false; BuyYes = false;
                }
                if(BuyNo == true)
                {
                    Audio.Play("Close");
                    Yes.SetActive(false); No.SetActive(false); CheckStructure.SetActive(false);
                    Restart9 = false; BuyNo = false;
                }
            }
        }

        //----------------------Prop10------------------------------//

              if(totalDistance11 < 0.08 && totalDistance11 > 0.02 && canBuy == true  && Restart10 == true)

            {
                if(Brought.isBrought10 == true)
                {
                    Money.GetComponent<MoneySystem>().MONEY_CONTROLLER(39);
                    Restart10 = false;
                }
                else if(Brought.isBrought10 == false)
                {
                Yes.SetActive(true); No.SetActive(true); CheckStructure.SetActive(true);
                InfoProperty2.instance.StreetInfo("Property Name: Lestrade Lane");
                InfoProperty2.instance.PriceInfo("Property Price: 160");
                InfoProperty2.instance.SetInfo("Colour Set: Pink");
                if(BuyYes == true)
                {
                    Yes.SetActive(false); No.SetActive(false); CheckStructure.SetActive(false);
                    Money.GetComponent<MoneySystem>().MONEY_CONTROLLER(39);
                    Restart10 = false; BuyYes = false;
                }
                if(BuyNo == true)
                {
                    Audio.Play("Close");
                    Yes.SetActive(false); No.SetActive(false); CheckStructure.SetActive(false);
                    Restart10 = false; BuyNo = false;
                }
            }
        }

        //----------------------Prop11------------------------------//

              if(totalDistance12 < 0.08 && totalDistance12 > 0.02 && canBuy == true  && Restart11 == true)

            {
                if(Brought.isBrought11 == true)
                {
                    Money.GetComponent<MoneySystem>().MONEY_CONTROLLER(40);
                    Restart11 = false;
                }
                else if(Brought.isBrought11 == false)
                {
                Yes.SetActive(true); No.SetActive(true); CheckStructure.SetActive(true);
                InfoProperty2.instance.StreetInfo("Property Name: Strange Railway");
                InfoProperty2.instance.PriceInfo("Property Price: 200");
                InfoProperty2.instance.SetInfo("Colour Set: Station");
                if(BuyYes == true)
                {
                    Yes.SetActive(false); No.SetActive(false); CheckStructure.SetActive(false);
                    Money.GetComponent<MoneySystem>().MONEY_CONTROLLER(40);
                    Restart11 = false; BuyYes = false;
                }
                if(BuyNo == true)
                {
                    Audio.Play("Close");
                    Yes.SetActive(false); No.SetActive(false); CheckStructure.SetActive(false);
                    Restart11 = false; BuyNo = false;
                }
            }
        }

        //----------------------Prop12------------------------------//

              if(totalDistance13 < 0.08 && totalDistance13 > 0.02 && canBuy == true  && Restart12 == true)

            {
                if(Brought.isBrought12 == true)
                {
                    Money.GetComponent<MoneySystem>().MONEY_CONTROLLER(41);
                    Restart12 = false;
                }
                else if(Brought.isBrought12 == false)
                {
                Yes.SetActive(true); No.SetActive(true); CheckStructure.SetActive(true);
                InfoProperty2.instance.StreetInfo("Property Name: Potter Manor");
                InfoProperty2.instance.PriceInfo("Property Price: 180");
                InfoProperty2.instance.SetInfo("Colour Set: Orange");
                if(BuyYes == true)
                {
                    Yes.SetActive(false); No.SetActive(false); CheckStructure.SetActive(false);
                    Money.GetComponent<MoneySystem>().MONEY_CONTROLLER(41);
                    Restart12 = false; BuyYes = false;
                }
                if(BuyNo == true)
                {
                    Audio.Play("Close");
                    Yes.SetActive(false); No.SetActive(false); CheckStructure.SetActive(false);
                    Restart12 = false; BuyNo = false;
                }
            }
        }

        //----------------------Prop13------------------------------//

              if(totalDistance14 < 0.08 && totalDistance14 > 0.02 && canBuy == true  && Restart13 == true)

            {
                if(Brought.isBrought13 == true)
                {
                    Money.GetComponent<MoneySystem>().MONEY_CONTROLLER(42);
                    Restart13 = false;
                }
                else if(Brought.isBrought13 == false)
                {
                Yes.SetActive(true); No.SetActive(true); CheckStructure.SetActive(true);
                InfoProperty2.instance.StreetInfo("Property Name: Dumbeldore Valley");
                InfoProperty2.instance.PriceInfo("Property Price: 180");
                InfoProperty2.instance.SetInfo("Colour Set: Orange");
                if(BuyYes == true)
                {
                    Yes.SetActive(false); No.SetActive(false); CheckStructure.SetActive(false);
                    Money.GetComponent<MoneySystem>().MONEY_CONTROLLER(42);
                    Restart13 = false; BuyYes = false;
                }
                if(BuyNo == true)
                {
                    Audio.Play("Close");
                    Yes.SetActive(false); No.SetActive(false); CheckStructure.SetActive(false);
                    Restart13 = false; BuyNo = false;
                }
            }
        }

        //----------------------Prop14------------------------------//

              if(totalDistance15 < 0.08 && totalDistance15 > 0.02 && canBuy == true  && Restart14 == true)

            {
                if(Brought.isBrought14 == true)
                {
                    Money.GetComponent<MoneySystem>().MONEY_CONTROLLER(43);
                    Restart14 = false;
                }
                else if(Brought.isBrought14 == false)
                {
                Yes.SetActive(true); No.SetActive(true); CheckStructure.SetActive(true);
                InfoProperty2.instance.StreetInfo("Property Name: Snape Street");
                InfoProperty2.instance.PriceInfo("Property Price: 200");
                InfoProperty2.instance.SetInfo("Colour Set: Orange");
                if(BuyYes == true)
                {
                    Yes.SetActive(false); No.SetActive(false); CheckStructure.SetActive(false);
                    Money.GetComponent<MoneySystem>().MONEY_CONTROLLER(43);
                    Restart14 = false; BuyYes = false;
                }
                if(BuyNo == true)
                {
                    Audio.Play("Close");
                    Yes.SetActive(false); No.SetActive(false); CheckStructure.SetActive(false);
                    Restart14 = false; BuyNo = false;
                }
            }
        }

        //----------------------Prop15------------------------------//

              if(totalDistance16 < 0.08 && totalDistance16 > 0.02 && canBuy == true  && Restart15 == true)

            {
                if(Brought.isBrought15 == true)
                {
                    Money.GetComponent<MoneySystem>().MONEY_CONTROLLER(44);
                    Restart15 = false;
                }
                else if(Brought.isBrought15 == false)
                {
                Yes.SetActive(true); No.SetActive(true); CheckStructure.SetActive(true);
                InfoProperty2.instance.StreetInfo("Property Name: SkyWalker Boulevard");
                InfoProperty2.instance.PriceInfo("Property Price: 220");
                InfoProperty2.instance.SetInfo("Colour Set: Red");
                if(BuyYes == true)
                {
                    Yes.SetActive(false); No.SetActive(false); CheckStructure.SetActive(false);
                    Money.GetComponent<MoneySystem>().MONEY_CONTROLLER(44);
                    Restart15 = false; BuyYes = false;
                }
                if(BuyNo == true)
                {
                    Audio.Play("Close");
                    Yes.SetActive(false); No.SetActive(false); CheckStructure.SetActive(false);
                    Restart15 = false; BuyNo = false;
                }
            }
        }

        //----------------------Prop16------------------------------//

              if(totalDistance17 < 0.08 && totalDistance17 > 0.02 && canBuy == true  && Restart16 == true)

            {
                if(Brought.isBrought16 == true)
                {
                    Money.GetComponent<MoneySystem>().MONEY_CONTROLLER(45);
                    Restart16 = false;
                }
                else if(Brought.isBrought16 == false)
                {
                Yes.SetActive(true); No.SetActive(true); CheckStructure.SetActive(true);
                InfoProperty2.instance.StreetInfo("Property Name: Kenobi Avenue");
                InfoProperty2.instance.PriceInfo("Property Price: 220");
                InfoProperty2.instance.SetInfo("Colour Set: Red");
                if(BuyYes == true)
                {
                    Yes.SetActive(false); No.SetActive(false); CheckStructure.SetActive(false);
                    Money.GetComponent<MoneySystem>().MONEY_CONTROLLER(45);
                    Restart16 = false; BuyYes = false;
                }
                if(BuyNo == true)
                {
                    Audio.Play("Close");
                    Yes.SetActive(false); No.SetActive(false); CheckStructure.SetActive(false);
                    Restart16 = false; BuyNo = false;
                }
            }
        }

        //----------------------Prop17------------------------------//

              if(totalDistance18 < 0.08 && totalDistance18 > 0.02 && canBuy == true  && Restart17 == true)

            {
                if(Brought.isBrought17 == true)
                {
                    Money.GetComponent<MoneySystem>().MONEY_CONTROLLER(46);
                    Restart17 = false;
                }
                else if(Brought.isBrought17 == false)
                {
                Yes.SetActive(true); No.SetActive(true); CheckStructure.SetActive(true);
                InfoProperty2.instance.StreetInfo("Property Name: Solo Street");
                InfoProperty2.instance.PriceInfo("Property Price: 240");
                InfoProperty2.instance.SetInfo("Colour Set: Red");
                if(BuyYes == true)
                {
                    Yes.SetActive(false); No.SetActive(false); CheckStructure.SetActive(false);
                    Money.GetComponent<MoneySystem>().MONEY_CONTROLLER(46);
                    Restart17 = false; BuyYes = false;
                }
                if(BuyNo == true)
                {
                    Audio.Play("Close");
                    Yes.SetActive(false); No.SetActive(false); CheckStructure.SetActive(false);
                    Restart17 = false; BuyNo = false;
                }
            }
        }

        //----------------------Prop18------------------------------//

              if(totalDistance19 < 0.08 && totalDistance19 > 0.02 && canBuy == true  && Restart18 == true)

            {
                if(Brought.isBrought18 == true)
                {
                    Money.GetComponent<MoneySystem>().MONEY_CONTROLLER(47);
                    Restart18 = false;
                }
                else if(Brought.isBrought18 == false)
                {
                Yes.SetActive(true); No.SetActive(true); CheckStructure.SetActive(true);
                InfoProperty2.instance.StreetInfo("Property Name: Kent Railways");
                InfoProperty2.instance.PriceInfo("Property Price: 200");
                InfoProperty2.instance.SetInfo("Colour Set: Station");
                if(BuyYes == true)
                {
                    Yes.SetActive(false); No.SetActive(false); CheckStructure.SetActive(false);
                    Money.GetComponent<MoneySystem>().MONEY_CONTROLLER(47);
                    Restart18 = false; BuyYes = false;
                }
                if(BuyNo == true)
                {
                    Audio.Play("Close");
                    Yes.SetActive(false); No.SetActive(false); CheckStructure.SetActive(false);
                    Restart18 = false; BuyNo = false;
                }
            }
        }

        //----------------------Prop19------------------------------//

              if(totalDistance20 < 0.08 && totalDistance20 > 0.02 && canBuy == true  && Restart19 == true)

            {
                if(Brought.isBrought19 == true)
                {
                    Money.GetComponent<MoneySystem>().MONEY_CONTROLLER(48);
                    Restart19 = false;
                }
                else if(Brought.isBrought19 == false)
                {
                Yes.SetActive(true); No.SetActive(true); CheckStructure.SetActive(true);
                InfoProperty2.instance.StreetInfo("Property Name: Eleven Boulevard");
                InfoProperty2.instance.PriceInfo("Property Price: 260");
                InfoProperty2.instance.SetInfo("Colour Set: Yellow");
                if(BuyYes == true)
                {
                    Yes.SetActive(false); No.SetActive(false); CheckStructure.SetActive(false);
                    Money.GetComponent<MoneySystem>().MONEY_CONTROLLER(48);
                    Restart19 = false; BuyYes = false;
                }
                if(BuyNo == true)
                {
                    Audio.Play("Close");
                    Yes.SetActive(false); No.SetActive(false); CheckStructure.SetActive(false);
                    Restart19 = false; BuyNo = false;
                }
            }
        }

        //----------------------Prop20------------------------------//

              if(totalDistance21 < 0.08 && totalDistance21 > 0.02 && canBuy == true  && Restart20 == true)

            {
                if(Brought.isBrought20 == true)
                {
                    Money.GetComponent<MoneySystem>().MONEY_CONTROLLER(49);
                    Restart20 = false;
                }
                else if(Brought.isBrought20 == false)
                {
                Yes.SetActive(true); No.SetActive(true); CheckStructure.SetActive(true);
                InfoProperty2.instance.StreetInfo("Property Name: Hopper Way");
                InfoProperty2.instance.PriceInfo("Property Price: 260");
                InfoProperty2.instance.SetInfo("Colour Set: Yellow");
                if(BuyYes == true)
                {
                    Yes.SetActive(false); No.SetActive(false); CheckStructure.SetActive(false);
                    Money.GetComponent<MoneySystem>().MONEY_CONTROLLER(49);
                    Restart20 = false; BuyYes = false;
                }
                if(BuyNo == true)
                {
                    Audio.Play("Close");
                    Yes.SetActive(false); No.SetActive(false); CheckStructure.SetActive(false);
                    Restart20 = false; BuyNo = false;
                }
            }
        }

        //----------------------Prop21------------------------------//

              if(totalDistance22 < 0.08 && totalDistance22 > 0.02 && canBuy == true  && Restart21 == true)

            {
                if(Brought.isBrought21 == true)
                {
                    Money.GetComponent<MoneySystem>().MONEY_CONTROLLER(50);
                    Restart21 = false;
                }
                else if(Brought.isBrought21 == false)
                {
                Yes.SetActive(true); No.SetActive(true); CheckStructure.SetActive(true);
                InfoProperty2.instance.StreetInfo("Property Name: Wayne Industries");
                InfoProperty2.instance.PriceInfo("Property Price: 150");
                InfoProperty2.instance.SetInfo("Colour Set: Industry");
                if(BuyYes == true)
                {
                    Yes.SetActive(false); No.SetActive(false); CheckStructure.SetActive(false);
                    Money.GetComponent<MoneySystem>().MONEY_CONTROLLER(50);
                    Restart21 = false; BuyYes = false;
                }
                if(BuyNo == true)
                {
                    Audio.Play("Close");
                    Yes.SetActive(false); No.SetActive(false); CheckStructure.SetActive(false);
                    Restart21 = false; BuyNo = false;
                }
            }
        }

        //----------------------Prop22------------------------------//

              if(totalDistance23 < 0.08 && totalDistance23 > 0.02 && canBuy == true  && Restart22 == true)

            {
                if(Brought.isBrought22 == true)
                {
                    Money.GetComponent<MoneySystem>().MONEY_CONTROLLER(51);
                    Restart22 = false;
                }
                else if(Brought.isBrought22 == false)
                {
                Yes.SetActive(true); No.SetActive(true); CheckStructure.SetActive(true);
                InfoProperty2.instance.StreetInfo("Property Name: Wheeler Highway");
                InfoProperty2.instance.PriceInfo("Property Price: 280");
                InfoProperty2.instance.SetInfo("Colour Set: Yellow");
                if(BuyYes == true)
                {
                    Yes.SetActive(false); No.SetActive(false); CheckStructure.SetActive(false);
                    Money.GetComponent<MoneySystem>().MONEY_CONTROLLER(51);
                    Restart22 = false; BuyYes = false;
                }
                if(BuyNo == true)
                {
                    Audio.Play("Close");
                    Yes.SetActive(false); No.SetActive(false); CheckStructure.SetActive(false);
                    Restart22 = false; BuyNo = false;
                }
            }
        }

        //----------------------Prop23------------------------------//

              if(totalDistance24 < 0.08 && totalDistance24 > 0.02 && canBuy == true  && Restart23 == true)

            {
                if(Brought.isBrought23 == true)
                {
                    Money.GetComponent<MoneySystem>().MONEY_CONTROLLER(52);
                    Restart23 = false;
                }
                else if(Brought.isBrought23 == false)
                {
                Yes.SetActive(true); No.SetActive(true); CheckStructure.SetActive(true);
                InfoProperty2.instance.StreetInfo("Property Name: Summer Street");
                InfoProperty2.instance.PriceInfo("Property Price: 300");
                InfoProperty2.instance.SetInfo("Colour Set: Green");
                if(BuyYes == true)
                {
                    Yes.SetActive(false); No.SetActive(false); CheckStructure.SetActive(false);
                    Money.GetComponent<MoneySystem>().MONEY_CONTROLLER(52);
                    Restart23 = false; BuyYes = false;
                }
                if(BuyNo == true)
                {
                    Audio.Play("Close");
                    Yes.SetActive(false); No.SetActive(false); CheckStructure.SetActive(false);
                    Restart23 = false; BuyNo = false;
                }
            }
        }

        //----------------------Prop24------------------------------//

              if(totalDistance25 < 0.08 && totalDistance25 > 0.02 && canBuy == true  && Restart24 == true)

            {
                if(Brought.isBrought24 == true)
                {
                    Money.GetComponent<MoneySystem>().MONEY_CONTROLLER(53);
                    Restart24 = false;
                }
                else if(Brought.isBrought24 == false)
                {
                Yes.SetActive(true); No.SetActive(true); CheckStructure.SetActive(true);
                InfoProperty2.instance.StreetInfo("Property Name: Morty Manor");
                InfoProperty2.instance.PriceInfo("Property Price: 300");
                InfoProperty2.instance.SetInfo("Colour Set: Green");
                if(BuyYes == true)
                {
                    Yes.SetActive(false); No.SetActive(false); CheckStructure.SetActive(false);
                    Money.GetComponent<MoneySystem>().MONEY_CONTROLLER(53);
                    Restart24 = false; BuyYes = false;
                }
                if(BuyNo == true)
                {
                    Audio.Play("Close");
                    Yes.SetActive(false); No.SetActive(false); CheckStructure.SetActive(false);
                    Restart24 = false; BuyNo = false;
                }
            }
        }

        //----------------------Prop25------------------------------//   

              if(totalDistance26 < 0.08 && totalDistance26 > 0.02 && canBuy == true  && Restart25 == true)

            {
                if(Brought.isBrought25 == true)
                {
                    Money.GetComponent<MoneySystem>().MONEY_CONTROLLER(54);
                    Restart25 = false;
                }
                else if(Brought.isBrought25 == false)
                {
                Yes.SetActive(true); No.SetActive(true); CheckStructure.SetActive(true);
                InfoProperty2.instance.StreetInfo("Property Name: Ricks Road");
                InfoProperty2.instance.PriceInfo("Property Price: 320");
                InfoProperty2.instance.SetInfo("Colour Set: Green");
                if(BuyYes == true)
                {
                    Yes.SetActive(false); No.SetActive(false); CheckStructure.SetActive(false);
                    Money.GetComponent<MoneySystem>().MONEY_CONTROLLER(54);
                    Restart25 = false; BuyYes = false;
                }
                if(BuyNo == true)
                {
                    Audio.Play("Close");
                    Yes.SetActive(false); No.SetActive(false); CheckStructure.SetActive(false);
                    Restart25 = false; BuyNo = false;
                }
            }
        }

        //----------------------Prop26------------------------------//  

              if(totalDistance27 < 0.08 && totalDistance27 > 0.02 && canBuy == true  && Restart26 == true)

            {
                if(Brought.isBrought26 == true)
                {
                    Money.GetComponent<MoneySystem>().MONEY_CONTROLLER(55);
                    Restart26 = false;
                }
                else if(Brought.isBrought26 == false)
                {
                Yes.SetActive(true); No.SetActive(true); CheckStructure.SetActive(true);
                InfoProperty2.instance.StreetInfo("Property Name: Curry Railway");
                InfoProperty2.instance.PriceInfo("Property Price: 200");
                InfoProperty2.instance.SetInfo("Colour Set: Station");
                if(BuyYes == true)
                {
                    Yes.SetActive(false); No.SetActive(false); CheckStructure.SetActive(false);
                    Money.GetComponent<MoneySystem>().MONEY_CONTROLLER(55);
                    Restart26 = false; BuyYes = false;
                }
                if(BuyNo == true)
                {
                    Audio.Play("Close");
                    Yes.SetActive(false); No.SetActive(false); CheckStructure.SetActive(false);
                    Restart26 = false; BuyNo = false;
                }
            }
        }  

        //----------------------Prop27------------------------------//    

              if(totalDistance28 < 0.08 && totalDistance28 > 0.02 && canBuy == true  && Restart27 == true)

            {
                if(Brought.isBrought27 == true)
                {
                    Money.GetComponent<MoneySystem>().MONEY_CONTROLLER(56);
                    Restart27 = false;
                }
                else if(Brought.isBrought27 == false)
                {
                Yes.SetActive(true); No.SetActive(true); CheckStructure.SetActive(true);
                InfoProperty2.instance.StreetInfo("Property Name: Myers Manor");
                InfoProperty2.instance.PriceInfo("Property Price: 350");
                InfoProperty2.instance.SetInfo("Colour Set: Dark Blue");
                if(BuyYes == true)
                {
                    Yes.SetActive(false); No.SetActive(false); CheckStructure.SetActive(false);
                    Money.GetComponent<MoneySystem>().MONEY_CONTROLLER(56);
                    Restart27 = false; BuyYes = false;
                }
                if(BuyNo == true)
                {
                    Audio.Play("Close");
                    Yes.SetActive(false); No.SetActive(false); CheckStructure.SetActive(false);
                    Restart27 = false; BuyNo = false;
                }
            }
        } 

        //----------------------Prop28------------------------------//  

              if(totalDistance29 < 0.08 && totalDistance29 > 0.02 && canBuy == true  && Restart28 == true)

            {
                if(Brought.isBrought28 == true)
                {
                    Money.GetComponent<MoneySystem>().MONEY_CONTROLLER(57);
                    Restart28 = false;
                }
                else if(Brought.isBrought28 == false)
                {
                Yes.SetActive(true); No.SetActive(true); CheckStructure.SetActive(true);
                InfoProperty2.instance.StreetInfo("Property Name: Strode Street");
                InfoProperty2.instance.PriceInfo("Property Price: 400");
                InfoProperty2.instance.SetInfo("Colour Set: Dark Blue");
                if(BuyYes == true)
                {
                    Yes.SetActive(false); No.SetActive(false); CheckStructure.SetActive(false);
                    Money.GetComponent<MoneySystem>().MONEY_CONTROLLER(57);
                    Restart28 = false; BuyYes = false;
                }
                if(BuyNo == true)
                {
                    Audio.Play("Close");
                    Yes.SetActive(false); No.SetActive(false); CheckStructure.SetActive(false);
                    Restart28 = false; BuyNo = false;
                }
            }
        } 
            
    }    



















    }

    public void RestartPassGo()
    {
        if(totalDistance1 > 0.09)
        {
            passGoRestart = true;
        }
        if(totalDistance2 > 0.08)
        {
            Restart1 = true;
        }
        if(totalDistance3 > 0.08)
        {
            Restart2 = true;
        }
        if(totalDistance4 > 0.08)
        {
            Restart3 = true;
        }
        if(totalDistance5 > 0.08)
        {
            Restart4 = true;
        }
        if(totalDistance6 > 0.08)
        {
            Restart5 = true;
        }
        if(totalDistance7 > 0.08)
        {
            Restart6 = true;
        }
        if(totalDistance8 > 0.08)
        {
            Restart7 = true;
        }
        if(totalDistance9 > 0.08)
        {
            Restart8 = true;
        }
        if(totalDistance10 > 0.08)
        {
            Restart9 = true;
        }
        if(totalDistance11 > 0.08)
        {
            Restart10 = true;
        }
        if(totalDistance12 > 0.08)
        {
            Restart11 = true;
        }
        if(totalDistance13 > 0.08)
        {
            Restart12 = true;
        }
        if(totalDistance14 > 0.08)
        {
            Restart13 = true;
        }
        if(totalDistance15 > 0.08)
        {
            Restart14 = true;
        }
        if(totalDistance16 > 0.08)
        {
            Restart15 = true;
        }
        if(totalDistance17 > 0.08)
        {
            Restart16 = true;
        }
        if(totalDistance18 > 0.08)
        {
            Restart17 = true;
        }
        if(totalDistance19 > 0.08)
        {
            Restart18 = true;
        }
        if(totalDistance20 > 0.08)
        {
            Restart19 = true;
        }
        if(totalDistance21 > 0.08)
        {
            Restart20 = true;
        }
        if(totalDistance22 > 0.08)
        {
            Restart21 = true;
        }
        if(totalDistance23 > 0.08)
        {
            Restart22 = true;
        }
        if(totalDistance24 > 0.08)
        {
            Restart23 = true;
        }
        if(totalDistance25 > 0.08)
        {
            Restart24 = true;
        }
        if(totalDistance26 > 0.08)
        {
            Restart25 = true;
        }
        if(totalDistance27 > 0.08)
        {
            Restart26 = true;
        }
        if(totalDistance28 > 0.08)
        {
            Restart27 = true;
        }
        if(totalDistance29 > 0.08)
        {
            Restart28 = true;
        }
        if(totalDistance30 > 0.08)
        {
            Restart30 = true;
        }
        if(totalDistance31 > 0.08)
        {
            Restart31 = true;
        }
        if(totalDistance32 > 0.08)
        {
            Restart32 = true;
        }
        if(totalDistance33 > 0.08)
        {
            Restart33 = true;
        }
        if(totalDistance34 > 0.08)
        {
            Restart34 = true;
        }
        if(totalDistance35 > 0.08)
        {
            Restart35 = true;
        }
        if(totalDistance36 > 0.08)
        {
            Restart36 = true;
        }
        if(totalDistance37 > 0.08)
        {
            Restart37 = true;
        }
        if(totalDistance38 > 0.08)
        {
            Restart38 = true;
        }

    }



        public IEnumerator CheckStateActive()
    {
        Vector3 prevPos = player2.transform.position;
        yield return new WaitForSeconds(0.2f);
        Vector3 actualPos = player2.transform.position;

        if(prevPos == actualPos)
        {
            canBuy = true;
        }
        if(prevPos != actualPos)
        {
            canBuy = false;
        }

    }

}
