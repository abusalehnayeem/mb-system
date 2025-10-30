# Coding Guidelines

## C# Naming Conventions

*   **Classes, Interfaces, Enums, Methods, Properties, Events**: Use `PascalCase`.
*   **Local Variables, Method Arguments**: Use `camelCase`.
*   **Private Fields**: Use `_camelCase` with a leading underscore.
*   **Interfaces**: Prefix with `I` (e.g., `IService`).

## C# Code Style

*   Use `using` statements at the top of the file to import namespaces.
*   Always specify access modifiers (e.g., `public`, `private`, `protected`).
*   Use expression-bodied members for simple one-line methods and properties.
*   Organize class members in a consistent order: fields, constructors, properties, methods.

## XAML Style

*   Use `x:Name` for elements that need to be referenced from code-behind, and use `PascalCase`.
*   Define resources in a `ResourceDictionary` and reuse them where possible.
*   Use a consistent indentation style.

## Comments

*   Write clear and concise comments to explain complex or non-obvious code.
*   Avoid commenting on obvious code.
*   Use XML documentation comments for public APIs.

## MVVM Pattern

*   Follow the Model-View-ViewModel (MVVM) pattern.
*   **View**: Contains only UI-related code. Code-behind should be minimal.
*   **ViewModel**: Contains the presentation logic and state of the view. It should not have any reference to the View.
*   **Model**: Represents the data and business logic.
