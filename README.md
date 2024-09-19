# Flappy-Bird


This project is a Unity-based 2D game inspired by *Flappy Bird*. The player controls a bird that navigates through a series of obstacles by tapping or clicking to make the bird fly. The goal is to avoid crashing into obstacles and score as many points as possible.


Features
- Flappy Bird-style Gameplay: Simple, addictive mechanics where the player controls a bird to avoid obstacles.
- Endless Runner: The game continues as long as the player successfully avoids obstacles.
- Random Obstacle Generation: Each playthrough is unique due to randomly generated obstacle positions.
- Score Tracking: Keep track of your high scores and try to beat them!
  
Installation
To play or modify the game, follow these steps:
1. Clone the repository:
2. Open the project in Unity:
   - Ensure that you have Unity version 2021 or later installed.
   - Open the `game.sln` solution file in Visual Studio for editing scripts if needed.
3. Build the project:
   - After making any changes, you can build the game by selecting `File -> Build and Run` in Unity.

How to Play
- Controls:
  - Press or tap to make the bird fly.
  - Avoid hitting obstacles by timing your taps to navigate through gaps.
- Objective::
  - Survive as long as possible by avoiding obstacles.
  - Each obstacle you pass adds to your score.

Project Structure
This project is structured as a typical Unity project. Below are the key files and directories:
- Assets/: Contains all the game assets, such as sprites, sounds, and scripts.
- Scripts/: C# scripts used for controlling the bird's movement, generating obstacles, and managing game mechanics.
- Scenes/: Unity scene files where the game environment is set up.

Key Files
- `game.sln`: Visual Studio solution file for the project.
- `Assembly-CSharp.csproj`: Project file for the C# scripts used in the game.
- `Birdscript.cs`: Script that handles the bird's flight and collision detection.
- `pipeSpawner.cs`: Script that manages the generation of obstacles at random intervals.
- `logicManager.cs`: Manages game states such as game over and restarting.

Contributing
Contributions are welcome! To contribute, follow these steps:
1. Fork the repository.
2. Create a new branch (`git checkout -b feature-branch`).
3. Make your changes and commit (`git commit -am 'Add new feature'`).
4. Push to the branch (`git push origin feature-branch`).
5. Create a new Pull Request.


