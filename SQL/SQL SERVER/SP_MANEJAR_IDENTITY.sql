ALTER PROCEDURE AUDITORIA.sp_MANEJAR_IDENTITY
@param_MODO INT
AS
BEGIN

	IF @param_MODO=0

		BEGIN
			SET IDENTITY_INSERT ESTUDIANTE.tb_ESTUDIANTE ON
		END

		ELSE IF @param_MODO=1

			BEGIN

				SET IDENTITY_INSERT ESTUDIANTE.tb_ESTUDIANTE OFF
			END
		ELSE IF @param_MODO=2

			BEGIN

				SET IDENTITY_INSERT ESTUDIANTE.tb_DIRECCION ON
				
			END
		ELSE IF @param_MODO=3

			BEGIN

				SET IDENTITY_INSERT ESTUDIANTE.tb_DIRECCION OFF
				
			END
		ELSE IF @param_MODO=4

			BEGIN
				
				SET IDENTITY_INSERT ESTUDIANTE.tb_TELEFONO ON
			END
		ELSE IF @param_MODO=5

			BEGIN
				SET IDENTITY_INSERT ESTUDIANTE.tb_TELEFONO OFF
			END
END

