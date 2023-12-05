using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    public int maxLetters = 10;
    public Transform rigedButton;
    public Transform blincker;
    public AudioSource bombbeep;
    public AudioSource explosion;
    public string numString { get; private set; }

    public bool isRigged { get; private set; }
    private void Start()
    {
        numString = " ";
        isRigged = false;
        rigedButton.gameObject.SetActive(false);
        blincker.gameObject.SetActive(false);
    }
    public void updateString(string num)
    {
        if (numString.Length < maxLetters && !isRigged)
            numString += num;
    }

    public void clearString()
    {
        numString = " ";
        isRigged = false;
        rigedButton.gameObject.SetActive(false);
        blincker.gameObject.SetActive(false);
    }

    public void rig()
    {
        isRigged = true;
        rigedButton.gameObject.SetActive(true);
        StartCoroutine(startCountDown());
    }

    private void detonate()
    {
        // play explosion sound effect
        explosion.Play();
    }

    private IEnumerator startCountDown()
    {
        // play beep sound
        while (true)
        {
            bombbeep.Play();
            yield return new WaitForSeconds(1);
            int newTimer = int.Parse(numString);
            newTimer -= 1;
            numString = newTimer.ToString();

            if(newTimer % 2 == 0)
                blincker.gameObject.SetActive(true);

            else blincker.gameObject.SetActive(false);

            if (newTimer <= 0) break;
        }

        detonate();
    }
}
