ALTER PROCEDURE ESTUDIANTE.sp_ACTUALIZAR_ESTUDIANTE
@param_ID_ESTUDIANTE INT,
@param_NOMBRE_ESTUDIANTE VARCHAR(32),
@param_APELLIDOS_ESTUDIANTE VARCHAR(32),
@param_EDAD INT,
@param_PROMEDIO VARCHAR(32),
@param_CARNE VARCHAR(32),
@param_DIRECCION VARCHAR(32),
@param_NOMBRE_SEDE VARCHAR(32),
@param_TIPO_BECA VARCHAR(32)
AS

BEGIN

UPDATE ESTUDIANTE.tb_ESTUDIANTE
SET NOMBRE_ESTUDIANTE=@param_NOMBRE_ESTUDIANTE,
APELLIDOS_ESTUDIANTE=@param_APELLIDOS_ESTUDIANTE,
EDAD=@param_EDAD,
PROMEDIO=@param_PROMEDIO,
CARNE=@param_CARNE WHERE ID_ESTUDIANTE=@param_ID_ESTUDIANTE;


DECLARE @local_id_beca INT=(SELECT ID_BECA FROM ADMINISTRACION.tb_BECA WHERE TIPO_BECA=@param_tipo_beca)

	 IF EXISTS (SELECT ID_ESTUDIANTE, ID_BECA FROM ESTUDIANTE.tb_ESTUDIANTE_BECA WHERE ID_ESTUDIANTE=@param_ID_ESTUDIANTE AND ID_BECA=@local_id_beca AND IS_DELETED=1)
	 BEGIN
		UPDATE ESTUDIANTE.tb_ESTUDIANTE_BECA SET IS_DELETED=1 WHERE ID_ESTUDIANTE=@param_ID_ESTUDIANTE
		UPDATE ESTUDIANTE.tb_ESTUDIANTE_BECA SET IS_DELETED=0 WHERE ID_ESTUDIANTE=@param_ID_ESTUDIANTE AND ID_BECA=@local_id_beca AND IS_DELETED=1
	 END
	 ELSE IF NOT EXISTS (SELECT ID_ESTUDIANTE, ID_BECA FROM ESTUDIANTE.tb_ESTUDIANTE_BECA WHERE ID_ESTUDIANTE=@param_ID_ESTUDIANTE AND ID_BECA=@local_id_beca AND IS_DELETED=0)
	 BEGIN
	    UPDATE ESTUDIANTE.tb_ESTUDIANTE_BECA SET IS_DELETED=1 WHERE ID_ESTUDIANTE=@param_ID_ESTUDIANTE
		INSERT INTO ESTUDIANTE.tb_ESTUDIANTE_BECA(ID_ESTUDIANTE,ID_BECA) VALUES (@param_ID_ESTUDIANTE, @local_id_beca)
	 END


DECLARE @local_ID_DIRECCION INT
SET @local_ID_DIRECCION=(SELECT ID_DIRECCION_ESTUDIANTE FROM ESTUDIANTE.tb_ESTUDIANTE WHERE ID_ESTUDIANTE=@param_ID_ESTUDIANTE)

UPDATE ESTUDIANTE.tb_DIRECCION SET DETALLES=@param_DIRECCION WHERE ID_DIRECCION=@local_ID_DIRECCION

DECLARE @local_ID_SEDE INT
SET @local_ID_SEDE=(SELECT ID_SEDE FROM ADMINISTRACION.tb_SEDE WHERE NOMBRE_SEDE=@param_NOMBRE_SEDE)

IF EXISTS (SELECT ID_ESTUDIANTE, ID_SEDE FROM ESTUDIANTE.tb_ESTUDIANTE_SEDE WHERE ID_ESTUDIANTE=@param_ID_ESTUDIANTE AND ID_SEDE=@local_ID_SEDE AND IS_DELETED=1)
	BEGIN
		UPDATE ESTUDIANTE.tb_ESTUDIANTE_SEDE SET IS_DELETED=1 WHERE ID_ESTUDIANTE=@param_ID_ESTUDIANTE
		UPDATE ESTUDIANTE.tb_ESTUDIANTE_SEDE SET IS_DELETED=0 WHERE ID_ESTUDIANTE=@param_ID_ESTUDIANTE AND ID_SEDE=@local_ID_SEDE
	END
ELSE IF NOT EXISTS (SELECT ID_ESTUDIANTE, ID_SEDE FROM ESTUDIANTE.tb_ESTUDIANTE_SEDE WHERE ID_ESTUDIANTE=@param_ID_ESTUDIANTE AND ID_SEDE=@local_ID_SEDE AND IS_DELETED=0)
	BEGIN
		UPDATE ESTUDIANTE.tb_ESTUDIANTE_SEDE SET IS_DELETED=1 WHERE ID_ESTUDIANTE=@param_ID_ESTUDIANTE
	 INSERT INTO ESTUDIANTE.tb_ESTUDIANTE_SEDE (ID_ESTUDIANTE, ID_SEDE) VALUES (@param_ID_ESTUDIANTE, @local_ID_SEDE)
	END
RETURN 1;
END
--------------------------------------------------------------------
CREATE PROCEDURE ADMINISTRACION.sp_ACTUALIZAR_CURSO
@param_ID_CURSO INT,
@param_NOMBRE_CURSO VARCHAR(32),
@param_CREDITOS INT
AS

BEGIN

	UPDATE ADMINISTRACION.tb_CURSO 
		SET NOMBRE_CURSO=@param_NOMBRE_CURSO,
		CREDITOS=@param_CREDITOS 
	WHERE ID_CURSO=@param_ID_CURSO;

	RETURN 1;
END

-----------------------------------------------------------------

CREATE PROCEDURE ADMINISTRACION.sp_ACTUALIZAR_CARRERA
@param_ID_CARRERA INT,
@param_NOMBRE_CARRERA VARCHAR(32)
AS

BEGIN

UPDATE ADMINISTRACION.tb_CARRERA SET NOMBRE_CARRERA=@param_NOMBRE_CARRERA WHERE ID_CARRERA=@param_ID_CARRERA;
RETURN 1;
END

------------------------------------------------------------


CREATE PROCEDURE ADMINISTRACION.sp_ACTUALIZAR_SEDE
@param_ID_SEDE INT,
@param_NOMBRE_SEDE VARCHAR(32)
AS

BEGIN

UPDATE ADMINISTRACION.tb_SEDE SET NOMBRE_SEDE=@param_NOMBRE_SEDE WHERE ID_SEDE=@param_ID_SEDE;

RETURN 1;
END

------------------------------------------------------------

CREATE PROCEDURE ESTUDIANTE.sp_QUITAR_CURSO_ESTUDIANTE
@param_CARNE_ESTUDIANTE VARCHAR(32),
@param_NOMBRE_CURSO VARCHAR(32)

AS
BEGIN
DECLARE @local_ID_ESTUDIANTE INT ,@local_ID_CURSO INT
SET @local_ID_CURSO=(SELECT ID_CURSO FROM ADMINISTRACION.tb_CURSO WHERE NOMBRE_CURSO=@param_NOMBRE_CURSO)
SET @local_ID_ESTUDIANTE=(SELECT ID_ESTUDIANTE FROM ESTUDIANTE.tb_ESTUDIANTE WHERE CARNE=@param_CARNE_ESTUDIANTE)


UPDATE ESTUDIANTE.tb_ESTUDIANTE_CURSO SET IS_DELETED=1 WHERE ID_ESTUDIANTE=@local_ID_ESTUDIANTE AND ID_CURSO=@local_ID_CURSO
RETURN 1;
END

CREATE PROCEDURE ESTUDIANTE.sp_QUITAR_CARRERA_ESTUDIANTE
 @param_NOMBRE_CARRERA VARCHAR(32),
 @param_CARNE_ESTUDIANTE VARCHAR(32)
AS

BEGIN
DECLARE @local_ID_ESTUDIANTE INT ,@local_ID_CARRERA INT

SET @local_ID_CARRERA=(SELECT ID_CARRERA FROM ADMINISTRACION.tb_CARRERA WHERE NOMBRE_CARRERA=@param_NOMBRE_CARRERA)
SET @local_ID_ESTUDIANTE=(SELECT ID_ESTUDIANTE FROM ESTUDIANTE.tb_ESTUDIANTE WHERE CARNE=@param_CARNE_ESTUDIANTE)

UPDATE ESTUDIANTE.tb_ESTUDIANTE_CARRERA SET IS_DELETED=1 WHERE ID_ESTUDIANTE=@local_ID_ESTUDIANTE AND ID_CARRERA=@local_ID_CARRERA

RETURN 1;

END


CREATE PROCEDURE ESTUDIANTE.sp_QUITAR_TELEFONO_ESTUDIANTE
@param_ID_ESTUDIANTE INT,
@param_NUMERO VARCHAR(32)
AS
BEGIN
DECLARE @local_ID_NUMERO INT=(SELECT ID_TELEFONO FROM ESTUDIANTE.tb_TELEFONO WHERE NUMERO_TELEFONO=@param_NUMERO)

 UPDATE ESTUDIANTE.tb_ESTUDIANTE_TELEFONO SET IS_DELETED=1 WHERE ID_ESTUDIANTE=@param_ID_ESTUDIANTE AND ID_TELEFONO=@local_ID_NUMERO

END

