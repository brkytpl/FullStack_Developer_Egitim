Create database Okul
go 
use Okul
go
create table Ogretmen(
Tc int primary key,
Ogretmen_Ad varchar(50) not null,
Brans varchar(50) not null,
Adres nvarchar,
D_Tarihi date,
Maas smallmoney
)
alter table Ogretmen alter column Adres nvarchar(100)
--veri ekleme
insert into  Ogretmen (Tc,Ogretmen_Ad,Brans,Adres,D_Tarihi,Maas) values(1111,'Ali K�sa','T�rk�e','Levent','2000/02/10',50000)
insert into  Ogretmen (Tc,Ogretmen_Ad,Brans,Adres,D_Tarihi,Maas) values(2222,'Veli K�sa','Matematik','Sar�yer','1995/02/15',30000)
insert into  Ogretmen (Tc,Ogretmen_Ad,Brans,Adres,D_Tarihi,Maas) values(3333,'Serap �elik','Tarih','Levent','2000/02/10',40000)
insert into  Ogretmen (Tc,Ogretmen_Ad,Brans,Adres,D_Tarihi,Maas) values(4444,'�a�atay �elik','T�rk�e','Sar�yer','1982-05-25',20000)
insert into  Ogretmen (Tc,Ogretmen_Ad,Brans,Adres,D_Tarihi,Maas) values(5555,'Zeynep Demir','Matematik','Taksim','1997.11.28',50000)

--veri Listeleme
select * from Ogretmen
-- veri silme
delete from Ogretmen where Maas<=30000 and Maas <50000
delete from Ogretmen

--veri g�ncelleme
update Ogretmen set Adres='Kad�k�y' where Ogretmen_Ad like '%K�sa'
update Ogretmen set Adres='Be�ikta�',Maas=40000 where Ogretmen_Ad like '%K�sa'
update Ogretmen set Maas-=2000
update Ogretmen set Adres+='il�esi'


