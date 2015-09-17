using System;
using UnityEngine;
using System.Collections;
using System.Security.Cryptography.X509Certificates;

public class Character : MonoBehaviour
{
    public string Name { get; set; }
    public float Hp { get; set; }
    public float Attack { get; set; }
    public float Defense { get; set; }
    public int Accuracy { get; set; }
    public int Speed { get; set; }
    public int Luck { get; set; }
    //public Status CharacterStatus { get; set; }
    //public Job characterClass {get;set;}
    //public Element CharacterElement {get;set;}
    //public EquipementSet equipments {get;set;}
    public bool IsAlive { get; set; }
    //public ArrayList<MysticCharacter> MysticParty { get; set; }


    #region Unity functions
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    #endregion

}
