# Bashka.Plugins.Logo

A demonstration plugin for [Bashka](https://github.com/jinek/bashka/) that
customizes the About view with a colored ANSI BASHKA logo.

The sample shows how to register a visual extension with Autofac, load Avalonia
styles, replace the `ContentControl.Bashka.AboutLogo` content template, and display
an embedded `.ans` asset. It adds no commands.

<img width="1870" height="841" alt="image" src="https://github.com/user-attachments/assets/5a42ba5d-ef49-4341-b70f-b59644921faf" />


## Run the demonstration

Run [Bashka](https://github.com/jinek/bashka/) normally, open **Plugins**, and
install `Bashka.Plugins.Logo`. Open the About view to see the logo.

### Run from source

Install the .NET 10 SDK, then run from the repository root:

```sh
dotnet run --project src/Bashka.Plugins.Logo
```

Open Bashka's About view to see the logo.

## Explore the example

The project lives in `src/Bashka.Plugins.Logo`:

- `PluginModule.cs` registers the visual extension.
- `PluginVisualExtension.cs` provides the style resource URI.
- `Styles.axaml` defines the logo content template.
- `Assets/Bashka.ans` contains the ANSI lettering and colors.
- `Program.cs` starts the development host with the plugin loaded.

## Package

```sh
dotnet pack src/Bashka.Plugins.Logo -c Release
```

The NuGet package uses the `bashka-plugin` discovery tag and includes this
repository README, including the screenshot.

## License

See [LICENSE](LICENSE).
