# ����� ������:


� ���� ������ MS SQL Server ���� �������� � ���������.
������ �������� ����� ��������������� ����� ���������, � ����� ��������� ����� ���� ����� ���������.
�������� SQL ������ ��� ������ ���� ��� ���� �������� � ��� ���������.
���� � �������� ��� ���������, �� ��� ��� ��� ����� ������ ����������.


## ��������� � �������������.

��� ��� � ������ �� ������� ����� ������ ������� ������������ ���� ������, ���������� ������ � �������,
�� � �������� ������� ������������� "��� ��� ��������� �� ��-�����".

������� ```Products``` � ���������� ���� ��������� �� ���:
```
CREATE TABLE Products (
	product_id int PRIMARY KEY,
	name varchar (50) NOT NULL
);
```

������� ```Categories```:
```
CREATE TABLE Categories (
	category_id int PRIMARY KEY,
	name varchar (50) NOT NULL
);
```

��� ���������� "���� ������� ����� ����� ��������� ���������" � �� ����������� ����� "many to many",
������� ���������� ����� �������� ��� ����� ������� ```ProductsCategories```:
```
CREATE TABLE ProductsCategories (
	product_id int NOT NULL,
	category_id int NOT NULL,
	PRIMARY KEY (product_id, category_id),
	FOREIGN KEY (product_id)
		REFERENCES Products (product_id),
	FOREIGN KEY (category_id)
		REFERENCES Categories (category_id)
);
```

## ������:

����� �������, ��� ��������� ��������� ����� ��������� ������:
```
SELECT Products.name, Categories.name FROM Products
LEFT JOIN ProductsCategories ON Products.product_id = ProductsCategories.product_id
LEFT JOIN Categories ON ProductsCategories.category_id = Categories.category_id
```
����� ������� ��� ������� �������� ��� ���������, ������� �� �����������, � ����� � ��� ������� ����� � �������� ��� �� ����� ���������.