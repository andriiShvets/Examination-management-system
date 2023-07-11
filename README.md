# Examination-management-system desctop application
# Examify - Examination Management System

This is a desktop application written in .NET with the use of Windows Forms, Dapper framework, and Microsoft SQL Server. It serves as an examination management system designed for teachers to manage test exams. The application has two types of users: teachers and students.

## Table of Contents

- [Description](#description)
- [Features](#features)
- [Prerequisites](#prerequisites)
- [Installation](#installation)
- [Usage](#usage)
- [Class Modules](#class-modules)
- [ExamifyDB Database Description](#examifydb-database-description)
- [License](#license)

## Description

Examify is a desktop application that helps teachers manage exams, specifically test exams. It provides a user-friendly interface for teachers to create subjects, add questions, view student results, and more. Students can log in, take exams, and view their scores.

## Features

- Teacher Interface:
  - Create subjects for exams.
  - Add questions to subjects.
  - View and save student results.
- Student Interface:
  - Log in and take exams.
  - View exam rules.
  - Submit answers and view scores.

## Screenshots

### Teacher Interface

![image](https://github.com/andriiShvets/Examination-management-system/assets/62800787/12987de7-8127-46d3-b04a-1e59c5d0dc5a)
- *Figure 1: Login form.*

![image](https://github.com/andriiShvets/Examination-management-system/assets/62800787/9f15d805-1ea4-4c2a-a1dc-8141b99bd2c0)
- *Figure 2: Teacher's login form.*

![image](https://github.com/andriiShvets/Examination-management-system/assets/62800787/524b0f66-144a-4995-b4fd-ba687cdd06ad)
- *Figure 3: Subjects form.*

![image](https://github.com/andriiShvets/Examination-management-system/assets/62800787/2589642c-89d4-4f1f-bb40-146e7dcd10fc)
- *Figure 4: Questions form.*

![image](https://github.com/andriiShvets/Examination-management-system/assets/62800787/5de4af5f-6cd2-4192-9c3d-c7bdef4a5859)
- *Figure 5: Students form.*

![image](https://github.com/andriiShvets/Examination-management-system/assets/62800787/d9b3b68e-a911-4c1e-b220-af6dd6e0b1eb)
- *Figure 6: Results form.*

![image](https://github.com/andriiShvets/Examination-management-system/assets/62800787/05bb22f3-8fc1-4541-8041-42bb06b3d82e)
- *Figure 7: Loaded file from the results form of students' grades.*

### User Interface

![image](https://github.com/andriiShvets/Examination-management-system/assets/62800787/bd9db99e-0e63-443c-bc8e-a5804165a42f)
- *Figure 8: Notification about the start of the exam.*

![image](https://github.com/andriiShvets/Examination-management-system/assets/62800787/a47e511e-6d5d-4d52-8493-8e48bb779163)
- *Figure 9: Exams form.*

![image](https://github.com/andriiShvets/Examination-management-system/assets/62800787/745459e8-2082-49a6-9a28-b1b88126d4a7)
- *Figure 10: Call to the OnDeactivate() method on the ExamsForm when exam ends.*

## Prerequisites

To run the Examify application, ensure that you have the following dependencies installed:
- .NET Framework
- Windows Forms
- Dapper framework
- Microsoft SQL Server

## Installation

1. Clone the repository to your local machine.
2. Build the solution using Visual Studio or the .NET CLI.
3. Set up the Microsoft SQL Server database and configure the connection string in the application.
4. Run the application.

## Usage

1. Launch the Examify application.
2. Log in as a teacher using valid credentials.
3. Navigate through the different forms to manage subjects, questions, and view results.
4. Log in as a student using a valid Gmail address and password.
5. Review the exam rules and start the exam.
6. Answer the questions sequentially and submit the exam.
7. View the results.

## Class Modules

The Examify application utilizes the following class modules:

- **User**: An abstract class that defines common properties and methods for system users. It includes fields such as an identifier, name, password, and email. This class serves as the base class for the **Teacher** and **Student** classes.
- **Teacher**: This class inherits from the **User** class and contains additional properties specific to teachers. It includes methods for adding and deleting subjects, creating questions, and updating student results.
- **Student**: This class also inherits from the **User** class and includes properties specific to students. It provides methods for viewing available subjects, submitting answers to questions, and viewing their results.
- **Subject**: This class represents a subject in the system. It has properties such as an identifier, subject name, number of questions, and time limit for the test.
- **Question**: This class represents an individual question in the system. It includes properties such as an identifier, subject identifier, question description, and answer options.
- **Result**: This class represents a student's result for a specific subject's test. It includes properties such as a result identifier, student identifier, subject identifier, score, and timestamp.
- **CommonUtil**: This class contains common utilities and helper methods that can be used in various parts of the system.
- **SqlConnector**: This class utilizes the Dapper framework for database communication and executing SQL queries.

### Modular structure of the Examify application
![image](https://github.com/andriiShvets/Examination-management-system/assets/62800787/cd212570-3753-4ca5-92d9-f92a41ed9c54)


## ExamifyDB Database Description

The project uses the Dapper framework to handle database connectivity. Dapper is a simple and fast framework that allows executing SQL queries and mapping the results to objects.

The system utilizes the following tables:
### ExamifyDB database table structure

![image](https://github.com/andriiShvets/Examination-management-system/assets/62800787/11434773-8d96-409a-a7ee-2c703de07626)


- **TeacherTbl**: Stores data about teachers, including their identifier, password, name, and email.
- **SubjectTbl**: Stores data about subjects, including the subject identifier, teacher identifier, subject name, number of questions, and time limit.
- **StudentTbl**: Stores data about students, including their identifier, subject identifier, student score, exam access, group, name, password, and email.
- **QuestionTbl**: Stores data about questions, including the question identifier, subject identifier, question description, answer options, and question score.
- **ResultsTbl**: Stores data about student results, including the result identifier, student identifier, subject identifier, score, and timestamp.

Using these tables and their relationships, we can efficiently store and retrieve data about teachers, subjects, students, questions, and their respective results within the application.

## License

This project is licensed under the [MIT License](LICENSE).

Please note that the database file "ExamifyDB" is not included in this repository. You need to manually set up the database by executing the SQL scripts provided in the repository's "ExamifyDB" folder.
