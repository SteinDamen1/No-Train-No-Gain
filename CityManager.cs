using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CityManager : MonoBehaviour {
    public int workers;
    public int money;

    void Start()
    {
        StartCoroutine(MoneyMaking());
    }

    IEnumerator MoneyMaking()
     {
        while(true)
        {
        yield return new WaitForSeconds(3);
        money += 1 * workers;
        Debug.Log("City money = " + money);
        
        
         }
    }
}
	
