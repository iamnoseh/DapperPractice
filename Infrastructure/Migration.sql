create  database cousedb;
create  table  Courses
(
    CouseId serial primary key,
    Name varchar(50) not null ,
    Description text ,
    CreateDate timestamp default  current_timestamp,
    EndDate timestamp,
    TeacherID int references Teachers(id),
    StudentID int references  Students(id)
);


create  table  Students
(
    Id serial primary key ,
    Full_Name varchar(100) not NULL ,
    Age int ,
    Phone varchar(15),
    Address text,
    Email varchar(50) unique
);

create  table  Teachers
(
    id serial primary key ,
    Full_name varchar(100),
    Age int ,
    Phone varchar(15),
    Address text,
    Email varchar(50) unique
);


INSERT INTO Students (Full_Name, Age, Phone, Address, Email) VALUES
                                                                 ('Али Алиев', 20, '+992123456789', 'Душанбе', 'ali@gmail.com'),
                                                                 ('Моҳира Салимова', 22, '+992987654321', 'Хуҷанд', 'mohira@gmail.com'),
                                                                 ('Фаррух Каримов', 19, '+992876543210', 'Кулоб', 'farrukh@gmail.com'),
                                                                 ('Гулру Насриддинова', 21, '+992456789123', 'Бохтар', 'gulru@gmail.com'),
                                                                 ('Саида Саидова', 23, '+992123987654', 'Душанбе', 'saida@gmail.com'),
                                                                 ('Рустам Нуров', 18, '+992654321987', 'Истаравшан', 'rustam@gmail.com'),
                                                                 ('Муҳайё Аҳмадова', 20, '+992345678912', 'Ваҳдат', 'mukhayyo@gmail.com'),
                                                                 ('Шоҳрух Шоҳиев', 24, '+992876543219', 'Ҳисор', 'shohruh@gmail.com'),
                                                                 ('Мадина Ҷамшедова', 19, '+992789123456', 'Душанбе', 'madina@gmail.com'),
                                                                 ('Зафар Холов', 22, '+992912345678', 'Қӯрғонтеппа', 'zafar@gmail.com');

select  * from  Teachers;

INSERT INTO Teachers (Full_name, Age, Phone, Address, Email) VALUES
                                                                 ('Насимҷон Шарипов', 35, '+992123654789', 'Душанбе', 'nasimjon@gmail.com'),
                                                                 ('Муҳсин Абдуллоев', 40, '+992987321654', 'Хуҷанд', 'muhsin@gmail.com'),
                                                                 ('Фирӯза Раҳимова', 28, '+992765432198', 'Кулоб', 'firuza@gmail.com'),
                                                                 ('Суҳроб Ҷӯраев', 42, '+992890123765', 'Бохтар', 'suhrob@gmail.com'),
                                                                 ('Шамсия Исмоилова', 30, '+992654123789', 'Душанбе', 'shamsiya@gmail.com'),
                                                                 ('Хуршед Холиқов', 33, '+992341987654', 'Истаравшан', 'khurshed@gmail.com'),
                                                                 ('Мавзуна Аҳмадова', 29, '+992765498132', 'Ваҳдат', 'mavzuna@gmail.com'),
                                                                 ('Бахтиёр Қурбонов', 38, '+992765432198', 'Ҳисор', 'bakhtiyor@gmail.com'),
                                                                 ('Саъдия Холмуродова', 26, '+992897654321', 'Душанбе', 'saadiya@gmail.com'),
                                                                 ('Рустам Зарифов', 34, '+992678901234', 'Қӯрғонтеппа', 'rustamz@gmail.com');



INSERT INTO Courses (Name, Description, EndDate, TeacherID, StudentID) VALUES
                                                                           ('Python Basics', 'Курси асосии барномасозӣ бо Python.', '2024-12-31', 1, 1),
                                                                           ('Web Development', 'Таҳияи сайтҳо бо HTML, CSS ва JavaScript.', '2024-12-31', 2, 2),
                                                                           ('Database Management', 'Курси кор бо базаҳои додаҳо.', '2024-11-30', 3, 3),
                                                                           ('C# Programming', 'Курси асосӣ оид ба барномасозӣ бо C#.', '2024-10-31', 4, 4),
                                                                           ('Machine Learning', 'Асосҳои таълими мошинӣ.', '2024-09-30', 5, 5),
                                                                           ('Data Science', 'Таҳлили додаҳо ва илм.', '2024-08-31', 6, 6),
                                                                           ('Mobile App Development', 'Таҳияи барномаҳои мобилӣ.', '2024-07-31', 7, 7),
                                                                           ('Game Development', 'Сохтани бозиҳои компютерӣ.', '2024-06-30', 8, 8),
                                                                           ('Cyber Security', 'Муҳофизати системаҳои компютерӣ.', '2024-05-31', 9, 9),
                                                                           ('Artificial Intelligence', 'Курси интеллекти сунъӣ.', '2024-04-30', 10, 10);
