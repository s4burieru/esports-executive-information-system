# Esports Executive Information System

## Mockups
<img src="https://github.com/user-attachments/assets/644fa9c5-b0d6-471c-a944-843481840528" width="45%" />
<img src="https://github.com/user-attachments/assets/0c4fc5ac-c51a-4a88-8b2e-783c811d8012" width="45%" />
 
## Description
The Esports Executive Information System (EIS) is a specialized management information system designed to support senior executives in the esports industry. The system helps top-level management monitor datas. This system offers executive-level dashboards that provide graphical displays and easy-to-use interfaces. The application is built using VB.NET within Visual Studio, utilizing the Guna UI framework for a modern aesthetic.

## Features
*   **Executive Dashboard Overview:** A high-level dashboard displaying key metrics such as **Total Players**, **Total Employees**, **Total Executives**, and **Total Sponsors**, allowing for immediate monitoring.
*   **Historical Performance Tracking:** Features a detailed bar chart showing team achievement trends over time specifically tracking 1st to 4nd place wins.
*   **Game Performance Analysis:** A pie chart visualization breaks down performance metrics by specific games.
*   **Employee and Executive Rosters:** Dedicated sections ("Employees" and "Executives" in the sidebar menu) for managing and viewing detailed information on all personnel within the organization.
*   **Financial Oversight:** A "Finance" menu option for tracking spendings.
*   **Sponsor Management:** The "Sponsors" section allows executives to manage relationships among them.
*   **Intuitive Interface:** Built with the Guna UI framework to ensure an easy-to-use, modern graphical interface for swift data retrieval and decision making.

## Technologies Used
*   **IDE:** Visual Studio
*   **Language:** VB.NET
*   **Platform:** .NET Framework
*   **Frontend UI:** Guna UI Framework (Windows Forms)
*   **Database:** Ms Access

## Getting Started
Follow these steps to get a copy of the project up and running on your local machine for development and testing purposes.

### Prerequisites
*   **Visual Studio:** A compatible version of Visual Studio (e.g., VS 2012, VS 2022) must be installed.
*   **.NET Framework:** The target .NET Framework version must be installed on the development machine.
*   **Guna UI Framework:** The Guna UI library must be licensed and installed/referenced within your Visual Studio environment.

### Installation

1.  **Clone the repository:**
    ```sh
    git clone https://github.com/s4burieru/esports-executive-information-system.git
    ```

2.  **Open the project in Visual Studio:**
    *   Navigate to the cloned directory and open the `EsportsEIS.sln` solution file with Visual Studio.

3.  **Restore NuGet Packages:**
    *   Ensure all necessary packages are restored (Right-click the solution in Solution Explorer -> Restore NuGet Packages).

4.  **Verify Guna UI References:**
    *   Confirm that the Guna UI components are correctly referenced in the project. If not, you may need to manually add the reference via "Manage NuGet Packages" or by referencing the locally installed DLLs, depending on your license method.

### Running the Project

*   **Build the solution:**
    *   In Visual Studio, select `Build` > `Build Solution` (Ctrl+Shift+B).
