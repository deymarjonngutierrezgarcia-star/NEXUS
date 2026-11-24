USE NexusDB;
GO

IF OBJECT_ID('dbo.Partidas', 'U') IS NULL
BEGIN
    CREATE TABLE dbo.Partidas (
        IdPartida      INT IDENTITY(1,1) PRIMARY KEY,
        NombreJugador  NVARCHAR(50)  NOT NULL,
        Nivel          INT           NOT NULL,
        Puntuacion     INT           NOT NULL,
        EstadoActual   NVARCHAR(30)  NOT NULL,
        FechaGuardado  DATETIME      NOT NULL DEFAULT GETDATE()
    );
END
GO