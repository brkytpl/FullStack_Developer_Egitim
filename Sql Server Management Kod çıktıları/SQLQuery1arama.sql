create proc sAra_musteri
(
@musteri varchar(50)
)
as
select * from  Satislar where musteri like '%'+@musteri+'%'

create proc sAra_urun
(
@urun varchar(50)
)
as
select * from  Satislar where urun like '%'+@urun+'%'

create proc sAra
(
@secim varchar(50),
@aranan varchar(50)
)
as
if(@secim='Müşteri')
begin
select * from Satislar where musteri like '%'+@aranan+'%'
end
else
begin
if(@secim='Ürün')
begin
select * from Satislar where urun like '%'+@aranan+'%'
end
end