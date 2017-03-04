using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Text workersText;
    public Text totalMoneyText;
    public GameObject[] cities;
    public int totalMoney;
    public int workers;

    void Start()
    {
        workersText.text = "Workers:" + workers.ToString();
        totalMoneyText.text = "Money:" + totalMoney.ToString();
    }

    void Update()
    {
        workers = 0;
        totalMoney = 0;
        for (int i = 0; i < cities.Length; i++)

        {
            GameObject City = cities[i];
            CityManager script = City.GetComponent<CityManager>();
            workers += script.workers;
            totalMoney += script.money;
        }

        workersText.text = "Workers: " + workers.ToString();
        totalMoneyText.text = "Money: " + totalMoney.ToString();
    }
}