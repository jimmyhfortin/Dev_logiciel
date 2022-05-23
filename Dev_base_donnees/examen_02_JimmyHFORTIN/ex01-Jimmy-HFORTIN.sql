create database GestionQuiz;
use GestionQuiz;

create table Category(
CategoryId int primary key,
Description_text varchar(30)
);

create table Question(
QuestionId int primary key,
Text_text varchar(250),
CategoryId int, 
foreign key(CategoryId) references Category(CategoryId)
);

create table Answer(
AnswerId int primary key, 
OptionId int,
QuizId int,
foreign key(OptionId) references Item_Option(OptionId),
foreign key(QuizId) references Quiz(QuizId)
);

create table Item_Option(
OptionId int primary key,
Text_text varchar(250),
IsRight int default 0,
QuestionId int,
foreign key(QuestionId) references Question(QuestionId)
);
create table Quiz(
QuizId int primary key,
UserName varchar(50),
Email varchar(60)
);

create table Question_Quiz(
QuestionId int, 
QuizId int,
foreign key(QuestionId) references Question(QuestionId),
foreign key(QuizId) references Quiz(QuizId),
primary key(QuestionId,QuizId)
);

select * from Answer;

insert into Category values(1, 'easy');
insert into Category values(2, 'medium'),(3, 'hard');

insert into Question values(1, 'Java is ……..', 1);
insert into Question values(2, 'A Java class', 2),(3, 'What is Java inheritance?', 2),(4, 'Polymorphism is the ability of an object to take on many forms.', 3),(5, 'Local variables are declared in methods, constructors, or blocks.', 1),(6, '…….. stores a fixed-size sequential collection of elements of the same type?', 2);

insert into Item_Option values(1,'a coffee', 0, 1),(2,'a high-level programming language', 1, 1),(3,'a source code editor', 0, 1),(4,'is a template that describes the behavior that the object of its type support', 1, 2),(5,'can have any number of methods', 1, 2),(6,'the process where one class acquires the properties (methods and fields) of another.', 1, 3),(7,'a problem that arises during the execution of a program.', 0, 3),(8,'it mainly used to traverse collection of elements including arrays.', 0, 3);
insert into Item_Option values(9,'true', 1, 4),(10,'false', 0, 4),(11,'true', 1, 5),(12,'false', 0, 5),(13,'variables', 0, 6),(14,'arrays', 1, 6),(15,'methods', 0, 6);

insert into Quiz values(1, 'williamo', 'william@gmail.com'),(2, 'allo21', 'alex.gh@gmail.com');

insert into Question_Quiz values(1, 1),(2, 1),(4, 1),(6, 1),(1, 2),(3, 2),(4, 2),(5, 2);

insert into Answer values(1, 1, 1),(2, 5, 1),(3, 6, 1),(4, 9, 1),(5, 12, 1),(6, 14, 1),(7, 1, 2),(8, 4, 2),(9, 7, 2),(10, 9, 2),(11, 11, 2),(12, 13, 2);
