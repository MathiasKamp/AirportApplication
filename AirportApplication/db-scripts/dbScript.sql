

create table Airport
(
    Airport_IATA varchar (3) not null primary key,
    Airport_Name varchar(50) not null,
    Airport_City varchar (50) not null

);

create table Airline
(
    Airline_Id integer not null identity (1,1) primary key,
    Airline_Name varchar (50) not null 
);


create table Route
(
    Route_Id integer not null identity (1,1) primary key,
    Route_Operator_Id integer not null,
    Route_Owner_Id integer not null,
    Route_Destination_IATA varchar(3) not null,
    Route_Home_IATA varchar(3) not null

        constraint FK_Airline_Route_Operator foreign key (Route_Operator_Id)
        references Airline (Airline_Id)

        
    
);

alter table Route add 

        constraint FK_Airline_Route_Owner foreign key (Route_Owner_Id)
            references Airline (Airline_Id);
            
alter table Route add

        constraint FK_Airport_Destination foreign key (Route_Destination_IATA)
            references airport (Airport_IATA);


create table RouteOperator
(

    Route_id integer not null,
    Route_Operator_Id integer not null


        constraint FK_Route foreign key (Route_id)
            references Route (Route_id)

        
)

alter table RouteOperator add
    constraint FK_Airline_Operator foreign key (Route_Operator_Id)
        references Airline (Airline_Id);