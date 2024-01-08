using System;
using Microsoft.Data.SqlClient;

class Program
{
static string connectionString = "Data Source=127.0.0.1,1433;Initial Catalog=fptacademy;User Id=admin;Password=fptaptech123;";


static void Main()
{
while (true)
{
Console.WriteLine("Choose operation:");
Console.WriteLine("1. Create");
Console.WriteLine("2. Read");
Console.WriteLine("3. Update");
Console.WriteLine("4. Delete");
Console.WriteLine("5. Exit");

string choice = Console.ReadLine();

switch (choice)
{
case "1":
CreateStudent();
break;

case "2":
ReadStudents();
break;

case "3":
UpdateStudent();
break;

case "4":
DeleteStudent();
break;

case "5":
Environment.Exit(0);
break;

default:
Console.WriteLine("Invalid choice. Please try again.");
break;
}
}
}

static void CreateStudent()
{
Console.WriteLine("Enter first name:");
string firstName = Console.ReadLine();

Console.WriteLine("Enter last name:");
string lastName = Console.ReadLine();

using (SqlConnection connection = new SqlConnection(connectionString))
{
connection.Open();

string query = $"INSERT INTO Student (s_fnam, s_lname) VALUES ('{firstName}', '{lastName}')";

using (SqlCommand command = new SqlCommand(query, connection))
{
int rowsAffected = command.ExecuteNonQuery();

if (rowsAffected > 0)
Console.WriteLine("Student created successfully!");
else
Console.WriteLine("Failed to create student.");
}
}
}

static void ReadStudents()
{
using (SqlConnection connection = new SqlConnection(connectionString))
{
connection.Open();

string query = "SELECT * FROM Student";

using (SqlCommand command = new SqlCommand(query, connection))
{
using (SqlDataReader reader = command.ExecuteReader())
{
while (reader.Read())
{
Console.WriteLine($"ID: {reader["sid"]}, First Name: {reader["s_fnam"]}, Last Name: {reader["s_lname"]}");
}
}
}
}
}

static void UpdateStudent()
{
Console.WriteLine("Enter student ID to update:");
int studentId = int.Parse(Console.ReadLine());

Console.WriteLine("Enter new first name:");
string newFirstName = Console.ReadLine();

Console.WriteLine("Enter new last name:");
string newLastName = Console.ReadLine();

using (SqlConnection connection = new SqlConnection(connectionString))
{
connection.Open();

string query = $"UPDATE Student SET s_fnam = '{newFirstName}', s_lname = '{newLastName}' WHERE sid = {studentId}";

using (SqlCommand command = new SqlCommand(query, connection))
{
int rowsAffected = command.ExecuteNonQuery();

if (rowsAffected > 0)
Console.WriteLine("Student updated successfully!");
else
Console.WriteLine("Failed to update student. Make sure the student ID exists.");
}
}
}

static void DeleteStudent()
{
Console.WriteLine("Enter student ID to delete:");
int studentId = int.Parse(Console.ReadLine());

using (SqlConnection connection = new SqlConnection(connectionString))
{
connection.Open();

string query = $"DELETE FROM Student WHERE sid = {studentId}";

using (SqlCommand command = new SqlCommand(query, connection))
{
int rowsAffected = command.ExecuteNonQuery();

if (rowsAffected > 0)
Console.WriteLine("Student deleted successfully!");
else
Console.WriteLine("Failed to delete student. Make sure the student ID exists.");
}
}
}
}ass General;
