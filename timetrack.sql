Create table [Project]
(
	[id_project] Integer NOT NULL identity(1,1) primary key,
	[fk_employee] Integer NOT NULL,
	[name] Nvarchar(300) NOT NULL,
	[closed] Integer NULL,
	[startDate] Datetime NULL,
	[finishDate] Datetime NULL,
) 
go

Create table [Employee]
(
	[id_employee] Integer NOT NULL identity(1,1) primary key,
	[fullName] Nvarchar(300) NULL,
) 
go

Create table [Timesheet]
(
	[id_timesheet] Integer NOT NULL identity(1,1) primary key,
	[fk_employee] Integer NOT NULL,
	[fk_project] Integer NOT NULL,
	[Date] Datetime NULL,
	[SpendTime] Float NULL,
	[notes] Nvarchar(300) NULL,
) 
go

Alter table [Timesheet] add  foreign key([fk_project]) references [Project] ([id_project])  on update cascade on delete no action 
go
Alter table [Project] add  foreign key([fk_employee]) references [Employee] ([id_employee])  on update no action on delete no action 
go
Alter table [Timesheet] add  foreign key([fk_employee]) references [Employee] ([id_employee])  on update cascade on delete no action 
go


Set quoted_identifier on
go

/* Update trigger "tu_Project" for table "Project" */
Create trigger [tu_Project]
on [Project] after update as
begin	 
		
	declare @numrows int 
	select @numrows = @@rowcount
	if @numrows = 0
		return
	
	
	/* Restrict parent "Employee" when child "Project" updated */
 	if update([fk_employee])
 	begin
 		if ((select count(*)
 			from [Employee] t, inserted i
 			where t.[id_employee] = i.[fk_employee] ) != @numrows)
 			begin
 				throw 50002,'Parent does not exist in table ''Employee''. Cannot update child table ''Project''.',1
 				rollback transaction
 				return
 			end
 	end		
 
 
	
end
go

/* Update trigger "tu_Timesheet" for table "Timesheet" */
Create trigger [tu_Timesheet]
on [Timesheet] after update as
begin	 
		
	declare @numrows int 
	select @numrows = @@rowcount
	if @numrows = 0
		return
	
	
	
 /* Restrict parent "Employee" when child "Timesheet" updated */
 	if update([fk_employee])
 	begin
 		if ((select count(*)
 			from [Employee] t, inserted i
 			where t.[id_employee] = i.[fk_employee] ) != @numrows)
 			begin
 				throw  50002,'Parent does not exist in table ''Employee''. Cannot update child table ''Timesheet''.',1
 				rollback transaction
 				return
 			end
 	end		
 
 
	
end
go



/* Insert trigger "ti_Project" for table "Project" */
Create trigger [ti_Project]
on [Project] after insert as
begin	 
	
	declare @numrows int
	select @numrows = @@rowcount
	if @numrows = 0
		return
	
		/* Restrict child "Project" when parent "Employee" insert */
 	if update([fk_employee])
 	begin
 		if ((select count(*) 
 			from [Employee] t, inserted i
 			where t.[id_employee] = i.[fk_employee] ) != @numrows)
 			begin
 				throw  50004,'Parent does not exist in table ''Employee''. Cannot insert into child table ''Project''.',1
 				rollback transaction
 				return
 			end
 	end		
	
end
go

/* Insert trigger "ti_Timesheet" for table "Timesheet" */
Create trigger [ti_Timesheet]
on [Timesheet] after insert as
begin	 
	
	declare @numrows int
	select @numrows = @@rowcount
	if @numrows = 0
		return
	
	
 	/* Restrict child "Timesheet" when parent "Employee" insert */
 	if update([fk_employee])
 	begin
 		if ((select count(*) 
 			from [Employee] t, inserted i
 			where t.[id_employee] = i.[fk_employee] ) != @numrows)
 			begin
 				throw 50004,'Parent does not exist in table ''Employee''. Cannot insert into child table ''Timesheet''.',1
 				rollback transaction
 				return
 			end
 	end		
	
end
go


Set quoted_identifier off
go





