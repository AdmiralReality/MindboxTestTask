# “екст задачи:


¬ базе данных MS SQL Server есть продукты и категории.
ќдному продукту может соответствовать много категорий, в одной категории может быть много продуктов.
Ќапишите SQL запрос дл€ выбора всех пар Ђ»м€ продукта Ц »м€ категорииї.
≈сли у продукта нет категорий, то его им€ все равно должно выводитьс€.


## ƒопущени€ и предположени€.

“ак как в задаче не указано каким именно образом организована база данных, содержание таблиц и колонок,
то € осмелюсь сделать предположение "как оно выгл€дело бы по-моему".

“аблица ```Products``` в упрощенном виде выгл€дела бы так:
```
CREATE TABLE Products (
	product_id int PRIMARY KEY,
	name varchar (50) NOT NULL
);
```

“аблица ```Categories```:
```
CREATE TABLE Categories (
	category_id int PRIMARY KEY,
	name varchar (50) NOT NULL
);
```

ƒл€ выполнени€ "один продукт может иметь несколько категорий" € бы использовал св€зь "many to many",
котора€ выражаетс€ путем создани€ еще одной таблице ```ProductsCategories```:
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

## «апрос:

“аким образом, дл€ выбранной структуры нужно выполнить запрос:
```
SELECT Products.name, Categories.name FROM Products
LEFT JOIN ProductsCategories ON Products.product_id = ProductsCategories.product_id
LEFT JOIN Categories ON ProductsCategories.category_id = Categories.category_id
```
„тобы вывести дл€ каждого продукта все категории, которым он принадлежит, а также в тех случа€х когда у продукта нет ни одной категории.