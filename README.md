# ❌ Tic Tac Toe Game (C# Windows Forms)

A classic **Tic Tac Toe (XOX)** game built with **C# and Windows Forms**, where a human player (❌) competes against a basic AI computer opponent (⭕). The game provides a simple interactive GUI, win detection, and alternating moves.

---

## 🕹️ Gameplay
- The user plays as `"X"`, the computer plays as `"O"`.
- The game board is a 3x3 grid.
- The player inputs `"X"` into a textbox, then clicks the corresponding button to lock the move.
- After the player's move, the computer randomly selects an empty cell and fills it with `"O"`.
- The game checks win conditions after each move and announces the winner.

---

## 📦 Features
- ✅ Fully interactive GUI using Windows Forms
- 🧠 Simple computer AI using random move generation
- 🎯 Automatic win detection for both player and computer
- 🔒 Cell locking after a move (disabling further edits)
- 📉 Ends game automatically upon a win condition

---

## 🛠️ Technologies Used
- Programming Language: **C#**
- Framework: **.NET Framework / Windows Forms**
- IDE: **Visual Studio**
---

## 🧱 Project Structure
TicTacToeGame/
│
├── Models/
│ ├── Player.cs # Represents the human player
│ ├── Computer.cs # Represents the computer AI opponent
│
├── Form1.cs # Main form UI and game logic
├── Form1.Designer.cs # Auto-generated Windows Forms layout code
├── TicTacToeGame.csproj # Project configuration
└── README.md

## 🧠 Logic Overview
Player
Represents the human player with:
Name, LastName, and FullName
Computer:
Picks a random empty cell from the board using:
Random.Next(0, 9)

## Win Detection
Checks all win possibilities (rows, columns, diagonals)
Ends the game using Application.Exit() once a win is detected.
