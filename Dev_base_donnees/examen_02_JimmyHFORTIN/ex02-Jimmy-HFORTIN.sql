Create database EX02;
USE EX02;

CREATE TABLE host (
host_id int primary key auto_increment,
host_name varchar(20),
host_ip varchar(50),
status varchar(15),
last_date_connection datetime
);
  
-- à la base des ses inserts , compléter les attributs de la table host, puis tester votre table avec l'exécution des inserts  
INSERT INTO host (host_id, host_name, host_ip, status, last_date_connection) VALUES (1,'Ubuntu_16.04', '121.83.158.243', 'started', '2019-12-09 01:18');
INSERT INTO host (host_name, host_ip, status, last_date_connection) VALUES ('RedHat', '79.30.50.207', 'stopped', '2018-11-19 13:50');
INSERT INTO host (host_name, host_ip, status, last_date_connection) VALUES ('Wind10', '125.69.100.61', 'stopped', '2019-06-25 00:48');
INSERT INTO host (host_name, host_ip, status, last_date_connection) VALUES ('Azure', '54.114.111.90', 'stopped', '2018-12-03 06:14');
INSERT INTO host (host_name, host_ip, status, last_date_connection) VALUES ('Ubuntu_18.04', '81.99.131.160', 'stopped', '2019-10-28 04:45');

select * from host;