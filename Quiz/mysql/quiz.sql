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
    Name varchar(50)
);

create table answers(
	Id int primary key auto_increment,
    Answer varchar(100)
);

create table questions (
	Id int primary key auto_increment,
    Question varchar(200),
    Category_id int not null,
    Answer_id int not null,
    foreign key (Category_id) references categories(Id),
    foreign key (Answer_id) references answers(Id)
);

create table highscores(
	Id int primary key auto_increment,
    CreatedAt date,
    User_id int,
    Score int,
    foreign key (User_id) references user(Id)
);