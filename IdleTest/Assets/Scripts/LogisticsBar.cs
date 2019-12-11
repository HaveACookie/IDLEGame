using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogisticsBar : MonoBehaviour
{
    MoneySTuff moneyStuff; 
    public Slider logSlide;
    public int transporter;
    public Slider sellSlide;

    // Start is called before the first frame update
    void Start()
    {
       moneyStuff = GetComponent<MoneySTuff>();
    }

    // Update is called once per frame
    void Update()
    {
        logSlide.maxValue = moneyStuff.maxCanTransport;
        transporter = moneyStuff.maxCanTransport;
        logSlide.value = moneyStuff.rawProduction;

        sellSlide.maxValue = moneyStuff.maxCanSell;
        sellSlide.value = moneyStuff.maxCanTransport;
    }
}
