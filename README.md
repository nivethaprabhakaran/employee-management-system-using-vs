 Employee Management System

This is a simple Employee Management System implemented in VB.NET. It allows users to manage employee data, calculate salaries, and generate salary slips.

 Features

- Login: Users can log in using a hardcoded username and password.
- Main Form: Provides navigation to different sections of the application.
- Employee Management: Allows CRUD operations on employee data.
- Details: Displays detailed information about a specific employee.
- Salary Calculation: Calculates the salary of an employee based on the number of days worked.
- Salary Slip Generation: Generates a printable salary slip.

login.vb: This file contains the code for the login form. Users need to enter their username and password, and if it matches the hardcoded values ("nivi" for both), they are logged in and redirected to the main form.

mainform.vb: This file represents the main form of your application. It provides navigation options to different sections such as employee management, details, and salary. It also has event handlers to show other forms like employeemanage, details, and salary based on user interactions.

employeemanage.vb: This file contains code for managing employees. Users can add, delete, update, and view employee details. It interacts with a database (assumed to be SQL Server) using ADO.NET for CRUD operations.

details.vb: This file is responsible for displaying details of a specific employee. Users can input an employee ID, and it retrieves and displays their details from the database.

salary.vb: This file handles salary-related functionalities. Users can input an employee ID and the number of days worked to calculate their salary. It also provides a feature to generate a salary slip.


 Setup

1. Clone the repository:
   
   ```
   git clone <repository-url>
   ```

3. Open the project in Visual Studio or any compatible VB.NET IDE.

4. Build and run the project.

5. Log in with the username "nivi" and password "nivi" to access the system.

 Usage

1. Upon logging in, you will be directed to the main form.

2. Navigate to different sections using the provided buttons:
   - Employee Management: Add, delete, update, and view employee details.
   - Details: View detailed information about a specific employee.
   - Salary: Calculate and generate salary slips for employees.

3. Ensure to input valid data and follow the instructions provided in each section.

