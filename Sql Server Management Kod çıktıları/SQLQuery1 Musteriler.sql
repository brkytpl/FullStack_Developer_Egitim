create proc mListele
as
begin
select * from Musteriler
end

exec mListele

create proc mKaydet
(
@adi varchar(50),
@adres varchar(100),
@Il varchar(50),
@Tel varchar(11)
)
as
insert into Musteriler (mAd,mAdres,il,tel) values(@adi,@adres,@Il,@Tel)

drop proc mKaydet

exec mKaydet @adi='Ali Kýsa',@adres='levent',@Il='Ýstanbul',@Tel='2122323'

Alter proc mGuncelle
(
@id int,
@adi varchar(50),
@adres varchar(100),
@Il varchar(50),
@Tel varchar(11)
)
as
begin
update Musteriler set mAd=@adi,mAdres=@adres,il=@Il,tel=@Tel where id=@id
end

create proc mSil
@id int
as
delete from Musteriler where id=@id

