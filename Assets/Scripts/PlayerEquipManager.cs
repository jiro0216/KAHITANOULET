using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class Items
{
  

    [SerializeField]
    public string Name;
    public string Description;
    public GameObject Model;
    public int ID;

}



public class PlayerEquipManager : MonoBehaviour
{
    public static PlayerEquipManager Instance { get; private set; }
    [SerializeField]
    private List<Items> itemList = new List<Items>();
   
    public List<Items> ItemsList
    {
        get { return itemList; }
        //set { itemList = value; }
    }
}

