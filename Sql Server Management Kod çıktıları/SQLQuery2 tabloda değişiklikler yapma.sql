
--Kar��la�t�rma operat�rleri
-- = E�itse, <,>,<> E�itde�ilse,!= E�itde�ilse,<=,>=,Between (Aras�nda), Not Between (Aras�nda De�il)
--in (Verilen de�erlerden birine e�itse), not in (verilen de�erlerden birine e�it de�ilse),
--Like (metinsel ifade i�eren), not like (metinsel ifade i�ermeyen)
--Mant�ksal Operat�rler AND (ve), OR (veya)

--tc si 1111 olan ki�inin ad�
select Ogretmen_Ad from Ogretmen where Tc=1111
--tc si 1111 olan ki�inin t�m bilgileri
select * from Ogretmen where Tc=1111

select * from Ogretmen where Maas!=50000

select Ogretmen_Ad,Maas from Ogretmen where Maas>30000

select * from Ogretmen 

--bran�� t�rk�e olan ��retmenlerin adlar� ve bran�lar�
select Ogretmen_Ad,Brans from Ogretmen where Brans Like '%T%'

--bran�� t�rk�e olmayan ��retmenlerin t�m verileri
select * from Ogretmen where Brans not Like 'Tarih'
select * from Ogretmen where Brans like 'T_r__'

select * from Ogretmen where Adres in('Be�ikta�','Taksim','Kad�k�y','Levent')
select * from Ogretmen where Adres not in('Be�ikta�','Taksim','Kad�k�y','Levent')

select * from Ogretmen where Maas in(1000,25000,50000)
--maas� 25 bin ile 50 bin aras�nda olanlar dahil
select* from Ogretmen where Maas Between 25000 and 50000 
select* from Ogretmen where Maas not Between 25000 and 50000 

--maas� 25 bin ile 50 bin aras�nda olanlar dahil
select* from Ogretmen where Maas>=25000 and Maas <=50000 
select* from Ogretmen where Maas>=25000 or Maas <=50000 

select* from Ogretmen where Maas>=25000 and Adres ='Levent' 

select * from Ogretmen where Adres like '%Levent%' and Maas = 50000
select * from Ogretmen where Adres ='Levent' and Maas = 50000

--Adresi levent veya sar�yer olanlar�n maas� 30 binden b�y�k olanlar� listele
select * from Ogretmen where (Adres ='Levent' or Adres='Sar�yer') and Maas>30000

--Bran�� T�rk�e veya adresi taksim olanlar�n maa�� 30 binden b�y�k olanlar�
select * from Ogretmen where (Brans= 'T�rk�e' or Adres= 'Taksim') and Maas>30000
