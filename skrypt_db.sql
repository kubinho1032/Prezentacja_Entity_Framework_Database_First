create table Samochody (
id_samochod integer,
marka varchar(30),
rok_produkcji integer
);

alter table samochody add constraint pk_samochody primary key (id_samochod);
alter table samochody modify (marka not null);
alter table samochody modify (rok_produkcji not null);