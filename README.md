# Simaira Digital API Integration  

## Overview  
The **Simaira Digital API Integration** project is designed for automated API integration testing using MSTest, SpecFlow, and SonarQube, with CI/CD implemented through Azure DevOps Pipelines.  

---

## Features  
- **Behavior-Driven Development (BDD):**  
  Leverages SpecFlow for writing Gherkin-based feature files to simplify and standardize test cases.  

- **Automated Testing:**  
  Implements MSTest for unit and integration testing of API endpoints.  

- **Continuous Integration/Continuous Deployment (CI/CD):**  
  Uses Azure DevOps Pipelines to automate build, test, and deployment processes.  

- **Code Quality Analysis:**  
  Integrates SonarQube for static code analysis and adherence to coding standards.  

---

## Prerequisites  
- **Development Tools:**  
  - Visual Studio 2022 or later  
  - .NET 6.0 or higher  
- **Tools & Services:**  
  - Azure DevOps account with necessary permissions  
  - SonarQube instance with project key and access token  

---

## Project Setup  

### Clone the Repository  
```bash
git clone <repository-url>
cd simaira.digital.api.integration
```

### Install Dependencies
```bash
dotnet restore
```

## Configuration  

### Configure SonarQube  
1. Open the `azure-pipelines.yml` file.  
2. Add the SonarQube project key and authentication token.  
3. Ensure the SonarQube tasks are defined in the pipeline configuration.  

### Configure Azure DevOps Pipeline  
1. Navigate to **Azure DevOps > Pipelines** and create a new pipeline.  
2. Use the `azure-pipelines.yml` file provided in the repository.  
3. Add required secrets, such as connection strings and API keys, in the pipeline’s variable configuration.  

---

## Running Tests  

### Locally  
1. Open the solution in Visual Studio.  
2. Run tests using the **Test Explorer** window.  

### Azure DevOps Pipeline  
1. Push changes to the repository.  
2. The pipeline triggers automatically, running all configured tests.  
3. View the test results in the Azure DevOps portal.  

---

## Project Structure  
```plaintext
Simaira.Digital.API.Integration/
│
├── Features/                 # Gherkin-based feature files
│   ├── Example.feature       # Sample feature file
│   └── ExampleSteps.cs       # Step definitions for the feature
│
├── Tests/                    # MSTest test cases
│   ├── UnitTests/            # Unit test cases
│   └── IntegrationTests/     # Integration test cases
│
├── azure-pipelines.yml       # Azure DevOps pipeline configuration
├── sonar-project.properties  # SonarQube configuration file
└── README.md                 # Project documentation
```
## Key Tools & Frameworks  

### MSTest  
- A testing framework for writing and running unit and integration tests.  

### SpecFlow  
- Enables Behavior-Driven Development (BDD) using Gherkin syntax to define user stories and scenarios.  

### Azure DevOps Pipeline  
- Manages CI/CD workflows, automatically triggering tests and deployments on commits and pull requests.  

### SonarQube  
- Performs static code analysis and provides reports on:  
  - Code quality  
  - Security vulnerabilities  
  - Technical debt
 
## Contributing
1. Fork this repository.

2. Create a feature branch:
```bash
git checkout -b feature/your-feature-name
```

3. Commit your changes:
```bash
git commit -m "Add feature description"
```

4. Push the branch:
```bash
git push origin feature/your-feature-name
```

5. Open a pull request in the main repository.


## License
This project is licensed under the MIT License. See the LICENSE file for details.


## Contact
For questions or support, contact:
Email: [abhishek.job@hotmail.com]
Linkedin: [[LinkedIn Profile](https://www.linkedin.com/in/firstcrazydeveloper/)]





