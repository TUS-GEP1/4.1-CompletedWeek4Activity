/*
 * The following three lines are required for all Scripts used by Unity. They inform the Unity
 * Engine about some core functionality that is required.
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Start of the SpriteColorChanger class.
 * 
 * The following code line indicates the start of the SpriteColorChanger class which continues until the very
 * end of this file. Generally you have only one class per file and the name of the class MUST be the
 * same as the name of the file e.g. this class is called SpriteColorChanger and is in a file called
 * SpriteColorChanger.cs
 * 
 * A class is simply a collection of variables and functions. They are a very useful way of sharing
 * code. If you write code in a class that, for example, draws coloured circles onto the screen and I
 * want to use it, then all you have to do is give me the class. Now, if I wanted to also draw coloured 
 * squares onto the screen than I could either (a) open up the file that contains your class code and 
 * and new code that draws squares (I might also have to change some of your exisiting code), or (b) I 
 * could EXTEND your class. 
 * 
 * What does it mean to EXTEND a class?
 * Let's pretend for a moment that your class is called ColourfulCircles. I can now write a new class
 * called, let's say, ColourfulShapes and specify that it is to EXTEND your class ColourfulCircles. My
 * class will now have access to all (or at least most) of the code in your class plus I can write my 
 * own code in my class. It is almost the same as option (a) above but I don't actually add or change 
 * the code in your class (and possibly break it), instead I write my own class code that will have the
 * functions and variables that are in your class PLUS the functions and variables that are in mine.
 * 
 * The class below called SpriteColorChanger EXTENDS the class MonoBehaviour. The MonoBehaviour class was
 * written by the Unity Company and contains lots of functions of variables that allow your (or my) 
 * classes to work within the Unity Game Engine. ALL script components that get attached to Game Object
 * MUST extend the MonoBehaviour class. 
 * 
 * I can't see the code that's in the MonoBehaviour class, instead, Unity have written an online document
 * explaining what functions are in it and what they do. The online document, known as the Unity Scripting
 * API, explains 100's of classes that the Unity Company have written that we can use. 
 * 
 * - The Unity Scripting API - https://docs.unity3d.com/ScriptReference/index.html
 * - Explanation of the MonoBehaviour class - https://docs.unity3d.com/ScriptReference/MonoBehaviour.html
 *
 */

public class SpriteColorChanger : MonoBehaviour
{
    public SpriteRenderer aSR;

    /*
     * The following function, known as Event Function, get called by the Unity Engine when
     * the user presses a mouse button when over a Game Object that has a Collider 
     * component. This is just one example of an Event Function, that is, a function that
     * gets called by the Unity Engine as a result of some event happening. You can read
     * more about them in the Unity Manual here https://docs.unity3d.com/Manual/EventFunctions.html
     */

    /*
     * I am going to use the event function to demonstrate how this Script, when attached to a Game Object 
     * as a component, can access another component on the Game Object. The other component I am going to
     * access is a Sprite Renderer component.
     */

    /*
     * If a script component attached to a Game Object has a Start function then Unity will call it
     * just once, just before it calls the Update function for the first time. 
     */
    private void Start()
    {
        Debug.Log("This scene is starting");


    }


    /*
     * If a script component attached to a Game Object has an Update function then Unity will call it
     * frame (approximately 60 times a second). Note the code you place in this function gets executed
     * before Unity actually updates the screen (known as rendering the screen).
     */
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Color someColor;
            float randomRed;
            float randomBlue;
            float randomGreen;

            randomRed = Random.value;
            randomGreen = Random.value;
            randomBlue = Random.value;

            someColor = new Color(randomRed, randomGreen, randomBlue);
            aSR.color = someColor;
        }
    }
}
/* End of the SpriteFlipper Class */
