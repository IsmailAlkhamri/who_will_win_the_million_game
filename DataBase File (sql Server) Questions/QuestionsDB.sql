use GameQuestions;

Create Table Question(
   ques_no int primary key identity(1,1),
   ques_title nvarchar(300) Not null,
   ques_Difficulity varchar(10) Not null,
   Answer1 nvarchar(20) Not null,
   Answer2 nvarchar(20) Not null,
   Answer3 nvarchar(20) Not null,
   Answer4 nvarchar(20) Not null,
);

insert into Question
values (,,,,)
