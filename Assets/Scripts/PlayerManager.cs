using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{

    PlayerEquipManager pm;
    public string WeaponsEquiped;
    public GameObject EquippedItem;
    public Transform hand;
    public int ID;

    int previousID;
    bool isCreated;
    bool destroyPrev;
    // Start is called before the first frame update
    void Start()
    {
        destroyPrev = false;
        isCreated = true;
        pm = PlayerEquipManager.Instance;    
    }

    // Update is called once per frame
    void Update()
    {
        WeaponsChecker();
        WeaponModelUpdate();
        if (previousID != ID) 
        {
            previousID = ID;
            isCreated = true;
            destroyPrev = true;
        }
    }

    public void WeaponsChecker() 
    {

        WeaponsEquiped = pm.ItemsList[ID].Name;
        EquippedItem = pm.ItemsList[ID].Model;
    }

    public void WeaponModelUpdate() 
    {

        if (isCreated) {

            GameObject weapon = Instantiate(EquippedItem, hand.transform);
            weapon.transform.SetParent(hand.transform);
            isCreated = false;
            if (destroyPrev)
            { 
               var prevWeapon = hand.transform.GetChild(0);
                Destroy(prevWeapon.gameObject);
                destroyPrev = false;
            }
        }

    }
}
