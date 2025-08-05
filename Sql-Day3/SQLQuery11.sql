/* Assume we have Stock table contains all details
about stocks, once u order first it has to check
whether qty is available or not if qty is available
then it has to move to the orders table and 
qty to be updated in stock table.  Amt to be added
to the Amount table */

create table Stock
(
   StockID int Identity(1,1) constraint 
   pk_stock_stockid primary key,
   StockName varchar(30),
   Quantity int,
   price numeric(9,2)
)
GO

Insert into Stock 
values('Books',55,233.44)

Insert into Stock
values('Pens',43,43.34)

Insert into Stock
values('Bottles',23,23.33)

Insert into Stock
values('Mobiles',45,5344.44)

Insert into Stock
values('Chairs',42,434.44)

select * from Stock
GO

Create  table Orders
(
   OrderId int Identity(1,1) constraint 
   pk_orders_orderid primary key,
   StockID int constraint fk_stock_stockid 
    references Stock(StockID),
   StockName varchar(30),
   QtyOrd int,
   Price numeric(9,2)
)
GO

Create Table Amount
(
  Gamt numeric(9,2)
)
GO

insert into Amount values(0)
GO

CREATE TRIGGER trgInsOrder on Orders for insert
as
   declare 
		@stockid int,
		@qtyord int,
		@qtyavail int,
		@dif int,
		@price float,
		@stockname varchar(30),
		@tot float,
		@flag int
  
   set @flag=1
   select @stockid=StockId,@qtyord=QtyOrd from 
    inserted
   select @qtyavail=Quantity,@stockname=StockName,@price=Price 
    from Stock where StockID=@StockID 
   set @dif=@qtyavail-@qtyord 
   if @dif < 0
   begin
     print 'Sorry Quantity not Available '
      set @flag=0
     rollback tran
     return
   end
   if @flag=1
   begin
   update stock set Quantity=@dif where Stockid=@stockid 
   set @tot=@qtyord*@price 
   update Orders set StockName=@StockName,QtyOrd=@QtyOrd,Price=@price 
    where StockID=@StockID 
   update Amount set Gamt=Gamt+@tot
   end
   Go

   Insert into Orders(StockID, QtyOrd) values(3,100) 
   GO

   select * from Orders
   GO

   select * from Amount
   GO