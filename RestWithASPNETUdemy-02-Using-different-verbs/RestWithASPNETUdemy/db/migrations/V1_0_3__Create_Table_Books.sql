CREATE TABLE IF NOT EXISTS `books` (
`Id` INT(10)  not NULL ,
`Author` longtext,
`LaunchDate` datetime(6) not NULL,
`Price` decimal(65,2) NOT NULL,
`Title` longtext,
PRIMARY KEY (`Id`)
)
ENGINE=InnoDB;