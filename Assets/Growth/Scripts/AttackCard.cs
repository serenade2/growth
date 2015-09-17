using UnityEngine;
using System.Collections;

public class AttackCard : MonoBehaviour
{
    public int Id;
    public int Name;
   /* public Element CardElement
    {
        get;
        set;
    }*/
    public string Description { get; set; }

    public int Attack;
    public int Defense;
    public int ElementAttack;
    public int ElementDefense;
    //public ArrayList<Effect> effects; //TODO add the card effects
    public IEffect cardEffect;
    #region UnityFunctions
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    #endregion
}
