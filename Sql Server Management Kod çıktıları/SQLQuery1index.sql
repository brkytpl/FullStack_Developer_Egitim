create table kitaplar(
id int not null primary key,
kitapad varchar(50) not null unique,
sayfasayisi int check (sayfasayisi>0 and sayfasayisi<100),
yazarad varchar(50) default 'Yazar Bilgisi Yok',
kutuphaneadi varchar(100)
)

Alter table kitaplar add constraint df_kutuphaneadi default 'levent' for kutuphaneadi

create index ix_kitapad on kitaplar(kitapad)
drop index ix_kitapad on kitaplar
drop index kitaplar.ix_kitapad