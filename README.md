# ACARS

ACARS stands for "Aircraft Communications Addressing and Reporting System". It's a digital data link system used to transmit messages between airplanes and ground stations via airband radio or satellite.

In terms of VirtualFlight.Online, phpVMS ACARS is a software application you can run alongside Microsoft Flight Simulator that helps you track flights, refer to operational flight plans, and review your performance while in flight.

# rACARS

rACARS is a middleware application designed to bridge the gap between flight simulation software and the PHP VMS 7 API. It acts as an intermediary to track each step of your flight in simulations such as MSFS, X-Plane, or Prepar3D, and report these details to the API of your Virtual Airline. This enables your Virtual Airline to collect and manage flight data effectively, allowing for real-time tracking and future reference of simulated flights.

## Features

- **Support for Multiple Simulators**: Works with Microsoft Flight Simulator (MSFS), X-Plane, and Prepar3D.
- **Integration with PHP VMS 7**: Seamlessly reports flight data to the PHP VMS 7 API.
- **Real-Time Flight Tracking**: Captures and reports detailed flight information in real-time.
- **Flight Data Recording**: Keeps a record of each flight for future reference and analysis.
- **Friendly User Interface**: It shows in real time your airplane in a world map as well as the flight parameters.

## Installation

### Prerequisites

1. **.NET Framework**: Ensure that the .NET Framework 4.8 or later is installed on your system.
2. **Flight Simulation Software**: MSFS, X-Plane, or Prepar3D must be installed and properly configured.
3. **PHP VMS 7 API**: Access to a PHP VMS 7 installation with API access enabled. You will need a PHP VMS 7 API Key that will be provided to you by your Virtual Airline.

## Architecture

rACARS is developed using C# and leverages the Model-View-ViewModel (MVVM) pattern in combination with Windows Presentation Foundation (WPF). 

### C# and WPF

- **C#**: The core of rACARS is written in C#, a modern and versatile programming language that provides a robust environment for application development. C# is used for implementing the application's logic, data handling, and communication with the flight simulation software and PHP VMS 7 API.

- **WPF**: rACARS utilizes WPF for its user interface. WPF is a powerful framework for building rich desktop applications with flexible and customizable user interfaces. It allows rACARS to provide an intuitive and responsive experience for users.

### MVVM Pattern

- **Model**: Represents the data and business logic of the application. It includes classes that handle data retrieval, processing, and storage.

- **View**: Represents the user interface of the application. It is responsible for displaying data and providing a way for users to interact with the application.

- **ViewModel**: Acts as an intermediary between the Model and the View. It exposes data from the Model to the View and handles user input, updating the Model accordingly.

The MVVM pattern helps in separating concerns within the application, making it easier to manage and maintain. By decoupling the user interface from the business logic, rACARS ensures a clean and manageable codebase, which also facilitates easier testing and future enhancements.

For more information on MVVM and WPF, you can refer to the [Microsoft documentation on MVVM](https://learn.microsoft.com/en-us/dotnet/architecture/maui/mvvm) and [Windows Presentatin Foundation](https://learn.microsoft.com/en-us/dotnet/desktop/wpf/overview/?view=netdesktop-8.0).

## Download / Installation / Execution

1. **Download rACARS**: WIP.

2. **Install rACARS**:
   - Extract the downloaded ZIP file and extract. Software doesn't need installation.

3. **Configuration**:
   - Open rACARS.
   - Navigate to the **Settings** tab.
   - Configure your flight simulator and PHP VMS 7 API settings (API Key).
  
## Code

The project c

## License

rACARS is licensed under the [MIT License](#). See the LICENSE file for more details.

## Original Repository

https://avillasante-hotmail.visualstudio.com/_git/rACARS

## Contact

For questions or support, please contact us at [avillasante@hotmail.com](mailto:avillasante@hotmail.comm
