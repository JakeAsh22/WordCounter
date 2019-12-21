# Word Counter

#### _C#, .NET: Word Counter, 12/20/2019_

#### Contributors
_**Jacob Ash**_

## Description
Word Counter is an application that allows the user to type a word, and then type a sentence.  The application will then display how many times that full word is in that sentence.  If the word, or the sentence, has numbers the application will ask to only use letters.

## Application should have:

There should be one class: `Word Counter`. 

When the user runs the application, they will recieve a message asking for both the key word and the sentence.  If they run the tests, it should display that all of the tests work properly.

The user should be able to type any word, or any sentence they would like as long as it does not contain numbers.

The application will return how many times that word is in the sentence.


| input | Output |
| :------------- | :------------- |
| "Inputs - Key Word: "Hello" Sentence: "1111111" | Please only use letters in your sentence |
| "Inputs - Key Word: "111" Sentence: "Hello" | Please only use letters in your key word |
| "Inputs - Key Word: "cat" Sentence: "cat" | 1 |
| "Inputs - Key Word: "cat" Sentence: "cat cat cat dog" | 3 |
| "Inputs - Key Word: "cat" Sentence: "I'm walking to the cathedral." | 0 |
* The first spec is to test to see if the sentence contains numbers.
* The second spec is to test if the word contains numbers
* the third spec tests if the word finder works with the keyword, and a sentence that only contains the key word
* the fourth spec tests to see if the program counts multiple of the same words
* The fifth spec tests to see if the program only counts whole words

## Setup/Installation Requirements

Clone this repo:
Please clone this repo to use the application.  After cloning, use dotnet restore inside the `ModelTests` and `WordCounter.Tests` folders to receieve the proper files.

Link to GH repo:
https://github.com/JakeAsh22/WordCounter

## Known Bugs
* No known bugs at this time.

## Support and contact details

email: jacob.ash1998@gmail.com

## Technologies Used
_Git, GitHub, C# and .NET Core_


## License
Copyright © 2019 [Jacob Ash] under the MIT License