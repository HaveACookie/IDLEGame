using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    private static GameManager _instance;
    public static GameManager Instance

    {
        get
        {
            //Checks to see if manager exists and creates an instance if it doesn't exist
            if (_instance == null)
            {
                GameObject go = new GameObject("GameManager");
                go.AddComponent<GameManager>();



            }
            return _instance;
        }

    }

    //Uses Accessors to help implement global accessibility for important variables that must be acccessed accross multiple objects/scripts
    public double Money { get; set; }

    public int Burgers { get; set; }

    public int baseRate { get; set; }

    public int MaximumOutput { get; set; }


    //production
    public int gSRunner { get; set; }
    public int bGDelivery { get; set; }
    public int lSCompany { get; set; }
    public int Farms { get; set; }
    public int mPFarm { get; set; }

    public double gSRunnerPrice { get; set; }
    public double bGDeliveryPrice { get; set; }
    public double lSCompanyPrice { get; set; }
    public double FarmPrice { get; set; }
    public double mPFarmPrice { get; set; }

    //storeFront
    public int foodTruck { get; set; }
    public int mFoodCourtStand { get; set; }
    public int lRDive { get; set; }
    public int iMRestaurant { get; set; }
    public int lRestaurant { get; set; }
    public int Stores { get; set; }
    public int flagShips { get; set; }

    public double foodTruckPrice { get; set; }
    public double mFoodCourtStandPrice { get; set; }
    public double lRDivePrice { get; set; }
    public double iMRestaurantPrice { get; set; }
    public double lRestaurantPrice { get; set; }
    public double StorePrice { get; set; }
    public double flagShipPrice { get; set; }

    //transportation
    public int fCar { get; set; }
    public int hDriver { get; set; }
    public int sVan { get; set; }
    public int sTruck { get; set; }
    public int mTruck { get; set; }
    public int LTrucks { get; set; }

    public double fCarPrice { get; set; }
    public double hDriverPrice { get; set; }
    public double sVanPrice { get; set; }
    public double sTruckPrice { get; set; }
    public double mTruckPrice { get; set; }
    public double lTruckPrice { get; set; }


    //upgrades
    public bool breakfastMenu { get; set; }
    public int breakfastMenuPrice { get; set; }
    public bool tHours { get; set; }
    public int tHoursPrice { get; set; }
    public bool valueMenu { get; set; }
    public int valueMenuPrice { get; set; }
    public bool optimizedSN { get; set; }
    public int optimizedSNPrice { get; set; }
    public bool pesticides { get; set; }
    public int pesticidesPrice { get; set; }
    public bool GMO { get; set; }
    public int GMOPrice { get; set; }
    public bool growthHoromones { get; set; }
    public int growthHoromonesPrice { get; set; }


   
    void Awake()
    {
        _instance = this;
    }

    private void Start()
    {

    }
}

