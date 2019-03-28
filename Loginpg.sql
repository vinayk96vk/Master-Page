create database Mydb
use Mydb

create table tblUser
(id varchar(20) primary key,
user_password varchar(20),
user_role varchar(20));
insert into tblUser values('Jeff','1234','user')
go
create proc prologic(@id varchar(20),@pass varchar(20))
as
begin
select user_role from tblUser where id=@id and user_password=@pass
end
go
execute prologic 'Jeff','1234'
