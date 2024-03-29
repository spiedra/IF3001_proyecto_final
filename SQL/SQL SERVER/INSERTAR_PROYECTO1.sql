ALTER PROCEDURE ESTUDIANTE.sp_INSERTAR_ESTUDIANTE
@param_NOMBRE_ESTUDIANTE VARCHAR(32),
@param_APELLIDOS_ESTUDIANTE VARCHAR(32),
@param_EDAD INT,
@param_PROMEDIO VARCHAR(32),
@param_CARNE VARCHAR(32),
@param_direccion varchar(32),
@param_sede VARCHAR(32),
@param_tipo_beca VARCHAR(32)
AS
BEGIN

 IF EXISTS (SELECT ID_ESTUDIANTE FROM ESTUDIANTE.tb_ESTUDIANTE WHERE CARNE=@param_CARNE)
  BEGIN
	RETURN 0;
  END
 ELSE
	BEGIN
		INSERT INTO ESTUDIANTE.tb_DIRECCION (DETALLES) VALUES

		(
		@param_direccion

		)

		DECLARE @local_id_direccion INT
		SET @local_id_direccion=SCOPE_IDENTITY()


		INSERT INTO ESTUDIANTE.tb_ESTUDIANTE (NOMBRE_ESTUDIANTE,APELLIDOS_ESTUDIANTE,EDAD,PROMEDIO,CARNE,ID_DIRECCION_ESTUDIANTE) VALUES

		(
		@param_NOMBRE_ESTUDIANTE,
		@param_APELLIDOS_ESTUDIANTE,
		@param_EDAD,
		@param_PROMEDIO,
		@param_CARNE,
		@local_id_direccion
		);

		DECLARE @local_id_estudiante INT=SCOPE_IDENTITY()

		DECLARE @local_id_beca INT=(SELECT ID_BECA FROM ADMINISTRACION.tb_BECA WHERE TIPO_BECA=@param_tipo_beca)
		DECLARE @local_id_sede INT=(SELECT ID_SEDE FROM ADMINISTRACION.tb_SEDE WHERE NOMBRE_SEDE=@param_sede)

		INSERT INTO ESTUDIANTE.tb_ESTUDIANTE_SEDE (ID_ESTUDIANTE, ID_SEDE) VALUES (@local_id_estudiante, @local_id_sede)
		INSERT INTO ESTUDIANTE.tb_ESTUDIANTE_BECA(ID_ESTUDIANTE,ID_BECA) VALUES (@local_id_estudiante, @local_id_beca)
		RETURN 1;
	END



END

---------------------------------------------------------

CREATE PROCEDURE ADMINISTRACION.sp_INSERTAR_BECA
@param_TIPO_BECA INT
AS
BEGIN

	IF EXISTS (SELECT ID_BECA FROM ADMINISTRACION.tb_BECA WHERE TIPO_BECA=@param_TIPO_BECA)
		BEGIN
		RETURN 0;

		END
	ELSE
		BEGIN
			INSERT INTO ADMINISTRACION.tb_BECA (TIPO_BECA) VALUES
			(
			@param_TIPO_BECA
			);

			RETURN 1;
		END
	
END

---------------------------------------------------------

ALTER PROCEDURE ADMINISTRACION.sp_INSERTAR_CARRERA
@param_NOMBRE_CARRERA VARCHAR(32)
AS
BEGIN

	IF EXISTS (SELECT ID_CARRERA FROM ADMINISTRACION.tb_CARRERA WHERE NOMBRE_CARRERA=@param_NOMBRE_CARRERA)
		BEGIN
		RETURN 0;
		END
	    ELSE
			BEGIN
			
				INSERT INTO ADMINISTRACION.tb_CARRERA (NOMBRE_CARRERA) VALUES
				(
				@param_NOMBRE_CARRERA
				)

				RETURN 1;
			END

END

---------------------------------------------------------

ALTER PROCEDURE ADMINISTRACION.sp_INSERTAR_CURSO
@param_NOMBRE_CURSO VARCHAR(32),
@param_CREDITOS INT
AS
BEGIN 

  IF EXISTS (SELECT ID_CURSO FROM ADMINISTRACION.tb_CURSO WHERE NOMBRE_CURSO=@param_NOMBRE_CURSO)
	  BEGIN
	  RETURN 0;
	  END
	  ELSE
		  BEGIN
		  INSERT INTO ADMINISTRACION.tb_CURSO (NOMBRE_CURSO,CREDITOS) VALUES
		  (
		  @param_NOMBRE_CURSO,
		  @param_CREDITOS
		  );

	      RETURN 1;
	  END

	
END

--------------------------------------------------------

ALTER PROCEDURE ADMINISTRACION.sp_INSERTAR_SEDE
@param_NOMBRE_SEDE VARCHAR(32)
AS
BEGIN

   IF EXISTS (SELECT ID_SEDE FROM ADMINISTRACION.tb_SEDE WHERE NOMBRE_SEDE=@param_NOMBRE_SEDE)
	   BEGIN
	   RETURN 0;
	   END
       ELSE
		   BEGIN
			   INSERT INTO ADMINISTRACION.tb_SEDE (NOMBRE_SEDE) VALUES
				(
				@param_NOMBRE_SEDE
				);
				RETURN 1;
		   END

END

CREATE PROCEDURE ESTUDIANTE.sp_INSERTAR_SEDE_ESTUDIANTE
@param_ID_ESTUDIANTE INT,
@param_NOMBRE_SEDE VARCHAR(32)
AS
BEGIN

	DECLARE @local_ID_SEDE INT
	SET @local_ID_SEDE= (SELECT ID_SEDE FROM ADMINISTRACION.tb_SEDE WHERE NOMBRE_SEDE=@param_NOMBRE_SEDE)

	INSERT INTO ADMINISTRACION.tb_ESTUDIANTE_SEDE (ID_ESTUDIANTE,ID_SEDE) VALUES
	(
	@param_ID_ESTUDIANTE,
	@local_ID_SEDE
	)

	RETURN 1;
END


--------------------------------------------------------
ALTER PROCEDURE ESTUDIANTE.sp_INSERTAR_TELEFONO_ESTUDIANTE
@param_NUMERO_TELEFONO VARCHAR(32),
@param_ID_ESTUDIANTE INT
AS

BEGIN

 DECLARE @local_id_telefono_verificar INT
 SET @local_id_telefono_verificar= (SELECT ID_TELEFONO FROM ESTUDIANTE.tb_TELEFONO WHERE NUMERO_TELEFONO=@param_NUMERO_TELEFONO)

 IF EXISTS (SELECT ID_ESTUDIANTE, ID_TELEFONO FROM ESTUDIANTE.tb_ESTUDIANTE_TELEFONO WHERE ID_TELEFONO=@local_id_telefono_verificar AND ID_ESTUDIANTE=@param_ID_ESTUDIANTE)
	BEGIN
		UPDATE ESTUDIANTE.tb_ESTUDIANTE_TELEFONO SET IS_DELETED=0 WHERE ID_ESTUDIANTE=@param_ID_ESTUDIANTE AND ID_TELEFONO=@local_id_telefono_verificar
	END
	ELSE
		BEGIN
			INSERT INTO ESTUDIANTE.tb_TELEFONO (NUMERO_TELEFONO) VALUES
			(
			@param_NUMERO_TELEFONO
			)

			DECLARE @local_ID_TELEFONO INT
			SET @local_ID_TELEFONO=SCOPE_IDENTITY()

			INSERT INTO ESTUDIANTE.tb_ESTUDIANTE_TELEFONO (ID_ESTUDIANTE,ID_TELEFONO) VALUES
			(
			@param_ID_ESTUDIANTE,
			@local_ID_TELEFONO
			)

		END
		RETURN 1;

END


---------------------------------------------------

ALTER PROCEDURE ESTUDIANTE.sp_INSERTAR_CURSO_ESTUDIANTE
@param_ID_ESTUDIANTE INT,
@param_NOMBRE_CURSO VARCHAR(32)
AS

BEGIN 

DECLARE @local_ID_CURSO INT
SET @local_ID_CURSO=(SELECT ID_CURSO FROM ADMINISTRACION.tb_CURSO WHERE NOMBRE_CURSO=@param_NOMBRE_CURSO)


  IF EXISTS (SELECT ID_ESTUDIANTE, ID_CURSO FROM ESTUDIANTE.tb_ESTUDIANTE_CURSO WHERE ID_ESTUDIANTE=@param_ID_ESTUDIANTE AND ID_CURSO=@local_ID_CURSO)
	BEGIN
		UPDATE ESTUDIANTE.tb_ESTUDIANTE_CURSO SET IS_DELETED=0 WHERE ID_ESTUDIANTE=@param_ID_ESTUDIANTE AND ID_CURSO=@local_ID_CURSO
	END
    ELSE
		BEGIN
			INSERT INTO	ESTUDIANTE.tb_ESTUDIANTE_CURSO (ID_ESTUDIANTE,ID_CURSO) VALUES
			(
			@param_ID_ESTUDIANTE,
			@local_ID_CURSO
			)
		END

RETURN 1;
END
-------------------------------------------------

ALTER PROCEDURE ESTUDIANTE.sp_INSERTAR_CARRERA_ESTUDIANTE
@param_ID_ESTUDIANTE INT,
@param_NOMBRE_CARRERA VARCHAR(32)

AS

BEGIN 

DECLARE @local_ID_CARRERA INT
SET @local_ID_CARRERA=(SELECT ID_CARRERA FROM ADMINISTRACION.tb_CARRERA WHERE NOMBRE_CARRERA=@param_NOMBRE_CARRERA)

IF EXISTS (SELECT ID_ESTUDIANTE, ID_CARRERA FROM ESTUDIANTE.tb_ESTUDIANTE_CARRERA WHERE ID_ESTUDIANTE=@param_ID_ESTUDIANTE AND ID_CARRERA=@local_ID_CARRERA)
	BEGIN
		UPDATE ESTUDIANTE.tb_ESTUDIANTE_CARRERA SET IS_DELETED=0 WHERE ID_ESTUDIANTE=@param_ID_ESTUDIANTE AND ID_CARRERA=@local_ID_CARRERA
	END
	ELSE
		BEGIN
			INSERT INTO ESTUDIANTE.tb_ESTUDIANTE_CARRERA (ID_ESTUDIANTE,ID_CARRERA) VALUES
			(
			@param_ID_ESTUDIANTE,
			@local_ID_CARRERA
			)
		END
		RETURN 1;
END