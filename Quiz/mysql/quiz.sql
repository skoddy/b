drop database if exists quiz;
create database quiz;
use quiz;

create table user (
	Id int primary key auto_increment,
    Display_Name varchar(50),
    Password varchar(50)
);

create table categories (
	Id int primary key auto_increment,
    Text varchar(50)
);

create table questions (
	Id int primary key auto_increment,
    Text varchar(200),
	FileName varchar(100),
    Category_id int not null,
    foreign key (Category_id) references categories(Id)
);

create table answers(
	Id int primary key auto_increment,
    Text varchar(100),
    State bool,
    Question_id int,
	FileName varchar(100),
    foreign key (Question_id) references questions(Id)
);

create table highscores(
	Id int primary key auto_increment,
    CreatedAt date,
    User_id int,
    Score int,
    foreign key (User_id) references user(Id)
);

insert into categories(Text) values('Länder');
insert into categories(Text) values('Flaggen');
insert into categories(Text) values('Hauptstädte');
-- 
-- insert into answers value(NULL, 'Deutschland', 1);
-- insert into answers value(NULL, 'England', 1);
-- insert into answers value(NULL, 'Frankreich', 1);
-- insert into answers value(NULL, 'Polen', 1);
-- insert into answers value(NULL, 'Italien', 1);
-- 
-- insert into answers value(NULL, 'Deutschland.gif', 2);
-- insert into answers value(NULL, 'England.gif', 2);
-- insert into answers value(NULL, 'Frankreich.gif', 2);
-- insert into answers value(NULL, 'Polen.gif', 2);
-- insert into answers value(NULL, 'Italien.gif', 2);
-- 
-- insert into answers value(NULL, 'Berlin', 3);
-- insert into answers value(NULL, 'London', 3);
-- insert into answers value(NULL, 'Paris', 3);
-- insert into answers value(NULL, 'Warschau', 3);
-- insert into answers value(NULL, 'Rom', 3);
-- 
-- insert into questions value(NULL, 'Zu welchem Land gehört Deutschland.gif', 'Germany.png', 1, 1);
-- insert into questions value(NULL, 'Zu welchem Land gehört England.gif', 'United-Kingdom.png', 1, 2);
-- insert into questions value(NULL, 'Zu welchem Land gehört Frankreich.gif', 'France.png', 1, 3);
-- 
-- insert into questions value(NULL, 'Flagge von Deutschland', '', 2, 6);
-- insert into questions value(NULL, 'Flagge von England', '', 2, 7);
-- insert into questions value(NULL, 'Flagge von Frankreich', '', 2, 8);
-- 
-- insert into questions value(NULL, 'Hauptstadt von Deutschland', '', 3, 11);
-- insert into questions value(NULL, 'Hauptstadt von England', '', 3, 12);
-- insert into questions value(NULL, 'Hauptstadt von Frankreich', '', 3, 13);


