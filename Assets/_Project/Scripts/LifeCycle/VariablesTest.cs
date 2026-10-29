using NUnit.Framework;
using System;
using System.Collections.Generic;
using UnityEngine;

public class VariablesTest : MonoBehaviour
{
    [SerializeField] int shopIndex = 8;
    public int ShopIndex => shopIndex;


    [SerializeField] float shopRevenue = 50.5f;
    [SerializeField] bool shopOpen = false;


    enum ShopState { OPENING = 0, SELLING, RESTOCKING, CLOSING}
    [SerializeField] ShopState shopStateBase = ShopState.OPENING;
    [SerializeField] ShopState shopStateAdvance = ShopState.RESTOCKING;

    [SerializeField] string shopName = "shoppone";


    // Array bool + [6] > nome variabile
    [SerializeField] int[] productArray = new int[5];

    [SerializeField] List <int> productList = new List <int>();

    Dictionary<string, float> productDictionary = new Dictionary<string, float>();

    HashSet<Product> productHashSet = new HashSet<Product>();

    [SerializeField] List<Product> productsList = new List<Product>();

}
[Serializable]
public class Product
{
    public string Name;
    public float Price;


}