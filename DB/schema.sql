--Creating Tables

create table userInfo
(
	id				int			primary key			identity(1,1),
	firstName		varchar(20) not null,
	lastName		varchar(20) not null,
	email			varchar(50) not null,
	password		varchar(20) not null,
	passwordSalt	varchar(max)null,
	isAdmin			bit			not null	
);

create table productLine
(
	id				        int			  primary key			identity(1,1),
	named			        varchar(100)  not null,
	shortDescription		varchar(250)  null,
	longDescription			varchar(max)  null,
	pictureUrl				varchar(max)  null
);


create table products
(
	id						int			  primary key				identity(1,1),
	named					varchar(100)  not null,
	shortDescription        varchar(250)  null,
	longDescription			varchar(max)  null,
	price					varchar(20)   null,
	productLineId			int			  not null,
	pictureUrl				varchar(max)  null,

	constraint fk_products_productLine foreign key (productLineId) references productLine(id),
);

create table userInfoProducts
(
	id						int			  primary key				identity(1,1),
	userInfoId				int			  not null,
	productsId				int			  null,

	constraint fk_userInfoProducts_userInfo foreign key (userInfoId) references userInfo(id),
	constraint fk_userInfoProducts_products foreign key (productsId) references products(id),
);