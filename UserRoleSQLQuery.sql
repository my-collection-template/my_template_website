CREATE TABLE UserAccouuntsRoles
(
ID int Identity,
Name nvarchar(50),
Username varchar(20) Unique,
AccessLevel int,
PRIMARY KEY (ID)
);

CREATE TABLE UserAccouunts
(
ID int Identity,
Name nvarchar(50),
Code varchar(20) Unique,
Passkey varchar(max),
RoleID int,
ProfileImage binary,
Phone varchar(15),
Email varchar(81),
Approved bit,
PRIMARY KEY (ID)
);

ALTER TABLE UserAccouunts 
ADD CONSTRAINT FK_UARole FOREIGN KEY (RoleID) REFERENCES UserAccouuntsRoles (ID);

ALTER TABLE [Features-jnc]
ALTER COLUMN StateId int Not NULL

ALTER TABLE [Features-jnc]
ALTER COLUMN ItemId int Not NULL

ALTER TABLE [Features-jnc]
ADD CONSTRAINT pk_Features_JNS_ID Primary Key(StateId, ItemId)