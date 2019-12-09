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
    public int Money { get; set; }




    public int gSRunner { get; set; }
    public int bGDelivery { get; set; }
    public int lSCompany { get; set; }
    public int Farms { get; set; }
    public int mPFarm { get; set; }
    



    public int Burgers { get; set; }


    public int foodTruck { get; set; }
    public int mFoodCourtStand { get; set; }
    public int lRDive { get; set; }
    public int iMRestauraunt { get; set; }
    public int lRestaurant { get; set; }
    public int Stores { get; set; }
    
    
    public int fCar { get; set; }
    public int hDriver { get; set; }
    public int sVan { get; set; }
    public int sTruck { get; set; }
    public int mTruck { get; set; }
    public int LTrucks { get; set; }
   


    public double FarmPrice { get; set; }
    public double StorePrice { get; set; }
    public double TruckPrice { get; set; }
   
    public int baseRate { get; set;}
    

    public int MaximumOutput { get; set; }

    void Awake()
    {
        _instance = this;
    }

    private void Start()
    {

    }
}

