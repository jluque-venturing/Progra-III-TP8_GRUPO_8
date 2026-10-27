USE BDSucursales
GO

IF OBJECT_ID('spEliminarSucursal', 'P') IS NOT NULL
    DROP PROCEDURE spEliminarSucursal
GO

CREATE PROCEDURE spEliminarSucursal
(
    @IDSUCURSAL INT
)
AS
DELETE Sucursal WHERE Id_Sucursal = @IDSUCURSAL
RETURN
GO
