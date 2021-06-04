CREATE PROCEDURE ESTUDIANTE.sp_BORRAR_ESTUDIANTE
@param_ID_ESTUDIANTE INT
AS

BEGIN

UPDATE ESTUDIANTE.tb_ESTUDIANTE SET IS_DELETED=1 WHERE ID_ESTUDIANTE=@param_ID_ESTUDIANTE;

RETURN 1;

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

