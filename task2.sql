create table products (
	id INT IDENTITY(1,1) primary key,
	name text
);

create table categories (
	id INT IDENTITY(1,1) primary key,
	name text
);

create table links (
	product_id integer 
		references products (id),
	category_id integer 
		references categories (id)
);
insert into products (name)
values ('product1'), ('product2'), ('product3');

insert into categories(name)
values ('category1'), ('category2');

insert into links(product_id, category_id)
values (1, 1), (2, 2), (2, 2);

select pr.name as product_name, ct.name as category_name
from products pr
left JOIN links l on pr.id = l.product_id
left JOIN categories ct on ct.id = l.category_id
