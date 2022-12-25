create table Users

(id int primary key identity(1,1),
nickname nvarchar(20) unique not null,
password nvarchar(40) not null,
avatar varbinary(max) null,
experience int default 0,
rating int default 0,
rating2vs2 int default 0,
NumberOfAnswers int default 0,
NumberOfCorrectAnswers int default 0,
NumberOfGames int default 0,
NumberOfGamesWon int default 0,
BestCategory nvarchar(25) null)

create table Difficulty
(difficulty_id int primary key,
description nvarchar(15) not null)

insert into Difficulty
values
(1, 'Лёгкая'),
(2, 'Средняя'),
(3, 'Сложная');

create table Category
(category_id int primary key identity(1,1),
description nvarchar(100) not null)

insert into Category
values
('История'),
('География'),
('Математика'),
('Физика и астрономия'),
('Программирование'),
('Исскуство (Литература и Музыка)'),
('Спорт'),
('Общие знания'),
('Развлечения(Игры)'),
('Фильмы');


create table Questions
(question_id int primary key identity(1,1),
difficulty_id int not null,
category_id int not null,
question nvarchar(250) unique not null,
correct_answer nvarchar(100) not null,
answer_1 nvarchar(100) null,
answer_2 nvarchar(100) null,
answer_3 nvarchar(100) null,
question_type int default 1 null

foreign key (difficulty_id) references Difficulty (difficulty_id),
foreign key (category_id) references Category (category_id))