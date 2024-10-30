using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task8 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        // Solution 1:
        Debug.Log("----- Solution 1 -----");
        while (true)
        {
            int number = Random.Range(1, 21); // Generate a random number from 1 to 20
            
            if (number == 5){
                continue; // Skip printing the number 5
            }
            else if (number == 15){
                break; // Exit the loop if the number is 15
            }

            Debug.Log(number); // Print the generated number
            
        }

        Debug.Log("-----------------------------------------");

        // Solution 2:
        Debug.Log("----- Solution 2 -----");

        string[] words = { "Cat", "Dog", "Car", "Pizza", "Hat", "Fish", "Tree", "Monkey", "Ball", "Bird" };
        string sentence = "";

        int wordCount = 0;
        
        while (wordCount < 7)
        {
            int index = Random.Range(0,words.Length); // Get a random index from the array
            sentence += words[index] + " , "; // Add the chosen word to the sentence
            wordCount++;
        }

        Debug.Log("Funny Sentence: " + sentence.Trim());

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}



