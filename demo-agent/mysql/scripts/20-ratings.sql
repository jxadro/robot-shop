USE sample;

CREATE TABLE sampletable (
    id INT NOT NULL,
    name INT NOT NULL
) ENGINE=InnoDB;


GRANT ALL ON sample.* TO 'sample'@'%'
IDENTIFIED BY 'iloveit';

