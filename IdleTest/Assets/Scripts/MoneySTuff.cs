using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneySTuff : MonoBehaviour
{

    [SerializeField]
    private int rawProduction;
    private int realProduction;
    private int maxCanTransport;
    private int maxCanSell;
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
        GameManager.Instance.FarmPrice = 10;
        GameManager.Instance.TruckPrice = 15;
        GameManager.Instance.StorePrice = 44;
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
            truckText.text = GameManager.Instance.LTrucks + "Trucks" + "Buy Another for" + " " + GameManager.Instance.TruckPrice;
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
        for(; ;)
        {

            yield return new WaitForSeconds(1f);
        }
    }

     public void farmButton()
    {
        if (GameManager.Instance.Money >= GameManager.Instance.FarmPrice)
        {
            GameManager.Instance.Farms += 1;
            GameManager.Instance.FarmPrice = (10 * (10^GameManager.Instance.Farms));
        }
        
    }
    public void truckButton()
    {
        if (GameManager.Instance.Money >= GameManager.Instance.TruckPrice)
        {
            GameManager.Instance.LTrucks += 1;
            GameManager.Instance.TruckPrice = (GameManager.Instance.TruckPrice * 1.1);
        }

    }
    public void storeButton()
    {
        if(GameManager.Instance.Money>= GameManager.Instance.StorePrice)
        {
            GameManager.Instance.Stores += 1;
            GameManager.Instance.StorePrice = (GameManager.Instance.StorePrice * 1.1);
        }
    }

    public void cookButton()
    {
        sold++;
        GameManager.Instance.Money += 5;
    }

}
