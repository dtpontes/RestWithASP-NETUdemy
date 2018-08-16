CREATE TABLE  `users` (
`Id` INT(10)  NOT NULL AUTO_INCREMENT ,
`Login` varchar(50) UNIQUE NOT NULL,
`AccessKey`  varchar(50)  NOT NULL,
PRIMARY KEY (`Id`)
)
;