![Diagramme de classes](CollegeLib.png)

[Diagramme sur PlantUML](https://www.plantuml.com/plantuml/uml/bLB1Rjim3BthAmYVbjKkkcjN5EsQ7N9f2wIN7HMRTOLOKY3Hm3BF_pvP2e78CJ3q9l7nFRv7yC6JTDJhJlYzCWVff8Qwazu_4ZcrwmatjJLRzGVXHeY8m2iwRmqC0W1W20AawX6kdl4tRHgu1MKeGbVyWm5QfEymflApr1W07mQODfNMTXSgQqduOhfZgZssk4XFuxy4e3nfbC3CLTPoYOwSuQS-TFQ824DYy3yFiCQm4T9eQEPtuyC8BKr2TjPskSookpAhJgmLp7WN55ZYZ28bXBk_LGLCvcnlAEiFT1pjJL4tt_UfXMt-ToR_LZdzKynHiD5ecssA9zixZo_lxpZrGV6rWAgwX-Bc-lfRmLt1Fyc-_Q0VHuwPU9pooJPPoEKxInpsVMQDDJClhFqBfJi_Yorgz8Gk5y-v-MeJLdAQQM8gGH4otbLLZ3sRVWjrB0XsjwM-GKDiw_JbayskWdi5S-9Qx-EuLsTR9_NaFe0AFJVnxfVDaDo71tjXaM5frwDWU5AocMACPKWguyK3cgRNtJy0)

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