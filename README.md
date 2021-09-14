# MidiMapper (In Development)

## Overview
MidiMapper is a Windows Form Application that maps MIDI signals into customizable keyboard/mouse input. The keyboard/mouse input is done using the [InputManager library](https://www.codeproject.com/Articles/117657/InputManager-library-Track-user-input-and-simulate) which supports DirectX and therefore allows in-game inputs. To receive and process MIDI messages the application uses [NAudio](https://github.com/naudio/NAudio) as a library.

The application allows for profiles to be created and loaded. This way it is possible to easily switch between user-made profiles. These profiles can be described through `.txt` files as explained [here](user-profiles) or can be managed via the application's interface.

The following diagram displays the system's overview:

<img src="resources/app-overview.png" width="850">

## Table of Contents
- [Functionalities](#functionalities)
- [Preview](#preview)
- [MIDI Device Setup](#midi-device-setup)
- [User Profiles](#user-profiles)

## Functionalities
MidiMapper exposes the following functionalities:
- Functional and intuitive Windows Form Application to map MIDI signals into keyboard/mouse input
- MIDI device selection
- Run in background option
- Event Log which displays the keys being pressed and its respective macros
- Profile management
    - Create unlimited profiles with sets of macros
    - Customize macros
        - Add/Edit/Delete
        - Add a title to describe a macro
        - Support for keyboard/mouse actions as macros 
    - Save profiles to `.txt` files
    - Load profiles into MidiMapper

## Preview
<img src="resources/app-preview.png" width="850">

## MIDI Device Setup
MidiMapper's interface displays a selection of connected MIDI devices allowing the user to pick the desired one. Furthermore, the application provides buttons to start and stop the listening of key presses on the selected device.

In order to avoid unexpected errors, make sure the MIDI drivers for the specific device are correctly installed!

The following image exhibits an example of the device selection provided by the application's interface:

<img src="resources/app-midi-device-selection.png">

## User Profiles
...