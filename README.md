```markdown
# BinaryConverter Game

## Overview

The BinaryConverter game is a simple console-based game where players are tested on their ability to convert numbers between binary and decimal formats. The game provides either a binary or decimal number and prompts the player to convert it to the other format. It provides immediate feedback on the correctness of the player's answer.

## Features

- **Binary to Decimal Conversion**: The game generates a random decimal number, displays its binary representation, and asks the player to enter the decimal equivalent.
- **Decimal to Binary Conversion**: The game generates a random decimal number, displays it, and asks the player to enter its binary representation.
- **Feedback and Replay**: After each round, the game informs the player if their answer was correct or not and provides the correct answer if it was incorrect. The player can choose to continue or exit the game.

## Getting Started

To play the game, you'll need to have a .NET runtime environment installed on your machine. Follow these steps to run the game:

1. **Clone the Repository**

   ```bash
   git clone <repository-url>
   cd <repository-directory>
   ```

2. **Build and Run**

   Open a terminal or command prompt in the project directory and use the following command to build and run the application:

   ```bash
   dotnet run
   ```

3. **Play the Game**

   - When prompted, enter `"yes"` to start the game.
   - Choose `"binary"` to receive a binary number and convert it to decimal.
   - Choose `"decimal"` to receive a decimal number and convert it to binary.
   - Input your answer and receive immediate feedback.

4. **Exit the Game**

   Enter `"no"` when asked if you want to play the game to exit.

## Example

```
Do you want to play the game: yes
Do you want a binary or a decimal number: binary
Here is your binary number: 110101
Enter your answer: 53
Congratulations! You entered 53 which is the correct answer.

Do you want to play the game: yes
Do you want a binary or a decimal number: decimal
Here is your decimal number: 25
Enter your answer: 11001
Congratulations! You entered 11001 which is the correct answer.
```

## Notes

- The game uses random numbers ranging from 0 to 16384 (inclusive).
- Ensure that your console window is large enough to display the game's output comfortably.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## Contributing

Feel free to fork the repository and submit pull requests. Any improvements or bug fixes are welcome!

## Contact

For any questions or feedback, please contact the project maintainer at [angelarabadzhiev82@gmail.com].

```

Feel free to adjust the contact information, repository URL, and any other details as needed!
