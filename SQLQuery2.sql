use FEST

create table Student(Usn varchar(25) ,Name varchar(25) not null,Email_Id varchar(25) not null,sex varchar(25) not null,Address varchar(100) not null,Sem int not null,
Mobile_no int not null,Username varchar(25) not null unique,Password varchar(25) not null unique
,College_Id varchar(25) not null
primary key(Usn)
foreign key(College_Id) references College(College_Id)
);




drop table Student
select * from STUDENT

drop table College

select * from Student


create table College(College_Id Varchar(25),College_Name varchar(25) not null,Address varchar(100) not null
primary key(College_Id)
);



select * from COLLEGE

create table Volounteer(VUsn varchar(25),VEvent_Id int not null
primary key(VUsn)
Foreign key(VEvent_Id) references Event(Event_Id) on update cascade on delete cascade,
Foreign key(VUsn) references Student(Usn) on update cascade on delete cascade
);



drop table Volounteers


create table Participant(PUsn varchar(25),PEvent_Id int
primary key(PUsn,PEvent_Id)
Foreign key(PEvent_Id) references Event(Event_Id),
Foreign key(PUsn) references Student(Usn)
);


drop table Participates

create table Event(Event_Id int,Event_Name varchar(25) not null,Department Varchar(25) not null,Date Date not null,Place Varchar(25) not null,OrgUsn varchar(25) not null
primary key(Event_Id),
Foreign Key(OrgUsn) references Student(Usn)
);




drop Table Event


select *from Event




drop table Volounteers

drop table Organizes


create table Winners(Usn varchar(25),Event_Id int,Position int not null
primary key(Usn,Event_Id)
Foreign key(Event_Id) references Event(Event_Id),
Foreign key(Usn) references Student(Usn)
);

select * from Event

drop table Winners


insert into College values
('4NM','NMAMIT','Nitte,Karkala');

select * from College

insert into Student
values('4nm15cs001','Roline','rolineshirva@gmail.com','Female','Shirva,udupi','5','9123456789','Roline','Roline','4NM');

insert into Student
values('4nm15cs002','Chaithanya','chaithanya0607@gmail.com','Female','udupi','5','9243546782','Chaithanya','Chaithanya','4NM');

insert into Student
values('4nm15cs003','Raju','raju@gmail.com','Male','udupi','5','9243546728','Raju','Raju','4NM');

insert into Student
values('4nm15cs004','Raj','raj@gmail.com','Male','udupi','5','9453546728','Raj','Raj','4NM');

insert into Student
values('4nm15cs005','Ramu','ramu@gmail.com','Male','udupi','5','9289546728','Ramu','Ramu','4NM');

insert into Student
values('4nm15cs006','Ram','ram@gmail.com','Male','udupi','5','9453549028','Ram','Ram','4NM');

insert into Student
values('4nm15cs007','Ravi','ravi@gmail.com','Male','udupi','5','9298546728','Ravi','Ravi','4NM');

insert into Student
values('4nm15cs008','Raja','raja@gmail.com','Male','udupi','5','9453586728','Raja','Raja','4NM');

insert into Student
values('4nm15cs009','Savitha','Savitha@gmail.com','Female','udupi','5','9453589728','Savitha','Savitha','4NM');


insert into Student
values('4nm15cs010','Babitha','Babitha@gmail.com','Female','udupi','5','9400589728','Babitha','Babitha','4NM');


insert into Student
values('4nm15cs011','Pavitha','Pavitha@gmail.com','Female','udupi','5','9451189728','Pavitha','Pavitha','4NM');

insert into Student
values('4nm15cs012','Githa','Githa@gmail.com','Female','udupi','5','9451779728','Githa','Githa','4NM');
insert into Student
values('4nm15cs013','Safa','Safa@gmail.com','Female','udupi','5','9478189728','Safa','Safa','4NM');

insert into Student
values('4nm15cs014','Raksha','Raksha@gmail.com','Female','udupi','5','9451199728','Raksha','Raksha','4NM');

insert into Student
values('4nm15cs015','Rangitha','Rangitha@gmail.com','Female','udupi','5','9451899728','Rangitha','Rangitha','4NM');



insert into Student
values('4nm15cs016','Prathima','Prathima@gmail.com','Female','udupi','5','9488899728','Prathima','Prathima','4NM');

insert into Student
values('4nm15cs017','Rhea','Rhea@gmail.com','Female','udupi','5','9881899728','Rhea','Rhea','4NM');

insert into Student
values('4nm15cs018','Prajna','Prajna@gmail.com','Female','udupi','5','9881099728','Prajna','Prajna','4NM');

insert into Student
values('4nm15cs019','Neha','Neha@gmail.com','Female','udupi','5','9823899728','Neha','Neha','4NM');
select * from Student

insert into Student
values('4nm15cs020','Nisha','Nisha@gmail.com','Female','udupi','5','9823889728','Nisha','Nisha','4NM');








alter table Student alter column Mobile_no varchar(20)
select * from Student


insert into Event values(
'01','Terabyte','cse','2018-01-23','lc01','4nm15cs001');
insert into Event values(
'02','Panorama','cse','2018-01-23','lc02','4nm15cs002');
insert into Event values(
'03','Papyrus','cse','2018-01-23','lc03','4nm15cs003');
insert into Event values(
'04','Huntertainment','cse','2018-01-23','lc04','4nm15cs004');
insert into Event values(
'05','Adrenaline_Rush','cse','2018-01-23','lc05','4nm15cs005');

insert into Event values(
'06','Clash_Of_Clans_Reloaded','cse','2018-01-23','lc06','4nm15cs006');
insert into Event values(
'07','Pokemon_Go','cse','2018-01-23','lc07','4nm15cs007');

insert into Event values(
'08','Game_Of_Clues_Returns','cse','2018-01-23','lc08','4nm15cs008');

insert into Event values(
'09','Talaash','cse','2018-01-23','lc09','4nm15cs009');
insert into Event values(
'10','Despicable_Me','cse','2018-01-23','lc10','4nm15cs010');

insert into Event values(
'11','Tech_Roadies','cse','2018-01-24','lc11','4nm15cs011');

insert into Event values(
'12','Techtainment','cse','2018-01-24','lc12','4nm15cs012');

insert into Event values(
'13','Twitease','cse','2018-01-24','lc13','4nm15cs013');

insert into Event values(
'14','Thinking_Cap','cse','2018-01-24','lc14','4nm15cs014');
insert into Event values(
'15','Blind_Drive','cse','2018-01-24','lc15','4nm15cs015');
insert into Event values(
'16','Speed_Clubbing','cse','2018-01-24','lc16','4nm15cs016');

insert into Event values(
'17','Keep_It_Simple_Silly','cse','2018-01-24','lc17','4nm15cs017');
insert into Event values(
'18','Techjuggling','cse','2018-01-24','lc18','4nm15cs018');

insert into Event values(
'19','Un_Google','cse','2018-01-24','lc19','4nm15cs019');

insert into Event values(
'20','Tantragni','cse','2018-01-24','lc20','4nm15cs020');













select * from Event

select * from College
Select * from Student