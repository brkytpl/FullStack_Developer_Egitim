create proc Listeleme
as
select * from Araclar

create proc Kaydetme
(
	@marka varchar(50),
	@model varchar(50),
	@renk varchar(50)
)
as
insert into Araclar (Marka,Model,Renk) values(@marka,@model,@renk)

create proc Guncelleme
(
	@id int,
	@marka varchar(50),
	@model varchar(50),
	@renk varchar(50)
)
as
update Araclar set Marka=@marka,Model=@model,Renk=@renk where id=@id

create proc Silme
(
	@id int
)
as
Delete from Araclar where id=@id


create proc Ara
(
	@arananmetin varchar(50)
)
as
select * from Araclar where Marka=@arananmetin