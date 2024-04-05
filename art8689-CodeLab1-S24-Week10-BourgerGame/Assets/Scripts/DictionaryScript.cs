using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class DictionaryScript : MonoBehaviour
{
    public Dictionary<string, int> ingredients = new Dictionary<string, int>();
    public Dictionary<string, int> customerburger1 = new Dictionary<string, int>();

    public GameObject bun;
    private int bunNumber;

    public GameObject lettuce;

    public GameObject meat;

    public GameObject cheese;
    // Start is called before the first frame update
    void Start()
    {
        customerburger1.Add("bun",4);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //when player presses the bun button a burger spawns and adds the number to the dictionary
    public void BunAdd()
    {
        if (ingredients.ContainsKey("bun"))
        {
            Instantiate(bun, new Vector3(0,2.0f,0), quaternion.identity);
            ingredients["bun"]++;
        }
        else
        {
            Instantiate(bun, new Vector3(0,2.0f,0), quaternion.identity);
            ingredients.Add("bun", 1);
        }

        bunNumber = ingredients["bun"];
        Debug.Log(bunNumber);
    }

    public void MakeBurger()
    {
        Debug.Log(ingredients["bun"]);
        Debug.Log(customerburger1["bun"]);
        //check to see if burger matches customer burger
        if (ingredients["bun"] == customerburger1["bun"])
        {
            Debug.Log("yayy go to sleep");
        }
        else
        {
            Debug.Log("not equal?");
        }
        
    }
}
