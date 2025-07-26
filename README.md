
# Student Attendance Management System

A Windows Forms application for managing student attendance, built with Visual Basic .NET and SQL Server.

## Features

- Teacher, student, and attendance management
- Secure login for teachers and students
- Attendance tracking by class and roll number
- Simple, user-friendly interface

## Requirements

- **Visual Studio** (2015 or later recommended)
- **.NET Framework 4.0** or higher
- **SQL Server** (Express or above)

## Getting Started

### 1. Clone or Download the Repository

Download or clone this repository to your local machine.

### 2. Database Setup

1. Open SQL Server Management Studio.
2. Run the `attend.sql` script located in the `student attendence` folder to create the database and tables.
3. The database includes the following tables:
   - **Teacher**: Id (PK), name, gen, contact, email, addr, subject, age, pass, salary
   - **Student**: Id (PK), name, gen, contact, email, addr, dob, class, Rno, pass
   - **Attendance**: tid, class, date, RN01 ... RN40 (attendance for each roll number)

### 3. Update Connection String

After creating the database, update the connection string in the application to match your SQL Server instance and database path. Search for `SqlConnection` in the `.vb` files and replace the existing connection string if needed.

### 4. Build and Run the Application

1. Open `student attendence.sln` in Visual Studio.
2. Restore any missing NuGet packages if prompted.
3. Build the solution (`Build > Build Solution`).
4. Run the application (`Debug > Start Debugging`).

## Project Structure

- `student attendence/` - Main application source code and resources
- `attend.sql` - SQL script to create and populate the database
- `Resources/` - Images and icons used in the application

## Customization

- To change the database connection, update the connection string in the code.
- You can modify forms and logic as needed for your institution's requirements.

## Screenshots

Add screenshots of the application UI here (optional).

## License

This project is for educational purposes.

---
Thank you for using the Student Attendance Management System!
