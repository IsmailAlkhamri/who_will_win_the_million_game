select * from Question;

EXEC sp_rename 'Question.CorrectAns', 'Answer4','COLUMN';

alter table Question add Corr_No int not null;

alter table Question alter column ques_no int not null;

alter table Question add ques_no int not null

insert into Question 
values ('�� �� ��� ���� ������ �������ɿ','difficult','1848','1812','1789','1776',2,6),
('�� �� ������� ���� ���� ������','difficult','�����','�����','�������','������',4,7),
('�� �� ������ ������� ������� ������ɿ','difficult','�������','������','����','������ ����������',4,8),
('�� �� ������ ��������� ���� ����� ���� "����� ������"�','difficult','�������','�����','������','����������',1,9),
('�� �� ������� ������ ��������ǿ','difficult','������','���� �������','�������','�����',1,10)
