# Cqrs.Core.Demo
CQRS API Example. Currently using MariaDB installed as a docker container with port number: 55001

## Database Schema

```
CREATE DATABASE `BookStore` /*!40100 DEFAULT CHARACTER SET utf8mb4 */;
```

```
-- BookStore.Books definition

CREATE TABLE `Books` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Title` varchar(200) NOT NULL,
  `Author` varchar(200) NOT NULL,
  `Description` varchar(500) DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4;
```

```
INSERT INTO BookStore.Books
(Title, Author, Description)
VALUES('', '', NULL);
```
