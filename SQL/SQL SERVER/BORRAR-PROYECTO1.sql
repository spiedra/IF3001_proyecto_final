ALTER PROCEDURE ESTUDIANTE.sp_BORRAR_ESTUDIANTE
@param_CARNE INT
AS

BEGIN

 IF EXISTS(SELECT ID_ESTUDIANTE FROM ESTUDIANTE.tb_ESTUDIANTE WHERE CARNE=@param_CARNE)
BEGIN
DECLARE @local_ID_ESTUDIANTE INT=(SELECT ID_ESTUDIANTE FROM ESTUDIANTE.tb_ESTUDIANTE WHERE CARNE=@param_CARNE);

UPDATE ESTUDIANTE.tb_ESTUDIANTE SET IS_DELETED=1 WHERE ID_ESTUDIANTE=@local_ID_ESTUDIANTE;
UPDATE ESTUDIANTE.tb_ESTUDIANTE_TELEFONO SET IS_DELETED =1 WHERE ID_ESTUDIANTE=@local_ID_ESTUDIANTE;
UPDATE ESTUDIANTE.tb_ESTUDIANTE_CURSO SET IS_DELETED=1 WHERE ID_ESTUDIANTE=@local_ID_ESTUDIANTE;
UPDATE ESTUDIANTE.tb_ESTUDIANTE_SEDE SET IS_DELETED=1 WHERE ID_ESTUDIANTE=@local_ID_ESTUDIANTE;

RETURN 1;
END
ELSE
  
BEGIN

RETURN 0;
END



END

-------------------------------------



CREATE PROCEDURE ADMINISTRACION.sp_BORRAR_SEDE
@param_ID_SEDE INT
AS

BEGIN

UPDATE ADMINISTRACION.tb_SEDE SET IS_DELETED=1 WHERE ID_SEDE=@param_ID_SEDE;

RETURN 1;

END

------------------------------------


CREATE PROCEDURE ADMINISTRACION.sp_BORRAR_CURSO
@param_ID_CURSO INT
AS
BEGIN

UPDATE ADMINISTRACION.tb_CURSO SET IS_DELETED=1 WHERE ID_CURSO=@param_ID_CURSO;

RETURN 1;

END

------------------------------------

CREATE PROCEDURE ADMINISTRACION.sp_BORRAR_CARRERA
@param_ID_CARRERA INT
AS
BEGIN

UPDATE ADMINISTRACION.tb_CARRERA SET IS_DELETED=1 WHERE ID_CARRERA=@param_ID_CARRERA;

RETURN 1;

END

------------------------------------


CREATE PROCEDURE ADMINISTRACION.sp_BORRAR_BECA
@param_ID_BECA INT
AS

BEGIN

UPDATE ADMINISTRACION.tb_BECA SET IS_DELETED=1 WHERE ID_BECA=@param_ID_BECA;

RETURN 1;

END

