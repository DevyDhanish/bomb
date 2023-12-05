using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttons : MonoBehaviour
{
    public Bomb bomb;

    public void one()
    {
        bomb.updateString("1");
    }

    public void two()
    {
        bomb.updateString("2");
    }

    public void three()
    {
        bomb.updateString("3");
    }

    public void four()
    {
        bomb.updateString("4");
    }

    public void five()
    {
        bomb.updateString("5");
    }

    public void six()
    {
        bomb.updateString("6");
    }

    public void seven()
    {
        bomb.updateString("7");
    }

    public void eight()
    {
        bomb.updateString("8");
    }

    public void nine()
    {
        bomb.updateString("9");
    }

    public void zero()
    {
        bomb.updateString("0");
    }

    public void Star()
    {
        bomb.updateString("*");
    }

    public void hash()
    {
        bomb.updateString("#");
    }

    public void clear()
    {
        bomb.clearString();
    }

    public void rig()
    {
        // rig the bomb
        bomb.rig();
    }
}
