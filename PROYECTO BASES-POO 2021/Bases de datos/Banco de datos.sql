CREATE DATABASE ProyectoFinal;
USE ProyectoFinal;
SET LANGUAGE us_english;

--Creating tables
CREATE TABLE EMPLOYEE(
	employee_id INT IDENTITY PRIMARY KEY,
	username VARCHAR(50) NOT NULL,
	password VARCHAR(255) NOT NULL,
	name VARCHAR(100) NOT NULL,
	email VARCHAR(100) NOT NULL,
	address VARCHAR(100) NOT NULL,
	type_id INT NOT NULL,
	booth_id INT
);

CREATE TABLE BOOTH(
	booth_id INT IDENTITY PRIMARY KEY,
	address VARCHAR(255) NOT NULL,
	phone VARCHAR(25) NOT NULL,
	email VARCHAR(100) NOT NULL,
	employee_in_charge_id INT
);

CREATE TABLE LOG(
	log_id INT IDENTITY PRIMARY KEY,
	booth_id INT NOT NULL,
	employee_id INT NOT NULL,
	log_in datetime NOT NULL,
	log_out datetime NOT NULL
);

CREATE TABLE TYPE(
	type_id INT IDENTITY PRIMARY KEY,
	type VARCHAR(50) NOT NULL
);

CREATE TABLE EMPLOYEEXAPPOINTMENT(
	id INT IDENTITY PRIMARY KEY,
	employee_id INT,
	appointment_id INT
);

CREATE TABLE VACCINATION_CENTER(
	center_id INT IDENTITY PRIMARY KEY,
	vaccination_center VARCHAR(100)
);

CREATE TABLE APPOINTMENT(
	appointment_id INT IDENTITY PRIMARY KEY,
	date_time DATETIME NOT NULL,
	center_id INT NOT NULL,
	dui INT NOT NULL,
	queue_start DATETIME NOT NULL,
	vaccination_time DATETIME NOT NULL
);

CREATE TABLE APPOINTMENTXSIDE_EFFECT(
	id INT IDENTITY PRIMARY KEY,
	appointment_id INT NOT NULL,
	effect_id INT NOT NULL,
	description VARCHAR(255) NOT NULL,
	time DATETIME NOT NULL
);

CREATE TABLE SIDE_EFFECT(
	effect_id INT IDENTITY PRIMARY KEY,
	side_effect VARCHAR(255) NOT NULL
);

CREATE TABLE CITIZEN(
	dui INT PRIMARY KEY,
	name VARCHAR(255) NOT NULL,
	address VARCHAR(255) NOT NULL,
	phone VARCHAR(25) NOT NULL,
	email VARCHAR(150),
	essential_job INT 
);

CREATE TABLE DISEASEXCITIZEN(
 id INT IDENTITY PRIMARY KEY,
 disease_id INT NOT NULL,
 citizen_id INT NOT NULL
);

CREATE TABLE DISEASE(
	disease_id INT IDENTITY PRIMARY KEY,
	disease VARCHAR(255) NOT NULL
);


--Foreign keys
ALTER TABLE BOOTH 
ADD CONSTRAINT FK_EMPLOYEE_IN_CHARGE
FOREIGN KEY (employee_in_charge_id) REFERENCES EMPLOYEE(employee_id);

ALTER TABLE EMPLOYEE 
ADD CONSTRAINT FK_TYPE_ID
FOREIGN KEY (type_id) REFERENCES TYPE (type_id);

ALTER TABLE EMPLOYEE 
ADD CONSTRAINT FK_BOOTH_ID
FOREIGN KEY (booth_id) REFERENCES BOOTH (booth_id);

ALTER TABLE LOG 
ADD CONSTRAINT FK_LOG_BOOTH_ID
FOREIGN KEY (booth_id) REFERENCES BOOTH (booth_id);

ALTER TABLE LOG 
ADD CONSTRAINT FK_LOG_EMPLOYEE_ID
FOREIGN KEY (employee_id) REFERENCES EMPLOYEE (employee_id);

ALTER TABLE EMPLOYEEXAPPOINTMENT 
ADD CONSTRAINT FK_EMPLOYEEXAPPOINTMENT_EMPLOYEE
FOREIGN KEY (employee_id) REFERENCES EMPLOYEE (employee_id);

ALTER TABLE EMPLOYEEXAPPOINTMENT 
ADD CONSTRAINT FK_EMPLOYEEXAPPOINTMENT_APPOINTMENT
FOREIGN KEY (appointment_id) REFERENCES APPOINTMENT (appointment_id);

ALTER TABLE DISEASEXCITIZEN
ADD CONSTRAINT FK_DISEASEXCITIZEN_DISEASE
FOREIGN KEY (disease_id) REFERENCES DISEASE (disease_id);

ALTER TABLE DISEASEXCITIZEN 
ADD CONSTRAINT FK_DISEASEXCITIZEN_CITIZEN
FOREIGN KEY (citizen_id) REFERENCES CITIZEN (dui);

ALTER TABLE APPOINTMENT
ADD CONSTRAINT FK_VACCINATION_CENTER
FOREIGN KEY (center_id) REFERENCES VACCINATION_CENTER (center_id);

ALTER TABLE APPOINTMENT
ADD CONSTRAINT FK_CITIZEN_ID
FOREIGN KEY (dui) REFERENCES CITIZEN (dui);

ALTER TABLE APPOINTMENTXSIDE_EFFECT
ADD CONSTRAINT FK_APPOINTMENTXSIDE_EFFECT_APPOINTMENT
FOREIGN KEY (appointment_id) REFERENCES APPOINTMENT (appointment_id);

ALTER TABLE APPOINTMENTXSIDE_EFFECT
ADD CONSTRAINT FK_APPOINTMENTXSIDE_EFFECT
FOREIGN KEY (effect_id) REFERENCES SIDE_EFFECT (effect_id);


--Databank
INSERT [dbo].[TYPE] ([type]) VALUES ('Vacunador');
INSERT [dbo].[TYPE] ([type]) VALUES ('Enfermera');
INSERT [dbo].[TYPE] ([type]) VALUES ('Atencion al cliente');
INSERT [dbo].[TYPE] ([type]) VALUES ('Doctor');
INSERT [dbo].[TYPE] ([type]) VALUES ('Administracion');

INSERT [dbo].[VACCINATION_CENTER] ([vaccination_center]) VALUES ('La Tiendona');
INSERT [dbo].[VACCINATION_CENTER] ([vaccination_center]) VALUES ('Megacentro');
INSERT [dbo].[VACCINATION_CENTER] ([vaccination_center]) VALUES ('ExCifco');
INSERT [dbo].[VACCINATION_CENTER] ([vaccination_center]) VALUES ('Hospital Rosales');
INSERT [dbo].[VACCINATION_CENTER] ([vaccination_center]) VALUES ('Centro La Esperanza');

INSERT [dbo].[DISEASE] ([disease]) VALUES ('Diabetes');
INSERT [dbo].[DISEASE] ([disease]) VALUES ('Hipertension');
INSERT [dbo].[DISEASE] ([disease]) VALUES ('Arritmia');
INSERT [dbo].[DISEASE] ([disease]) VALUES ('Cancer');
INSERT [dbo].[DISEASE] ([disease]) VALUES ('Impedimento Mental');

INSERT [dbo].[CITIZEN] ([dui],[name], [address], [phone], [email], [essential_job] ) VALUES (00074720,'Alex Morello', 'Calle La Campiña ', '77477584', 'Alex.morello@gmail.com', 674857);

INSERT [dbo].[SIDE_EFFECT] ([side_effect]) VALUES ('Dolor de cabeza');
INSERT [dbo].[SIDE_EFFECT] ([side_effect]) VALUES ('Fiebre');
INSERT [dbo].[SIDE_EFFECT] ([side_effect]) VALUES ('Vomitos');
INSERT [dbo].[SIDE_EFFECT] ([side_effect]) VALUES ('Otros');
INSERT [dbo].[SIDE_EFFECT] ([side_effect]) VALUES ('Fatiga');
INSERT [dbo].[SIDE_EFFECT] ([side_effect]) VALUES ('Fiebre');
INSERT [dbo].[SIDE_EFFECT] ([side_effect]) VALUES ('Anafalaxia');

INSERT [dbo].[DISEASEXCITIZEN] ([disease_id], [citizen_id] ) VALUES (2,74720);

INSERT [dbo].[APPOINTMENT] ( [date_time] ,[center_id], [dui],[queue_start],[vaccination_time]) VALUES (CAST('1998-03-02T00:00:00.000' AS DateTime), 2,74720, CAST('1998-03-04T00:00:00.000' AS DateTime),CAST('1998-03-04T00:00:00.000' AS DateTime));

INSERT [dbo].[APPOINTMENTXSIDE_EFFECT] ([appointment_id], [effect_id], [description], [time]) VALUES (1,1,'Dolor de cabeza severo',CAST('1998-03-02T00:00:00.000' AS DateTime));

INSERT [dbo].[EMPLOYEE] ([username], [password], [name], [email], [address], [type_id], [booth_id]) VALUES ('John.Doe', 'qwerty', 'John Doe', 'John.doegmail.com', 'Calle Los Naranjos, Casa #1', 5, NULL);

INSERT [dbo].[BOOTH] ([address], [phone], [email], [employee_in_charge_id]) VALUES ('Calle Los Manzanos', '22747587', 'cabina12@gmail.gov', 1);
INSERT [dbo].[BOOTH] ([address], [phone], [email], [employee_in_charge_id]) VALUES ('Calle Las Mandarinas', '77485962', 'cabina02@gmail.com', 1);
INSERT [dbo].[BOOTH] ([address], [phone], [email], [employee_in_charge_id]) VALUES ('Calle Las Peras', '774834534', 'cabina022@gmail.com', 1);
INSERT [dbo].[BOOTH] ([address], [phone], [email], [employee_in_charge_id]) VALUES ('Calle Las Uvas', '77483457', 'cabina42@gmail.com', 1);
INSERT [dbo].[BOOTH] ([address], [phone], [email], [employee_in_charge_id]) VALUES ('Calle Principal #14', '77456782', 'cabina21@gmail.com', 1);
INSERT [dbo].[BOOTH] ([address], [phone], [email], [employee_in_charge_id]) VALUES ('Calle Principa #142', '774512312', 'cabina26@gmail.com', 1);

INSERT [dbo].[EMPLOYEE] ([username], [password], [name], [email], [address], [type_id], [booth_id]) VALUES ('Alex.Morales', 'qwerty', 'Alex morales', 'Alex.morales@gmail.com', 'Calle Las Peras, Casa #34', 3, 6);

INSERT [dbo].[EMPLOYEEXAPPOINTMENT] ([employee_id], [appointment_id] ) VALUES (2,1);

INSERT [dbo].[LOG] ([booth_id], [employee_id], [log_in], [log_out]) VALUES (6, 2, CAST('1998-01-02T00:00:00.000' AS DateTime), CAST('1998-02-02T00:00:00.000' AS DateTime));
INSERT [dbo].[LOG] ([booth_id], [employee_id], [log_in], [log_out]) VALUES (6, 1, CAST('1998-03-02T00:00:00.000' AS DateTime), CAST('1998-03-04T00:00:00.000' AS DateTime));
