using UnityEngine;

public class EngageMenuInfo : MonoBehaviour 
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


    public void DisplayAttackMenuInfo()
    {
        GetComponent<UILabel>().text = "Attack the enemy!";
    }

    public void DisplayEscapeCommandInfo()
    {
        GetComponent<UILabel>().text = "Run from the battle!";
    }

    public void DisplayItemMenuInfo()
    {
        GetComponent<UILabel>().text = "Open the inventory!";
    }

    public void DisplayEquipementMenuInfo()
    {
        GetComponent<UILabel>().text = "Change the equipement\n before the battle start!\n(Once per battle)";
    }
    
}
