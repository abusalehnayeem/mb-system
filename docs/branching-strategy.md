# Branching Strategy

This project will use a branching strategy based on GitFlow. The main branches are:

* **main**: This branch contains production-ready code. All development work is merged into `main` through pull requests.
* **develop**: This is the main development branch. All feature branches are created from `develop` and merged back into it.

## Feature Branches

* All new features should be developed in a `feature/` branch.
* Branch names should be descriptive (e.g., `feature/user-authentication`).
* Feature branches are created from `develop`.
* Once a feature is complete, a pull request is created to merge it into `develop`.

## Release Branches

* When the `develop` branch is ready for a release, a `release/` branch is created (e.g., `release/v1.0.0`).
* This branch is used for final testing and bug fixes.
* Once the release is ready, it is merged into `main` and tagged with the version number. The changes are also merged back into `develop`.

## Hotfix Branches

* If a critical bug is found in production, a `hotfix/` branch is created from `main`.
* The bug is fixed in this branch.
* The hotfix is merged back into both `main` and `develop`.
