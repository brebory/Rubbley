Rubbley
=======

Rubbley is an iOS and Android game built on the MonoGame framework. It is a touch-based action-puzzle game set in space.

Contents
========

1. [Development Environment Setup](#development-environment-setup)
2. [Build Process](#build-process)
3. [Example Workflow](#example-workflow)
4. [Documentation](#documentatation)


Development Environment Setup
=============================

Rubbley depends on `cocos2d`, `box2d`, `Lidgren.Network`, and `MonoGame`. It's also recommended to use [Xamarin Studio](http://xamarin.com/) for development
in order to facilitate cross-platform development. Install the `cocos2d-xna` library to an appropriate location for your platform using git. (Ex: `/User/usrname/Library`
on Mac)

`git clone https://github.com/mono/cocos2d-xna.git`

Follow the instructions in the README for [`cocos2d-xna` on github](https://github.com/mono/cocos2d-xna) to build the project.


Build Process
=============

Using Xamarin Studio, add existing project solutions for `box2d.iOS`, `cocos2d.iOS`, `Lidgren.Network.iOS`, and `MonoGame.Framework.iOS`. (Cross-platform build process coming soon)
Use the iPhone Simulator to test code.


Example Workflow
================

1. Make your own fork of `snackpackgames/Rubbley`
2. Create feature branches off of the `develop` branch, merge them back into `develop` when they're complete. Never check code into master until it's fully documented and tested.
	* on branch `develop`: `git checkout -tb [your-branch-name]`
	* on branch `develop`: `git merge [your-branch-name]`
3. Once your code is sucessfully merged into your fork's master branch, make a pull request to the `snackpackgames/Rubbley` develop branch to integrate your changes.
4. Once code has been code reviewed, tested on multiple platforms, and debugged, it will be merged into `snackpackgames/Rubbley:master`.


Documentation
=============

COMING SOON!
