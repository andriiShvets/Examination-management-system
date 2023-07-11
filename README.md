# Examination-management-system
Examify is a desktop application written in .NET, utilizing Windows Forms, Dapper framework, and Microsoft SQL Server. It serves as an examination management system designed for teachers to manage test exams. The application has two types of users: teachers and students.

Teacher Interface
Upon opening the application, the user is presented with the login form (LoginForm.cs). The teacher can either exit the program or log in by clicking the "Admin" button. To log in, the teacher must enter their email address and password on the TeacherLoginForm.cs form (Fig. 3.4). If the entered credentials exist in the TeacherTbl database table, the teacher is redirected to the SubjectsForm.cs window (Fig. 3.5).

SubjectsForm
In the SubjectsForm, teachers can create subjects for exams. They can specify the number of questions and the time limit for the exam. The form also displays a DataGridView showing all the subjects associated with the specific teacher, retrieved from the SubjectTbl table based on the TeacherId. Teachers can add, edit, or delete subjects using the provided functionality. The form includes a menu platform for easy navigation between forms.

QuestionsForm
The QuestionsForm is used for creating exam questions. Teachers can select a subject from a ComboBox and add questions by providing descriptions, answer options, correct answers, and point values. The DataGridView displays all the questions associated with a particular subject, retrieved from the QuestionTbl table. Teachers can delete questions from the database by selecting a row and clicking the "Delete" button.

ResultsForm
The ResultsForm allows teachers to view the results of student exams. The DataGridView displays the results obtained by students upon completing the exam. Teachers can export this table as a text file, containing a list of students and their scores, filtered by subject and selected group.

Student Interface
Upon opening Examify, students are presented with the login form (LoginForm.cs). If the student has not yet taken the exam and enters a valid Gmail address and password, they are shown a window with exam rules (Fig. 3.11). Once the student agrees to the rules, a set number of questions for the subject they are registered for and the time limit are retrieved from the database.

ExamForm
The ExamForm (Fig. 3.12) is where students take their exams. The form displays the subject name and student's name. Questions are presented one at a time, with answer options displayed as checkboxes. Students can navigate between questions using the "Previous" and "Next" buttons or the numbered buttons on the left side of the form. Selected answers are stored using the SelectedAnswer property in the Question.cs class.

Completion of the exam occurs in three scenarios: the time limit is reached, the student clicks the "Submit" button, or the student attempts to open another program or switch to another tab on their computer while the ExamsForm window is open. Focus is monitored using the OnDeactivate() method, which is triggered when the form loses focus (Fig. 3.13). In any case, the results are automatically calculated and stored in the ResultTbl table using the Result.cs and SqlConnection.cs classes. The recorded information includes StudentId, SubjectId, score, and the date and time of the exam. The ExamAccess field for the student is set to False, preventing them from retaking the exam.

Prerequisites
To run the Examify application, ensure that you have the following dependencies installed:

.NET Framework
Windows Forms
Dapper framework
Microsoft SQL Server
Installation
Clone the repository to your local machine.
Build the solution using Visual Studio or the .NET CLI.
Set up the Microsoft SQL Server database and configure the connection string in the application.
Run the application.
Usage
Launch the Examify application.
Log in as a teacher using valid credentials.
Navigate through the different forms to manage subjects, questions, and view results.
Log in as a student using a valid Gmail address and password.
Review the exam rules and start the exam.
Answer the questions sequentially and submit the exam.
View the results.
License
This project is licensed under the MIT License.

Acknowledgments
Dapper - A simple object mapper for .NET
Microsoft SQL Server - Relational database management system
Windows Forms - UI framework for creating desktop applications
