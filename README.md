# How to run the Mars Rover Coding Challenge

Make sure you have to **dotnet core sdk** installed on your system, which you can download from [here](https://www.microsoft.com/net/download/core).

To see if you have **dotnet core skd** open the terminal and type `dotnet -h`. You will see help messages like below on the terminal:

![image-20210401021109995](/home/david/.var/app/io.typora.Typora/config/Typora/typora-user-images/image-20210401021109995.png)





## Running The Mars Rover

*  Within the terminal open up the directory MarsRoverCodingChallenge/MarsRoverChallenge
* Within this directory run the following command `dotnet run` and hit enter.
* After the program runs enter in the relevant information you are prompted to, e.g.

`Enter plateau coordinates`
`5 5`


`Enter rover starting position`
`1 2 N`

`Enter in the instructions for the rover`
`LMLMLMLMM`

`Would you like to enter in another rover`
`no`

`Output:`

`1 3 N`

## Running The Test for the Mars Rover

* Within the terminal open up the directory MarsRoverCodingChallenge/MarsRoverChallengeTests 

* Within this directory run the following command `dotnet test` to run the tests for the MarsRoverChallenge.