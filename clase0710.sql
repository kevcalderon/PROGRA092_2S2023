-- usuario
-- artista
-- playlist *
-- cancion *
-- detalle



create table Artista(
    Id_artista INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
    nombre varchar(50) NOT NULL,
    nacionalidad VARCHAR(50) NOT NULL,
    fecha_inicio DATE NOT NULL
);

create table Cancion(
    Id_cancion INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
    titulo VARCHAR(50) NOT NULL,
    album varchar(50) NOT NULL,
    fecha_lanzamiento DATE NOT NULL,
    genero VARCHAR(50) NOT NULL,
    ubicacion varchar(150) NOT NULL,
    Id_artista INT NOT NULL,
    FOREIGN KEY (Id_artista) REFERENCES Artista(Id_artista)
);

create table Playlist(
    Id_Playlist INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
    nombre_playlist VARCHAR(50) NOT NULL,
    fecha_creacion VARCHAR(50) NOT NULL,
    img_cover VARCHAR(150) NOT NULL
);





create table DetallePlaylist(
    Id_Detalle INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
    Id_Playlist INT NOT NULL,
    Id_Cancion INT NOT NULL,
    FOREIGN KEY (Id_Cancion) REFERENCES Cancion(Id_cancion),
    FOREIGN KEY (Id_Playlist) REFERENCES Playlist(Id_Playlist)
);

insert into Artista(nombre, nacionalidad, fecha_inicio) VALUES ('DANNY OCEAN', 'PR', '2012-01-01');
insert into Playlist(nombre_playlist, fecha_creacion, img_cover) VALUES ('THIS IS BAD BUNNY', '2023-01-01','C:/IMAGES/ALBUM/BADBUNNY')

select * from Artista;

select * from Playlist;
select * from Cancion;


INSERT INTO Cancion (titulo, album, fecha_lanzamiento, genero, ubicacion, Id_artista) VALUES ('UN PREVIEW', 'NUEVOS', '2023-01-01', 'REGGUETON', 'C://IMAGE/CANCIONES', 1)

select * from DetallePlaylist;

INSERT INTO DetallePlaylist (id_playlist, id_cancion) VALUES (1, 1)


-- REPORTES

-- Cantidad de canciones que posee cada artista (Nombre del artista y cantidad de canciones)
SELECT Artista.nombre, count(c.Id_cancion) as cantidad FROM Artista
INNER JOIN cancion c on Artista.Id_artista = c.Id_artista










