# Examination-management-system
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

## ExamifyDB Database Description

The project uses the Dapper framework to handle database connectivity. Dapper is a simple and fast framework that allows executing SQL queries and mapping the results to objects.

The system utilizes the following tables:

- **TeacherTbl**: Stores data about teachers, including their identifier, password, name, and email.
- **SubjectTbl**: Stores data about subjects, including the subject identifier, teacher identifier, subject name, number of questions, and time limit.
- **StudentTbl**: Stores data about students, including their identifier, subject identifier, student score, exam access, group, name, password, and email.
- **QuestionTbl**: Stores data about questions, including the question identifier, subject identifier, question description, answer options, and question score.
- **ResultsTbl**: Stores data about student results, including the result identifier, student identifier, subject identifier, score, and timestamp.

Using these tables and their relationships, we can efficiently store and retrieve data about teachers, subjects, students, questions, and their respective results within the application.

## License

This project is licensed under the [MIT License](LICENSE).

