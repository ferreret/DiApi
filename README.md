# Minimal API with .NET Framework 8.0

This project demonstrates how to build a minimal API using .NET Framework 8.0, with a focus on explaining and implementing Dependency Injection (DI).

## Table of Contents

- [Introduction](#introduction)
- [What is Dependency Injection?](#what-is-dependency-injection)
- [Getting Started](#getting-started)
  - [Prerequisites](#prerequisites)
  - [Installation](#installation)
- [Usage](#usage)
- [Contributing](#contributing)
- [License](#license)

## Introduction

This repository contains a minimal API built with .NET Framework 8.0. The primary goal of this project is to illustrate the concept of Dependency Injection (DI) and how it can be implemented in a .NET application.

## What is Dependency Injection?

Dependency Injection (DI) is a design pattern used to achieve Inversion of Control (IoC) between classes and their dependencies. In simpler terms, DI allows a class to receive its dependencies from an external source rather than creating them itself. This makes the code more modular, easier to test, and more maintainable.

**Benefits of Dependency Injection:**
- **Decoupling:** Reduces the tight coupling between classes and their dependencies.
- **Testability:** Makes it easier to inject mock dependencies, facilitating unit testing.
- **Maintainability:** Simplifies the process of changing dependencies without modifying the classes that use them.
- **Flexibility:** Enables swapping implementations of dependencies without changing the dependent class.

## Getting Started

### Prerequisites

- [.NET SDK 8.0](https://dotnet.microsoft.com/download/dotnet/8.0)

### Installation

1. Clone the repository:
   ```sh
   git clone https://github.com/yourusername/minimal-api-di.git
   cd minimal-api-di
   ```
2. Build the project
   ```sh
    dotnet build
   ```
3. Run the project
   ```sh
    dotnet run
   ```
## Usage

The minimal API includes a simple endpoint for demonstration purposes. Once the project is running, you can interact with the API using tools like curl or Postman.

## Contributions

Contributions are welcome! Please open an issue or submit a pull request for any changes.

## License

This project is licensed under the MIT License.
