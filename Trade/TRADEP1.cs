using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Created by Caleb

//Checks to see if property is aquired, adds it to the Trade window and allows for it to be traded UNLESS there are houses on the property

//Specific trade request is sent across network and given to TradeActive files to be processed 

public class TRADEP1 : MonoBehaviour
{
    public MoneySystem Money;
    public AudioManager Audio;
    public static TRADEP1 instance;

    public GameObject TradeWindow;
    public GameObject Goldberg;
    public GameObject Quinn;
    public GameObject Sang;
    public GameObject Sae;
    public GameObject Gi;
    public GameObject Holmes;
    public GameObject Watson;
    public GameObject Lestrade;
    public GameObject Harry;
    public GameObject Dumble;
    public GameObject Snape;
    public GameObject SkyWalker;
    public GameObject Kenobi;
    public GameObject Solo;
    public GameObject Eleven;
    public GameObject Wheeler;
    public GameObject Hopper;
    public GameObject Summer;
    public GameObject Morty;
    public GameObject Rick;
    public GameObject Myer;
    public GameObject Strode;

    public GameObject ButtonGoldberg;
    public GameObject ButtonQuinn;
    public GameObject ButtonSang;
    public GameObject ButtonSae;
    public GameObject ButtonGi;
    public GameObject ButtonHolmes;
    public GameObject ButtonWatson;
    public GameObject ButtonLestrade;
    public GameObject ButtonHarry;
    public GameObject ButtonDumble;
    public GameObject ButtonSnape;
    public GameObject ButtonSkyWalker;
    public GameObject ButtonKenobi;
    public GameObject ButtonSolo;
    public GameObject ButtonEleven;
    public GameObject ButtonWheeler;
    public GameObject ButtonHopper;
    public GameObject ButtonSummer;
    public GameObject ButtonMorty;
    public GameObject ButtonRick;
    public GameObject ButtonMyer;
    public GameObject ButtonStrode;

    public GameObject InputGoldberg;
    public GameObject InputQuinn;
    public GameObject InputSang;
    public GameObject InputSae;
    public GameObject InputGi;
    public GameObject InputHolmes;
    public GameObject InputWatson;
    public GameObject InputLestrade;
    public GameObject InputHarry;
    public GameObject InputDumble;
    public GameObject InputSnape;
    public GameObject InputSkyWalker;
    public GameObject InputKenobi;
    public GameObject InputSolo;
    public GameObject InputEleven;
    public GameObject InputWheeler;
    public GameObject InputHopper;
    public GameObject InputSummer;
    public GameObject InputMorty;
    public GameObject InputRick;
    public GameObject InputMyer;
    public GameObject InputStrode;


    public bool ShowCard1 = false;
    public bool ShowCard2 = false;
    public bool ShowCard3 = false;
    public bool ShowCard4 = false;
    public bool ShowCard5 = false;
    public bool ShowCard6 = false;
    public bool ShowCard7 = false;
    public bool ShowCard8 = false;
    public bool ShowCard9 = false;
    public bool ShowCard10 = false;
    public bool ShowCard11 = false;
    public bool ShowCard12 = false;
    public bool ShowCard13 = false;
    public bool ShowCard14 = false;
    public bool ShowCard15 = false;
    public bool ShowCard16 = false;
    public bool ShowCard17 = false;
    public bool ShowCard18 = false;
    public bool ShowCard19 = false;
    public bool ShowCard20 = false;
    public bool ShowCard21 = false;
    public bool ShowCard22 = false;
    public bool ShowCard23 = false;
    public bool ShowCard24 = false;
    public bool ShowCard25 = false;

    public int Count = 0;
    public bool TradeWindowActive = true;

    public void Awake()
    {
        instance = this;
    }

    public void RestartTrade()
    {
        TradeWindow.SetActive(false);
        TradeWindowActive = false;
    }

    public void TradeReactivate()
    {
        TradeWindowActive = true;
    }

    public void Start() 
    {
        Audio = FindObjectOfType<AudioManager>();
        Restart();
        TradeWindow.SetActive(false);
    }

    public void Restart()
    {
        Goldberg.SetActive(false);
        Quinn.SetActive(false);
        Sang.SetActive(false);
        Sae.SetActive(false);
        Gi.SetActive(false);
        Holmes.SetActive(false);
        Watson.SetActive(false);
        Lestrade.SetActive(false);
        Harry.SetActive(false);
        Dumble.SetActive(false);
        Snape.SetActive(false);
        SkyWalker.SetActive(false);
        Kenobi.SetActive(false);
        Solo.SetActive(false);
        Eleven.SetActive(false);
        Wheeler.SetActive(false);
        Hopper.SetActive(false);
        Summer.SetActive(false);
        Morty.SetActive(false);
        Rick.SetActive(false);
        Myer.SetActive(false);
        Strode.SetActive(false);

        ButtonGoldberg.SetActive(false);
        ButtonQuinn.SetActive(false);
        ButtonSang.SetActive(false);
        ButtonSae.SetActive(false);
        ButtonGi.SetActive(false);
        ButtonHolmes.SetActive(false);
        ButtonWatson.SetActive(false);
        ButtonLestrade.SetActive(false);
        ButtonHarry.SetActive(false);
        ButtonDumble.SetActive(false);
        ButtonSnape.SetActive(false);
        ButtonSkyWalker.SetActive(false);
        ButtonKenobi.SetActive(false);
        ButtonSolo.SetActive(false);
        ButtonEleven.SetActive(false);
        ButtonWheeler.SetActive(false);
        ButtonHopper.SetActive(false);
        ButtonSummer.SetActive(false);
        ButtonMorty.SetActive(false);
        ButtonRick.SetActive(false);
        ButtonMyer.SetActive(false);
        ButtonStrode.SetActive(false);

        InputGoldberg.SetActive(false);
        InputQuinn.SetActive(false);
        InputSang.SetActive(false);
        InputSae.SetActive(false);
        InputGi.SetActive(false);
        InputHolmes.SetActive(false);
        InputWatson.SetActive(false);
        InputLestrade.SetActive(false);
        InputHarry.SetActive(false);
        InputDumble.SetActive(false);
        InputSnape.SetActive(false);
        InputSkyWalker.SetActive(false);
        InputKenobi.SetActive(false);
        InputSolo.SetActive(false);
        InputEleven.SetActive(false);
        InputWheeler.SetActive(false);
        InputHopper.SetActive(false);
        InputSummer.SetActive(false);
        InputMorty.SetActive(false);
        InputRick.SetActive(false);
        InputMyer.SetActive(false);
        InputStrode.SetActive(false);
    }




    public void Update()
    {

        if(Money.P1IsMine1 == true)
        {
            ShowCard1 = true;
        }
        if(Money.P1IsMine1 == false)
        {
            ShowCard1 = false;
        }

        if(Money.P1IsMine2 == true)
        {
            ShowCard2 = true;
        }
        if(Money.P1IsMine2 == false)
        {
            ShowCard2 = false;
        }

        if(Money.P1IsMine4 == true)
        {
            ShowCard3 = true;
        }
        if(Money.P1IsMine4 == false)
        {
            ShowCard3 = false;
        }

        if(Money.P1IsMine5 == true)
        {
            ShowCard4 = true;
        }
        if(Money.P1IsMine5 == false)
        {
            ShowCard4 = false;
        }

        if(Money.P1IsMine6 == true)
        {
            ShowCard5 = true;
        }
        if(Money.P1IsMine6 == false)
        {
            ShowCard5 = false;
        }

        if(Money.P1IsMine7 == true)
        {
            ShowCard6 = true;
        }
        if(Money.P1IsMine7 == false)
        {
            ShowCard6 = false;
        }

        if(Money.P1IsMine9 == true)
        {
            ShowCard7 = true;
        }
        if(Money.P1IsMine9 == false)
        {
            ShowCard7 = false;
        }

        if(Money.P1IsMine10 == true)
        {
            ShowCard8 = true;
        }
        if(Money.P1IsMine10 == false)
        {
            ShowCard8 = false;
        }

        if(Money.P1IsMine12 == true)
        {
            ShowCard9 = true;
        }
        if(Money.P1IsMine12 == false)
        {
            ShowCard9 = false;
        }

        if(Money.P1IsMine13 == true)
        {
            ShowCard10 = true;
        }
        if(Money.P1IsMine13 == false)
        {
            ShowCard10 = false;
        }

        if(Money.P1IsMine14 == true)
        {
            ShowCard11 = true;
        }
        if(Money.P1IsMine14 == false)
        {
            ShowCard11 = false;
        }

        if(Money.P1IsMine15 == true)
        {
            ShowCard12 = true;
        }
        if(Money.P1IsMine15 == false)
        {
            ShowCard12 = false;
        }

        if(Money.P1IsMine16 == true)
        {
            ShowCard13 = true;
        }
        if(Money.P1IsMine16 == false)
        {
            ShowCard13 = false;
        }

        if(Money.P1IsMine17 == true)
        {
            ShowCard14 = true;
        }
        if(Money.P1IsMine17 == false)
        {
            ShowCard14 = false;
        }

        if(Money.P1IsMine19 == true)
        {
            ShowCard15 = true;
        }
        if(Money.P1IsMine19 == false)
        {
            ShowCard15 = false;
        }

        if(Money.P1IsMine20 == true)
        {
            ShowCard16 = true;
        }
        if(Money.P1IsMine20 == false)
        {
            ShowCard16 = false;
        }

        if(Money.P1IsMine22 == true)
        {
            ShowCard17 = true;
        }
        if(Money.P1IsMine22 == false)
        {
            ShowCard17 = false;
        }

        if(Money.P1IsMine23 == true)
        {
            ShowCard18 = true;
        }
        if(Money.P1IsMine23 == false)
        {
            ShowCard18 = false;
        }

        if(Money.P1IsMine24 == true)
        {
            ShowCard19 = true;
        }
        if(Money.P1IsMine24 == false)
        {
            ShowCard19 = false;
        }

        if(Money.P1IsMine25 == true)
        {
            ShowCard20 = true;
        }
        if(Money.P1IsMine25 == false)
        {
            ShowCard20 = false;
        }

        if(Money.P1IsMine27 == true)
        {
            ShowCard21 = true;
        }
        if(Money.P1IsMine27 == false)
        {
            ShowCard21 = false;
        }

        if(Money.P1IsMine28 == true)
        {
            ShowCard22 = true;
        }
        if(Money.P1IsMine28 == false)
        {
            ShowCard22 = false;
        }

    }



    public void ButtonOpen()
    {
        if(TradeWindowActive == true)
        {
            Update();
            TradeWindow.SetActive(true);
            Restart();
            CheckCardsShowPage1();
            Count = 1;
            Audio.Play("Press");
        }
        if(TradeWindowActive == false)
        {
            Debug.Log("Trade in progress!");
        }
    }

    public void ButtonPageRight()
    {
        Audio.Play("Press");
        if(Count == 1)
        {
            CheckCardsShowPage2();
        }

        if(Count == 2)
        {
            CheckCardsShowPage3();
        }
        if(Count == 3)
        {
            CheckCardsShowPage4();
        }
        if(Count == 4)
        {
           CheckCardsShowPage5(); 
        }
        if(Count == 5)
        {
           CheckCardsShowPage6(); 
        }
        if(Count == 6)
        {
            CheckCardsShowPage7(); 
        }
        if(Count == 7)
        {
            CheckCardsShowPage8(); 
        }
        if(Count > 7 )
        {
            Count = 7;
        }
        
        Count++;
    }



    public void ButtonPageLeft()
    {
        Count--;
        Audio.Play("Press");
        if(Count == 6)
        {
            CheckCardsShowPage7Backwards();
        }
        if(Count == 5)
        {
            CheckCardsShowPage6Backwards();
        }
        if(Count == 4)
        {
            CheckCardsShowPage5Backwards();
        }
        if(Count == 3)
        {
            CheckCardsShowPage4Backwards();
        }
        if(Count == 2)
        {
            CheckCardsShowPage3Backwards();
        }
        if(Count == 1)
        {
            CheckCardsShowPage2Backwards();
        }
        if(Count == 0)
        {
            CheckCardsShowPage1Backwards();
        }
        if(Count < 0)
        {
            Count = 0;
        }
    }

    public void ButtonClose()
    {
        Audio.Play("Close");
        Start();
        Count = 0;
    }




    public void CheckCardsShowPage1()
    {
        if(ShowCard1 == true)
        {
            Goldberg.SetActive(true);
            InputGoldberg.SetActive(true);
            ButtonGoldberg.SetActive(true);
        }

        if(ShowCard2 == true)
        {
            Quinn.SetActive(true);
            InputQuinn.SetActive(true);
            ButtonQuinn.SetActive(true);
            
        }
    }

    public void CheckCardsShowPage2()
    {
        if(ShowCard1 == true)
        {
            Goldberg.SetActive(false);
            InputGoldberg.SetActive(false);
            ButtonGoldberg.SetActive(false);
        }

        if(ShowCard2 == true)
        {
            Quinn.SetActive(false);
            InputQuinn.SetActive(false);
            ButtonQuinn.SetActive(false);
        }

        if(ShowCard3 == true)
        {
            Sang.SetActive(true);
            InputSang.SetActive(true);
            ButtonSang.SetActive(true);
        }

        if(ShowCard4 == true)
        {
            Sae.SetActive(true);
            InputSae.SetActive(true);
            ButtonSae.SetActive(true);
        }

        if(ShowCard5 == true)
        {
            Gi.SetActive(true);
            InputGi.SetActive(true);
            ButtonGi.SetActive(true);
        }
    }

    public void CheckCardsShowPage3()
    {
        if(ShowCard3 == true)
        {
            Sang.SetActive(false);
            InputSang.SetActive(false);
            ButtonSang.SetActive(false);
        }

        if(ShowCard4 == true)
        {
            Sae.SetActive(false);
            InputSae.SetActive(false);
            ButtonSae.SetActive(false);
        }

        if(ShowCard5 == true)
        {
            Gi.SetActive(false);
            InputGi.SetActive(false);
            ButtonGi.SetActive(false);
        }

        if(ShowCard6 == true)
        {
            Holmes.SetActive(true);
            InputHolmes.SetActive(true);
            ButtonHolmes.SetActive(true);
        }

        if(ShowCard7 == true)
        {
            Watson.SetActive(true);
            InputWatson.SetActive(true);
            ButtonWatson.SetActive(true);
        }

        if(ShowCard8 == true)
        {
            Lestrade.SetActive(true);
            InputLestrade.SetActive(true);
            ButtonLestrade.SetActive(true);
        }
    }

    public void CheckCardsShowPage4()
    {
        if(ShowCard6 == true)
        {
            Holmes.SetActive(false);
            InputHolmes.SetActive(false);
            ButtonHolmes.SetActive(false);
        }

        if(ShowCard7 == true)
        {
            Watson.SetActive(false);
            InputWatson.SetActive(false);
            ButtonWatson.SetActive(false);
        }

        if(ShowCard8 == true)
        {
            Lestrade.SetActive(false);
            InputLestrade.SetActive(false);
            ButtonLestrade.SetActive(false);
        }

        if(ShowCard9 == true)
        {
            Harry.SetActive(true);
            InputHarry.SetActive(true);
            ButtonHarry.SetActive(true);
        }

        if(ShowCard10 == true)
        {
            Dumble.SetActive(true);
            InputDumble.SetActive(true);
            ButtonDumble.SetActive(true);
        }

        if(ShowCard11 == true)
        {
            Snape.SetActive(true);
            InputSnape.SetActive(true);
            ButtonSnape.SetActive(true);
        }
    }

    public void CheckCardsShowPage5()
    {
        if(ShowCard9 == true)
        {
            Harry.SetActive(false);
            InputHarry.SetActive(false);
            ButtonHarry.SetActive(false);
        }

        if(ShowCard10 == true)
        {
            Dumble.SetActive(false);
            InputDumble.SetActive(false);
            ButtonDumble.SetActive(false);
        }

        if(ShowCard11 == true)
        {
            Snape.SetActive(false);
            InputSnape.SetActive(false);
            ButtonSnape.SetActive(false);
        }

        if(ShowCard12 == true)
        {
            SkyWalker.SetActive(true);
            InputSkyWalker.SetActive(true);
            ButtonSkyWalker.SetActive(true);
        }

        if(ShowCard13 == true)
        {
            Kenobi.SetActive(true);
            InputKenobi.SetActive(true);
            ButtonKenobi.SetActive(true);
        }

        if(ShowCard14 == true)
        {
            Solo.SetActive(true);
            InputSolo.SetActive(true);
            ButtonSolo.SetActive(true);
        }
    }

    public void CheckCardsShowPage6()
    {
        if(ShowCard12 == true)
        {
            SkyWalker.SetActive(false);
            InputSkyWalker.SetActive(false);
            ButtonSkyWalker.SetActive(false);
        }

        if(ShowCard13 == true)
        {
            Kenobi.SetActive(false);
            InputKenobi.SetActive(false);
            ButtonKenobi.SetActive(false);
        }

        if(ShowCard14 == true)
        {
            Solo.SetActive(false);
            InputSolo.SetActive(false);
            ButtonSolo.SetActive(false);
        }

        if(ShowCard15 == true)
        {
            Eleven.SetActive(true);
            InputEleven.SetActive(true);
            ButtonEleven.SetActive(true);
        }

        if(ShowCard16 == true)
        {
            Hopper.SetActive(true);
            InputHopper.SetActive(true);
            ButtonHopper.SetActive(true);
        }

        if(ShowCard17 == true)
        {
            Wheeler.SetActive(true);
            InputWheeler.SetActive(true);
            ButtonWheeler.SetActive(true);
        }
    }

    public void CheckCardsShowPage7()
    {
        if(ShowCard15 == true)
        {
            Eleven.SetActive(false);
            InputEleven.SetActive(false);
            ButtonEleven.SetActive(false);
        }

        if(ShowCard16 == true)
        {
            Hopper.SetActive(false);
            InputHopper.SetActive(false);
            ButtonHopper.SetActive(false);
        }

        if(ShowCard17 == true)
        {
            Wheeler.SetActive(false);
            InputWheeler.SetActive(false);
            ButtonWheeler.SetActive(false);
        }

        if(ShowCard18 == true)
        {
            Summer.SetActive(true);
            InputSummer.SetActive(true);
            ButtonSummer.SetActive(true);
        }

        if(ShowCard19 == true)
        {
            Morty.SetActive(true);
            InputMorty.SetActive(true);
            ButtonMorty.SetActive(true);
        }

        if(ShowCard20 == true)
        {
            Rick.SetActive(true);
            InputRick.SetActive(true);
            ButtonRick.SetActive(true);
        }
    }

    public void CheckCardsShowPage8()
    {
        if(ShowCard18 == true)
        {
            Summer.SetActive(false);
            InputSummer.SetActive(false);
            ButtonSummer.SetActive(false);
        }

        if(ShowCard19 == true)
        {
            Morty.SetActive(false);
            InputMorty.SetActive(false);
            ButtonMorty.SetActive(false);
        }

        if(ShowCard20 == true)
        {
            Rick.SetActive(false);
            InputRick.SetActive(false);
            ButtonRick.SetActive(false);
        }

        if(ShowCard21 == true)
        {
            Myer.SetActive(true);
            InputMyer.SetActive(true);
            ButtonMyer.SetActive(true);
        }

        if(ShowCard22 == true)
        {
            Strode.SetActive(true);
            InputStrode.SetActive(true);
            ButtonStrode.SetActive(true);
        }
    }





    public void CheckCardsShowPage7Backwards()
    {
        if(ShowCard18 == true)
        {
            Summer.SetActive(true);
            InputSummer.SetActive(true);
            ButtonSummer.SetActive(true);
        }

        if(ShowCard19 == true)
        {
            Morty.SetActive(true);
            InputMorty.SetActive(true);
            ButtonMorty.SetActive(true);
        }

        if(ShowCard20 == true)
        {
            Rick.SetActive(true);
            InputRick.SetActive(true);
            ButtonRick.SetActive(true);
        }

        if(ShowCard21 == true)
        {
            Myer.SetActive(false);
            InputMyer.SetActive(false);
            ButtonMyer.SetActive(false);
        }

        if(ShowCard22 == true)
        {
            Strode.SetActive(false);
            InputStrode.SetActive(false);
            ButtonStrode.SetActive(false);
        }
    }

    public void CheckCardsShowPage6Backwards()
    {
        if(ShowCard15 == true)
        {
            Eleven.SetActive(true);
            InputEleven.SetActive(true);
            ButtonEleven.SetActive(true);
        }

        if(ShowCard16 == true)
        {
            Hopper.SetActive(true);
            InputHopper.SetActive(true);
            ButtonHopper.SetActive(true);
        }

        if(ShowCard17 == true)
        {
            Wheeler.SetActive(true);
            InputWheeler.SetActive(true);
            ButtonWheeler.SetActive(true);
        }

        if(ShowCard18 == true)
        {
            Summer.SetActive(false);
            InputSummer.SetActive(false);
            ButtonSummer.SetActive(false);
        }

        if(ShowCard19 == true)
        {
            Morty.SetActive(false);
            InputMorty.SetActive(false);
            ButtonMorty.SetActive(false);
        }

        if(ShowCard20 == true)
        {
            Rick.SetActive(false);
            InputRick.SetActive(false);
            ButtonRick.SetActive(false);
        }
    }

    public void CheckCardsShowPage5Backwards()
    {
        if(ShowCard12 == true)
        {
            SkyWalker.SetActive(true);
            InputSkyWalker.SetActive(true);
            ButtonSkyWalker.SetActive(true);
        }

        if(ShowCard13 == true)
        {
            Kenobi.SetActive(true);
            InputKenobi.SetActive(true);
            ButtonKenobi.SetActive(true);
        }

        if(ShowCard14 == true)
        {
            Solo.SetActive(true);
            InputSolo.SetActive(true);
            ButtonSolo.SetActive(true);
        }

        if(ShowCard15 == true)
        {
            Eleven.SetActive(false);
            InputEleven.SetActive(false);
            ButtonEleven.SetActive(false);
        }

        if(ShowCard16 == true)
        {
            Hopper.SetActive(false);
            InputHopper.SetActive(false);
            ButtonHopper.SetActive(false);
        }

        if(ShowCard17 == true)
        {
            Wheeler.SetActive(false);
            InputWheeler.SetActive(false);
            ButtonWheeler.SetActive(false);
        }
    }

    public void CheckCardsShowPage4Backwards()
    {
        if(ShowCard9 == true)
        {
            Harry.SetActive(true);
            InputHarry.SetActive(true);
            ButtonHarry.SetActive(true);
        }

        if(ShowCard10 == true)
        {
            Dumble.SetActive(true);
            InputDumble.SetActive(true);
            ButtonDumble.SetActive(true);
        }

        if(ShowCard11 == true)
        {
            Snape.SetActive(true);
            InputSnape.SetActive(true);
            ButtonSnape.SetActive(true);
        }

        if(ShowCard12 == true)
        {
            SkyWalker.SetActive(false);
            InputSkyWalker.SetActive(false);
            ButtonSkyWalker.SetActive(false);
        }

        if(ShowCard13 == true)
        {
            Kenobi.SetActive(false);
            InputKenobi.SetActive(false);
            ButtonKenobi.SetActive(false);
        }

        if(ShowCard14 == true)
        {
            Solo.SetActive(false);
            InputSolo.SetActive(false);
            ButtonSolo.SetActive(false);
        }
    }

    public void CheckCardsShowPage3Backwards()
    {
        if(ShowCard6 == true)
        {
            Holmes.SetActive(true);
            InputHolmes.SetActive(true);
            ButtonHolmes.SetActive(true);
        }

        if(ShowCard7 == true)
        {
            Watson.SetActive(true);
            InputWatson.SetActive(true);
            ButtonWatson.SetActive(true);
        }

        if(ShowCard8 == true)
        {
            Lestrade.SetActive(true);
            InputLestrade.SetActive(true);
            ButtonLestrade.SetActive(true);
        }

        if(ShowCard9 == true)
        {
            Harry.SetActive(false);
            InputHarry.SetActive(false);
            ButtonHarry.SetActive(false);
        }

        if(ShowCard10 == true)
        {
            Dumble.SetActive(false);
            InputDumble.SetActive(false);
            ButtonDumble.SetActive(false);
        }

        if(ShowCard11 == true)
        {
            Snape.SetActive(false);
            InputSnape.SetActive(false);
            ButtonSnape.SetActive(false);
        }
    }

    public void CheckCardsShowPage2Backwards()
    {
        if(ShowCard3 == true)
        {
            Sang.SetActive(true);
            InputSang.SetActive(true);
            ButtonSang.SetActive(true);
        }

        if(ShowCard4 == true)
        {
            Sae.SetActive(true);
            InputSae.SetActive(true);
            ButtonSae.SetActive(true);
        }

        if(ShowCard5 == true)
        {
            Gi.SetActive(true);
            InputGi.SetActive(true);
            ButtonGi.SetActive(true);
        }

        if(ShowCard6 == true)
        {
            Holmes.SetActive(false);
            InputHolmes.SetActive(false);
            ButtonHolmes.SetActive(false);
        }

        if(ShowCard7 == true)
        {
            Watson.SetActive(false);
            InputWatson.SetActive(false);
            ButtonWatson.SetActive(false);
        }

        if(ShowCard8 == true)
        {
            Lestrade.SetActive(false);
            InputLestrade.SetActive(false);
            ButtonLestrade.SetActive(false);
        }
    }

    public void CheckCardsShowPage1Backwards()
    {
        if(ShowCard1 == true)
        {
            Goldberg.SetActive(true);
            InputGoldberg.SetActive(true);
            ButtonGoldberg.SetActive(true);
        }

        if(ShowCard2 == true)
        {
            Quinn.SetActive(true);
            InputQuinn.SetActive(true);
            ButtonQuinn.SetActive(true);
        }

        if(ShowCard3 == true)
        {
            Sang.SetActive(false);
            InputSang.SetActive(false);
            ButtonSang.SetActive(false);
        }

        if(ShowCard4 == true)
        {
            Sae.SetActive(false);
            InputSae.SetActive(false);
            ButtonSae.SetActive(false);
        }

        if(ShowCard5 == true)
        {
            Gi.SetActive(false);
            InputGi.SetActive(false);
            ButtonGi.SetActive(false);
        }
    }

}
