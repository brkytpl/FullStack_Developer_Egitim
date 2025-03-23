
--Karþýlaþtýrma operatörleri
-- = Eþitse, <,>,<> Eþitdeðilse,!= Eþitdeðilse,<=,>=,Between (Arasýnda), Not Between (Arasýnda Deðil)
--in (Verilen deðerlerden birine eþitse), not in (verilen deðerlerden birine eþit deðilse),
--Like (metinsel ifade içeren), not like (metinsel ifade içermeyen)
--Mantýksal Operatörler AND (ve), OR (veya)

--tc si 1111 olan kiþinin adý
select Ogretmen_Ad from Ogretmen where Tc=1111
--tc si 1111 olan kiþinin tüm bilgileri
select * from Ogretmen where Tc=1111

select * from Ogretmen where Maas!=50000

select Ogretmen_Ad,Maas from Ogretmen where Maas>30000

select * from Ogretmen 

--branþý türkçe olan öðretmenlerin adlarý ve branþlarý
select Ogretmen_Ad,Brans from Ogretmen where Brans Like '%T%'

--branþý türkçe olmayan öðretmenlerin tüm verileri
select * from Ogretmen where Brans not Like 'Tarih'
select * from Ogretmen where Brans like 'T_r__'

select * from Ogretmen where Adres in('Beþiktaþ','Taksim','Kadýköy','Levent')
select * from Ogretmen where Adres not in('Beþiktaþ','Taksim','Kadýköy','Levent')

select * from Ogretmen where Maas in(1000,25000,50000)
--maasý 25 bin ile 50 bin arasýnda olanlar dahil
select* from Ogretmen where Maas Between 25000 and 50000 
select* from Ogretmen where Maas not Between 25000 and 50000 

--maasý 25 bin ile 50 bin arasýnda olanlar dahil
select* from Ogretmen where Maas>=25000 and Maas <=50000 
select* from Ogretmen where Maas>=25000 or Maas <=50000 

select* from Ogretmen where Maas>=25000 and Adres ='Levent' 

select * from Ogretmen where Adres like '%Levent%' and Maas = 50000
select * from Ogretmen where Adres ='Levent' and Maas = 50000

--Adresi levent veya sarýyer olanlarýn maasý 30 binden büyük olanlarý listele
select * from Ogretmen where (Adres ='Levent' or Adres='Sarýyer') and Maas>30000

--Branþý Türkçe veya adresi taksim olanlarýn maaþý 30 binden büyük olanlarý
select * from Ogretmen where (Brans= 'Türkçe' or Adres= 'Taksim') and Maas>30000
