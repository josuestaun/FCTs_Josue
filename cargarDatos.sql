USE [BdFCTs]
GO
Delete FCTs
Delete OfertasFCT
Delete Alumnos
Delete Empresas
Delete Ciclos
Delete Profes
GO

INSERT [dbo].[Ciclos] ([Id], [Nombre], [Tipo]) VALUES (N'AF', N'Administración y Finanzas', N'CFS')
GO
INSERT [dbo].[Ciclos] ([Id], [Nombre], [Tipo]) VALUES (N'Asir', N'Administración de Sistemas Informáticos en Red', N'CFS')
GO
INSERT [dbo].[Ciclos] ([Id], [Nombre], [Tipo]) VALUES (N'Dam', N'Desarrollo de Aplicaciones Multiplataforma', N'CFS')
GO
INSERT [dbo].[Ciclos] ([Id], [Nombre], [Tipo]) VALUES (N'Smr', N'Sistemas Microinformáticos y Redes', N'CFM')
GO
INSERT [dbo].[Alumnos] ([NMatricula], [Nombre], [Telefono], [Aprobado], [IdCiclo]) VALUES (7, N'Bouazdia Imanol DT', N'645478965', 1, N'Dam')
GO
INSERT [dbo].[Alumnos] ([NMatricula], [Nombre], [Telefono], [Aprobado], [IdCiclo]) VALUES (11, N'Cuello Unai DT', N'612345678', 1, N'Dam')
GO
INSERT [dbo].[Alumnos] ([NMatricula], [Nombre], [Telefono], [Aprobado], [IdCiclo]) VALUES (16, N'Gaztelu Pablo ST', N'987456321', 1, N'Smr')
GO
INSERT [dbo].[Alumnos] ([NMatricula], [Nombre], [Telefono], [Aprobado], [IdCiclo]) VALUES (102, N'Goikoetxea Álvaro DF', N'654654321', 0, N'Dam')
GO
INSERT [dbo].[Alumnos] ([NMatricula], [Nombre], [Telefono], [Aprobado], [IdCiclo]) VALUES (193, N'Hazas Gorka ST', N'985478541', 1, N'Smr')
GO
INSERT [dbo].[Alumnos] ([NMatricula], [Nombre], [Telefono], [Aprobado], [IdCiclo]) VALUES (230, N'Junquitu Maitane DT', N'987456321', 1, N'Dam')
GO
INSERT [dbo].[Alumnos] ([NMatricula], [Nombre], [Telefono], [Aprobado], [IdCiclo]) VALUES (234, N'Martín Josué AF', N'645585858', 0, N'Asir')
GO
INSERT [dbo].[Alumnos] ([NMatricula], [Nombre], [Telefono], [Aprobado], [IdCiclo]) VALUES (324, N'Méndez Embie DF', N'654789987', 0, N'Dam')
GO
INSERT [dbo].[Alumnos] ([NMatricula], [Nombre], [Telefono], [Aprobado], [IdCiclo]) VALUES (343, N'Redrejo Javier AF', N'641123365', 0, N'Asir')
GO
INSERT [dbo].[Alumnos] ([NMatricula], [Nombre], [Telefono], [Aprobado], [IdCiclo]) VALUES (345, N'Sáez Ekaitz ST', N'654741259', 1, N'Smr')
GO
INSERT [dbo].[Alumnos] ([NMatricula], [Nombre], [Telefono], [Aprobado], [IdCiclo]) VALUES (453, N'Torregrosa Eneko AT', N'978456456', 1, N'Asir')
GO
INSERT [dbo].[Alumnos] ([NMatricula], [Nombre], [Telefono], [Aprobado], [IdCiclo]) VALUES (543, N'Zhunaula Nabil DT', N'641369785', 1, N'Dam')
GO
INSERT [dbo].[Alumnos] ([NMatricula], [Nombre], [Telefono], [Aprobado], [IdCiclo]) VALUES (765, N'Crespo Aingeru DT', N'978454564', 1, N'Dam')
GO
INSERT [dbo].[Alumnos] ([NMatricula], [Nombre], [Telefono], [Aprobado], [IdCiclo]) VALUES (789, N'Elizondo Jone SF', N'987456654', 0, N'Smr')
GO
INSERT [dbo].[Alumnos] ([NMatricula], [Nombre], [Telefono], [Aprobado], [IdCiclo]) VALUES (921, N'Gil Mikel DF', N'987654654', 0, N'Dam')
GO
INSERT [dbo].[Alumnos] ([NMatricula], [Nombre], [Telefono], [Aprobado], [IdCiclo]) VALUES (999, N'Gutiérrez Joel AT', N'948454545', 1, N'Asir')
GO
INSERT [dbo].[Alumnos] ([NMatricula], [Nombre], [Telefono], [Aprobado], [IdCiclo]) VALUES (1124, N'Henández Julen DT', N'987456369', 1, N'Dam')
GO
INSERT [dbo].[Alumnos] ([NMatricula], [Nombre], [Telefono], [Aprobado], [IdCiclo]) VALUES (2342, N'Lecuona Daniel AT', N'654414141', 1, N'Asir')
GO
INSERT [dbo].[Alumnos] ([NMatricula], [Nombre], [Telefono], [Aprobado], [IdCiclo]) VALUES (3242, N'Martínez Marcos AT', N'945696587', 1, N'Asir')
GO
INSERT [dbo].[Empresas] ([Id], [Nombre], [TelefonoContacto]) VALUES (1, N'Atecna S.A.L', N'987456987')
GO
INSERT [dbo].[Empresas] ([Id], [Nombre], [TelefonoContacto]) VALUES (2, N'Biko2', N'948451245')
GO
INSERT [dbo].[Empresas] ([Id], [Nombre], [TelefonoContacto]) VALUES (3, N'Contigo 2020 S.L.', N'948456328')
GO
INSERT [dbo].[Empresas] ([Id], [Nombre], [TelefonoContacto]) VALUES (4, N'Isringhausen Spain, S.L.U.
', N'645456587')
GO
INSERT [dbo].[Empresas] ([Id], [Nombre], [TelefonoContacto]) VALUES (5, N'Nafarco', N'654125485')
GO
INSERT [dbo].[Empresas] ([Id], [Nombre], [TelefonoContacto]) VALUES (6, N'Nubapp Applications S.L.
', N'948635792')
GO
INSERT [dbo].[Empresas] ([Id], [Nombre], [TelefonoContacto]) VALUES (7, N'Nubba Informática', N'948437855')
GO
INSERT [dbo].[Empresas] ([Id], [Nombre], [TelefonoContacto]) VALUES (8, N'Siemens Gamesa', N'978456456')
GO
INSERT [dbo].[Empresas] ([Id], [Nombre], [TelefonoContacto]) VALUES (9, N'Nuonet Gestión, S.L:', N'948369354')
GO
INSERT [dbo].[Empresas] ([Id], [Nombre], [TelefonoContacto]) VALUES (10, N'540', N'654197584')
GO
INSERT [dbo].[Empresas] ([Id], [Nombre], [TelefonoContacto]) VALUES (11, N'Zeroa Multimedia', N'978454585')
GO
INSERT [dbo].[Empresas] ([Id], [Nombre], [TelefonoContacto]) VALUES (12, N'Brandok', N'654456654')
GO
INSERT [dbo].[Empresas] ([Id], [Nombre], [TelefonoContacto]) VALUES (13, N'Electro Hogar Bayona, S.A.', N'948758745')
GO
INSERT [dbo].[Empresas] ([Id], [Nombre], [TelefonoContacto]) VALUES (14, N'CYC', N'948454545')
GO
INSERT [dbo].[Empresas] ([Id], [Nombre], [TelefonoContacto]) VALUES (15, N'Tracasa Instrumental', N'654478965')
GO
INSERT [dbo].[Empresas] ([Id], [Nombre], [TelefonoContacto]) VALUES (16, N'Infotec Navarra S.L.', N'948456456')
GO
INSERT [dbo].[Empresas] ([Id], [Nombre], [TelefonoContacto]) VALUES (17, N'Nadetec Soluciones S.L.', N'948454784')
GO
INSERT [dbo].[Empresas] ([Id], [Nombre], [TelefonoContacto]) VALUES (18, N'Volkswagen Navarra', N'948565656')
GO
INSERT [dbo].[Empresas] ([Id], [Nombre], [TelefonoContacto]) VALUES (19, N'Javyser Formación y Desarrollo SL', N'948585858')
GO
INSERT [dbo].[Empresas] ([Id], [Nombre], [TelefonoContacto]) VALUES (20, N'Conatel', N'648484848')
GO
INSERT [dbo].[Empresas] ([Id], [Nombre], [TelefonoContacto]) VALUES (50, N'Erasmus', N'948124129')
GO
INSERT [dbo].[Profes] ([Id], [Nombre]) VALUES (N'Abilio', N'Abilio Diaz')
GO
INSERT [dbo].[Profes] ([Id], [Nombre]) VALUES (N'Alberto', N'Alberto Aginaga')
GO
INSERT [dbo].[Profes] ([Id], [Nombre]) VALUES (N'Ander', N'Ander Frago')
GO
INSERT [dbo].[Profes] ([Id], [Nombre]) VALUES (N'Angel', N'Ángel Zúñiga')
GO
INSERT [dbo].[Profes] ([Id], [Nombre]) VALUES (N'Dani', N'Dani Martínez')
GO
INSERT [dbo].[Profes] ([Id], [Nombre]) VALUES (N'Iban', N'Iban Sarria')
GO
INSERT [dbo].[Profes] ([Id], [Nombre]) VALUES (N'Javier', N'Javier Romera')
GO
INSERT [dbo].[Profes] ([Id], [Nombre]) VALUES (N'Luis ', N'Luis Agero')
GO
INSERT [dbo].[Profes] ([Id], [Nombre]) VALUES (N'María', N'María Martín')
GO
INSERT [dbo].[Profes] ([Id], [Nombre]) VALUES (N'Silvia', N'Silvia Sanz')
GO
INSERT [dbo].[FCTs] ([NMatricula], [IdEmpresa], [TutorInsti], [TutorEmpresa]) VALUES (7, 1, N'María', N'Olatz Garmendia')
GO
INSERT [dbo].[FCTs] ([NMatricula], [IdEmpresa], [TutorInsti], [TutorEmpresa]) VALUES (11, 5, N'María', N'Patxi Larrainzar')
GO
INSERT [dbo].[FCTs] ([NMatricula], [IdEmpresa], [TutorInsti], [TutorEmpresa]) VALUES (765, 2, N'Iban', N'djfka')
GO
INSERT [dbo].[OfertasFCT] ([IdEmpresa], [IdCiclo], [Cantidad]) VALUES (1, N'Dam', 2)
GO
INSERT [dbo].[OfertasFCT] ([IdEmpresa], [IdCiclo], [Cantidad]) VALUES (2, N'Dam', 1)
GO
INSERT [dbo].[OfertasFCT] ([IdEmpresa], [IdCiclo], [Cantidad]) VALUES (3, N'Asir', 1)
GO
INSERT [dbo].[OfertasFCT] ([IdEmpresa], [IdCiclo], [Cantidad]) VALUES (3, N'Dam', 1)
GO
INSERT [dbo].[OfertasFCT] ([IdEmpresa], [IdCiclo], [Cantidad]) VALUES (3, N'Smr', 1)
GO
INSERT [dbo].[OfertasFCT] ([IdEmpresa], [IdCiclo], [Cantidad]) VALUES (4, N'Dam', 1)
GO
INSERT [dbo].[OfertasFCT] ([IdEmpresa], [IdCiclo], [Cantidad]) VALUES (5, N'Asir', 1)
GO
INSERT [dbo].[OfertasFCT] ([IdEmpresa], [IdCiclo], [Cantidad]) VALUES (5, N'Dam', 1)
GO
INSERT [dbo].[OfertasFCT] ([IdEmpresa], [IdCiclo], [Cantidad]) VALUES (6, N'Dam', 1)
GO
INSERT [dbo].[OfertasFCT] ([IdEmpresa], [IdCiclo], [Cantidad]) VALUES (7, N'Dam', 2)
GO
INSERT [dbo].[OfertasFCT] ([IdEmpresa], [IdCiclo], [Cantidad]) VALUES (8, N'Dam', 1)
GO
INSERT [dbo].[OfertasFCT] ([IdEmpresa], [IdCiclo], [Cantidad]) VALUES (10, N'Dam', 1)
GO
INSERT [dbo].[OfertasFCT] ([IdEmpresa], [IdCiclo], [Cantidad]) VALUES (14, N'Asir', 3)
GO
INSERT [dbo].[OfertasFCT] ([IdEmpresa], [IdCiclo], [Cantidad]) VALUES (14, N'Dam', 1)
GO
INSERT [dbo].[OfertasFCT] ([IdEmpresa], [IdCiclo], [Cantidad]) VALUES (15, N'Asir', 1)
GO
INSERT [dbo].[OfertasFCT] ([IdEmpresa], [IdCiclo], [Cantidad]) VALUES (16, N'Asir', 2)
GO
INSERT [dbo].[OfertasFCT] ([IdEmpresa], [IdCiclo], [Cantidad]) VALUES (17, N'Asir', 2)
GO
INSERT [dbo].[OfertasFCT] ([IdEmpresa], [IdCiclo], [Cantidad]) VALUES (17, N'Dam', 1)
GO
INSERT [dbo].[OfertasFCT] ([IdEmpresa], [IdCiclo], [Cantidad]) VALUES (18, N'Asir', 1)
GO
INSERT [dbo].[OfertasFCT] ([IdEmpresa], [IdCiclo], [Cantidad]) VALUES (18, N'Smr', 1)
GO
INSERT [dbo].[OfertasFCT] ([IdEmpresa], [IdCiclo], [Cantidad]) VALUES (19, N'Asir', 4)
GO
INSERT [dbo].[OfertasFCT] ([IdEmpresa], [IdCiclo], [Cantidad]) VALUES (20, N'Asir', 1)
GO
