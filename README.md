# Azure Function Template

A comprehensive .NET project template for creating Azure Functions microservices with a complete project structure including documentation, testing, and domain modeling.

## Overview

This template provides a scaffolded solution for Azure Function microservices following best practices for enterprise development. It creates a well-structured solution with separation of concerns, comprehensive testing setup, and documentation generation.

## Features

- **Azure Functions Service**: Ready-to-use Azure Function app with dependency injection setup
- **Domain Layer**: Shared domain models and business logic
- **Comprehensive Testing**: Both unit and integration test projects
- **Documentation**: Automated documentation generation setup
- **Template Parameters**: Customizable company, application, and component names
- **EditorConfig**: Consistent code formatting across the team
- **Solution Structure**: Well-organized folder structure following .NET best practices

## Prerequisites

- [.NET 6.0 SDK](https://dotnet.microsoft.com/download/dotnet/6.0) or later
- [Azure Functions Core Tools](https://docs.microsoft.com/en-us/azure/azure-functions/functions-run-local) (for local development)
- [Visual Studio 2022](https://visualstudio.microsoft.com/) or [Visual Studio Code](https://code.visualstudio.com/) with C# extension

## Installation

### Install the Template

1. Clone this repository:
   ```bash
   git clone https://github.com/AdiThakker/Azure.Function.Template.git
   cd Azure.Function.Template
   ```

2. Pack the template:
   ```bash
   dotnet pack
   ```

3. Install the template locally:
   ```bash
   dotnet new install ./nupkg/AdiThakker.Azure.Function.Template.1.0.0.nupkg
   ```

### Alternative: Direct Installation from NuGet
```bash
dotnet new install AdiThakker.Azure.Function.Template
```

## Usage

### Create a New Project

Use the template to create a new Azure Function microservice:

```bash
dotnet new adifunctionappservice -n MyNewService -o ./MyNewService --company "MyCompany" --application "MyApp" --component "MyComponent"
```

### Template Parameters

| Parameter | Required | Default Value | Description |
|-----------|----------|---------------|-------------|
| `company` | Yes | "Your Company name" | The company name that will replace "Company" in all files and namespaces |
| `application` | Yes | "Your Application name" | The application name that will replace "Application" in all files and namespaces |
| `component` | Yes | "Your Component name" | The component name that will replace "Component" in all files and namespaces |
| `includeIntegrationTest` | No | `true` | Whether to include integration test project in the generated solution |

### Example Usage

```bash
# Create a new service for Contoso's inventory management
dotnet new adifunctionappservice \
  --name InventoryService \
  --output ./ContosInventoryService \
  --company "Contoso" \
  --application "Retail" \
  --component "Inventory"
```

This will create a solution with the following namespaces:
- `Contoso.Retail.Inventory.Service`
- `Contoso.Retail.Inventory.Domain`
- `Contoso.Retail.Inventory.UnitTest`
- `Contoso.Retail.Inventory.IntegrationTest`

## Generated Project Structure

After using the template, you'll get the following structure:

```
YourProject/
├── Documentation/
│   └── Company.Application.Component.Documentation/
│       ├── Company.Application.Component.Documentation.csproj
│       └── [Documentation generation setup]
├── Source/
│   ├── Company.Application.Component.Service/
│   │   ├── Company.Application.Component.Service.csproj
│   │   ├── Startup.cs
│   │   ├── host.json
│   │   └── Properties/
│   └── Shared/
│       └── Company.Application.Component.Domain/
│           └── Company.Application.Component.Domain.csproj
├── Testing/
│   ├── Company.Application.Component.UnitTest/
│   │   └── Company.Application.Component.UnitTest.csproj
│   └── Company.Application.Component.IntegrationTest/
│       ├── Company.Application.Component.IntegrationTest.csproj
│       └── Program.cs
├── .editorconfig
└── Company.Application.Component.sln
```

### Project Descriptions

- **Service Project**: The main Azure Functions application with dependency injection configured
- **Domain Project**: Shared domain models, entities, and business logic
- **Unit Test Project**: Unit tests for your business logic and functions
- **Integration Test Project**: End-to-end tests for your Azure Functions
- **Documentation Project**: Setup for generating API documentation

## Development Workflow

1. **Build the solution**:
   ```bash
   dotnet build
   ```

2. **Run tests**:
   ```bash
   dotnet test
   ```

3. **Run Azure Functions locally**:
   ```bash
   cd Source/[YourCompany].[YourApplication].[YourComponent].Service
   func start
   ```

4. **Add new functions**:
   - Add new function classes to the Service project
   - Register dependencies in `Startup.cs`
   - Add corresponding tests

## Configuration

### Azure Functions Configuration

The template includes a basic `host.json` configuration file. Customize it according to your needs:

```json
{
  "version": "2.0",
  "functionTimeout": "00:05:00",
  "logging": {
    "applicationInsights": {
      "samplingSettings": {
        "isEnabled": true
      }
    }
  }
}
```

### Dependency Injection

Dependencies are configured in the `Startup.cs` file:

```csharp
public override void Configure(IFunctionsHostBuilder builder)
{
    // Register your services here
    builder.Services.AddScoped<IYourService, YourService>();
}
```

## Best Practices

1. **Separation of Concerns**: Keep business logic in the Domain project
2. **Dependency Injection**: Use the built-in DI container for managing dependencies
3. **Testing**: Write comprehensive unit and integration tests
4. **Configuration**: Use Azure App Configuration or Key Vault for sensitive settings
5. **Monitoring**: Implement Application Insights for monitoring and logging
6. **Security**: Follow Azure Functions security best practices

## Contributing

1. Fork the repository
2. Create a feature branch: `git checkout -b feature/my-new-feature`
3. Make your changes and add tests
4. Commit your changes: `git commit -am 'Add some feature'`
5. Push to the branch: `git push origin feature/my-new-feature`
6. Submit a pull request

## Template Development

To modify the template:

1. Edit files in the `templates/Azure.FunctionServiceTemplate.Scaffolding/` directory
2. Update `template.json` for new parameters or configuration
3. Test the template by packing and installing locally
4. Submit a pull request with your changes

## Troubleshooting

### Common Issues

1. **Template not found**: Make sure you've installed the template correctly
2. **Build errors**: Ensure all required parameters are provided
3. **Missing dependencies**: Run `dotnet restore` in the generated solution

### Getting Help

- Check the [Azure Functions documentation](https://docs.microsoft.com/en-us/azure/azure-functions/)
- Review the [.NET CLI documentation](https://docs.microsoft.com/en-us/dotnet/core/tools/)
- Open an issue in this repository for template-specific problems

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## Author

**Adi Thakker**

- Email: [Contact information]
- GitHub: [@AdiThakker](https://github.com/AdiThakker)

## Acknowledgments

- Microsoft Azure Functions team for the excellent platform
- .NET team for the powerful templating engine
- Contributors who help improve this template

---

## Version History

- **1.0.0**: Initial release with basic Azure Function microservice template
  - Azure Functions service project
  - Domain modeling support
  - Unit and integration testing setup
  - Documentation generation
  - Customizable naming parameters