using System;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Creature : MonoBehaviour
{
    public TextAsset JsonHero;
    public TextAsset JsonWeapon;
    public  List<Hero> Heroes;

    public List<Element> _elements = new List <Element>();
    private void Start()
    {
        AddButtonListeners();
       
        //Heroes = JsonConvert.DeserializeObject<List<Hero>>(JsonHero.text);

    }


    public void AddButtonListeners()
    {
        foreach (var elem in _elements) //��������  �� ������� ����� ������
        {
            var Button = elem.transform.GetComponent<Button>();

            Button.onClick.AddListener(elem.SelectItem);



        }

    }





}

public enum Body
{
    head,
    torso,
    leftHand,
    rightHand,
    leftFoot,
    rightFoot
}

[Serializable]
public class Hero : Ident
{
    public int id { get; set; }


    public string name;
    public int hp;
    public int damage;
    public int armor;

    //public Body body;
    public int[] weapon;
    //public Potion[] potion;
    //public Animal[] animal;
     
}

 
 
 

[Serializable]
public class Animal : Ident
{
    public int id { get; set; }

    public string name;
    public int hp;
    public int damage;
    public int armor;
    public superForce[] force;

    public int level;
}

[Serializable]
public class superForce : Ident
{
    public int id { get; set; }
    public string name;
    public string damage;
}


