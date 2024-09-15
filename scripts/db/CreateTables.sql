CREATE TABLE cafe (
    id BINARY(16) PRIMARY KEY DEFAULT (UUID_TO_BIN(UUID())),
    name varchar(255) not null,
    description varchar(255) not null,
    logo varchar(255),
    location varchar(255) not null
);

CREATE TABLE employee (
    id varchar(9) PRIMARY KEY,
    name varchar(255) not null,
    email_address varchar(255) not null,
    phone_number varchar(8),
    gender varchar(6) not null
);
