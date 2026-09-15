# Jummpy Bunny

Jummpy Bunny is a 2D endless-runner game developed using Unity and C#.

The project focuses on basic gameplay programming, physics-based player movement, procedural level generation, collectibles, scoring, UI, and game-state management.

## Features

- Player movement and jumping using `Rigidbody2D`
- Ground detection using `Physics2D.Raycast`
- Procedural level-block generation
- Automatic removal of old level blocks
- Coin collection system
- Score calculation based on player distance
- Persistent high-score storage using `PlayerPrefs`
- Menu, gameplay, and game-over states
- Camera-follow system
- Character animations
- UI integration

## What I Worked On

I implemented the gameplay logic and supporting systems in C#, including:

- Player movement and jump mechanics
- Ground detection and physics handling
- Level generation using reusable level-block prefabs
- Game-state management
- Coin collection and scoring
- High-score persistence
- Camera movement and UI behavior
- Player death and restart logic

## Technologies

- Unity
- C#
- Unity 2D Physics
- Animator
- Prefabs
- TextMeshPro / Unity UI

## How the Game Works

The player controls a bunny moving through a continuously generated 2D level.

As the player progresses:

1. New level blocks are generated.
2. Older blocks are removed to keep the level manageable.
3. The player can collect coins.
4. Distance travelled is used as the score.
5. The highest score is stored between sessions.
6. Hitting a kill trigger ends the game and displays the game-over screen.

## Controls

- **Space** or **W** — Jump
- **Mouse Click** — Jump

## Unity Version

Built using **Unity 2020.3.23f1**.

## Purpose

This project was created to practice game-development concepts including C# scripting, object-oriented programming, Unity physics, procedural content generation, debugging, and gameplay-system design.

## Future Improvements

Some improvements I would like to explore include:

- Refactoring and improving code organization
- Adding more level-block variations
- Improving difficulty progression
- Adding additional gameplay mechanics
- Improving animations and visual effects
- Expanding the scoring and achievement systems
