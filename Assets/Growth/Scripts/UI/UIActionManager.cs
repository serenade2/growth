using System;
using UnityEngine;
using System.Collections;

public class UIActionManager : MonoBehaviour
{
    private GameObject engagingMenuPanelGameObject;
    private GameObject attackingMenuPanelGameObject;
	// Use this for initialization
	void Start () 
	{
        //engagingMenuPanelGameObject = GameObject.Find("EngagingMenuPanel");
        attackingMenuPanelGameObject = GameObject.Find("AttackingMenuPanel");
	}
	
	// Update is called once per frame
	void Update () 
	{
       
	}

	public void OpenEngagingMenuPanel()
	{
		//GetComponent<UIPanel>().gameObject.transform
		
		NGUITools.SetActive(engagingMenuPanelGameObject,true);
	}

	public void CloseEngagingMenuPanel()
	{
		NGUITools.SetActive(engagingMenuPanelGameObject, false);
	}

	public void OpenAttackingMenuPanel()
	{
        attackingMenuPanelGameObject = GameObject.Find("AttackingMenuPanel");
	    //GameObject.Find("AttackingMenuPanel", bool active_only = true);
        attackingMenuPanelGameObject = FindGameObjectHelper.GameObjectHardFind("AttackingMenuPanel");
		NGUITools.SetActive(attackingMenuPanelGameObject, true);
	}

	 public void CloseAttackingMenuPanel()
	{
		NGUITools.SetActive(attackingMenuPanelGameObject, false);
	}


}
