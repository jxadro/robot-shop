CREATE DATABASE sample
DEFAULT CHARACTER SET 'utf8';

USE sample;

CREATE TABLE sampletable (
    id varchar(80) NOT NULL,
    avalue INT NOT NULL,
    PRIMARY KEY (sku)
) ENGINE=InnoDB;


GRANT ALL ON sample.* TO 'sample'@'%'
IDENTIFIED BY 'iloveit';

