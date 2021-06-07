using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
    //the time I want it to start at then end on 
    //starting time is what is starts on
    //current time is the current time that is playing, 
    //by refering to current time you can change what happens when the number is shown. eg: change the following numbers to red or end the game at 0).
    public float currentTime = 0f;
    public float startingTime = 10f;
    


    public Text countdownText;


    //the script starts the countdown
    public void Start()
    {
        //the current time starts at the starting time (the following scripts make the current time shift down)
        currentTime = startingTime;
    }

    //an update starts to make the game count the numbers frame wise.
    void FixedUpdate()
    {
        //minus one (deltatime does the countdown per frame instead of having to manually update and write the new number)
        currentTime -= 1 * Time.deltaTime;
        // "0" makes it a whole number instead of counting down in percentages.
        countdownText.text = currentTime.ToString("0");

        //colour change script
        if (currentTime == 3)
            countdownText.color = Color.red;



        //the number goes into minus numbers, to fix this we need an if statement)
        if (currentTime <= 0)
            currentTime = 0;

        //end of the game script, once the current time is equal to 0 the game over screen appears.
        if (currentTime == 0)
            countdownText.text = "Game Over.";



    }

}
