using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using Unity.UI;
using TMPro;

public class DictionaryScript : MonoBehaviour
{
    public static DictionaryScript instance;
    public Dictionary<string, int> ingredients = new Dictionary<string, int>();
    public TextMeshProUGUI order;
    public GameObject burgerHolder;
    

    public GameObject bun;
    private int bunNumber;

    public GameObject lettuce;
    private int lettuceNumber;
    
    public GameObject meat;
    private int meatNumber;

    public GameObject cheese;
    private int cheeseNumber;

    public bool correctBurger = false;

    private CustomerScriptable customer;
    public int customerNumber = 0;
    public string path = "Prefabs/Customer";
    public Dictionary<string, int> numbers = new Dictionary<string, int>();
    

    public void newCustomer()
    {
        path = "Prefabs/Customer" + customerNumber.ToString();
        Debug.Log(path);
        customer = (CustomerScriptable)Instantiate(Resources.Load<ScriptableObject>(path));
        Debug.Log(customer);
        customer.customerOrder();
        order.text = "I want a burger with: " 
                                               + customer.customerburger1["bun"] + " buns, "
                                               + customer.customerburger1["meat"] + " meat, "
                                               + customer.customerburger1["cheese"] + " cheese, "
                                               + customer.customerburger1["lettuce"] + " lettuce, ";
        customerNumber++;
        

    }

    //when player presses the bun button a burger spawns and adds the number to the dictionary
    public void BunAdd()
    {
        Instantiate(bun, new Vector3(0,2.0f,0), quaternion.identity, burgerHolder.transform);
        bunNumber++;
        Debug.Log(bunNumber);
    }
    public void MeatAdd()
    {
        Instantiate(meat, new Vector3(0,2.0f,0), quaternion.identity, burgerHolder.transform);
        meatNumber++;
        Debug.Log(meatNumber);
    }
    public void LettuceAdd()
    {
        Instantiate(lettuce, new Vector3(0,2.0f,0), quaternion.identity, burgerHolder.transform);
        lettuceNumber++;
        Debug.Log(lettuceNumber);
    }
    public void CheeseAdd()
    {
        Instantiate(cheese, new Vector3(0,2.0f,0), quaternion.identity, burgerHolder.transform);
        cheeseNumber++;
        Debug.Log(cheeseNumber);
    }
        

    public void MakeBurger()
    {
        numbers.Add("meatNumber", meatNumber);
        numbers.Add("cheeseNumber", cheeseNumber);
        numbers.Add("lettuceNumber", lettuceNumber);
        numbers.Add("bunNumber", bunNumber);
        foreach (KeyValuePair <string,int> ingredient in customer.customerburger1)
        {
            Debug.Log(ingredient.Key + ingredient.Value);
            string currentIngredient = ingredient.Key + "Number";
            Debug.Log(currentIngredient);
            ingredients.Add(ingredient.Key,numbers[currentIngredient]);
            
        }

        foreach (KeyValuePair<string, int> ingredient in customer.customerburger1)
        {
            foreach (KeyValuePair<string, int> ingredientPlayer in ingredients)
            {

                if (ingredient.Key == ingredientPlayer.Key)
                {
                    if (ingredient.Value == ingredientPlayer.Value)
                    {
                        correctBurger = true;
                    }
                }
            }
        }
        

        if (correctBurger)
        {
            order.text = "yayyyy my burger yum!";
        }
        else
        {
            order.text = "oh... that's not...";
        }
        ingredients.Clear();
        numbers.Clear();
        for (int j = 0; j < burgerHolder.transform.childCount; j++)
        {
            Destroy(burgerHolder.transform.GetChild(j).gameObject);
        }
    }
}
