using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneySTuff : MonoBehaviour
{

    [SerializeField]
    public int rawProduction;
    public int realProduction;
    public int maxCanTransport;
    public int maxCanSell;
    public int sold;
    public int selling;
    private int surplus;

    public Text moneyText;
    public Text soldText;
    public Text farmText;
    public Text truckText;
    public Text storeText;
    public Text cookText;
    public Text sellingText;
    public Text rawProductionText;
    public Text realProductionText;
    public Text surplusText;

    private float time = 0.0f;
    private float nextActionTime = 0.0f;
    public float period = 0.01f;




    // Start is called before the first frame update
    void Start()
    {
        GameManager.Instance.Money = 1000000000000;

        //Raw Production Prices
        GameManager.Instance.gSRunnerPrice = 7;
        GameManager.Instance.bGDeliveryPrice = 100;
        GameManager.Instance.lSCompany = 10000;
        GameManager.Instance.FarmPrice = 500000;
        GameManager.Instance.mPFarmPrice = 10000000;

        //StoreFront Prices
        GameManager.Instance.foodTruckPrice = 10;
        GameManager.Instance.mFoodCourtStand = 90;
        GameManager.Instance.lRDivePrice = 800;
        GameManager.Instance.iMRestaurantPrice = 15000;
        GameManager.Instance.lRestaurantPrice = 100000;
        GameManager.Instance.StorePrice = 1200000;
        GameManager.Instance.flagShipPrice = 20000000;


        //Transport Prices
        GameManager.Instance.fCarPrice = 5;
        GameManager.Instance.hDriverPrice = 120;
        GameManager.Instance.sVanPrice = 5000;
        GameManager.Instance.mTruckPrice = 1000000;
        GameManager.Instance.lTruckPrice = 50000000;

        //Upgrade Prices 
        GameManager.Instance.breakfastMenu = false;
        GameManager.Instance.tHours = false;
        GameManager.Instance.valueMenu = false;
        GameManager.Instance.optimizedSN = false;
        GameManager.Instance.pesticides = false;
        GameManager.Instance.GMO = false;
        GameManager.Instance.growthHoromones = false;

        GameManager.Instance.breakfastMenuPrice = 1000000;
        GameManager.Instance.tHoursPrice = 70000;
        GameManager.Instance.valueMenuPrice = 500000;
        GameManager.Instance.optimizedSNPrice = 9000;
        GameManager.Instance.pesticidesPrice = 470000;
        GameManager.Instance.GMOPrice = 100000;
        GameManager.Instance.growthHoromonesPrice = 639000;

    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextActionTime)
        {
            nextActionTime = Time.time + period;

            moneyText.text = GameManager.Instance.Money + " " + "Dollars";
            soldText.text = sold + "Sandwhiches Sold";
            farmText.text = GameManager.Instance.Farms + "Farms " + "Buy Another for" + " " + GameManager.Instance.FarmPrice;
            storeText.text = GameManager.Instance.Stores + "Stores " + "Buy Another for" + " " + GameManager.Instance.StorePrice;
            truckText.text = GameManager.Instance.LTrucks + "Trucks" + "Buy Another for" + " " + GameManager.Instance.lTruckPrice;
            cookText.text = "Cook/Sell 1 Burger at home ";
            sellingText.text = "Selling " + selling + " per second";
            rawProductionText.text = "raw Production " + rawProduction;
            realProductionText.text = "real Production  " + realProduction;
            surplusText.text = "Surplus " + surplus;


            rawProduction = (GameManager.Instance.Farms * 10);
            maxCanTransport = (GameManager.Instance.LTrucks * 100);
            maxCanSell = (GameManager.Instance.Stores * 200);

            if (rawProduction > maxCanTransport)
            {
                //surplus += rawProduction - maxCanTransport;
                realProduction = maxCanTransport;

            }
            if (rawProduction <= maxCanTransport)
            {
                realProduction = rawProduction;
            }
            if (maxCanTransport > maxCanSell)
            {
                //surplus += maxCanSell - maxCanTransport;
                //sold += maxCanSell;
                selling = maxCanSell;
            }
            if (maxCanTransport <= maxCanSell)
            {
                //sold += maxCanTransport;
                selling = maxCanTransport;
            }


            GameManager.Instance.Money += selling * 5;

            sold += selling;

        }
    }

    IEnumerator gameRunner()
    {
        for (; ; )
        {

            yield return new WaitForSeconds(1f);
        }
    }





    //Button Management



    public void gSRButton()
    {
        if (GameManager.Instance.Money >= GameManager.Instance.gSRunnerPrice)
        {
            GameManager.Instance.Money -= GameManager.Instance.gSRunnerPrice;
            GameManager.Instance.gSRunner += 1;
            GameManager.Instance.gSRunnerPrice = (10 * (10 ^ GameManager.Instance.gSRunner));
        }
    }
    public void bGDeliveryButton()
    {
        if (GameManager.Instance.Money >= GameManager.Instance.bGDeliveryPrice)
        {
            GameManager.Instance.Money -= GameManager.Instance.bGDeliveryPrice;
            GameManager.Instance.bGDelivery += 1;
            GameManager.Instance.bGDeliveryPrice = (10 * (10 ^ GameManager.Instance.bGDelivery));
        }
    }
    public void lsCompanyButton()
    {
        if (GameManager.Instance.Money >= GameManager.Instance.lSCompanyPrice)
        {
            GameManager.Instance.Money -= GameManager.Instance.lSCompanyPrice;
            GameManager.Instance.lSCompany += 1;
            GameManager.Instance.lSCompanyPrice = (10 * (10 ^ GameManager.Instance.lSCompany));
        }
    }
    
    public void farmButton()
    {
        if (GameManager.Instance.Money >= GameManager.Instance.FarmPrice)
        {
            GameManager.Instance.Money -= GameManager.Instance.FarmPrice;
            GameManager.Instance.Farms += 1;
            GameManager.Instance.FarmPrice = (10 * (10 ^ GameManager.Instance.Farms));
        }

    }

    public void mPFarmButton()
    {
        if (GameManager.Instance.Money >= GameManager.Instance.mPFarmPrice)
        {
            GameManager.Instance.Money -= GameManager.Instance.mPFarmPrice;
            GameManager.Instance.mPFarm += 1;
            GameManager.Instance.mPFarmPrice = (10 * (10 ^ GameManager.Instance.mPFarm));
        }
    }


   public void foodTruckButton()
    {
        if(GameManager.Instance.Money >= GameManager.Instance.foodTruckPrice)
        {
            GameManager.Instance.Money -= GameManager.Instance.foodTruckPrice;
            GameManager.Instance.foodTruck += 1;
            GameManager.Instance.foodTruckPrice = (10 * (10 ^ GameManager.Instance.foodTruck));
        }
    }
    
    public void mFoodCourtStandButton()
    {
        if (GameManager.Instance.Money >= GameManager.Instance.mFoodCourtStandPrice)
        {
            GameManager.Instance.Money -= GameManager.Instance.mFoodCourtStandPrice;
            GameManager.Instance.mFoodCourtStand += 1;
            GameManager.Instance.mFoodCourtStandPrice = (10 * (10 ^ GameManager.Instance.mFoodCourtStand));
        }
    }

    public void lRDiveButton()
    {
        if (GameManager.Instance.Money >= GameManager.Instance.lRDivePrice)
        {
            GameManager.Instance.Money -= GameManager.Instance.lRDivePrice;
            GameManager.Instance.lRDive += 1;
            GameManager.Instance.lRDivePrice = (10 * (10 ^ GameManager.Instance.lRDive));
        }
    }

    public void iMRestaurantButton()
    {
        if (GameManager.Instance.Money >= GameManager.Instance.iMRestaurantPrice)
        {
            GameManager.Instance.Money -= GameManager.Instance.iMRestaurantPrice;
            GameManager.Instance.iMRestaurant += 1;
            GameManager.Instance.iMRestaurantPrice = (10 * (10 ^ GameManager.Instance.iMRestaurant));
        }
    }

    public void lRestaurantButton()
    {
        if (GameManager.Instance.Money >= GameManager.Instance.lRestaurantPrice)
        {
            GameManager.Instance.Money -= GameManager.Instance.lRestaurantPrice;
            GameManager.Instance.lRestaurant += 1;
            GameManager.Instance.lRestaurantPrice = (10 * (10 ^ GameManager.Instance.lRestaurant));
        }
    }


    public void storeButton()
    {
        if (GameManager.Instance.Money >= GameManager.Instance.StorePrice)
        {
            GameManager.Instance.Money -= GameManager.Instance.StorePrice;
            GameManager.Instance.Stores += 1;
            GameManager.Instance.StorePrice = (10 * (10 ^ GameManager.Instance.Stores));
        }
    }

    public void flagShipsButton()
    {
        if (GameManager.Instance.Money >= GameManager.Instance.flagShipPrice)
        {
            GameManager.Instance.Money -= GameManager.Instance.flagShipPrice;
            GameManager.Instance.flagShips += 1;
            GameManager.Instance.flagShipPrice = (10* (10 ^ GameManager.Instance.flagShips));
        }
    }


    public void truckButton()
    {
        if (GameManager.Instance.Money >= GameManager.Instance.lTruckPrice)
        {
            GameManager.Instance.Money -= GameManager.Instance.lTruckPrice;
            GameManager.Instance.LTrucks += 1;
            GameManager.Instance.lTruckPrice = (10 * (10 ^ GameManager.Instance.LTrucks));
        }

    }

    public void fCarButton()
    {
        if (GameManager.Instance.Money >= GameManager.Instance.fCarPrice)
        {
            GameManager.Instance.Money -= GameManager.Instance.fCarPrice;
            GameManager.Instance.fCar += 1;
            GameManager.Instance.fCarPrice = (10 * (10 ^ GameManager.Instance.fCar));
        }
    }

    public void hDriverButton()
    {
        if (GameManager.Instance.Money >= GameManager.Instance.hDriverPrice)
        {
            GameManager.Instance.Money -= GameManager.Instance.hDriverPrice;
            GameManager.Instance.hDriver += 1;
            GameManager.Instance.hDriverPrice = (10 * (10 ^ GameManager.Instance.hDriver));
        }
    }

    public void sVanButton()
    {
        if (GameManager.Instance.Money >= GameManager.Instance.sVanPrice)
        {
            GameManager.Instance.Money -= GameManager.Instance.sVanPrice;
            GameManager.Instance.sVan += 1;
            GameManager.Instance.sVanPrice = (10 * (10 ^ GameManager.Instance.sVan));
        }
    }

    public void sTruckButton()
    {
        if (GameManager.Instance.Money >= GameManager.Instance.sTruckPrice)
        {
            GameManager.Instance.Money -= GameManager.Instance.sTruckPrice;
            GameManager.Instance.sTruckPrice += 1;
            GameManager.Instance.sTruckPrice = (10 * (10 ^ GameManager.Instance.sTruck));
        }
    }

    public void mTruckButton()
    {
        if (GameManager.Instance.Money >= GameManager.Instance.mTruckPrice)
        {
            GameManager.Instance.Money -= GameManager.Instance.mTruckPrice;
            GameManager.Instance.mTruck += 1;
            GameManager.Instance.mTruckPrice = (10 * (10 ^ GameManager.Instance.mTruck));
        }
    }



    public void cookButton()
    {
        sold++;
        GameManager.Instance.Money += 5;
    }
    
    

}
