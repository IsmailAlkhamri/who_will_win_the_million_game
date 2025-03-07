select * from Question;

EXEC sp_rename 'Question.CorrectAns', 'Answer4','COLUMN';

alter table Question add Corr_No int not null;

alter table Question alter column ques_no int not null;

alter table Question add ques_no int not null

insert into Question 
values ('Ён √н Џ«г жёЏ  «бЋж—… «бЁ—д”н…њ','difficult','1848','1812','1789','1776',2,6),
('г« еж «бЌнж«д «б–н нд«г ж«ёЁ«рњ','difficult','«бЁнб','«бдг—','«б“—«Ё…','«бЌ’«д',4,7),
('г« ен «бЏгб… «б—”гн… ббггбя… «бг Ќѕ…њ','difficult','«бѕжб«—','«бнж—ж','«бнд','«бћдне «б≈” —бндн',4,8),
('г« еж «бЏд’— «бянгн«∆н «б–н нхЎбё Џбне "«б–е» «б√”жѕ"њ','difficult','«б» —жб','«бЁЌг','«б“∆»ё','«бнж—«днжг',1,9),
('г« еж «бЌнж«д «бжЎдн б√” —«бн«њ','difficult','«бядџ—','«бѕ» «бяж«б«','«бдЏ«г…','«б√”ѕ',1,10)
