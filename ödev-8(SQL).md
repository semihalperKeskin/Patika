## test veritabanınızda employee isimli sütun bilgileri id(INTEGER), name VARCHAR(50), birthday DATE, email VARCHAR(100) olan bir tablo oluşturalım.
```
CREATE TABLE employee (
    id INT PRIMARY KEY,
    name VARCHAR(50),
    birthday DATE
    email VARCHAR(50)
);

```
## Oluşturduğumuz employee tablosuna 'Mockaroo' servisini kullanarak 50 adet veri ekleyelim.
```
insert into employee (id, first_name, last_name, birthday, email) values (1, 'Todd', 'Reddihough', '1975/07/31', 'treddihough0@vinaora.com');
insert into employee (id, first_name, last_name, birthday, email) values (2, 'Fan', 'Margram', '1944/05/14', 'fmargram1@google.de');
insert into employee (id, first_name, last_name, birthday, email) values (3, 'Teddy', 'Shewen', '1992/03/23', 'tshewen2@miitbeian.gov.cn');
insert into employee (id, first_name, last_name, birthday, email) values (4, 'Sandor', 'Becken', '1943/05/08', 'sbecken3@indiegogo.com');
insert into employee (id, first_name, last_name, birthday, email) values (5, 'Rosemaria', 'Simek', '1943/10/05', 'rsimek4@simplemachines.org');
insert into employee (id, first_name, last_name, birthday, email) values (6, 'Aldwin', 'Bonar', '1966/09/04', 'abonar5@lycos.com');
insert into employee (id, first_name, last_name, birthday, email) values (7, 'Anabella', 'Markova', '2015/11/15', 'amarkova6@discovery.com');
insert into employee (id, first_name, last_name, birthday, email) values (8, 'Tresa', 'Iacoviello', '1928/02/10', 'tiacoviello7@lycos.com');
insert into employee (id, first_name, last_name, birthday, email) values (9, 'Harmonie', 'Pieters', '2003/06/12', 'hpieters8@youtube.com');
insert into employee (id, first_name, last_name, birthday, email) values (10, 'Olivette', 'Simko', '1979/10/27', 'osimko9@dailymotion.com');
insert into employee (id, first_name, last_name, birthday, email) values (11, 'Goran', 'Hamsley', '1960/01/03', 'ghamsleya@mapy.cz');
insert into employee (id, first_name, last_name, birthday, email) values (12, 'Nev', 'Divina', '1977/03/23', 'ndivinab@aboutads.info');
insert into employee (id, first_name, last_name, birthday, email) values (13, 'Monica', 'Fyers', '1987/12/15', 'mfyersc@senate.gov');
insert into employee (id, first_name, last_name, birthday, email) values (14, 'Kerrin', 'Kepe', '1949/11/14', 'kkeped@irs.gov');
insert into employee (id, first_name, last_name, birthday, email) values (15, 'Marje', 'Hurley', '1974/08/02', 'mhurleye@vk.com');
insert into employee (id, first_name, last_name, birthday, email) values (16, 'Dorita', 'Gaddas', '1983/08/24', 'dgaddasf@addtoany.com');
insert into employee (id, first_name, last_name, birthday, email) values (17, 'Jennifer', 'Corran', '1988/04/17', 'jcorrang@addtoany.com');
insert into employee (id, first_name, last_name, birthday, email) values (18, 'Jodee', 'Kilfeather', '1982/03/23', 'jkilfeatherh@unicef.org');
insert into employee (id, first_name, last_name, birthday, email) values (19, 'Benoit', 'Jasik', '1979/07/18', 'bjasiki@e-recht24.de');
insert into employee (id, first_name, last_name, birthday, email) values (20, 'Nate', 'Brodbin', '1980/04/05', 'nbrodbinj@soup.io');
insert into employee (id, first_name, last_name, birthday, email) values (21, 'Chere', 'Cornthwaite', '1995/09/27', 'ccornthwaitek@addthis.com');
insert into employee (id, first_name, last_name, birthday, email) values (22, 'Ines', 'Edelston', '1932/10/29', 'iedelstonl@shinystat.com');
insert into employee (id, first_name, last_name, birthday, email) values (23, 'Shanna', 'Zuker', '1967/09/14', 'szukerm@ucoz.ru');
insert into employee (id, first_name, last_name, birthday, email) values (24, 'Bil', 'Gentil', '2010/10/01', 'bgentiln@kickstarter.com');
insert into employee (id, first_name, last_name, birthday, email) values (25, 'Tandie', 'McNair', '1946/02/08', 'tmcnairo@furl.net');
insert into employee (id, first_name, last_name, birthday, email) values (26, 'Urbanus', 'Jamison', '1953/11/09', 'ujamisonp@vinaora.com');
insert into employee (id, first_name, last_name, birthday, email) values (27, 'Vladimir', 'Farnin', '1994/09/07', 'vfarninq@shareasale.com');
insert into employee (id, first_name, last_name, birthday, email) values (28, 'Teodor', 'Ellins', '2003/03/07', 'tellinsr@meetup.com');
insert into employee (id, first_name, last_name, birthday, email) values (29, 'Sabine', 'Calam', '1989/05/26', 'scalams@wikispaces.com');
insert into employee (id, first_name, last_name, birthday, email) values (30, 'Susann', 'Caldow', '1935/06/08', 'scaldowt@taobao.com');
insert into employee (id, first_name, last_name, birthday, email) values (31, 'Kara', 'Pogue', '1943/11/14', 'kpogueu@netscape.com');
insert into employee (id, first_name, last_name, birthday, email) values (32, 'Austina', 'Moses', '1987/07/22', 'amosesv@elegantthemes.com');
insert into employee (id, first_name, last_name, birthday, email) values (33, 'Vonni', 'Kleinschmidt', '1954/09/10', 'vkleinschmidtw@digg.com');
insert into employee (id, first_name, last_name, birthday, email) values (34, 'King', 'Faragher', '2010/10/19', 'kfaragherx@chronoengine.com');
insert into employee (id, first_name, last_name, birthday, email) values (35, 'Wilmar', 'Verheijden', '1943/09/03', 'wverheijdeny@typepad.com');
insert into employee (id, first_name, last_name, birthday, email) values (36, 'Livvy', 'Durward', '1926/08/25', 'ldurwardz@indiatimes.com');
insert into employee (id, first_name, last_name, birthday, email) values (37, 'Janeta', 'Meriguet', '1926/01/31', 'jmeriguet10@businessweek.com');
insert into employee (id, first_name, last_name, birthday, email) values (38, 'Kimbra', 'Wison', '1953/11/06', 'kwison11@reddit.com');
insert into employee (id, first_name, last_name, birthday, email) values (39, 'Nicolea', 'Lidgerton', '1925/06/08', 'nlidgerton12@salon.com');
insert into employee (id, first_name, last_name, birthday, email) values (40, 'Olivier', 'Arent', '1970/12/14', 'oarent13@omniture.com');
insert into employee (id, first_name, last_name, birthday, email) values (41, 'Corty', 'Dowse', '2015/12/05', 'cdowse14@simplemachines.org');
insert into employee (id, first_name, last_name, birthday, email) values (42, 'Inger', 'Abbay', '1931/10/22', 'iabbay15@e-recht24.de');
insert into employee (id, first_name, last_name, birthday, email) values (43, 'Flo', 'Simms', '2008/07/06', 'fsimms16@reddit.com');
insert into employee (id, first_name, last_name, birthday, email) values (44, 'Lanny', 'Dilworth', '1965/07/06', 'ldilworth17@google.co.uk');
insert into employee (id, first_name, last_name, birthday, email) values (45, 'Jacinthe', 'Goodfield', '1952/11/09', 'jgoodfield18@epa.gov');
insert into employee (id, first_name, last_name, birthday, email) values (46, 'Jackquelin', 'Ivashchenko', '1958/08/17', 'jivashchenko19@hibu.com');
insert into employee (id, first_name, last_name, birthday, email) values (47, 'Corella', 'Novkovic', '1994/06/11', 'cnovkovic1a@newsvine.com');
insert into employee (id, first_name, last_name, birthday, email) values (48, 'Earl', 'Roffe', '1995/06/19', 'eroffe1b@webeden.co.uk');
insert into employee (id, first_name, last_name, birthday, email) values (49, 'Creighton', 'Gallatly', '1990/07/01', 'cgallatly1c@1und1.de');
insert into employee (id, first_name, last_name, birthday, email) values (50, 'Smith', 'Benoey', '2004/06/09', 'sbenoey1d@tmall.com');
```
## Sütunların her birine göre diğer sütunları güncelleyecek 5 adet UPDATE işlemi yapalım.
```
UPDATE employee 
SET first_name = 'Ali'
    last_name = 'Karakoç'
    email = 'Ali@karakoc.com'
    birthday = '2020-01-01'
WHERE id= 5
RETURNING *;

UPDATE employee
SET  first_name = 'Ahmet'
    last_name = 'Karış'
    email = 'Ahmet@karis.com'
    birthday = '2001-11-05'
WHERE id= 6
RETURNING *;

UPDATE employee
SET first_name = 'Ayşe'
    last_name = 'Yıldız'
    email = 'Ayse@yildiz.com'
    birthday = '1985-10-02'
WHERE id= 15
RETURNING *;

UPDATE employee
SET first_name = 'Hakan'
    last_name = 'Eroğlu'
    email = 'hakan@eroglu.com'
    birthday = '1995-07-09'
WHERE id= 29
RETURNING *;

UPDATE employee
SET first_name = 'Derya'
    last_name = 'Yobaz'
    email = 'derya@yobaz.com'
    birthday = '1991-04-12'
WHERE id= 41
RETURNING *;
```
## Sütunların her birine göre ilgili satırı silecek 5 adet DELETE işlemi yapalım.
```
DELETE FROM employee WHERE id = 5;
DELETE FROM employee WHERE id = 6;
DELETE FROM employee WHERE id = 15;
DELETE FROM employee WHERE id = 29;
DELETE FROM employee WHERE id = 41;
```