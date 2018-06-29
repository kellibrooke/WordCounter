# Word Counter

#### A C# Word Counting Program

#### By Kelli McCloskey

## Description

This is a code review project for the C# class at Epicodus. The instructions are as follows:
Your mission is to create a program that checks how frequently a word appears in a given string. The user should input both the word and a list of words to check. Check for full word matches only.

## Specs

* A user enters a string of words.
* The string is converted to all lower case letters.
* The string of words is split into individual word strings.
* The individual word strings are checked to make sure they are letters. If not, the user is told they are not allowed to use other characters or punctuation.
* An empty dictionary is created to keep track of the word count for each word.
* A loop is iterated through for each word in the string and tested whether or not it can be found in the dictionary. If it is not found, it is added as a key and its value is set to 1. If it is found as a key already existing in the dictionary, its value simply increases by 1.
* Once the dictionary is created by the string, a user is prompted to enter a word.
* That word will be sent to the dictionary, and the dictionary's keys will be searched for that word. If found, it will report to the user how many times that word was found in the previously entered string of words. If not found, it will report to the user that they have entered a word that does not exist in the previously entered string of words.

## Setup on OSX

* Download and install .Net Core 1.1.4
* Download and install Mono
* Clone the repo
* Navigate to repo folder via command line.
* Run `dotnet restore` from within the project directory
* Run 'mcs RepeatCounter.cs' and 'mono RepeatCounter.exe'.

## Contribution Requirements

1. Clone the repo
1. Make a new branch
1. Commit and push your changes
1. Create a PR

## Technologies Used

* .Net Core 1.1.4

## Links

* [Here](https://github.com/kellibrooke/WordCounter) is a link to the project's repo on GitHub.

## License

This software is licensed under the MIT license.

Copyright (c) 2018 **Kelli McCloskey**
