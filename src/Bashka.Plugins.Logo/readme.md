# Bashka.Plugins.Logo

A demonstration plugin showing how to customize Bashka's interface with a visual
extension. It displays a colored ANSI BASHKA logo in the About view.

## What it demonstrates

- Registering a `VisualExtension` with Autofac in `PluginModule`.
- Loading an Avalonia style resource through `PluginVisualExtension.StyleUris`.
- Replacing the content template of `ContentControl.Bashka.AboutLogo` in `Styles.axaml`.
- Embedding `Assets/Bashka.ans` as an Avalonia resource and displaying it with an `Image`.

This sample adds a visual customization only; it does not register commands.

## Run locally

With the .NET 10 SDK installed, run from the project directory:

```sh
dotnet run
```

`Program.cs` launches Bashka with this plugin through `Bashka.Launcher` for local
development. Open the About view to see the logo.

## Build a NuGet package

```sh
dotnet pack -c Release
```

The package includes this README, the plugin assembly, and its embedded styles
and ANSI logo. The package ID matches the assembly name, and the `bashka-plugin`
tag lets Bashka discover the plugin.

`Bashka.Plugins` supplies the shared plugin APIs. Its runtime assets are excluded
because the installed plugin uses the host's shared assemblies. `Bashka.Launcher`
is a private development dependency and is not exposed to package consumers.
Keep both Bashka package references on matching versions when updating them.
