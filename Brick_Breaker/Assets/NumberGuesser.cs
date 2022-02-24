using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

//all c# code must be written in classes since its and object oriented language
//the class name must match the c# file name
//monobehavior is the unity class that all our custom classes will derive from. Class NumberGuesser inherits all
//information and features from the monobehavior class. This is all done for us.

public class NumberGuesser : MonoBehaviour
{
    //instance variables (attributes of the numberguesser objects)
    // variables in c# are strongly typed. you must declare the type (int, bool, string, etc.) before the name when its first used.
    public int max = 1000; // statements all end in a semicolon
    public int min = 1;
    private int count = 1;
    private int guess = 0;
    public int maxGuesses = 10;
    public Text guessText;


    // VISIBILITY - the visibility of variables and methods can be declared as public or private
    //      (the default is private). Making a variable public makes it accessible from the Unity inspector window in the unity editor.

    // Start is called before the first frame update
    void Start()
    {
        //print("welcome to number guesser!");
        //print("Pick a number in your head...");
        //print("pick a number between" + min + " and " + max + "...");

        newGuess();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))  // check if the user pressed the up arrow
        {
            min = guess + 1;
            count++;  // means increment a variable by 1 
            newGuess();
        }

        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess - 1;
            count++;
            newGuess();

        }

        else if (Input.GetKeyDown(KeyCode.Return))
        {
            print("silly human. it only took me " + count + " tries to get the right number");

        }
    }

    void newGuess()
    {
        guess = Random.Range(min, max + 1);
        guessText.text = guess.ToString();
        maxGuesses--;
        if (maxGuesses == 0)
        {
            SceneManager.LoadScene("Lose");

        }
    }

    public void GuessHigher()
       {
            min = guess + 1;
            count++;
            newGuess();


       }

    public void GuessLower ()
       {
            max = guess - 1;
            count++;
            newGuess();


       }



    

    

}
