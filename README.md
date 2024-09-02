# vivid/stasis Mod Template

This is a template for the [.NET Template Engine](https://github.com/dotnet/templating) to make vivid/stasis mods.

## Installation

Clone this repository and run this command:

```shell
dotnet new install --force .
```

You can then use `dotnet new vsmod` to create a new mod, or use the GUI in Visual Studio/JetBrains Rider. Make sure to run `dotnet restore` at least once after creating the project!

If you are looking to create a repository for your mod, please note that after project creation, you will have to delete the `vendor/gmsl` folder and run the following command to properly initialize it as a Git submodule:

```
git submodule add https://github.com/VSLoader/gmsl.git vendor/gmsl && git submodule update --init --recursive
```

Obviously this does require you to initialize a Git repository with `git init` beforehand.

## Problems

If the mod doesn't build out of the box after creation, this is considered a bug. Please create an issue!
