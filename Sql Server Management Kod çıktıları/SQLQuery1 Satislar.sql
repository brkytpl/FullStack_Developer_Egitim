create proc sListele
as
select * from Satislar

exec sListele

create proc sKaydet
(
	@musteri varchar(50),
	@urun varchar(50),
	@fiyat smallmoney,
	@adet int,
	@odeme varchar(50)
)
as
insert into Satislar (musteri,urun,fiyat,adet,odeme) values (@musteri,@urun,@fiyat,@adet,@odeme)

create proc sGuncelle
(
	@id int,
	@musteri varchar(50),
	@urun varchar(50),
	@fiyat smallmoney,
	@adet int,
	@odeme varchar(50)
)
as
update Satislar set musteri=@musteri,urun=@urun,fiyat=@fiyat,adet=@adet,odeme=@odeme where id=@id

create proc sSil
@id int
as
delete from Satislar where id=@id