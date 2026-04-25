# vex-override-scorekeeper

Standalone Unity app for real-time VEX Override scorekeeping on Beam Pro / Android AR.

## Current State

This repository is intentionally starting as a clean standalone scaffold.
It includes:

- product docs and planning notes
- a Unity-oriented folder layout
- Git initialization support

It does not yet contain a Unity-generated project or gameplay code.

## Proposed Architecture

- `Assets/Scripts/Core` - match state, timer, event log, scoring engine
- `Assets/Scripts/Rules` - rulesets and score validation
- `Assets/Scripts/UI` - HUD, setup flow, score panels
- `Assets/Scripts/Input` - touch and gesture interactions
- `Assets/Scripts/Storage` - persistence, export, import
- `Assets/Scenes` - Unity scenes
- `docs` - product and implementation planning

## Next Steps

1. Write the product spec and MVP workflow.
2. Initialize the Unity project in this repo.
3. Implement the scoring engine and local save format.
