````plantuml
@startuml
skinparam classAttributeIconSize 0

class Person {
    {static} +NextId : int
    +Id : int { get; }
    +Name : string
    +Dob : DateOnly
    +Age : int { get; }
    +Person(int, string, DateOnly)
    +Person(string, DateOnly)
}

class Employee {
    +EmployeeId : int
    +Department : string
    +IsPermanent : bool
    +Employee(int, string, DateOnly,int, string, bool) 
    +Employee(string, DateOnly, int, string, bool) 
}
Person <|-- Employee

class Teacher {
    +Title : string
    +Teacher(int, string, DateOnly, int, string, bool, string)
    +Teacher(string, DateOnly, int, string, bool, string)
}
Employee <|-- Teacher
CourseOffering "*" --> "0..1" Teacher : taughtBy

class Course {
    +Code : string
    +Name : string
    +Course(string, string)
}

class CourseOffering {
    +Year : int
    +Semester : string
    CourseOffering(int, string, Course, Teacher)
}
Course "1" <-- "*" CourseOffering : course


class Student {
    +StudentId : int
}
Person <|- Student
Student "*" -> "1" Program : studies
Student "*" --> "*" CourseOffering : taking

class Program {
    +Name : string
}
Program "*" o-> "*" Course : contains
@enduml
````