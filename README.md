# vex-override-scorekeeper

Standalone Unity app for real-time VEX Override scorekeeping on Beam Pro / Android AR.

## Current State

This repository is intentionally starting as a clean standalone scaffold.
It includes:

- product docs and planning notes
- Unity-generated project metadata
- a Unity-oriented folder layout
- Git initialization support

It does not yet contain gameplay code.

## Unity Setup

This project is now initialized and locked to the Unity version below:

- Unity `6000.3.14f1`
- Install through Unity Hub
- Include Android Build Support
- Include Android SDK & NDK Tools
- Include OpenJDK

To open or initialize this project:

1. Install Unity Hub from the Unity download page.
2. In Unity Hub, install editor `6000.3.14f1` with the Android modules listed above.
3. In Unity Hub, add the folder `C:\git\vex-override-ar-scoring`.
4. Open the project from Unity Hub.
5. If Unity prompts to upgrade the project, do that work in a feature branch and commit the generated metadata changes there.

For Beam Pro / Android AR work after the project opens:

1. Open `File > Build Profiles` or `File > Build Settings`.
2. Select Android.
3. Switch the active platform to Android.
4. Confirm the project targets ARM64 before device builds.

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
2. Implement the scoring engine and local save format.
3. Add Android build configuration and first scene setup.

## Git Workflow

Use `main` as the shared integration branch.

1. Start from the latest `main`.
2. Create a feature branch for each task.
3. Push the feature branch to `origin`.
4. Open a pull request into `main`.
5. Merge the pull request after review.
6. Delete the merged branch locally and on GitHub.
