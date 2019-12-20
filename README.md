# Word Counter

#### _C#, .NET: Pierre Bakery, 12/16/2019_

#### Contributors
_**Jacob Ash**_

## Description
Word Counter is an application that allows the user to type a word, and then type a sentence.  The application will then display how many times that full word is in that sentence.  If the word, or the sentence, has numbers the application will ask to only use letters.

## Application should have:

There should be one class: `Word Counter`. 

When the user runs the application, they will recieve a message asking for both the key word and the sentence.  If they run the tests, it should display that all of the tests work properly.

THe user should be able to type any word, or any sentence they would like as long as it does not contain numbers.

The application will return how many times that word is in the sentence.


| input | Output |
| :------------- | :------------- |
| "Inputs - Key Word: "Hello" Sentence: "1111111" | Please only use letters in your sentence |
| "Inputs - Key Word: "111" Sentence: "Hello" | Please only use letters in your key word |
| "Inputs - Key Word: "cat" Sentence: "cat" | 1 |
| "Inputs - Key Word: "cat" Sentence: "cat cat cat dog" | 3 |
| "Inputs - Key Word: "cat" Sentence: "I'm walking to the cathedral." | 0 |

## Setup/Installation Requirements

Clone this repo:
Please clone this repo to use the application.  After cloning, use dotnet restore inside the `ModelTests` and `WordCounter.Tests` folders to receieve the proper files.


## Known Bugs
* No known bugs at this time.

## Support and contact details

email: jacob.ash1998@gmail.com

## Technologies Used
_Git, GitHub, C# and .NET Core


## License
Copyright © 2019 [Jacob Ash] under the MIT License