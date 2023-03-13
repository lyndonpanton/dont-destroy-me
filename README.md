# dont-destroy-me
Exercise 8 of the "Intermediate Object-Oriented Programming for Unity Games" course of the "C# Programming for Unity Game Development" Specialization by the University of Colorado via Coursera Description

## Description
Problem 1 – Create project and add event manager

Create a new Unity project named Exercise8 and save the default scene into a new scenes folder.

Add a DestroyButton script (you'll use this in Problem 3, but you need the class now to use in the event manager). Add a stub for an AddDestroyEventListenerAddDestroyEventListener method to the script; your stub should be the entire method without any code in the method body.

Add a static EventManagerEventManager class that has static fields for an invoker and a listener for a no argument event. Add public static methods to add an invoker and to add a listener for that event. Remember, you don’t know in what order those methods will be called, so when you add the invoker you should also add the listener to the invoker (if the listener isn’t null). You should also do this when you add a listener (if the invoker isn’t null);

Problem 2 – Add a game object that listens for the event

Add a game object to the scene. Have the game object’s script add itself as a listener for theDestroyEvent to the event manager in the script’s StartStart method. Have the script destroy the game object it’s attached to when the event is invoked.

Problem 3 – Add a menu button that invokes the event

Add a DestroyEvent class for a no argument UnityEvent.

Add a menu button that invokes the event to the scene when it’s clicked. Have the DestroyButton script add itself as an invoker of the DestroyEvent to the event manager in the script’s StartStart method. Have the script invoke the event when the menu button is clicked.

## Getting Started

n/a

### Dependencies

* Windows 10
* Microsoft Visual Studio
* .NET
* Unity

### Installing

* Download link: [Github Repository](https://github.com/lyndonpanton/dont-destroy-me)

### Executing program

n/a

## Help

n/a

## Authors

Lyndon Mykal Panton
[lyndonpanton](https://github.com/lyndonpanton/)

## Version History

* 0.1
    * Initial Release

## License

n/a

## Acknowledgments

Problem provided by the _University of Colorado_ and _Coursera_
