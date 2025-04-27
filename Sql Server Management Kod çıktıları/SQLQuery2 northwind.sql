select * from Urunler

select sum (HedefStokDuzeyi) as toplam_stok from Urunler

select avg (HedefStokDuzeyi) as ortalama_stok from Urunler

select max(BirimFiyati) as 'birim fiyati max' from Urunler
select min(BirimFiyati) as 'birim fiyati min' from Urunler

select count(BirimFiyati) as Urun_Sayýsý from Urunler

select TedarikciID, KategoriID, sum(HedefStokDuzeyi) from Urunler group by TedarikciID, KategoriID

select top 4* from Urunler

select * from Urunler order by BirimFiyati

