using System;
using UnityEngine;
using System.Collections;

public class UIActionManager : MonoBehaviour
{
    public GameObject engagingMenuPanelGameObject;
    public GameObject attackingMenuPanelGameObject;
	// Use this for initialization
	void Start ()
	{
	    engagingMenuPanelGameObject = GameObject.Find("EngagingMenuPanel");
        attackingMenuPanelGameObject = GameObject.Find("AttackingMenuPanel");
        // show only the principal ui at the start of the battle.
        CloseAttackingMenuPanel();
	}
	
	// Update is called once per frame
	void Update () 
	{
       
	}

    public void DisplayAttackMenu()
    {
        CloseEngagingMenuPanel();
        OpenAttackingMenuPanel();
    }

    public void DisplayEngagingMenu()
    {
        CloseAttackingMenuPanel();
        OpenEngagingMenuPanel();
    }

	private void OpenEngagingMenuPanel()
	{
		//GetComponent<UIPanel>().gameObject.transform
	    if (engagingMenuPanelGameObject != null)
	    {
	        NGUITools.SetActive(engagingMenuPanelGameObject, true);
	    }    
	}

	private void CloseEngagingMenuPanel()
	{
	    if (engagingMenuPanelGameObject != null)
	    {
            //NGUITools.SetActive(engagingMenuPanelGameObject, false);
            this.engagingMenuPanelGameObject.SetActive(false);
	    }
	}

	private void OpenAttackingMenuPanel()
	{
        //attackingMenuPanelGameObject = GameObject.Find("AttackingMenuPanel");
	    //GameObject.Find("AttackingMenuPanel", bool active_only = true);
	    if (attackingMenuPanelGameObject != null)
	    {
            NGUITools.SetActive(attackingMenuPanelGameObject, true);
	    }
	}

	private void CloseAttackingMenuPanel()
	{
	     if (attackingMenuPanelGameObject != null)
	     {
             NGUITools.SetActive(attackingMenuPanelGameObject, false);
	     }
	}


}
