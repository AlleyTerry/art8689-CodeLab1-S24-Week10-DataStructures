using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using Unity.UI;
using TMPro;

public class DictionaryScript : MonoBehaviour
{
    public Dictionary<string, int> ingredients = new Dictionary<string, int>();
    public Dictionary<string, int> customerburger1 = new Dictionary<string, int>();
    public TextMeshProUGUI order;
    

    public GameObject bun;
    private int bunNumber;

    public GameObject lettuce;
    private int lettuceNumber;
    
    public GameObject meat;
    private int meatNumber;

    public GameObject cheese;
    private int cheeseNumber;
    // Start is called before the first frame update
    void Start()
    {
        customerburger1.Add("bun",2);
        customerburger1.Add("meat",2);
        customerburger1.Add("cheese",2);
        customerburger1.Add("lettuce",2);
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
    
        public void MeatAdd()
        {
            if (ingredients.ContainsKey("meat"))
            {
                Instantiate(meat, new Vector3(0,2.0f,0), quaternion.identity);
                ingredients["meat"]++;
            }
            else
            {
                Instantiate(meat, new Vector3(0,2.0f,0), quaternion.identity);
                ingredients.Add("meat", 1);
            }
    
            meatNumber = ingredients["meat"];
            Debug.Log(meatNumber);
        }
        public void LettuceAdd()
        {
            if (ingredients.ContainsKey("lettuce"))
            {
                Instantiate(lettuce, new Vector3(0,2.0f,0), quaternion.identity);
                ingredients["lettuce"]++;
            }
            else
            {
                Instantiate(lettuce, new Vector3(0,2.0f,0), quaternion.identity);
                ingredients.Add("lettuce", 1);
            }
    
            lettuceNumber = ingredients["lettuce"];
            Debug.Log(lettuceNumber);
        }
        public void CheeseAdd()
        {
            if (ingredients.ContainsKey("cheese"))
            {
                Instantiate(cheese, new Vector3(0,2.0f,0), quaternion.identity);
                ingredients["cheese"]++;
            }
            else
            {
                Instantiate(cheese, new Vector3(0,2.0f,0), quaternion.identity);
                ingredients.Add("cheese", 1);
            }
    
            cheeseNumber = ingredients["cheese"];
            Debug.Log(cheeseNumber);
        }
        

    public void MakeBurger()
    {
        Debug.Log(ingredients["bun"]);
        Debug.Log(customerburger1["bun"]);
        //check to see if burger matches customer burger
        if (ingredients["bun"] == customerburger1["bun"] && ingredients["meat"] == customerburger1["meat"]
                                                         && ingredients["cheese"] == customerburger1["cheese"] 
                                                         && ingredients["lettuce"] == customerburger1["lettuce"])
        {
            order.text = "yes my order yipeeee";
        }
        else
        {
            order.text = "I want to speak to the manager";
        }
        
    }
}
