--  SELECT * FROM "Customers";
--  SELECT * FROM "Discounts";
--  SELECT * FROM "Products";
--  SELECT * FROM "Sales";
--  SELECT * FROM "SalesPeople";

--Customers
INSERT INTO "Customers" ("FirstName","LastName","Address","PhoneNumber","StartDate") 
				VALUES ('Al','Tall','45 S Main St Alphretta, GA 30009','6784543524', '12/1/2022');
INSERT INTO "Customers" ("FirstName","LastName","Address","PhoneNumber","StartDate") 
				VALUES ('Taylor','Simpson','3440 Ridle Ln Roswell, GA 30076','7704567656', '03/10/2021');
INSERT INTO "Customers" ("FirstName","LastName","Address","PhoneNumber","StartDate") 
				VALUES ('Sam','Adams','4560 Old Milton PKWY Alphretta, GA 30005','7708975498', '06/12/2019');
INSERT INTO "Customers" ("FirstName","LastName","Address","PhoneNumber","StartDate") 
				VALUES ('Gene','Park','453 Long Lake Ln Duluth, GA 30096','4045463874', '05/12/2022');

--Discounts
INSERT INTO "Discounts" ("BeginDate","EndDate","DiscountPercentage","productId") 
				VALUES ('01/01/2023','01/31/2023', 10.00, 1);
INSERT INTO "Discounts" ("BeginDate","EndDate","DiscountPercentage","productId") 
				VALUES ('02/01/2023','02/28/2023','20.00', 2);
INSERT INTO "Discounts" ("BeginDate","EndDate","DiscountPercentage","productId") 
				VALUES ('03/01/2023','03/31/2023','5.00', 3);
INSERT INTO "Discounts" ("BeginDate","EndDate","DiscountPercentage","productId") 
				VALUES ('04/01/2023','04/30/2023','25.00', 4);



--Products
INSERT INTO "Products" ("Name","Manufacturer","Style","PurchasePrice","SalePrice", "QuantityOnHand", "CommissionPercentage") 
			VALUES ('Smooth',' Smooth Inc','Road Bike',75.00, 120.00, 12, 5.00);
INSERT INTO "Products" ("Name","Manufacturer","Style","PurchasePrice","SalePrice", "QuantityOnHand", "CommissionPercentage") 
				VALUES ('Ranger','S. Bike Inc','Touring Bike',95.00, 170.00, 2, 2.00);
INSERT INTO "Products" ("Name","Manufacturer","Style","PurchasePrice","SalePrice", "QuantityOnHand", "CommissionPercentage") 
				VALUES ('Eco','Eco Inc','Hybrid Bike',85.00, 150.00, 4, 4.00);
INSERT INTO "Products" ("Name","Manufacturer","Style","PurchasePrice","SalePrice", "QuantityOnHand", "CommissionPercentage") 
				VALUES ('Compact','Town Inc','City Bike',65.00, 100.00, 3, 3.00);
INSERT INTO "Products" ("Name","Manufacturer","Style","PurchasePrice","SalePrice", "QuantityOnHand", "CommissionPercentage") 
				VALUES ('Rough','Sam Inc','Gravel Bike',55.00, 150.00, 4, 6.00);
INSERT INTO "Products" ("Name","Manufacturer","Style","PurchasePrice","SalePrice", "QuantityOnHand", "CommissionPercentage") 
				VALUES ('Multi','Metal inc','Utility Bike',125.00, 170.00, 1, 10.00);
INSERT INTO "Products" ("Name","Manufacturer","Style","PurchasePrice","SalePrice", "QuantityOnHand", "CommissionPercentage") 
				VALUES ('Long Range','Welders Inc','Cyclo-cross Bike',45.00, 70.00, 2, 4.00);
INSERT INTO "Products" ("Name","Manufacturer","Style","PurchasePrice","SalePrice", "QuantityOnHand", "CommissionPercentage") 
				VALUES ('Loader','Brand LLC','Flat Bar Road Bike',75.00, 110.00, 3, 5.00);
INSERT INTO "Products" ("Name","Manufacturer","Style","PurchasePrice","SalePrice", "QuantityOnHand", "CommissionPercentage") 
				VALUES ('Green','Jason Inc','Mountain Bike',85.00, 170.00, 11, 6.00);
INSERT INTO "Products" ("Name","Manufacturer","Style","PurchasePrice","SalePrice", "QuantityOnHand", "CommissionPercentage") 
				VALUES ('Transporter','Two Brothers Manufacturing','Cargo Bike',105.00, 150.00, 10, 7.00);
INSERT INTO "Products" ("Name","Manufacturer","Style","PurchasePrice","SalePrice", "QuantityOnHand", "CommissionPercentage") 
				VALUES ('Advance','Elegant Inc','Time Trial Bike',75.00, 130.00, 8, 4.00);
INSERT INTO "Products" ("Name","Manufacturer","Style","PurchasePrice","SalePrice", "QuantityOnHand", "CommissionPercentage") 
				VALUES ('Precise','Simple Metals Inc','Track Bike',65.00, 150.00, 5, 12.00);
INSERT INTO "Products" ("Name","Manufacturer","Style","PurchasePrice","SalePrice", "QuantityOnHand", "CommissionPercentage") 
				VALUES ('Compete','Precious Inc','Triathlon Bike',85.00, 140.00, 6, 15.00);
INSERT INTO "Products" ("Name","Manufacturer","Style","PurchasePrice","SalePrice", "QuantityOnHand", "CommissionPercentage") 
				VALUES ('FunTime','Bike For Kids Inc','BMX Bike',95.00, 150.00, 8, 20.00);
INSERT INTO "Products" ("Name","Manufacturer","Style","PurchasePrice","SalePrice", "QuantityOnHand", "CommissionPercentage") 
				VALUES ('Ride-On','Speed Bikes LLC','Cruiser Bike',55.00, 90.00, 2, 14.00);
INSERT INTO "Products" ("Name","Manufacturer","Style","PurchasePrice","SalePrice", "QuantityOnHand", "CommissionPercentage") 
				VALUES ('EV-50','Eco Bike Inc','Electric Bike',65.00, 100.00, 4, 7.00);
INSERT INTO "Products" ("Name","Manufacturer","Style","PurchasePrice","SalePrice", "QuantityOnHand", "CommissionPercentage") 
				VALUES ('TwinHp','Performance Bike Inc','Motorized Bike',175.00, 220.00, 7, 4.00);




 --SalesPeople
INSERT INTO "SalesPeople" ("FirstName","LastName","Address","PhoneNumber","StartDate","TerminationDate", "managerId") 
				VALUES ('John','Becker','45 Long Tree Ln Snellville, GA 30078','6784564354', '03/1/2018', Null, 1);
INSERT INTO "SalesPeople" ("FirstName","LastName","Address","PhoneNumber","StartDate","TerminationDate", "managerId") 
				VALUES ('Karen','Tucker','876 GreenBriar CT, Roswell, GA 30078','6784513254', '05/12/2019', Null, 1);



 --Sales
INSERT INTO "Sales" ("SaleDate", "SalePrice", "salesPersonId","customerId","productId") 
				VALUES ('05/12/2022',85.65,2,1, 2);
INSERT INTO "Sales" ("SaleDate","SalePrice","salesPersonId","customerId","productId") 
				VALUES ('05/13/2022',77.85,1,2, 5);
INSERT INTO "Sales" ("SaleDate","SalePrice","salesPersonId","customerId","productId") 
				VALUES ('05/14/2022',175.35,2,3, 7);
INSERT INTO "Sales" ("SaleDate","SalePrice","salesPersonId","customerId","productId") 
				VALUES ('05/15/2022',205.65,1,4, 4);
INSERT INTO "Sales" ("SaleDate","SalePrice","salesPersonId","customerId","productId") 
				VALUES ('05/16/2022',65.65,2,5, 8);
INSERT INTO "Sales" ("SaleDate","SalePrice","salesPersonId","customerId","productId") 
				VALUES ('05/16/2022',114.55,2,1, 1);
INSERT INTO "Sales" ("SaleDate","SalePrice","salesPersonId","customerId","productId") 
				VALUES ('05/12/2022',115.66,1,2, 3);
INSERT INTO "Sales" ("SaleDate","SalePrice","salesPersonId","customerId","productId") 
				VALUES ('05/17/2022',145.05,2,3, 6);
INSERT INTO "Sales" ("SaleDate","SalePrice","salesPersonId","customerId","productId") 
				VALUES ('05/11/2022',67.75,1,4, 9);
INSERT INTO "Sales" ("SaleDate","SalePrice","salesPersonId","customerId","productId") 
				VALUES ('05/19/2022',89.95,2,5, 10);
INSERT INTO "Sales" ("SaleDate","SalePrice","salesPersonId","customerId","productId") 
				VALUES ('05/16/2022',87.25,2,1,11);
INSERT INTO "Sales" ("SaleDate","SalePrice","salesPersonId","customerId","productId") 
				VALUES ('05/14/2022',78.95,1,2, 12);
INSERT INTO "Sales" ("SaleDate","SalePrice","salesPersonId","customerId","productId") 
				VALUES ('05/18/2022',74.75,2,3, 13);
INSERT INTO "Sales" ("SaleDate","SalePrice","salesPersonId","customerId","productId") 
				VALUES ('03/15/2022',73.95,1,4, 14);
INSERT INTO "Sales" ("SaleDate","SalePrice","salesPersonId","customerId","productId") 
				VALUES ('02/16/2022',76.85,2,5, 15);
INSERT INTO "Sales" ("SaleDate","SalePrice","salesPersonId","customerId","productId") 
				VALUES ('01/12/2022',205.69,2,1, 16);
INSERT INTO "Sales" ("SaleDate","SalePrice","salesPersonId","customerId","productId") 
				VALUES ('07/13/2022',215.65,1,2, 17);
INSERT INTO "Sales" ("SaleDate","SalePrice","salesPersonId","customerId","productId") 
				VALUES ('08/14/2022',100.99,2,3, 18);
INSERT INTO "Sales" ("SaleDate","SalePrice","salesPersonId","customerId","productId") 
				VALUES ('06/15/2022',98.99,1,4, 15);
INSERT INTO "Sales" ("SaleDate","SalePrice","salesPersonId","customerId","productId") 
				VALUES ('09/16/2022',123.50,2,5, 2);
INSERT INTO "Sales" ("SaleDate","SalePrice","salesPersonId","customerId","productId") 
				VALUES ('08/12/2022',205.00, 2,1, 5);
INSERT INTO "Sales" ("SaleDate","SalePrice","salesPersonId","customerId","productId") 
				VALUES ('06/13/2022',125.00,1,2, 6);
INSERT INTO "Sales" ("SaleDate","SalePrice","salesPersonId","customerId","productId") 
				VALUES ('11/14/2022',54.70,2,3, 3);
INSERT INTO "Sales" ("SaleDate","SalePrice","salesPersonId","customerId","productId") 
				VALUES ('12/15/2022', 98.80,1,4, 8);
INSERT INTO "Sales" ("SaleDate","SalePrice","salesPersonId","customerId","productId") 
				VALUES ('3/16/2022', 85.50,2,5, 6);
				



