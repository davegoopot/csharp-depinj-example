# csharp-depinj-example
Example code to understand dependency injection in C#

See: https://davepotts.software/development/2025/08/20/csharp-dependency-injection-learning.html

## Project Structure

- `src/DepInj.Example.Core/` - Main class library containing core business logic
- `tests/DepInj.Example.Tests/` - xUnit test project

## Building and Testing

```bash
# Build the solution
dotnet build

# Run tests
dotnet test
```

## Continuous Integration

This project uses GitHub Actions for continuous integration. The CI workflow automatically runs on:
- Push to `main` branch
- Pull requests targeting `main` branch

The CI pipeline:
1. Sets up .NET 8.0 environment
2. Restores dependencies
3. Builds the solution
4. Runs all tests

See [`.github/workflows/ci.yml`](.github/workflows/ci.yml) for the complete workflow configuration.

## Current Features

### StringReverse Class (TDD Implementation)
- Test-driven development implementation of a simple string reversal utility
- Tests created first following TDD principles, implementation pending



