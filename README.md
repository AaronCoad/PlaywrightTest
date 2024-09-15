# Purpose
Learning how Playwright can be used to test Razor ASPNET Core applications to support automated unit testing of UI/UX.

# Current State
Uses the default ASPNET Core Razor project and some basic tests from the Playwright Getting Started docs.

# Usage
The following steps only need to be performed the first time or when you want to retrieve the latest browser versions for testing:
 - Run `dotnet build` against the test project
 - Run `pwsh ./bin/Debug/net8.0/playwright.ps1 install`

Perform the following steps for each test run / build of the tested application:
 - Open a second terminal and cd into src/TestRazor and run `dotnet run`
 - Go back to the original terminal and run `dotnet test`