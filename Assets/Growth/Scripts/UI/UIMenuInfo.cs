using System;
using UnityEngine;

/// <summary>
/// This class display information of each icons that are in the battle menu.
/// <author>Samuel Abraham</author>
/// </summary>
public class UIMenuInfo : MonoBehaviour 
{
    public void MakeItRed()
    {
        GetComponent<UIWidget>().color = Color.red;
    }

    public void MakeItBlue()
    {
        GetComponent<UIWidget>().color = Color.blue;
    }

    public void MakeItGreen()
    {
        GetComponent<UIWidget>().color = Color.green;
    }

    public void DisplayEngageMenuInfo()
    {
        GetComponent<UILabel>().text = "Engage the enemy!";
    }
    public void DisplayAttackMenuInfo()
    {
        GetComponent<UILabel>().text = "Attack the enemy!";
    }

    public void DisplayEscapeCommandInfo()
    {
        GetComponent<UILabel>().text = "Escape from the battle!";
    }

    public void DisplayItemMenuInfo()
    {
        GetComponent<UILabel>().text = "Open the inventory!";
    }

    public void DisplayEquipementMenuInfo()
    {
        GetComponent<UILabel>().text = "Change the equipement\n before the battle start!\n(Once per battle)";
    }

    public void DisplayNothing()
    {
        GetComponent<UILabel>().text = String.Empty;
    }

    public void DisplayMCMenuInfo()
    {
        GetComponent<UILabel>().text = "Use/Set Mystic creatures!";
    }

    public void DisplaySpecialMenuInfo()
    {
        GetComponent<UILabel>().text = "Use technical skills!";
    }

    public void DisplayMMCMenuInfo()
    {
        GetComponent<UILabel>().text = "Unleash the potential of the mystic creatures!";
    }

    public void DisplayDefenseActionInfo()
    {
        GetComponent<UILabel>().text = "Defend for this turn.";
    }

}
