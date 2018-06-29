# Word Counter

#### A C# Word Counting Program

#### By Kelli McCloskey

## Description

This is a code review project for the C# class at Epicodus. The instructions are as follows:
Your mission is to create a program that checks how frequently a word appears in a given string. The user should input both the word and a list of words to check. Check for full word matches only.

## Specs

| Description | Input | Output |
| ----------- | ----- | ------ |
| A user enters a string of words, the string is converted to all lower case letters, the string of words is split into individual word strings. | "Here it iS" | { "here", "it", "is" }
| The individual word strings are checked to make sure they are letters. If not, the user is told they are not allowed to use other characters or punctuation. | { "here", "i4", "is" } | Console Says: "Please do not enter any characters aside from letters."
| Once the phrase is validated, it gets sorted into a dictionary that counts how many iterations of each word exists in the string. | { "here", "it", "is" } | here: 1, it: 1, is: 1
| Once the dictionary is created by the string, a user is prompted to enter a word. The word is checked to make sure it is composed only of letters. If not, it will display an error to the user. If it is only letters, it will be made all lowercase and sent to the next step. | "TeSt" | "test"
| That word will be sent to the dictionary, and the dictionary's keys will be searched for that word. If found, it will report to the user how many times that word was found in the previously entered string of words. If not found, it will report to the user that they have entered a word that does not exist in the previously entered string of words. | { "here", "it", "is" }, "here" | 1 |

## Setup on OSX

* Download and install .Net Core 1.1.4
* Download and install Mono
* Clone the repo
* Navigate to repo folder via command line.
* Run `dotnet restore` from within the project directory
* Run `mcs RepeatCounter.cs` and `mono RepeatCounter.exe`.

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
