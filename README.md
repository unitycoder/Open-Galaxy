# Open-Galaxy
![screenshot](https://github.com/MichaelEGA/Open-Galaxy/assets/67586167/d8400322-e72b-415f-a0b1-1a59dd9299f8)

Open Galaxy is a X-Wing and Tie Fighter style space sim designed to be a platform for custom missions made by the community. 

**Main Features**

  - X-Wing and Tie Fighter style ship combat (Implemented)
  - Missions and other game modes (Implemented)
  - Cockpits (Implemented)
  - Capital ships (Implemented)
  - Tile Generation for Cities and Death Star (Implemented)
  - Easy to use mission editor (In Progress)
  - External mission loading (Not implemented yet)
  - Accurate Star Wars galaxy i.e the star locations accurately represent the galaxy (Implemented)
  - Explore mode where you can explore the whole Star Wars galaxy (In progress)

**Latest Release:** 0.6.2

Find it here: https://github.com/MichaelEGA/Open-Galaxy/releases

**Other Info**

  - Roadmap: https://docs.google.com/spreadsheets/d/14mWjYlATWQYKEfD6AG4MwC_ppTzG-aDlsI2yR2h7D54/edit?usp=sharing
  - Missions: https://docs.google.com/spreadsheets/d/1Gh4fdxHZI7DfOsCidDuX5mCqRGvpNe71Tga3iwFPoFA/edit?usp=sharing
  - Ship Stats: https://docs.google.com/spreadsheets/d/1PwTEx9dPTEhxY5ebIWjXgZj0bz84qzDL47KDm0aw8FU/edit?usp=sharing
  - Galaxy Data: https://docs.google.com/spreadsheets/d/13MOCvB86lFkK4HSIt8wtAJS5BCVGm4-Zh3ffCMEnTAI/edit?usp=sharing


**Changelog**

03/09/23 - v.0.6.2
  - Update: Death Star test mission with new messages and enemies
  - Added: Tile Loading to mission functions. 
  - Added: Death Star Mission - Our Moment of Triumph
  - Update: death star tiles and tiling code
  - Added: Code for generating tiles
  - Update: FS and GC cockpit models
  - Update: First Strike X-Wing cockpit is now slightly more accurate
  - Fixed: Torpedoes not exploding 
  - Added: high resolution cockpit textures for FS
  - Update: GC X-Wing cockpit improved

27/08/23 - v.0.5.7
  - Added: Galactic Conquest Cockpits, Bomber attack pattern, dynamic thruster placement
  - Added: Turret explodes on destruction + some general cleaning up
  - Added: Cockpit rotation for lighting effects
  - Added: Toggle Cockpit Sets, Torpedoes damage cap ships
  - Fixed: turret tracking bud
  - Added: Turrets can be destroyed

21/08/23 - v.0.5.21
  - WARNING: This version may temporarily break some missions like 'Assault on Empress Station' 
  - Upside Down Turret Rotation Fixed, and Capital Ships are Destroyed
  - All turret prefabs set up, initial code for upside down turrets
  - Fixed capital ship jitter, turret firerates and damage, capital ship …
  - Begun to add code to toggle cockpit sets
  - Capital ships now deal and take laser damage
  - Fixed laser color bug
  - Capital ship turrets now fire lasers
  - Implemented variable values for different turrets
  - Added rotation restrictions on turrets
  - turret rotation improvements

13/08/23 - v.0.5.2
  - Added capital ship turret loading
  - Added "In Development" mission category
  - Correctly Implemented Code for Avoiding Collisions with large objects
  - Fixed bug that causes stationary "capital ships" (i.e. stations) to move
  - Rudimentary capital ship support complete
  - Created base functions for capital ships

08/08/23 - v.0.5.1
  - Finished adding cockpits, removed hud shake and hud glass
  - Added dynamic head movement
  - Added cockpit shake

05/08/23 - v.0.5.01
  - Update aes_b1.wav
  - Fixed torpedoes locking on instantly
  - Fixed target representation not showing

02/08/23 - v.0.5.0
  - Updated cursor and fixed loading placement problems
  - Updated all three training missions and the menu script
  - Minor updates to several missions
  - Updated game mode: the ladder
  - Added game mode: the ladder rebel
  - Updated game mode: the ladder imperial
  - Added new game mode: the ladder imperial
  - Added dynamic messages to title and load screens

30/07/23 - v.0.49.1
  - Added new mission functions: set target, set ai override mode
  - Added invert options and planet heightmap resolution options
  - Added external loading and saving of game settings from the persistent data file
  - Made separate loading pathways for standard audio and mission audio
  - Added new mission - Corrans Nightmare Part 2

27/07/23 - v0.49.0
  - First Commit
