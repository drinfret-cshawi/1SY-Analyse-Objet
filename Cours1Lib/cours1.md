````plantuml
skinparam classAttributeIconSize 0
class Person {
    +Id : int {get; set;}
    +Name : string {get; set;}
    +Person(Id : int, Name : string)
}

class Student {
    +noDA : int {get; set;}
    +Student(Id : int, Name : string, noDA : int)
}

Person <|-- Student
````