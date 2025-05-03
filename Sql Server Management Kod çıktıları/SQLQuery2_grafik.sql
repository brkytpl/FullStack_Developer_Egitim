select UrunAdi,KategoriAdi,SirketAdi as TedarikciFirma from Tedarikciler as t inner join Urunler u on t.TedarikciID=u.TedarikciID inner join Kategoriler k on u.KategoriID=k.KategoriID


select KategoriAdi, sum(HedefStokDuzeyi) from Urunler u inner join Kategoriler k on u.KategoriID=k.KategoriID group by KategoriAdi


select top 5 UrunAdi,BirimFiyati from Urunler

select * from Personeller
select * from Satislar

select * from Personeller p inner join Satislar s on p.PersonelID=s.PersonelID where Adi like 'Nancy' and SevkUlkesi='Brazil'